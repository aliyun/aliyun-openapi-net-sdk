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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListEcsInstancesResponse : AcsResponse
	{

		private string requestId;

		private List<ListEcsInstances_ResultItem> result;

		private ListEcsInstances_Headers headers;

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

		public List<ListEcsInstances_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public ListEcsInstances_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListEcsInstances_ResultItem
		{

			private string ecsInstanceId;

			private string ecsInstanceName;

			private string status;

			private string tags;

			private string osType;

			private string cloudAssistantStatus;

			private List<ListEcsInstances_IpAddressItem> ipAddress;

			private List<ListEcsInstances_CollectorsItem> collectors;

			public string EcsInstanceId
			{
				get
				{
					return ecsInstanceId;
				}
				set	
				{
					ecsInstanceId = value;
				}
			}

			public string EcsInstanceName
			{
				get
				{
					return ecsInstanceName;
				}
				set	
				{
					ecsInstanceName = value;
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

			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public string OsType
			{
				get
				{
					return osType;
				}
				set	
				{
					osType = value;
				}
			}

			public string CloudAssistantStatus
			{
				get
				{
					return cloudAssistantStatus;
				}
				set	
				{
					cloudAssistantStatus = value;
				}
			}

			public List<ListEcsInstances_IpAddressItem> IpAddress
			{
				get
				{
					return ipAddress;
				}
				set	
				{
					ipAddress = value;
				}
			}

			public List<ListEcsInstances_CollectorsItem> Collectors
			{
				get
				{
					return collectors;
				}
				set	
				{
					collectors = value;
				}
			}

			public class ListEcsInstances_IpAddressItem
			{

				private string host;

				private string ipType;

				public string Host
				{
					get
					{
						return host;
					}
					set	
					{
						host = value;
					}
				}

				public string IpType
				{
					get
					{
						return ipType;
					}
					set	
					{
						ipType = value;
					}
				}
			}

			public class ListEcsInstances_CollectorsItem
			{

				private string gmtCreatedTime;

				private string gmtUpdateTime;

				private string name;

				private string resId;

				private string resVersion;

				private string vpcId;

				private string resType;

				private string ownerId;

				private string status;

				private bool? dryRun;

				private List<ListEcsInstances_ConfigsItem> configs;

				private List<ListEcsInstances_ExtendConfigsItem> extendConfigs;

				private List<string> collectorPaths;

				public string GmtCreatedTime
				{
					get
					{
						return gmtCreatedTime;
					}
					set	
					{
						gmtCreatedTime = value;
					}
				}

				public string GmtUpdateTime
				{
					get
					{
						return gmtUpdateTime;
					}
					set	
					{
						gmtUpdateTime = value;
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

				public string ResId
				{
					get
					{
						return resId;
					}
					set	
					{
						resId = value;
					}
				}

				public string ResVersion
				{
					get
					{
						return resVersion;
					}
					set	
					{
						resVersion = value;
					}
				}

				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				public string ResType
				{
					get
					{
						return resType;
					}
					set	
					{
						resType = value;
					}
				}

				public string OwnerId
				{
					get
					{
						return ownerId;
					}
					set	
					{
						ownerId = value;
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

				public bool? DryRun
				{
					get
					{
						return dryRun;
					}
					set	
					{
						dryRun = value;
					}
				}

				public List<ListEcsInstances_ConfigsItem> Configs
				{
					get
					{
						return configs;
					}
					set	
					{
						configs = value;
					}
				}

				public List<ListEcsInstances_ExtendConfigsItem> ExtendConfigs
				{
					get
					{
						return extendConfigs;
					}
					set	
					{
						extendConfigs = value;
					}
				}

				public List<string> CollectorPaths
				{
					get
					{
						return collectorPaths;
					}
					set	
					{
						collectorPaths = value;
					}
				}

				public class ListEcsInstances_ConfigsItem
				{

					private string fileName;

					private string content;

					public string FileName
					{
						get
						{
							return fileName;
						}
						set	
						{
							fileName = value;
						}
					}

					public string Content
					{
						get
						{
							return content;
						}
						set	
						{
							content = value;
						}
					}
				}

				public class ListEcsInstances_ExtendConfigsItem
				{

					private string configType;

					private string instanceId;

					private string instanceType;

					private string protocol;

					private string userName;

					private bool? enableMonitoring;

					private string type;

					private string groupId;

					private List<ListEcsInstances_MachinesItem> machines;

					private List<string> hosts;

					public string ConfigType
					{
						get
						{
							return configType;
						}
						set	
						{
							configType = value;
						}
					}

					public string InstanceId
					{
						get
						{
							return instanceId;
						}
						set	
						{
							instanceId = value;
						}
					}

					public string InstanceType
					{
						get
						{
							return instanceType;
						}
						set	
						{
							instanceType = value;
						}
					}

					public string Protocol
					{
						get
						{
							return protocol;
						}
						set	
						{
							protocol = value;
						}
					}

					public string UserName
					{
						get
						{
							return userName;
						}
						set	
						{
							userName = value;
						}
					}

					public bool? EnableMonitoring
					{
						get
						{
							return enableMonitoring;
						}
						set	
						{
							enableMonitoring = value;
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

					public string GroupId
					{
						get
						{
							return groupId;
						}
						set	
						{
							groupId = value;
						}
					}

					public List<ListEcsInstances_MachinesItem> Machines
					{
						get
						{
							return machines;
						}
						set	
						{
							machines = value;
						}
					}

					public List<string> Hosts
					{
						get
						{
							return hosts;
						}
						set	
						{
							hosts = value;
						}
					}

					public class ListEcsInstances_MachinesItem
					{

						private string instanceId;

						private string agentStatus;

						public string InstanceId
						{
							get
							{
								return instanceId;
							}
							set	
							{
								instanceId = value;
							}
						}

						public string AgentStatus
						{
							get
							{
								return agentStatus;
							}
							set	
							{
								agentStatus = value;
							}
						}
					}
				}
			}
		}

		public class ListEcsInstances_Headers
		{

			private int? xTotalCount;

			public int? XTotalCount
			{
				get
				{
					return xTotalCount;
				}
				set	
				{
					xTotalCount = value;
				}
			}
		}
	}
}
