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
	public class DescribeInstancesResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private long? totalCount;

		private List<DescribeInstances_Instance> instances;

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeInstances_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class DescribeInstances_Instance
		{

			private string vpcId;

			private string status;

			private int? moduleId;

			private string vswitchId;

			private string backupStatus;

			private string payType;

			private string coreDiskType;

			private int? masterNodeCount;

			private string networkType;

			private string createdTimeUTC;

			private string parentId;

			private string expireTimeUTC;

			private string instanceName;

			private string masterInstanceType;

			private string coreInstanceType;

			private string createdTime;

			private int? coreDiskSize;

			private string clusterId;

			private string expireTime;

			private bool? isHa;

			private string instanceId;

			private string coldStorageStatus;

			private bool? isDeletionProtection;

			private string regionId;

			private int? masterDiskSize;

			private string masterDiskType;

			private bool? autoRenewal;

			private string clusterType;

			private string resourceGroupId;

			private string clusterName;

			private string zoneId;

			private int? duration;

			private string moduleStackVersion;

			private string engine;

			private string majorVersion;

			private string coreDiskCount;

			private int? coreNodeCount;

			private List<DescribeInstances_Tag> tags;

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

			public List<DescribeInstances_Tag> Tags
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

			public class DescribeInstances_Tag
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
}
