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
using System.Runtime.CompilerServices;
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Regions.Location.Model;
using Aliyun.Acs.Core.Transform;

[assembly : InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Aliyun.Acs.Core.Regions
{
    internal class DescribeEndpointServiceImpl : DescribeEndpointService
    {
        private const string DEFAULT_ENDPOINT_TYPE = "openAPI";

        public DescribeEndpointResponse DescribeEndpoint(string regionId, string serviceCode, string endpointType,
            Credential credential, LocationConfig locationConfig)
        {
            if (string.IsNullOrEmpty(serviceCode))
            {
                return null;
            }

            if (string.IsNullOrEmpty(endpointType))
            {
                endpointType = DEFAULT_ENDPOINT_TYPE;
            }

            var request = new DescribeEndpointRequest
            {
                AcceptFormat = FormatType.JSON,
                Id = regionId,
                RegionId = locationConfig.RegionId,
                LocationProduct = serviceCode,
                SecurityToken = credential.SecurityToken,
                EndpointType = endpointType
            };

            var signer = Signer.GetSigner(new LegacyCredentials(credential));
            var domain = new ProductDomain(locationConfig.Product, locationConfig.Endpoint);

            var httpRequest = request.SignRequest(signer, credential, FormatType.JSON, domain);
            httpRequest.SetConnectTimeoutInMilliSeconds(100000);
            httpRequest.SetReadTimeoutInMilliSeconds(100000);
            var httpResponse = GetResponse(httpRequest);

            if (httpResponse.isSuccess())
            {
                var data = Encoding.UTF8.GetString(httpResponse.Content);
                var response = GetEndpointResponse(data, endpointType);
                if (response == null || string.IsNullOrEmpty(response.Endpoint))
                {
                    return null;
                }

                return response;
            }

            var error = ReadError(httpResponse, FormatType.JSON);
            if (500 <= httpResponse.Status)
            {
                return null;
            }

            return null;
        }

        private DescribeEndpointResponse GetEndpointResponse(string data, string endpointType)
        {
            var reader = ReaderFactory.CreateInstance(FormatType.JSON);
            var context = new UnmarshallerContext();
            context.ResponseDictionary = reader.Read(data, "DescribeEndpoints");

            var endpointsLength = context.Length("DescribeEndpoints.Endpoints.Length");
            for (var i = 0; i < endpointsLength; i++)
            {
                if (string.Equals(endpointType, context.StringValue("DescribeEndpoints.Endpoints[" + i + "].Type"),
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    var response = new DescribeEndpointResponse();
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
            var responseEndpoint = "Error";
            var reader = ReaderFactory.CreateInstance(format);
            var context = new UnmarshallerContext();
            var stringContent = GetResponseContent(httpResponse);
            context.ResponseDictionary = reader.Read(stringContent, responseEndpoint);
            var error = new AcsError();
            error.HttpResponse = httpResponse;

            return error;
        }

        private string GetResponseContent(HttpResponse httpResponse)
        {
            string stringContent = null;
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

        public virtual HttpResponse GetResponse(HttpRequest httpRequest)
        {
            return HttpResponse.GetResponse(httpRequest);
        }
    }
}
