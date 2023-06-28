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
	public class QueryFaceAllUserGroupAndDeviceGroupRelationResponse : AcsResponse
	{

		private string code;

		private string requestId;

		private string errorMessage;

		private bool? success;

		private QueryFaceAllUserGroupAndDeviceGroupRelation_Data data;

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

		public QueryFaceAllUserGroupAndDeviceGroupRelation_Data Data
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

		public class QueryFaceAllUserGroupAndDeviceGroupRelation_Data
		{

			private int? pageSize;

			private int? total;

			private int? page;

			private List<QueryFaceAllUserGroupAndDeviceGroupRelation_ListItem> list;

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

			public int? Page
			{
				get
				{
					return page;
				}
				set	
				{
					page = value;
				}
			}

			public List<QueryFaceAllUserGroupAndDeviceGroupRelation_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QueryFaceAllUserGroupAndDeviceGroupRelation_ListItem
			{

				private string deviceGroupId;

				private string controlId;

				private string modifiedTime;

				private string controlType;

				private string userGroupId;

				public string DeviceGroupId
				{
					get
					{
						return deviceGroupId;
					}
					set	
					{
						deviceGroupId = value;
					}
				}

				public string ControlId
				{
					get
					{
						return controlId;
					}
					set	
					{
						controlId = value;
					}
				}

				public string ModifiedTime
				{
					get
					{
						return modifiedTime;
					}
					set	
					{
						modifiedTime = value;
					}
				}

				public string ControlType
				{
					get
					{
						return controlType;
					}
					set	
					{
						controlType = value;
					}
				}

				public string UserGroupId
				{
					get
					{
						return userGroupId;
					}
					set	
					{
						userGroupId = value;
					}
				}
			}
		}
	}
}
