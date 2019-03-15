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

namespace Aliyun.Acs.pvtz.Model.V20180101
{
	public class DescribeStatisticSummaryResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private List<DescribeStatisticSummary_ZoneRequestTop> zoneRequestTops;

		private List<DescribeStatisticSummary_VpcRequestTop> vpcRequestTops;

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

		public long? TotalCount
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

		public List<DescribeStatisticSummary_ZoneRequestTop> ZoneRequestTops
		{
			get
			{
				return zoneRequestTops;
			}
			set	
			{
				zoneRequestTops = value;
			}
		}

		public List<DescribeStatisticSummary_VpcRequestTop> VpcRequestTops
		{
			get
			{
				return vpcRequestTops;
			}
			set	
			{
				vpcRequestTops = value;
			}
		}

		public class DescribeStatisticSummary_ZoneRequestTop
		{

			private string zoneName;

			private long? requestCount;

			public string ZoneName
			{
				get
				{
					return zoneName;
				}
				set	
				{
					zoneName = value;
				}
			}

			public long? RequestCount
			{
				get
				{
					return requestCount;
				}
				set	
				{
					requestCount = value;
				}
			}
		}

		public class DescribeStatisticSummary_VpcRequestTop
		{

			private string regionId;

			private string vpcId;

			private string tunnelId;

			private long? requestCount;

			private string regionName;

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

			public string TunnelId
			{
				get
				{
					return tunnelId;
				}
				set	
				{
					tunnelId = value;
				}
			}

			public long? RequestCount
			{
				get
				{
					return requestCount;
				}
				set	
				{
					requestCount = value;
				}
			}

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}
		}
	}
}
