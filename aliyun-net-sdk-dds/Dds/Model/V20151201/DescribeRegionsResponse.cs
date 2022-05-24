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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeRegionsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRegions_DdsRegion> regions;

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

		public List<DescribeRegions_DdsRegion> Regions
		{
			get
			{
				return regions;
			}
			set	
			{
				regions = value;
			}
		}

		public class DescribeRegions_DdsRegion
		{

			private string zoneIds;

			private string regionId;

			private string regionName;

			private List<DescribeRegions_Zone> zones;

			public string ZoneIds
			{
				get
				{
					return zoneIds;
				}
				set	
				{
					zoneIds = value;
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

			public List<DescribeRegions_Zone> Zones
			{
				get
				{
					return zones;
				}
				set	
				{
					zones = value;
				}
			}

			public class DescribeRegions_Zone
			{

				private string zoneId;

				private bool? vpcEnabled;

				private string zoneName;

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

				public bool? VpcEnabled
				{
					get
					{
						return vpcEnabled;
					}
					set	
					{
						vpcEnabled = value;
					}
				}

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
			}
		}
	}
}
