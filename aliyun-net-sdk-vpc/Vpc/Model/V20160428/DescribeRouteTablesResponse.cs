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
	public class DescribeRouteTablesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeRouteTables_RouteTable> routeTables;

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

		public List<DescribeRouteTables_RouteTable> RouteTables
		{
			get
			{
				return routeTables;
			}
			set	
			{
				routeTables = value;
			}
		}

		public class DescribeRouteTables_RouteTable
		{

			private string vRouterId;

			private string routeTableId;

			private string routeTableType;

			private string creationTime;

			private string resourceGroupId;

			private string status;

			private List<DescribeRouteTables_RouteEntry> routeEntrys;

			private List<string> vSwitchIds;

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

			public List<DescribeRouteTables_RouteEntry> RouteEntrys
			{
				get
				{
					return routeEntrys;
				}
				set	
				{
					routeEntrys = value;
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

			public class DescribeRouteTables_RouteEntry
			{

				private string routeTableId;

				private string destinationCidrBlock;

				private string type;

				private string status;

				private string instanceId;

				private string nextHopType;

				private string routeEntryName;

				private string description;

				private string routeEntryId;

				private string nextHopRegionId;

				private string nextHopOppsiteType;

				private string nextHopOppsiteInstanceId;

				private string nextHopOppsiteRegionId;

				private string privateIpAddress;

				private List<DescribeRouteTables_NextHop> nextHops;

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

				public string DestinationCidrBlock
				{
					get
					{
						return destinationCidrBlock;
					}
					set	
					{
						destinationCidrBlock = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
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

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string NextHopType
				{
					get
					{
						return nextHopType;
					}
					set	
					{
						nextHopType = value;
					}
				}

				public string RouteEntryName
				{
					get
					{
						return routeEntryName;
					}
					set	
					{
						routeEntryName = value;
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

				public string RouteEntryId
				{
					get
					{
						return routeEntryId;
					}
					set	
					{
						routeEntryId = value;
					}
				}

				public string NextHopRegionId
				{
					get
					{
						return nextHopRegionId;
					}
					set	
					{
						nextHopRegionId = value;
					}
				}

				public string NextHopOppsiteType
				{
					get
					{
						return nextHopOppsiteType;
					}
					set	
					{
						nextHopOppsiteType = value;
					}
				}

				public string NextHopOppsiteInstanceId
				{
					get
					{
						return nextHopOppsiteInstanceId;
					}
					set	
					{
						nextHopOppsiteInstanceId = value;
					}
				}

				public string NextHopOppsiteRegionId
				{
					get
					{
						return nextHopOppsiteRegionId;
					}
					set	
					{
						nextHopOppsiteRegionId = value;
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

				public List<DescribeRouteTables_NextHop> NextHops
				{
					get
					{
						return nextHops;
					}
					set	
					{
						nextHops = value;
					}
				}

				public class DescribeRouteTables_NextHop
				{

					private string nextHopType;

					private string nextHopId;

					private int? enabled;

					private int? weight;

					private string nextHopRegionId;

					private string nextHopOppsiteType;

					private string nextHopOppsiteInstanceId;

					private string nextHopOppsiteRegionId;

					public string NextHopType
					{
						get
						{
							return nextHopType;
						}
						set	
						{
							nextHopType = value;
						}
					}

					public string NextHopId
					{
						get
						{
							return nextHopId;
						}
						set	
						{
							nextHopId = value;
						}
					}

					public int? Enabled
					{
						get
						{
							return enabled;
						}
						set	
						{
							enabled = value;
						}
					}

					public int? Weight
					{
						get
						{
							return weight;
						}
						set	
						{
							weight = value;
						}
					}

					public string NextHopRegionId
					{
						get
						{
							return nextHopRegionId;
						}
						set	
						{
							nextHopRegionId = value;
						}
					}

					public string NextHopOppsiteType
					{
						get
						{
							return nextHopOppsiteType;
						}
						set	
						{
							nextHopOppsiteType = value;
						}
					}

					public string NextHopOppsiteInstanceId
					{
						get
						{
							return nextHopOppsiteInstanceId;
						}
						set	
						{
							nextHopOppsiteInstanceId = value;
						}
					}

					public string NextHopOppsiteRegionId
					{
						get
						{
							return nextHopOppsiteRegionId;
						}
						set	
						{
							nextHopOppsiteRegionId = value;
						}
					}
				}
			}
		}
	}
}
