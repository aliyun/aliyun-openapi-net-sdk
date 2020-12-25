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
	public class ListClusterInstalledServiceResponse : AcsResponse
	{

		private string requestId;

		private List<ListClusterInstalledService_ClusterInstalledService> clusterInstalledServiceList;

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

		public List<ListClusterInstalledService_ClusterInstalledService> ClusterInstalledServiceList
		{
			get
			{
				return clusterInstalledServiceList;
			}
			set	
			{
				clusterInstalledServiceList = value;
			}
		}

		public class ListClusterInstalledService_ClusterInstalledService
		{

			private string serviceName;

			private string serviceDisplayName;

			private string serviceVersion;

			private string serviceEcmVersion;

			private string serviceStatus;

			private bool? onlyClient;

			private int? notStartedNum;

			private int? needRestartNum;

			private int? abnormalNum;

			private string comment;

			private List<ListClusterInstalledService_ServiceAction> serviceActionList;

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

			public string ServiceEcmVersion
			{
				get
				{
					return serviceEcmVersion;
				}
				set	
				{
					serviceEcmVersion = value;
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

			public bool? OnlyClient
			{
				get
				{
					return onlyClient;
				}
				set	
				{
					onlyClient = value;
				}
			}

			public int? NotStartedNum
			{
				get
				{
					return notStartedNum;
				}
				set	
				{
					notStartedNum = value;
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

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public List<ListClusterInstalledService_ServiceAction> ServiceActionList
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

			public class ListClusterInstalledService_ServiceAction
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
