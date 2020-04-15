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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSmartAccessGatewaysResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeSmartAccessGateways_SmartAccessGateway> smartAccessGateways;

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

		public List<DescribeSmartAccessGateways_SmartAccessGateway> SmartAccessGateways
		{
			get
			{
				return smartAccessGateways;
			}
			set	
			{
				smartAccessGateways = value;
			}
		}

		public class DescribeSmartAccessGateways_SmartAccessGateway
		{

			private string smartAGId;

			private string name;

			private string city;

			private string maxBandwidth;

			private string status;

			private string cidrBlock;

			private string associatedCcnId;

			private string associatedCcnName;

			private string description;

			private long? createTime;

			private long? endTime;

			private string softwareVersion;

			private string hardwareVersion;

			private string serialNumber;

			private int? securityLockThreshold;

			private string aclIds;

			private long? dataPlan;

			private int? userCount;

			private string routingStrategy;

			private int? upBandwidthWan;

			private int? upBandwidth4G;

			private string qosIds;

			private string backupSoftwareVersion;

			private long? smartAGUid;

			private string backupStatus;

			private string resourceGroupId;

			private string vpnStatus;

			private string ipsecStatus;

			private List<DescribeSmartAccessGateways_Link> links;

			public string SmartAGId
			{
				get
				{
					return smartAGId;
				}
				set	
				{
					smartAGId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string City
			{
				get
				{
					return city;
				}
				set	
				{
					city = value;
				}
			}

			public string MaxBandwidth
			{
				get
				{
					return maxBandwidth;
				}
				set	
				{
					maxBandwidth = value;
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

			public string CidrBlock
			{
				get
				{
					return cidrBlock;
				}
				set	
				{
					cidrBlock = value;
				}
			}

			public string AssociatedCcnId
			{
				get
				{
					return associatedCcnId;
				}
				set	
				{
					associatedCcnId = value;
				}
			}

			public string AssociatedCcnName
			{
				get
				{
					return associatedCcnName;
				}
				set	
				{
					associatedCcnName = value;
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

			public long? CreateTime
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

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string SoftwareVersion
			{
				get
				{
					return softwareVersion;
				}
				set	
				{
					softwareVersion = value;
				}
			}

			public string HardwareVersion
			{
				get
				{
					return hardwareVersion;
				}
				set	
				{
					hardwareVersion = value;
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

			public int? SecurityLockThreshold
			{
				get
				{
					return securityLockThreshold;
				}
				set	
				{
					securityLockThreshold = value;
				}
			}

			public string AclIds
			{
				get
				{
					return aclIds;
				}
				set	
				{
					aclIds = value;
				}
			}

			public long? DataPlan
			{
				get
				{
					return dataPlan;
				}
				set	
				{
					dataPlan = value;
				}
			}

			public int? UserCount
			{
				get
				{
					return userCount;
				}
				set	
				{
					userCount = value;
				}
			}

			public string RoutingStrategy
			{
				get
				{
					return routingStrategy;
				}
				set	
				{
					routingStrategy = value;
				}
			}

			public int? UpBandwidthWan
			{
				get
				{
					return upBandwidthWan;
				}
				set	
				{
					upBandwidthWan = value;
				}
			}

			public int? UpBandwidth4G
			{
				get
				{
					return upBandwidth4G;
				}
				set	
				{
					upBandwidth4G = value;
				}
			}

			public string QosIds
			{
				get
				{
					return qosIds;
				}
				set	
				{
					qosIds = value;
				}
			}

			public string BackupSoftwareVersion
			{
				get
				{
					return backupSoftwareVersion;
				}
				set	
				{
					backupSoftwareVersion = value;
				}
			}

			public long? SmartAGUid
			{
				get
				{
					return smartAGUid;
				}
				set	
				{
					smartAGUid = value;
				}
			}

			public string BackupStatus
			{
				get
				{
					return backupStatus;
				}
				set	
				{
					backupStatus = value;
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

			public string VpnStatus
			{
				get
				{
					return vpnStatus;
				}
				set	
				{
					vpnStatus = value;
				}
			}

			public string IpsecStatus
			{
				get
				{
					return ipsecStatus;
				}
				set	
				{
					ipsecStatus = value;
				}
			}

			public List<DescribeSmartAccessGateways_Link> Links
			{
				get
				{
					return links;
				}
				set	
				{
					links = value;
				}
			}

			public class DescribeSmartAccessGateways_Link
			{

				private string instanceId;

				private string type;

				private string status;

				private long? endTime;

				private string bandwidth;

				private string relateInstanceId;

				private string relateInstanceRegionId;

				private string commodityType;

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
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

				public long? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public string Bandwidth
				{
					get
					{
						return bandwidth;
					}
					set	
					{
						bandwidth = value;
					}
				}

				public string RelateInstanceId
				{
					get
					{
						return relateInstanceId;
					}
					set	
					{
						relateInstanceId = value;
					}
				}

				public string RelateInstanceRegionId
				{
					get
					{
						return relateInstanceRegionId;
					}
					set	
					{
						relateInstanceRegionId = value;
					}
				}

				public string CommodityType
				{
					get
					{
						return commodityType;
					}
					set	
					{
						commodityType = value;
					}
				}
			}
		}
	}
}
