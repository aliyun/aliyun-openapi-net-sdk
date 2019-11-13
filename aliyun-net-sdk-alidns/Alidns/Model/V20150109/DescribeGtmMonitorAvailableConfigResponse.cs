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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeGtmMonitorAvailableConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGtmMonitorAvailableConfig_IspCityNode> ispCityNodes;

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

		public List<DescribeGtmMonitorAvailableConfig_IspCityNode> IspCityNodes
		{
			get
			{
				return ispCityNodes;
			}
			set	
			{
				ispCityNodes = value;
			}
		}

		public class DescribeGtmMonitorAvailableConfig_IspCityNode
		{

			private string ispName;

			private string ispCode;

			private string cityName;

			private string cityCode;

			private bool? defaultSelected;

			private bool? mainland;

			private string groupType;

			private string groupName;

			public string IspName
			{
				get
				{
					return ispName;
				}
				set	
				{
					ispName = value;
				}
			}

			public string IspCode
			{
				get
				{
					return ispCode;
				}
				set	
				{
					ispCode = value;
				}
			}

			public string CityName
			{
				get
				{
					return cityName;
				}
				set	
				{
					cityName = value;
				}
			}

			public string CityCode
			{
				get
				{
					return cityCode;
				}
				set	
				{
					cityCode = value;
				}
			}

			public bool? DefaultSelected
			{
				get
				{
					return defaultSelected;
				}
				set	
				{
					defaultSelected = value;
				}
			}

			public bool? Mainland
			{
				get
				{
					return mainland;
				}
				set	
				{
					mainland = value;
				}
			}

			public string GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}
		}
	}
}
