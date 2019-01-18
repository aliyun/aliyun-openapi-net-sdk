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
using System.Linq;
using System.Text;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Regions.Location.Model;
using Aliyun.Acs.Core.Transform;

namespace Aliyun.Acs.Core.Regions
{
    class DescribeEndpointServiceImpl : DescribeEndpointService
    {
        private const String DEFAULT_ENDPOINT_TYPE = "openAPI";

        public DescribeEndpointResponse DescribeEndpoint(string regionId, string serviceCode, string endpointType, Credential credential, LocationConfig locationConfig)
        {
            if (string.IsNullOrEmpty(serviceCode))
                return null;

            if (string.IsNullOrEmpty(endpointType))
                endpointType = DEFAULT_ENDPOINT_TYPE;

            DescribeEndpointRequest request = new DescribeEndpointRequest
            {
                AcceptFormat = Http.FormatType.JSON,
                Id = regionId,
                RegionId = locationConfig.RegionId,
                LocationProduct = serviceCode,
                SecurityToken = credential.SecurityToken,
                EndpointType = endpointType
            };

            Signer signer = Signer.GetSigner(new LegacyCredentials(credential));
            ProductDomain domain = new ProductDomain(locationConfig.Product, locationConfig.Endpoint);

            HttpRequest httpRequest = request.SignRequest(signer, credential, FormatType.JSON, domain);
            HttpResponse httpResponse = HttpResponse.GetResponse(httpRequest);
            if (httpResponse.isSuccess())
            {
                String data = Encoding.UTF8.GetString(httpResponse.Content);
                DescribeEndpointResponse response = GetEndpointResponse(data, endpointType);
                if (response == null || string.IsNullOrEmpty(response.Endpoint))
                    return null;

                return response;
            }
            AcsError error = ReadError(httpResponse, FormatType.JSON);
            if (500 <= httpResponse.Status)
            {
                return null;
            }
            return null;
        }

        private DescribeEndpointResponse GetEndpointResponse(String data, String endpointType)
        {
            IReader reader = ReaderFactory.CreateInstance(FormatType.JSON);
            UnmarshallerContext context = new UnmarshallerContext();
            context.ResponseDictionary = reader.Read(data, "DescribeEndpoints");

            int endpointsLength = context.Length("DescribeEndpoints.Endpoints.Length");
            for (int i = 0; i < endpointsLength; i++)
            {
                if (string.Equals(endpointType, context.StringValue("DescribeEndpoints.Endpoints[" + i + "].Type"), StringComparison.InvariantCultureIgnoreCase))
                {
                    DescribeEndpointResponse response = new DescribeEndpointResponse();
                    response.RequestId = context.StringValue("DescribeEndpoints.RequestId");
                    response.Product = context.StringValue("DescribeEndpoints.Endpoints[" + i + "].SerivceCode");
                    response.Endpoint = context.StringValue("DescribeEndpoints.Endpoints[" + i + "].Endpoint");
                    response.RegionId = context.StringValue("DescribeEndpoints.Endpoints[" + i + "].Id");
                    return response;
                }
            }
            return null;
        }

        private AcsError ReadError(HttpResponse httpResponse, FormatType format)
        {
            String responseEndpoint = "Error";
            IReader reader = ReaderFactory.CreateInstance(format);
            UnmarshallerContext context = new UnmarshallerContext();
            String stringContent = GetResponseContent(httpResponse);
            context.ResponseDictionary = reader.Read(stringContent, responseEndpoint);
            AcsError error = new AcsError();
            error.HttpResponse = httpResponse;

            return error;
        }

        private String GetResponseContent(HttpResponse httpResponse)
        {
            String stringContent = null;
            if (null == httpResponse.Encoding)
            {
                stringContent = httpResponse.Content.ToString();
            }
            else
            {
                var e = Encoding.GetEncoding(httpResponse.Encoding);
                stringContent = e.GetString(httpResponse.Content);
            }
            return stringContent;
        }
    }
}
