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
    public class CreateLaunchTemplateRequest : RpcAcsRequest<CreateLaunchTemplateResponse>
    {
        public CreateLaunchTemplateRequest()
            : base("Ecs", "2014-05-26", "CreateLaunchTemplate", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string launchTemplateName;

		private long? resourceOwnerId;

		private string securityEnhancementStrategy;

		private string networkType;

		private string keyPairName;

		private float? spotPriceLimit;

		private string imageOwnerAlias;

		private string resourceGroupId;

		private string hostName;

		private int? systemDiskIops;

		private List<TemplateTag> templateTags = new List<TemplateTag>(){ };

		private List<Tag> tags = new List<Tag>(){ };

		private int? period;

		private string templateResourceGroupId;

		private long? ownerId;

		private string vSwitchId;

		private string spotStrategy;

		private string instanceName;

		private string internetChargeType;

		private string zoneId;

		private int? internetMaxBandwidthIn;

		private string versionDescription;

		private string imageId;

		private string ioOptimized;

		private string securityGroupId;

		private int? internetMaxBandwidthOut;

		private string description;

		private string systemDiskCategory;

		private string userData;

		private bool? passwordInherit;

		private string instanceType;

		private string instanceChargeType;

		private bool? enableVmOsConfig;

		private List<NetworkInterface> networkInterfaces = new List<NetworkInterface>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string systemDiskDiskName;

		private string ramRoleName;

		private string autoReleaseTime;

		private int? spotDuration;

		private List<DataDisk> dataDisks = new List<DataDisk>(){ };

		private int? systemDiskSize;

		private string vpcId;

		private string systemDiskDescription;

		public string LaunchTemplateName
		{
			get
			{
				return launchTemplateName;
			}
			set	
			{
				launchTemplateName = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateName", value);
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

		public string SecurityEnhancementStrategy
		{
			get
			{
				return securityEnhancementStrategy;
			}
			set	
			{
				securityEnhancementStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SecurityEnhancementStrategy", value);
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
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
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
				DictionaryUtil.Add(QueryParameters, "KeyPairName", value);
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
				DictionaryUtil.Add(QueryParameters, "SpotPriceLimit", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ImageOwnerAlias", value);
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

		public string HostName
		{
			get
			{
				return hostName;
			}
			set	
			{
				hostName = value;
				DictionaryUtil.Add(QueryParameters, "HostName", value);
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
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Iops", value.ToString());
			}
		}

		public List<TemplateTag> TemplateTags
		{
			get
			{
				return templateTags;
			}

			set
			{
				templateTags = value;
				for (int i = 0; i < templateTags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TemplateTag." + (i + 1) + ".Key", templateTags[i].Key);
					DictionaryUtil.Add(QueryParameters,"TemplateTag." + (i + 1) + ".Value", templateTags[i].Value);
				}
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
				}
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
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string TemplateResourceGroupId
		{
			get
			{
				return templateResourceGroupId;
			}
			set	
			{
				templateResourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateResourceGroupId", value);
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

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
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
				DictionaryUtil.Add(QueryParameters, "SpotStrategy", value);
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
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
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
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
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
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
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
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthIn", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "VersionDescription", value);
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
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
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
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value);
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
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
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
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
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

		public string SystemDiskCategory
		{
			get
			{
				return systemDiskCategory;
			}
			set	
			{
				systemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Category", value);
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
				DictionaryUtil.Add(QueryParameters, "UserData", value);
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
				DictionaryUtil.Add(QueryParameters, "PasswordInherit", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
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
				DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
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
				DictionaryUtil.Add(QueryParameters, "EnableVmOsConfig", value.ToString());
			}
		}

		public List<NetworkInterface> NetworkInterfaces
		{
			get
			{
				return networkInterfaces;
			}

			set
			{
				networkInterfaces = value;
				for (int i = 0; i < networkInterfaces.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".PrimaryIpAddress", networkInterfaces[i].PrimaryIpAddress);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".VSwitchId", networkInterfaces[i].VSwitchId);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".SecurityGroupId", networkInterfaces[i].SecurityGroupId);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".NetworkInterfaceName", networkInterfaces[i].NetworkInterfaceName);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".Description", networkInterfaces[i].Description);
				}
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

		public string SystemDiskDiskName
		{
			get
			{
				return systemDiskDiskName;
			}
			set	
			{
				systemDiskDiskName = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.DiskName", value);
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
				DictionaryUtil.Add(QueryParameters, "RamRoleName", value);
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
				DictionaryUtil.Add(QueryParameters, "AutoReleaseTime", value);
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
				DictionaryUtil.Add(QueryParameters, "SpotDuration", value.ToString());
			}
		}

		public List<DataDisk> DataDisks
		{
			get
			{
				return dataDisks;
			}

			set
			{
				dataDisks = value;
				for (int i = 0; i < dataDisks.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Size", dataDisks[i].Size);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".SnapshotId", dataDisks[i].SnapshotId);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Category", dataDisks[i].Category);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Encrypted", dataDisks[i].Encrypted);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".DiskName", dataDisks[i].DiskName);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Description", dataDisks[i].Description);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".DeleteWithInstance", dataDisks[i].DeleteWithInstance);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Device", dataDisks[i].Device);
				}
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
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Size", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
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
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Description", value);
			}
		}

		public class TemplateTag
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

		public class Tag
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

		public class NetworkInterface
		{

			private string primaryIpAddress;

			private string vSwitchId;

			private string securityGroupId;

			private string networkInterfaceName;

			private string description;

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
		}

		public class DataDisk
		{

			private int? size;

			private string snapshotId;

			private string category;

			private string encrypted;

			private string diskName;

			private string description;

			private bool? deleteWithInstance;

			private string device;

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
		}

        public override CreateLaunchTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLaunchTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
