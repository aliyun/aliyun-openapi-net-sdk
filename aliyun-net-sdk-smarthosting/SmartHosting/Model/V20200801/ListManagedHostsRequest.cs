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
using Aliyun.Acs.SmartHosting.Transform;
using Aliyun.Acs.SmartHosting.Transform.V20200801;

namespace Aliyun.Acs.SmartHosting.Model.V20200801
{
    public class ListManagedHostsRequest : RpcAcsRequest<ListManagedHostsResponse>
    {
        public ListManagedHostsRequest()
            : base("SmartHosting", "2020-08-01", "ListManagedHosts", "smarthosting", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string hostType;

		private string mode;

		private string resourceGroupId;

		private string nextToken;

		private List<Tag> tags = new List<Tag>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private List<string> managedHostIds = new List<string>(){ };

		private long? ownerId;

		private string managedPrivateSpaceId;

		private string zoneId;

		private int? maxResults;

		private string managedHostName;

		private string status;

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

		public string HostType
		{
			get
			{
				return hostType;
			}
			set	
			{
				hostType = value;
				DictionaryUtil.Add(QueryParameters, "HostType", value);
			}
		}

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
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

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public List<string> ManagedHostIds
		{
			get
			{
				return managedHostIds;
			}

			set
			{
				managedHostIds = value;
				for (int i = 0; i < managedHostIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ManagedHostId." + (i + 1) , managedHostIds[i]);
				}
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

		public string ManagedPrivateSpaceId
		{
			get
			{
				return managedPrivateSpaceId;
			}
			set	
			{
				managedPrivateSpaceId = value;
				DictionaryUtil.Add(QueryParameters, "ManagedPrivateSpaceId", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public string ManagedHostName
		{
			get
			{
				return managedHostName;
			}
			set	
			{
				managedHostName = value;
				DictionaryUtil.Add(QueryParameters, "ManagedHostName", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public class Tag
		{

			private string key;

			private string value_;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

        public override ListManagedHostsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListManagedHostsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
