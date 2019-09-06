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
	public class DescribeSnatTableEntriesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeSnatTableEntries_SnatTableEntry> snatTableEntries;

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

		public List<DescribeSnatTableEntries_SnatTableEntry> SnatTableEntries
		{
			get
			{
				return snatTableEntries;
			}
			set	
			{
				snatTableEntries = value;
			}
		}

		public class DescribeSnatTableEntries_SnatTableEntry
		{

			private string snatTableId;

			private string snatEntryId;

			private string sourceVSwitchId;

			private string sourceCIDR;

			private string snatIp;

			private string status;

			private string snatEntryName;

			public string SnatTableId
			{
				get
				{
					return snatTableId;
				}
				set	
				{
					snatTableId = value;
				}
			}

			public string SnatEntryId
			{
				get
				{
					return snatEntryId;
				}
				set	
				{
					snatEntryId = value;
				}
			}

			public string SourceVSwitchId
			{
				get
				{
					return sourceVSwitchId;
				}
				set	
				{
					sourceVSwitchId = value;
				}
			}

			public string SourceCIDR
			{
				get
				{
					return sourceCIDR;
				}
				set	
				{
					sourceCIDR = value;
				}
			}

			public string SnatIp
			{
				get
				{
					return snatIp;
				}
				set	
				{
					snatIp = value;
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

			public string SnatEntryName
			{
				get
				{
					return snatEntryName;
				}
				set	
				{
					snatEntryName = value;
				}
			}
		}
	}
}
