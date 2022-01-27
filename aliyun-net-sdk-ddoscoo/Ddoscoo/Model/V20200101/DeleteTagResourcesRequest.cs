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
using Aliyun.Acs.ddoscoo;
using Aliyun.Acs.ddoscoo.Transform;
using Aliyun.Acs.ddoscoo.Transform.V20200101;

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
    public class DeleteTagResourcesRequest : RpcAcsRequest<DeleteTagResourcesResponse>
    {
        public DeleteTagResourcesRequest()
            : base("ddoscoo", "2020-01-01", "DeleteTagResources")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceGroupId;

		private bool? all;

		private string resourceType;

		private List<string> tagKeys = new List<string>(){ };

		private List<string> resourceIdss = new List<string>(){ };

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

		public bool? All
		{
			get
			{
				return all;
			}
			set	
			{
				all = value;
				DictionaryUtil.Add(QueryParameters, "All", value.ToString());
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public List<string> TagKeys
		{
			get
			{
				return tagKeys;
			}

			set
			{
				tagKeys = value;
				for (int i = 0; i < tagKeys.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TagKey." + (i + 1) , tagKeys[i]);
				}
			}
		}

		public List<string> ResourceIdss
		{
			get
			{
				return resourceIdss;
			}

			set
			{
				resourceIdss = value;
				for (int i = 0; i < resourceIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ResourceIds." + (i + 1) , resourceIdss[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteTagResourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteTagResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
