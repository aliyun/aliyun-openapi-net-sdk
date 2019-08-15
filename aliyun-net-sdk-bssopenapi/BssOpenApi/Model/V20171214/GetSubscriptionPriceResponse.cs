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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class GetSubscriptionPriceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private GetSubscriptionPrice_Data data;

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

		public GetSubscriptionPrice_Data Data
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

		public class GetSubscriptionPrice_Data
		{

			private float? originalPrice;

			private float? discountPrice;

			private float? tradePrice;

			private string currency;

			private int? quantity;

			private List<GetSubscriptionPrice_ModuleDetail> moduleDetails;

			private List<GetSubscriptionPrice_PromotionDetail> promotionDetails;

			public float? OriginalPrice
			{
				get
				{
					return originalPrice;
				}
				set	
				{
					originalPrice = value;
				}
			}

			public float? DiscountPrice
			{
				get
				{
					return discountPrice;
				}
				set	
				{
					discountPrice = value;
				}
			}

			public float? TradePrice
			{
				get
				{
					return tradePrice;
				}
				set	
				{
					tradePrice = value;
				}
			}

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

			public int? Quantity
			{
				get
				{
					return quantity;
				}
				set	
				{
					quantity = value;
				}
			}

			public List<GetSubscriptionPrice_ModuleDetail> ModuleDetails
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

			public List<GetSubscriptionPrice_PromotionDetail> PromotionDetails
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

			public class GetSubscriptionPrice_ModuleDetail
			{

				private string moduleCode;

				private float? originalCost;

				private float? invoiceDiscount;

				private float? costAfterDiscount;

				private float? unitPrice;

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
			}

			public class GetSubscriptionPrice_PromotionDetail
			{

				private string promotionName;

				private string promotionDesc;

				private long? promotionId;

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
			}
		}
	}
}
