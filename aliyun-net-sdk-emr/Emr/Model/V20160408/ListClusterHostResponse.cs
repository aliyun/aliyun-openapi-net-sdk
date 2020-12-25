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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListClusterHostResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<ListClusterHost_Host> hostList;

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<ListClusterHost_Host> HostList
		{
			get
			{
				return hostList;
			}
			set	
			{
				hostList = value;
			}
		}

		public class ListClusterHost_Host
		{

			private string hostName;

			private string publicIp;

			private string privateIp;

			private string role;

			private string zoneId;

			private string instanceType;

			private int? cpu;

			private int? memory;

			private string status;

			private string instanceStatus;

			private string type;

			private string hostInstanceId;

			private string serialNumber;

			private string chargeType;

			private long? expiredTime;

			private string hostGroupId;

			private string createTime;

			private string emrExpiredTime;

			private bool? supportIpV6;

			private List<ListClusterHost_Disk> diskList;

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

			public string PublicIp
			{
				get
				{
					return publicIp;
				}
				set	
				{
					publicIp = value;
				}
			}

			public string PrivateIp
			{
				get
				{
					return privateIp;
				}
				set	
				{
					privateIp = value;
				}
			}

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
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

			public int? Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
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

			public string InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string HostInstanceId
			{
				get
				{
					return hostInstanceId;
				}
				set	
				{
					hostInstanceId = value;
				}
			}

			public string SerialNumber
			{
				get
				{
					return serialNumber;
				}
				set	
				{
					serialNumber = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public long? ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			public string HostGroupId
			{
				get
				{
					return hostGroupId;
				}
				set	
				{
					hostGroupId = value;
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

			public string EmrExpiredTime
			{
				get
				{
					return emrExpiredTime;
				}
				set	
				{
					emrExpiredTime = value;
				}
			}

			public bool? SupportIpV6
			{
				get
				{
					return supportIpV6;
				}
				set	
				{
					supportIpV6 = value;
				}
			}

			public List<ListClusterHost_Disk> DiskList
			{
				get
				{
					return diskList;
				}
				set	
				{
					diskList = value;
				}
			}

			public class ListClusterHost_Disk
			{

				private string diskId;

				private string type;

				private string device;

				private string diskType;

				private int? diskSize;

				private string blockMountPoint;

				private string diskMountPoint;

				private string _event;

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

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
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

				public string BlockMountPoint
				{
					get
					{
						return blockMountPoint;
					}
					set	
					{
						blockMountPoint = value;
					}
				}

				public string DiskMountPoint
				{
					get
					{
						return diskMountPoint;
					}
					set	
					{
						diskMountPoint = value;
					}
				}

				public string _Event
				{
					get
					{
						return _event;
					}
					set	
					{
						_event = value;
					}
				}
			}
		}
	}
}
