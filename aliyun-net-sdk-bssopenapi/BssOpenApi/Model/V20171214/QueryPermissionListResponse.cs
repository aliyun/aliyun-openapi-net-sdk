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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryPermissionListResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryPermissionList_Data data;

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

		public QueryPermissionList_Data Data
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

		public class QueryPermissionList_Data
		{

			private string endTime;

			private string relationType;

			private string startTime;

			private string state;

			private long? masterId;

			private long? memberId;

			private string setupTime;

			private List<QueryPermissionList_PermissionListItem> permissionList;

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string RelationType
			{
				get
				{
					return relationType;
				}
				set	
				{
					relationType = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public long? MasterId
			{
				get
				{
					return masterId;
				}
				set	
				{
					masterId = value;
				}
			}

			public long? MemberId
			{
				get
				{
					return memberId;
				}
				set	
				{
					memberId = value;
				}
			}

			public string SetupTime
			{
				get
				{
					return setupTime;
				}
				set	
				{
					setupTime = value;
				}
			}

			public List<QueryPermissionList_PermissionListItem> PermissionList
			{
				get
				{
					return permissionList;
				}
				set	
				{
					permissionList = value;
				}
			}

			public class QueryPermissionList_PermissionListItem
			{

				private string endTime;

				private string startTime;

				private string permissionCode;

				private string permissionName;

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string PermissionCode
				{
					get
					{
						return permissionCode;
					}
					set	
					{
						permissionCode = value;
					}
				}

				public string PermissionName
				{
					get
					{
						return permissionName;
					}
					set	
					{
						permissionName = value;
					}
				}
			}
		}
	}
}
