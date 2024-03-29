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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeRegionsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRegions_RDSRegion> regions;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Regions")]
		public List<DescribeRegions_RDSRegion> Regions
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

		public class DescribeRegions_RDSRegion
		{

			private string zoneId;

			private string regionEndpoint;

			private string localName;

			private string regionId;

			private string zoneName;

			[JsonProperty(PropertyName = "ZoneId")]
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

			[JsonProperty(PropertyName = "RegionEndpoint")]
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

			[JsonProperty(PropertyName = "LocalName")]
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

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "ZoneName")]
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
