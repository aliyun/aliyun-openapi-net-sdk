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
    public class ModifyForwardEntryRequest : RpcAcsRequest<ModifyForwardEntryResponse>
    {
        public ModifyForwardEntryRequest()
            : base("Ecs", "2014-05-26", "ModifyForwardEntry", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string forwardTableId;

		private string internalIp;

		private string forwardEntryId;

		private string externalIp;

		private string resourceOwnerAccount;

		private string ipProtocol;

		private string ownerAccount;

		private long? ownerId;

		private string internalPort;

		private string externalPort;

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

		public string ForwardTableId
		{
			get
			{
				return forwardTableId;
			}
			set	
			{
				forwardTableId = value;
				DictionaryUtil.Add(QueryParameters, "ForwardTableId", value);
			}
		}

		public string InternalIp
		{
			get
			{
				return internalIp;
			}
			set	
			{
				internalIp = value;
				DictionaryUtil.Add(QueryParameters, "InternalIp", value);
			}
		}

		public string ForwardEntryId
		{
			get
			{
				return forwardEntryId;
			}
			set	
			{
				forwardEntryId = value;
				DictionaryUtil.Add(QueryParameters, "ForwardEntryId", value);
			}
		}

		public string ExternalIp
		{
			get
			{
				return externalIp;
			}
			set	
			{
				externalIp = value;
				DictionaryUtil.Add(QueryParameters, "ExternalIp", value);
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

		public string IpProtocol
		{
			get
			{
				return ipProtocol;
			}
			set	
			{
				ipProtocol = value;
				DictionaryUtil.Add(QueryParameters, "IpProtocol", value);
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

		public string InternalPort
		{
			get
			{
				return internalPort;
			}
			set	
			{
				internalPort = value;
				DictionaryUtil.Add(QueryParameters, "InternalPort", value);
			}
		}

		public string ExternalPort
		{
			get
			{
				return externalPort;
			}
			set	
			{
				externalPort = value;
				DictionaryUtil.Add(QueryParameters, "ExternalPort", value);
			}
		}

        public override ModifyForwardEntryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyForwardEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
