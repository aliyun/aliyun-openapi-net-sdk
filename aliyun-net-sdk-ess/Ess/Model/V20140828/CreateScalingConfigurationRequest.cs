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

		private int? dataDisk3Size;

		private string imageId;

		private string dataDisk1SnapshotId;

		private string dataDisk3Category;

		private string dataDisk1Device;

		private string scalingGroupId;

		private string dataDisk2Device;

		private string ioOptimized;

		private string securityGroupId;

		private int? internetMaxBandwidthOut;

		private string securityEnhancementStrategy;

		private string keyPairName;

		private string systemDiskCategory;

		private string accessKeyId;

		private string userData;

		private string dataDisk4Category;

		private string dataDisk2SnapshotId;

		private int? dataDisk4Size;

		private string action;

		private string instanceType;

		private string dataDisk2Category;

		private int? dataDisk1Size;

		private string dataDisk3SnapshotId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? dataDisk2Size;

		private string ramRoleName;

		private long? ownerId;

		private string scalingConfigurationName;

		private string tags;

		private string dataDisk2DeleteWithInstance;

		private string dataDisk1Category;

		private string dataDisk3DeleteWithInstance;

		private int? loadBalancerWeight;

		private int? systemDiskSize;

		private string dataDisk4SnapshotId;

		private string dataDisk4Device;

		private string internetChargeType;

		private string dataDisk3Device;

		private string dataDisk4DeleteWithInstance;

		private int? internetMaxBandwidthIn;

		private string dataDisk1DeleteWithInstance;

		public int? DataDisk3Size
		{
			get
			{
				return dataDisk3Size;
			}
			set	
			{
				dataDisk3Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.Size", value.ToString());
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

		public string DataDisk1SnapshotId
		{
			get
			{
				return dataDisk1SnapshotId;
			}
			set	
			{
				dataDisk1SnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.SnapshotId", value);
			}
		}

		public string DataDisk3Category
		{
			get
			{
				return dataDisk3Category;
			}
			set	
			{
				dataDisk3Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.Category", value);
			}
		}

		public string DataDisk1Device
		{
			get
			{
				return dataDisk1Device;
			}
			set	
			{
				dataDisk1Device = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.Device", value);
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

		public string DataDisk2Device
		{
			get
			{
				return dataDisk2Device;
			}
			set	
			{
				dataDisk2Device = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.Device", value);
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

		public string DataDisk4Category
		{
			get
			{
				return dataDisk4Category;
			}
			set	
			{
				dataDisk4Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.Category", value);
			}
		}

		public string DataDisk2SnapshotId
		{
			get
			{
				return dataDisk2SnapshotId;
			}
			set	
			{
				dataDisk2SnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.SnapshotId", value);
			}
		}

		public int? DataDisk4Size
		{
			get
			{
				return dataDisk4Size;
			}
			set	
			{
				dataDisk4Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.Size", value.ToString());
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

		public string DataDisk2Category
		{
			get
			{
				return dataDisk2Category;
			}
			set	
			{
				dataDisk2Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.Category", value);
			}
		}

		public int? DataDisk1Size
		{
			get
			{
				return dataDisk1Size;
			}
			set	
			{
				dataDisk1Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.Size", value.ToString());
			}
		}

		public string DataDisk3SnapshotId
		{
			get
			{
				return dataDisk3SnapshotId;
			}
			set	
			{
				dataDisk3SnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.SnapshotId", value);
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

		public int? DataDisk2Size
		{
			get
			{
				return dataDisk2Size;
			}
			set	
			{
				dataDisk2Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.Size", value.ToString());
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

		public string DataDisk2DeleteWithInstance
		{
			get
			{
				return dataDisk2DeleteWithInstance;
			}
			set	
			{
				dataDisk2DeleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.DeleteWithInstance", value);
			}
		}

		public string DataDisk1Category
		{
			get
			{
				return dataDisk1Category;
			}
			set	
			{
				dataDisk1Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.Category", value);
			}
		}

		public string DataDisk3DeleteWithInstance
		{
			get
			{
				return dataDisk3DeleteWithInstance;
			}
			set	
			{
				dataDisk3DeleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.DeleteWithInstance", value);
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

		public string DataDisk4SnapshotId
		{
			get
			{
				return dataDisk4SnapshotId;
			}
			set	
			{
				dataDisk4SnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.SnapshotId", value);
			}
		}

		public string DataDisk4Device
		{
			get
			{
				return dataDisk4Device;
			}
			set	
			{
				dataDisk4Device = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.Device", value);
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

		public string DataDisk3Device
		{
			get
			{
				return dataDisk3Device;
			}
			set	
			{
				dataDisk3Device = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.Device", value);
			}
		}

		public string DataDisk4DeleteWithInstance
		{
			get
			{
				return dataDisk4DeleteWithInstance;
			}
			set	
			{
				dataDisk4DeleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.DeleteWithInstance", value);
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

		public string DataDisk1DeleteWithInstance
		{
			get
			{
				return dataDisk1DeleteWithInstance;
			}
			set	
			{
				dataDisk1DeleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.DeleteWithInstance", value);
			}
		}

        public override CreateScalingConfigurationResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateScalingConfigurationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}