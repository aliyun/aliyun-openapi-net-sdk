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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
	public class QueryCarProcessEventsResponse : AcsResponse
	{

		private string code;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private QueryCarProcessEvents_Data data;

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

		public QueryCarProcessEvents_Data Data
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

		public class QueryCarProcessEvents_Data
		{

			private int? currentPage;

			private int? pageSize;

			private int? total;

			private int? pageCount;

			private List<QueryCarProcessEvents_PageDataItem> pageData;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? PageCount
			{
				get
				{
					return pageCount;
				}
				set	
				{
					pageCount = value;
				}
			}

			public List<QueryCarProcessEvents_PageDataItem> PageData
			{
				get
				{
					return pageData;
				}
				set	
				{
					pageData = value;
				}
			}

			public class QueryCarProcessEvents_PageDataItem
			{

				private string eventPicUrl;

				private long? eventTime;

				private int? actionType;

				private int? confidence;

				private string subProductKey;

				private string eventId;

				private string subIotId;

				private int? areaIndex;

				private int? eventType;

				private string eventPicId;

				private string taskId;

				private string subDeviceName;

				private string iotId;

				private string subDeviceNickName;

				private string plateNo;

				public string EventPicUrl
				{
					get
					{
						return eventPicUrl;
					}
					set	
					{
						eventPicUrl = value;
					}
				}

				public long? EventTime
				{
					get
					{
						return eventTime;
					}
					set	
					{
						eventTime = value;
					}
				}

				public int? ActionType
				{
					get
					{
						return actionType;
					}
					set	
					{
						actionType = value;
					}
				}

				public int? Confidence
				{
					get
					{
						return confidence;
					}
					set	
					{
						confidence = value;
					}
				}

				public string SubProductKey
				{
					get
					{
						return subProductKey;
					}
					set	
					{
						subProductKey = value;
					}
				}

				public string EventId
				{
					get
					{
						return eventId;
					}
					set	
					{
						eventId = value;
					}
				}

				public string SubIotId
				{
					get
					{
						return subIotId;
					}
					set	
					{
						subIotId = value;
					}
				}

				public int? AreaIndex
				{
					get
					{
						return areaIndex;
					}
					set	
					{
						areaIndex = value;
					}
				}

				public int? EventType
				{
					get
					{
						return eventType;
					}
					set	
					{
						eventType = value;
					}
				}

				public string EventPicId
				{
					get
					{
						return eventPicId;
					}
					set	
					{
						eventPicId = value;
					}
				}

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public string SubDeviceName
				{
					get
					{
						return subDeviceName;
					}
					set	
					{
						subDeviceName = value;
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

				public string SubDeviceNickName
				{
					get
					{
						return subDeviceNickName;
					}
					set	
					{
						subDeviceNickName = value;
					}
				}

				public string PlateNo
				{
					get
					{
						return plateNo;
					}
					set	
					{
						plateNo = value;
					}
				}
			}
		}
	}
}
