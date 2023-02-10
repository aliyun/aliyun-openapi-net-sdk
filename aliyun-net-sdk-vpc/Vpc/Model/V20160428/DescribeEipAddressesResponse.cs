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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeEipAddressesResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeEipAddresses_EipAddress> eipAddresses;

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

		public List<DescribeEipAddresses_EipAddress> EipAddresses
		{
			get
			{
				return eipAddresses;
			}
			set	
			{
				eipAddresses = value;
			}
		}

		public class DescribeEipAddresses_EipAddress
		{

			private string reservationActiveTime;

			private string status;

			private string reservationOrderType;

			private string allocationTime;

			private string netmode;

			private string chargeType;

			private string descritpion;

			private string description;

			private string mode;

			private string segmentInstanceId;

			private string reservationInternetChargeType;

			private string bandwidthPackageId;

			private string ipAddress;

			private string bandwidth;

			private string reservationBandwidth;

			private string eipBandwidth;

			private string name;

			private string privateIpAddress;

			private string instanceRegionId;

			private bool? deletionProtection;

			private string instanceId;

			private bool? secondLimited;

			private string instanceType;

			private string hDMonitorStatus;

			private string regionId;

			private string bandwidthPackageBandwidth;

			private int? serviceManaged;

			private string expiredTime;

			private string resourceGroupId;

			private string allocationId;

			private string internetChargeType;

			private string businessStatus;

			private string bandwidthPackageType;

			private string hasReservationData;

			private string iSP;

			private string publicIpAddressPoolId;

			private string vpcId;

			private string zone;

			private List<DescribeEipAddresses_LockReason> operationLocks;

			private List<DescribeEipAddresses_Tag> tags;

			private List<string> availableRegions;

			private List<string> securityProtectionTypes;

			public string ReservationActiveTime
			{
				get
				{
					return reservationActiveTime;
				}
				set	
				{
					reservationActiveTime = value;
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

			public string ReservationOrderType
			{
				get
				{
					return reservationOrderType;
				}
				set	
				{
					reservationOrderType = value;
				}
			}

			public string AllocationTime
			{
				get
				{
					return allocationTime;
				}
				set	
				{
					allocationTime = value;
				}
			}

			public string Netmode
			{
				get
				{
					return netmode;
				}
				set	
				{
					netmode = value;
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

			public string Descritpion
			{
				get
				{
					return descritpion;
				}
				set	
				{
					descritpion = value;
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

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			public string SegmentInstanceId
			{
				get
				{
					return segmentInstanceId;
				}
				set	
				{
					segmentInstanceId = value;
				}
			}

			public string ReservationInternetChargeType
			{
				get
				{
					return reservationInternetChargeType;
				}
				set	
				{
					reservationInternetChargeType = value;
				}
			}

			public string BandwidthPackageId
			{
				get
				{
					return bandwidthPackageId;
				}
				set	
				{
					bandwidthPackageId = value;
				}
			}

			public string IpAddress
			{
				get
				{
					return ipAddress;
				}
				set	
				{
					ipAddress = value;
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

			public string ReservationBandwidth
			{
				get
				{
					return reservationBandwidth;
				}
				set	
				{
					reservationBandwidth = value;
				}
			}

			public string EipBandwidth
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

			public string InstanceRegionId
			{
				get
				{
					return instanceRegionId;
				}
				set	
				{
					instanceRegionId = value;
				}
			}

			public bool? DeletionProtection
			{
				get
				{
					return deletionProtection;
				}
				set	
				{
					deletionProtection = value;
				}
			}

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

			public bool? SecondLimited
			{
				get
				{
					return secondLimited;
				}
				set	
				{
					secondLimited = value;
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

			public string HDMonitorStatus
			{
				get
				{
					return hDMonitorStatus;
				}
				set	
				{
					hDMonitorStatus = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string BandwidthPackageBandwidth
			{
				get
				{
					return bandwidthPackageBandwidth;
				}
				set	
				{
					bandwidthPackageBandwidth = value;
				}
			}

			public int? ServiceManaged
			{
				get
				{
					return serviceManaged;
				}
				set	
				{
					serviceManaged = value;
				}
			}

			public string ExpiredTime
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

			public string AllocationId
			{
				get
				{
					return allocationId;
				}
				set	
				{
					allocationId = value;
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

			public string BandwidthPackageType
			{
				get
				{
					return bandwidthPackageType;
				}
				set	
				{
					bandwidthPackageType = value;
				}
			}

			public string HasReservationData
			{
				get
				{
					return hasReservationData;
				}
				set	
				{
					hasReservationData = value;
				}
			}

			public string ISP
			{
				get
				{
					return iSP;
				}
				set	
				{
					iSP = value;
				}
			}

			public string PublicIpAddressPoolId
			{
				get
				{
					return publicIpAddressPoolId;
				}
				set	
				{
					publicIpAddressPoolId = value;
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

			public string Zone
			{
				get
				{
					return zone;
				}
				set	
				{
					zone = value;
				}
			}

			public List<DescribeEipAddresses_LockReason> OperationLocks
			{
				get
				{
					return operationLocks;
				}
				set	
				{
					operationLocks = value;
				}
			}

			public List<DescribeEipAddresses_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> AvailableRegions
			{
				get
				{
					return availableRegions;
				}
				set	
				{
					availableRegions = value;
				}
			}

			public List<string> SecurityProtectionTypes
			{
				get
				{
					return securityProtectionTypes;
				}
				set	
				{
					securityProtectionTypes = value;
				}
			}

			public class DescribeEipAddresses_LockReason
			{

				private string lockReason;

				public string LockReason
				{
					get
					{
						return lockReason;
					}
					set	
					{
						lockReason = value;
					}
				}
			}

			public class DescribeEipAddresses_Tag
			{

				private string key;

				private string _value;

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

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
