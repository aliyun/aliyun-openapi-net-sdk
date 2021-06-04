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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class CreatePrefixListRequest : RpcAcsRequest<CreatePrefixListResponse>
    {
        public CreatePrefixListRequest()
            : base("Ecs", "2014-05-26", "CreatePrefixList", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string description;

		private int? maxEntries;

		private string addressFamily;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string prefixListName;

		private List<Entry> entrys = new List<Entry>(){ };

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

		public string AddressFamily
		{
			get
			{
				return addressFamily;
			}
			set	
			{
				addressFamily = value;
				DictionaryUtil.Add(QueryParameters, "AddressFamily", value);
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

		public List<Entry> Entrys
		{
			get
			{
				return entrys;
			}

			set
			{
				entrys = value;
				for (int i = 0; i < entrys.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Entry." + (i + 1) + ".Cidr", entrys[i].Cidr);
					DictionaryUtil.Add(QueryParameters,"Entry." + (i + 1) + ".Description", entrys[i].Description);
				}
			}
		}

		public class Entry
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

        public override CreatePrefixListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePrefixListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
