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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryDeviceBySQLResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private long? totalCount;

		private List<QueryDeviceBySQL_SimpleDeviceSearchInfo> data;

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

		public long? TotalCount
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

		public List<QueryDeviceBySQL_SimpleDeviceSearchInfo> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryDeviceBySQL_SimpleDeviceSearchInfo
		{

			private string productKey;

			private string deviceName;

			private string nickname;

			private string status;

			private string activeTime;

			private string iotId;

			private string gmtCreate;

			private string gmtModified;

			private List<QueryDeviceBySQL_SimpleDeviceGroupInfo> groups;

			private List<QueryDeviceBySQL_TagInfo> tags;

			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			public string DeviceName
			{
				get
				{
					return deviceName;
				}
				set	
				{
					deviceName = value;
				}
			}

			public string Nickname
			{
				get
				{
					return nickname;
				}
				set	
				{
					nickname = value;
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

			public string ActiveTime
			{
				get
				{
					return activeTime;
				}
				set	
				{
					activeTime = value;
				}
			}

			public string IotId
			{
				get
				{
					return iotId;
				}
				set	
				{
					iotId = value;
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

			public List<QueryDeviceBySQL_SimpleDeviceGroupInfo> Groups
			{
				get
				{
					return groups;
				}
				set	
				{
					groups = value;
				}
			}

			public List<QueryDeviceBySQL_TagInfo> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class QueryDeviceBySQL_SimpleDeviceGroupInfo
			{

				private string groupId;

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}
			}

			public class QueryDeviceBySQL_TagInfo
			{

				private string tagName;

				private string tagValue;

				public string TagName
				{
					get
					{
						return tagName;
					}
					set	
					{
						tagName = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}
		}
	}
}
