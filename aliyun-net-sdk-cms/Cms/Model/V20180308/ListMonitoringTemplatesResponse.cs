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

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class ListMonitoringTemplatesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private string errorMessage;

		private long? pageSize;

		private long? pageNumber;

		private long? total;

		private List<ListMonitoringTemplates_Resource> resources;

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

		public int? ErrorCode
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

		public long? PageSize
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

		public long? PageNumber
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

		public long? Total
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

		public List<ListMonitoringTemplates_Resource> Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
			}
		}

		public class ListMonitoringTemplates_Resource
		{

			private string name;

			private string _namespace;

			private string description;

			private string alertTemplatesJson;

			private long? restVersion;

			private long? id;

			private long? gmtCreate;

			private long? gmtModified;

			private string eventRuleTemplatesJson;

			private List<ListMonitoringTemplates_ApplyHistory> applyHistories;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string AlertTemplatesJson
			{
				get
				{
					return alertTemplatesJson;
				}
				set	
				{
					alertTemplatesJson = value;
				}
			}

			public long? RestVersion
			{
				get
				{
					return restVersion;
				}
				set	
				{
					restVersion = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public long? GmtCreate
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

			public long? GmtModified
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

			public string EventRuleTemplatesJson
			{
				get
				{
					return eventRuleTemplatesJson;
				}
				set	
				{
					eventRuleTemplatesJson = value;
				}
			}

			public List<ListMonitoringTemplates_ApplyHistory> ApplyHistories
			{
				get
				{
					return applyHistories;
				}
				set	
				{
					applyHistories = value;
				}
			}

			public class ListMonitoringTemplates_ApplyHistory
			{

				private long? groupId;

				private string groupName;

				private long? applyTime;

				public long? GroupId
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

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

				public long? ApplyTime
				{
					get
					{
						return applyTime;
					}
					set	
					{
						applyTime = value;
					}
				}
			}
		}
	}
}
