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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
	public class OpsDescribeInstancesResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNo;

		private int? pageSize;

		private List<Instance> instances;

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

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
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

		public List<Instance> Instances
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

		public class Instance{

			private string regionNo;

			private string izNo;

			private string zoneNo;

			private string ecsInstanceId;

			private string aliUid;

			private string bid;

			private string hostname;

			private string ecsInstanceName;

			private string description;

			private string status;

			private BusinessStatusEnum? businessStatus;

			private string houyiStatus;

			private string privateIpAddress;

			private string publicIpAddress;

			private string imageId;

			private string imageName;

			private int? cores;

			private int? mem;

			private int? disk;

			private int? intranetRx;

			private int? intranetTx;

			private int? internetRx;

			private int? internetTx;

			private string securityControl;

			private string systemDeviceCategory;

			private string createdTime;

			private string vpcId;

			private string vswId;

			private string natIp;

			private string eip;

			private string eipId;

			private int? eipBandwidth;

			private string netWorkType;

			private bool? networkValidation;

			private bool? ioOptimized;

			private bool? mountAvailable;

			private string vlanId;

			private string ncId;

			private string ncIp;

			private string rackId;

			private string vncHost;

			private int? vncPort;

			private string vncPassword;

			private string platform;

			private List<Disk> disks;

			private List<string> groupIds;

			public string RegionNo
			{
				get
				{
					return regionNo;
				}
				set	
				{
					regionNo = value;
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
				}
			}

			public string EcsInstanceId
			{
				get
				{
					return ecsInstanceId;
				}
				set	
				{
					ecsInstanceId = value;
				}
			}

			public string AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
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

			public BusinessStatusEnum? BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			public string HouyiStatus
			{
				get
				{
					return houyiStatus;
				}
				set	
				{
					houyiStatus = value;
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

			public string PublicIpAddress
			{
				get
				{
					return publicIpAddress;
				}
				set	
				{
					publicIpAddress = value;
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

			public string ImageName
			{
				get
				{
					return imageName;
				}
				set	
				{
					imageName = value;
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
				}
			}

			public int? Disk
			{
				get
				{
					return disk;
				}
				set	
				{
					disk = value;
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
				}
			}

			public string SecurityControl
			{
				get
				{
					return securityControl;
				}
				set	
				{
					securityControl = value;
				}
			}

			public string SystemDeviceCategory
			{
				get
				{
					return systemDeviceCategory;
				}
				set	
				{
					systemDeviceCategory = value;
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

			public string VswId
			{
				get
				{
					return vswId;
				}
				set	
				{
					vswId = value;
				}
			}

			public string NatIp
			{
				get
				{
					return natIp;
				}
				set	
				{
					natIp = value;
				}
			}

			public string Eip
			{
				get
				{
					return eip;
				}
				set	
				{
					eip = value;
				}
			}

			public string EipId
			{
				get
				{
					return eipId;
				}
				set	
				{
					eipId = value;
				}
			}

			public int? EipBandwidth
			{
				get
				{
					return eipBandwidth;
				}
				set	
				{
					eipBandwidth = value;
				}
			}

			public string NetWorkType
			{
				get
				{
					return netWorkType;
				}
				set	
				{
					netWorkType = value;
				}
			}

			public bool? NetworkValidation
			{
				get
				{
					return networkValidation;
				}
				set	
				{
					networkValidation = value;
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
				}
			}

			public bool? MountAvailable
			{
				get
				{
					return mountAvailable;
				}
				set	
				{
					mountAvailable = value;
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
				}
			}

			public string NcIp
			{
				get
				{
					return ncIp;
				}
				set	
				{
					ncIp = value;
				}
			}

			public string RackId
			{
				get
				{
					return rackId;
				}
				set	
				{
					rackId = value;
				}
			}

			public string VncHost
			{
				get
				{
					return vncHost;
				}
				set	
				{
					vncHost = value;
				}
			}

			public int? VncPort
			{
				get
				{
					return vncPort;
				}
				set	
				{
					vncPort = value;
				}
			}

			public string VncPassword
			{
				get
				{
					return vncPassword;
				}
				set	
				{
					vncPassword = value;
				}
			}

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}

			public List<Disk> Disks
			{
				get
				{
					return disks;
				}
				set	
				{
					disks = value;
				}
			}

			public List<string> GroupIds
			{
				get
				{
					return groupIds;
				}
				set	
				{
					groupIds = value;
				}
			}

			public enum BusinessStatusEnum {
			
					Created,
					Transfering,
					Updating,
					Normal,
					Creating,
					ChangeOSFailure,
					Expired,
					Resetting,
					Rollbacking,
					Starting,
					Locked,
					ChangeOS,
			}

			public class Disk{

				private long? id;

				private long? aliUid;

				private string bid;

				private string diskId;

				private string houyiDiskId;

				private string diskType;

				private string diskCategory;

				private string status;

				private string regionNo;

				private string izNo;

				private string zoneNo;

				private string diskName;

				private string diskDesc;

				private int? diskSize;

				private bool? active;

				private bool? bootable;

				private bool? portable;

				private string imageId;

				private string snapshotId;

				private string ecsInstanceId;

				private string mountPoint;

				private bool? deleteWithInstance;

				private bool? deleteAutoSnapshot;

				private bool? enableAutoSnapshot;

				private string businessStatus;

				private int? iopsSize;

				private string productCode;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public long? AliUid
				{
					get
					{
						return aliUid;
					}
					set	
					{
						aliUid = value;
					}
				}

				public string Bid
				{
					get
					{
						return bid;
					}
					set	
					{
						bid = value;
					}
				}

				public string DiskId
				{
					get
					{
						return diskId;
					}
					set	
					{
						diskId = value;
					}
				}

				public string HouyiDiskId
				{
					get
					{
						return houyiDiskId;
					}
					set	
					{
						houyiDiskId = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

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

				public string RegionNo
				{
					get
					{
						return regionNo;
					}
					set	
					{
						regionNo = value;
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

				public string DiskDesc
				{
					get
					{
						return diskDesc;
					}
					set	
					{
						diskDesc = value;
					}
				}

				public int? DiskSize
				{
					get
					{
						return diskSize;
					}
					set	
					{
						diskSize = value;
					}
				}

				public bool? Active
				{
					get
					{
						return active;
					}
					set	
					{
						active = value;
					}
				}

				public bool? Bootable
				{
					get
					{
						return bootable;
					}
					set	
					{
						bootable = value;
					}
				}

				public bool? Portable
				{
					get
					{
						return portable;
					}
					set	
					{
						portable = value;
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

				public string EcsInstanceId
				{
					get
					{
						return ecsInstanceId;
					}
					set	
					{
						ecsInstanceId = value;
					}
				}

				public string MountPoint
				{
					get
					{
						return mountPoint;
					}
					set	
					{
						mountPoint = value;
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

				public bool? DeleteAutoSnapshot
				{
					get
					{
						return deleteAutoSnapshot;
					}
					set	
					{
						deleteAutoSnapshot = value;
					}
				}

				public bool? EnableAutoSnapshot
				{
					get
					{
						return enableAutoSnapshot;
					}
					set	
					{
						enableAutoSnapshot = value;
					}
				}

				public string BusinessStatus
				{
					get
					{
						return businessStatus;
					}
					set	
					{
						businessStatus = value;
					}
				}

				public int? IopsSize
				{
					get
					{
						return iopsSize;
					}
					set	
					{
						iopsSize = value;
					}
				}

				public string ProductCode
				{
					get
					{
						return productCode;
					}
					set	
					{
						productCode = value;
					}
				}
			}
		}
	}
}