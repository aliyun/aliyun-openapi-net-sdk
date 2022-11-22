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
	public class DescribeInstanceCreatableZoneResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceCreatableZone_ZoneListItem> zoneList;

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

		[JsonProperty(PropertyName = "ZoneList")]
		public List<DescribeInstanceCreatableZone_ZoneListItem> ZoneList
		{
			get
			{
				return zoneList;
			}
			set	
			{
				zoneList = value;
			}
		}

		public class DescribeInstanceCreatableZone_ZoneListItem
		{

			private bool? isInCluster;

			private string zone;

			[JsonProperty(PropertyName = "IsInCluster")]
			public bool? IsInCluster
			{
				get
				{
					return isInCluster;
				}
				set	
				{
					isInCluster = value;
				}
			}

			[JsonProperty(PropertyName = "Zone")]
			public string Zone
			{
				get
				{
					return zone;
				}
				set	
				{
					zone = value;
				}
			}
		}
	}
}
