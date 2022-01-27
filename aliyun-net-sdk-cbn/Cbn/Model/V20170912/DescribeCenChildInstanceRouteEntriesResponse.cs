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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class DescribeCenChildInstanceRouteEntriesResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeCenChildInstanceRouteEntries_CenRouteEntry> cenRouteEntries;

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

		public List<DescribeCenChildInstanceRouteEntries_CenRouteEntry> CenRouteEntries
		{
			get
			{
				return cenRouteEntries;
			}
			set	
			{
				cenRouteEntries = value;
			}
		}

		public class DescribeCenChildInstanceRouteEntries_CenRouteEntry
		{

			private string status;

			private string type;

			private string publishStatus;

			private string nextHopType;

			private bool? operationalMode;

			private string nextHopRegionId;

			private string nextHopInstanceId;

			private string destinationCidrBlock;

			private string routeTableId;

			private List<DescribeCenChildInstanceRouteEntries_CenRouteMapRecord> cenRouteMapRecords;

			private List<DescribeCenChildInstanceRouteEntries_Conflict> conflicts;

			private List<string> communities;

			private List<string> asPaths;

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

			public string NextHopInstanceId
			{
				get
				{
					return nextHopInstanceId;
				}
				set	
				{
					nextHopInstanceId = value;
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

			public List<DescribeCenChildInstanceRouteEntries_CenRouteMapRecord> CenRouteMapRecords
			{
				get
				{
					return cenRouteMapRecords;
				}
				set	
				{
					cenRouteMapRecords = value;
				}
			}

			public List<DescribeCenChildInstanceRouteEntries_Conflict> Conflicts
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

			public List<string> Communities
			{
				get
				{
					return communities;
				}
				set	
				{
					communities = value;
				}
			}

			public List<string> AsPaths
			{
				get
				{
					return asPaths;
				}
				set	
				{
					asPaths = value;
				}
			}

			public class DescribeCenChildInstanceRouteEntries_CenRouteMapRecord
			{

				private string routeMapId;

				private string regionId;

				public string RouteMapId
				{
					get
					{
						return routeMapId;
					}
					set	
					{
						routeMapId = value;
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

			public class DescribeCenChildInstanceRouteEntries_Conflict
			{

				private string status;

				private string destinationCidrBlock;

				private string instanceId;

				private string instanceType;

				private string regionId;

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
