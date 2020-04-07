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
	public class DescribeVSwitchAttributesResponse : AcsResponse
	{

		private string requestId;

		private string vSwitchId;

		private string vpcId;

		private string status;

		private string cidrBlock;

		private string ipv6CidrBlock;

		private string zoneId;

		private long? availableIpAddressCount;

		private string description;

		private string vSwitchName;

		private string creationTime;

		private bool? isDefault;

		private string resourceGroupId;

		private string networkAclId;

		private long? ownerId;

		private string shareType;

		private List<DescribeVSwitchAttributes_CloudResourceSetType> cloudResources;

		private DescribeVSwitchAttributes_RouteTable routeTable;

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

		public long? AvailableIpAddressCount
		{
			get
			{
				return availableIpAddressCount;
			}
			set	
			{
				availableIpAddressCount = value;
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

		public string VSwitchName
		{
			get
			{
				return vSwitchName;
			}
			set	
			{
				vSwitchName = value;
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

		public string NetworkAclId
		{
			get
			{
				return networkAclId;
			}
			set	
			{
				networkAclId = value;
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

		public string ShareType
		{
			get
			{
				return shareType;
			}
			set	
			{
				shareType = value;
			}
		}

		public List<DescribeVSwitchAttributes_CloudResourceSetType> CloudResources
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

		public DescribeVSwitchAttributes_RouteTable RouteTable
		{
			get
			{
				return routeTable;
			}
			set	
			{
				routeTable = value;
			}
		}

		public class DescribeVSwitchAttributes_CloudResourceSetType
		{

			private string resourceType;

			private int? resourceCount;

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
		}

		public class DescribeVSwitchAttributes_RouteTable
		{

			private string routeTableId;

			private string routeTableType;

			public string RouteTableId
			{
				get
				{
					return routeTableId;
				}
				set	
				{
					routeTableId = value;
				}
			}

			public string RouteTableType
			{
				get
				{
					return routeTableType;
				}
				set	
				{
					routeTableType = value;
				}
			}
		}
	}
}
