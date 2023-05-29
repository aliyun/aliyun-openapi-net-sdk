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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeProductsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeProducts_ProductItem> productItems;

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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "ProductItems")]
		public List<DescribeProducts_ProductItem> ProductItems
		{
			get
			{
				return productItems;
			}
			set	
			{
				productItems = value;
			}
		}

		public class DescribeProducts_ProductItem
		{

			private string priceInfo;

			private string deliveryWay;

			private string imageUrl;

			private string warrantyDate;

			private string tags;

			private string score;

			private long? supplierId;

			private string operationSystem;

			private string shortDescription;

			private string deliveryDate;

			private string targetUrl;

			private string code;

			private long? categoryId;

			private string name;

			private string suggestedPrice;

			private string supplierName;

			[JsonProperty(PropertyName = "PriceInfo")]
			public string PriceInfo
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

			[JsonProperty(PropertyName = "DeliveryWay")]
			public string DeliveryWay
			{
				get
				{
					return deliveryWay;
				}
				set	
				{
					deliveryWay = value;
				}
			}

			[JsonProperty(PropertyName = "ImageUrl")]
			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
				}
			}

			[JsonProperty(PropertyName = "WarrantyDate")]
			public string WarrantyDate
			{
				get
				{
					return warrantyDate;
				}
				set	
				{
					warrantyDate = value;
				}
			}

			[JsonProperty(PropertyName = "Tags")]
			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			[JsonProperty(PropertyName = "Score")]
			public string Score
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

			[JsonProperty(PropertyName = "SupplierId")]
			public long? SupplierId
			{
				get
				{
					return supplierId;
				}
				set	
				{
					supplierId = value;
				}
			}

			[JsonProperty(PropertyName = "OperationSystem")]
			public string OperationSystem
			{
				get
				{
					return operationSystem;
				}
				set	
				{
					operationSystem = value;
				}
			}

			[JsonProperty(PropertyName = "ShortDescription")]
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

			[JsonProperty(PropertyName = "DeliveryDate")]
			public string DeliveryDate
			{
				get
				{
					return deliveryDate;
				}
				set	
				{
					deliveryDate = value;
				}
			}

			[JsonProperty(PropertyName = "TargetUrl")]
			public string TargetUrl
			{
				get
				{
					return targetUrl;
				}
				set	
				{
					targetUrl = value;
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

			[JsonProperty(PropertyName = "CategoryId")]
			public long? CategoryId
			{
				get
				{
					return categoryId;
				}
				set	
				{
					categoryId = value;
				}
			}

			[JsonProperty(PropertyName = "Name")]
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

			[JsonProperty(PropertyName = "SuggestedPrice")]
			public string SuggestedPrice
			{
				get
				{
					return suggestedPrice;
				}
				set	
				{
					suggestedPrice = value;
				}
			}

			[JsonProperty(PropertyName = "SupplierName")]
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
		}
	}
}
