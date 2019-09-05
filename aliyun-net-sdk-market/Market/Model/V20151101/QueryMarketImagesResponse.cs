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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class QueryMarketImagesResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private string requestId;

		private List<QueryMarketImages_ImageProduct> result;

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

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

		public List<QueryMarketImages_ImageProduct> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryMarketImages_ImageProduct
		{

			private string imageProductCode;

			private string productName;

			private string categoryName;

			private string supplierName;

			private string baseSystem;

			private string osKind;

			private int? osBit;

			private string pictureUrl;

			private string smallPicUrl;

			private string shortDescription;

			private string agreementUrl;

			private string detailUrl;

			private string buyUrl;

			private string storeUrl;

			private float? score;

			private long? userCount;

			private bool? supportIO;

			private long? createdOn;

			private List<QueryMarketImages_Image> images;

			private List<string> skuCodes;

			private QueryMarketImages_Quota quota;

			private QueryMarketImages_PriceInfo priceInfo;

			public string ImageProductCode
			{
				get
				{
					return imageProductCode;
				}
				set	
				{
					imageProductCode = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public string CategoryName
			{
				get
				{
					return categoryName;
				}
				set	
				{
					categoryName = value;
				}
			}

			public string SupplierName
			{
				get
				{
					return supplierName;
				}
				set	
				{
					supplierName = value;
				}
			}

			public string BaseSystem
			{
				get
				{
					return baseSystem;
				}
				set	
				{
					baseSystem = value;
				}
			}

			public string OsKind
			{
				get
				{
					return osKind;
				}
				set	
				{
					osKind = value;
				}
			}

			public int? OsBit
			{
				get
				{
					return osBit;
				}
				set	
				{
					osBit = value;
				}
			}

			public string PictureUrl
			{
				get
				{
					return pictureUrl;
				}
				set	
				{
					pictureUrl = value;
				}
			}

			public string SmallPicUrl
			{
				get
				{
					return smallPicUrl;
				}
				set	
				{
					smallPicUrl = value;
				}
			}

			public string ShortDescription
			{
				get
				{
					return shortDescription;
				}
				set	
				{
					shortDescription = value;
				}
			}

			public string AgreementUrl
			{
				get
				{
					return agreementUrl;
				}
				set	
				{
					agreementUrl = value;
				}
			}

			public string DetailUrl
			{
				get
				{
					return detailUrl;
				}
				set	
				{
					detailUrl = value;
				}
			}

			public string BuyUrl
			{
				get
				{
					return buyUrl;
				}
				set	
				{
					buyUrl = value;
				}
			}

			public string StoreUrl
			{
				get
				{
					return storeUrl;
				}
				set	
				{
					storeUrl = value;
				}
			}

			public float? Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public long? UserCount
			{
				get
				{
					return userCount;
				}
				set	
				{
					userCount = value;
				}
			}

			public bool? SupportIO
			{
				get
				{
					return supportIO;
				}
				set	
				{
					supportIO = value;
				}
			}

			public long? CreatedOn
			{
				get
				{
					return createdOn;
				}
				set	
				{
					createdOn = value;
				}
			}

			public List<QueryMarketImages_Image> Images
			{
				get
				{
					return images;
				}
				set	
				{
					images = value;
				}
			}

			public List<string> SkuCodes
			{
				get
				{
					return skuCodes;
				}
				set	
				{
					skuCodes = value;
				}
			}

			public QueryMarketImages_Quota Quota
			{
				get
				{
					return quota;
				}
				set	
				{
					quota = value;
				}
			}

			public QueryMarketImages_PriceInfo PriceInfo
			{
				get
				{
					return priceInfo;
				}
				set	
				{
					priceInfo = value;
				}
			}

			public class QueryMarketImages_Image
			{

				private string version;

				private string versionDescription;

				private string imageId;

				private int? imageSize;

				private string region;

				private bool? isDefault;

				private bool? supportIO;

				private List<QueryMarketImages_DiskDeviceMapping> diskDeviceMappings;

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string VersionDescription
				{
					get
					{
						return versionDescription;
					}
					set	
					{
						versionDescription = value;
					}
				}

				public string ImageId
				{
					get
					{
						return imageId;
					}
					set	
					{
						imageId = value;
					}
				}

				public int? ImageSize
				{
					get
					{
						return imageSize;
					}
					set	
					{
						imageSize = value;
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

				public bool? IsDefault
				{
					get
					{
						return isDefault;
					}
					set	
					{
						isDefault = value;
					}
				}

				public bool? SupportIO
				{
					get
					{
						return supportIO;
					}
					set	
					{
						supportIO = value;
					}
				}

				public List<QueryMarketImages_DiskDeviceMapping> DiskDeviceMappings
				{
					get
					{
						return diskDeviceMappings;
					}
					set	
					{
						diskDeviceMappings = value;
					}
				}

				public class QueryMarketImages_DiskDeviceMapping
				{

					private string diskType;

					private string format;

					private string snapshotId;

					private int? size;

					private string device;

					private string importOSSBucket;

					private string importOSSObject;

					public string DiskType
					{
						get
						{
							return diskType;
						}
						set	
						{
							diskType = value;
						}
					}

					public string Format
					{
						get
						{
							return format;
						}
						set	
						{
							format = value;
						}
					}

					public string SnapshotId
					{
						get
						{
							return snapshotId;
						}
						set	
						{
							snapshotId = value;
						}
					}

					public int? Size
					{
						get
						{
							return size;
						}
						set	
						{
							size = value;
						}
					}

					public string Device
					{
						get
						{
							return device;
						}
						set	
						{
							device = value;
						}
					}

					public string ImportOSSBucket
					{
						get
						{
							return importOSSBucket;
						}
						set	
						{
							importOSSBucket = value;
						}
					}

					public string ImportOSSObject
					{
						get
						{
							return importOSSObject;
						}
						set	
						{
							importOSSObject = value;
						}
					}
				}
			}

			public class QueryMarketImages_Quota
			{

				private long? totalQuota;

				private long? usingQuota;

				private long? unusedQuota;

				public long? TotalQuota
				{
					get
					{
						return totalQuota;
					}
					set	
					{
						totalQuota = value;
					}
				}

				public long? UsingQuota
				{
					get
					{
						return usingQuota;
					}
					set	
					{
						usingQuota = value;
					}
				}

				public long? UnusedQuota
				{
					get
					{
						return unusedQuota;
					}
					set	
					{
						unusedQuota = value;
					}
				}
			}

			public class QueryMarketImages_PriceInfo
			{

				private List<QueryMarketImages_Rule> rules;

				private QueryMarketImages_Order order;

				public List<QueryMarketImages_Rule> Rules
				{
					get
					{
						return rules;
					}
					set	
					{
						rules = value;
					}
				}

				public QueryMarketImages_Order Order
				{
					get
					{
						return order;
					}
					set	
					{
						order = value;
					}
				}

				public class QueryMarketImages_Rule
				{

					private long? ruleId;

					private string title;

					private string name;

					public long? RuleId
					{
						get
						{
							return ruleId;
						}
						set	
						{
							ruleId = value;
						}
					}

					public string Title
					{
						get
						{
							return title;
						}
						set	
						{
							title = value;
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
						}
					}
				}

				public class QueryMarketImages_Order
				{

					private float? originalPrice;

					private float? discountPrice;

					private float? tradePrice;

					private string currency;

					private int? period;

					private string priceUnit;

					private List<string> ruleIdSet;

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

					public int? Period
					{
						get
						{
							return period;
						}
						set	
						{
							period = value;
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

					public List<string> RuleIdSet
					{
						get
						{
							return ruleIdSet;
						}
						set	
						{
							ruleIdSet = value;
						}
					}
				}
			}
		}
	}
}
