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
	public class ListTakeStockOrderLinesResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListTakeStockOrderLines_TakeStockOrderLineModel> takeStockOrderLines;

		private List<ListTakeStockOrderLines_SummaryModel> summarys;

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

		public List<ListTakeStockOrderLines_TakeStockOrderLineModel> TakeStockOrderLines
		{
			get
			{
				return takeStockOrderLines;
			}
			set	
			{
				takeStockOrderLines = value;
			}
		}

		public List<ListTakeStockOrderLines_SummaryModel> Summarys
		{
			get
			{
				return summarys;
			}
			set	
			{
				summarys = value;
			}
		}

		public class ListTakeStockOrderLines_TakeStockOrderLineModel
		{

			private float? differenceAmount;

			private string productName;

			private string productSizeCode;

			private int? operateQuantity;

			private string createDate;

			private string updateDate;

			private int? confirmQuantity;

			private string productSizeName;

			private int? snapQuantity;

			private float? confirmAmount;

			private float? skuCurrentPrice;

			private string productColorCode;

			private int? differenceQuantity;

			private string barcodeId;

			private float? operateAmount;

			private string orderLineId;

			private string barcode;

			private float? skuRetailPrice;

			private float? snapAmount;

			private string productCode;

			private string takeStockOrderId;

			private string productColorName;

			public float? DifferenceAmount
			{
				get
				{
					return differenceAmount;
				}
				set	
				{
					differenceAmount = value;
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

			public int? ConfirmQuantity
			{
				get
				{
					return confirmQuantity;
				}
				set	
				{
					confirmQuantity = value;
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

			public int? SnapQuantity
			{
				get
				{
					return snapQuantity;
				}
				set	
				{
					snapQuantity = value;
				}
			}

			public float? ConfirmAmount
			{
				get
				{
					return confirmAmount;
				}
				set	
				{
					confirmAmount = value;
				}
			}

			public float? SkuCurrentPrice
			{
				get
				{
					return skuCurrentPrice;
				}
				set	
				{
					skuCurrentPrice = value;
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

			public int? DifferenceQuantity
			{
				get
				{
					return differenceQuantity;
				}
				set	
				{
					differenceQuantity = value;
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

			public float? OperateAmount
			{
				get
				{
					return operateAmount;
				}
				set	
				{
					operateAmount = value;
				}
			}

			public string OrderLineId
			{
				get
				{
					return orderLineId;
				}
				set	
				{
					orderLineId = value;
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

			public float? SkuRetailPrice
			{
				get
				{
					return skuRetailPrice;
				}
				set	
				{
					skuRetailPrice = value;
				}
			}

			public float? SnapAmount
			{
				get
				{
					return snapAmount;
				}
				set	
				{
					snapAmount = value;
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

			public string TakeStockOrderId
			{
				get
				{
					return takeStockOrderId;
				}
				set	
				{
					takeStockOrderId = value;
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
		}

		public class ListTakeStockOrderLines_SummaryModel
		{

			private int? differenceQuantity;

			private float? snapRetailAmount;

			private int? operateQuantity;

			private float? differenceRetailAmount;

			private float? operateAmount;

			private int? confirmQuantity;

			private int? snapQuantity;

			private float? confirmRetailAmount;

			public int? DifferenceQuantity
			{
				get
				{
					return differenceQuantity;
				}
				set	
				{
					differenceQuantity = value;
				}
			}

			public float? SnapRetailAmount
			{
				get
				{
					return snapRetailAmount;
				}
				set	
				{
					snapRetailAmount = value;
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

			public float? DifferenceRetailAmount
			{
				get
				{
					return differenceRetailAmount;
				}
				set	
				{
					differenceRetailAmount = value;
				}
			}

			public float? OperateAmount
			{
				get
				{
					return operateAmount;
				}
				set	
				{
					operateAmount = value;
				}
			}

			public int? ConfirmQuantity
			{
				get
				{
					return confirmQuantity;
				}
				set	
				{
					confirmQuantity = value;
				}
			}

			public int? SnapQuantity
			{
				get
				{
					return snapQuantity;
				}
				set	
				{
					snapQuantity = value;
				}
			}

			public float? ConfirmRetailAmount
			{
				get
				{
					return confirmRetailAmount;
				}
				set	
				{
					confirmRetailAmount = value;
				}
			}
		}
	}
}
