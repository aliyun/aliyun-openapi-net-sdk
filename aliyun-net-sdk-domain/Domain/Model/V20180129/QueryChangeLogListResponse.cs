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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryChangeLogListResponse : AcsResponse
	{

		private bool? prePage;

		private int? currentPageNum;

		private string requestId;

		private int? pageSize;

		private int? totalPageNum;

		private bool? resultLimit;

		private int? totalItemNum;

		private bool? nextPage;

		private List<QueryChangeLogList_ChangeLog> data;

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
			}
		}

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

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public bool? ResultLimit
		{
			get
			{
				return resultLimit;
			}
			set	
			{
				resultLimit = value;
			}
		}

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
			}
		}

		public List<QueryChangeLogList_ChangeLog> Data
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

		public class QueryChangeLogList_ChangeLog
		{

			private string operation;

			private string time;

			private string result;

			private string domainName;

			private string operationIPAddress;

			private string details;

			public string Operation
			{
				get
				{
					return operation;
				}
				set	
				{
					operation = value;
				}
			}

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public string Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
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

			public string OperationIPAddress
			{
				get
				{
					return operationIPAddress;
				}
				set	
				{
					operationIPAddress = value;
				}
			}

			public string Details
			{
				get
				{
					return details;
				}
				set	
				{
					details = value;
				}
			}
		}
	}
}
