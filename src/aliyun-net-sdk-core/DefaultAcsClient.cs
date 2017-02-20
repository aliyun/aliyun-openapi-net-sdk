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

using System;
using System.Collections.Generic;
using System.Text;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;

namespace Aliyun.Acs.Core
{
    public class DefaultAcsClient : IAcsClient
    {
        private readonly IClientProfile _clientProfile;

        public DefaultAcsClient()
        {
            _clientProfile = DefaultProfile.GetProfile();
        }

        public DefaultAcsClient(IClientProfile profile)
        {
            _clientProfile = profile;
        }

        public int MaxRetryNumber { get; set; } = 3;

        public bool AutoRetry { get; set; } = true;

        public T GetAcsResponse<T>(AcsRequest<T> request) where T : AcsResponse
        {
            var httpResponse = DoAction(request);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber) where T : AcsResponse
        {
            var httpResponse = DoAction(request, autoRetry, maxRetryNumber);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            var httpResponse = DoAction(request, profile);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse
        {
            var httpResponse = DoAction(request, regionId, credential);
            return ParseAcsResponse(request, httpResponse);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request) where T : AcsResponse
        {
            return DoAction(request, AutoRetry, MaxRetryNumber, _clientProfile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber) where T : AcsResponse
        {
            return DoAction(request, autoRetry, maxRetryNumber, _clientProfile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            return DoAction(request, AutoRetry, MaxRetryNumber, profile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse
        {
            ISigner signer = null;
            //FormatType format = FormatType.JSON;
            List<Endpoint> endpoints = null;
            if (null != _clientProfile)
            {
                signer = _clientProfile.GetSigner();
                //format = _clientProfile.GetFormat();
                endpoints = _clientProfile.GetEndpoints();
            }
            return DoAction(request, AutoRetry, MaxRetryNumber, regionId, credential, signer, endpoints);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry,
            int maxRetryNumber, IClientProfile profile) where T : AcsResponse
        {
            if (null == profile)
                throw new ClientException("SDK.InvalidProfile", "No active profile found.");
            var regionId = profile.GetRegionId();
            var credential = profile.GetCredential();
            var signer = profile.GetSigner();
            //FormatType format = profile.GetFormat();
            var endpoints = profile.GetEndpoints();

            return DoAction(request, autoRetry, maxRetryNumber, regionId, credential, signer, endpoints);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, string regionId,
            Credential credential, ISigner signer, List<Endpoint> endpoints) where T : AcsResponse
        {
            var format = request.AcceptFormat;
            if (null == request.RegionId)
                request.RegionId = regionId;
            var domain = Endpoint.FindProductDomain(regionId, request.Product, endpoints, this);
            if (null == domain)
                throw new ClientException("SDK.InvalidRegionId", "Can not find endpoint to access.");
            var httpRequest = request.SignRequest(signer, credential, format, domain);
            var retryTimes = 1;
            var response = HttpResponse.GetResponse(httpRequest);
            while (500 <= response.Status && autoRetry && retryTimes < maxRetryNumber)
            {
                httpRequest = request.SignRequest(signer, credential, format, domain);
                response = HttpResponse.GetResponse(httpRequest);
                retryTimes++;
            }

            return response;
        }

        private static T ParseAcsResponse<T>(AcsRequest<T> request, HttpResponse httpResponse) where T : AcsResponse
        {
            var format = httpResponse.ContentType;

            if (httpResponse.IsSuccess())
                return ReadResponse(request, httpResponse, format);
            var error = ReadError(httpResponse, format);
            if (null != error.ErrorCode)
                if (500 <= httpResponse.Status)
                    throw new ServerException(error.ErrorCode, error.ErrorMessage, error.RequestId);
                else
                    throw new ClientException(error.ErrorCode, error.ErrorMessage, error.RequestId);
            var t = Activator.CreateInstance<T>();
            return t;
        }

        private static T ReadResponse<T>(AcsRequest<T> request, HttpResponse httpResponse, FormatType? format) where T : AcsResponse
        {
            var reader = ReaderFactory.CreateInstance(format);
            var context = new UnmarshallerContext();
            var body = Encoding.UTF8.GetString(httpResponse.Content);
            context.ResponseDictionary = reader.Read(body, request.ActionName);
            context.HttpResponse = httpResponse;
            return request.GetResponse(context);
        }

        private static AcsError ReadError(HttpRequest httpResponse, FormatType? format)
        {
            var responseEndpoint = "Error";
            var reader = ReaderFactory.CreateInstance(format);
            var context = new UnmarshallerContext();
            var body = Encoding.UTF8.GetString(httpResponse.Content);
            context.ResponseDictionary = null == reader ? new Dictionary<string, string>() : reader.Read(body, responseEndpoint);
            return AcsErrorUnmarshaller.Unmarshall(context);
        }
    }
}