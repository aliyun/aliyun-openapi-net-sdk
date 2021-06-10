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
    public class ModifyRouterInterfaceAttributeRequest : RpcAcsRequest<ModifyRouterInterfaceAttributeResponse>
    {
        public ModifyRouterInterfaceAttributeRequest()
            : base("Vpc", "2016-04-28", "ModifyRouterInterfaceAttribute", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string oppositeRouterId;

		private long? resourceOwnerId;

		private string description;

		private string healthCheckTargetIp;

		private string oppositeInterfaceId;

		private int? hcThreshold;

		private string resourceOwnerAccount;

		private bool? deleteHealthCheckIp;

		private long? ownerId;

		private string routerInterfaceId;

		private long? oppositeInterfaceOwnerId;

		private string healthCheckSourceIp;

		private string name;

		private string oppositeRouterType;

		private int? hcRate;

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

		public int? HcThreshold
		{
			get
			{
				return hcThreshold;
			}
			set	
			{
				hcThreshold = value;
				DictionaryUtil.Add(QueryParameters, "HcThreshold", value.ToString());
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

		public bool? DeleteHealthCheckIp
		{
			get
			{
				return deleteHealthCheckIp;
			}
			set	
			{
				deleteHealthCheckIp = value;
				DictionaryUtil.Add(QueryParameters, "DeleteHealthCheckIp", value.ToString());
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

		public int? HcRate
		{
			get
			{
				return hcRate;
			}
			set	
			{
				hcRate = value;
				DictionaryUtil.Add(QueryParameters, "HcRate", value.ToString());
			}
		}

        public override ModifyRouterInterfaceAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyRouterInterfaceAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
