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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeBandwidthPackagesResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeBandwidthPackages_BandwidthPackage> bandwidthPackages;

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

			private string status;

			private string creationTime;

			private string ipCount;

			private string regionId;

			private string instanceChargeType;

			private string bandwidthPackageId;

			private string description;

			private string bandwidth;

			private string natGatewayId;

			private string zoneId;

			private string internetChargeType;

			private string businessStatus;

			private string name;

			private string iSP;

			private List<DescribeBandwidthPackages_PublicIpAddresse> publicIpAddresses;

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

				private string ipAddress;

				private string allocationId;

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
			}
		}
	}
}
