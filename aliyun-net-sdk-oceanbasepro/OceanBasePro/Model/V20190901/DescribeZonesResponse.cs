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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeZonesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeZones_Data> zones;

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

		[JsonProperty(PropertyName = "Zones")]
		public List<DescribeZones_Data> Zones
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

		public class DescribeZones_Data
		{

			private string zoneId;

			private string zoneName;

			private string series;

			private string deployType;

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

			[JsonProperty(PropertyName = "Series")]
			public string Series
			{
				get
				{
					return series;
				}
				set	
				{
					series = value;
				}
			}

			[JsonProperty(PropertyName = "DeployType")]
			public string DeployType
			{
				get
				{
					return deployType;
				}
				set	
				{
					deployType = value;
				}
			}
		}
	}
}
