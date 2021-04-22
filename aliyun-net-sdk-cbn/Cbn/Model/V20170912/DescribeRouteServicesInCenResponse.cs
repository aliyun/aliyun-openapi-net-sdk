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
	public class DescribeRouteServicesInCenResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeRouteServicesInCen_RouteServiceEntry> routeServiceEntries;

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

		public List<DescribeRouteServicesInCen_RouteServiceEntry> RouteServiceEntries
		{
			get
			{
				return routeServiceEntries;
			}
			set	
			{
				routeServiceEntries = value;
			}
		}

		public class DescribeRouteServicesInCen_RouteServiceEntry
		{

			private string cenId;

			private string host;

			private string hostRegionId;

			private string accessRegionId;

			private string updateInterval;

			private string status;

			private string hostVpcId;

			private string description;

			private List<string> cidrs;

			public string CenId
			{
				get
				{
					return cenId;
				}
				set	
				{
					cenId = value;
				}
			}

			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}

			public string HostRegionId
			{
				get
				{
					return hostRegionId;
				}
				set	
				{
					hostRegionId = value;
				}
			}

			public string AccessRegionId
			{
				get
				{
					return accessRegionId;
				}
				set	
				{
					accessRegionId = value;
				}
			}

			public string UpdateInterval
			{
				get
				{
					return updateInterval;
				}
				set	
				{
					updateInterval = value;
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

			public string HostVpcId
			{
				get
				{
					return hostVpcId;
				}
				set	
				{
					hostVpcId = value;
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

			public List<string> Cidrs
			{
				get
				{
					return cidrs;
				}
				set	
				{
					cidrs = value;
				}
			}
		}
	}
}
