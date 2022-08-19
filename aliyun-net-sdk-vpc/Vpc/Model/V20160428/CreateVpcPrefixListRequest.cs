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
    public class CreateVpcPrefixListRequest : RpcAcsRequest<CreateVpcPrefixListResponse>
    {
        public CreateVpcPrefixListRequest()
            : base("Vpc", "2016-04-28", "CreateVpcPrefixList", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> prefixListEntryss = new List<string>(){ };

		private long? resourceOwnerId;

		private string clientToken;

		private int? maxEntries;

		private string ipVersion;

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string prefixListName;

		private string prefixListDescription;

		public List<string> PrefixListEntryss
		{
			get
			{
				return prefixListEntryss;
			}

			set
			{
				prefixListEntryss = value;
				if(prefixListEntryss != null)
				{
					for (int depth1 = 0; depth1 < prefixListEntryss.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"PrefixListEntrys." + (depth1 + 1), prefixListEntryss[depth1]);
						DictionaryUtil.Add(QueryParameters,"PrefixListEntrys." + (depth1 + 1), prefixListEntryss[depth1]);
					}
				}
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

		public string IpVersion
		{
			get
			{
				return ipVersion;
			}
			set	
			{
				ipVersion = value;
				DictionaryUtil.Add(QueryParameters, "IpVersion", value);
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

		public class PrefixListEntrys
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

        public override CreateVpcPrefixListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVpcPrefixListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
