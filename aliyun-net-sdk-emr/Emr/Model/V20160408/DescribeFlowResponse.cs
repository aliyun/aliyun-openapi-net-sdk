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
	public class DescribeFlowResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private long? gmtCreate;

		private long? gmtModified;

		private string name;

		private string description;

		private string type;

		private string status;

		private bool? periodic;

		private long? startSchedule;

		private long? endSchedule;

		private string cronExpr;

		private bool? createCluster;

		private string clusterId;

		private string hostName;

		private string _namespace;

		private string logArchiveLocation;

		private string lifecycle;

		private string graph;

		private string categoryId;

		private string alertConf;

		private string alertUserGroupBizId;

		private string alertDingDingGroupBizId;

		private string application;

		private string editLockDetail;

		private List<DescribeFlow_ParentFlow> parentFlowList;

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
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

		public bool? Periodic
		{
			get
			{
				return periodic;
			}
			set	
			{
				periodic = value;
			}
		}

		public long? StartSchedule
		{
			get
			{
				return startSchedule;
			}
			set	
			{
				startSchedule = value;
			}
		}

		public long? EndSchedule
		{
			get
			{
				return endSchedule;
			}
			set	
			{
				endSchedule = value;
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

		public bool? CreateCluster
		{
			get
			{
				return createCluster;
			}
			set	
			{
				createCluster = value;
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

		public string CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
			}
		}

		public string AlertConf
		{
			get
			{
				return alertConf;
			}
			set	
			{
				alertConf = value;
			}
		}

		public string AlertUserGroupBizId
		{
			get
			{
				return alertUserGroupBizId;
			}
			set	
			{
				alertUserGroupBizId = value;
			}
		}

		public string AlertDingDingGroupBizId
		{
			get
			{
				return alertDingDingGroupBizId;
			}
			set	
			{
				alertDingDingGroupBizId = value;
			}
		}

		public string Application
		{
			get
			{
				return application;
			}
			set	
			{
				application = value;
			}
		}

		public string EditLockDetail
		{
			get
			{
				return editLockDetail;
			}
			set	
			{
				editLockDetail = value;
			}
		}

		public List<DescribeFlow_ParentFlow> ParentFlowList
		{
			get
			{
				return parentFlowList;
			}
			set	
			{
				parentFlowList = value;
			}
		}

		public class DescribeFlow_ParentFlow
		{

			private string parentFlowId;

			private string parentFlowName;

			private string projectId;

			private string projectName;

			public string ParentFlowId
			{
				get
				{
					return parentFlowId;
				}
				set	
				{
					parentFlowId = value;
				}
			}

			public string ParentFlowName
			{
				get
				{
					return parentFlowName;
				}
				set	
				{
					parentFlowName = value;
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

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}
		}
	}
}
