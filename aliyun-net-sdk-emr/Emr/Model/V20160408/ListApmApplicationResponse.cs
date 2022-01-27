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
	public class ListApmApplicationResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private int? pageSize;

		private int? pageNumber;

		private List<ListApmApplication_ApmAppInfo> apmAppInfoList;

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

		public List<ListApmApplication_ApmAppInfo> ApmAppInfoList
		{
			get
			{
				return apmAppInfoList;
			}
			set	
			{
				apmAppInfoList = value;
			}
		}

		public class ListApmApplication_ApmAppInfo
		{

			private string applicationId;

			private string clusterBizId;

			private string applicationType;

			private string name;

			private string state;

			private string finalStatus;

			private string queue;

			private string user;

			private long? allocatedVcore;

			private long? allocatedMemory;

			private float? progress;

			private long? vcoreSeconds;

			private long? memorySeconds;

			private long? startTime;

			private long? submitTime;

			private long? finishedTime;

			private int? duration;

			private string diagnostics;

			private float? clusterUsagePercent;

			private float? queueUsagePercent;

			private int? runningContainers;

			private int? runningDuration;

			private string resourceRequests;

			private string diagnoseResult;

			private string diagnoseCode;

			public string ApplicationId
			{
				get
				{
					return applicationId;
				}
				set	
				{
					applicationId = value;
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

			public string ApplicationType
			{
				get
				{
					return applicationType;
				}
				set	
				{
					applicationType = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string FinalStatus
			{
				get
				{
					return finalStatus;
				}
				set	
				{
					finalStatus = value;
				}
			}

			public string Queue
			{
				get
				{
					return queue;
				}
				set	
				{
					queue = value;
				}
			}

			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
				}
			}

			public long? AllocatedVcore
			{
				get
				{
					return allocatedVcore;
				}
				set	
				{
					allocatedVcore = value;
				}
			}

			public long? AllocatedMemory
			{
				get
				{
					return allocatedMemory;
				}
				set	
				{
					allocatedMemory = value;
				}
			}

			public float? Progress
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

			public long? VcoreSeconds
			{
				get
				{
					return vcoreSeconds;
				}
				set	
				{
					vcoreSeconds = value;
				}
			}

			public long? MemorySeconds
			{
				get
				{
					return memorySeconds;
				}
				set	
				{
					memorySeconds = value;
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

			public long? SubmitTime
			{
				get
				{
					return submitTime;
				}
				set	
				{
					submitTime = value;
				}
			}

			public long? FinishedTime
			{
				get
				{
					return finishedTime;
				}
				set	
				{
					finishedTime = value;
				}
			}

			public int? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string Diagnostics
			{
				get
				{
					return diagnostics;
				}
				set	
				{
					diagnostics = value;
				}
			}

			public float? ClusterUsagePercent
			{
				get
				{
					return clusterUsagePercent;
				}
				set	
				{
					clusterUsagePercent = value;
				}
			}

			public float? QueueUsagePercent
			{
				get
				{
					return queueUsagePercent;
				}
				set	
				{
					queueUsagePercent = value;
				}
			}

			public int? RunningContainers
			{
				get
				{
					return runningContainers;
				}
				set	
				{
					runningContainers = value;
				}
			}

			public int? RunningDuration
			{
				get
				{
					return runningDuration;
				}
				set	
				{
					runningDuration = value;
				}
			}

			public string ResourceRequests
			{
				get
				{
					return resourceRequests;
				}
				set	
				{
					resourceRequests = value;
				}
			}

			public string DiagnoseResult
			{
				get
				{
					return diagnoseResult;
				}
				set	
				{
					diagnoseResult = value;
				}
			}

			public string DiagnoseCode
			{
				get
				{
					return diagnoseCode;
				}
				set	
				{
					diagnoseCode = value;
				}
			}
		}
	}
}
