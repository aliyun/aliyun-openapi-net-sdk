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
    public class CreateIPBlockRequest : RpcAcsRequest<CreateIPBlockResponse>
    {
        public CreateIPBlockRequest()
            : base("waf-openapi", "2019-09-10", "CreateIPBlock", "waf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string domainList;

		private string iPList;

		private string resourceGroupId;

		private long? blockInterval;

		private string operationType;

		private string instanceId;

		public string DomainList
		{
			get
			{
				return domainList;
			}
			set	
			{
				domainList = value;
				DictionaryUtil.Add(QueryParameters, "DomainList", value);
			}
		}

		public string IPList
		{
			get
			{
				return iPList;
			}
			set	
			{
				iPList = value;
				DictionaryUtil.Add(QueryParameters, "IPList", value);
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

		public long? BlockInterval
		{
			get
			{
				return blockInterval;
			}
			set	
			{
				blockInterval = value;
				DictionaryUtil.Add(QueryParameters, "BlockInterval", value.ToString());
			}
		}

		public string OperationType
		{
			get
			{
				return operationType;
			}
			set	
			{
				operationType = value;
				DictionaryUtil.Add(QueryParameters, "OperationType", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateIPBlockResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateIPBlockResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
