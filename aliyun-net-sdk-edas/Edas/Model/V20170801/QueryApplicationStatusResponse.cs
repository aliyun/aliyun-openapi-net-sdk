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
	public class QueryApplicationStatusResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private QueryApplicationStatus_AppInfo appInfo;

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

		public QueryApplicationStatus_AppInfo AppInfo
		{
			get
			{
				return appInfo;
			}
			set	
			{
				appInfo = value;
			}
		}

		public class QueryApplicationStatus_AppInfo
		{

			private List<QueryApplicationStatus_Ecu> ecuList;

			private List<QueryApplicationStatus_Ecc> eccList;

			private List<QueryApplicationStatus_Group> groupList;

			private List<QueryApplicationStatus_DeployRecord> deployRecordList;

			private QueryApplicationStatus_Application application;

			public List<QueryApplicationStatus_Ecu> EcuList
			{
				get
				{
					return ecuList;
				}
				set	
				{
					ecuList = value;
				}
			}

			public List<QueryApplicationStatus_Ecc> EccList
			{
				get
				{
					return eccList;
				}
				set	
				{
					eccList = value;
				}
			}

			public List<QueryApplicationStatus_Group> GroupList
			{
				get
				{
					return groupList;
				}
				set	
				{
					groupList = value;
				}
			}

			public List<QueryApplicationStatus_DeployRecord> DeployRecordList
			{
				get
				{
					return deployRecordList;
				}
				set	
				{
					deployRecordList = value;
				}
			}

			public QueryApplicationStatus_Application Application
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

			public class QueryApplicationStatus_Ecu
			{

				private string ecuId;

				private bool? online;

				private bool? dockerEnv;

				private long? createTime;

				private long? updateTime;

				private string ipAddr;

				private long? heartbeatTime;

				private string userId;

				private string groupId;

				private string name;

				private string zoneId;

				private string regionId;

				private string instanceId;

				private string vpcId;

				private string regionId1;

				private int? availableCpu;

				private int? availableMem;

				public string EcuId
				{
					get
					{
						return ecuId;
					}
					set	
					{
						ecuId = value;
					}
				}

				public bool? Online
				{
					get
					{
						return online;
					}
					set	
					{
						online = value;
					}
				}

				public bool? DockerEnv
				{
					get
					{
						return dockerEnv;
					}
					set	
					{
						dockerEnv = value;
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

				public string IpAddr
				{
					get
					{
						return ipAddr;
					}
					set	
					{
						ipAddr = value;
					}
				}

				public long? HeartbeatTime
				{
					get
					{
						return heartbeatTime;
					}
					set	
					{
						heartbeatTime = value;
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

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
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

				public string RegionId1
				{
					get
					{
						return regionId1;
					}
					set	
					{
						regionId1 = value;
					}
				}

				public int? AvailableCpu
				{
					get
					{
						return availableCpu;
					}
					set	
					{
						availableCpu = value;
					}
				}

				public int? AvailableMem
				{
					get
					{
						return availableMem;
					}
					set	
					{
						availableMem = value;
					}
				}
			}

			public class QueryApplicationStatus_Ecc
			{

				private string eccId;

				private string ecuId;

				private string appId;

				private int? appState;

				private int? taskState;

				private long? createTime;

				private long? updateTime;

				private string ip;

				private string vpcId;

				private string groupId;

				private string containerStatus;

				public string EccId
				{
					get
					{
						return eccId;
					}
					set	
					{
						eccId = value;
					}
				}

				public string EcuId
				{
					get
					{
						return ecuId;
					}
					set	
					{
						ecuId = value;
					}
				}

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

				public int? AppState
				{
					get
					{
						return appState;
					}
					set	
					{
						appState = value;
					}
				}

				public int? TaskState
				{
					get
					{
						return taskState;
					}
					set	
					{
						taskState = value;
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

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
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

				public string ContainerStatus
				{
					get
					{
						return containerStatus;
					}
					set	
					{
						containerStatus = value;
					}
				}
			}

			public class QueryApplicationStatus_Group
			{

				private string groupId;

				private string groupName;

				private string appId;

				private string packageVersionId;

				private string appVersionId;

				private int? groupType;

				private string clusterId;

				private long? createTime;

				private long? updateTime;

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

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

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

				public string PackageVersionId
				{
					get
					{
						return packageVersionId;
					}
					set	
					{
						packageVersionId = value;
					}
				}

				public string AppVersionId
				{
					get
					{
						return appVersionId;
					}
					set	
					{
						appVersionId = value;
					}
				}

				public int? GroupType
				{
					get
					{
						return groupType;
					}
					set	
					{
						groupType = value;
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

			public class QueryApplicationStatus_DeployRecord
			{

				private string deployRecordId;

				private string eccId;

				private string ecuId;

				private string packageVersionId;

				private string packageMd5;

				private long? createTime;

				public string DeployRecordId
				{
					get
					{
						return deployRecordId;
					}
					set	
					{
						deployRecordId = value;
					}
				}

				public string EccId
				{
					get
					{
						return eccId;
					}
					set	
					{
						eccId = value;
					}
				}

				public string EcuId
				{
					get
					{
						return ecuId;
					}
					set	
					{
						ecuId = value;
					}
				}

				public string PackageVersionId
				{
					get
					{
						return packageVersionId;
					}
					set	
					{
						packageVersionId = value;
					}
				}

				public string PackageMd5
				{
					get
					{
						return packageMd5;
					}
					set	
					{
						packageMd5 = value;
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

			public class QueryApplicationStatus_Application
			{

				private string applicationId;

				private int? buildPackageId;

				private string clusterId;

				private int? cpu;

				private long? createTime;

				private bool? dockerize;

				private string email;

				private string healthCheckUrl;

				private int? instanceCount;

				private long? launchTime;

				private int? memory;

				private string name;

				private string owner;

				private string phone;

				private int? port;

				private string regionId;

				private int? runningInstanceCount;

				private string userId;

				public string ApplicationId
				{
					get
					{
						return applicationId;
					}
					set	
					{
						applicationId = value;
					}
				}

				public int? BuildPackageId
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

				public string Email
				{
					get
					{
						return email;
					}
					set	
					{
						email = value;
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

				public long? LaunchTime
				{
					get
					{
						return launchTime;
					}
					set	
					{
						launchTime = value;
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

				public string Phone
				{
					get
					{
						return phone;
					}
					set	
					{
						phone = value;
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
			}
		}
	}
}
