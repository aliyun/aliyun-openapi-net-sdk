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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeProcessTasksResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeProcessTasks_Data> processTasks;

		private DescribeProcessTasks_Page page;

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

		public List<DescribeProcessTasks_Data> ProcessTasks
		{
			get
			{
				return processTasks;
			}
			set	
			{
				processTasks = value;
			}
		}

		public DescribeProcessTasks_Page Page
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

		public class DescribeProcessTasks_Data
		{

			private string taskId;

			private string creator;

			private long? gmtCreateMillis;

			private long? gmtModifiedMillis;

			private string taskName;

			private string yunCode;

			private string entityName;

			private string entityType;

			private string entityValue;

			private string entityKey;

			private int? taskStatus;

			private string scope;

			private string inputParams;

			private string sceneCode;

			private string sceneName;

			private long? processTime;

			private long? removeTime;

			private string processStrategyUuid;

			private string tenantId;

			private string source;

			private int? removeFlag;

			private int? retryFlag;

			private string errCode;

			private string errMsg;

			private string errTip;

			private string entityUuid;

			private string eventUuid;

			private string reqUuid;

			private string triggerSource;

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

			public string Creator
			{
				get
				{
					return creator;
				}
				set	
				{
					creator = value;
				}
			}

			public long? GmtCreateMillis
			{
				get
				{
					return gmtCreateMillis;
				}
				set	
				{
					gmtCreateMillis = value;
				}
			}

			public long? GmtModifiedMillis
			{
				get
				{
					return gmtModifiedMillis;
				}
				set	
				{
					gmtModifiedMillis = value;
				}
			}

			public string TaskName
			{
				get
				{
					return taskName;
				}
				set	
				{
					taskName = value;
				}
			}

			public string YunCode
			{
				get
				{
					return yunCode;
				}
				set	
				{
					yunCode = value;
				}
			}

			public string EntityName
			{
				get
				{
					return entityName;
				}
				set	
				{
					entityName = value;
				}
			}

			public string EntityType
			{
				get
				{
					return entityType;
				}
				set	
				{
					entityType = value;
				}
			}

			public string EntityValue
			{
				get
				{
					return entityValue;
				}
				set	
				{
					entityValue = value;
				}
			}

			public string EntityKey
			{
				get
				{
					return entityKey;
				}
				set	
				{
					entityKey = value;
				}
			}

			public int? TaskStatus
			{
				get
				{
					return taskStatus;
				}
				set	
				{
					taskStatus = value;
				}
			}

			public string Scope
			{
				get
				{
					return scope;
				}
				set	
				{
					scope = value;
				}
			}

			public string InputParams
			{
				get
				{
					return inputParams;
				}
				set	
				{
					inputParams = value;
				}
			}

			public string SceneCode
			{
				get
				{
					return sceneCode;
				}
				set	
				{
					sceneCode = value;
				}
			}

			public string SceneName
			{
				get
				{
					return sceneName;
				}
				set	
				{
					sceneName = value;
				}
			}

			public long? ProcessTime
			{
				get
				{
					return processTime;
				}
				set	
				{
					processTime = value;
				}
			}

			public long? RemoveTime
			{
				get
				{
					return removeTime;
				}
				set	
				{
					removeTime = value;
				}
			}

			public string ProcessStrategyUuid
			{
				get
				{
					return processStrategyUuid;
				}
				set	
				{
					processStrategyUuid = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public int? RemoveFlag
			{
				get
				{
					return removeFlag;
				}
				set	
				{
					removeFlag = value;
				}
			}

			public int? RetryFlag
			{
				get
				{
					return retryFlag;
				}
				set	
				{
					retryFlag = value;
				}
			}

			public string ErrCode
			{
				get
				{
					return errCode;
				}
				set	
				{
					errCode = value;
				}
			}

			public string ErrMsg
			{
				get
				{
					return errMsg;
				}
				set	
				{
					errMsg = value;
				}
			}

			public string ErrTip
			{
				get
				{
					return errTip;
				}
				set	
				{
					errTip = value;
				}
			}

			public string EntityUuid
			{
				get
				{
					return entityUuid;
				}
				set	
				{
					entityUuid = value;
				}
			}

			public string EventUuid
			{
				get
				{
					return eventUuid;
				}
				set	
				{
					eventUuid = value;
				}
			}

			public string ReqUuid
			{
				get
				{
					return reqUuid;
				}
				set	
				{
					reqUuid = value;
				}
			}

			public string TriggerSource
			{
				get
				{
					return triggerSource;
				}
				set	
				{
					triggerSource = value;
				}
			}
		}

		public class DescribeProcessTasks_Page
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

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
		}
	}
}
