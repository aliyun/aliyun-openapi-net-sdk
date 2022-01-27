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
	public class DescribeStoreStatisticsResponse : AcsResponse
	{

		private string errorMessage;

		private string errorCode;

		private string message;

		private string dynamicCode;

		private string code;

		private string dynamicMessage;

		private string requestId;

		private bool? success;

		private List<DescribeStoreStatistics_StoreStatisticsInfo> storeStatisticsInfoList;

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

		public List<DescribeStoreStatistics_StoreStatisticsInfo> StoreStatisticsInfoList
		{
			get
			{
				return storeStatisticsInfoList;
			}
			set	
			{
				storeStatisticsInfoList = value;
			}
		}

		public class DescribeStoreStatistics_StoreStatisticsInfo
		{

			private int? sendFailEsl;

			private int? displayFailEsl;

			private string storeName;

			private int? activeApDevice;

			private int? updateFailureEsl;

			private int? updateEsl;

			private int? offlineEslDevice;

			private string statisticsTime;

			private string storeId;

			private int? bindEsl;

			private int? abnormalEsl;

			private int? lowBatteryEsl;

			private int? bindItem;

			public int? SendFailEsl
			{
				get
				{
					return sendFailEsl;
				}
				set	
				{
					sendFailEsl = value;
				}
			}

			public int? DisplayFailEsl
			{
				get
				{
					return displayFailEsl;
				}
				set	
				{
					displayFailEsl = value;
				}
			}

			public string StoreName
			{
				get
				{
					return storeName;
				}
				set	
				{
					storeName = value;
				}
			}

			public int? ActiveApDevice
			{
				get
				{
					return activeApDevice;
				}
				set	
				{
					activeApDevice = value;
				}
			}

			public int? UpdateFailureEsl
			{
				get
				{
					return updateFailureEsl;
				}
				set	
				{
					updateFailureEsl = value;
				}
			}

			public int? UpdateEsl
			{
				get
				{
					return updateEsl;
				}
				set	
				{
					updateEsl = value;
				}
			}

			public int? OfflineEslDevice
			{
				get
				{
					return offlineEslDevice;
				}
				set	
				{
					offlineEslDevice = value;
				}
			}

			public string StatisticsTime
			{
				get
				{
					return statisticsTime;
				}
				set	
				{
					statisticsTime = value;
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

			public int? BindEsl
			{
				get
				{
					return bindEsl;
				}
				set	
				{
					bindEsl = value;
				}
			}

			public int? AbnormalEsl
			{
				get
				{
					return abnormalEsl;
				}
				set	
				{
					abnormalEsl = value;
				}
			}

			public int? LowBatteryEsl
			{
				get
				{
					return lowBatteryEsl;
				}
				set	
				{
					lowBatteryEsl = value;
				}
			}

			public int? BindItem
			{
				get
				{
					return bindItem;
				}
				set	
				{
					bindItem = value;
				}
			}
		}
	}
}
