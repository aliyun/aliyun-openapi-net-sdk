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

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class ListProduceOrderLinesResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListProduceOrderLines_ProduceOrderLineModel> produceOrderLines;

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

		public List<ListProduceOrderLines_ProduceOrderLineModel> ProduceOrderLines
		{
			get
			{
				return produceOrderLines;
			}
			set	
			{
				produceOrderLines = value;
			}
		}

		public class ListProduceOrderLines_ProduceOrderLineModel
		{

			private string productId;

			private string productColorCode;

			private string orderId;

			private string updateDate;

			private string productSizeName;

			private string productName;

			private string productSizeCode;

			private int? operateQuantity;

			private string createDate;

			private int? inboundQuantity;

			private int? boxedNum;

			private int? quantity;

			private string productColorName;

			private string productCode;

			private int? businessPrice;

			private string barcodeId;

			private string barcode;

			private string sKUName;

			public string ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
				}
			}

			public string ProductColorCode
			{
				get
				{
					return productColorCode;
				}
				set	
				{
					productColorCode = value;
				}
			}

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string ProductSizeName
			{
				get
				{
					return productSizeName;
				}
				set	
				{
					productSizeName = value;
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

			public string ProductSizeCode
			{
				get
				{
					return productSizeCode;
				}
				set	
				{
					productSizeCode = value;
				}
			}

			public int? OperateQuantity
			{
				get
				{
					return operateQuantity;
				}
				set	
				{
					operateQuantity = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public int? InboundQuantity
			{
				get
				{
					return inboundQuantity;
				}
				set	
				{
					inboundQuantity = value;
				}
			}

			public int? BoxedNum
			{
				get
				{
					return boxedNum;
				}
				set	
				{
					boxedNum = value;
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

			public string ProductColorName
			{
				get
				{
					return productColorName;
				}
				set	
				{
					productColorName = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public int? BusinessPrice
			{
				get
				{
					return businessPrice;
				}
				set	
				{
					businessPrice = value;
				}
			}

			public string BarcodeId
			{
				get
				{
					return barcodeId;
				}
				set	
				{
					barcodeId = value;
				}
			}

			public string Barcode
			{
				get
				{
					return barcode;
				}
				set	
				{
					barcode = value;
				}
			}

			public string SKUName
			{
				get
				{
					return sKUName;
				}
				set	
				{
					sKUName = value;
				}
			}
		}
	}
}
