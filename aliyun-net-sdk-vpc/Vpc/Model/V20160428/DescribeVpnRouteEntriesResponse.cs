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
	public class DescribeVpnRouteEntriesResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeVpnRouteEntries_VpnRouteEntry> vpnRouteEntries;

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

		public List<DescribeVpnRouteEntries_VpnRouteEntry> VpnRouteEntries
		{
			get
			{
				return vpnRouteEntries;
			}
			set	
			{
				vpnRouteEntries = value;
			}
		}

		public class DescribeVpnRouteEntries_VpnRouteEntry
		{

			private string routeEntryType;

			private string nextHop;

			private int? weight;

			private string routeDest;

			private string asPath;

			private string state;

			private long? createTime;

			private string community;

			private string source;

			private string vpnInstanceId;

			public string RouteEntryType
			{
				get
				{
					return routeEntryType;
				}
				set	
				{
					routeEntryType = value;
				}
			}

			public string NextHop
			{
				get
				{
					return nextHop;
				}
				set	
				{
					nextHop = value;
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

			public string RouteDest
			{
				get
				{
					return routeDest;
				}
				set	
				{
					routeDest = value;
				}
			}

			public string AsPath
			{
				get
				{
					return asPath;
				}
				set	
				{
					asPath = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
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

			public string Community
			{
				get
				{
					return community;
				}
				set	
				{
					community = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public string VpnInstanceId
			{
				get
				{
					return vpnInstanceId;
				}
				set	
				{
					vpnInstanceId = value;
				}
			}
		}
	}
}
