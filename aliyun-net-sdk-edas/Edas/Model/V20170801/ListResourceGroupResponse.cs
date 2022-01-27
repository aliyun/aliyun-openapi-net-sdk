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
	public class ListResourceGroupResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListResourceGroup_ResGroupEntity> resourceGroupList;

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

		public List<ListResourceGroup_ResGroupEntity> ResourceGroupList
		{
			get
			{
				return resourceGroupList;
			}
			set	
			{
				resourceGroupList = value;
			}
		}

		public class ListResourceGroup_ResGroupEntity
		{

			private long? id;

			private string name;

			private string description;

			private string adminUserId;

			private long? createTime;

			private long? updateTime;

			private string regionId;

			private List<ListResourceGroup_EcsEntity> ecsList;

			private List<ListResourceGroup_SlbEntity> slbList;

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

			public string AdminUserId
			{
				get
				{
					return adminUserId;
				}
				set	
				{
					adminUserId = value;
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

			public List<ListResourceGroup_EcsEntity> EcsList
			{
				get
				{
					return ecsList;
				}
				set	
				{
					ecsList = value;
				}
			}

			public List<ListResourceGroup_SlbEntity> SlbList
			{
				get
				{
					return slbList;
				}
				set	
				{
					slbList = value;
				}
			}

			public class ListResourceGroup_EcsEntity
			{

				private string instanceId;

				private string instanceName;

				private string hostName;

				private string description;

				private string status;

				private string publicIp;

				private string innerIp;

				private string privateIp;

				private string eip;

				private string serialNum;

				private string userId;

				private string zoneId;

				private string regionId;

				private string instanceId1;

				private bool? expired;

				private string sgId;

				private string vpcId;

				private string groupId;

				private int? cpu;

				private int? mem;

				private ListResourceGroup_EcuEntity ecuEntity;

				private ListResourceGroup_VpcEntity vpcEntity;

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

				public string InstanceName
				{
					get
					{
						return instanceName;
					}
					set	
					{
						instanceName = value;
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

				public string PublicIp
				{
					get
					{
						return publicIp;
					}
					set	
					{
						publicIp = value;
					}
				}

				public string InnerIp
				{
					get
					{
						return innerIp;
					}
					set	
					{
						innerIp = value;
					}
				}

				public string PrivateIp
				{
					get
					{
						return privateIp;
					}
					set	
					{
						privateIp = value;
					}
				}

				public string Eip
				{
					get
					{
						return eip;
					}
					set	
					{
						eip = value;
					}
				}

				public string SerialNum
				{
					get
					{
						return serialNum;
					}
					set	
					{
						serialNum = value;
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

				public string InstanceId1
				{
					get
					{
						return instanceId1;
					}
					set	
					{
						instanceId1 = value;
					}
				}

				public bool? Expired
				{
					get
					{
						return expired;
					}
					set	
					{
						expired = value;
					}
				}

				public string SgId
				{
					get
					{
						return sgId;
					}
					set	
					{
						sgId = value;
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

				public int? Mem
				{
					get
					{
						return mem;
					}
					set	
					{
						mem = value;
					}
				}

				public ListResourceGroup_EcuEntity EcuEntity
				{
					get
					{
						return ecuEntity;
					}
					set	
					{
						ecuEntity = value;
					}
				}

				public ListResourceGroup_VpcEntity VpcEntity
				{
					get
					{
						return vpcEntity;
					}
					set	
					{
						vpcEntity = value;
					}
				}

				public class ListResourceGroup_EcuEntity
				{

					private string ecuId;

					private bool? online;

					private bool? dockerEnv;

					private long? createTime;

					private long? updateTime;

					private string ipAddr;

					private long? heartbeatTime;

					private string userId;

					private string name;

					private string zoneId;

					private string regionId;

					private string instanceId;

					private string vpcId;

					private int? availableCpu;

					private int? availableMem;

					private int? cpu;

					private int? mem;

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

					public int? Mem
					{
						get
						{
							return mem;
						}
						set	
						{
							mem = value;
						}
					}
				}

				public class ListResourceGroup_VpcEntity
				{

					private string vpcId;

					private string vpcName;

					private string regionId;

					private string userId;

					private string cidrblock;

					private string status;

					private string description;

					private bool? expired;

					private int? ecsNum;

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

					public string VpcName
					{
						get
						{
							return vpcName;
						}
						set	
						{
							vpcName = value;
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

					public string Cidrblock
					{
						get
						{
							return cidrblock;
						}
						set	
						{
							cidrblock = value;
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

					public bool? Expired
					{
						get
						{
							return expired;
						}
						set	
						{
							expired = value;
						}
					}

					public int? EcsNum
					{
						get
						{
							return ecsNum;
						}
						set	
						{
							ecsNum = value;
						}
					}
				}
			}

			public class ListResourceGroup_SlbEntity
			{

				private string slbId;

				private string slbName;

				private string regionId;

				private string userId;

				private string address;

				private string slbStatus;

				private string addressType;

				private string vswitchId;

				private string vpcId;

				private string networkType;

				private int? groupId;

				private bool? expired;

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

				public string SlbName
				{
					get
					{
						return slbName;
					}
					set	
					{
						slbName = value;
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

				public string Address
				{
					get
					{
						return address;
					}
					set	
					{
						address = value;
					}
				}

				public string SlbStatus
				{
					get
					{
						return slbStatus;
					}
					set	
					{
						slbStatus = value;
					}
				}

				public string AddressType
				{
					get
					{
						return addressType;
					}
					set	
					{
						addressType = value;
					}
				}

				public string VswitchId
				{
					get
					{
						return vswitchId;
					}
					set	
					{
						vswitchId = value;
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

				public string NetworkType
				{
					get
					{
						return networkType;
					}
					set	
					{
						networkType = value;
					}
				}

				public int? GroupId
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

				public bool? Expired
				{
					get
					{
						return expired;
					}
					set	
					{
						expired = value;
					}
				}
			}
		}
	}
}
