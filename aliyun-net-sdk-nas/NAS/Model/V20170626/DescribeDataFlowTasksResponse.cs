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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeDataFlowTasksResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeDataFlowTasks_Task> taskInfo;

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

		public List<DescribeDataFlowTasks_Task> TaskInfo
		{
			get
			{
				return taskInfo;
			}
			set	
			{
				taskInfo = value;
			}
		}

		public class DescribeDataFlowTasks_Task
		{

			private string filesystemId;

			private string dataFlowId;

			private string taskId;

			private string sourceStorage;

			private string fileSystemPath;

			private string originator;

			private string taskAction;

			private string dataType;

			private long? progress;

			private string status;

			private string reportPath;

			private string createTime;

			private string startTime;

			private string endTime;

			private string fsPath;

			public string FilesystemId
			{
				get
				{
					return filesystemId;
				}
				set	
				{
					filesystemId = value;
				}
			}

			public string DataFlowId
			{
				get
				{
					return dataFlowId;
				}
				set	
				{
					dataFlowId = value;
				}
			}

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

			public string SourceStorage
			{
				get
				{
					return sourceStorage;
				}
				set	
				{
					sourceStorage = value;
				}
			}

			public string FileSystemPath
			{
				get
				{
					return fileSystemPath;
				}
				set	
				{
					fileSystemPath = value;
				}
			}

			public string Originator
			{
				get
				{
					return originator;
				}
				set	
				{
					originator = value;
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

			public string DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
				}
			}

			public long? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
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

			public string ReportPath
			{
				get
				{
					return reportPath;
				}
				set	
				{
					reportPath = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string StartTime
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

			public string EndTime
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

			public string FsPath
			{
				get
				{
					return fsPath;
				}
				set	
				{
					fsPath = value;
				}
			}
		}
	}
}
