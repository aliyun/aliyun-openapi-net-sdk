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

		private List<string> addEntrys = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string prefixListName;

		private List<string> removeEntrys = new List<string>(){ };

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "Description")]
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

		[JsonProperty(PropertyName = "PrefixListId")]
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

		[JsonProperty(PropertyName = "AddEntry")]
		public List<string> AddEntrys
		{
			get
			{
				return addEntrys;
			}

			set
			{
				addEntrys = value;
				if(addEntrys != null)
				{
					for (int depth1 = 0; depth1 < addEntrys.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"AddEntry." + (depth1 + 1), addEntrys[depth1]);
						DictionaryUtil.Add(QueryParameters,"AddEntry." + (depth1 + 1), addEntrys[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "PrefixListName")]
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

		[JsonProperty(PropertyName = "RemoveEntry")]
		public List<string> RemoveEntrys
		{
			get
			{
				return removeEntrys;
			}

			set
			{
				removeEntrys = value;
				if(removeEntrys != null)
				{
					for (int depth1 = 0; depth1 < removeEntrys.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"RemoveEntry." + (depth1 + 1), removeEntrys[depth1]);
					}
				}
			}
		}

		public class AddEntry
		{

			private string description;

			private string cidr;

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "Cidr")]
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

		public class RemoveEntry
		{

			private string cidr;

			[JsonProperty(PropertyName = "Cidr")]
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
