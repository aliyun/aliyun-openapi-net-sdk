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
	public class DescribeStoreConfigResponse : AcsResponse
	{

		private string requestId;

		private string errorMessage;

		private bool? success;

		private string errorCode;

		private string code;

		private string message;

		private string dynamicMessage;

		private string dynamicCode;

		private DescribeStoreConfig_StoreConfigInfo storeConfigInfo;

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

		public DescribeStoreConfig_StoreConfigInfo StoreConfigInfo
		{
			get
			{
				return storeConfigInfo;
			}
			set	
			{
				storeConfigInfo = value;
			}
		}

		public class DescribeStoreConfig_StoreConfigInfo
		{

			private string storeId;

			private bool? enableNotification;

			private string notificationWebHook;

			private string notificationSilentTimes;

			private List<DescribeStoreConfig_SubscribeContent> subscribeContents;

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

			public bool? EnableNotification
			{
				get
				{
					return enableNotification;
				}
				set	
				{
					enableNotification = value;
				}
			}

			public string NotificationWebHook
			{
				get
				{
					return notificationWebHook;
				}
				set	
				{
					notificationWebHook = value;
				}
			}

			public string NotificationSilentTimes
			{
				get
				{
					return notificationSilentTimes;
				}
				set	
				{
					notificationSilentTimes = value;
				}
			}

			public List<DescribeStoreConfig_SubscribeContent> SubscribeContents
			{
				get
				{
					return subscribeContents;
				}
				set	
				{
					subscribeContents = value;
				}
			}

			public class DescribeStoreConfig_SubscribeContent
			{

				private string category;

				private bool? enable;

				private string threshold;

				private bool? atAll;

				private string atMobileList;

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public bool? Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Threshold
				{
					get
					{
						return threshold;
					}
					set	
					{
						threshold = value;
					}
				}

				public bool? AtAll
				{
					get
					{
						return atAll;
					}
					set	
					{
						atAll = value;
					}
				}

				public string AtMobileList
				{
					get
					{
						return atMobileList;
					}
					set	
					{
						atMobileList = value;
					}
				}
			}
		}
	}
}
