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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class UntagResourcesRequest : RpcAcsRequest<UntagResourcesResponse>
    {
        public UntagResourcesRequest()
            : base("Rds", "2014-08-15", "UntagResources", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? all;

		private long? resourceOwnerId;

		private List<string> resourceIds = new List<string>(){ };

		private string resourceOwnerAccount;

		private long? ownerId;

		private string resourceType;

		private List<string> tagKeys = new List<string>(){ };

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

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public List<string> ResourceIds
		{
			get
			{
				return resourceIds;
			}

			set
			{
				resourceIds = value;
				for (int i = 0; i < resourceIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ResourceId." + (i + 1) , resourceIds[i]);
				}
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
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

        public override UntagResourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UntagResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
