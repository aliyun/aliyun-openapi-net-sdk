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
using Aliyun.Acs.waf_openapi.Transform;
using Aliyun.Acs.waf_openapi.Transform.V20190910;

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
    public class DescribeDomainBasicConfigsRequest : RpcAcsRequest<DescribeDomainBasicConfigsResponse>
    {
        public DescribeDomainBasicConfigsRequest()
            : base("waf-openapi", "2019-09-10", "DescribeDomainBasicConfigs", "waf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? pageNumber;

		private string resourceGroupId;

		private int? pageSize;

		private string accessType;

		private int? cloudNativeProductId;

		private string instanceId;

		private string domainKey;

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string AccessType
		{
			get
			{
				return accessType;
			}
			set	
			{
				accessType = value;
				DictionaryUtil.Add(QueryParameters, "AccessType", value);
			}
		}

		public int? CloudNativeProductId
		{
			get
			{
				return cloudNativeProductId;
			}
			set	
			{
				cloudNativeProductId = value;
				DictionaryUtil.Add(QueryParameters, "CloudNativeProductId", value.ToString());
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string DomainKey
		{
			get
			{
				return domainKey;
			}
			set	
			{
				domainKey = value;
				DictionaryUtil.Add(QueryParameters, "DomainKey", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeDomainBasicConfigsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDomainBasicConfigsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
