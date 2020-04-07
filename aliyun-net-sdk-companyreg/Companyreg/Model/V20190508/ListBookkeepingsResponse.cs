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

namespace Aliyun.Acs.companyreg.Model.V20190508
{
	public class ListBookkeepingsResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNumber;

		private int? currentPageNumber;

		private int? pageSize;

		private int? totalPageNumber;

		private List<ListBookkeepings_Bookkeeping> bookkeepings;

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

		public int? TotalItemNumber
		{
			get
			{
				return totalItemNumber;
			}
			set	
			{
				totalItemNumber = value;
			}
		}

		public int? CurrentPageNumber
		{
			get
			{
				return currentPageNumber;
			}
			set	
			{
				currentPageNumber = value;
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

		public int? TotalPageNumber
		{
			get
			{
				return totalPageNumber;
			}
			set	
			{
				totalPageNumber = value;
			}
		}

		public List<ListBookkeepings_Bookkeeping> Bookkeepings
		{
			get
			{
				return bookkeepings;
			}
			set	
			{
				bookkeepings = value;
			}
		}

		public class ListBookkeepings_Bookkeeping
		{

			private string bizId;

			private string companyName;

			private string orderId;

			private int? status;

			private bool? renew;

			private string note;

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string CompanyName
			{
				get
				{
					return companyName;
				}
				set	
				{
					companyName = value;
				}
			}

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public int? Status
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

			public bool? Renew
			{
				get
				{
					return renew;
				}
				set	
				{
					renew = value;
				}
			}

			public string Note
			{
				get
				{
					return note;
				}
				set	
				{
					note = value;
				}
			}
		}
	}
}
