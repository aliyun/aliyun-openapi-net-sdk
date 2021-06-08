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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class CreateAutoProvisioningGroupRequest : RpcAcsRequest<CreateAutoProvisioningGroupResponse>
    {
        public CreateAutoProvisioningGroupRequest()
            : base("Ecs", "2014-05-26", "CreateAutoProvisioningGroup", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<LaunchConfigurationDataDisk> launchConfigurationDataDisks = new List<LaunchConfigurationDataDisk>(){ };

		private long? resourceOwnerId;

		private string launchConfigurationSystemDiskCategory;

		private string autoProvisioningGroupType;

		private string launchConfigurationSystemDiskPerformanceLevel;

		private List<string> launchConfigurationHostNamess = new List<string>(){ };

		private string resourceGroupId;

		private string launchConfigurationImageId;

		private string launchConfigurationResourceGroupId;

		private string payAsYouGoAllocationStrategy;

		private string defaultTargetCapacityType;

		private string launchConfigurationKeyPairName;

		private List<SystemDiskConfig> systemDiskConfigs = new List<SystemDiskConfig>(){ };

		private List<DataDiskConfig> dataDiskConfigs = new List<DataDiskConfig>(){ };

		private string validUntil;

		private string launchTemplateId;

		private long? ownerId;

		private int? launchConfigurationSystemDiskSize;

		private int? launchConfigurationInternetMaxBandwidthOut;

		private string launchConfigurationHostName;

		private string minTargetCapacity;

		private float? maxSpotPrice;

		private bool? launchConfigurationPasswordInherit;

		private string clientToken;

		private string launchConfigurationSecurityGroupId;

		private string description;

		private bool? terminateInstancesWithExpiration;

		private string launchConfigurationUserData;

		private string launchConfigurationCreditSpecification;

		private string launchConfigurationInstanceName;

		private string launchConfigurationInstanceDescription;

		private string spotAllocationStrategy;

		private bool? terminateInstances;

		private string launchConfigurationSystemDiskName;

		private string launchConfigurationSystemDiskDescription;

		private string excessCapacityTerminationPolicy;

		private List<LaunchTemplateConfig> launchTemplateConfigs = new List<LaunchTemplateConfig>(){ };

		private string launchConfigurationRamRoleName;

		private int? launchConfigurationInternetMaxBandwidthIn;

		private string spotInstanceInterruptionBehavior;

		private string launchConfigurationSecurityEnhancementStrategy;

		private List<LaunchConfigurationTag> launchConfigurationTags = new List<LaunchConfigurationTag>(){ };

		private string launchConfigurationDeploymentSetId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? spotInstancePoolsToUseCount;

		private string launchConfigurationInternetChargeType;

		private string launchTemplateVersion;

		private string launchConfigurationIoOptimized;

		private string payAsYouGoTargetCapacity;

		private string totalTargetCapacity;

		private string spotTargetCapacity;

		private string validFrom;

		private string autoProvisioningGroupName;

		public List<LaunchConfigurationDataDisk> LaunchConfigurationDataDisks
		{
			get
			{
				return launchConfigurationDataDisks;
			}

			set
			{
				launchConfigurationDataDisks = value;
				for (int i = 0; i < launchConfigurationDataDisks.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".PerformanceLevel", launchConfigurationDataDisks[i].PerformanceLevel);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".KmsKeyId", launchConfigurationDataDisks[i].KmsKeyId);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".Description", launchConfigurationDataDisks[i].Description);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".SnapshotId", launchConfigurationDataDisks[i].SnapshotId);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".Size", launchConfigurationDataDisks[i].Size);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".Device", launchConfigurationDataDisks[i].Device);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".DiskName", launchConfigurationDataDisks[i].DiskName);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".Category", launchConfigurationDataDisks[i].Category);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".DeleteWithInstance", launchConfigurationDataDisks[i].DeleteWithInstance);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.DataDisk." + (i + 1) + ".Encrypted", launchConfigurationDataDisks[i].Encrypted);
				}
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string LaunchConfigurationSystemDiskCategory
		{
			get
			{
				return launchConfigurationSystemDiskCategory;
			}
			set	
			{
				launchConfigurationSystemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.SystemDiskCategory", value);
			}
		}

		public string AutoProvisioningGroupType
		{
			get
			{
				return autoProvisioningGroupType;
			}
			set	
			{
				autoProvisioningGroupType = value;
				DictionaryUtil.Add(QueryParameters, "AutoProvisioningGroupType", value);
			}
		}

		public string LaunchConfigurationSystemDiskPerformanceLevel
		{
			get
			{
				return launchConfigurationSystemDiskPerformanceLevel;
			}
			set	
			{
				launchConfigurationSystemDiskPerformanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.SystemDiskPerformanceLevel", value);
			}
		}

		public List<string> LaunchConfigurationHostNamess
		{
			get
			{
				return launchConfigurationHostNamess;
			}

			set
			{
				launchConfigurationHostNamess = value;
				for (int i = 0; i < launchConfigurationHostNamess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.HostNames." + (i + 1) , launchConfigurationHostNamess[i]);
				}
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
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string LaunchConfigurationImageId
		{
			get
			{
				return launchConfigurationImageId;
			}
			set	
			{
				launchConfigurationImageId = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.ImageId", value);
			}
		}

		public string LaunchConfigurationResourceGroupId
		{
			get
			{
				return launchConfigurationResourceGroupId;
			}
			set	
			{
				launchConfigurationResourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.ResourceGroupId", value);
			}
		}

		public string PayAsYouGoAllocationStrategy
		{
			get
			{
				return payAsYouGoAllocationStrategy;
			}
			set	
			{
				payAsYouGoAllocationStrategy = value;
				DictionaryUtil.Add(QueryParameters, "PayAsYouGoAllocationStrategy", value);
			}
		}

		public string DefaultTargetCapacityType
		{
			get
			{
				return defaultTargetCapacityType;
			}
			set	
			{
				defaultTargetCapacityType = value;
				DictionaryUtil.Add(QueryParameters, "DefaultTargetCapacityType", value);
			}
		}

		public string LaunchConfigurationKeyPairName
		{
			get
			{
				return launchConfigurationKeyPairName;
			}
			set	
			{
				launchConfigurationKeyPairName = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.KeyPairName", value);
			}
		}

		public List<SystemDiskConfig> SystemDiskConfigs
		{
			get
			{
				return systemDiskConfigs;
			}

			set
			{
				systemDiskConfigs = value;
				for (int i = 0; i < systemDiskConfigs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SystemDiskConfig." + (i + 1) + ".DiskCategory", systemDiskConfigs[i].DiskCategory);
				}
			}
		}

		public List<DataDiskConfig> DataDiskConfigs
		{
			get
			{
				return dataDiskConfigs;
			}

			set
			{
				dataDiskConfigs = value;
				for (int i = 0; i < dataDiskConfigs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DataDiskConfig." + (i + 1) + ".DiskCategory", dataDiskConfigs[i].DiskCategory);
				}
			}
		}

		public string ValidUntil
		{
			get
			{
				return validUntil;
			}
			set	
			{
				validUntil = value;
				DictionaryUtil.Add(QueryParameters, "ValidUntil", value);
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
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? LaunchConfigurationSystemDiskSize
		{
			get
			{
				return launchConfigurationSystemDiskSize;
			}
			set	
			{
				launchConfigurationSystemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.SystemDiskSize", value.ToString());
			}
		}

		public int? LaunchConfigurationInternetMaxBandwidthOut
		{
			get
			{
				return launchConfigurationInternetMaxBandwidthOut;
			}
			set	
			{
				launchConfigurationInternetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.InternetMaxBandwidthOut", value.ToString());
			}
		}

		public string LaunchConfigurationHostName
		{
			get
			{
				return launchConfigurationHostName;
			}
			set	
			{
				launchConfigurationHostName = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.HostName", value);
			}
		}

		public string MinTargetCapacity
		{
			get
			{
				return minTargetCapacity;
			}
			set	
			{
				minTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "MinTargetCapacity", value);
			}
		}

		public float? MaxSpotPrice
		{
			get
			{
				return maxSpotPrice;
			}
			set	
			{
				maxSpotPrice = value;
				DictionaryUtil.Add(QueryParameters, "MaxSpotPrice", value.ToString());
			}
		}

		public bool? LaunchConfigurationPasswordInherit
		{
			get
			{
				return launchConfigurationPasswordInherit;
			}
			set	
			{
				launchConfigurationPasswordInherit = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.PasswordInherit", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string LaunchConfigurationSecurityGroupId
		{
			get
			{
				return launchConfigurationSecurityGroupId;
			}
			set	
			{
				launchConfigurationSecurityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.SecurityGroupId", value);
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public bool? TerminateInstancesWithExpiration
		{
			get
			{
				return terminateInstancesWithExpiration;
			}
			set	
			{
				terminateInstancesWithExpiration = value;
				DictionaryUtil.Add(QueryParameters, "TerminateInstancesWithExpiration", value.ToString());
			}
		}

		public string LaunchConfigurationUserData
		{
			get
			{
				return launchConfigurationUserData;
			}
			set	
			{
				launchConfigurationUserData = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.UserData", value);
			}
		}

		public string LaunchConfigurationCreditSpecification
		{
			get
			{
				return launchConfigurationCreditSpecification;
			}
			set	
			{
				launchConfigurationCreditSpecification = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.CreditSpecification", value);
			}
		}

		public string LaunchConfigurationInstanceName
		{
			get
			{
				return launchConfigurationInstanceName;
			}
			set	
			{
				launchConfigurationInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.InstanceName", value);
			}
		}

		public string LaunchConfigurationInstanceDescription
		{
			get
			{
				return launchConfigurationInstanceDescription;
			}
			set	
			{
				launchConfigurationInstanceDescription = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.InstanceDescription", value);
			}
		}

		public string SpotAllocationStrategy
		{
			get
			{
				return spotAllocationStrategy;
			}
			set	
			{
				spotAllocationStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SpotAllocationStrategy", value);
			}
		}

		public bool? TerminateInstances
		{
			get
			{
				return terminateInstances;
			}
			set	
			{
				terminateInstances = value;
				DictionaryUtil.Add(QueryParameters, "TerminateInstances", value.ToString());
			}
		}

		public string LaunchConfigurationSystemDiskName
		{
			get
			{
				return launchConfigurationSystemDiskName;
			}
			set	
			{
				launchConfigurationSystemDiskName = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.SystemDiskName", value);
			}
		}

		public string LaunchConfigurationSystemDiskDescription
		{
			get
			{
				return launchConfigurationSystemDiskDescription;
			}
			set	
			{
				launchConfigurationSystemDiskDescription = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.SystemDiskDescription", value);
			}
		}

		public string ExcessCapacityTerminationPolicy
		{
			get
			{
				return excessCapacityTerminationPolicy;
			}
			set	
			{
				excessCapacityTerminationPolicy = value;
				DictionaryUtil.Add(QueryParameters, "ExcessCapacityTerminationPolicy", value);
			}
		}

		public List<LaunchTemplateConfig> LaunchTemplateConfigs
		{
			get
			{
				return launchTemplateConfigs;
			}

			set
			{
				launchTemplateConfigs = value;
				for (int i = 0; i < launchTemplateConfigs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".VSwitchId", launchTemplateConfigs[i].VSwitchId);
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".MaxPrice", launchTemplateConfigs[i].MaxPrice);
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".Priority", launchTemplateConfigs[i].Priority);
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".InstanceType", launchTemplateConfigs[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".WeightedCapacity", launchTemplateConfigs[i].WeightedCapacity);
				}
			}
		}

		public string LaunchConfigurationRamRoleName
		{
			get
			{
				return launchConfigurationRamRoleName;
			}
			set	
			{
				launchConfigurationRamRoleName = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.RamRoleName", value);
			}
		}

		public int? LaunchConfigurationInternetMaxBandwidthIn
		{
			get
			{
				return launchConfigurationInternetMaxBandwidthIn;
			}
			set	
			{
				launchConfigurationInternetMaxBandwidthIn = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.InternetMaxBandwidthIn", value.ToString());
			}
		}

		public string SpotInstanceInterruptionBehavior
		{
			get
			{
				return spotInstanceInterruptionBehavior;
			}
			set	
			{
				spotInstanceInterruptionBehavior = value;
				DictionaryUtil.Add(QueryParameters, "SpotInstanceInterruptionBehavior", value);
			}
		}

		public string LaunchConfigurationSecurityEnhancementStrategy
		{
			get
			{
				return launchConfigurationSecurityEnhancementStrategy;
			}
			set	
			{
				launchConfigurationSecurityEnhancementStrategy = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.SecurityEnhancementStrategy", value);
			}
		}

		public List<LaunchConfigurationTag> LaunchConfigurationTags
		{
			get
			{
				return launchConfigurationTags;
			}

			set
			{
				launchConfigurationTags = value;
				for (int i = 0; i < launchConfigurationTags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.Tag." + (i + 1) + ".Key", launchConfigurationTags[i].Key);
					DictionaryUtil.Add(QueryParameters,"LaunchConfiguration.Tag." + (i + 1) + ".Value", launchConfigurationTags[i].Value);
				}
			}
		}

		public string LaunchConfigurationDeploymentSetId
		{
			get
			{
				return launchConfigurationDeploymentSetId;
			}
			set	
			{
				launchConfigurationDeploymentSetId = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.DeploymentSetId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public int? SpotInstancePoolsToUseCount
		{
			get
			{
				return spotInstancePoolsToUseCount;
			}
			set	
			{
				spotInstancePoolsToUseCount = value;
				DictionaryUtil.Add(QueryParameters, "SpotInstancePoolsToUseCount", value.ToString());
			}
		}

		public string LaunchConfigurationInternetChargeType
		{
			get
			{
				return launchConfigurationInternetChargeType;
			}
			set	
			{
				launchConfigurationInternetChargeType = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.InternetChargeType", value);
			}
		}

		public string LaunchTemplateVersion
		{
			get
			{
				return launchTemplateVersion;
			}
			set	
			{
				launchTemplateVersion = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateVersion", value);
			}
		}

		public string LaunchConfigurationIoOptimized
		{
			get
			{
				return launchConfigurationIoOptimized;
			}
			set	
			{
				launchConfigurationIoOptimized = value;
				DictionaryUtil.Add(QueryParameters, "LaunchConfiguration.IoOptimized", value);
			}
		}

		public string PayAsYouGoTargetCapacity
		{
			get
			{
				return payAsYouGoTargetCapacity;
			}
			set	
			{
				payAsYouGoTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "PayAsYouGoTargetCapacity", value);
			}
		}

		public string TotalTargetCapacity
		{
			get
			{
				return totalTargetCapacity;
			}
			set	
			{
				totalTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "TotalTargetCapacity", value);
			}
		}

		public string SpotTargetCapacity
		{
			get
			{
				return spotTargetCapacity;
			}
			set	
			{
				spotTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "SpotTargetCapacity", value);
			}
		}

		public string ValidFrom
		{
			get
			{
				return validFrom;
			}
			set	
			{
				validFrom = value;
				DictionaryUtil.Add(QueryParameters, "ValidFrom", value);
			}
		}

		public string AutoProvisioningGroupName
		{
			get
			{
				return autoProvisioningGroupName;
			}
			set	
			{
				autoProvisioningGroupName = value;
				DictionaryUtil.Add(QueryParameters, "AutoProvisioningGroupName", value);
			}
		}

		public class LaunchConfigurationDataDisk
		{

			private string performanceLevel;

			private string kmsKeyId;

			private string description;

			private string snapshotId;

			private int? size;

			private string device;

			private string diskName;

			private string category;

			private bool? deleteWithInstance;

			private bool? encrypted;

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

			public string KmsKeyId
			{
				get
				{
					return kmsKeyId;
				}
				set	
				{
					kmsKeyId = value;
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

			public bool? Encrypted
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
		}

		public class SystemDiskConfig
		{

			private string diskCategory;

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
		}

		public class DataDiskConfig
		{

			private string diskCategory;

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
		}

		public class LaunchTemplateConfig
		{

			private string vSwitchId;

			private double? maxPrice;

			private int? priority;

			private string instanceType;

			private double? weightedCapacity;

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

			public double? MaxPrice
			{
				get
				{
					return maxPrice;
				}
				set	
				{
					maxPrice = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
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

			public double? WeightedCapacity
			{
				get
				{
					return weightedCapacity;
				}
				set	
				{
					weightedCapacity = value;
				}
			}
		}

		public class LaunchConfigurationTag
		{

			private string key;

			private string value_;

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

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

        public override CreateAutoProvisioningGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAutoProvisioningGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
