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
    public class RevokeSecurityGroupEgressRequest : RpcAcsRequest<RevokeSecurityGroupEgressResponse>
    {
        public RevokeSecurityGroupEgressRequest()
            : base("Ecs", "2014-05-26", "RevokeSecurityGroupEgress", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string nicType;

		private long? resourceOwnerId;

		private string sourcePortRange;

		private string clientToken;

		private string destPrefixListId;

		private string securityGroupId;

		private string description;

		private string ipv6DestCidrIp;

		private string ipv6SourceCidrIp;

		private string policy;

		private string portRange;

		private string resourceOwnerAccount;

		private string ipProtocol;

		private string ownerAccount;

		private string sourceCidrIp;

		private string destGroupId;

		private long? ownerId;

		private string destGroupOwnerAccount;

		private string priority;

		private string destCidrIp;

		private long? destGroupOwnerId;

		[JsonProperty(PropertyName = "NicType")]
		public string NicType
		{
			get
			{
				return nicType;
			}
			set	
			{
				nicType = value;
				DictionaryUtil.Add(QueryParameters, "NicType", value);
			}
		}

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

		[JsonProperty(PropertyName = "SourcePortRange")]
		public string SourcePortRange
		{
			get
			{
				return sourcePortRange;
			}
			set	
			{
				sourcePortRange = value;
				DictionaryUtil.Add(QueryParameters, "SourcePortRange", value);
			}
		}

		[JsonProperty(PropertyName = "ClientToken")]
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

		[JsonProperty(PropertyName = "DestPrefixListId")]
		public string DestPrefixListId
		{
			get
			{
				return destPrefixListId;
			}
			set	
			{
				destPrefixListId = value;
				DictionaryUtil.Add(QueryParameters, "DestPrefixListId", value);
			}
		}

		[JsonProperty(PropertyName = "SecurityGroupId")]
		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
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

		[JsonProperty(PropertyName = "Ipv6DestCidrIp")]
		public string Ipv6DestCidrIp
		{
			get
			{
				return ipv6DestCidrIp;
			}
			set	
			{
				ipv6DestCidrIp = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6DestCidrIp", value);
			}
		}

		[JsonProperty(PropertyName = "Ipv6SourceCidrIp")]
		public string Ipv6SourceCidrIp
		{
			get
			{
				return ipv6SourceCidrIp;
			}
			set	
			{
				ipv6SourceCidrIp = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6SourceCidrIp", value);
			}
		}

		[JsonProperty(PropertyName = "Policy")]
		public string Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
				DictionaryUtil.Add(QueryParameters, "Policy", value);
			}
		}

		[JsonProperty(PropertyName = "PortRange")]
		public string PortRange
		{
			get
			{
				return portRange;
			}
			set	
			{
				portRange = value;
				DictionaryUtil.Add(QueryParameters, "PortRange", value);
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

		[JsonProperty(PropertyName = "IpProtocol")]
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

		[JsonProperty(PropertyName = "SourceCidrIp")]
		public string SourceCidrIp
		{
			get
			{
				return sourceCidrIp;
			}
			set	
			{
				sourceCidrIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceCidrIp", value);
			}
		}

		[JsonProperty(PropertyName = "DestGroupId")]
		public string DestGroupId
		{
			get
			{
				return destGroupId;
			}
			set	
			{
				destGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DestGroupId", value);
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

		[JsonProperty(PropertyName = "DestGroupOwnerAccount")]
		public string DestGroupOwnerAccount
		{
			get
			{
				return destGroupOwnerAccount;
			}
			set	
			{
				destGroupOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "DestGroupOwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "Priority")]
		public string Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value);
			}
		}

		[JsonProperty(PropertyName = "DestCidrIp")]
		public string DestCidrIp
		{
			get
			{
				return destCidrIp;
			}
			set	
			{
				destCidrIp = value;
				DictionaryUtil.Add(QueryParameters, "DestCidrIp", value);
			}
		}

		[JsonProperty(PropertyName = "DestGroupOwnerId")]
		public long? DestGroupOwnerId
		{
			get
			{
				return destGroupOwnerId;
			}
			set	
			{
				destGroupOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "DestGroupOwnerId", value.ToString());
			}
		}

        public override RevokeSecurityGroupEgressResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RevokeSecurityGroupEgressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
