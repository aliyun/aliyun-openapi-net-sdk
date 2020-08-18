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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class DescribeMultiZoneAvailableRegionsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeMultiZoneAvailableRegions_Region> regions;

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

		public List<DescribeMultiZoneAvailableRegions_Region> Regions
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

		public class DescribeMultiZoneAvailableRegions_Region
		{

			private string localName;

			private string regionEndpoint;

			private string regionId;

			private List<DescribeMultiZoneAvailableRegions_AvailableCombine> availableCombines;

			public string LocalName
			{
				get
				{
					return localName;
				}
				set	
				{
					localName = value;
				}
			}

			public string RegionEndpoint
			{
				get
				{
					return regionEndpoint;
				}
				set	
				{
					regionEndpoint = value;
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

			public List<DescribeMultiZoneAvailableRegions_AvailableCombine> AvailableCombines
			{
				get
				{
					return availableCombines;
				}
				set	
				{
					availableCombines = value;
				}
			}

			public class DescribeMultiZoneAvailableRegions_AvailableCombine
			{

				private string id;

				private List<string> zones;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public List<string> Zones
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
			}
		}
	}
}
