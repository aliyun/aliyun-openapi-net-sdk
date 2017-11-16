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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class CreateRouterInterfaceRequest : RpcAcsRequest<CreateRouterInterfaceResponse>
    {
        public CreateRouterInterfaceRequest()
            : base("Vpc", "2016-04-28", "CreateRouterInterface", "vpc", "openAPI")
        {
        }

		private string accessPointId;

		private string oppositeRouterId;

		private string oppositeAccessPointId;

		private long? resourceOwnerId;

		private string role;

		private string clientToken;

		private string resourceOwnerAccount;

		private string oppositeRegionId;

		private string ownerAccount;

		private string healthCheckTargetIp;

		private string description;

		private long? ownerId;

		private string spec;

		private string oppositeInterfaceOwnerId;

		private string routerType;

		private string regionId;

		private string healthCheckSourceIp;

		private string routerId;

		private string oppositeRouterType;

		private string name;

		private string action;

		private string userCidr;

		private string oppositeInterfaceId;

		public string AccessPointId
		{
			get
			{
				return accessPointId;
			}
			set	
			{
				accessPointId = value;
				DictionaryUtil.Add(QueryParameters, "AccessPointId", value);
			}
		}

		public string OppositeRouterId
		{
			get
			{
				return oppositeRouterId;
			}
			set	
			{
				oppositeRouterId = value;
				DictionaryUtil.Add(QueryParameters, "OppositeRouterId", value);
			}
		}

		public string OppositeAccessPointId
		{
			get
			{
				return oppositeAccessPointId;
			}
			set	
			{
				oppositeAccessPointId = value;
				DictionaryUtil.Add(QueryParameters, "OppositeAccessPointId", value);
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

		public string Role
		{
			get
			{
				return role;
			}
			set	
			{
				role = value;
				DictionaryUtil.Add(QueryParameters, "Role", value);
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

		public string OppositeRegionId
		{
			get
			{
				return oppositeRegionId;
			}
			set	
			{
				oppositeRegionId = value;
				DictionaryUtil.Add(QueryParameters, "OppositeRegionId", value);
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

		public string HealthCheckTargetIp
		{
			get
			{
				return healthCheckTargetIp;
			}
			set	
			{
				healthCheckTargetIp = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckTargetIp", value);
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

		public string Spec
		{
			get
			{
				return spec;
			}
			set	
			{
				spec = value;
				DictionaryUtil.Add(QueryParameters, "Spec", value);
			}
		}

		public string OppositeInterfaceOwnerId
		{
			get
			{
				return oppositeInterfaceOwnerId;
			}
			set	
			{
				oppositeInterfaceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "OppositeInterfaceOwnerId", value);
			}
		}

		public string RouterType
		{
			get
			{
				return routerType;
			}
			set	
			{
				routerType = value;
				DictionaryUtil.Add(QueryParameters, "RouterType", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string HealthCheckSourceIp
		{
			get
			{
				return healthCheckSourceIp;
			}
			set	
			{
				healthCheckSourceIp = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckSourceIp", value);
			}
		}

		public string RouterId
		{
			get
			{
				return routerId;
			}
			set	
			{
				routerId = value;
				DictionaryUtil.Add(QueryParameters, "RouterId", value);
			}
		}

		public string OppositeRouterType
		{
			get
			{
				return oppositeRouterType;
			}
			set	
			{
				oppositeRouterType = value;
				DictionaryUtil.Add(QueryParameters, "OppositeRouterType", value);
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string UserCidr
		{
			get
			{
				return userCidr;
			}
			set	
			{
				userCidr = value;
				DictionaryUtil.Add(QueryParameters, "UserCidr", value);
			}
		}

		public string OppositeInterfaceId
		{
			get
			{
				return oppositeInterfaceId;
			}
			set	
			{
				oppositeInterfaceId = value;
				DictionaryUtil.Add(QueryParameters, "OppositeInterfaceId", value);
			}
		}

        public override CreateRouterInterfaceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateRouterInterfaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}