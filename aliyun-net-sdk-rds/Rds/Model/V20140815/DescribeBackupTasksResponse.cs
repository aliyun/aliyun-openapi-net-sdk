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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeBackupTasksResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeBackupTasks_BackupJob> items;

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

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeBackupTasks_BackupJob> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeBackupTasks_BackupJob
		{

			private string process;

			private string backupJobId;

			private string backupStatus;

			private string jobMode;

			private string backupProgressStatus;

			private string backupId;

			private string taskAction;

			[JsonProperty(PropertyName = "Process")]
			public string Process
			{
				get
				{
					return process;
				}
				set	
				{
					process = value;
				}
			}

			[JsonProperty(PropertyName = "BackupJobId")]
			public string BackupJobId
			{
				get
				{
					return backupJobId;
				}
				set	
				{
					backupJobId = value;
				}
			}

			[JsonProperty(PropertyName = "BackupStatus")]
			public string BackupStatus
			{
				get
				{
					return backupStatus;
				}
				set	
				{
					backupStatus = value;
				}
			}

			[JsonProperty(PropertyName = "JobMode")]
			public string JobMode
			{
				get
				{
					return jobMode;
				}
				set	
				{
					jobMode = value;
				}
			}

			[JsonProperty(PropertyName = "BackupProgressStatus")]
			public string BackupProgressStatus
			{
				get
				{
					return backupProgressStatus;
				}
				set	
				{
					backupProgressStatus = value;
				}
			}

			[JsonProperty(PropertyName = "BackupId")]
			public string BackupId
			{
				get
				{
					return backupId;
				}
				set	
				{
					backupId = value;
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
