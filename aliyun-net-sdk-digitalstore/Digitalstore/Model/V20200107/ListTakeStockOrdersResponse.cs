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
	public class ListTakeStockOrdersResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListTakeStockOrders_TakeStockOrderModel> takeStockOrders;

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

		public List<ListTakeStockOrders_TakeStockOrderModel> TakeStockOrders
		{
			get
			{
				return takeStockOrders;
			}
			set	
			{
				takeStockOrders = value;
			}
		}

		public class ListTakeStockOrders_TakeStockOrderModel
		{

			private string warehouseCode;

			private string createDate;

			private string warehouseName;

			private string confirmDateTime;

			private string description;

			private string orderId;

			private string updateDate;

			private string code;

			private string syncStatus;

			private string status;

			private string makeDateTime;

			private string sourceOrderCode;

			private string lastSyncDateTime;

			private string warehouseId;

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

			public string SyncStatus
			{
				get
				{
					return syncStatus;
				}
				set	
				{
					syncStatus = value;
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

			public string LastSyncDateTime
			{
				get
				{
					return lastSyncDateTime;
				}
				set	
				{
					lastSyncDateTime = value;
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
		}
	}
}
