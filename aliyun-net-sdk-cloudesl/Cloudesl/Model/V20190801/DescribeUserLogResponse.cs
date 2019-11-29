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

namespace Aliyun.Acs.cloudesl.Model.V20190801
{
	public class DescribeUserLogResponse : AcsResponse
	{

		private string errorMessage;

		private int? pageNumber;

		private string errorCode;

		private string message;

		private string dynamicCode;

		private int? pageSize;

		private string code;

		private string dynamicMessage;

		private int? totalCount;

		private string requestId;

		private bool? success;

		private List<DescribeUserLog_UserLogInfo> userLogs;

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public List<DescribeUserLog_UserLogInfo> UserLogs
		{
			get
			{
				return userLogs;
			}
			set	
			{
				userLogs = value;
			}
		}

		public class DescribeUserLog_UserLogInfo
		{

			private string operateType;

			private long? operateUserId;

			private string mac;

			private int? itemActionPrice;

			private string storeId;

			private string eslBarCode;

			private string operateStatus;

			private string itemBarCode;

			private long? itemId;

			private string shelfCode;

			private string operateTime;

			private string itemTitle;

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

			public string Mac
			{
				get
				{
					return mac;
				}
				set	
				{
					mac = value;
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

			public long? ItemId
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
		}
	}
}
