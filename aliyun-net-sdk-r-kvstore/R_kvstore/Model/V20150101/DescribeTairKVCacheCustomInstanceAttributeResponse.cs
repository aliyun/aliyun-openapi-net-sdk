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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeTairKVCacheCustomInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private string vpcId;

		private string privateIp;

		private string createTime;

		private string chargeType;

		private string storageType;

		private string architectureType;

		private string networkType;

		private string instanceName;

		private string zoneType;

		private string instanceClass;

		private string instanceId;

		private string instanceType;

		private string regionId;

		private string endTime;

		private string vSwitchId;

		private string resourceGroupId;

		private string zoneId;

		private string instanceStatus;

		private long? storage;

		private bool? isOrderCompleted;

		private string imageId;

		private long? cpu;

		private long? memory;

		private string securityGroupId;

		private bool? useEni;

		private List<DescribeTairKVCacheCustomInstanceAttribute_Tag> tags;

		private List<DescribeTairKVCacheCustomInstanceAttribute_Disk> disks;

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

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
			}
		}

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
			}
		}

		public string ArchitectureType
		{
			get
			{
				return architectureType;
			}
			set	
			{
				architectureType = value;
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

		public string ZoneType
		{
			get
			{
				return zoneType;
			}
			set	
			{
				zoneType = value;
			}
		}

		public string InstanceClass
		{
			get
			{
				return instanceClass;
			}
			set	
			{
				instanceClass = value;
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
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

		public long? Storage
		{
			get
			{
				return storage;
			}
			set	
			{
				storage = value;
			}
		}

		public bool? IsOrderCompleted
		{
			get
			{
				return isOrderCompleted;
			}
			set	
			{
				isOrderCompleted = value;
			}
		}

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
			}
		}

		public long? Cpu
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

		public long? Memory
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

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
			}
		}

		public bool? UseEni
		{
			get
			{
				return useEni;
			}
			set	
			{
				useEni = value;
			}
		}

		public List<DescribeTairKVCacheCustomInstanceAttribute_Tag> Tags
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

		public List<DescribeTairKVCacheCustomInstanceAttribute_Disk> Disks
		{
			get
			{
				return disks;
			}
			set	
			{
				disks = value;
			}
		}

		public class DescribeTairKVCacheCustomInstanceAttribute_Tag
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeTairKVCacheCustomInstanceAttribute_Disk
		{

			private string diskId;

			private string type;

			private string size;

			public string DiskId
			{
				get
				{
					return diskId;
				}
				set	
				{
					diskId = value;
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

			public string Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}
		}
	}
}
