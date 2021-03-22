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
	public class UpdateCollectorNameResponse : AcsResponse
	{

		private string requestId;

		private UpdateCollectorName_Result result;

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

		public UpdateCollectorName_Result Result
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

		public class UpdateCollectorName_Result
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

			private List<UpdateCollectorName_ConfigsItem> configs;

			private List<UpdateCollectorName_ExtendConfigsItem> extendConfigs;

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

			public List<UpdateCollectorName_ConfigsItem> Configs
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

			public List<UpdateCollectorName_ExtendConfigsItem> ExtendConfigs
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

			public class UpdateCollectorName_ConfigsItem
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

			public class UpdateCollectorName_ExtendConfigsItem
			{

				private string configType;

				private string instanceId;

				private string instanceType;

				private string protocol;

				private string userName;

				private bool? enableMonitoring;

				private string type;

				private string groupId;

				private string host;

				private string kibanaHost;

				private string totalPodsCount;

				private string successPodsCount;

				private List<UpdateCollectorName_MachinesItem> machines;

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

				public string KibanaHost
				{
					get
					{
						return kibanaHost;
					}
					set	
					{
						kibanaHost = value;
					}
				}

				public string TotalPodsCount
				{
					get
					{
						return totalPodsCount;
					}
					set	
					{
						totalPodsCount = value;
					}
				}

				public string SuccessPodsCount
				{
					get
					{
						return successPodsCount;
					}
					set	
					{
						successPodsCount = value;
					}
				}

				public List<UpdateCollectorName_MachinesItem> Machines
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

				public class UpdateCollectorName_MachinesItem
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
}
