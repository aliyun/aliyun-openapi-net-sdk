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
	public class ListJobExecutionPlanHierarchyResponse : AcsResponse
	{

		private string requestId;

		private string success;

		private string errCode;

		private string errMsg;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<ListJobExecutionPlanHierarchy_HierarchyInfo> hierarchyInfos;

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

		public string Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public List<ListJobExecutionPlanHierarchy_HierarchyInfo> HierarchyInfos
		{
			get
			{
				return hierarchyInfos;
			}
			set	
			{
				hierarchyInfos = value;
			}
		}

		public class ListJobExecutionPlanHierarchy_HierarchyInfo
		{

			private long? id;

			private string nodeBizType;

			private string nodeType;

			private string relateId;

			private string name;

			private string parentId;

			private string resourceOwnerId;

			private long? utcCreateTimestamp;

			private long? utcModifiedTimestamp;

			private int? nodeStatus;

			private ListJobExecutionPlanHierarchy_ExecutionPlan executionPlan;

			private ListJobExecutionPlanHierarchy_Job job;

			public long? Id
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

			public string NodeBizType
			{
				get
				{
					return nodeBizType;
				}
				set	
				{
					nodeBizType = value;
				}
			}

			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string RelateId
			{
				get
				{
					return relateId;
				}
				set	
				{
					relateId = value;
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

			public string ParentId
			{
				get
				{
					return parentId;
				}
				set	
				{
					parentId = value;
				}
			}

			public string ResourceOwnerId
			{
				get
				{
					return resourceOwnerId;
				}
				set	
				{
					resourceOwnerId = value;
				}
			}

			public long? UtcCreateTimestamp
			{
				get
				{
					return utcCreateTimestamp;
				}
				set	
				{
					utcCreateTimestamp = value;
				}
			}

			public long? UtcModifiedTimestamp
			{
				get
				{
					return utcModifiedTimestamp;
				}
				set	
				{
					utcModifiedTimestamp = value;
				}
			}

			public int? NodeStatus
			{
				get
				{
					return nodeStatus;
				}
				set	
				{
					nodeStatus = value;
				}
			}

			public ListJobExecutionPlanHierarchy_ExecutionPlan ExecutionPlan
			{
				get
				{
					return executionPlan;
				}
				set	
				{
					executionPlan = value;
				}
			}

			public ListJobExecutionPlanHierarchy_Job Job
			{
				get
				{
					return job;
				}
				set	
				{
					job = value;
				}
			}

			public class ListJobExecutionPlanHierarchy_ExecutionPlan
			{

				private string bizId;

				private string name;

				private int? status;

				private int? lastExeStatus;

				private bool? isCreateCluster;

				private bool? isInterruptWhenError;

				private bool? isCycle;

				private string scheduleCycle;

				private string regionId;

				private string cronExpr;

				private long? utcCreateTimestamp;

				private long? utcModifiedTimestamp;

				private string version;

				private string clusterTemplateId;

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

				public int? Status
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

				public int? LastExeStatus
				{
					get
					{
						return lastExeStatus;
					}
					set	
					{
						lastExeStatus = value;
					}
				}

				public bool? IsCreateCluster
				{
					get
					{
						return isCreateCluster;
					}
					set	
					{
						isCreateCluster = value;
					}
				}

				public bool? IsInterruptWhenError
				{
					get
					{
						return isInterruptWhenError;
					}
					set	
					{
						isInterruptWhenError = value;
					}
				}

				public bool? IsCycle
				{
					get
					{
						return isCycle;
					}
					set	
					{
						isCycle = value;
					}
				}

				public string ScheduleCycle
				{
					get
					{
						return scheduleCycle;
					}
					set	
					{
						scheduleCycle = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string CronExpr
				{
					get
					{
						return cronExpr;
					}
					set	
					{
						cronExpr = value;
					}
				}

				public long? UtcCreateTimestamp
				{
					get
					{
						return utcCreateTimestamp;
					}
					set	
					{
						utcCreateTimestamp = value;
					}
				}

				public long? UtcModifiedTimestamp
				{
					get
					{
						return utcModifiedTimestamp;
					}
					set	
					{
						utcModifiedTimestamp = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string ClusterTemplateId
				{
					get
					{
						return clusterTemplateId;
					}
					set	
					{
						clusterTemplateId = value;
					}
				}
			}

			public class ListJobExecutionPlanHierarchy_Job
			{

				private string bizId;

				private string name;

				private int? jobFailAct;

				private int? jobType;

				private string envParam;

				private int? maxRetry;

				private int? retryInterval;

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

				public int? JobFailAct
				{
					get
					{
						return jobFailAct;
					}
					set	
					{
						jobFailAct = value;
					}
				}

				public int? JobType
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

				public string EnvParam
				{
					get
					{
						return envParam;
					}
					set	
					{
						envParam = value;
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

				public int? RetryInterval
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
			}
		}
	}
}
