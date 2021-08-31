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
	public class ListApplicationEcuResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListApplicationEcu_EcuEntity> ecuInfoList;

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

		public List<ListApplicationEcu_EcuEntity> EcuInfoList
		{
			get
			{
				return ecuInfoList;
			}
			set	
			{
				ecuInfoList = value;
			}
		}

		public class ListApplicationEcu_EcuEntity
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

			private string appId;

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
		}
	}
}
