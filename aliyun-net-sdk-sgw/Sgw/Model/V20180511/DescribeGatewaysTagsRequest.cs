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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.sgw.Transform;
using Aliyun.Acs.sgw.Transform.V20180511;

namespace Aliyun.Acs.sgw.Model.V20180511
{
    public class DescribeGatewaysTagsRequest : RpcAcsRequest<DescribeGatewaysTagsResponse>
    {
        public DescribeGatewaysTagsRequest()
            : base("sgw", "2018-05-11", "DescribeGatewaysTags", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string gatewayIds;

		private string securityToken;

		private string tagCategory;

		private string storageBundleId;

		public string GatewayIds
		{
			get
			{
				return gatewayIds;
			}
			set	
			{
				gatewayIds = value;
				DictionaryUtil.Add(QueryParameters, "GatewayIds", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string TagCategory
		{
			get
			{
				return tagCategory;
			}
			set	
			{
				tagCategory = value;
				DictionaryUtil.Add(QueryParameters, "TagCategory", value);
			}
		}

		public string StorageBundleId
		{
			get
			{
				return storageBundleId;
			}
			set	
			{
				storageBundleId = value;
				DictionaryUtil.Add(QueryParameters, "StorageBundleId", value);
			}
		}

        public override DescribeGatewaysTagsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeGatewaysTagsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
