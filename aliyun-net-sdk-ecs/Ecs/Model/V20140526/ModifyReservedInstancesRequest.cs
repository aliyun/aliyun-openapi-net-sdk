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
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private List<Configuration> configurations = new List<Configuration>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> reservedInstanceIds = new List<string>(){ };

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

		public List<Configuration> Configurations
		{
			get
			{
				return configurations;
			}

			set
			{
				configurations = value;
				for (int i = 0; i < configurations.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Configuration." + (i + 1) + ".ZoneId", configurations[i].ZoneId);
					DictionaryUtil.Add(QueryParameters,"Configuration." + (i + 1) + ".ReservedInstanceName", configurations[i].ReservedInstanceName);
					DictionaryUtil.Add(QueryParameters,"Configuration." + (i + 1) + ".InstanceType", configurations[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"Configuration." + (i + 1) + ".Scope", configurations[i].Scope);
					DictionaryUtil.Add(QueryParameters,"Configuration." + (i + 1) + ".InstanceAmount", configurations[i].InstanceAmount);
				}
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

		public List<string> ReservedInstanceIds
		{
			get
			{
				return reservedInstanceIds;
			}

			set
			{
				reservedInstanceIds = value;
				for (int i = 0; i < reservedInstanceIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ReservedInstanceId." + (i + 1) , reservedInstanceIds[i]);
				}
			}
		}

		public class Configuration
		{

			private string zoneId;

			private string reservedInstanceName;

			private string instanceType;

			private string scope;

			private int? instanceAmount;

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
