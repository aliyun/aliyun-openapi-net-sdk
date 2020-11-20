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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class ListAppEventsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private string errorCode;

		private ListAppEvents_Data data;

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

		public ListAppEvents_Data Data
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

		public class ListAppEvents_Data
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalSize;

			private List<ListAppEvents_AppEventEntityItem> appEventEntity;

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

			public int? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			public List<ListAppEvents_AppEventEntityItem> AppEventEntity
			{
				get
				{
					return appEventEntity;
				}
				set	
				{
					appEventEntity = value;
				}
			}

			public class ListAppEvents_AppEventEntityItem
			{

				private string objectKind;

				private string objectName;

				private string eventType;

				private string message;

				private string firstTimestamp;

				private string lastTimestamp;

				private string reason;

				public string ObjectKind
				{
					get
					{
						return objectKind;
					}
					set	
					{
						objectKind = value;
					}
				}

				public string ObjectName
				{
					get
					{
						return objectName;
					}
					set	
					{
						objectName = value;
					}
				}

				public string EventType
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

				public string FirstTimestamp
				{
					get
					{
						return firstTimestamp;
					}
					set	
					{
						firstTimestamp = value;
					}
				}

				public string LastTimestamp
				{
					get
					{
						return lastTimestamp;
					}
					set	
					{
						lastTimestamp = value;
					}
				}

				public string Reason
				{
					get
					{
						return reason;
					}
					set	
					{
						reason = value;
					}
				}
			}
		}
	}
}
