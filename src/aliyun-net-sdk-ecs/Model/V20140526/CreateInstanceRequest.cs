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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class CreateInstanceRequest : RpcAcsRequest<CreateInstanceResponse>
    {
        public CreateInstanceRequest()
            : base("Ecs", "2014-05-26", "CreateInstance")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _imageId;

		private string _instanceType;

		private string _securityGroupId;

		private string _instanceName;

		private string _internetChargeType;

		private int? _internetMaxBandwidthIn;

		private int? _internetMaxBandwidthOut;

		private string _hostName;

		private string _password;

		private string _zoneId;

		private string _clusterId;

		private string _clientToken;

		private string _vlanId;

		private string _innerIpAddress;

		private int? _systemDiskSize;

		private string _systemDiskCategory;

		private string _systemDiskDiskName;

		private string _systemDiskDescription;

		private int? _dataDisk1Size;

		private string _dataDisk1Category;

		private string _dataDisk1SnapshotId;

		private string _dataDisk1DiskName;

		private string _dataDisk1Description;

		private string _dataDisk1Device;

		private bool? _dataDisk1DeleteWithInstance;

		private int? _dataDisk2Size;

		private string _dataDisk2Category;

		private string _dataDisk2SnapshotId;

		private string _dataDisk2DiskName;

		private string _dataDisk2Description;

		private string _dataDisk2Device;

		private bool? _dataDisk2DeleteWithInstance;

		private int? _dataDisk3Size;

		private string _dataDisk3Category;

		private string _dataDisk3SnapshotId;

		private string _dataDisk3DiskName;

		private string _dataDisk3Description;

		private string _dataDisk3Device;

		private bool? _dataDisk3DeleteWithInstance;

		private int? _dataDisk4Size;

		private string _dataDisk4Category;

		private string _dataDisk4SnapshotId;

		private string _dataDisk4DiskName;

		private string _dataDisk4Description;

		private string _dataDisk4Device;

		private bool? _dataDisk4DeleteWithInstance;

		private string _nodeControllerId;

		private string _description;

		private string _vSwitchId;

		private string _privateIpAddress;

		private string _ioOptimized;

		private string _ownerAccount;

		private bool? _useAdditionalService;

		private string _instanceChargeType;

		private int? _period;

		private string _tag1Key;

		private string _tag2Key;

		private string _tag3Key;

		private string _tag4Key;

		private string _tag5Key;

		private string _tag1Value;

		private string _tag2Value;

		private string _tag3Value;

		private string _tag4Value;

		private string _tag5Value;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ImageId
		{
			get
			{
				return _imageId;
			}
			set	
			{
				_imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return _instanceType;
			}
			set	
			{
				_instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return _securityGroupId;
			}
			set	
			{
				_securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return _instanceName;
			}
			set	
			{
				_instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public string InternetChargeType
		{
			get
			{
				return _internetChargeType;
			}
			set	
			{
				_internetChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
			}
		}

		public int? InternetMaxBandwidthIn
		{
			get
			{
				return _internetMaxBandwidthIn;
			}
			set	
			{
				_internetMaxBandwidthIn = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthIn", value.ToString());
			}
		}

		public int? InternetMaxBandwidthOut
		{
			get
			{
				return _internetMaxBandwidthOut;
			}
			set	
			{
				_internetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
			}
		}

		public string HostName
		{
			get
			{
				return _hostName;
			}
			set	
			{
				_hostName = value;
				DictionaryUtil.Add(QueryParameters, "HostName", value);
			}
		}

		public string Password
		{
			get
			{
				return _password;
			}
			set	
			{
				_password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return _zoneId;
			}
			set	
			{
				_zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return _clusterId;
			}
			set	
			{
				_clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return _clientToken;
			}
			set	
			{
				_clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string VlanId
		{
			get
			{
				return _vlanId;
			}
			set	
			{
				_vlanId = value;
				DictionaryUtil.Add(QueryParameters, "VlanId", value);
			}
		}

		public string InnerIpAddress
		{
			get
			{
				return _innerIpAddress;
			}
			set	
			{
				_innerIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "InnerIpAddress", value);
			}
		}

		public int? SystemDiskSize
		{
			get
			{
				return _systemDiskSize;
			}
			set	
			{
				_systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Size", value.ToString());
			}
		}

		public string SystemDiskCategory
		{
			get
			{
				return _systemDiskCategory;
			}
			set	
			{
				_systemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Category", value);
			}
		}

		public string SystemDiskDiskName
		{
			get
			{
				return _systemDiskDiskName;
			}
			set	
			{
				_systemDiskDiskName = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.DiskName", value);
			}
		}

		public string SystemDiskDescription
		{
			get
			{
				return _systemDiskDescription;
			}
			set	
			{
				_systemDiskDescription = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Description", value);
			}
		}

		public int? DataDisk1Size
		{
			get
			{
				return _dataDisk1Size;
			}
			set	
			{
				_dataDisk1Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.Size", value.ToString());
			}
		}

		public string DataDisk1Category
		{
			get
			{
				return _dataDisk1Category;
			}
			set	
			{
				_dataDisk1Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.Category", value);
			}
		}

		public string DataDisk1SnapshotId
		{
			get
			{
				return _dataDisk1SnapshotId;
			}
			set	
			{
				_dataDisk1SnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.SnapshotId", value);
			}
		}

		public string DataDisk1DiskName
		{
			get
			{
				return _dataDisk1DiskName;
			}
			set	
			{
				_dataDisk1DiskName = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.DiskName", value);
			}
		}

		public string DataDisk1Description
		{
			get
			{
				return _dataDisk1Description;
			}
			set	
			{
				_dataDisk1Description = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.Description", value);
			}
		}

		public string DataDisk1Device
		{
			get
			{
				return _dataDisk1Device;
			}
			set	
			{
				_dataDisk1Device = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.Device", value);
			}
		}

		public bool? DataDisk1DeleteWithInstance
		{
			get
			{
				return _dataDisk1DeleteWithInstance;
			}
			set	
			{
				_dataDisk1DeleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.DeleteWithInstance", value.ToString());
			}
		}

		public int? DataDisk2Size
		{
			get
			{
				return _dataDisk2Size;
			}
			set	
			{
				_dataDisk2Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.Size", value.ToString());
			}
		}

		public string DataDisk2Category
		{
			get
			{
				return _dataDisk2Category;
			}
			set	
			{
				_dataDisk2Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.Category", value);
			}
		}

		public string DataDisk2SnapshotId
		{
			get
			{
				return _dataDisk2SnapshotId;
			}
			set	
			{
				_dataDisk2SnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.SnapshotId", value);
			}
		}

		public string DataDisk2DiskName
		{
			get
			{
				return _dataDisk2DiskName;
			}
			set	
			{
				_dataDisk2DiskName = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.DiskName", value);
			}
		}

		public string DataDisk2Description
		{
			get
			{
				return _dataDisk2Description;
			}
			set	
			{
				_dataDisk2Description = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.Description", value);
			}
		}

		public string DataDisk2Device
		{
			get
			{
				return _dataDisk2Device;
			}
			set	
			{
				_dataDisk2Device = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.Device", value);
			}
		}

		public bool? DataDisk2DeleteWithInstance
		{
			get
			{
				return _dataDisk2DeleteWithInstance;
			}
			set	
			{
				_dataDisk2DeleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.DeleteWithInstance", value.ToString());
			}
		}

		public int? DataDisk3Size
		{
			get
			{
				return _dataDisk3Size;
			}
			set	
			{
				_dataDisk3Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.Size", value.ToString());
			}
		}

		public string DataDisk3Category
		{
			get
			{
				return _dataDisk3Category;
			}
			set	
			{
				_dataDisk3Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.Category", value);
			}
		}

		public string DataDisk3SnapshotId
		{
			get
			{
				return _dataDisk3SnapshotId;
			}
			set	
			{
				_dataDisk3SnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.SnapshotId", value);
			}
		}

		public string DataDisk3DiskName
		{
			get
			{
				return _dataDisk3DiskName;
			}
			set	
			{
				_dataDisk3DiskName = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.DiskName", value);
			}
		}

		public string DataDisk3Description
		{
			get
			{
				return _dataDisk3Description;
			}
			set	
			{
				_dataDisk3Description = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.Description", value);
			}
		}

		public string DataDisk3Device
		{
			get
			{
				return _dataDisk3Device;
			}
			set	
			{
				_dataDisk3Device = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.Device", value);
			}
		}

		public bool? DataDisk3DeleteWithInstance
		{
			get
			{
				return _dataDisk3DeleteWithInstance;
			}
			set	
			{
				_dataDisk3DeleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.DeleteWithInstance", value.ToString());
			}
		}

		public int? DataDisk4Size
		{
			get
			{
				return _dataDisk4Size;
			}
			set	
			{
				_dataDisk4Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.Size", value.ToString());
			}
		}

		public string DataDisk4Category
		{
			get
			{
				return _dataDisk4Category;
			}
			set	
			{
				_dataDisk4Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.Category", value);
			}
		}

		public string DataDisk4SnapshotId
		{
			get
			{
				return _dataDisk4SnapshotId;
			}
			set	
			{
				_dataDisk4SnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.SnapshotId", value);
			}
		}

		public string DataDisk4DiskName
		{
			get
			{
				return _dataDisk4DiskName;
			}
			set	
			{
				_dataDisk4DiskName = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.DiskName", value);
			}
		}

		public string DataDisk4Description
		{
			get
			{
				return _dataDisk4Description;
			}
			set	
			{
				_dataDisk4Description = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.Description", value);
			}
		}

		public string DataDisk4Device
		{
			get
			{
				return _dataDisk4Device;
			}
			set	
			{
				_dataDisk4Device = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.Device", value);
			}
		}

		public bool? DataDisk4DeleteWithInstance
		{
			get
			{
				return _dataDisk4DeleteWithInstance;
			}
			set	
			{
				_dataDisk4DeleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.DeleteWithInstance", value.ToString());
			}
		}

		public string NodeControllerId
		{
			get
			{
				return _nodeControllerId;
			}
			set	
			{
				_nodeControllerId = value;
				DictionaryUtil.Add(QueryParameters, "NodeControllerId", value);
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return _vSwitchId;
			}
			set	
			{
				_vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string PrivateIpAddress
		{
			get
			{
				return _privateIpAddress;
			}
			set	
			{
				_privateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
			}
		}

		public string IoOptimized
		{
			get
			{
				return _ioOptimized;
			}
			set	
			{
				_ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public bool? UseAdditionalService
		{
			get
			{
				return _useAdditionalService;
			}
			set	
			{
				_useAdditionalService = value;
				DictionaryUtil.Add(QueryParameters, "UseAdditionalService", value.ToString());
			}
		}

		public string InstanceChargeType
		{
			get
			{
				return _instanceChargeType;
			}
			set	
			{
				_instanceChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
			}
		}

		public int? Period
		{
			get
			{
				return _period;
			}
			set	
			{
				_period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string Tag1Key
		{
			get
			{
				return _tag1Key;
			}
			set	
			{
				_tag1Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Key", value);
			}
		}

		public string Tag2Key
		{
			get
			{
				return _tag2Key;
			}
			set	
			{
				_tag2Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Key", value);
			}
		}

		public string Tag3Key
		{
			get
			{
				return _tag3Key;
			}
			set	
			{
				_tag3Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Key", value);
			}
		}

		public string Tag4Key
		{
			get
			{
				return _tag4Key;
			}
			set	
			{
				_tag4Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Key", value);
			}
		}

		public string Tag5Key
		{
			get
			{
				return _tag5Key;
			}
			set	
			{
				_tag5Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Key", value);
			}
		}

		public string Tag1Value
		{
			get
			{
				return _tag1Value;
			}
			set	
			{
				_tag1Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Value", value);
			}
		}

		public string Tag2Value
		{
			get
			{
				return _tag2Value;
			}
			set	
			{
				_tag2Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Value", value);
			}
		}

		public string Tag3Value
		{
			get
			{
				return _tag3Value;
			}
			set	
			{
				_tag3Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Value", value);
			}
		}

		public string Tag4Value
		{
			get
			{
				return _tag4Value;
			}
			set	
			{
				_tag4Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Value", value);
			}
		}

		public string Tag5Value
		{
			get
			{
				return _tag5Value;
			}
			set	
			{
				_tag5Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Value", value);
			}
		}

        public override CreateInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}