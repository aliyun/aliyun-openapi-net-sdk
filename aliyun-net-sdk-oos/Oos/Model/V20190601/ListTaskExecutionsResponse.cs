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
	public class ListTaskExecutionsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListTaskExecutions_TaskExecution> taskExecutions;

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

		[JsonProperty(PropertyName = "TaskExecutions")]
		public List<ListTaskExecutions_TaskExecution> TaskExecutions
		{
			get
			{
				return taskExecutions;
			}
			set	
			{
				taskExecutions = value;
			}
		}

		public class ListTaskExecutions_TaskExecution
		{

			private string childExecutionId;

			private string outputs;

			private string status;

			private string endDate;

			private string parentTaskExecutionId;

			private string taskName;

			private string startDate;

			private string loopItem;

			private string createDate;

			private string executionId;

			private string taskAction;

			private string taskExecutionId;

			private string updateDate;

			private string loop;

			private string templateId;

			private int? loopBatchNumber;

			private string statusMessage;

			private string extraData;

			private string properties;

			[JsonProperty(PropertyName = "ChildExecutionId")]
			public string ChildExecutionId
			{
				get
				{
					return childExecutionId;
				}
				set	
				{
					childExecutionId = value;
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

			[JsonProperty(PropertyName = "ParentTaskExecutionId")]
			public string ParentTaskExecutionId
			{
				get
				{
					return parentTaskExecutionId;
				}
				set	
				{
					parentTaskExecutionId = value;
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

			[JsonProperty(PropertyName = "LoopItem")]
			public string LoopItem
			{
				get
				{
					return loopItem;
				}
				set	
				{
					loopItem = value;
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

			[JsonProperty(PropertyName = "Loop")]
			public string Loop
			{
				get
				{
					return loop;
				}
				set	
				{
					loop = value;
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

			[JsonProperty(PropertyName = "LoopBatchNumber")]
			public int? LoopBatchNumber
			{
				get
				{
					return loopBatchNumber;
				}
				set	
				{
					loopBatchNumber = value;
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

			[JsonProperty(PropertyName = "ExtraData")]
			public string ExtraData
			{
				get
				{
					return extraData;
				}
				set	
				{
					extraData = value;
				}
			}

			[JsonProperty(PropertyName = "Properties")]
			public string Properties
			{
				get
				{
					return properties;
				}
				set	
				{
					properties = value;
				}
			}
		}
	}
}
