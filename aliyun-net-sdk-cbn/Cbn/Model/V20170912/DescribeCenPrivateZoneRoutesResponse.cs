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
	public class DescribeCenPrivateZoneRoutesResponse : AcsResponse
	{

		private string requestId;

		private string privateZoneDnsServers;

		private string cenId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeCenPrivateZoneRoutes_PrivateZoneInfo> privateZoneInfos;

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

		public string PrivateZoneDnsServers
		{
			get
			{
				return privateZoneDnsServers;
			}
			set	
			{
				privateZoneDnsServers = value;
			}
		}

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

		public List<DescribeCenPrivateZoneRoutes_PrivateZoneInfo> PrivateZoneInfos
		{
			get
			{
				return privateZoneInfos;
			}
			set	
			{
				privateZoneInfos = value;
			}
		}

		public class DescribeCenPrivateZoneRoutes_PrivateZoneInfo
		{

			private string status;

			private string accessRegionId;

			private string hostRegionId;

			private string hostVpcId;

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
		}
	}
}
