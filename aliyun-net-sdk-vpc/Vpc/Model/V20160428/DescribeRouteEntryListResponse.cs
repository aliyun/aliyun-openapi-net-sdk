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
	public class DescribeRouteEntryListResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private List<DescribeRouteEntryList_RouteEntry> routeEntrys;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public List<DescribeRouteEntryList_RouteEntry> RouteEntrys
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

		public class DescribeRouteEntryList_RouteEntry
		{

			private string status;

			private string type;

			private string ipVersion;

			private string description;

			private string routeEntryName;

			private string destinationCidrBlock;

			private string routeEntryId;

			private string routeTableId;

			private string gmtModified;

			private List<DescribeRouteEntryList_NextHop> nextHops;

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

			public string IpVersion
			{
				get
				{
					return ipVersion;
				}
				set	
				{
					ipVersion = value;
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

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public List<DescribeRouteEntryList_NextHop> NextHops
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

			public class DescribeRouteEntryList_NextHop
			{

				private string nextHopRegionId;

				private int? weight;

				private string nextHopId;

				private int? enabled;

				private string nextHopType;

				private DescribeRouteEntryList_NextHopRelatedInfo nextHopRelatedInfo;

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

				public DescribeRouteEntryList_NextHopRelatedInfo NextHopRelatedInfo
				{
					get
					{
						return nextHopRelatedInfo;
					}
					set	
					{
						nextHopRelatedInfo = value;
					}
				}

				public class DescribeRouteEntryList_NextHopRelatedInfo
				{

					private string instanceId;

					private string instanceType;

					private string regionId;

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

					public string InstanceType
					{
						get
						{
							return instanceType;
						}
						set	
						{
							instanceType = value;
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
				}
			}
		}
	}
}
