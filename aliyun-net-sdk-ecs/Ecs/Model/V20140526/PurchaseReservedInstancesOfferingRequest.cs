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
    public class PurchaseReservedInstancesOfferingRequest : RpcAcsRequest<PurchaseReservedInstancesOfferingResponse>
    {
        public PurchaseReservedInstancesOfferingRequest()
            : base("Ecs", "2014-05-26", "PurchaseReservedInstancesOffering", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string description;

		private string platform;

		private string resourceGroupId;

		private string scope;

		private string instanceType;

		private List<string> tags = new List<string>(){ };

		private int? period;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string periodUnit;

		private string offeringType;

		private string zoneId;

		private string reservedInstanceName;

		private int? instanceAmount;

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

		[JsonProperty(PropertyName = "Platform")]
		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceGroupId")]
		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
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
				DictionaryUtil.Add(QueryParameters, "Scope", value);
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
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		[JsonProperty(PropertyName = "Tag")]
		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "Period")]
		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
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

		[JsonProperty(PropertyName = "PeriodUnit")]
		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
			}
		}

		[JsonProperty(PropertyName = "OfferingType")]
		public string OfferingType
		{
			get
			{
				return offeringType;
			}
			set	
			{
				offeringType = value;
				DictionaryUtil.Add(QueryParameters, "OfferingType", value);
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
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

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
				DictionaryUtil.Add(QueryParameters, "ReservedInstanceName", value);
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
				DictionaryUtil.Add(QueryParameters, "InstanceAmount", value.ToString());
			}
		}

		public class Tag
		{

			private string key;

			private string value_;

			[JsonProperty(PropertyName = "Key")]
			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			[JsonProperty(PropertyName = "Value")]
			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

        public override PurchaseReservedInstancesOfferingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PurchaseReservedInstancesOfferingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
