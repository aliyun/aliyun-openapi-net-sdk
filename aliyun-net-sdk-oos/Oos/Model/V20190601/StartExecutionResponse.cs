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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class StartExecutionResponse : AcsResponse
	{

		private string requestId;

		private StartExecution_Execution execution;

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

		public StartExecution_Execution Execution
		{
			get
			{
				return execution;
			}
			set	
			{
				execution = value;
			}
		}

		public class StartExecution_Execution
		{

			private string executionId;

			private string templateName;

			private string templateId;

			private string templateVersion;

			private string mode;

			private string loopMode;

			private string executedBy;

			private string startDate;

			private string endDate;

			private string createDate;

			private string updateDate;

			private string status;

			private string statusMessage;

			private string parentExecutionId;

			private string parameters;

			private string outputs;

			private string safetyCheck;

			private bool? isParent;

			private string counters;

			private string ramRole;

			private string tags;

			private string description;

			private List<StartExecution_CurrentTask> currentTasks;

			public string ExecutionId
			{
				get
				{
					return executionId;
				}
				set	
				{
					executionId = value;
				}
			}

			public string TemplateName
			{
				get
				{
					return templateName;
				}
				set	
				{
					templateName = value;
				}
			}

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			public string TemplateVersion
			{
				get
				{
					return templateVersion;
				}
				set	
				{
					templateVersion = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			public string LoopMode
			{
				get
				{
					return loopMode;
				}
				set	
				{
					loopMode = value;
				}
			}

			public string ExecutedBy
			{
				get
				{
					return executedBy;
				}
				set	
				{
					executedBy = value;
				}
			}

			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
				}
			}

			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
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

			public string StatusMessage
			{
				get
				{
					return statusMessage;
				}
				set	
				{
					statusMessage = value;
				}
			}

			public string ParentExecutionId
			{
				get
				{
					return parentExecutionId;
				}
				set	
				{
					parentExecutionId = value;
				}
			}

			public string Parameters
			{
				get
				{
					return parameters;
				}
				set	
				{
					parameters = value;
				}
			}

			public string Outputs
			{
				get
				{
					return outputs;
				}
				set	
				{
					outputs = value;
				}
			}

			public string SafetyCheck
			{
				get
				{
					return safetyCheck;
				}
				set	
				{
					safetyCheck = value;
				}
			}

			public bool? IsParent
			{
				get
				{
					return isParent;
				}
				set	
				{
					isParent = value;
				}
			}

			public string Counters
			{
				get
				{
					return counters;
				}
				set	
				{
					counters = value;
				}
			}

			public string RamRole
			{
				get
				{
					return ramRole;
				}
				set	
				{
					ramRole = value;
				}
			}

			public string Tags
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

			public List<StartExecution_CurrentTask> CurrentTasks
			{
				get
				{
					return currentTasks;
				}
				set	
				{
					currentTasks = value;
				}
			}

			public class StartExecution_CurrentTask
			{

				private string taskExecutionId;

				private string taskName;

				private string taskAction;

				public string TaskExecutionId
				{
					get
					{
						return taskExecutionId;
					}
					set	
					{
						taskExecutionId = value;
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

				public string TaskAction
				{
					get
					{
						return taskAction;
					}
					set	
					{
						taskAction = value;
					}
				}
			}
		}
	}
}
