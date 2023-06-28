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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QuerySavingsPlansDiscountResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private QuerySavingsPlansDiscount_Data data;

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "Code")]
		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public QuerySavingsPlansDiscount_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QuerySavingsPlansDiscount_Data
		{

			private string hostId;

			private List<QuerySavingsPlansDiscount_SavingsPlansDiscountResponse> items;

			[JsonProperty(PropertyName = "HostId")]
			public string HostId
			{
				get
				{
					return hostId;
				}
				set	
				{
					hostId = value;
				}
			}

			[JsonProperty(PropertyName = "Items")]
			public List<QuerySavingsPlansDiscount_SavingsPlansDiscountResponse> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class QuerySavingsPlansDiscount_SavingsPlansDiscountResponse
			{

				private string commodityName;

				private string moduleName;

				private string spnType;

				private string payMode;

				private string cycle;

				private string region;

				private string spec;

				private string discountRate;

				private string contractDiscountRate;

				[JsonProperty(PropertyName = "CommodityName")]
				public string CommodityName
				{
					get
					{
						return commodityName;
					}
					set	
					{
						commodityName = value;
					}
				}

				[JsonProperty(PropertyName = "ModuleName")]
				public string ModuleName
				{
					get
					{
						return moduleName;
					}
					set	
					{
						moduleName = value;
					}
				}

				[JsonProperty(PropertyName = "SpnType")]
				public string SpnType
				{
					get
					{
						return spnType;
					}
					set	
					{
						spnType = value;
					}
				}

				[JsonProperty(PropertyName = "PayMode")]
				public string PayMode
				{
					get
					{
						return payMode;
					}
					set	
					{
						payMode = value;
					}
				}

				[JsonProperty(PropertyName = "Cycle")]
				public string Cycle
				{
					get
					{
						return cycle;
					}
					set	
					{
						cycle = value;
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
					}
				}

				[JsonProperty(PropertyName = "Spec")]
				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				[JsonProperty(PropertyName = "DiscountRate")]
				public string DiscountRate
				{
					get
					{
						return discountRate;
					}
					set	
					{
						discountRate = value;
					}
				}

				[JsonProperty(PropertyName = "ContractDiscountRate")]
				public string ContractDiscountRate
				{
					get
					{
						return contractDiscountRate;
					}
					set	
					{
						contractDiscountRate = value;
					}
				}
			}
		}
	}
}
