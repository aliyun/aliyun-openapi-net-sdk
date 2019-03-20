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
	public class DescribeDomainRecordsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeDomainRecords_Record> domainRecords;

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

		public long? TotalCount
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

		public long? PageNumber
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

		public long? PageSize
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

		public List<DescribeDomainRecords_Record> DomainRecords
		{
			get
			{
				return domainRecords;
			}
			set	
			{
				domainRecords = value;
			}
		}

		public class DescribeDomainRecords_Record
		{

			private string domainName;

			private string recordId;

			private string rR;

			private string type;

			private string _value;

			private long? tTL;

			private long? priority;

			private string line;

			private string status;

			private bool? locked;

			private int? weight;

			private string remark;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string RecordId
			{
				get
				{
					return recordId;
				}
				set	
				{
					recordId = value;
				}
			}

			public string RR
			{
				get
				{
					return rR;
				}
				set	
				{
					rR = value;
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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			public long? TTL
			{
				get
				{
					return tTL;
				}
				set	
				{
					tTL = value;
				}
			}

			public long? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string Line
			{
				get
				{
					return line;
				}
				set	
				{
					line = value;
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

			public bool? Locked
			{
				get
				{
					return locked;
				}
				set	
				{
					locked = value;
				}
			}

			public int? Weight
			{
				get
				{
					return weight;
				}
				set	
				{
					weight = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}
		}
	}
}
