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
	public class DescribeNatGatewaysResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeNatGateways_NatGateway> natGateways;

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

		public List<DescribeNatGateways_NatGateway> NatGateways
		{
			get
			{
				return natGateways;
			}
			set	
			{
				natGateways = value;
			}
		}

		public class DescribeNatGateways_NatGateway
		{

			private string natGatewayId;

			private string regionId;

			private string name;

			private string description;

			private string vpcId;

			private string spec;

			private string instanceChargeType;

			private string expiredTime;

			private bool? autoPay;

			private string businessStatus;

			private string creationTime;

			private string status;

			private string natType;

			private string internetChargeType;

			private string resourceGroupId;

			private bool? deletionProtection;

			private bool? ecsMetricEnabled;

			private List<DescribeNatGateways_IpList> ipLists;

			private List<string> forwardTableIds;

			private List<string> snatTableIds;

			private List<string> bandwidthPackageIds;

			private DescribeNatGateways_NatGatewayPrivateInfo natGatewayPrivateInfo;

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

			public string Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
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

			public bool? AutoPay
			{
				get
				{
					return autoPay;
				}
				set	
				{
					autoPay = value;
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

			public string NatType
			{
				get
				{
					return natType;
				}
				set	
				{
					natType = value;
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

			public bool? EcsMetricEnabled
			{
				get
				{
					return ecsMetricEnabled;
				}
				set	
				{
					ecsMetricEnabled = value;
				}
			}

			public List<DescribeNatGateways_IpList> IpLists
			{
				get
				{
					return ipLists;
				}
				set	
				{
					ipLists = value;
				}
			}

			public List<string> ForwardTableIds
			{
				get
				{
					return forwardTableIds;
				}
				set	
				{
					forwardTableIds = value;
				}
			}

			public List<string> SnatTableIds
			{
				get
				{
					return snatTableIds;
				}
				set	
				{
					snatTableIds = value;
				}
			}

			public List<string> BandwidthPackageIds
			{
				get
				{
					return bandwidthPackageIds;
				}
				set	
				{
					bandwidthPackageIds = value;
				}
			}

			public DescribeNatGateways_NatGatewayPrivateInfo NatGatewayPrivateInfo
			{
				get
				{
					return natGatewayPrivateInfo;
				}
				set	
				{
					natGatewayPrivateInfo = value;
				}
			}

			public class DescribeNatGateways_IpList
			{

				private string allocationId;

				private string ipAddress;

				private string usingStatus;

				private bool? apAccessEnabled;

				private bool? snatEntryEnabled;

				private string privateIpAddress;

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

				public bool? SnatEntryEnabled
				{
					get
					{
						return snatEntryEnabled;
					}
					set	
					{
						snatEntryEnabled = value;
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
			}

			public class DescribeNatGateways_NatGatewayPrivateInfo
			{

				private string eniInstanceId;

				private string privateIpAddress;

				private string vswitchId;

				private string izNo;

				private int? maxBandwidth;

				private string eniType;

				public string EniInstanceId
				{
					get
					{
						return eniInstanceId;
					}
					set	
					{
						eniInstanceId = value;
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

				public string VswitchId
				{
					get
					{
						return vswitchId;
					}
					set	
					{
						vswitchId = value;
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

				public int? MaxBandwidth
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

				public string EniType
				{
					get
					{
						return eniType;
					}
					set	
					{
						eniType = value;
					}
				}
			}
		}
	}
}
