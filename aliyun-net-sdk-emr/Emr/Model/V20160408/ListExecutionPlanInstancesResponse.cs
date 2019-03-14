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
	public class ListExecutionPlanInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListExecutionPlanInstances_ExecutionPlanInstance> executionPlanInstances;

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

		public List<ListExecutionPlanInstances_ExecutionPlanInstance> ExecutionPlanInstances
		{
			get
			{
				return executionPlanInstances;
			}
			set	
			{
				executionPlanInstances = value;
			}
		}

		public class ListExecutionPlanInstances_ExecutionPlanInstance
		{

			private string id;

			private string executionPlanId;

			private string executionPlanName;

			private long? startTime;

			private int? runTime;

			private string clusterId;

			private string clusterName;

			private string clusterType;

			private string status;

			private bool? logEnable;

			private string logPath;

			private string workflowApp;

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

			public string ExecutionPlanId
			{
				get
				{
					return executionPlanId;
				}
				set	
				{
					executionPlanId = value;
				}
			}

			public string ExecutionPlanName
			{
				get
				{
					return executionPlanName;
				}
				set	
				{
					executionPlanName = value;
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

			public int? RunTime
			{
				get
				{
					return runTime;
				}
				set	
				{
					runTime = value;
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

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
				}
			}

			public string ClusterType
			{
				get
				{
					return clusterType;
				}
				set	
				{
					clusterType = value;
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

			public bool? LogEnable
			{
				get
				{
					return logEnable;
				}
				set	
				{
					logEnable = value;
				}
			}

			public string LogPath
			{
				get
				{
					return logPath;
				}
				set	
				{
					logPath = value;
				}
			}

			public string WorkflowApp
			{
				get
				{
					return workflowApp;
				}
				set	
				{
					workflowApp = value;
				}
			}
		}
	}
}
