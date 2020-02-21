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
	public class ListTaskExecutionsResponse : AcsResponse
	{

		private string requestId;

		private int? maxResults;

		private string nextToken;

		private List<ListTaskExecutions_TaskExecution> taskExecutions;

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

			private string executionId;

			private string taskExecutionId;

			private string templateId;

			private string startDate;

			private string endDate;

			private string createDate;

			private string updateDate;

			private string status;

			private string properties;

			private string outputs;

			private string taskAction;

			private string taskName;

			private string statusMessage;

			private string childExecutionId;

			private string parentTaskExecutionId;

			private string loopItem;

			private string loop;

			private string extraData;

			private int? loopBatchNumber;

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
		}
	}
}
