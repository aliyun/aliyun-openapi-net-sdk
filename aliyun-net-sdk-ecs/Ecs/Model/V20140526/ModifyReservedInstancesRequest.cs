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
    public class ModifyReservedInstancesRequest : RpcAcsRequest<ModifyReservedInstancesResponse>
    {
        public ModifyReservedInstancesRequest()
            : base("Ecs", "2014-05-26", "ModifyReservedInstances", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private List<string> configurations = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> reservedInstanceIds = new List<string>(){ };

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

		[JsonProperty(PropertyName = "Configuration")]
		public List<string> Configurations
		{
			get
			{
				return configurations;
			}

			set
			{
				configurations = value;
				if(configurations != null)
				{
					for (int depth1 = 0; depth1 < configurations.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Configuration." + (depth1 + 1), configurations[depth1]);
						DictionaryUtil.Add(QueryParameters,"Configuration." + (depth1 + 1), configurations[depth1]);
						DictionaryUtil.Add(QueryParameters,"Configuration." + (depth1 + 1), configurations[depth1]);
						DictionaryUtil.Add(QueryParameters,"Configuration." + (depth1 + 1), configurations[depth1]);
						DictionaryUtil.Add(QueryParameters,"Configuration." + (depth1 + 1), configurations[depth1]);
					}
				}
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

		[JsonProperty(PropertyName = "ReservedInstanceId")]
		public List<string> ReservedInstanceIds
		{
			get
			{
				return reservedInstanceIds;
			}

			set
			{
				reservedInstanceIds = value;
			}
		}

		public class Configuration
		{

			private string reservedInstanceName;

			private string zoneId;

			private string scope;

			private string instanceType;

			private int? instanceAmount;

			[JsonProperty(PropertyName = "ReservedInstanceName")]
			public string ReservedInstanceName
			{
				get
				{
					return reservedInstanceName;
				}
				set	
				{
					reservedInstanceName = value;
				}
			}

			[JsonProperty(PropertyName = "ZoneId")]
			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			[JsonProperty(PropertyName = "Scope")]
			public string Scope
			{
				get
				{
					return scope;
				}
				set	
				{
					scope = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceType")]
			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceAmount")]
			public int? InstanceAmount
			{
				get
				{
					return instanceAmount;
				}
				set	
				{
					instanceAmount = value;
				}
			}
		}

        public override ModifyReservedInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyReservedInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
