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
using Newtonsoft.Json;
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

			private string resId;

			private string gmtUpdateTime;

			private bool? dryRun;

			private string ownerId;

			private string vpcId;

			private string resType;

			private string resVersion;

			private string gmtCreatedTime;

			private string status;

			private string name;

			private List<UpdateCollectorName_ConfigsItem> configs;

			private List<UpdateCollectorName_ExtendConfigsItem> extendConfigs;

			private List<string> collectorPaths;

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

				private string content;

				private string fileName;

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
			}

			public class UpdateCollectorName_ExtendConfigsItem
			{

				private string successPodsCount;

				private string protocol;

				private string userName;

				private string totalPodsCount;

				private string type;

				private string kibanaHost;

				private bool? enableMonitoring;

				private string configType;

				private string instanceType;

				private string groupId;

				private string host;

				private string instanceId;

				private List<UpdateCollectorName_MachinesItem> machines;

				private List<string> hosts;

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

					private string agentStatus;

					private string instanceId;

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
				}
			}
		}
	}
}
