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
	public class DescribeVpcsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeVpcs_Vpc> vpcs;

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

		public List<DescribeVpcs_Vpc> Vpcs
		{
			get
			{
				return vpcs;
			}
			set	
			{
				vpcs = value;
			}
		}

		public class DescribeVpcs_Vpc
		{

			private string vpcId;

			private string regionId;

			private string status;

			private string vpcName;

			private string creationTime;

			private string cidrBlock;

			private string vRouterId;

			private string description;

			private bool? isDefault;

			private List<string> vSwitchIds;

			private List<string> userCidrs;

			private List<string> natGatewayIds;

			private List<string> routerTableIds;

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

			public List<string> NatGatewayIds
			{
				get
				{
					return natGatewayIds;
				}
				set	
				{
					natGatewayIds = value;
				}
			}

			public List<string> RouterTableIds
			{
				get
				{
					return routerTableIds;
				}
				set	
				{
					routerTableIds = value;
				}
			}
		}
	}
}