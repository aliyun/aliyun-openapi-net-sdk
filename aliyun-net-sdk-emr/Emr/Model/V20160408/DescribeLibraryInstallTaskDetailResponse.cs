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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeLibraryInstallTaskDetailResponse : AcsResponse
	{

		private string requestId;

		private string libraryBizId;

		private string taskGroupId;

		private string taskId;

		private string taskStatus;

		private long? startTime;

		private long? endTime;

		private long? executeTime;

		private int? taskProcess;

		private string taskType;

		private string detail;

		private string clusterBizId;

		private string hostname;

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

		public string LibraryBizId
		{
			get
			{
				return libraryBizId;
			}
			set	
			{
				libraryBizId = value;
			}
		}

		public string TaskGroupId
		{
			get
			{
				return taskGroupId;
			}
			set	
			{
				taskGroupId = value;
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

		public string TaskStatus
		{
			get
			{
				return taskStatus;
			}
			set	
			{
				taskStatus = value;
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

		public long? ExecuteTime
		{
			get
			{
				return executeTime;
			}
			set	
			{
				executeTime = value;
			}
		}

		public int? TaskProcess
		{
			get
			{
				return taskProcess;
			}
			set	
			{
				taskProcess = value;
			}
		}

		public string TaskType
		{
			get
			{
				return taskType;
			}
			set	
			{
				taskType = value;
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

		public string ClusterBizId
		{
			get
			{
				return clusterBizId;
			}
			set	
			{
				clusterBizId = value;
			}
		}

		public string Hostname
		{
			get
			{
				return hostname;
			}
			set	
			{
				hostname = value;
			}
		}
	}
}
