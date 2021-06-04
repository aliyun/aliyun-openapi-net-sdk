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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyPrefixListRequest : RpcAcsRequest<ModifyPrefixListResponse>
    {
        public ModifyPrefixListRequest()
            : base("Ecs", "2014-05-26", "ModifyPrefixList", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string description;

		private string prefixListId;

		private List<AddEntry> addEntrys = new List<AddEntry>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string prefixListName;

		private List<RemoveEntry> removeEntrys = new List<RemoveEntry>(){ };

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
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

		public List<AddEntry> AddEntrys
		{
			get
			{
				return addEntrys;
			}

			set
			{
				addEntrys = value;
				for (int i = 0; i < addEntrys.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AddEntry." + (i + 1) + ".Cidr", addEntrys[i].Cidr);
					DictionaryUtil.Add(QueryParameters,"AddEntry." + (i + 1) + ".Description", addEntrys[i].Description);
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

		public List<RemoveEntry> RemoveEntrys
		{
			get
			{
				return removeEntrys;
			}

			set
			{
				removeEntrys = value;
				for (int i = 0; i < removeEntrys.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RemoveEntry." + (i + 1) + ".Cidr", removeEntrys[i].Cidr);
				}
			}
		}

		public class AddEntry
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

		public class RemoveEntry
		{

			private string cidr;

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
		}

        public override ModifyPrefixListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyPrefixListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
