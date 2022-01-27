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
    public class ModifyIPv6TranslatorEntryRequest : RpcAcsRequest<ModifyIPv6TranslatorEntryResponse>
    {
        public ModifyIPv6TranslatorEntryRequest()
            : base("Vpc", "2016-04-28", "ModifyIPv6TranslatorEntry", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? backendIpv4Port;

		private long? resourceOwnerId;

		private string entryName;

		private string aclStatus;

		private int? entryBandwidth;

		private string aclType;

		private int? allocateIpv6Port;

		private string entryDescription;

		private string backendIpv4Addr;

		private string aclId;

		private string ipv6TranslatorEntryId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string transProtocol;

		public int? BackendIpv4Port
		{
			get
			{
				return backendIpv4Port;
			}
			set	
			{
				backendIpv4Port = value;
				DictionaryUtil.Add(QueryParameters, "BackendIpv4Port", value.ToString());
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

		public string EntryName
		{
			get
			{
				return entryName;
			}
			set	
			{
				entryName = value;
				DictionaryUtil.Add(QueryParameters, "EntryName", value);
			}
		}

		public string AclStatus
		{
			get
			{
				return aclStatus;
			}
			set	
			{
				aclStatus = value;
				DictionaryUtil.Add(QueryParameters, "AclStatus", value);
			}
		}

		public int? EntryBandwidth
		{
			get
			{
				return entryBandwidth;
			}
			set	
			{
				entryBandwidth = value;
				DictionaryUtil.Add(QueryParameters, "EntryBandwidth", value.ToString());
			}
		}

		public string AclType
		{
			get
			{
				return aclType;
			}
			set	
			{
				aclType = value;
				DictionaryUtil.Add(QueryParameters, "AclType", value);
			}
		}

		public int? AllocateIpv6Port
		{
			get
			{
				return allocateIpv6Port;
			}
			set	
			{
				allocateIpv6Port = value;
				DictionaryUtil.Add(QueryParameters, "AllocateIpv6Port", value.ToString());
			}
		}

		public string EntryDescription
		{
			get
			{
				return entryDescription;
			}
			set	
			{
				entryDescription = value;
				DictionaryUtil.Add(QueryParameters, "EntryDescription", value);
			}
		}

		public string BackendIpv4Addr
		{
			get
			{
				return backendIpv4Addr;
			}
			set	
			{
				backendIpv4Addr = value;
				DictionaryUtil.Add(QueryParameters, "BackendIpv4Addr", value);
			}
		}

		public string AclId
		{
			get
			{
				return aclId;
			}
			set	
			{
				aclId = value;
				DictionaryUtil.Add(QueryParameters, "AclId", value);
			}
		}

		public string Ipv6TranslatorEntryId
		{
			get
			{
				return ipv6TranslatorEntryId;
			}
			set	
			{
				ipv6TranslatorEntryId = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6TranslatorEntryId", value);
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

		public string TransProtocol
		{
			get
			{
				return transProtocol;
			}
			set	
			{
				transProtocol = value;
				DictionaryUtil.Add(QueryParameters, "TransProtocol", value);
			}
		}

        public override ModifyIPv6TranslatorEntryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyIPv6TranslatorEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
