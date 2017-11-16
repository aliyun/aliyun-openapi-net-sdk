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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeBandwidthPackagesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeBandwidthPackages_BandwidthPackage> bandwidthPackages;

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

		public List<DescribeBandwidthPackages_BandwidthPackage> BandwidthPackages
		{
			get
			{
				return bandwidthPackages;
			}
			set	
			{
				bandwidthPackages = value;
			}
		}

		public class DescribeBandwidthPackages_BandwidthPackage
		{

			private string bandwidthPackageId;

			private string regionId;

			private string name;

			private string description;

			private string zoneId;

			private string natGatewayId;

			private string bandwidth;

			private string instanceChargeType;

			private string internetChargeType;

			private string businessStatus;

			private string ipCount;

			private string creationTime;

			private string status;

			private string iSP;

			private List<DescribeBandwidthPackages_PublicIpAddresse> publicIpAddresses;

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

			public string NatGatewayId
			{
				get
				{
					return natGatewayId;
				}
				set	
				{
					natGatewayId = value;
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

			public string IpCount
			{
				get
				{
					return ipCount;
				}
				set	
				{
					ipCount = value;
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

			public List<DescribeBandwidthPackages_PublicIpAddresse> PublicIpAddresses
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

			public class DescribeBandwidthPackages_PublicIpAddresse
			{

				private string allocationId;

				private string ipAddress;

				private string usingStatus;

				private bool? apAccessEnabled;

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

				public string UsingStatus
				{
					get
					{
						return usingStatus;
					}
					set	
					{
						usingStatus = value;
					}
				}

				public bool? ApAccessEnabled
				{
					get
					{
						return apAccessEnabled;
					}
					set	
					{
						apAccessEnabled = value;
					}
				}
			}
		}
	}
}