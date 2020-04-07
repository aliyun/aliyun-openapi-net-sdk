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
	public class DescribeVSwitchesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeVSwitches_VSwitch> vSwitches;

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

		public List<DescribeVSwitches_VSwitch> VSwitches
		{
			get
			{
				return vSwitches;
			}
			set	
			{
				vSwitches = value;
			}
		}

		public class DescribeVSwitches_VSwitch
		{

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

			private List<DescribeVSwitches_Tag> tags;

			private DescribeVSwitches_RouteTable routeTable;

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

			public List<DescribeVSwitches_Tag> Tags
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

			public DescribeVSwitches_RouteTable RouteTable
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

			public class DescribeVSwitches_Tag
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

			public class DescribeVSwitches_RouteTable
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
}
