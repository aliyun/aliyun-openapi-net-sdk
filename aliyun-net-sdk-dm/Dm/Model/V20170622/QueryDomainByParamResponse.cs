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

namespace Aliyun.Acs.Dm.Model.V20170622
{
	public class QueryDomainByParamResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<QueryDomainByParam_Domain> data;

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

		public List<QueryDomainByParam_Domain> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryDomainByParam_Domain
		{

			private string domainId;

			private string domainName;

			private string domainStatus;

			private string domainRecord;

			private string confirmStatus;

			private string spfAuthStatus;

			private string mxAuthStatus;

			private string createTime;

			private long? utcCreateTime;

			private string cnameAuthStatus;

			private string icpStatus;

			public string DomainId
			{
				get
				{
					return domainId;
				}
				set	
				{
					domainId = value;
				}
			}

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

			public string DomainStatus
			{
				get
				{
					return domainStatus;
				}
				set	
				{
					domainStatus = value;
				}
			}

			public string DomainRecord
			{
				get
				{
					return domainRecord;
				}
				set	
				{
					domainRecord = value;
				}
			}

			public string ConfirmStatus
			{
				get
				{
					return confirmStatus;
				}
				set	
				{
					confirmStatus = value;
				}
			}

			public string SpfAuthStatus
			{
				get
				{
					return spfAuthStatus;
				}
				set	
				{
					spfAuthStatus = value;
				}
			}

			public string MxAuthStatus
			{
				get
				{
					return mxAuthStatus;
				}
				set	
				{
					mxAuthStatus = value;
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

			public long? UtcCreateTime
			{
				get
				{
					return utcCreateTime;
				}
				set	
				{
					utcCreateTime = value;
				}
			}

			public string CnameAuthStatus
			{
				get
				{
					return cnameAuthStatus;
				}
				set	
				{
					cnameAuthStatus = value;
				}
			}

			public string IcpStatus
			{
				get
				{
					return icpStatus;
				}
				set	
				{
					icpStatus = value;
				}
			}
		}
	}
}
