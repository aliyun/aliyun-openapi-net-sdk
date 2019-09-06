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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeIPv6TranslatorsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeIPv6Translators_Ipv6Translator> ipv6Translators;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeIPv6Translators_Ipv6Translator> Ipv6Translators
		{
			get
			{
				return ipv6Translators;
			}
			set	
			{
				ipv6Translators = value;
			}
		}

		public class DescribeIPv6Translators_Ipv6Translator
		{

			private string ipv6TranslatorId;

			private long? createTime;

			private long? endTime;

			private string spec;

			private string name;

			private string description;

			private string status;

			private string businessStatus;

			private string payType;

			private int? bandwidth;

			private string allocateIpv6Addr;

			private string allocateIpv4Addr;

			private string availableBandwidth;

			private string regionId;

			private List<string> ipv6TranslatorEntryIds;

			public string Ipv6TranslatorId
			{
				get
				{
					return ipv6TranslatorId;
				}
				set	
				{
					ipv6TranslatorId = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
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

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public int? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public string AllocateIpv6Addr
			{
				get
				{
					return allocateIpv6Addr;
				}
				set	
				{
					allocateIpv6Addr = value;
				}
			}

			public string AllocateIpv4Addr
			{
				get
				{
					return allocateIpv4Addr;
				}
				set	
				{
					allocateIpv4Addr = value;
				}
			}

			public string AvailableBandwidth
			{
				get
				{
					return availableBandwidth;
				}
				set	
				{
					availableBandwidth = value;
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

			public List<string> Ipv6TranslatorEntryIds
			{
				get
				{
					return ipv6TranslatorEntryIds;
				}
				set	
				{
					ipv6TranslatorEntryIds = value;
				}
			}
		}
	}
}
