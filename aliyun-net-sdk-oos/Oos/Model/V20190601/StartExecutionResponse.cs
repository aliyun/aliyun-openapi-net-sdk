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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class StartExecutionResponse : AcsResponse
	{

		private string requestId;

		private StartExecution_Execution execution;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Execution")]
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

			private string outputs;

			private string status;

			private string endDate;

			private string executedBy;

			private bool? isParent;

			private string tags;

			private string startDate;

			private string safetyCheck;

			private string mode;

			private string templateName;

			private string createDate;

			private string templateVersion;

			private string executionId;

			private string parameters;

			private string description;

			private string counters;

			private string updateDate;

			private string resourceGroupId;

			private string parentExecutionId;

			private string ramRole;

			private string templateId;

			private string statusMessage;

			private string loopMode;

			private List<StartExecution_CurrentTask> currentTasks;

			[JsonProperty(PropertyName = "Outputs")]
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

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "EndDate")]
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

			[JsonProperty(PropertyName = "ExecutedBy")]
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

			[JsonProperty(PropertyName = "IsParent")]
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

			[JsonProperty(PropertyName = "Tags")]
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

			[JsonProperty(PropertyName = "StartDate")]
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

			[JsonProperty(PropertyName = "SafetyCheck")]
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

			[JsonProperty(PropertyName = "Mode")]
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

			[JsonProperty(PropertyName = "TemplateName")]
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

			[JsonProperty(PropertyName = "CreateDate")]
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

			[JsonProperty(PropertyName = "TemplateVersion")]
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

			[JsonProperty(PropertyName = "ExecutionId")]
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

			[JsonProperty(PropertyName = "Parameters")]
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

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "Counters")]
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

			[JsonProperty(PropertyName = "UpdateDate")]
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

			[JsonProperty(PropertyName = "ResourceGroupId")]
			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			[JsonProperty(PropertyName = "ParentExecutionId")]
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

			[JsonProperty(PropertyName = "RamRole")]
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

			[JsonProperty(PropertyName = "TemplateId")]
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

			[JsonProperty(PropertyName = "StatusMessage")]
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

			[JsonProperty(PropertyName = "LoopMode")]
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

			[JsonProperty(PropertyName = "CurrentTasks")]
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

				[JsonProperty(PropertyName = "TaskExecutionId")]
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

				[JsonProperty(PropertyName = "TaskName")]
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

				[JsonProperty(PropertyName = "TaskAction")]
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
