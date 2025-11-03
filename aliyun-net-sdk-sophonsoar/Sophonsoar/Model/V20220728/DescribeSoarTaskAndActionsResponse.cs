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
	public class DescribeSoarTaskAndActionsResponse : AcsResponse
	{

		private string requestId;

		private DescribeSoarTaskAndActions_Details details;

		private DescribeSoarTaskAndActions_Page page;

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

		public DescribeSoarTaskAndActions_Details Details
		{
			get
			{
				return details;
			}
			set	
			{
				details = value;
			}
		}

		public DescribeSoarTaskAndActions_Page Page
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

		public class DescribeSoarTaskAndActions_Details
		{

			private string triggerType;

			private string taskName;

			private long? startTime;

			private long? endTime;

			private string status;

			private string requestUuid;

			private string taskUuid;

			private string triggerUser;

			private string errorMsg;

			private string rawEventReq;

			private string taskFlowMd5;

			private int? actionLogNum;

			private List<DescribeSoarTaskAndActions_Action> actions;

			public string TriggerType
			{
				get
				{
					return triggerType;
				}
				set	
				{
					triggerType = value;
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

			public long? StartTime
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

			public long? EndTime
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

			public string RequestUuid
			{
				get
				{
					return requestUuid;
				}
				set	
				{
					requestUuid = value;
				}
			}

			public string TaskUuid
			{
				get
				{
					return taskUuid;
				}
				set	
				{
					taskUuid = value;
				}
			}

			public string TriggerUser
			{
				get
				{
					return triggerUser;
				}
				set	
				{
					triggerUser = value;
				}
			}

			public string ErrorMsg
			{
				get
				{
					return errorMsg;
				}
				set	
				{
					errorMsg = value;
				}
			}

			public string RawEventReq
			{
				get
				{
					return rawEventReq;
				}
				set	
				{
					rawEventReq = value;
				}
			}

			public string TaskFlowMd5
			{
				get
				{
					return taskFlowMd5;
				}
				set	
				{
					taskFlowMd5 = value;
				}
			}

			public int? ActionLogNum
			{
				get
				{
					return actionLogNum;
				}
				set	
				{
					actionLogNum = value;
				}
			}

			public List<DescribeSoarTaskAndActions_Action> Actions
			{
				get
				{
					return actions;
				}
				set	
				{
					actions = value;
				}
			}

			public class DescribeSoarTaskAndActions_Action
			{

				private string component;

				private string action;

				private long? startTime;

				private long? endTime;

				private string status;

				private string actionUuid;

				private string assetName;

				private string nodeName;

				private string nodeId;

				private string nodeType;

				public string Component
				{
					get
					{
						return component;
					}
					set	
					{
						component = value;
					}
				}

				public string Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
					}
				}

				public long? StartTime
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

				public long? EndTime
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

				public string ActionUuid
				{
					get
					{
						return actionUuid;
					}
					set	
					{
						actionUuid = value;
					}
				}

				public string AssetName
				{
					get
					{
						return assetName;
					}
					set	
					{
						assetName = value;
					}
				}

				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				public string NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}

				public string NodeType
				{
					get
					{
						return nodeType;
					}
					set	
					{
						nodeType = value;
					}
				}
			}
		}

		public class DescribeSoarTaskAndActions_Page
		{

			private string totalCount;

			private string pageNumber;

			private string pageSize;

			public string TotalCount
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

			public string PageNumber
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

			public string PageSize
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
