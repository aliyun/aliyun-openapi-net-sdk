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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetRemindResponse : AcsResponse
	{

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private GetRemind_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public GetRemind_Data Data
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

		public class GetRemind_Data
		{

			private long? remindId;

			private string remindName;

			private string dndStart;

			private string dndEnd;

			private string remindUnit;

			private string remindType;

			private string alertUnit;

			private bool? useflag;

			private string founder;

			private int? alertInterval;

			private string detail;

			private int? maxAlertTimes;

			private List<GetRemind_RobotsItem> robots;

			private List<GetRemind_NodesItem> nodes;

			private List<GetRemind_BaselinesItem> baselines;

			private List<GetRemind_ProjectsItem> projects;

			private List<GetRemind_BizProcessesItem> bizProcesses;

			private List<string> alertMethods;

			private List<string> alertTargets;

			public long? RemindId
			{
				get
				{
					return remindId;
				}
				set	
				{
					remindId = value;
				}
			}

			public string RemindName
			{
				get
				{
					return remindName;
				}
				set	
				{
					remindName = value;
				}
			}

			public string DndStart
			{
				get
				{
					return dndStart;
				}
				set	
				{
					dndStart = value;
				}
			}

			public string DndEnd
			{
				get
				{
					return dndEnd;
				}
				set	
				{
					dndEnd = value;
				}
			}

			public string RemindUnit
			{
				get
				{
					return remindUnit;
				}
				set	
				{
					remindUnit = value;
				}
			}

			public string RemindType
			{
				get
				{
					return remindType;
				}
				set	
				{
					remindType = value;
				}
			}

			public string AlertUnit
			{
				get
				{
					return alertUnit;
				}
				set	
				{
					alertUnit = value;
				}
			}

			public bool? Useflag
			{
				get
				{
					return useflag;
				}
				set	
				{
					useflag = value;
				}
			}

			public string Founder
			{
				get
				{
					return founder;
				}
				set	
				{
					founder = value;
				}
			}

			public int? AlertInterval
			{
				get
				{
					return alertInterval;
				}
				set	
				{
					alertInterval = value;
				}
			}

			public string Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public int? MaxAlertTimes
			{
				get
				{
					return maxAlertTimes;
				}
				set	
				{
					maxAlertTimes = value;
				}
			}

			public List<GetRemind_RobotsItem> Robots
			{
				get
				{
					return robots;
				}
				set	
				{
					robots = value;
				}
			}

			public List<GetRemind_NodesItem> Nodes
			{
				get
				{
					return nodes;
				}
				set	
				{
					nodes = value;
				}
			}

			public List<GetRemind_BaselinesItem> Baselines
			{
				get
				{
					return baselines;
				}
				set	
				{
					baselines = value;
				}
			}

			public List<GetRemind_ProjectsItem> Projects
			{
				get
				{
					return projects;
				}
				set	
				{
					projects = value;
				}
			}

			public List<GetRemind_BizProcessesItem> BizProcesses
			{
				get
				{
					return bizProcesses;
				}
				set	
				{
					bizProcesses = value;
				}
			}

			public List<string> AlertMethods
			{
				get
				{
					return alertMethods;
				}
				set	
				{
					alertMethods = value;
				}
			}

			public List<string> AlertTargets
			{
				get
				{
					return alertTargets;
				}
				set	
				{
					alertTargets = value;
				}
			}

			public class GetRemind_RobotsItem
			{

				private string webUrl;

				private bool? atAll;

				public string WebUrl
				{
					get
					{
						return webUrl;
					}
					set	
					{
						webUrl = value;
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
			}

			public class GetRemind_NodesItem
			{

				private long? nodeId;

				private string nodeName;

				private string owner;

				private long? projectId;

				public long? NodeId
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

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}
			}

			public class GetRemind_BaselinesItem
			{

				private long? baselineId;

				private string baselineName;

				public long? BaselineId
				{
					get
					{
						return baselineId;
					}
					set	
					{
						baselineId = value;
					}
				}

				public string BaselineName
				{
					get
					{
						return baselineName;
					}
					set	
					{
						baselineName = value;
					}
				}
			}

			public class GetRemind_ProjectsItem
			{

				private long? projectId;

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}
			}

			public class GetRemind_BizProcessesItem
			{

				private long? bizId;

				private string bizProcessName;

				public long? BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
					}
				}

				public string BizProcessName
				{
					get
					{
						return bizProcessName;
					}
					set	
					{
						bizProcessName = value;
					}
				}
			}
		}
	}
}
