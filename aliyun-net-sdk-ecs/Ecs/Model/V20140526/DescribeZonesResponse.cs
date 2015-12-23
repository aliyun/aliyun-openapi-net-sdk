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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeZonesResponse : AcsResponse
	{

		private List<Zone> zones;

		public List<Zone> Zones
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

		public class Zone{

			private string zoneId;

			private string localName;

			private List<string> availableResourceCreation;

			private List<string> availableDiskCategories;

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

			public List<string> AvailableResourceCreation
			{
				get
				{
					return availableResourceCreation;
				}
				set	
				{
					availableResourceCreation = value;
				}
			}

			public List<string> AvailableDiskCategories
			{
				get
				{
					return availableDiskCategories;
				}
				set	
				{
					availableDiskCategories = value;
				}
			}
		}
	}
}