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
	public class ListTakeStockOrderTasksResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListTakeStockOrderTasks_TakeStockOrderTaskModel> takeStockOrderTasks;

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

		public List<ListTakeStockOrderTasks_TakeStockOrderTaskModel> TakeStockOrderTasks
		{
			get
			{
				return takeStockOrderTasks;
			}
			set	
			{
				takeStockOrderTasks = value;
			}
		}

		public class ListTakeStockOrderTasks_TakeStockOrderTaskModel
		{

			private string deviceNumber;

			private string createDate;

			private int? operateQuantity;

			private string status;

			private string takeStockTaskId;

			private string syncStatus;

			private string description;

			private string takeStockOrderId;

			private string code;

			private string updateDate;

			public string DeviceNumber
			{
				get
				{
					return deviceNumber;
				}
				set	
				{
					deviceNumber = value;
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

			public string TakeStockTaskId
			{
				get
				{
					return takeStockTaskId;
				}
				set	
				{
					takeStockTaskId = value;
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
		}
	}
}
