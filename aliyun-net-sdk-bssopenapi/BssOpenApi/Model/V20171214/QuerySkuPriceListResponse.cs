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
	public class QuerySkuPriceListResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private QuerySkuPriceList_Data data;

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
		public QuerySkuPriceList_Data Data
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

		public class QuerySkuPriceList_Data
		{

			private QuerySkuPriceList_SkuPricePage skuPricePage;

			[JsonProperty(PropertyName = "SkuPricePage")]
			public QuerySkuPriceList_SkuPricePage SkuPricePage
			{
				get
				{
					return skuPricePage;
				}
				set	
				{
					skuPricePage = value;
				}
			}

			public class QuerySkuPriceList_SkuPricePage
			{

				private int? totalCount;

				private string nextPageToken;

				private List<QuerySkuPriceList_SkuPricePageDTO> skuPriceList;

				[JsonProperty(PropertyName = "TotalCount")]
				public int? TotalCount
				{
					get
					{
						return totalCount;
					}
					set	
					{
						totalCount = value;
					}
				}

				[JsonProperty(PropertyName = "NextPageToken")]
				public string NextPageToken
				{
					get
					{
						return nextPageToken;
					}
					set	
					{
						nextPageToken = value;
					}
				}

				[JsonProperty(PropertyName = "SkuPriceList")]
				public List<QuerySkuPriceList_SkuPricePageDTO> SkuPriceList
				{
					get
					{
						return skuPriceList;
					}
					set	
					{
						skuPriceList = value;
					}
				}

				public class QuerySkuPriceList_SkuPricePageDTO
				{

					private string skuCode;

					private string skuFactorMap;

					private List<QuerySkuPriceList_CSkuPriceDTO> cskuPriceList;

					[JsonProperty(PropertyName = "SkuCode")]
					public string SkuCode
					{
						get
						{
							return skuCode;
						}
						set	
						{
							skuCode = value;
						}
					}

					[JsonProperty(PropertyName = "SkuFactorMap")]
					public string SkuFactorMap
					{
						get
						{
							return skuFactorMap;
						}
						set	
						{
							skuFactorMap = value;
						}
					}

					[JsonProperty(PropertyName = "CskuPriceList")]
					public List<QuerySkuPriceList_CSkuPriceDTO> CskuPriceList
					{
						get
						{
							return cskuPriceList;
						}
						set	
						{
							cskuPriceList = value;
						}
					}

					public class QuerySkuPriceList_CSkuPriceDTO
					{

						private string cskuCode;

						private string currency;

						private string usageUnit;

						private string priceType;

						private string priceMode;

						private string price;

						private string priceUnit;

						private List<QuerySkuPriceList_RangeDTO> rangeList;

						[JsonProperty(PropertyName = "CskuCode")]
						public string CskuCode
						{
							get
							{
								return cskuCode;
							}
							set	
							{
								cskuCode = value;
							}
						}

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

						[JsonProperty(PropertyName = "UsageUnit")]
						public string UsageUnit
						{
							get
							{
								return usageUnit;
							}
							set	
							{
								usageUnit = value;
							}
						}

						[JsonProperty(PropertyName = "PriceType")]
						public string PriceType
						{
							get
							{
								return priceType;
							}
							set	
							{
								priceType = value;
							}
						}

						[JsonProperty(PropertyName = "PriceMode")]
						public string PriceMode
						{
							get
							{
								return priceMode;
							}
							set	
							{
								priceMode = value;
							}
						}

						[JsonProperty(PropertyName = "Price")]
						public string Price
						{
							get
							{
								return price;
							}
							set	
							{
								price = value;
							}
						}

						[JsonProperty(PropertyName = "PriceUnit")]
						public string PriceUnit
						{
							get
							{
								return priceUnit;
							}
							set	
							{
								priceUnit = value;
							}
						}

						[JsonProperty(PropertyName = "RangeList")]
						public List<QuerySkuPriceList_RangeDTO> RangeList
						{
							get
							{
								return rangeList;
							}
							set	
							{
								rangeList = value;
							}
						}

						public class QuerySkuPriceList_RangeDTO
						{

							private string factorCode;

							private string min;

							private string max;

							private string type;

							[JsonProperty(PropertyName = "FactorCode")]
							public string FactorCode
							{
								get
								{
									return factorCode;
								}
								set	
								{
									factorCode = value;
								}
							}

							[JsonProperty(PropertyName = "Min")]
							public string Min
							{
								get
								{
									return min;
								}
								set	
								{
									min = value;
								}
							}

							[JsonProperty(PropertyName = "Max")]
							public string Max
							{
								get
								{
									return max;
								}
								set	
								{
									max = value;
								}
							}

							[JsonProperty(PropertyName = "Type")]
							public string Type
							{
								get
								{
									return type;
								}
								set	
								{
									type = value;
								}
							}
						}
					}
				}
			}
		}
	}
}
