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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class ModifyVpcPrefixListRequest : RpcAcsRequest<ModifyVpcPrefixListResponse>
    {
        public ModifyVpcPrefixListRequest()
            : base("Vpc", "2016-04-28", "ModifyVpcPrefixList", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private int? maxEntries;

		private List<string> removePrefixListEntrys = new List<string>(){ };

		private string prefixListId;

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> addPrefixListEntrys = new List<string>(){ };

		private string prefixListName;

		private string prefixListDescription;

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

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public int? MaxEntries
		{
			get
			{
				return maxEntries;
			}
			set	
			{
				maxEntries = value;
				DictionaryUtil.Add(QueryParameters, "MaxEntries", value.ToString());
			}
		}

		public List<string> RemovePrefixListEntrys
		{
			get
			{
				return removePrefixListEntrys;
			}

			set
			{
				removePrefixListEntrys = value;
				if(removePrefixListEntrys != null)
				{
					for (int depth1 = 0; depth1 < removePrefixListEntrys.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"RemovePrefixListEntry." + (depth1 + 1), removePrefixListEntrys[depth1]);
						DictionaryUtil.Add(QueryParameters,"RemovePrefixListEntry." + (depth1 + 1), removePrefixListEntrys[depth1]);
					}
				}
			}
		}

		public string PrefixListId
		{
			get
			{
				return prefixListId;
			}
			set	
			{
				prefixListId = value;
				DictionaryUtil.Add(QueryParameters, "PrefixListId", value);
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
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

		public List<string> AddPrefixListEntrys
		{
			get
			{
				return addPrefixListEntrys;
			}

			set
			{
				addPrefixListEntrys = value;
				if(addPrefixListEntrys != null)
				{
					for (int depth1 = 0; depth1 < addPrefixListEntrys.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"AddPrefixListEntry." + (depth1 + 1), addPrefixListEntrys[depth1]);
						DictionaryUtil.Add(QueryParameters,"AddPrefixListEntry." + (depth1 + 1), addPrefixListEntrys[depth1]);
					}
				}
			}
		}

		public string PrefixListName
		{
			get
			{
				return prefixListName;
			}
			set	
			{
				prefixListName = value;
				DictionaryUtil.Add(QueryParameters, "PrefixListName", value);
			}
		}

		public string PrefixListDescription
		{
			get
			{
				return prefixListDescription;
			}
			set	
			{
				prefixListDescription = value;
				DictionaryUtil.Add(QueryParameters, "PrefixListDescription", value);
			}
		}

		public class RemovePrefixListEntry
		{

			private string cidr;

			private string description;

			public string Cidr
			{
				get
				{
					return cidr;
				}
				set	
				{
					cidr = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}

		public class AddPrefixListEntry
		{

			private string cidr;

			private string description;

			public string Cidr
			{
				get
				{
					return cidr;
				}
				set	
				{
					cidr = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyVpcPrefixListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyVpcPrefixListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
