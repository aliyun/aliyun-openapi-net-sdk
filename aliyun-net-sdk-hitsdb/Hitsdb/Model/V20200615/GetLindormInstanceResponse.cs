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

namespace Aliyun.Acs.hitsdb.Model.V20200615
{
	public class GetLindormInstanceResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private string instanceAlias;

		private string regionId;

		private string zoneId;

		private string instanceStatus;

		private string payType;

		private string networkType;

		private string createTime;

		private string expireTime;

		private string instanceStorage;

		private string vpcId;

		private string vswitchId;

		private bool? autoRenew;

		private int? engineType;

		private string serviceType;

		private string deletionProtection;

		private string diskCategory;

		private int? coldStorage;

		private bool? enableBDS;

		private long? aliUid;

		private bool? enableFS;

		private bool? enablePhoenix;

		private string diskUsage;

		private string diskThreshold;

		private long? createMilliseconds;

		private long? expiredMilliseconds;

		private List<GetLindormInstance_Engine> engineList;

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

		public string InstanceAlias
		{
			get
			{
				return instanceAlias;
			}
			set	
			{
				instanceAlias = value;
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

		public string InstanceStatus
		{
			get
			{
				return instanceStatus;
			}
			set	
			{
				instanceStatus = value;
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
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

		public string CreateTime
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

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
			}
		}

		public string InstanceStorage
		{
			get
			{
				return instanceStorage;
			}
			set	
			{
				instanceStorage = value;
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

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
			}
		}

		public int? EngineType
		{
			get
			{
				return engineType;
			}
			set	
			{
				engineType = value;
			}
		}

		public string ServiceType
		{
			get
			{
				return serviceType;
			}
			set	
			{
				serviceType = value;
			}
		}

		public string DeletionProtection
		{
			get
			{
				return deletionProtection;
			}
			set	
			{
				deletionProtection = value;
			}
		}

		public string DiskCategory
		{
			get
			{
				return diskCategory;
			}
			set	
			{
				diskCategory = value;
			}
		}

		public int? ColdStorage
		{
			get
			{
				return coldStorage;
			}
			set	
			{
				coldStorage = value;
			}
		}

		public bool? EnableBDS
		{
			get
			{
				return enableBDS;
			}
			set	
			{
				enableBDS = value;
			}
		}

		public long? AliUid
		{
			get
			{
				return aliUid;
			}
			set	
			{
				aliUid = value;
			}
		}

		public bool? EnableFS
		{
			get
			{
				return enableFS;
			}
			set	
			{
				enableFS = value;
			}
		}

		public bool? EnablePhoenix
		{
			get
			{
				return enablePhoenix;
			}
			set	
			{
				enablePhoenix = value;
			}
		}

		public string DiskUsage
		{
			get
			{
				return diskUsage;
			}
			set	
			{
				diskUsage = value;
			}
		}

		public string DiskThreshold
		{
			get
			{
				return diskThreshold;
			}
			set	
			{
				diskThreshold = value;
			}
		}

		public long? CreateMilliseconds
		{
			get
			{
				return createMilliseconds;
			}
			set	
			{
				createMilliseconds = value;
			}
		}

		public long? ExpiredMilliseconds
		{
			get
			{
				return expiredMilliseconds;
			}
			set	
			{
				expiredMilliseconds = value;
			}
		}

		public List<GetLindormInstance_Engine> EngineList
		{
			get
			{
				return engineList;
			}
			set	
			{
				engineList = value;
			}
		}

		public class GetLindormInstance_Engine
		{

			private string engine;

			private string version;

			private string cpuCount;

			private string memorySize;

			private string coreCount;

			private bool? isLastVersion;

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
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

			public string CpuCount
			{
				get
				{
					return cpuCount;
				}
				set	
				{
					cpuCount = value;
				}
			}

			public string MemorySize
			{
				get
				{
					return memorySize;
				}
				set	
				{
					memorySize = value;
				}
			}

			public string CoreCount
			{
				get
				{
					return coreCount;
				}
				set	
				{
					coreCount = value;
				}
			}

			public bool? IsLastVersion
			{
				get
				{
					return isLastVersion;
				}
				set	
				{
					isLastVersion = value;
				}
			}
		}
	}
}
