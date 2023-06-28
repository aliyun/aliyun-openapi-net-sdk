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
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class GetSubscriptionPriceRequest : RpcAcsRequest<GetSubscriptionPriceResponse>
    {
        public GetSubscriptionPriceRequest()
            : base("BssOpenApi", "2017-12-14", "GetSubscriptionPrice", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productCode;

		private int? quantity;

		private string subscriptionType;

		private List<string> moduleLists = new List<string>(){ };

		private long? ownerId;

		private string productType;

		private int? servicePeriodQuantity;

		private string instanceId;

		private string servicePeriodUnit;

		private string region;

		private string orderType;

		[JsonProperty(PropertyName = "ProductCode")]
		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
			}
		}

		[JsonProperty(PropertyName = "Quantity")]
		public int? Quantity
		{
			get
			{
				return quantity;
			}
			set	
			{
				quantity = value;
				DictionaryUtil.Add(QueryParameters, "Quantity", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SubscriptionType")]
		public string SubscriptionType
		{
			get
			{
				return subscriptionType;
			}
			set	
			{
				subscriptionType = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionType", value);
			}
		}

		[JsonProperty(PropertyName = "ModuleList")]
		public List<string> ModuleLists
		{
			get
			{
				return moduleLists;
			}

			set
			{
				moduleLists = value;
				if(moduleLists != null)
				{
					for (int depth1 = 0; depth1 < moduleLists.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ModuleList." + (depth1 + 1), moduleLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"ModuleList." + (depth1 + 1), moduleLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"ModuleList." + (depth1 + 1), moduleLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"ModuleList." + (depth1 + 1), moduleLists[depth1]);
					}
				}
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

		[JsonProperty(PropertyName = "ProductType")]
		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		[JsonProperty(PropertyName = "ServicePeriodQuantity")]
		public int? ServicePeriodQuantity
		{
			get
			{
				return servicePeriodQuantity;
			}
			set	
			{
				servicePeriodQuantity = value;
				DictionaryUtil.Add(QueryParameters, "ServicePeriodQuantity", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "InstanceId")]
		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "ServicePeriodUnit")]
		public string ServicePeriodUnit
		{
			get
			{
				return servicePeriodUnit;
			}
			set	
			{
				servicePeriodUnit = value;
				DictionaryUtil.Add(QueryParameters, "ServicePeriodUnit", value);
			}
		}

		[JsonProperty(PropertyName = "Region")]
		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		[JsonProperty(PropertyName = "OrderType")]
		public string OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "OrderType", value);
			}
		}

		public class ModuleList
		{

			private string moduleCode;

			private int? moduleStatus;

			private string tag;

			private string config;

			[JsonProperty(PropertyName = "ModuleCode")]
			public string ModuleCode
			{
				get
				{
					return moduleCode;
				}
				set	
				{
					moduleCode = value;
				}
			}

			[JsonProperty(PropertyName = "ModuleStatus")]
			public int? ModuleStatus
			{
				get
				{
					return moduleStatus;
				}
				set	
				{
					moduleStatus = value;
				}
			}

			[JsonProperty(PropertyName = "Tag")]
			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			[JsonProperty(PropertyName = "Config")]
			public string Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}
		}

        public override GetSubscriptionPriceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetSubscriptionPriceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
