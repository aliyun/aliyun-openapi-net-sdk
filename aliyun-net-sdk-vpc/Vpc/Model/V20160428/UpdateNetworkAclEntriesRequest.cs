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
    public class UpdateNetworkAclEntriesRequest : RpcAcsRequest<UpdateNetworkAclEntriesResponse>
    {
        public UpdateNetworkAclEntriesRequest()
            : base("Vpc", "2016-04-28", "UpdateNetworkAclEntries", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private List<string> egressAclEntriess = new List<string>(){ };

		private string clientToken;

		private string networkAclId;

		private bool? updateIngressAclEntries;

		private string resourceOwnerAccount;

		private bool? updateEgressAclEntries;

		private long? ownerId;

		private List<string> ingressAclEntriess = new List<string>(){ };

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

		public List<string> EgressAclEntriess
		{
			get
			{
				return egressAclEntriess;
			}

			set
			{
				egressAclEntriess = value;
				if(egressAclEntriess != null)
				{
					for (int depth1 = 0; depth1 < egressAclEntriess.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"EgressAclEntries." + (depth1 + 1), egressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"EgressAclEntries." + (depth1 + 1), egressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"EgressAclEntries." + (depth1 + 1), egressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"EgressAclEntries." + (depth1 + 1), egressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"EgressAclEntries." + (depth1 + 1), egressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"EgressAclEntries." + (depth1 + 1), egressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"EgressAclEntries." + (depth1 + 1), egressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"EgressAclEntries." + (depth1 + 1), egressAclEntriess[depth1]);
					}
				}
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

		public string NetworkAclId
		{
			get
			{
				return networkAclId;
			}
			set	
			{
				networkAclId = value;
				DictionaryUtil.Add(QueryParameters, "NetworkAclId", value);
			}
		}

		public bool? UpdateIngressAclEntries
		{
			get
			{
				return updateIngressAclEntries;
			}
			set	
			{
				updateIngressAclEntries = value;
				DictionaryUtil.Add(QueryParameters, "UpdateIngressAclEntries", value.ToString());
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

		public bool? UpdateEgressAclEntries
		{
			get
			{
				return updateEgressAclEntries;
			}
			set	
			{
				updateEgressAclEntries = value;
				DictionaryUtil.Add(QueryParameters, "UpdateEgressAclEntries", value.ToString());
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

		public List<string> IngressAclEntriess
		{
			get
			{
				return ingressAclEntriess;
			}

			set
			{
				ingressAclEntriess = value;
				if(ingressAclEntriess != null)
				{
					for (int depth1 = 0; depth1 < ingressAclEntriess.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"IngressAclEntries." + (depth1 + 1), ingressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"IngressAclEntries." + (depth1 + 1), ingressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"IngressAclEntries." + (depth1 + 1), ingressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"IngressAclEntries." + (depth1 + 1), ingressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"IngressAclEntries." + (depth1 + 1), ingressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"IngressAclEntries." + (depth1 + 1), ingressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"IngressAclEntries." + (depth1 + 1), ingressAclEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"IngressAclEntries." + (depth1 + 1), ingressAclEntriess[depth1]);
					}
				}
			}
		}

		public class EgressAclEntries
		{

			private string networkAclEntryId;

			private string entryType;

			private string networkAclEntryName;

			private string policy;

			private string description;

			private string protocol;

			private string destinationCidrIp;

			private string port;

			public string NetworkAclEntryId
			{
				get
				{
					return networkAclEntryId;
				}
				set	
				{
					networkAclEntryId = value;
				}
			}

			public string EntryType
			{
				get
				{
					return entryType;
				}
				set	
				{
					entryType = value;
				}
			}

			public string NetworkAclEntryName
			{
				get
				{
					return networkAclEntryName;
				}
				set	
				{
					networkAclEntryName = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
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

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string DestinationCidrIp
			{
				get
				{
					return destinationCidrIp;
				}
				set	
				{
					destinationCidrIp = value;
				}
			}

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}
		}

		public class IngressAclEntries
		{

			private string networkAclEntryId;

			private string entryType;

			private string networkAclEntryName;

			private string policy;

			private string sourceCidrIp;

			private string description;

			private string protocol;

			private string port;

			public string NetworkAclEntryId
			{
				get
				{
					return networkAclEntryId;
				}
				set	
				{
					networkAclEntryId = value;
				}
			}

			public string EntryType
			{
				get
				{
					return entryType;
				}
				set	
				{
					entryType = value;
				}
			}

			public string NetworkAclEntryName
			{
				get
				{
					return networkAclEntryName;
				}
				set	
				{
					networkAclEntryName = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}

			public string SourceCidrIp
			{
				get
				{
					return sourceCidrIp;
				}
				set	
				{
					sourceCidrIp = value;
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

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}
		}

        public override UpdateNetworkAclEntriesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateNetworkAclEntriesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
