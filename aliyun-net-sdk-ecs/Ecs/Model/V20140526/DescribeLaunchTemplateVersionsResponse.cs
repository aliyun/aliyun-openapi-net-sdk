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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeLaunchTemplateVersionsResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeLaunchTemplateVersions_LaunchTemplateVersionSet> launchTemplateVersionSets;

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

		public int? TotalCount
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

		public List<DescribeLaunchTemplateVersions_LaunchTemplateVersionSet> LaunchTemplateVersionSets
		{
			get
			{
				return launchTemplateVersionSets;
			}
			set	
			{
				launchTemplateVersionSets = value;
			}
		}

		public class DescribeLaunchTemplateVersions_LaunchTemplateVersionSet
		{

			private string launchTemplateName;

			private bool? defaultVersion;

			private long? versionNumber;

			private string modifiedTime;

			private string launchTemplateId;

			private string createTime;

			private string createdBy;

			private string versionDescription;

			private DescribeLaunchTemplateVersions_LaunchTemplateData launchTemplateData;

			public string LaunchTemplateName
			{
				get
				{
					return launchTemplateName;
				}
				set	
				{
					launchTemplateName = value;
				}
			}

			public bool? DefaultVersion
			{
				get
				{
					return defaultVersion;
				}
				set	
				{
					defaultVersion = value;
				}
			}

			public long? VersionNumber
			{
				get
				{
					return versionNumber;
				}
				set	
				{
					versionNumber = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string LaunchTemplateId
			{
				get
				{
					return launchTemplateId;
				}
				set	
				{
					launchTemplateId = value;
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

			public string CreatedBy
			{
				get
				{
					return createdBy;
				}
				set	
				{
					createdBy = value;
				}
			}

			public string VersionDescription
			{
				get
				{
					return versionDescription;
				}
				set	
				{
					versionDescription = value;
				}
			}

			public DescribeLaunchTemplateVersions_LaunchTemplateData LaunchTemplateData
			{
				get
				{
					return launchTemplateData;
				}
				set	
				{
					launchTemplateData = value;
				}
			}

			public class DescribeLaunchTemplateVersions_LaunchTemplateData
			{

				private string deploymentSetId;

				private string vpcId;

				private string systemDiskPerformanceLevel;

				private string keyPairName;

				private string securityGroupId;

				private string networkType;

				private string spotStrategy;

				private bool? enableVmOsConfig;

				private string description;

				private int? spotDuration;

				private string instanceName;

				private string securityEnhancementStrategy;

				private string userData;

				private string systemDiskDiskName;

				private int? systemDiskSize;

				private float? spotPriceLimit;

				private bool? passwordInherit;

				private string privateIpAddress;

				private string imageId;

				private bool? systemDiskDeleteWithInstance;

				private string systemDiskCategory;

				private string autoReleaseTime;

				private string systemDiskDescription;

				private string imageOwnerAlias;

				private string hostName;

				private int? systemDiskIops;

				private string systemDiskAutoSnapshotPolicyId;

				private int? internetMaxBandwidthOut;

				private int? internetMaxBandwidthIn;

				private string instanceType;

				private int? period;

				private string instanceChargeType;

				private string ioOptimized;

				private string ramRoleName;

				private string vSwitchId;

				private string resourceGroupId;

				private string internetChargeType;

				private string zoneId;

				private int? ipv6AddressCount;

				private long? systemDiskProvisionedIops;

				private bool? systemDiskBurstingEnabled;

				private List<DescribeLaunchTemplateVersions_DataDisk> dataDisks;

				private List<DescribeLaunchTemplateVersions_NetworkInterface> networkInterfaces;

				private List<DescribeLaunchTemplateVersions_InstanceTag> tags;

				private List<string> securityGroupIds;

				public string DeploymentSetId
				{
					get
					{
						return deploymentSetId;
					}
					set	
					{
						deploymentSetId = value;
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

				public string SystemDiskPerformanceLevel
				{
					get
					{
						return systemDiskPerformanceLevel;
					}
					set	
					{
						systemDiskPerformanceLevel = value;
					}
				}

				public string KeyPairName
				{
					get
					{
						return keyPairName;
					}
					set	
					{
						keyPairName = value;
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

				public string SpotStrategy
				{
					get
					{
						return spotStrategy;
					}
					set	
					{
						spotStrategy = value;
					}
				}

				public bool? EnableVmOsConfig
				{
					get
					{
						return enableVmOsConfig;
					}
					set	
					{
						enableVmOsConfig = value;
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

				public int? SpotDuration
				{
					get
					{
						return spotDuration;
					}
					set	
					{
						spotDuration = value;
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

				public string SecurityEnhancementStrategy
				{
					get
					{
						return securityEnhancementStrategy;
					}
					set	
					{
						securityEnhancementStrategy = value;
					}
				}

				public string UserData
				{
					get
					{
						return userData;
					}
					set	
					{
						userData = value;
					}
				}

				public string SystemDiskDiskName
				{
					get
					{
						return systemDiskDiskName;
					}
					set	
					{
						systemDiskDiskName = value;
					}
				}

				public int? SystemDiskSize
				{
					get
					{
						return systemDiskSize;
					}
					set	
					{
						systemDiskSize = value;
					}
				}

				public float? SpotPriceLimit
				{
					get
					{
						return spotPriceLimit;
					}
					set	
					{
						spotPriceLimit = value;
					}
				}

				public bool? PasswordInherit
				{
					get
					{
						return passwordInherit;
					}
					set	
					{
						passwordInherit = value;
					}
				}

				public string PrivateIpAddress
				{
					get
					{
						return privateIpAddress;
					}
					set	
					{
						privateIpAddress = value;
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

				public bool? SystemDiskDeleteWithInstance
				{
					get
					{
						return systemDiskDeleteWithInstance;
					}
					set	
					{
						systemDiskDeleteWithInstance = value;
					}
				}

				public string SystemDiskCategory
				{
					get
					{
						return systemDiskCategory;
					}
					set	
					{
						systemDiskCategory = value;
					}
				}

				public string AutoReleaseTime
				{
					get
					{
						return autoReleaseTime;
					}
					set	
					{
						autoReleaseTime = value;
					}
				}

				public string SystemDiskDescription
				{
					get
					{
						return systemDiskDescription;
					}
					set	
					{
						systemDiskDescription = value;
					}
				}

				public string ImageOwnerAlias
				{
					get
					{
						return imageOwnerAlias;
					}
					set	
					{
						imageOwnerAlias = value;
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

				public int? SystemDiskIops
				{
					get
					{
						return systemDiskIops;
					}
					set	
					{
						systemDiskIops = value;
					}
				}

				public string SystemDiskAutoSnapshotPolicyId
				{
					get
					{
						return systemDiskAutoSnapshotPolicyId;
					}
					set	
					{
						systemDiskAutoSnapshotPolicyId = value;
					}
				}

				public int? InternetMaxBandwidthOut
				{
					get
					{
						return internetMaxBandwidthOut;
					}
					set	
					{
						internetMaxBandwidthOut = value;
					}
				}

				public int? InternetMaxBandwidthIn
				{
					get
					{
						return internetMaxBandwidthIn;
					}
					set	
					{
						internetMaxBandwidthIn = value;
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

				public int? Period
				{
					get
					{
						return period;
					}
					set	
					{
						period = value;
					}
				}

				public string InstanceChargeType
				{
					get
					{
						return instanceChargeType;
					}
					set	
					{
						instanceChargeType = value;
					}
				}

				public string IoOptimized
				{
					get
					{
						return ioOptimized;
					}
					set	
					{
						ioOptimized = value;
					}
				}

				public string RamRoleName
				{
					get
					{
						return ramRoleName;
					}
					set	
					{
						ramRoleName = value;
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

				public string InternetChargeType
				{
					get
					{
						return internetChargeType;
					}
					set	
					{
						internetChargeType = value;
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

				public int? Ipv6AddressCount
				{
					get
					{
						return ipv6AddressCount;
					}
					set	
					{
						ipv6AddressCount = value;
					}
				}

				public long? SystemDiskProvisionedIops
				{
					get
					{
						return systemDiskProvisionedIops;
					}
					set	
					{
						systemDiskProvisionedIops = value;
					}
				}

				public bool? SystemDiskBurstingEnabled
				{
					get
					{
						return systemDiskBurstingEnabled;
					}
					set	
					{
						systemDiskBurstingEnabled = value;
					}
				}

				public List<DescribeLaunchTemplateVersions_DataDisk> DataDisks
				{
					get
					{
						return dataDisks;
					}
					set	
					{
						dataDisks = value;
					}
				}

				public List<DescribeLaunchTemplateVersions_NetworkInterface> NetworkInterfaces
				{
					get
					{
						return networkInterfaces;
					}
					set	
					{
						networkInterfaces = value;
					}
				}

				public List<DescribeLaunchTemplateVersions_InstanceTag> Tags
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

				public List<string> SecurityGroupIds
				{
					get
					{
						return securityGroupIds;
					}
					set	
					{
						securityGroupIds = value;
					}
				}

				public class DescribeLaunchTemplateVersions_DataDisk
				{

					private string performanceLevel;

					private string description;

					private string snapshotId;

					private string device;

					private int? size;

					private string diskName;

					private string category;

					private bool? deleteWithInstance;

					private string encrypted;

					private long? provisionedIops;

					private bool? burstingEnabled;

					private string autoSnapshotPolicyId;

					public string PerformanceLevel
					{
						get
						{
							return performanceLevel;
						}
						set	
						{
							performanceLevel = value;
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

					public string SnapshotId
					{
						get
						{
							return snapshotId;
						}
						set	
						{
							snapshotId = value;
						}
					}

					public string Device
					{
						get
						{
							return device;
						}
						set	
						{
							device = value;
						}
					}

					public int? Size
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

					public string DiskName
					{
						get
						{
							return diskName;
						}
						set	
						{
							diskName = value;
						}
					}

					public string Category
					{
						get
						{
							return category;
						}
						set	
						{
							category = value;
						}
					}

					public bool? DeleteWithInstance
					{
						get
						{
							return deleteWithInstance;
						}
						set	
						{
							deleteWithInstance = value;
						}
					}

					public string Encrypted
					{
						get
						{
							return encrypted;
						}
						set	
						{
							encrypted = value;
						}
					}

					public long? ProvisionedIops
					{
						get
						{
							return provisionedIops;
						}
						set	
						{
							provisionedIops = value;
						}
					}

					public bool? BurstingEnabled
					{
						get
						{
							return burstingEnabled;
						}
						set	
						{
							burstingEnabled = value;
						}
					}

					public string AutoSnapshotPolicyId
					{
						get
						{
							return autoSnapshotPolicyId;
						}
						set	
						{
							autoSnapshotPolicyId = value;
						}
					}
				}

				public class DescribeLaunchTemplateVersions_NetworkInterface
				{

					private string networkInterfaceName;

					private string vSwitchId;

					private string description;

					private string primaryIpAddress;

					private string securityGroupId;

					private string instanceType;

					private string networkInterfaceTrafficMode;

					private List<string> securityGroupIds1;

					public string NetworkInterfaceName
					{
						get
						{
							return networkInterfaceName;
						}
						set	
						{
							networkInterfaceName = value;
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

					public string PrimaryIpAddress
					{
						get
						{
							return primaryIpAddress;
						}
						set	
						{
							primaryIpAddress = value;
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

					public string NetworkInterfaceTrafficMode
					{
						get
						{
							return networkInterfaceTrafficMode;
						}
						set	
						{
							networkInterfaceTrafficMode = value;
						}
					}

					public List<string> SecurityGroupIds1
					{
						get
						{
							return securityGroupIds1;
						}
						set	
						{
							securityGroupIds1 = value;
						}
					}
				}

				public class DescribeLaunchTemplateVersions_InstanceTag
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
}
