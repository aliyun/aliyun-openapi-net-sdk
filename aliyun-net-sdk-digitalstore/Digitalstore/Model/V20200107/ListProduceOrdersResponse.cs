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
	public class ListProduceOrdersResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListProduceOrders_ProduceOrderModel> orders;

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

		public List<ListProduceOrders_ProduceOrderModel> Orders
		{
			get
			{
				return orders;
			}
			set	
			{
				orders = value;
			}
		}

		public class ListProduceOrders_ProduceOrderModel
		{

			private string orderId;

			private int? totalBinding;

			private string code;

			private string updateDate;

			private string warehouseName;

			private int? inboundQuantity;

			private string businessUnitId;

			private string warehouseCode;

			private string description;

			private string styleName;

			private string styleId;

			private string purchaseOrderCode;

			private float? businessAmount;

			private string deliveryDate;

			private string businessUnitCode;

			private string makeDateTime;

			private string businessUnitName;

			private int? totalBoxQuantity;

			private string createDate;

			private string styleCode;

			private string contractNumber;

			private string warehouseId;

			private int? quantity;

			private string sourceOrderCode;

			private string purchaseOrderId;

			private string sourceOrderType;

			private string status;

			private string scanType;

			private int? applyOrderQuantity;

			private int? applyCaseQuantity;

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

			public int? TotalBinding
			{
				get
				{
					return totalBinding;
				}
				set	
				{
					totalBinding = value;
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

			public string WarehouseName
			{
				get
				{
					return warehouseName;
				}
				set	
				{
					warehouseName = value;
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

			public string BusinessUnitId
			{
				get
				{
					return businessUnitId;
				}
				set	
				{
					businessUnitId = value;
				}
			}

			public string WarehouseCode
			{
				get
				{
					return warehouseCode;
				}
				set	
				{
					warehouseCode = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string StyleName
			{
				get
				{
					return styleName;
				}
				set	
				{
					styleName = value;
				}
			}

			public string StyleId
			{
				get
				{
					return styleId;
				}
				set	
				{
					styleId = value;
				}
			}

			public string PurchaseOrderCode
			{
				get
				{
					return purchaseOrderCode;
				}
				set	
				{
					purchaseOrderCode = value;
				}
			}

			public float? BusinessAmount
			{
				get
				{
					return businessAmount;
				}
				set	
				{
					businessAmount = value;
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

			public string BusinessUnitCode
			{
				get
				{
					return businessUnitCode;
				}
				set	
				{
					businessUnitCode = value;
				}
			}

			public string MakeDateTime
			{
				get
				{
					return makeDateTime;
				}
				set	
				{
					makeDateTime = value;
				}
			}

			public string BusinessUnitName
			{
				get
				{
					return businessUnitName;
				}
				set	
				{
					businessUnitName = value;
				}
			}

			public int? TotalBoxQuantity
			{
				get
				{
					return totalBoxQuantity;
				}
				set	
				{
					totalBoxQuantity = value;
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

			public string StyleCode
			{
				get
				{
					return styleCode;
				}
				set	
				{
					styleCode = value;
				}
			}

			public string ContractNumber
			{
				get
				{
					return contractNumber;
				}
				set	
				{
					contractNumber = value;
				}
			}

			public string WarehouseId
			{
				get
				{
					return warehouseId;
				}
				set	
				{
					warehouseId = value;
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

			public string SourceOrderCode
			{
				get
				{
					return sourceOrderCode;
				}
				set	
				{
					sourceOrderCode = value;
				}
			}

			public string PurchaseOrderId
			{
				get
				{
					return purchaseOrderId;
				}
				set	
				{
					purchaseOrderId = value;
				}
			}

			public string SourceOrderType
			{
				get
				{
					return sourceOrderType;
				}
				set	
				{
					sourceOrderType = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string ScanType
			{
				get
				{
					return scanType;
				}
				set	
				{
					scanType = value;
				}
			}

			public int? ApplyOrderQuantity
			{
				get
				{
					return applyOrderQuantity;
				}
				set	
				{
					applyOrderQuantity = value;
				}
			}

			public int? ApplyCaseQuantity
			{
				get
				{
					return applyCaseQuantity;
				}
				set	
				{
					applyCaseQuantity = value;
				}
			}
		}
	}
}
