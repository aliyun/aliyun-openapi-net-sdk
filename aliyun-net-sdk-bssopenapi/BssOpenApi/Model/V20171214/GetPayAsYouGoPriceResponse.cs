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
	public class GetPayAsYouGoPriceResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetPayAsYouGoPrice_Data data;

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
		public GetPayAsYouGoPrice_Data Data
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

		public class GetPayAsYouGoPrice_Data
		{

			private string currency;

			private List<GetPayAsYouGoPrice_ModuleDetail> moduleDetails;

			private List<GetPayAsYouGoPrice_PromotionDetail> promotionDetails;

			[JsonProperty(PropertyName = "Currency")]
			public string Currency
			{
				get
				{
					return currency;
				}
				set	
				{
					currency = value;
				}
			}

			[JsonProperty(PropertyName = "ModuleDetails")]
			public List<GetPayAsYouGoPrice_ModuleDetail> ModuleDetails
			{
				get
				{
					return moduleDetails;
				}
				set	
				{
					moduleDetails = value;
				}
			}

			[JsonProperty(PropertyName = "PromotionDetails")]
			public List<GetPayAsYouGoPrice_PromotionDetail> PromotionDetails
			{
				get
				{
					return promotionDetails;
				}
				set	
				{
					promotionDetails = value;
				}
			}

			public class GetPayAsYouGoPrice_ModuleDetail
			{

				private float? costAfterDiscount;

				private float? invoiceDiscount;

				private float? unitPrice;

				private float? originalCost;

				private string moduleCode;

				[JsonProperty(PropertyName = "CostAfterDiscount")]
				public float? CostAfterDiscount
				{
					get
					{
						return costAfterDiscount;
					}
					set	
					{
						costAfterDiscount = value;
					}
				}

				[JsonProperty(PropertyName = "InvoiceDiscount")]
				public float? InvoiceDiscount
				{
					get
					{
						return invoiceDiscount;
					}
					set	
					{
						invoiceDiscount = value;
					}
				}

				[JsonProperty(PropertyName = "UnitPrice")]
				public float? UnitPrice
				{
					get
					{
						return unitPrice;
					}
					set	
					{
						unitPrice = value;
					}
				}

				[JsonProperty(PropertyName = "OriginalCost")]
				public float? OriginalCost
				{
					get
					{
						return originalCost;
					}
					set	
					{
						originalCost = value;
					}
				}

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
			}

			public class GetPayAsYouGoPrice_PromotionDetail
			{

				private string promotionDesc;

				private long? promotionId;

				private string promotionName;

				[JsonProperty(PropertyName = "PromotionDesc")]
				public string PromotionDesc
				{
					get
					{
						return promotionDesc;
					}
					set	
					{
						promotionDesc = value;
					}
				}

				[JsonProperty(PropertyName = "PromotionId")]
				public long? PromotionId
				{
					get
					{
						return promotionId;
					}
					set	
					{
						promotionId = value;
					}
				}

				[JsonProperty(PropertyName = "PromotionName")]
				public string PromotionName
				{
					get
					{
						return promotionName;
					}
					set	
					{
						promotionName = value;
					}
				}
			}
		}
	}
}
