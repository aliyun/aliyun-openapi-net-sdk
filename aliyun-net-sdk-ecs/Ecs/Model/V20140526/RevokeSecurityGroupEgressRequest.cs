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
            : base("Ecs", "2014-05-26", "RevokeSecurityGroupEgress")
        {
        }

	private long? ownerId;

	private string resourceOwnerAccount;

	private long? resourceOwnerId;

	private string securityGroupId;

	private string ipProtocol;

	private string portRange;

	private string destGroupId;

	private string destGroupOwnerAccount;

	private string destCidrIp;

	private string policy;

	private string nicType;

	private string ownerAccount;

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

        public override RevokeSecurityGroupEgressResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RevokeSecurityGroupEgressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}