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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeAvailableAdvicesResponse : AcsResponse
	{

		private long? pageNumber;

		private long? pageSize;

		private string requestId;

		private long? totalCount;

		private List<DescribeAvailableAdvices_ItemsItem> items;

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

		public List<DescribeAvailableAdvices_ItemsItem> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeAvailableAdvices_ItemsItem
		{

			private string adviceId;

			private string adviceDate;

			private string adviceType;

			private string sQL;

			private string reason;

			private string benefit;

			private long? totalCount;

			private long? pageSize;

			private long? pageNumber;

			public string AdviceId
			{
				get
				{
					return adviceId;
				}
				set	
				{
					adviceId = value;
				}
			}

			public string AdviceDate
			{
				get
				{
					return adviceDate;
				}
				set	
				{
					adviceDate = value;
				}
			}

			public string AdviceType
			{
				get
				{
					return adviceType;
				}
				set	
				{
					adviceType = value;
				}
			}

			public string SQL
			{
				get
				{
					return sQL;
				}
				set	
				{
					sQL = value;
				}
			}

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}

			public string Benefit
			{
				get
				{
					return benefit;
				}
				set	
				{
					benefit = value;
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
		}
	}
}
