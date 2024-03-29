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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeVpcHoneyPotListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVpcHoneyPotList_VpcHoneyPotDTO> vpcHoneyPotDTOList;

		private DescribeVpcHoneyPotList_PageInfo pageInfo;

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

		public List<DescribeVpcHoneyPotList_VpcHoneyPotDTO> VpcHoneyPotDTOList
		{
			get
			{
				return vpcHoneyPotDTOList;
			}
			set	
			{
				vpcHoneyPotDTOList = value;
			}
		}

		public DescribeVpcHoneyPotList_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeVpcHoneyPotList_VpcHoneyPotDTO
		{

			private string vpcName;

			private string vpcId;

			private string honeyPotEniInstanceId;

			private string cidrBlock;

			private string vpcStatus;

			private long? createTime;

			private string honeyPotVpcSwitchId;

			private bool? honeyPotExistence;

			private string vpcRegionId;

			private string honeyPotEcsInstanceStatus;

			private string honeyPotInstanceStatus;

			private List<DescribeVpcHoneyPotList_VpcSwitchInfo> vpcSwitchIdList;

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

			public string HoneyPotEniInstanceId
			{
				get
				{
					return honeyPotEniInstanceId;
				}
				set	
				{
					honeyPotEniInstanceId = value;
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

			public string VpcStatus
			{
				get
				{
					return vpcStatus;
				}
				set	
				{
					vpcStatus = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string HoneyPotVpcSwitchId
			{
				get
				{
					return honeyPotVpcSwitchId;
				}
				set	
				{
					honeyPotVpcSwitchId = value;
				}
			}

			public bool? HoneyPotExistence
			{
				get
				{
					return honeyPotExistence;
				}
				set	
				{
					honeyPotExistence = value;
				}
			}

			public string VpcRegionId
			{
				get
				{
					return vpcRegionId;
				}
				set	
				{
					vpcRegionId = value;
				}
			}

			public string HoneyPotEcsInstanceStatus
			{
				get
				{
					return honeyPotEcsInstanceStatus;
				}
				set	
				{
					honeyPotEcsInstanceStatus = value;
				}
			}

			public string HoneyPotInstanceStatus
			{
				get
				{
					return honeyPotInstanceStatus;
				}
				set	
				{
					honeyPotInstanceStatus = value;
				}
			}

			public List<DescribeVpcHoneyPotList_VpcSwitchInfo> VpcSwitchIdList
			{
				get
				{
					return vpcSwitchIdList;
				}
				set	
				{
					vpcSwitchIdList = value;
				}
			}

			public class DescribeVpcHoneyPotList_VpcSwitchInfo
			{

				private string vpcSwitchName;

				private string zoneId;

				private string vpcSwitchId;

				public string VpcSwitchName
				{
					get
					{
						return vpcSwitchName;
					}
					set	
					{
						vpcSwitchName = value;
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

				public string VpcSwitchId
				{
					get
					{
						return vpcSwitchId;
					}
					set	
					{
						vpcSwitchId = value;
					}
				}
			}
		}

		public class DescribeVpcHoneyPotList_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
