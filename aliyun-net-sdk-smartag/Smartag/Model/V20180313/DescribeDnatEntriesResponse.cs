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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeDnatEntriesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeDnatEntries_DnatEntry> dnatEntries;

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

		public List<DescribeDnatEntries_DnatEntry> DnatEntries
		{
			get
			{
				return dnatEntries;
			}
			set	
			{
				dnatEntries = value;
			}
		}

		public class DescribeDnatEntries_DnatEntry
		{

			private string dnatEntryId;

			private string type;

			private string sagId;

			private string externalIp;

			private string externalPort;

			private string internalIp;

			private string ipProtocol;

			private string internalPort;

			public string DnatEntryId
			{
				get
				{
					return dnatEntryId;
				}
				set	
				{
					dnatEntryId = value;
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

			public string SagId
			{
				get
				{
					return sagId;
				}
				set	
				{
					sagId = value;
				}
			}

			public string ExternalIp
			{
				get
				{
					return externalIp;
				}
				set	
				{
					externalIp = value;
				}
			}

			public string ExternalPort
			{
				get
				{
					return externalPort;
				}
				set	
				{
					externalPort = value;
				}
			}

			public string InternalIp
			{
				get
				{
					return internalIp;
				}
				set	
				{
					internalIp = value;
				}
			}

			public string IpProtocol
			{
				get
				{
					return ipProtocol;
				}
				set	
				{
					ipProtocol = value;
				}
			}

			public string InternalPort
			{
				get
				{
					return internalPort;
				}
				set	
				{
					internalPort = value;
				}
			}
		}
	}
}
