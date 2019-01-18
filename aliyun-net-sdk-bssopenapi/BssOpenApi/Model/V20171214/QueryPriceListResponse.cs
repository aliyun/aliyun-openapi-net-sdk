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
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryPriceListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private QueryPriceList_Data data;

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

		public QueryPriceList_Data Data
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

		public class QueryPriceList_Data
		{

			private string currency;

			private List<QueryPriceList_Module> modules;

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

			public List<QueryPriceList_Module> Modules
			{
				get
				{
					return modules;
				}
				set	
				{
					modules = value;
				}
			}

			public class QueryPriceList_Module
			{

				private string moduleCode;

				private string region;

				private string config;

				private string priceUnitQuantity;

				private string priceUnit;

				private List<QueryPriceList_TierPrice> tierPrices;

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

				public string PriceUnitQuantity
				{
					get
					{
						return priceUnitQuantity;
					}
					set	
					{
						priceUnitQuantity = value;
					}
				}

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

				public List<QueryPriceList_TierPrice> TierPrices
				{
					get
					{
						return tierPrices;
					}
					set	
					{
						tierPrices = value;
					}
				}

				public class QueryPriceList_TierPrice
				{

					private string tierStart;

					private string startSymbol;

					private string tierEnd;

					private string endSymbol;

					private string tierType;

					private string priceType;

					private string price;

					public string TierStart
					{
						get
						{
							return tierStart;
						}
						set	
						{
							tierStart = value;
						}
					}

					public string StartSymbol
					{
						get
						{
							return startSymbol;
						}
						set	
						{
							startSymbol = value;
						}
					}

					public string TierEnd
					{
						get
						{
							return tierEnd;
						}
						set	
						{
							tierEnd = value;
						}
					}

					public string EndSymbol
					{
						get
						{
							return endSymbol;
						}
						set	
						{
							endSymbol = value;
						}
					}

					public string TierType
					{
						get
						{
							return tierType;
						}
						set	
						{
							tierType = value;
						}
					}

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
				}
			}
		}
	}
}