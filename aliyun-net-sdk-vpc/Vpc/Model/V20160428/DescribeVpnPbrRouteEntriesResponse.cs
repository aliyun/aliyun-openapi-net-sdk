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
	public class DescribeVpnPbrRouteEntriesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeVpnPbrRouteEntries_VpnPbrRouteEntry> vpnPbrRouteEntries;

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

		public List<DescribeVpnPbrRouteEntries_VpnPbrRouteEntry> VpnPbrRouteEntries
		{
			get
			{
				return vpnPbrRouteEntries;
			}
			set	
			{
				vpnPbrRouteEntries = value;
			}
		}

		public class DescribeVpnPbrRouteEntries_VpnPbrRouteEntry
		{

			private string vpnInstanceId;

			private string routeSource;

			private string routeDest;

			private string nextHop;

			private int? weight;

			private long? createTime;

			private string state;

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

			public string RouteSource
			{
				get
				{
					return routeSource;
				}
				set	
				{
					routeSource = value;
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
		}
	}
}
