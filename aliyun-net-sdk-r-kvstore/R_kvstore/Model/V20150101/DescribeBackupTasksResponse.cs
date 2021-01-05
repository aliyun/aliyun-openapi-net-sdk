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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeBackupTasksResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private List<DescribeBackupTasks_BackupJob> backupJobs;

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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public List<DescribeBackupTasks_BackupJob> BackupJobs
		{
			get
			{
				return backupJobs;
			}
			set	
			{
				backupJobs = value;
			}
		}

		public class DescribeBackupTasks_BackupJob
		{

			private int? backupJobID;

			private string backupProgressStatus;

			private string jobMode;

			private string process;

			private string startTime;

			private string taskAction;

			public int? BackupJobID
			{
				get
				{
					return backupJobID;
				}
				set	
				{
					backupJobID = value;
				}
			}

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
