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
	public class DescribeVpcAttributeResponse : AcsResponse
	{

		private string creationTime;

		private string status;

		private string vpcId;

		private bool? isDefault;

		private bool? classicLinkEnabled;

		private long? ownerId;

		private string regionId;

		private string vpcName;

		private string vRouterId;

		private string dhcpOptionsSetStatus;

		private string cidrBlock;

		private string requestId;

		private string description;

		private string networkAclNum;

		private string resourceGroupId;

		private string dhcpOptionsSetId;

		private string ipv6CidrBlock;

		private bool? supportIpv4Gateway;

		private string ipv4GatewayId;

		private List<DescribeVpcAttribute_AssociatedCen> associatedCens;

		private List<DescribeVpcAttribute_CloudResourceSetType> cloudResources;

		private List<DescribeVpcAttribute_Ipv6CidrBlock> ipv6CidrBlocks;

		private List<string> vSwitchIds;

		private List<string> userCidrs;

		private List<string> secondaryCidrBlocks;

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

		public bool? IsDefault
		{
			get
			{
				return isDefault;
			}
			set	
			{
				isDefault = value;
			}
		}

		public bool? ClassicLinkEnabled
		{
			get
			{
				return classicLinkEnabled;
			}
			set	
			{
				classicLinkEnabled = value;
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
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

		public string VpcName
		{
			get
			{
				return vpcName;
			}
			set	
			{
				vpcName = value;
			}
		}

		public string VRouterId
		{
			get
			{
				return vRouterId;
			}
			set	
			{
				vRouterId = value;
			}
		}

		public string DhcpOptionsSetStatus
		{
			get
			{
				return dhcpOptionsSetStatus;
			}
			set	
			{
				dhcpOptionsSetStatus = value;
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

		public string NetworkAclNum
		{
			get
			{
				return networkAclNum;
			}
			set	
			{
				networkAclNum = value;
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

		public string DhcpOptionsSetId
		{
			get
			{
				return dhcpOptionsSetId;
			}
			set	
			{
				dhcpOptionsSetId = value;
			}
		}

		public string Ipv6CidrBlock
		{
			get
			{
				return ipv6CidrBlock;
			}
			set	
			{
				ipv6CidrBlock = value;
			}
		}

		public bool? SupportIpv4Gateway
		{
			get
			{
				return supportIpv4Gateway;
			}
			set	
			{
				supportIpv4Gateway = value;
			}
		}

		public string Ipv4GatewayId
		{
			get
			{
				return ipv4GatewayId;
			}
			set	
			{
				ipv4GatewayId = value;
			}
		}

		public List<DescribeVpcAttribute_AssociatedCen> AssociatedCens
		{
			get
			{
				return associatedCens;
			}
			set	
			{
				associatedCens = value;
			}
		}

		public List<DescribeVpcAttribute_CloudResourceSetType> CloudResources
		{
			get
			{
				return cloudResources;
			}
			set	
			{
				cloudResources = value;
			}
		}

		public List<DescribeVpcAttribute_Ipv6CidrBlock> Ipv6CidrBlocks
		{
			get
			{
				return ipv6CidrBlocks;
			}
			set	
			{
				ipv6CidrBlocks = value;
			}
		}

		public List<string> VSwitchIds
		{
			get
			{
				return vSwitchIds;
			}
			set	
			{
				vSwitchIds = value;
			}
		}

		public List<string> UserCidrs
		{
			get
			{
				return userCidrs;
			}
			set	
			{
				userCidrs = value;
			}
		}

		public List<string> SecondaryCidrBlocks
		{
			get
			{
				return secondaryCidrBlocks;
			}
			set	
			{
				secondaryCidrBlocks = value;
			}
		}

		public class DescribeVpcAttribute_AssociatedCen
		{

			private long? cenOwnerId;

			private string cenId;

			private string cenStatus;

			public long? CenOwnerId
			{
				get
				{
					return cenOwnerId;
				}
				set	
				{
					cenOwnerId = value;
				}
			}

			public string CenId
			{
				get
				{
					return cenId;
				}
				set	
				{
					cenId = value;
				}
			}

			public string CenStatus
			{
				get
				{
					return cenStatus;
				}
				set	
				{
					cenStatus = value;
				}
			}
		}

		public class DescribeVpcAttribute_CloudResourceSetType
		{

			private int? resourceCount;

			private string resourceType;

			public int? ResourceCount
			{
				get
				{
					return resourceCount;
				}
				set	
				{
					resourceCount = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}
		}

		public class DescribeVpcAttribute_Ipv6CidrBlock
		{

			private string ipv6Isp;

			private string ipv6CidrBlock;

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

			public string Ipv6CidrBlock
			{
				get
				{
					return ipv6CidrBlock;
				}
				set	
				{
					ipv6CidrBlock = value;
				}
			}
		}
	}
}
