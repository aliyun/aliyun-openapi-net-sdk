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

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
	public class DescribeDepartCountsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeDepartCounts_DepartCount> items;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<DescribeDepartCounts_DepartCount> Items
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

		public class DescribeDepartCounts_DepartCount
		{

			private string departName;

			private long? departCount;

			private long? count;

			private long? userCount;

			private long? dtCount;

			private long? subCount;

			private long? sensitiveCount;

			private long? eventTotalCount;

			private long? confirmCount;

			private long? userConfirmCount;

			private long? lastEventCount;

			private long? topSubTypeName;

			private long? topDisplayName;

			public string DepartName
			{
				get
				{
					return departName;
				}
				set	
				{
					departName = value;
				}
			}

			public long? DepartCount
			{
				get
				{
					return departCount;
				}
				set	
				{
					departCount = value;
				}
			}

			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public long? UserCount
			{
				get
				{
					return userCount;
				}
				set	
				{
					userCount = value;
				}
			}

			public long? DtCount
			{
				get
				{
					return dtCount;
				}
				set	
				{
					dtCount = value;
				}
			}

			public long? SubCount
			{
				get
				{
					return subCount;
				}
				set	
				{
					subCount = value;
				}
			}

			public long? SensitiveCount
			{
				get
				{
					return sensitiveCount;
				}
				set	
				{
					sensitiveCount = value;
				}
			}

			public long? EventTotalCount
			{
				get
				{
					return eventTotalCount;
				}
				set	
				{
					eventTotalCount = value;
				}
			}

			public long? ConfirmCount
			{
				get
				{
					return confirmCount;
				}
				set	
				{
					confirmCount = value;
				}
			}

			public long? UserConfirmCount
			{
				get
				{
					return userConfirmCount;
				}
				set	
				{
					userConfirmCount = value;
				}
			}

			public long? LastEventCount
			{
				get
				{
					return lastEventCount;
				}
				set	
				{
					lastEventCount = value;
				}
			}

			public long? TopSubTypeName
			{
				get
				{
					return topSubTypeName;
				}
				set	
				{
					topSubTypeName = value;
				}
			}

			public long? TopDisplayName
			{
				get
				{
					return topDisplayName;
				}
				set	
				{
					topDisplayName = value;
				}
			}
		}
	}
}
