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
	public class DescribeIPv6TranslatorEntriesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeIPv6TranslatorEntries_Ipv6TranslatorEntry> ipv6TranslatorEntries;

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

		public List<DescribeIPv6TranslatorEntries_Ipv6TranslatorEntry> Ipv6TranslatorEntries
		{
			get
			{
				return ipv6TranslatorEntries;
			}
			set	
			{
				ipv6TranslatorEntries = value;
			}
		}

		public class DescribeIPv6TranslatorEntries_Ipv6TranslatorEntry
		{

			private string ipv6TranslatorId;

			private string ipv6TranslatorEntryId;

			private string allocateIpv6Addr;

			private int? allocateIpv6Port;

			private string backendIpv4Addr;

			private string backendIpv4Port;

			private string transProtocol;

			private string entryBandwidth;

			private string entryDescription;

			private string entryName;

			private string entryStatus;

			private string aclStatus;

			private string aclType;

			private string aclId;

			private string regionId;

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

			public string Ipv6TranslatorEntryId
			{
				get
				{
					return ipv6TranslatorEntryId;
				}
				set	
				{
					ipv6TranslatorEntryId = value;
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

			public int? AllocateIpv6Port
			{
				get
				{
					return allocateIpv6Port;
				}
				set	
				{
					allocateIpv6Port = value;
				}
			}

			public string BackendIpv4Addr
			{
				get
				{
					return backendIpv4Addr;
				}
				set	
				{
					backendIpv4Addr = value;
				}
			}

			public string BackendIpv4Port
			{
				get
				{
					return backendIpv4Port;
				}
				set	
				{
					backendIpv4Port = value;
				}
			}

			public string TransProtocol
			{
				get
				{
					return transProtocol;
				}
				set	
				{
					transProtocol = value;
				}
			}

			public string EntryBandwidth
			{
				get
				{
					return entryBandwidth;
				}
				set	
				{
					entryBandwidth = value;
				}
			}

			public string EntryDescription
			{
				get
				{
					return entryDescription;
				}
				set	
				{
					entryDescription = value;
				}
			}

			public string EntryName
			{
				get
				{
					return entryName;
				}
				set	
				{
					entryName = value;
				}
			}

			public string EntryStatus
			{
				get
				{
					return entryStatus;
				}
				set	
				{
					entryStatus = value;
				}
			}

			public string AclStatus
			{
				get
				{
					return aclStatus;
				}
				set	
				{
					aclStatus = value;
				}
			}

			public string AclType
			{
				get
				{
					return aclType;
				}
				set	
				{
					aclType = value;
				}
			}

			public string AclId
			{
				get
				{
					return aclId;
				}
				set	
				{
					aclId = value;
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
