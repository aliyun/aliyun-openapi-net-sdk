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
	public class DescribeFlowInstanceResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private long? gmtCreate;

		private long? gmtModified;

		private string flowId;

		private string flowName;

		private string projectId;

		private string status;

		private string clusterId;

		private string _namespace;

		private string logArchiveLocation;

		private string lifecycle;

		private long? startTime;

		private long? endTime;

		private long? duration;

		private long? scheduleTime;

		private string graph;

		private string cronExpression;

		private bool? hasNodeFailed;

		private List<DescribeFlowInstance_ParentFlow> dependencyFlowList;

		private List<DescribeFlowInstance_NodeInstanceItem> nodeInstance;

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

		public string FlowId
		{
			get
			{
				return flowId;
			}
			set	
			{
				flowId = value;
			}
		}

		public string FlowName
		{
			get
			{
				return flowName;
			}
			set	
			{
				flowName = value;
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

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
			}
		}

		public string LogArchiveLocation
		{
			get
			{
				return logArchiveLocation;
			}
			set	
			{
				logArchiveLocation = value;
			}
		}

		public string Lifecycle
		{
			get
			{
				return lifecycle;
			}
			set	
			{
				lifecycle = value;
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

		public long? Duration
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

		public long? ScheduleTime
		{
			get
			{
				return scheduleTime;
			}
			set	
			{
				scheduleTime = value;
			}
		}

		public string Graph
		{
			get
			{
				return graph;
			}
			set	
			{
				graph = value;
			}
		}

		public string CronExpression
		{
			get
			{
				return cronExpression;
			}
			set	
			{
				cronExpression = value;
			}
		}

		public bool? HasNodeFailed
		{
			get
			{
				return hasNodeFailed;
			}
			set	
			{
				hasNodeFailed = value;
			}
		}

		public List<DescribeFlowInstance_ParentFlow> DependencyFlowList
		{
			get
			{
				return dependencyFlowList;
			}
			set	
			{
				dependencyFlowList = value;
			}
		}

		public List<DescribeFlowInstance_NodeInstanceItem> NodeInstance
		{
			get
			{
				return nodeInstance;
			}
			set	
			{
				nodeInstance = value;
			}
		}

		public class DescribeFlowInstance_ParentFlow
		{

			private string projectId;

			private string flowId;

			private string dependencyFlowId;

			private string flowInstanceId;

			private string dependencyInstanceId;

			private string scheduleKey;

			private long? bizDate;

			private bool? meet;

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

			public string FlowId
			{
				get
				{
					return flowId;
				}
				set	
				{
					flowId = value;
				}
			}

			public string DependencyFlowId
			{
				get
				{
					return dependencyFlowId;
				}
				set	
				{
					dependencyFlowId = value;
				}
			}

			public string FlowInstanceId
			{
				get
				{
					return flowInstanceId;
				}
				set	
				{
					flowInstanceId = value;
				}
			}

			public string DependencyInstanceId
			{
				get
				{
					return dependencyInstanceId;
				}
				set	
				{
					dependencyInstanceId = value;
				}
			}

			public string ScheduleKey
			{
				get
				{
					return scheduleKey;
				}
				set	
				{
					scheduleKey = value;
				}
			}

			public long? BizDate
			{
				get
				{
					return bizDate;
				}
				set	
				{
					bizDate = value;
				}
			}

			public bool? Meet
			{
				get
				{
					return meet;
				}
				set	
				{
					meet = value;
				}
			}
		}

		public class DescribeFlowInstance_NodeInstanceItem
		{

			private string id;

			private long? gmtCreate;

			private long? gmtModified;

			private string type;

			private string status;

			private string jobId;

			private string jobName;

			private string jobType;

			private string failAct;

			private string maxRetry;

			private string retryInterval;

			private string nodeName;

			private string clusterId;

			private string hostName;

			private string projectId;

			private bool? pending;

			private long? startTime;

			private long? endTime;

			private long? duration;

			private int? retries;

			private string externalId;

			private string externalStatus;

			private string externalInfo;

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

			public string MaxRetry
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

			public string RetryInterval
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

			public long? Duration
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
		}
	}
}
