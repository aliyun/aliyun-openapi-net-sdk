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
	public class DescribeProductsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeProducts_ProductItem> productItems;

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

			private string code;

			private string name;

			private long? categoryId;

			private long? supplierId;

			private string supplierName;

			private string shortDescription;

			private string tags;

			private string suggestedPrice;

			private string targetUrl;

			private string imageUrl;

			private string score;

			private string operationSystem;

			private string warrantyDate;

			private string deliveryDate;

			private string deliveryWay;

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
		}
	}
}
