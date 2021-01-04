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
	public class DescribeDnsGtmInstanceAddressPoolsResponse : AcsResponse
	{

		private string requestId;

		private int? totalItems;

		private int? totalPages;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeDnsGtmInstanceAddressPools_AddrPool> addrPools;

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

		public int? TotalItems
		{
			get
			{
				return totalItems;
			}
			set	
			{
				totalItems = value;
			}
		}

		public int? TotalPages
		{
			get
			{
				return totalPages;
			}
			set	
			{
				totalPages = value;
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

		public List<DescribeDnsGtmInstanceAddressPools_AddrPool> AddrPools
		{
			get
			{
				return addrPools;
			}
			set	
			{
				addrPools = value;
			}
		}

		public class DescribeDnsGtmInstanceAddressPools_AddrPool
		{

			private string addrPoolId;

			private string createTime;

			private long? createTimestamp;

			private string updateTime;

			private long? updateTimestamp;

			private int? addrCount;

			private string monitorConfigId;

			private string monitorStatus;

			private string name;

			private string type;

			private string lbaStrategy;

			public string AddrPoolId
			{
				get
				{
					return addrPoolId;
				}
				set	
				{
					addrPoolId = value;
				}
			}

			public string CreateTime
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

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public long? UpdateTimestamp
			{
				get
				{
					return updateTimestamp;
				}
				set	
				{
					updateTimestamp = value;
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

			public string MonitorConfigId
			{
				get
				{
					return monitorConfigId;
				}
				set	
				{
					monitorConfigId = value;
				}
			}

			public string MonitorStatus
			{
				get
				{
					return monitorStatus;
				}
				set	
				{
					monitorStatus = value;
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string LbaStrategy
			{
				get
				{
					return lbaStrategy;
				}
				set	
				{
					lbaStrategy = value;
				}
			}
		}
	}
}
