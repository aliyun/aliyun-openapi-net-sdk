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
	public class ListApplicationOrdersResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListApplicationOrders_ApplyOrderModel> applyOrders;

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

		public List<ListApplicationOrders_ApplyOrderModel> ApplyOrders
		{
			get
			{
				return applyOrders;
			}
			set	
			{
				applyOrders = value;
			}
		}

		public class ListApplicationOrders_ApplyOrderModel
		{

			private string orderId;

			private int? confirmTotal;

			private string code;

			private string updateDate;

			private string warehouseName;

			private int? productionOrderQuantity;

			private string warehouseCode;

			private string confirmDateTime;

			private int? confirmCaseQuantity;

			private string productionOrderSourceOrderCode;

			private string confirmDeliveryDate;

			private string purchaseOrderCode;

			private string rejectReason;

			private int? total;

			private string deliveryDate;

			private string confirmDeliveryDateTimeRange;

			private string productId;

			private string fromBusinessUnitCode;

			private string fromBusinessUnitId;

			private string createDate;

			private string toWarehouseContact;

			private int? contractNumber;

			private string warehouseId;

			private int? caseQuantity;

			private string purchaseOrderId;

			private string sourceOrderCode;

			private string toWarehouseTel;

			private int? receivedQuantity;

			private string status;

			private string fromBusinessUnitName;

			private string scanType;

			private string toWarehouseAddress;

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

			public int? ConfirmTotal
			{
				get
				{
					return confirmTotal;
				}
				set	
				{
					confirmTotal = value;
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

			public int? ProductionOrderQuantity
			{
				get
				{
					return productionOrderQuantity;
				}
				set	
				{
					productionOrderQuantity = value;
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

			public string ConfirmDateTime
			{
				get
				{
					return confirmDateTime;
				}
				set	
				{
					confirmDateTime = value;
				}
			}

			public int? ConfirmCaseQuantity
			{
				get
				{
					return confirmCaseQuantity;
				}
				set	
				{
					confirmCaseQuantity = value;
				}
			}

			public string ProductionOrderSourceOrderCode
			{
				get
				{
					return productionOrderSourceOrderCode;
				}
				set	
				{
					productionOrderSourceOrderCode = value;
				}
			}

			public string ConfirmDeliveryDate
			{
				get
				{
					return confirmDeliveryDate;
				}
				set	
				{
					confirmDeliveryDate = value;
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

			public string RejectReason
			{
				get
				{
					return rejectReason;
				}
				set	
				{
					rejectReason = value;
				}
			}

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
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

			public string ConfirmDeliveryDateTimeRange
			{
				get
				{
					return confirmDeliveryDateTimeRange;
				}
				set	
				{
					confirmDeliveryDateTimeRange = value;
				}
			}

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

			public string FromBusinessUnitCode
			{
				get
				{
					return fromBusinessUnitCode;
				}
				set	
				{
					fromBusinessUnitCode = value;
				}
			}

			public string FromBusinessUnitId
			{
				get
				{
					return fromBusinessUnitId;
				}
				set	
				{
					fromBusinessUnitId = value;
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

			public string ToWarehouseContact
			{
				get
				{
					return toWarehouseContact;
				}
				set	
				{
					toWarehouseContact = value;
				}
			}

			public int? ContractNumber
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

			public int? CaseQuantity
			{
				get
				{
					return caseQuantity;
				}
				set	
				{
					caseQuantity = value;
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

			public string ToWarehouseTel
			{
				get
				{
					return toWarehouseTel;
				}
				set	
				{
					toWarehouseTel = value;
				}
			}

			public int? ReceivedQuantity
			{
				get
				{
					return receivedQuantity;
				}
				set	
				{
					receivedQuantity = value;
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

			public string FromBusinessUnitName
			{
				get
				{
					return fromBusinessUnitName;
				}
				set	
				{
					fromBusinessUnitName = value;
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

			public string ToWarehouseAddress
			{
				get
				{
					return toWarehouseAddress;
				}
				set	
				{
					toWarehouseAddress = value;
				}
			}
		}
	}
}
