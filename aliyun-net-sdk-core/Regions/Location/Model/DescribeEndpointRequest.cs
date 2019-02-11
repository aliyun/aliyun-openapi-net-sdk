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

using Aliyun.Acs.Core.Regions.Location.Transform;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Regions.Location.Model
{
    public class DescribeEndpointRequest : RpcAcsRequest<DescribeEndpointResponse>
    {

        public DescribeEndpointRequest() : base("Location", "2015-06-12", "DescribeEndpoints")
        {

        }

        private String id;

        private String locationProduct;

        private String endpointType;

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                DictionaryUtil.Add(QueryParameters, "Id", value);
            }
        }

        public string EndpointType
        {
            get
            {
                return endpointType;
            }
            set
            {
                endpointType = value;
                DictionaryUtil.Add(QueryParameters, "Type", value);
            }
        }

        public new string LocationProduct
        {
            get
            {
                return locationProduct;
            }
            set
            {
                locationProduct = value;
                DictionaryUtil.Add(QueryParameters, "ServiceCode", value);
            }
        }

        public override DescribeEndpointResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return null;
        }
    }
}
