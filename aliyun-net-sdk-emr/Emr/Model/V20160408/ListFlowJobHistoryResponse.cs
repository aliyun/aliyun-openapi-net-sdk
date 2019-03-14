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
	public class ListFlowJobHistoryResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<ListFlowJobHistory_NodeInstance> nodeInstances;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<ListFlowJobHistory_NodeInstance> NodeInstances
		{
			get
			{
				return nodeInstances;
			}
			set	
			{
				nodeInstances = value;
			}
		}

		public class ListFlowJobHistory_NodeInstance
		{

			private string id;

			private long? gmtCreate;

			private long? gmtModified;

			private string type;

			private string status;

			private string jobId;

			private string jobName;

			private string jobType;

			private string jobParams;

			private string failAct;

			private int? maxRetry;

			private long? retryInterval;

			private string nodeName;

			private string clusterId;

			private string hostName;

			private string projectId;

			private long? startTime;

			private long? endTime;

			private bool? pending;

			private int? retries;

			private string externalId;

			private string externalStatus;

			private string externalInfo;

			private string paramConf;

			private string envConf;

			private string runConf;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string JobName
			{
				get
				{
					return jobName;
				}
				set	
				{
					jobName = value;
				}
			}

			public string JobType
			{
				get
				{
					return jobType;
				}
				set	
				{
					jobType = value;
				}
			}

			public string JobParams
			{
				get
				{
					return jobParams;
				}
				set	
				{
					jobParams = value;
				}
			}

			public string FailAct
			{
				get
				{
					return failAct;
				}
				set	
				{
					failAct = value;
				}
			}

			public int? MaxRetry
			{
				get
				{
					return maxRetry;
				}
				set	
				{
					maxRetry = value;
				}
			}

			public long? RetryInterval
			{
				get
				{
					return retryInterval;
				}
				set	
				{
					retryInterval = value;
				}
			}

			public string NodeName
			{
				get
				{
					return nodeName;
				}
				set	
				{
					nodeName = value;
				}
			}

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
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

			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
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

			public bool? Pending
			{
				get
				{
					return pending;
				}
				set	
				{
					pending = value;
				}
			}

			public int? Retries
			{
				get
				{
					return retries;
				}
				set	
				{
					retries = value;
				}
			}

			public string ExternalId
			{
				get
				{
					return externalId;
				}
				set	
				{
					externalId = value;
				}
			}

			public string ExternalStatus
			{
				get
				{
					return externalStatus;
				}
				set	
				{
					externalStatus = value;
				}
			}

			public string ExternalInfo
			{
				get
				{
					return externalInfo;
				}
				set	
				{
					externalInfo = value;
				}
			}

			public string ParamConf
			{
				get
				{
					return paramConf;
				}
				set	
				{
					paramConf = value;
				}
			}

			public string EnvConf
			{
				get
				{
					return envConf;
				}
				set	
				{
					envConf = value;
				}
			}

			public string RunConf
			{
				get
				{
					return runConf;
				}
				set	
				{
					runConf = value;
				}
			}
		}
	}
}
