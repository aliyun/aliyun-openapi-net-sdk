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
    public class ModifyBgpGroupAttributeRequest : RpcAcsRequest<ModifyBgpGroupAttributeResponse>
    {
        public ModifyBgpGroupAttributeRequest()
            : base("Vpc", "2016-04-28", "ModifyBgpGroupAttribute", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string authKey;

		private long? resourceOwnerId;

		private string clientToken;

		private string bgpGroupId;

		private string description;

		private long? peerAsn;

		private bool? isFakeAsn;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string name;

		private long? localAsn;

		public string AuthKey
		{
			get
			{
				return authKey;
			}
			set	
			{
				authKey = value;
				DictionaryUtil.Add(QueryParameters, "AuthKey", value);
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

		public string BgpGroupId
		{
			get
			{
				return bgpGroupId;
			}
			set	
			{
				bgpGroupId = value;
				DictionaryUtil.Add(QueryParameters, "BgpGroupId", value);
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

		public long? PeerAsn
		{
			get
			{
				return peerAsn;
			}
			set	
			{
				peerAsn = value;
				DictionaryUtil.Add(QueryParameters, "PeerAsn", value.ToString());
			}
		}

		public bool? IsFakeAsn
		{
			get
			{
				return isFakeAsn;
			}
			set	
			{
				isFakeAsn = value;
				DictionaryUtil.Add(QueryParameters, "IsFakeAsn", value.ToString());
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public long? LocalAsn
		{
			get
			{
				return localAsn;
			}
			set	
			{
				localAsn = value;
				DictionaryUtil.Add(QueryParameters, "LocalAsn", value.ToString());
			}
		}

        public override ModifyBgpGroupAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyBgpGroupAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
