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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class DescribePublishedRouteEntriesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private int? pageSize;

		private List<DescribePublishedRouteEntries_PublishedRouteEntry> publishedRouteEntries;

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

		public List<DescribePublishedRouteEntries_PublishedRouteEntry> PublishedRouteEntries
		{
			get
			{
				return publishedRouteEntries;
			}
			set	
			{
				publishedRouteEntries = value;
			}
		}

		public class DescribePublishedRouteEntries_PublishedRouteEntry
		{

			private string destinationCidrBlock;

			private string childInstanceRouteTableId;

			private string nextHopType;

			private string routeType;

			private string nextHopId;

			private bool? operationalMode;

			private string publishStatus;

			private List<DescribePublishedRouteEntries_Conflict> conflicts;

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

			public string ChildInstanceRouteTableId
			{
				get
				{
					return childInstanceRouteTableId;
				}
				set	
				{
					childInstanceRouteTableId = value;
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

			public string RouteType
			{
				get
				{
					return routeType;
				}
				set	
				{
					routeType = value;
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

			public bool? OperationalMode
			{
				get
				{
					return operationalMode;
				}
				set	
				{
					operationalMode = value;
				}
			}

			public string PublishStatus
			{
				get
				{
					return publishStatus;
				}
				set	
				{
					publishStatus = value;
				}
			}

			public List<DescribePublishedRouteEntries_Conflict> Conflicts
			{
				get
				{
					return conflicts;
				}
				set	
				{
					conflicts = value;
				}
			}

			public class DescribePublishedRouteEntries_Conflict
			{

				private string destinationCidrBlock;

				private string regionId;

				private string instanceId;

				private string instanceType;

				private string status;

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
			}
		}
	}
}
