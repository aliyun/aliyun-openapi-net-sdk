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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Core.Regions;

namespace Aliyun.Acs.Core
{
    public class CommonRequest
    {
        public String Product { get; set; }
        public String Version { get; set; }
        public String Action { get; set; }
        public String RegionId { get; set; }
        public String LocationProduct { get; set; }
        public String LocationEndpointType { get; set; }
        public ProtocolType Protocol { get; set; }
        private Dictionary<String, String> queryParameters = new Dictionary<String, String>();
        private Dictionary<String, String> bodyParameters = new Dictionary<String, String>();
        private Dictionary<String, String> headParameters = new Dictionary<String, String>();

        public MethodType? Method { get; set; }
        private FormatType? ContentType { get; set; }
        private byte[] Content { get; set; }
        private String Encoding { get; set; }
        public int TimeoutInMilliSeconds { get; set; }

        public String UriPattern { get; set; }
        private Dictionary<string, string> pathParameters = new Dictionary<string, string>();

        public String Domain { get; set; }

        public CommonRequest()
        {
            AddHeadParameters("x-sdk-invoke-type", "common");
        }

        public AcsRequest<CommonResponse> BuildRequest()
        {
            if (UriPattern != null)
            {
                CommonRoaRequest request = new CommonRoaRequest(Product);
                request.UriPattern = UriPattern;
                request.SetVersion(Version);
                foreach (var entry in pathParameters)
                {
                    request.AddPathParameters(entry.Key, entry.Value);
                }

                FillParams(request);
                return request;
            }
            else
            {
                CommonRpcRequest request = new CommonRpcRequest(Product);
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
                request.TimeoutInMilliSeconds = TimeoutInMilliSeconds;
            }
            if (Method != null)
            {
                request.Method = Method;
            }
            if (Protocol != null)
            {
                request.Protocol = Protocol;
            }
            if (Domain != null)
            {
                ProductDomain productDomain = new ProductDomain(request.Product, Domain);
                request.ProductDomain = productDomain;
            }
            if (Content != null)
            {
                request.SetContent(Content, Encoding, ContentType);
            }
            foreach (var entry in queryParameters)
            {
                DictionaryUtil.Add(request.QueryParameters, entry.Key, entry.Value);
            }
            foreach (var entry in bodyParameters)
            {
                DictionaryUtil.Add(request.BodyParameters, entry.Key, entry.Value);
            }
            foreach (var entry in headParameters)
            {
                request.Headers.Remove(entry.Key);
                DictionaryUtil.Add(request.Headers, entry.Key, entry.Value);
            }
        }

        public void AddQueryParameters(string name, string value)
        {
            DictionaryUtil.Add(queryParameters, name, value);
        }

        public void AddBodyParameters(string name, string value)
        {
            DictionaryUtil.Add(bodyParameters, name, value);
        }

        public void AddHeadParameters(string name, string value)
        {
            DictionaryUtil.Add(headParameters, name, value);
        }

        public void AddPathParameters(string name, string value)
        {
            DictionaryUtil.Add(pathParameters, name, value);
        }

        public void SetContent(byte[] content, String encoding, FormatType? format)
        {
            Content = content;
            Encoding = encoding;
            ContentType = format;
        }
    }
}
