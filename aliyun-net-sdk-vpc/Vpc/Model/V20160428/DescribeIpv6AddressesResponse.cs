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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeIpv6AddressesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeIpv6Addresses_Ipv6Address> ipv6Addresses;

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

		public List<DescribeIpv6Addresses_Ipv6Address> Ipv6Addresses
		{
			get
			{
				return ipv6Addresses;
			}
			set	
			{
				ipv6Addresses = value;
			}
		}

		public class DescribeIpv6Addresses_Ipv6Address
		{

			private string ipv6AddressId;

			private string ipv6AddressName;

			private string vSwitchId;

			private string vpcId;

			private string ipv6GatewayId;

			private string ipv6Address;

			private string associatedInstanceId;

			private string associatedInstanceType;

			private string status;

			private string networkType;

			private int? realBandwidth;

			private string allocationTime;

			private string ipv6Isp;

			private DescribeIpv6Addresses_Ipv6InternetBandwidth ipv6InternetBandwidth;

			public string Ipv6AddressId
			{
				get
				{
					return ipv6AddressId;
				}
				set	
				{
					ipv6AddressId = value;
				}
			}

			public string Ipv6AddressName
			{
				get
				{
					return ipv6AddressName;
				}
				set	
				{
					ipv6AddressName = value;
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

			public string Ipv6GatewayId
			{
				get
				{
					return ipv6GatewayId;
				}
				set	
				{
					ipv6GatewayId = value;
				}
			}

			public string Ipv6Address
			{
				get
				{
					return ipv6Address;
				}
				set	
				{
					ipv6Address = value;
				}
			}

			public string AssociatedInstanceId
			{
				get
				{
					return associatedInstanceId;
				}
				set	
				{
					associatedInstanceId = value;
				}
			}

			public string AssociatedInstanceType
			{
				get
				{
					return associatedInstanceType;
				}
				set	
				{
					associatedInstanceType = value;
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

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public int? RealBandwidth
			{
				get
				{
					return realBandwidth;
				}
				set	
				{
					realBandwidth = value;
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

			public string Ipv6Isp
			{
				get
				{
					return ipv6Isp;
				}
				set	
				{
					ipv6Isp = value;
				}
			}

			public DescribeIpv6Addresses_Ipv6InternetBandwidth Ipv6InternetBandwidth
			{
				get
				{
					return ipv6InternetBandwidth;
				}
				set	
				{
					ipv6InternetBandwidth = value;
				}
			}

			public class DescribeIpv6Addresses_Ipv6InternetBandwidth
			{

				private int? bandwidth;

				private string instanceChargeType;

				private string internetChargeType;

				private string businessStatus;

				private string ipv6InternetBandwidthId;

				public int? Bandwidth
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

				public string Ipv6InternetBandwidthId
				{
					get
					{
						return ipv6InternetBandwidthId;
					}
					set	
					{
						ipv6InternetBandwidthId = value;
					}
				}
			}
		}
	}
}
