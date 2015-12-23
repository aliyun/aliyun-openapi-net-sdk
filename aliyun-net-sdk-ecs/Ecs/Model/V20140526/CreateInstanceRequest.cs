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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class CreateInstanceRequest : RpcAcsRequest<CreateInstanceResponse>
    {
        public CreateInstanceRequest()
            : base("Ecs", "2014-05-26", "CreateInstance")
        {
        }

	private long? ownerId;

	private string resourceOwnerAccount;

	private long? resourceOwnerId;

	private string imageId;

	private string instanceType;

	private string securityGroupId;

	private string instanceName;

	private string internetChargeType;

	private int? internetMaxBandwidthIn;

	private int? internetMaxBandwidthOut;

	private string hostName;

	private string password;

	private string zoneId;

	private string clusterId;

	private string clientToken;

	private string vlanId;

	private string innerIpAddress;

	private string systemDiskCategory;

	private string systemDiskDiskName;

	private string systemDiskDescription;

	private int? dataDisk1Size;

	private string dataDisk1Category;

	private string dataDisk1SnapshotId;

	private string dataDisk1DiskName;

	private string dataDisk1Description;

	private string dataDisk1Device;

	private bool? dataDisk1DeleteWithInstance;

	private int? dataDisk2Size;

	private string dataDisk2Category;

	private string dataDisk2SnapshotId;

	private string dataDisk2DiskName;

	private string dataDisk2Description;

	private string dataDisk2Device;

	private bool? dataDisk2DeleteWithInstance;

	private int? dataDisk3Size;

	private string dataDisk3Category;

	private string dataDisk3SnapshotId;

	private string dataDisk3DiskName;

	private string dataDisk3Description;

	private string dataDisk3Device;

	private bool? dataDisk3DeleteWithInstance;

	private int? dataDisk4Size;

	private string dataDisk4Category;

	private string dataDisk4SnapshotId;

	private string dataDisk4DiskName;

	private string dataDisk4Description;

	private string dataDisk4Device;

	private bool? dataDisk4DeleteWithInstance;

	private string nodeControllerId;

	private string description;

	private string vSwitchId;

	private string privateIpAddress;

	private string ioOptimized;

	private string ownerAccount;

	private bool? useAdditionalService;

	private string instanceChargeType;

	private int? period;

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

	public string ClusterId
	{
		get
		{
			return clusterId;
		}
		set	
		{
			clusterId = value;
			DictionaryUtil.Add(QueryParameters, "ClusterId", value);
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

	public string VlanId
	{
		get
		{
			return vlanId;
		}
		set	
		{
			vlanId = value;
			DictionaryUtil.Add(QueryParameters, "VlanId", value);
		}
	}

	public string InnerIpAddress
	{
		get
		{
			return innerIpAddress;
		}
		set	
		{
			innerIpAddress = value;
			DictionaryUtil.Add(QueryParameters, "InnerIpAddress", value);
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

	public string DataDisk1DiskName
	{
		get
		{
			return dataDisk1DiskName;
		}
		set	
		{
			dataDisk1DiskName = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.1.DiskName", value);
		}
	}

	public string DataDisk1Description
	{
		get
		{
			return dataDisk1Description;
		}
		set	
		{
			dataDisk1Description = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.1.Description", value);
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

	public bool? DataDisk1DeleteWithInstance
	{
		get
		{
			return dataDisk1DeleteWithInstance;
		}
		set	
		{
			dataDisk1DeleteWithInstance = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.1.DeleteWithInstance", value.ToString());
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

	public string DataDisk2DiskName
	{
		get
		{
			return dataDisk2DiskName;
		}
		set	
		{
			dataDisk2DiskName = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.2.DiskName", value);
		}
	}

	public string DataDisk2Description
	{
		get
		{
			return dataDisk2Description;
		}
		set	
		{
			dataDisk2Description = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.2.Description", value);
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

	public bool? DataDisk2DeleteWithInstance
	{
		get
		{
			return dataDisk2DeleteWithInstance;
		}
		set	
		{
			dataDisk2DeleteWithInstance = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.2.DeleteWithInstance", value.ToString());
		}
	}

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

	public string DataDisk3DiskName
	{
		get
		{
			return dataDisk3DiskName;
		}
		set	
		{
			dataDisk3DiskName = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.3.DiskName", value);
		}
	}

	public string DataDisk3Description
	{
		get
		{
			return dataDisk3Description;
		}
		set	
		{
			dataDisk3Description = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.3.Description", value);
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

	public bool? DataDisk3DeleteWithInstance
	{
		get
		{
			return dataDisk3DeleteWithInstance;
		}
		set	
		{
			dataDisk3DeleteWithInstance = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.3.DeleteWithInstance", value.ToString());
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

	public string DataDisk4DiskName
	{
		get
		{
			return dataDisk4DiskName;
		}
		set	
		{
			dataDisk4DiskName = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.4.DiskName", value);
		}
	}

	public string DataDisk4Description
	{
		get
		{
			return dataDisk4Description;
		}
		set	
		{
			dataDisk4Description = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.4.Description", value);
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

	public bool? DataDisk4DeleteWithInstance
	{
		get
		{
			return dataDisk4DeleteWithInstance;
		}
		set	
		{
			dataDisk4DeleteWithInstance = value;
			DictionaryUtil.Add(QueryParameters, "DataDisk.4.DeleteWithInstance", value.ToString());
		}
	}

	public string NodeControllerId
	{
		get
		{
			return nodeControllerId;
		}
		set	
		{
			nodeControllerId = value;
			DictionaryUtil.Add(QueryParameters, "NodeControllerId", value);
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

	public string PrivateIpAddress
	{
		get
		{
			return privateIpAddress;
		}
		set	
		{
			privateIpAddress = value;
			DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
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

	public bool? UseAdditionalService
	{
		get
		{
			return useAdditionalService;
		}
		set	
		{
			useAdditionalService = value;
			DictionaryUtil.Add(QueryParameters, "UseAdditionalService", value.ToString());
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

        public override CreateInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}