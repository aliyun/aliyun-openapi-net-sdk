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
    public class ModifyRouterInterfaceAttributeRequest : RpcAcsRequest<ModifyRouterInterfaceAttributeResponse>
    {
        public ModifyRouterInterfaceAttributeRequest()
            : base("Vpc", "2016-04-28", "ModifyRouterInterfaceAttribute", "vpc", "openAPI")
        {
        }

		private string oppositeRouterId;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string description;

		private string healthCheckTargetIp;

		private long? ownerId;

		private string routerInterfaceId;

		private long? oppositeInterfaceOwnerId;

		private string regionId;

		private string healthCheckSourceIp;

		private string name;

		private string oppositeRouterType;

		private string action;

		private string oppositeInterfaceId;

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

		public string RouterInterfaceId
		{
			get
			{
				return routerInterfaceId;
			}
			set	
			{
				routerInterfaceId = value;
				DictionaryUtil.Add(QueryParameters, "RouterInterfaceId", value);
			}
		}

		public long? OppositeInterfaceOwnerId
		{
			get
			{
				return oppositeInterfaceOwnerId;
			}
			set	
			{
				oppositeInterfaceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "OppositeInterfaceOwnerId", value.ToString());
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

        public override ModifyRouterInterfaceAttributeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyRouterInterfaceAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}