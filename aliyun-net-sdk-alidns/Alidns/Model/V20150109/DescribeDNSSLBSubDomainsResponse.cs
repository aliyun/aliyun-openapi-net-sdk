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
	public class DescribeDNSSLBSubDomainsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeDNSSLBSubDomains_SlbSubDomain> slbSubDomains;

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

		public List<DescribeDNSSLBSubDomains_SlbSubDomain> SlbSubDomains
		{
			get
			{
				return slbSubDomains;
			}
			set	
			{
				slbSubDomains = value;
			}
		}

		public class DescribeDNSSLBSubDomains_SlbSubDomain
		{

			private string subDomain;

			private long? recordCount;

			private bool? open;

			private string type;

			private List<DescribeDNSSLBSubDomains_LineAlgorithm> lineAlgorithms;

			public string SubDomain
			{
				get
				{
					return subDomain;
				}
				set	
				{
					subDomain = value;
				}
			}

			public long? RecordCount
			{
				get
				{
					return recordCount;
				}
				set	
				{
					recordCount = value;
				}
			}

			public bool? Open
			{
				get
				{
					return open;
				}
				set	
				{
					open = value;
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

			public List<DescribeDNSSLBSubDomains_LineAlgorithm> LineAlgorithms
			{
				get
				{
					return lineAlgorithms;
				}
				set	
				{
					lineAlgorithms = value;
				}
			}

			public class DescribeDNSSLBSubDomains_LineAlgorithm
			{

				private string line;

				private bool? open;

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

				public bool? Open
				{
					get
					{
						return open;
					}
					set	
					{
						open = value;
					}
				}
			}
		}
	}
}
