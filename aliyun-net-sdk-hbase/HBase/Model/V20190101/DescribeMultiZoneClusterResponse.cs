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
	public class DescribeMultiZoneClusterResponse : AcsResponse
	{

		private bool? autoRenewal;

		private string clusterId;

		private string clusterName;

		private string createdTime;

		private string createdTimeUTC;

		private int? duration;

		private string engine;

		private string expireTime;

		private string expireTimeUTC;

		private string instanceId;

		private string instanceName;

		private bool? isDeletionProtection;

		private string maintainEndTime;

		private string maintainStartTime;

		private string majorVersion;

		private int? masterDiskSize;

		private string masterDiskType;

		private string masterInstanceType;

		private int? masterNodeCount;

		private string coreDiskCount;

		private int? coreDiskSize;

		private string coreDiskType;

		private string coreInstanceType;

		private int? coreNodeCount;

		private string logDiskCount;

		private int? logDiskSize;

		private string logDiskType;

		private string logInstanceType;

		private int? logNodeCount;

		private int? moduleId;

		private string moduleStackVersion;

		private string networkType;

		private string parentId;

		private string payType;

		private string regionId;

		private string requestId;

		private string status;

		private string multiZoneCombination;

		private string primaryZoneId;

		private string primaryVSwitchIds;

		private string standbyZoneId;

		private string standbyVSwitchIds;

		private string arbiterZoneId;

		private string arbiterVSwitchIds;

		private string vpcId;

		private string resourceGroupId;

		private bool? encryptionType;

		private string encryptionKey;

		private List<DescribeMultiZoneCluster_MultiZoneInstanceModel> multiZoneInstanceModels;

		private List<DescribeMultiZoneCluster_Tag> tags;

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

		public string LogDiskCount
		{
			get
			{
				return logDiskCount;
			}
			set	
			{
				logDiskCount = value;
			}
		}

		public int? LogDiskSize
		{
			get
			{
				return logDiskSize;
			}
			set	
			{
				logDiskSize = value;
			}
		}

		public string LogDiskType
		{
			get
			{
				return logDiskType;
			}
			set	
			{
				logDiskType = value;
			}
		}

		public string LogInstanceType
		{
			get
			{
				return logInstanceType;
			}
			set	
			{
				logInstanceType = value;
			}
		}

		public int? LogNodeCount
		{
			get
			{
				return logNodeCount;
			}
			set	
			{
				logNodeCount = value;
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

		public string MultiZoneCombination
		{
			get
			{
				return multiZoneCombination;
			}
			set	
			{
				multiZoneCombination = value;
			}
		}

		public string PrimaryZoneId
		{
			get
			{
				return primaryZoneId;
			}
			set	
			{
				primaryZoneId = value;
			}
		}

		public string PrimaryVSwitchIds
		{
			get
			{
				return primaryVSwitchIds;
			}
			set	
			{
				primaryVSwitchIds = value;
			}
		}

		public string StandbyZoneId
		{
			get
			{
				return standbyZoneId;
			}
			set	
			{
				standbyZoneId = value;
			}
		}

		public string StandbyVSwitchIds
		{
			get
			{
				return standbyVSwitchIds;
			}
			set	
			{
				standbyVSwitchIds = value;
			}
		}

		public string ArbiterZoneId
		{
			get
			{
				return arbiterZoneId;
			}
			set	
			{
				arbiterZoneId = value;
			}
		}

		public string ArbiterVSwitchIds
		{
			get
			{
				return arbiterVSwitchIds;
			}
			set	
			{
				arbiterVSwitchIds = value;
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

		public List<DescribeMultiZoneCluster_MultiZoneInstanceModel> MultiZoneInstanceModels
		{
			get
			{
				return multiZoneInstanceModels;
			}
			set	
			{
				multiZoneInstanceModels = value;
			}
		}

		public List<DescribeMultiZoneCluster_Tag> Tags
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

		public class DescribeMultiZoneCluster_MultiZoneInstanceModel
		{

			private string insName;

			private bool? isLatestVersion;

			private string minorVersion;

			private string status;

			private string role;

			public string InsName
			{
				get
				{
					return insName;
				}
				set	
				{
					insName = value;
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

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
				}
			}
		}

		public class DescribeMultiZoneCluster_Tag
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
