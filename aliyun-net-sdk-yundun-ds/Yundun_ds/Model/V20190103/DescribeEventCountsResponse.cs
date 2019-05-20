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
	public class DescribeEventCountsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeEventCounts_EventCount> eventCountList;

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

		public List<DescribeEventCounts_EventCount> EventCountList
		{
			get
			{
				return eventCountList;
			}
			set	
			{
				eventCountList = value;
			}
		}

		public class DescribeEventCounts_EventCount
		{

			private string typeCode;

			private string typeName;

			private long? date;

			private DescribeEventCounts_Total total;

			private DescribeEventCounts_LastDay lastDay;

			private DescribeEventCounts_LastWeek lastWeek;

			private DescribeEventCounts_LastMonth lastMonth;

			public string TypeCode
			{
				get
				{
					return typeCode;
				}
				set	
				{
					typeCode = value;
				}
			}

			public string TypeName
			{
				get
				{
					return typeName;
				}
				set	
				{
					typeName = value;
				}
			}

			public long? Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public DescribeEventCounts_Total Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public DescribeEventCounts_LastDay LastDay
			{
				get
				{
					return lastDay;
				}
				set	
				{
					lastDay = value;
				}
			}

			public DescribeEventCounts_LastWeek LastWeek
			{
				get
				{
					return lastWeek;
				}
				set	
				{
					lastWeek = value;
				}
			}

			public DescribeEventCounts_LastMonth LastMonth
			{
				get
				{
					return lastMonth;
				}
				set	
				{
					lastMonth = value;
				}
			}

			public class DescribeEventCounts_Total
			{

				private long? totalCount;

				private long? undealCount;

				private long? confirmCount;

				private long? excludeCount;

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

				public long? UndealCount
				{
					get
					{
						return undealCount;
					}
					set	
					{
						undealCount = value;
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

				public long? ExcludeCount
				{
					get
					{
						return excludeCount;
					}
					set	
					{
						excludeCount = value;
					}
				}
			}

			public class DescribeEventCounts_LastDay
			{

				private long? totalCount;

				private long? undealCount;

				private long? confirmCount;

				private long? excludeCount;

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

				public long? UndealCount
				{
					get
					{
						return undealCount;
					}
					set	
					{
						undealCount = value;
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

				public long? ExcludeCount
				{
					get
					{
						return excludeCount;
					}
					set	
					{
						excludeCount = value;
					}
				}
			}

			public class DescribeEventCounts_LastWeek
			{

				private long? totalCount;

				private long? undealCount;

				private long? confirmCount;

				private long? excludeCount;

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

				public long? UndealCount
				{
					get
					{
						return undealCount;
					}
					set	
					{
						undealCount = value;
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

				public long? ExcludeCount
				{
					get
					{
						return excludeCount;
					}
					set	
					{
						excludeCount = value;
					}
				}
			}

			public class DescribeEventCounts_LastMonth
			{

				private long? totalCount;

				private long? undealCount;

				private long? confirmCount;

				private long? excludeCount;

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

				public long? UndealCount
				{
					get
					{
						return undealCount;
					}
					set	
					{
						undealCount = value;
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

				public long? ExcludeCount
				{
					get
					{
						return excludeCount;
					}
					set	
					{
						excludeCount = value;
					}
				}
			}
		}
	}
}
