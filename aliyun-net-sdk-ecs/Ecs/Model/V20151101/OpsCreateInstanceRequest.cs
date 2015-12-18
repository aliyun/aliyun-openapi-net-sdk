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
using Aliyun.Acs.Ecs.Transform.V20151101;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
    public class OpsCreateInstanceRequest : RpcAcsRequest<OpsCreateInstanceResponse>
    {
        public OpsCreateInstanceRequest()
            : base("Ecs", "2015-11-01", "OpsCreateInstance")
        {
        }

		private string regionNo;

		private string izNo;

		private string zoneNo;

		private string ncId;

		private string ecsInstanceName;

		private string hostname;

		private int? intranetRx;

		private int? intranetTx;

		private int? internetRx;

		private int? internetTx;

		private int? cores;

		private int? mem;

		private bool? async;

		private string groupId;

		private string imageId;

		private string vlanId;

		private string password;

		private string description;

		private bool? ioOptimized;

		private bool? computeIntensive;

		private bool? enableVmOsConfig;

		private string privateIpAddress;

		private string vswId;

		private string vpcPrivateIp;

		private string systemDiskCategory;

		private string systemDeviceName;

		private string systemDeviceDesc;

		private int? systemDiskSize;

		private int? systemIopsSize;

		private int? systemBpsSize;

		private int? dataDisk1Size;

		private string dataDisk1Category;

		private string dataDisk1SnapshotId;

		private string dataDisk1Name;

		private string dataDisk1Description;

		private string dataDisk1MountPoint;

		private bool? dataDisk1DeleteWithInstance;

		private int? dataDisk1IopsSize;

		private bool? dataDisk1DeleteAutoSnapshot;

		private bool? dataDisk1EnableAutoSnapshot;

		private int? dataDisk1BpsSize;

		private bool? dataDisk1Portable;

		private int? dataDisk2Size;

		private string dataDisk2Category;

		private string dataDisk2SnapshotId;

		private string dataDisk2Name;

		private string dataDisk2Description;

		private string dataDisk2MountPoint;

		private bool? dataDisk2DeleteWithInstance;

		private int? dataDisk2IopsSize;

		private bool? dataDisk2DeleteAutoSnapshot;

		private bool? dataDisk2EnableAutoSnapshot;

		private int? dataDisk2BpsSize;

		private bool? dataDisk2Portable;

		private int? dataDisk3Size;

		private string dataDisk3Category;

		private string dataDisk3SnapshotId;

		private string dataDisk3Name;

		private string dataDisk3Description;

		private string dataDisk3MountPoint;

		private bool? dataDisk3DeleteWithInstance;

		private int? dataDisk3IopsSize;

		private bool? dataDisk3DeleteAutoSnapshot;

		private bool? dataDisk3EnableAutoSnapshot;

		private int? dataDisk3BpsSize;

		private bool? dataDisk3Portable;

		private int? dataDisk4Size;

		private string dataDisk4Category;

		private string dataDisk4SnapshotId;

		private string dataDisk4Name;

		private string dataDisk4Description;

		private string dataDisk4MountPoint;

		private bool? dataDisk4DeleteWithInstance;

		private int? dataDisk4IopsSize;

		private bool? dataDisk4DeleteAutoSnapshot;

		private bool? dataDisk4EnableAutoSnapshot;

		private int? dataDisk4BpsSize;

		private bool? dataDisk4Portable;

		private long? resourceOwnerId;

		public string RegionNo
		{
			get
			{
				return regionNo;
			}
			set	
			{
				regionNo = value;
				DictionaryUtil.Add(QueryParameters, "RegionNo", value);
			}
		}

		public string IzNo
		{
			get
			{
				return izNo;
			}
			set	
			{
				izNo = value;
				DictionaryUtil.Add(QueryParameters, "IzNo", value);
			}
		}

		public string ZoneNo
		{
			get
			{
				return zoneNo;
			}
			set	
			{
				zoneNo = value;
				DictionaryUtil.Add(QueryParameters, "ZoneNo", value);
			}
		}

		public string NcId
		{
			get
			{
				return ncId;
			}
			set	
			{
				ncId = value;
				DictionaryUtil.Add(QueryParameters, "NcId", value);
			}
		}

		public string EcsInstanceName
		{
			get
			{
				return ecsInstanceName;
			}
			set	
			{
				ecsInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "EcsInstanceName", value);
			}
		}

		public string Hostname
		{
			get
			{
				return hostname;
			}
			set	
			{
				hostname = value;
				DictionaryUtil.Add(QueryParameters, "Hostname", value);
			}
		}

		public int? IntranetRx
		{
			get
			{
				return intranetRx;
			}
			set	
			{
				intranetRx = value;
				DictionaryUtil.Add(QueryParameters, "IntranetRx", value.ToString());
			}
		}

		public int? IntranetTx
		{
			get
			{
				return intranetTx;
			}
			set	
			{
				intranetTx = value;
				DictionaryUtil.Add(QueryParameters, "IntranetTx", value.ToString());
			}
		}

		public int? InternetRx
		{
			get
			{
				return internetRx;
			}
			set	
			{
				internetRx = value;
				DictionaryUtil.Add(QueryParameters, "InternetRx", value.ToString());
			}
		}

		public int? InternetTx
		{
			get
			{
				return internetTx;
			}
			set	
			{
				internetTx = value;
				DictionaryUtil.Add(QueryParameters, "InternetTx", value.ToString());
			}
		}

		public int? Cores
		{
			get
			{
				return cores;
			}
			set	
			{
				cores = value;
				DictionaryUtil.Add(QueryParameters, "Cores", value.ToString());
			}
		}

		public int? Mem
		{
			get
			{
				return mem;
			}
			set	
			{
				mem = value;
				DictionaryUtil.Add(QueryParameters, "Mem", value.ToString());
			}
		}

		public bool? Async
		{
			get
			{
				return async;
			}
			set	
			{
				async = value;
				DictionaryUtil.Add(QueryParameters, "Async", value.ToString());
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
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

		public bool? IoOptimized
		{
			get
			{
				return ioOptimized;
			}
			set	
			{
				ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value.ToString());
			}
		}

		public bool? ComputeIntensive
		{
			get
			{
				return computeIntensive;
			}
			set	
			{
				computeIntensive = value;
				DictionaryUtil.Add(QueryParameters, "ComputeIntensive", value.ToString());
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

		public string VswId
		{
			get
			{
				return vswId;
			}
			set	
			{
				vswId = value;
				DictionaryUtil.Add(QueryParameters, "VswId", value);
			}
		}

		public string VpcPrivateIp
		{
			get
			{
				return vpcPrivateIp;
			}
			set	
			{
				vpcPrivateIp = value;
				DictionaryUtil.Add(QueryParameters, "VpcPrivateIp", value);
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
				DictionaryUtil.Add(QueryParameters, "SystemDiskCategory", value);
			}
		}

		public string SystemDeviceName
		{
			get
			{
				return systemDeviceName;
			}
			set	
			{
				systemDeviceName = value;
				DictionaryUtil.Add(QueryParameters, "SystemDeviceName", value);
			}
		}

		public string SystemDeviceDesc
		{
			get
			{
				return systemDeviceDesc;
			}
			set	
			{
				systemDeviceDesc = value;
				DictionaryUtil.Add(QueryParameters, "SystemDeviceDesc", value);
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
				DictionaryUtil.Add(QueryParameters, "SystemDiskSize", value.ToString());
			}
		}

		public int? SystemIopsSize
		{
			get
			{
				return systemIopsSize;
			}
			set	
			{
				systemIopsSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemIopsSize", value.ToString());
			}
		}

		public int? SystemBpsSize
		{
			get
			{
				return systemBpsSize;
			}
			set	
			{
				systemBpsSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemBpsSize", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DataDisk1Size", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DataDisk1Category", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk1SnapshotId", value);
			}
		}

		public string DataDisk1Name
		{
			get
			{
				return dataDisk1Name;
			}
			set	
			{
				dataDisk1Name = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk1Name", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk1Description", value);
			}
		}

		public string DataDisk1MountPoint
		{
			get
			{
				return dataDisk1MountPoint;
			}
			set	
			{
				dataDisk1MountPoint = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk1MountPoint", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk1DeleteWithInstance", value.ToString());
			}
		}

		public int? DataDisk1IopsSize
		{
			get
			{
				return dataDisk1IopsSize;
			}
			set	
			{
				dataDisk1IopsSize = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk1IopsSize", value.ToString());
			}
		}

		public bool? DataDisk1DeleteAutoSnapshot
		{
			get
			{
				return dataDisk1DeleteAutoSnapshot;
			}
			set	
			{
				dataDisk1DeleteAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk1DeleteAutoSnapshot", value.ToString());
			}
		}

		public bool? DataDisk1EnableAutoSnapshot
		{
			get
			{
				return dataDisk1EnableAutoSnapshot;
			}
			set	
			{
				dataDisk1EnableAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk1EnableAutoSnapshot", value.ToString());
			}
		}

		public int? DataDisk1BpsSize
		{
			get
			{
				return dataDisk1BpsSize;
			}
			set	
			{
				dataDisk1BpsSize = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk1BpsSize", value.ToString());
			}
		}

		public bool? DataDisk1Portable
		{
			get
			{
				return dataDisk1Portable;
			}
			set	
			{
				dataDisk1Portable = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk1Portable", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DataDisk2Size", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DataDisk2Category", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk2SnapshotId", value);
			}
		}

		public string DataDisk2Name
		{
			get
			{
				return dataDisk2Name;
			}
			set	
			{
				dataDisk2Name = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk2Name", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk2Description", value);
			}
		}

		public string DataDisk2MountPoint
		{
			get
			{
				return dataDisk2MountPoint;
			}
			set	
			{
				dataDisk2MountPoint = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk2MountPoint", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk2DeleteWithInstance", value.ToString());
			}
		}

		public int? DataDisk2IopsSize
		{
			get
			{
				return dataDisk2IopsSize;
			}
			set	
			{
				dataDisk2IopsSize = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk2IopsSize", value.ToString());
			}
		}

		public bool? DataDisk2DeleteAutoSnapshot
		{
			get
			{
				return dataDisk2DeleteAutoSnapshot;
			}
			set	
			{
				dataDisk2DeleteAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk2DeleteAutoSnapshot", value.ToString());
			}
		}

		public bool? DataDisk2EnableAutoSnapshot
		{
			get
			{
				return dataDisk2EnableAutoSnapshot;
			}
			set	
			{
				dataDisk2EnableAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk2EnableAutoSnapshot", value.ToString());
			}
		}

		public int? DataDisk2BpsSize
		{
			get
			{
				return dataDisk2BpsSize;
			}
			set	
			{
				dataDisk2BpsSize = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk2BpsSize", value.ToString());
			}
		}

		public bool? DataDisk2Portable
		{
			get
			{
				return dataDisk2Portable;
			}
			set	
			{
				dataDisk2Portable = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk2Portable", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DataDisk3Size", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DataDisk3Category", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk3SnapshotId", value);
			}
		}

		public string DataDisk3Name
		{
			get
			{
				return dataDisk3Name;
			}
			set	
			{
				dataDisk3Name = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk3Name", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk3Description", value);
			}
		}

		public string DataDisk3MountPoint
		{
			get
			{
				return dataDisk3MountPoint;
			}
			set	
			{
				dataDisk3MountPoint = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk3MountPoint", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk3DeleteWithInstance", value.ToString());
			}
		}

		public int? DataDisk3IopsSize
		{
			get
			{
				return dataDisk3IopsSize;
			}
			set	
			{
				dataDisk3IopsSize = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk3IopsSize", value.ToString());
			}
		}

		public bool? DataDisk3DeleteAutoSnapshot
		{
			get
			{
				return dataDisk3DeleteAutoSnapshot;
			}
			set	
			{
				dataDisk3DeleteAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk3DeleteAutoSnapshot", value.ToString());
			}
		}

		public bool? DataDisk3EnableAutoSnapshot
		{
			get
			{
				return dataDisk3EnableAutoSnapshot;
			}
			set	
			{
				dataDisk3EnableAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk3EnableAutoSnapshot", value.ToString());
			}
		}

		public int? DataDisk3BpsSize
		{
			get
			{
				return dataDisk3BpsSize;
			}
			set	
			{
				dataDisk3BpsSize = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk3BpsSize", value.ToString());
			}
		}

		public bool? DataDisk3Portable
		{
			get
			{
				return dataDisk3Portable;
			}
			set	
			{
				dataDisk3Portable = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk3Portable", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DataDisk4Size", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DataDisk4Category", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk4SnapshotId", value);
			}
		}

		public string DataDisk4Name
		{
			get
			{
				return dataDisk4Name;
			}
			set	
			{
				dataDisk4Name = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk4Name", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk4Description", value);
			}
		}

		public string DataDisk4MountPoint
		{
			get
			{
				return dataDisk4MountPoint;
			}
			set	
			{
				dataDisk4MountPoint = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk4MountPoint", value);
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
				DictionaryUtil.Add(QueryParameters, "DataDisk4DeleteWithInstance", value.ToString());
			}
		}

		public int? DataDisk4IopsSize
		{
			get
			{
				return dataDisk4IopsSize;
			}
			set	
			{
				dataDisk4IopsSize = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk4IopsSize", value.ToString());
			}
		}

		public bool? DataDisk4DeleteAutoSnapshot
		{
			get
			{
				return dataDisk4DeleteAutoSnapshot;
			}
			set	
			{
				dataDisk4DeleteAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk4DeleteAutoSnapshot", value.ToString());
			}
		}

		public bool? DataDisk4EnableAutoSnapshot
		{
			get
			{
				return dataDisk4EnableAutoSnapshot;
			}
			set	
			{
				dataDisk4EnableAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk4EnableAutoSnapshot", value.ToString());
			}
		}

		public int? DataDisk4BpsSize
		{
			get
			{
				return dataDisk4BpsSize;
			}
			set	
			{
				dataDisk4BpsSize = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk4BpsSize", value.ToString());
			}
		}

		public bool? DataDisk4Portable
		{
			get
			{
				return dataDisk4Portable;
			}
			set	
			{
				dataDisk4Portable = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk4Portable", value.ToString());
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

        public override OpsCreateInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OpsCreateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}