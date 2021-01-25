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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeLaunchTemplateVersionsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeLaunchTemplateVersions_LaunchTemplateVersionSet> launchTemplateVersionSets;

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

			private string createTime;

			private string modifiedTime;

			private string launchTemplateId;

			private string launchTemplateName;

			private bool? defaultVersion;

			private long? versionNumber;

			private string versionDescription;

			private string createdBy;

			private DescribeLaunchTemplateVersions_LaunchTemplateData launchTemplateData;

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

				private string imageId;

				private string imageOwnerAlias;

				private bool? passwordInherit;

				private string instanceType;

				private string securityGroupId;

				private string vpcId;

				private string vSwitchId;

				private string instanceName;

				private string description;

				private int? internetMaxBandwidthIn;

				private int? internetMaxBandwidthOut;

				private string hostName;

				private string zoneId;

				private int? systemDiskSize;

				private string systemDiskCategory;

				private string systemDiskDiskName;

				private string systemDiskDescription;

				private int? systemDiskIops;

				private string systemDiskPerformanceLevel;

				private bool? systemDiskDeleteWithInstance;

				private string ioOptimized;

				private string instanceChargeType;

				private int? period;

				private string internetChargeType;

				private bool? enableVmOsConfig;

				private string networkType;

				private string userData;

				private string keyPairName;

				private string ramRoleName;

				private string autoReleaseTime;

				private string spotStrategy;

				private float? spotPriceLimit;

				private int? spotDuration;

				private string resourceGroupId;

				private string securityEnhancementStrategy;

				private string privateIpAddress;

				private string deploymentSetId;

				private List<DescribeLaunchTemplateVersions_DataDisk> dataDisks;

				private List<DescribeLaunchTemplateVersions_NetworkInterface> networkInterfaces;

				private List<DescribeLaunchTemplateVersions_InstanceTag> tags;

				private List<string> securityGroupIds;

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

					private int? size;

					private string snapshotId;

					private string category;

					private string encrypted;

					private string diskName;

					private string description;

					private bool? deleteWithInstance;

					private string device;

					private string performanceLevel;

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
				}

				public class DescribeLaunchTemplateVersions_NetworkInterface
				{

					private string primaryIpAddress;

					private string vSwitchId;

					private string securityGroupId;

					private string networkInterfaceName;

					private string description;

					private List<string> securityGroupIds1;

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
