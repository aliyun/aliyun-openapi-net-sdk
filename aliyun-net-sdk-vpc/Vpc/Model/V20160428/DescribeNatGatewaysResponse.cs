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
	public class DescribeNatGatewaysResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeNatGateways_NatGateway> natGateways;

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

			private string status;

			private string creationTime;

			private string vpcId;

			private string natType;

			private bool? autoPay;

			private string spec;

			private bool? deletionProtection;

			private string networkType;

			private bool? securityProtectionEnabled;

			private string instanceChargeType;

			private string regionId;

			private bool? ecsMetricEnabled;

			private bool? icmpReplyEnabled;

			private string description;

			private string expiredTime;

			private string resourceGroupId;

			private string natGatewayId;

			private string internetChargeType;

			private string businessStatus;

			private string name;

			private bool? privateLinkEnabled;

			private string privateLinkMode;

			private string eipBindMode;

			private List<DescribeNatGateways_IpList> ipLists;

			private List<DescribeNatGateways_Tag> tags;

			private List<string> forwardTableIds;

			private List<string> snatTableIds;

			private List<string> fullNatTableIds;

			private List<string> bandwidthPackageIds;

			private DescribeNatGateways_NatGatewayPrivateInfo natGatewayPrivateInfo;

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

			public bool? SecurityProtectionEnabled
			{
				get
				{
					return securityProtectionEnabled;
				}
				set	
				{
					securityProtectionEnabled = value;
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

			public bool? IcmpReplyEnabled
			{
				get
				{
					return icmpReplyEnabled;
				}
				set	
				{
					icmpReplyEnabled = value;
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

			public bool? PrivateLinkEnabled
			{
				get
				{
					return privateLinkEnabled;
				}
				set	
				{
					privateLinkEnabled = value;
				}
			}

			public string PrivateLinkMode
			{
				get
				{
					return privateLinkMode;
				}
				set	
				{
					privateLinkMode = value;
				}
			}

			public string EipBindMode
			{
				get
				{
					return eipBindMode;
				}
				set	
				{
					eipBindMode = value;
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

			public List<DescribeNatGateways_Tag> Tags
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

			public List<string> FullNatTableIds
			{
				get
				{
					return fullNatTableIds;
				}
				set	
				{
					fullNatTableIds = value;
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

				private string usingStatus;

				private string ipAddress;

				private bool? snatEntryEnabled;

				private string allocationId;

				private bool? apAccessEnabled;

				private string privateIpAddress;

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

			public class DescribeNatGateways_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}

			public class DescribeNatGateways_NatGatewayPrivateInfo
			{

				private string vswitchId;

				private string eniInstanceId;

				private int? maxBandwidth;

				private int? maxSessionQuota;

				private int? maxSessionEstablishRate;

				private string privateIpAddress;

				private string izNo;

				private string eniType;

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

				public int? MaxSessionQuota
				{
					get
					{
						return maxSessionQuota;
					}
					set	
					{
						maxSessionQuota = value;
					}
				}

				public int? MaxSessionEstablishRate
				{
					get
					{
						return maxSessionEstablishRate;
					}
					set	
					{
						maxSessionEstablishRate = value;
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
