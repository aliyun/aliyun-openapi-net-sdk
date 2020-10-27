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

namespace Aliyun.Acs.cloudesl.Model.V20180801
{
	public class DescribeUserOperationLogResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string message;

		private string errorCode;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeUserOperationLog_OperationLogInfo> operationLogs;

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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public List<DescribeUserOperationLog_OperationLogInfo> OperationLogs
		{
			get
			{
				return operationLogs;
			}
			set	
			{
				operationLogs = value;
			}
		}

		public class DescribeUserOperationLog_OperationLogInfo
		{

			private string operateType;

			private string operateStatus;

			private long? operateUserId;

			private string operateTime;

			private string storeId;

			private string itemTitle;

			private string itemId;

			private int? itemActionPrice;

			private string itemBarCode;

			private string eslBarCode;

			private string shelfCode;

			public string OperateType
			{
				get
				{
					return operateType;
				}
				set	
				{
					operateType = value;
				}
			}

			public string OperateStatus
			{
				get
				{
					return operateStatus;
				}
				set	
				{
					operateStatus = value;
				}
			}

			public long? OperateUserId
			{
				get
				{
					return operateUserId;
				}
				set	
				{
					operateUserId = value;
				}
			}

			public string OperateTime
			{
				get
				{
					return operateTime;
				}
				set	
				{
					operateTime = value;
				}
			}

			public string StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public string ItemTitle
			{
				get
				{
					return itemTitle;
				}
				set	
				{
					itemTitle = value;
				}
			}

			public string ItemId
			{
				get
				{
					return itemId;
				}
				set	
				{
					itemId = value;
				}
			}

			public int? ItemActionPrice
			{
				get
				{
					return itemActionPrice;
				}
				set	
				{
					itemActionPrice = value;
				}
			}

			public string ItemBarCode
			{
				get
				{
					return itemBarCode;
				}
				set	
				{
					itemBarCode = value;
				}
			}

			public string EslBarCode
			{
				get
				{
					return eslBarCode;
				}
				set	
				{
					eslBarCode = value;
				}
			}

			public string ShelfCode
			{
				get
				{
					return shelfCode;
				}
				set	
				{
					shelfCode = value;
				}
			}
		}
	}
}
