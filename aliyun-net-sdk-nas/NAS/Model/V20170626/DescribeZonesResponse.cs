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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeZonesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeZones_Zone> zones;

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

		public List<DescribeZones_Zone> Zones
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

		public class DescribeZones_Zone
		{

			private string zoneId;

			private List<DescribeZones_InstanceType> instanceTypes;

			private List<string> performance;

			private List<string> capacity;

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

			public List<DescribeZones_InstanceType> InstanceTypes
			{
				get
				{
					return instanceTypes;
				}
				set	
				{
					instanceTypes = value;
				}
			}

			public List<string> Performance
			{
				get
				{
					return performance;
				}
				set	
				{
					performance = value;
				}
			}

			public List<string> Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public class DescribeZones_InstanceType
			{

				private string storageType;

				private string protocolType;

				public string StorageType
				{
					get
					{
						return storageType;
					}
					set	
					{
						storageType = value;
					}
				}

				public string ProtocolType
				{
					get
					{
						return protocolType;
					}
					set	
					{
						protocolType = value;
					}
				}
			}
		}
	}
}
