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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListFlowControlsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListFlowControls_FlowControlsMap flowControlsMap;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public ListFlowControls_FlowControlsMap FlowControlsMap
		{
			get
			{
				return flowControlsMap;
			}
			set	
			{
				flowControlsMap = value;
			}
		}

		public class ListFlowControls_FlowControlsMap
		{

			private string appId;

			private string appName;

			private List<ListFlowControls_InterfaceMethod> interfaceMethods;

			private List<ListFlowControls_App> appList;

			private ListFlowControls_RuleList ruleList;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public List<ListFlowControls_InterfaceMethod> InterfaceMethods
			{
				get
				{
					return interfaceMethods;
				}
				set	
				{
					interfaceMethods = value;
				}
			}

			public List<ListFlowControls_App> AppList
			{
				get
				{
					return appList;
				}
				set	
				{
					appList = value;
				}
			}

			public ListFlowControls_RuleList RuleList
			{
				get
				{
					return ruleList;
				}
				set	
				{
					ruleList = value;
				}
			}

			public class ListFlowControls_InterfaceMethod
			{

				private string name;

				private string version;

				private List<string> methods;

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

				public List<string> Methods
				{
					get
					{
						return methods;
					}
					set	
					{
						methods = value;
					}
				}
			}

			public class ListFlowControls_App
			{

				private string appId;

				private string name;

				private string regionId;

				private string description;

				private string owner;

				private int? instanceCount;

				private int? runningInstanceCount;

				private int? port;

				private string userId;

				private string slbId;

				private string slbIp;

				private int? slbPort;

				private string extSlbId;

				private string extSlbIp;

				private string applicationType;

				private int? clusterType;

				private string clusterId;

				private bool? dockerize;

				private int? cpu;

				private int? memory;

				private string healthCheckUrl;

				private long? buildPackageId;

				private long? createTime;

				public string AppId
				{
					get
					{
						return appId;
					}
					set	
					{
						appId = value;
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

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public int? InstanceCount
				{
					get
					{
						return instanceCount;
					}
					set	
					{
						instanceCount = value;
					}
				}

				public int? RunningInstanceCount
				{
					get
					{
						return runningInstanceCount;
					}
					set	
					{
						runningInstanceCount = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string SlbId
				{
					get
					{
						return slbId;
					}
					set	
					{
						slbId = value;
					}
				}

				public string SlbIp
				{
					get
					{
						return slbIp;
					}
					set	
					{
						slbIp = value;
					}
				}

				public int? SlbPort
				{
					get
					{
						return slbPort;
					}
					set	
					{
						slbPort = value;
					}
				}

				public string ExtSlbId
				{
					get
					{
						return extSlbId;
					}
					set	
					{
						extSlbId = value;
					}
				}

				public string ExtSlbIp
				{
					get
					{
						return extSlbIp;
					}
					set	
					{
						extSlbIp = value;
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

				public int? ClusterType
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

				public bool? Dockerize
				{
					get
					{
						return dockerize;
					}
					set	
					{
						dockerize = value;
					}
				}

				public int? Cpu
				{
					get
					{
						return cpu;
					}
					set	
					{
						cpu = value;
					}
				}

				public int? Memory
				{
					get
					{
						return memory;
					}
					set	
					{
						memory = value;
					}
				}

				public string HealthCheckUrl
				{
					get
					{
						return healthCheckUrl;
					}
					set	
					{
						healthCheckUrl = value;
					}
				}

				public long? BuildPackageId
				{
					get
					{
						return buildPackageId;
					}
					set	
					{
						buildPackageId = value;
					}
				}

				public long? CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}
			}

			public class ListFlowControls_RuleList
			{

				private int? currentPage;

				private int? pageSize;

				private int? totalSize;

				private List<ListFlowControls_Rule> ruleResultList;

				public int? CurrentPage
				{
					get
					{
						return currentPage;
					}
					set	
					{
						currentPage = value;
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

				public int? TotalSize
				{
					get
					{
						return totalSize;
					}
					set	
					{
						totalSize = value;
					}
				}

				public List<ListFlowControls_Rule> RuleResultList
				{
					get
					{
						return ruleResultList;
					}
					set	
					{
						ruleResultList = value;
					}
				}

				public class ListFlowControls_Rule
				{

					private string appId;

					private string consumerAppId;

					private long? createTime;

					private string granularity;

					private string id;

					private string resource;

					private string ruleId;

					private string ruleType;

					private int? state;

					private string strategy;

					private int? threshold;

					private long? updateTime;

					public string AppId
					{
						get
						{
							return appId;
						}
						set	
						{
							appId = value;
						}
					}

					public string ConsumerAppId
					{
						get
						{
							return consumerAppId;
						}
						set	
						{
							consumerAppId = value;
						}
					}

					public long? CreateTime
					{
						get
						{
							return createTime;
						}
						set	
						{
							createTime = value;
						}
					}

					public string Granularity
					{
						get
						{
							return granularity;
						}
						set	
						{
							granularity = value;
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

					public string Resource
					{
						get
						{
							return resource;
						}
						set	
						{
							resource = value;
						}
					}

					public string RuleId
					{
						get
						{
							return ruleId;
						}
						set	
						{
							ruleId = value;
						}
					}

					public string RuleType
					{
						get
						{
							return ruleType;
						}
						set	
						{
							ruleType = value;
						}
					}

					public int? State
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

					public string Strategy
					{
						get
						{
							return strategy;
						}
						set	
						{
							strategy = value;
						}
					}

					public int? Threshold
					{
						get
						{
							return threshold;
						}
						set	
						{
							threshold = value;
						}
					}

					public long? UpdateTime
					{
						get
						{
							return updateTime;
						}
						set	
						{
							updateTime = value;
						}
					}
				}
			}
		}
	}
}
