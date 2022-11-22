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
	public class DescribeTimeZonesResponse : AcsResponse
	{

		private string requestId;

		private DescribeTimeZones_TimeZones timeZones;

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

		[JsonProperty(PropertyName = "TimeZones")]
		public DescribeTimeZones_TimeZones TimeZones
		{
			get
			{
				return timeZones;
			}
			set	
			{
				timeZones = value;
			}
		}

		public class DescribeTimeZones_TimeZones
		{

			private string _default;

			private List<DescribeTimeZones_ListItem> list;

			[JsonProperty(PropertyName = "_Default")]
			public string _Default
			{
				get
				{
					return _default;
				}
				set	
				{
					_default = value;
				}
			}

			[JsonProperty(PropertyName = "List")]
			public List<DescribeTimeZones_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class DescribeTimeZones_ListItem
			{

				private string timeZone;

				private string description;

				[JsonProperty(PropertyName = "TimeZone")]
				public string TimeZone
				{
					get
					{
						return timeZone;
					}
					set	
					{
						timeZone = value;
					}
				}

				[JsonProperty(PropertyName = "Description")]
				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}
			}
		}
	}
}
