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
	public class DescribeAlarmsResponse : AcsResponse
	{

		private string errorMessage;

		private string errorCode;

		private int? pageSize;

		private string message;

		private int? totalCount;

		private int? pageNumber;

		private string dynamicCode;

		private string code;

		private string dynamicMessage;

		private string requestId;

		private bool? success;

		private List<DescribeAlarms_AlarmInfo> alarms;

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

		public List<DescribeAlarms_AlarmInfo> Alarms
		{
			get
			{
				return alarms;
			}
			set	
			{
				alarms = value;
			}
		}

		public class DescribeAlarms_AlarmInfo
		{

			private string remark;

			private string storeId;

			private string deviceBarCode;

			private string dealUserId;

			private string deviceType;

			private string itemTitle;

			private string alarmTime;

			private string errorType;

			private string deviceMac;

			private string alarmId;

			private string retryGmtCreate;

			private string retryGmtModified;

			private string itemBarCode;

			private long? retryTimes;

			private string dealTime;

			private string alarmType;

			private string alarmStatus;

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
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

			public string DeviceBarCode
			{
				get
				{
					return deviceBarCode;
				}
				set	
				{
					deviceBarCode = value;
				}
			}

			public string DealUserId
			{
				get
				{
					return dealUserId;
				}
				set	
				{
					dealUserId = value;
				}
			}

			public string DeviceType
			{
				get
				{
					return deviceType;
				}
				set	
				{
					deviceType = value;
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

			public string AlarmTime
			{
				get
				{
					return alarmTime;
				}
				set	
				{
					alarmTime = value;
				}
			}

			public string ErrorType
			{
				get
				{
					return errorType;
				}
				set	
				{
					errorType = value;
				}
			}

			public string DeviceMac
			{
				get
				{
					return deviceMac;
				}
				set	
				{
					deviceMac = value;
				}
			}

			public string AlarmId
			{
				get
				{
					return alarmId;
				}
				set	
				{
					alarmId = value;
				}
			}

			public string RetryGmtCreate
			{
				get
				{
					return retryGmtCreate;
				}
				set	
				{
					retryGmtCreate = value;
				}
			}

			public string RetryGmtModified
			{
				get
				{
					return retryGmtModified;
				}
				set	
				{
					retryGmtModified = value;
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

			public long? RetryTimes
			{
				get
				{
					return retryTimes;
				}
				set	
				{
					retryTimes = value;
				}
			}

			public string DealTime
			{
				get
				{
					return dealTime;
				}
				set	
				{
					dealTime = value;
				}
			}

			public string AlarmType
			{
				get
				{
					return alarmType;
				}
				set	
				{
					alarmType = value;
				}
			}

			public string AlarmStatus
			{
				get
				{
					return alarmStatus;
				}
				set	
				{
					alarmStatus = value;
				}
			}
		}
	}
}
