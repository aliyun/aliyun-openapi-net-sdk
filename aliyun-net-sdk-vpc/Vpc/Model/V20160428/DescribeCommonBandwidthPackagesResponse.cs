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
	public class DescribeCommonBandwidthPackagesResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeCommonBandwidthPackages_CommonBandwidthPackage> commonBandwidthPackages;

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

		public List<DescribeCommonBandwidthPackages_CommonBandwidthPackage> CommonBandwidthPackages
		{
			get
			{
				return commonBandwidthPackages;
			}
			set	
			{
				commonBandwidthPackages = value;
			}
		}

		public class DescribeCommonBandwidthPackages_CommonBandwidthPackage
		{

			private string reservationActiveTime;

			private string status;

			private string creationTime;

			private string reservationOrderType;

			private bool? deletionProtection;

			private string reservationInternetChargeType;

			private int? ratio;

			private string instanceChargeType;

			private string regionId;

			private string bandwidthPackageId;

			private int? serviceManaged;

			private string bandwidth;

			private string description;

			private string expiredTime;

			private string reservationBandwidth;

			private string resourceGroupId;

			private string internetChargeType;

			private string businessStatus;

			private string name;

			private string iSP;

			private string hasReservationData;

			private List<DescribeCommonBandwidthPackages_PublicIpAddresse> publicIpAddresses;

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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
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

			public int? Ratio
			{
				get
				{
					return ratio;
				}
				set	
				{
					ratio = value;
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

			public List<DescribeCommonBandwidthPackages_PublicIpAddresse> PublicIpAddresses
			{
				get
				{
					return publicIpAddresses;
				}
				set	
				{
					publicIpAddresses = value;
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

			public class DescribeCommonBandwidthPackages_PublicIpAddresse
			{

				private string ipAddress;

				private string allocationId;

				private string bandwidthPackageIpRelationStatus;

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

				public string BandwidthPackageIpRelationStatus
				{
					get
					{
						return bandwidthPackageIpRelationStatus;
					}
					set	
					{
						bandwidthPackageIpRelationStatus = value;
					}
				}
			}
		}
	}
}
