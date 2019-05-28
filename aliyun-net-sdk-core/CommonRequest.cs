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

using System.Collections.Generic;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core
{
    public class CommonRequest
    {
        public CommonRequest()
        {
            AddHeadParameters("x-sdk-invoke-type", "common");
        }

        public string Product { get; set; }
        public string Version { get; set; }
        public string Action { get; set; }
        public string RegionId { get; set; }
        public string LocationProduct { get; set; }
        public string LocationEndpointType { get; set; }
        public ProtocolType Protocol { get; set; }
        public MethodType? Method { get; set; }
        private FormatType? ContentType { get; set; }
        private byte[] Content { get; set; }
        private string Encoding { get; set; }
        public int TimeoutInMilliSeconds { get; set; }
        public string UriPattern { get; set; }
        public string Domain { get; set; }

        private Dictionary<string, string> queryParameters = new Dictionary<string, string>();
        private Dictionary<string, string> bodyParameters = new Dictionary<string, string>();
        private Dictionary<string, string> headParameters = new Dictionary<string, string>();
        private Dictionary<string, string> pathParameters = new Dictionary<string, string>();

        public Dictionary<string, string> QueryParameters { get { return this.queryParameters; } }

        public Dictionary<string, string> BodyParameters { get { return this.bodyParameters; } }

        public Dictionary<string, string> HeadParameters { get { return this.headParameters; } }

        public Dictionary<string, string> PathParameters { get { return this.pathParameters; } }

        public AcsRequest<CommonResponse> BuildRequest()
        {
            if (UriPattern != null)
            {
                var request = new CommonRoaRequest(Product);
                request.UriPattern = UriPattern;
                request.SetVersion(Version);
                foreach (var entry in PathParameters)
                {
                    request.AddPathParameters(entry.Key, entry.Value);
                }

                FillParams(request);
                return request;
            }
            else
            {
                var request = new CommonRpcRequest(Product);
                request.Version = Version;
                FillParams(request);
                return request;
            }
        }

        private void FillParams<T>(AcsRequest<T> request) where T : AcsResponse
        {
            if (Action != null)
            {
                request.ActionName = Action;
            }

            if (RegionId != null)
            {
                request.RegionId = RegionId;
            }

            if (LocationProduct != null)
            {
                request.LocationProduct = LocationProduct;
            }

            if (LocationEndpointType != null)
            {
                request.LocationEndpointType = LocationEndpointType;
            }

            if (TimeoutInMilliSeconds > 0)
            {
                request.SetReadTimeoutInMilliSeconds(TimeoutInMilliSeconds);
            }

            if (Method != null)
            {
                request.Method = Method;
            }

            // the result of the expression is always 'true' since a value of type 'ProtocolType' is never equal to 'null'
            request.Protocol = Protocol;

            if (Domain != null)
            {
                var productDomain = new ProductDomain(request.Product, Domain);
                request.ProductDomain = productDomain;
            }

            if (Content != null)
            {
                request.SetContent(Content, Encoding, ContentType);
            }

            foreach (var entry in QueryParameters)
            {
                DictionaryUtil.Add(request.QueryParameters, entry.Key, entry.Value);
            }

            foreach (var entry in BodyParameters)
            {
                DictionaryUtil.Add(request.BodyParameters, entry.Key, entry.Value);
            }

            foreach (var entry in HeadParameters)
            {
                request.Headers.Remove(entry.Key);
                DictionaryUtil.Add(request.Headers, entry.Key, entry.Value);
            }
        }

        public void AddQueryParameters(string name, string value)
        {
            DictionaryUtil.Add(QueryParameters, name, value);
        }

        public void AddBodyParameters(string name, string value)
        {
            DictionaryUtil.Add(BodyParameters, name, value);
        }

        public void AddHeadParameters(string name, string value)
        {
            DictionaryUtil.Add(HeadParameters, name, value);
        }

        public void AddPathParameters(string name, string value)
        {
            DictionaryUtil.Add(PathParameters, name, value);
        }

        public void SetContent(byte[] content, string encoding, FormatType? format)
        {
            Content = content;
            Encoding = encoding;
            ContentType = format;
        }
    }
}
