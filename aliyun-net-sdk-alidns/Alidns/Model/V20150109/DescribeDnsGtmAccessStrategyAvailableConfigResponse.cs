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
	public class DescribeDnsGtmAccessStrategyAvailableConfigResponse : AcsResponse
	{

		private string requestId;

		private bool? suggestSetDefaultLine;

		private List<DescribeDnsGtmAccessStrategyAvailableConfig_Ipv4AddrPool> ipv4AddrPools;

		private List<DescribeDnsGtmAccessStrategyAvailableConfig_Line> lines;

		private List<DescribeDnsGtmAccessStrategyAvailableConfig_Ipv6AddrPool> ipv6AddrPools;

		private List<DescribeDnsGtmAccessStrategyAvailableConfig_DomainAddrPool> domainAddrPools;

		private List<string> selectedIpv4Lines;

		private List<string> selectedIpv6Lines;

		private List<string> selectedDomainLines;

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

		public bool? SuggestSetDefaultLine
		{
			get
			{
				return suggestSetDefaultLine;
			}
			set	
			{
				suggestSetDefaultLine = value;
			}
		}

		public List<DescribeDnsGtmAccessStrategyAvailableConfig_Ipv4AddrPool> Ipv4AddrPools
		{
			get
			{
				return ipv4AddrPools;
			}
			set	
			{
				ipv4AddrPools = value;
			}
		}

		public List<DescribeDnsGtmAccessStrategyAvailableConfig_Line> Lines
		{
			get
			{
				return lines;
			}
			set	
			{
				lines = value;
			}
		}

		public List<DescribeDnsGtmAccessStrategyAvailableConfig_Ipv6AddrPool> Ipv6AddrPools
		{
			get
			{
				return ipv6AddrPools;
			}
			set	
			{
				ipv6AddrPools = value;
			}
		}

		public List<DescribeDnsGtmAccessStrategyAvailableConfig_DomainAddrPool> DomainAddrPools
		{
			get
			{
				return domainAddrPools;
			}
			set	
			{
				domainAddrPools = value;
			}
		}

		public List<string> SelectedIpv4Lines
		{
			get
			{
				return selectedIpv4Lines;
			}
			set	
			{
				selectedIpv4Lines = value;
			}
		}

		public List<string> SelectedIpv6Lines
		{
			get
			{
				return selectedIpv6Lines;
			}
			set	
			{
				selectedIpv6Lines = value;
			}
		}

		public List<string> SelectedDomainLines
		{
			get
			{
				return selectedDomainLines;
			}
			set	
			{
				selectedDomainLines = value;
			}
		}

		public class DescribeDnsGtmAccessStrategyAvailableConfig_Ipv4AddrPool
		{

			private string id;

			private string name;

			private int? addrCount;

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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public int? AddrCount
			{
				get
				{
					return addrCount;
				}
				set	
				{
					addrCount = value;
				}
			}
		}

		public class DescribeDnsGtmAccessStrategyAvailableConfig_Line
		{

			private string lineCode;

			private string lineName;

			private string groupCode;

			private string groupName;

			private string fatherCode;

			public string LineCode
			{
				get
				{
					return lineCode;
				}
				set	
				{
					lineCode = value;
				}
			}

			public string LineName
			{
				get
				{
					return lineName;
				}
				set	
				{
					lineName = value;
				}
			}

			public string GroupCode
			{
				get
				{
					return groupCode;
				}
				set	
				{
					groupCode = value;
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

			public string FatherCode
			{
				get
				{
					return fatherCode;
				}
				set	
				{
					fatherCode = value;
				}
			}
		}

		public class DescribeDnsGtmAccessStrategyAvailableConfig_Ipv6AddrPool
		{

			private string id;

			private string name;

			private int? addrCount;

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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public int? AddrCount
			{
				get
				{
					return addrCount;
				}
				set	
				{
					addrCount = value;
				}
			}
		}

		public class DescribeDnsGtmAccessStrategyAvailableConfig_DomainAddrPool
		{

			private string id;

			private string name;

			private int? addrCount;

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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public int? AddrCount
			{
				get
				{
					return addrCount;
				}
				set	
				{
					addrCount = value;
				}
			}
		}
	}
}
