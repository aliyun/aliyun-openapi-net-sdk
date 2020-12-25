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
	public class CreateBackupResponse : AcsResponse
	{

		private string requestId;

		private string bizId;

		private long? dataSourceId;

		private string taskType;

		private string taskStatus;

		private long? startTime;

		private long? endTime;

		private string taskDetail;

		private string taskResultDetail;

		private int? taskProcess;

		private string triggerUser;

		private string triggerType;

		private long? gmtCreate;

		private long? gmtModified;

		private string clusterBizId;

		private string hostName;

		private long? ecmTaskId;

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

		public string BizId
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

		public long? DataSourceId
		{
			get
			{
				return dataSourceId;
			}
			set	
			{
				dataSourceId = value;
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

		public string TaskDetail
		{
			get
			{
				return taskDetail;
			}
			set	
			{
				taskDetail = value;
			}
		}

		public string TaskResultDetail
		{
			get
			{
				return taskResultDetail;
			}
			set	
			{
				taskResultDetail = value;
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

		public string TriggerUser
		{
			get
			{
				return triggerUser;
			}
			set	
			{
				triggerUser = value;
			}
		}

		public string TriggerType
		{
			get
			{
				return triggerType;
			}
			set	
			{
				triggerType = value;
			}
		}

		public long? GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
			}
		}

		public long? GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
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

		public string HostName
		{
			get
			{
				return hostName;
			}
			set	
			{
				hostName = value;
			}
		}

		public long? EcmTaskId
		{
			get
			{
				return ecmTaskId;
			}
			set	
			{
				ecmTaskId = value;
			}
		}
	}
}
