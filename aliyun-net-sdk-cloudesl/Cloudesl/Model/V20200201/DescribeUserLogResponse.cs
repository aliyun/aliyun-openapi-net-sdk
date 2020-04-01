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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribeUserLogResponse : AcsResponse
	{

		private string errorMessage;

		private string errorCode;

		private int? pageNumber;

		private string message;

		private string dynamicCode;

		private string code;

		private int? pageSize;

		private string dynamicMessage;

		private string requestId;

		private bool? success;

		private int? totalCount;

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

			private string resultCode;

			private string operationSendTime;

			private string gmtCreate;

			private string storeId;

			private string gmtModified;

			private string actionPrice;

			private string operationStatus;

			private string priceUnit;

			private string logId;

			private string itemShortTitle;

			private string operationType;

			private string operationResponseTime;

			private string spendTime;

			private string eslBarCode;

			private string itemId;

			private string itemBarCode;

			private bool? bePromotion;

			private string userId;

			public string ResultCode
			{
				get
				{
					return resultCode;
				}
				set	
				{
					resultCode = value;
				}
			}

			public string OperationSendTime
			{
				get
				{
					return operationSendTime;
				}
				set	
				{
					operationSendTime = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
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

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string ActionPrice
			{
				get
				{
					return actionPrice;
				}
				set	
				{
					actionPrice = value;
				}
			}

			public string OperationStatus
			{
				get
				{
					return operationStatus;
				}
				set	
				{
					operationStatus = value;
				}
			}

			public string PriceUnit
			{
				get
				{
					return priceUnit;
				}
				set	
				{
					priceUnit = value;
				}
			}

			public string LogId
			{
				get
				{
					return logId;
				}
				set	
				{
					logId = value;
				}
			}

			public string ItemShortTitle
			{
				get
				{
					return itemShortTitle;
				}
				set	
				{
					itemShortTitle = value;
				}
			}

			public string OperationType
			{
				get
				{
					return operationType;
				}
				set	
				{
					operationType = value;
				}
			}

			public string OperationResponseTime
			{
				get
				{
					return operationResponseTime;
				}
				set	
				{
					operationResponseTime = value;
				}
			}

			public string SpendTime
			{
				get
				{
					return spendTime;
				}
				set	
				{
					spendTime = value;
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

			public bool? BePromotion
			{
				get
				{
					return bePromotion;
				}
				set	
				{
					bePromotion = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}
		}
	}
}
