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
	public class ListClusterServiceResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListClusterService_ClusterService> clusterServiceList;

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

		public List<ListClusterService_ClusterService> ClusterServiceList
		{
			get
			{
				return clusterServiceList;
			}
			set	
			{
				clusterServiceList = value;
			}
		}

		public class ListClusterService_ClusterService
		{

			private string serviceName;

			private string serviceDisplayName;

			private string serviceVersion;

			private bool? installStatus;

			private bool? clientType;

			private string serviceStatus;

			private string healthStatus;

			private string needRestartInfo;

			private string notStartInfo;

			private int? abnormalNum;

			private int? stoppedNum;

			private int? needRestartNum;

			private string state;

			private List<ListClusterService_ServiceAction> serviceActionList;

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string ServiceDisplayName
			{
				get
				{
					return serviceDisplayName;
				}
				set	
				{
					serviceDisplayName = value;
				}
			}

			public string ServiceVersion
			{
				get
				{
					return serviceVersion;
				}
				set	
				{
					serviceVersion = value;
				}
			}

			public bool? InstallStatus
			{
				get
				{
					return installStatus;
				}
				set	
				{
					installStatus = value;
				}
			}

			public bool? ClientType
			{
				get
				{
					return clientType;
				}
				set	
				{
					clientType = value;
				}
			}

			public string ServiceStatus
			{
				get
				{
					return serviceStatus;
				}
				set	
				{
					serviceStatus = value;
				}
			}

			public string HealthStatus
			{
				get
				{
					return healthStatus;
				}
				set	
				{
					healthStatus = value;
				}
			}

			public string NeedRestartInfo
			{
				get
				{
					return needRestartInfo;
				}
				set	
				{
					needRestartInfo = value;
				}
			}

			public string NotStartInfo
			{
				get
				{
					return notStartInfo;
				}
				set	
				{
					notStartInfo = value;
				}
			}

			public int? AbnormalNum
			{
				get
				{
					return abnormalNum;
				}
				set	
				{
					abnormalNum = value;
				}
			}

			public int? StoppedNum
			{
				get
				{
					return stoppedNum;
				}
				set	
				{
					stoppedNum = value;
				}
			}

			public int? NeedRestartNum
			{
				get
				{
					return needRestartNum;
				}
				set	
				{
					needRestartNum = value;
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

			public List<ListClusterService_ServiceAction> ServiceActionList
			{
				get
				{
					return serviceActionList;
				}
				set	
				{
					serviceActionList = value;
				}
			}

			public class ListClusterService_ServiceAction
			{

				private string serviceName;

				private string componentName;

				private string actionName;

				private string command;

				private string displayName;

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string ComponentName
				{
					get
					{
						return componentName;
					}
					set	
					{
						componentName = value;
					}
				}

				public string ActionName
				{
					get
					{
						return actionName;
					}
					set	
					{
						actionName = value;
					}
				}

				public string Command
				{
					get
					{
						return command;
					}
					set	
					{
						command = value;
					}
				}

				public string DisplayName
				{
					get
					{
						return displayName;
					}
					set	
					{
						displayName = value;
					}
				}
			}
		}
	}
}
