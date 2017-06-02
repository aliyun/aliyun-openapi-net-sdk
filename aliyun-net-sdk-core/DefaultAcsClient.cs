/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;
using System.Collections.Generic;
using System;

namespace Aliyun.Acs.Core
{
    public class DefaultAcsClient : IAcsClient
    {

        private int maxRetryNumber = 3;
        private bool autoRetry = true;
        private IClientProfile clientProfile = null;
        private int timeoutInMilliSeconds = 100000; // Default 100 Seconds

        public DefaultAcsClient()
        {
            this.clientProfile = DefaultProfile.GetProfile();
        }

        public DefaultAcsClient(IClientProfile profile)
        {
            this.clientProfile = profile;
        }

        public T GetAcsResponse<T>(AcsRequest<T> request) where T : AcsResponse
        {
            HttpResponse httpResponse = this.DoAction(request);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber) where T : AcsResponse
        {
            HttpResponse httpResponse = this.DoAction(request, autoRetry, maxRetryNumber);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            HttpResponse httpResponse = this.DoAction(request, profile);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse
        {
            HttpResponse httpResponse = this.DoAction(request, regionId, credential);
            return ParseAcsResponse(request, httpResponse);
        }

        public CommonResponse DoCommonAction(CommonRequest request)
        {
            HttpResponse httpResponse = this.DoAction(request);
            String data = System.Text.Encoding.UTF8.GetString(httpResponse.Content);

            CommonResponse response = new CommonResponse();
            response.Data = data;
            response.HttpResponse = httpResponse;

            return response;
        }

        private T ParseAcsResponse<T>(AcsRequest<T> request, HttpResponse httpResponse) where T : AcsResponse
        {
            FormatType? format = httpResponse.ContentType;

            if (httpResponse.isSuccess())
            {
                return ReadResponse<T>(request, httpResponse, format);
            }
            else
            {
                AcsError error = ReadError(request, httpResponse, format);
                if (null != error.ErrorCode)
                {
                    if (500 <= httpResponse.Status)
                    {
                        throw new ServerException(error.ErrorCode, error.ErrorMessage, error.RequestId);
                    }
                    else
                    {
                        throw new ClientException(error.ErrorCode, error.ErrorMessage, error.RequestId);
                    }
                }
                else
                {
                    T t = System.Activator.CreateInstance<T>();
                    t.HttpResponse = httpResponse;
                    return t;
                }

            }
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request) where T : AcsResponse
        {
            return DoAction(request, autoRetry, maxRetryNumber, this.clientProfile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber) where T : AcsResponse
        {
            return DoAction(request, autoRetry, maxRetryNumber, this.clientProfile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            return DoAction(request, this.autoRetry, this.maxRetryNumber, profile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse
        {
            ISigner signer = null;
            FormatType format = FormatType.JSON;
            List<Endpoint> endpoints = null;
            if (null != this.clientProfile)
            {
                signer = clientProfile.GetSigner();
                format = clientProfile.GetFormat();
                endpoints = clientProfile.GetEndpoints(regionId, request.Product, credential, request.LocationProduct); ;
            }
            return DoAction(request, autoRetry, this.maxRetryNumber, regionId, credential, signer, format, endpoints);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry,
                int maxRetryNumber, IClientProfile profile) where T : AcsResponse
        {
            if (null == profile)
            {
                throw new ClientException("SDK.InvalidProfile", "No active profile found.");
            }
            string regionId = profile.GetRegionId();
            if (null != request.RegionId)
            {
                regionId = request.RegionId;
            }
            Credential credential = profile.GetCredential();
            ISigner signer = profile.GetSigner();
            FormatType? format = profile.GetFormat();
            List<Endpoint> endpoints = profile.GetEndpoints(regionId, request.Product, credential, request.LocationProduct);

            return DoAction(request, autoRetry, maxRetryNumber, regionId, credential, signer, format, endpoints);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, string regionId,
            Credential credential, ISigner signer, FormatType? format, List<Endpoint> endpoints) where T : AcsResponse
        {
            FormatType? requestFormatType = request.AcceptFormat;
            if (null != requestFormatType)
            {
                format = requestFormatType;
            }
            if (null == request.RegionId)
            {
                request.RegionId = regionId;
            }
            ProductDomain domain = Endpoint.FindProductDomain(regionId, request.Product, endpoints, this);
            if (null == domain)
            {
                throw new ClientException("SDK.InvalidRegionId", "Can not find endpoint to access.");
            }
            HttpRequest httpRequest = request.SignRequest(signer, credential, format, domain);
            int retryTimes = 1;
            HttpResponse response = HttpResponse.GetResponse(httpRequest, timeoutInMilliSeconds);
            while (500 <= response.Status && autoRetry && retryTimes < maxRetryNumber)
            {
                httpRequest = request.SignRequest(signer, credential, format, domain);
                response = HttpResponse.GetResponse(httpRequest, timeoutInMilliSeconds);
                retryTimes++;
            }
            return response;
        }

        private T ReadResponse<T>(AcsRequest<T> request, HttpResponse httpResponse, FormatType? format) where T : AcsResponse
        {
            IReader reader = ReaderFactory.CreateInstance(format);
            UnmarshallerContext context = new UnmarshallerContext();
            string body = System.Text.Encoding.UTF8.GetString(httpResponse.Content);
            context.ResponseDictionary = reader.Read(body, request.ActionName);
            context.HttpResponse = httpResponse;
            return request.GetResponse(context);
        }

        private AcsError ReadError<T>(AcsRequest<T> request, HttpResponse httpResponse, FormatType? format) where T : AcsResponse
        {
            string responseEndpoint = "Error";
            IReader reader = ReaderFactory.CreateInstance(format);
            UnmarshallerContext context = new UnmarshallerContext();
            string body = System.Text.Encoding.Default.GetString(httpResponse.Content);
            if (null == reader)
            {
                context.ResponseDictionary = new Dictionary<string, string>();
            }
            else
            {
                context.ResponseDictionary = reader.Read(body, responseEndpoint);
            }
            return AcsErrorUnmarshaller.Unmarshall(context);
        }

        public int MaxRetryNumber
        {
            get { return maxRetryNumber; }
            set { maxRetryNumber = value; }
        }

        public bool AutoRetry
        {
            get { return autoRetry; }
            set { autoRetry = value; }
        }

        public int TimeoutInMilliSeconds
        {
            get { return timeoutInMilliSeconds; }
            set { timeoutInMilliSeconds = value; }
        }

    }
}
