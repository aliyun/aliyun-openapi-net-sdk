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
	public class ListExecutionsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListExecutions_Execution> executions;

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

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

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		[JsonProperty(PropertyName = "Executions")]
		public List<ListExecutions_Execution> Executions
		{
			get
			{
				return executions;
			}
			set	
			{
				executions = value;
			}
		}

		public class ListExecutions_Execution
		{

			private string status;

			private string waitingStatus;

			private string targets;

			private string statusReason;

			private string tags;

			private string lastSuccessfulTriggerTime;

			private string mode;

			private string safetyCheck;

			private string templateName;

			private string templateVersion;

			private string createDate;

			private string updateDate;

			private string description;

			private string lastTriggerTime;

			private string parentExecutionId;

			private string lastTriggerStatus;

			private string statusMessage;

			private string outputs;

			private string executedBy;

			private string endDate;

			private bool? isParent;

			private string startDate;

			private string executionId;

			private string parameters;

			private string counters;

			private string resourceGroupId;

			private string category;

			private string templateId;

			private string ramRole;

			private string resourceStatus;

			private string lastTriggerStatusMessage;

			private string lastTriggerOutputs;

			private List<ListExecutions_CurrentTask> currentTasks;

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

			[JsonProperty(PropertyName = "WaitingStatus")]
			public string WaitingStatus
			{
				get
				{
					return waitingStatus;
				}
				set	
				{
					waitingStatus = value;
				}
			}

			[JsonProperty(PropertyName = "Targets")]
			public string Targets
			{
				get
				{
					return targets;
				}
				set	
				{
					targets = value;
				}
			}

			[JsonProperty(PropertyName = "StatusReason")]
			public string StatusReason
			{
				get
				{
					return statusReason;
				}
				set	
				{
					statusReason = value;
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

			[JsonProperty(PropertyName = "LastSuccessfulTriggerTime")]
			public string LastSuccessfulTriggerTime
			{
				get
				{
					return lastSuccessfulTriggerTime;
				}
				set	
				{
					lastSuccessfulTriggerTime = value;
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

			[JsonProperty(PropertyName = "LastTriggerTime")]
			public string LastTriggerTime
			{
				get
				{
					return lastTriggerTime;
				}
				set	
				{
					lastTriggerTime = value;
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

			[JsonProperty(PropertyName = "LastTriggerStatus")]
			public string LastTriggerStatus
			{
				get
				{
					return lastTriggerStatus;
				}
				set	
				{
					lastTriggerStatus = value;
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

			[JsonProperty(PropertyName = "Category")]
			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
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

			[JsonProperty(PropertyName = "ResourceStatus")]
			public string ResourceStatus
			{
				get
				{
					return resourceStatus;
				}
				set	
				{
					resourceStatus = value;
				}
			}

			[JsonProperty(PropertyName = "LastTriggerStatusMessage")]
			public string LastTriggerStatusMessage
			{
				get
				{
					return lastTriggerStatusMessage;
				}
				set	
				{
					lastTriggerStatusMessage = value;
				}
			}

			[JsonProperty(PropertyName = "LastTriggerOutputs")]
			public string LastTriggerOutputs
			{
				get
				{
					return lastTriggerOutputs;
				}
				set	
				{
					lastTriggerOutputs = value;
				}
			}

			[JsonProperty(PropertyName = "CurrentTasks")]
			public List<ListExecutions_CurrentTask> CurrentTasks
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

			public class ListExecutions_CurrentTask
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
