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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class DescribeInstanceResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private string instanceName;

		private string status;

		private string payType;

		private string createdTime;

		private string expireTime;

		private string majorVersion;

		private string minorVersion;

		private string engine;

		private bool? isHa;

		private string networkType;

		private string vpcId;

		private string vswitchId;

		private string masterInstanceType;

		private int? masterNodeCount;

		private string masterDiskType;

		private int? masterDiskSize;

		private string coreInstanceType;

		private int? coreNodeCount;

		private string coreDiskType;

		private int? coreDiskSize;

		private string regionId;

		private string zoneId;

		private string coldStorageStatus;

		private string backupStatus;

		private string coreDiskCount;

		private string maintainStartTime;

		private string maintainEndTime;

		private string createdTimeUTC;

		private string expireTimeUTC;

		private bool? isLatestVersion;

		private bool? isMultiModel;

		private string clusterType;

		private string clusterId;

		private string clusterName;

		private bool? isDeletionProtection;

		private string parentId;

		private int? moduleId;

		private string moduleStackVersion;

		private bool? autoRenewal;

		private int? duration;

		private int? coldStorageSize;

		private string resourceGroupId;

		private bool? encryptionType;

		private string encryptionKey;

		private List<DescribeInstance_Tag> tags;

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

		public string CreatedTime
		{
			get
			{
				return createdTime;
			}
			set	
			{
				createdTime = value;
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

		public string MajorVersion
		{
			get
			{
				return majorVersion;
			}
			set	
			{
				majorVersion = value;
			}
		}

		public string MinorVersion
		{
			get
			{
				return minorVersion;
			}
			set	
			{
				minorVersion = value;
			}
		}

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

		public bool? IsHa
		{
			get
			{
				return isHa;
			}
			set	
			{
				isHa = value;
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

		public string MasterInstanceType
		{
			get
			{
				return masterInstanceType;
			}
			set	
			{
				masterInstanceType = value;
			}
		}

		public int? MasterNodeCount
		{
			get
			{
				return masterNodeCount;
			}
			set	
			{
				masterNodeCount = value;
			}
		}

		public string MasterDiskType
		{
			get
			{
				return masterDiskType;
			}
			set	
			{
				masterDiskType = value;
			}
		}

		public int? MasterDiskSize
		{
			get
			{
				return masterDiskSize;
			}
			set	
			{
				masterDiskSize = value;
			}
		}

		public string CoreInstanceType
		{
			get
			{
				return coreInstanceType;
			}
			set	
			{
				coreInstanceType = value;
			}
		}

		public int? CoreNodeCount
		{
			get
			{
				return coreNodeCount;
			}
			set	
			{
				coreNodeCount = value;
			}
		}

		public string CoreDiskType
		{
			get
			{
				return coreDiskType;
			}
			set	
			{
				coreDiskType = value;
			}
		}

		public int? CoreDiskSize
		{
			get
			{
				return coreDiskSize;
			}
			set	
			{
				coreDiskSize = value;
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

		public string ColdStorageStatus
		{
			get
			{
				return coldStorageStatus;
			}
			set	
			{
				coldStorageStatus = value;
			}
		}

		public string BackupStatus
		{
			get
			{
				return backupStatus;
			}
			set	
			{
				backupStatus = value;
			}
		}

		public string CoreDiskCount
		{
			get
			{
				return coreDiskCount;
			}
			set	
			{
				coreDiskCount = value;
			}
		}

		public string MaintainStartTime
		{
			get
			{
				return maintainStartTime;
			}
			set	
			{
				maintainStartTime = value;
			}
		}

		public string MaintainEndTime
		{
			get
			{
				return maintainEndTime;
			}
			set	
			{
				maintainEndTime = value;
			}
		}

		public string CreatedTimeUTC
		{
			get
			{
				return createdTimeUTC;
			}
			set	
			{
				createdTimeUTC = value;
			}
		}

		public string ExpireTimeUTC
		{
			get
			{
				return expireTimeUTC;
			}
			set	
			{
				expireTimeUTC = value;
			}
		}

		public bool? IsLatestVersion
		{
			get
			{
				return isLatestVersion;
			}
			set	
			{
				isLatestVersion = value;
			}
		}

		public bool? IsMultiModel
		{
			get
			{
				return isMultiModel;
			}
			set	
			{
				isMultiModel = value;
			}
		}

		public string ClusterType
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

		public string ClusterName
		{
			get
			{
				return clusterName;
			}
			set	
			{
				clusterName = value;
			}
		}

		public bool? IsDeletionProtection
		{
			get
			{
				return isDeletionProtection;
			}
			set	
			{
				isDeletionProtection = value;
			}
		}

		public string ParentId
		{
			get
			{
				return parentId;
			}
			set	
			{
				parentId = value;
			}
		}

		public int? ModuleId
		{
			get
			{
				return moduleId;
			}
			set	
			{
				moduleId = value;
			}
		}

		public string ModuleStackVersion
		{
			get
			{
				return moduleStackVersion;
			}
			set	
			{
				moduleStackVersion = value;
			}
		}

		public bool? AutoRenewal
		{
			get
			{
				return autoRenewal;
			}
			set	
			{
				autoRenewal = value;
			}
		}

		public int? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
			}
		}

		public int? ColdStorageSize
		{
			get
			{
				return coldStorageSize;
			}
			set	
			{
				coldStorageSize = value;
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

		public bool? EncryptionType
		{
			get
			{
				return encryptionType;
			}
			set	
			{
				encryptionType = value;
			}
		}

		public string EncryptionKey
		{
			get
			{
				return encryptionKey;
			}
			set	
			{
				encryptionKey = value;
			}
		}

		public List<DescribeInstance_Tag> Tags
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

		public class DescribeInstance_Tag
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
	}
}
