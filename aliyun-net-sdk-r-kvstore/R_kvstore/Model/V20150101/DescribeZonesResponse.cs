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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeZonesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeZones_KVStoreZone> zones;

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

		public List<DescribeZones_KVStoreZone> Zones
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

		public class DescribeZones_KVStoreZone
		{

			private bool? isRds;

			private string zoneId;

			private bool? disabled;

			private bool? switchNetwork;

			private string zoneName;

			private string regionId;

			public bool? IsRds
			{
				get
				{
					return isRds;
				}
				set	
				{
					isRds = value;
				}
			}

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

			public bool? Disabled
			{
				get
				{
					return disabled;
				}
				set	
				{
					disabled = value;
				}
			}

			public bool? SwitchNetwork
			{
				get
				{
					return switchNetwork;
				}
				set	
				{
					switchNetwork = value;
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
