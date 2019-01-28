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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class CreateScalingConfigurationRequest : RpcAcsRequest<CreateScalingConfigurationResponse>
    {
        public CreateScalingConfigurationRequest()
            : base("Ess", "2014-08-28", "CreateScalingConfiguration", "ess", "openAPI")
        {
        }

		private string imageId;

		private int? memory;

		private string scalingGroupId;

		private List<string> instanceTypes;

		private string ioOptimized;

		private string securityGroupId;

		private int? internetMaxBandwidthOut;

		private string securityEnhancementStrategy;

		private string keyPairName;

		private List<SpotPriceLimit> spotPriceLimits;

		private string systemDiskCategory;

		private string accessKeyId;

		private string userData;

		private string resourceGroupId;

		private string hostName;

		private string password;

		private bool? passwordInherit;

		private string imageName;

		private string action;

		private string instanceType;

		private string deploymentSetId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? cpu;

		private string ramRoleName;

		private long? ownerId;

		private List<DataDisk> dataDisks;

		private string scalingConfigurationName;

		private string tags;

		private string spotStrategy;

		private int? loadBalancerWeight;

		private string instanceName;

		private int? systemDiskSize;

		private string internetChargeType;

		private int? internetMaxBandwidthIn;

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

		public int? Memory
		{
			get
			{
				return memory;
			}
			set	
			{
				memory = value;
				DictionaryUtil.Add(QueryParameters, "Memory", value.ToString());
			}
		}

		public string ScalingGroupId
		{
			get
			{
				return scalingGroupId;
			}
			set	
			{
				scalingGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId", value);
			}
		}

		public List<string> InstanceTypes
		{
			get
			{
				return instanceTypes;
			}

			set
			{
				instanceTypes = value;
				for (int i = 0; i < instanceTypes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceTypes." + (i + 1) , instanceTypes[i]);
				}
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

		public List<SpotPriceLimit> SpotPriceLimits
		{
			get
			{
				return spotPriceLimits;
			}

			set
			{
				spotPriceLimits = value;
				for (int i = 0; i < spotPriceLimits.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SpotPriceLimit." + (i + 1) + ".InstanceType", spotPriceLimits[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"SpotPriceLimit." + (i + 1) + ".PriceLimit", spotPriceLimits[i].PriceLimit);
				}
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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
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

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
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

		public string ImageName
		{
			get
			{
				return imageName;
			}
			set	
			{
				imageName = value;
				DictionaryUtil.Add(QueryParameters, "ImageName", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

		public string DeploymentSetId
		{
			get
			{
				return deploymentSetId;
			}
			set	
			{
				deploymentSetId = value;
				DictionaryUtil.Add(QueryParameters, "DeploymentSetId", value);
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

		public int? Cpu
		{
			get
			{
				return cpu;
			}
			set	
			{
				cpu = value;
				DictionaryUtil.Add(QueryParameters, "Cpu", value.ToString());
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
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".SnapshotId", dataDisks[i].SnapshotId);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Size", dataDisks[i].Size);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Category", dataDisks[i].Category);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Device", dataDisks[i].Device);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".DeleteWithInstance", dataDisks[i].DeleteWithInstance);
				}
			}
		}

		public string ScalingConfigurationName
		{
			get
			{
				return scalingConfigurationName;
			}
			set	
			{
				scalingConfigurationName = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName", value);
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
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

		public int? LoadBalancerWeight
		{
			get
			{
				return loadBalancerWeight;
			}
			set	
			{
				loadBalancerWeight = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight", value.ToString());
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

		public class SpotPriceLimit
		{

			private string instanceType;

			private float? priceLimit;

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

			public float? PriceLimit
			{
				get
				{
					return priceLimit;
				}
				set	
				{
					priceLimit = value;
				}
			}
		}

		public class DataDisk
		{

			private string snapshotId;

			private int? size;

			private string category;

			private string device;

			private bool? deleteWithInstance;

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
		}

        public override CreateScalingConfigurationResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateScalingConfigurationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}