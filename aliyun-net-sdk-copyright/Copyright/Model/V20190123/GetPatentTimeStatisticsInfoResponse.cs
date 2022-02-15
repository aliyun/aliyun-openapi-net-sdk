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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class GetPatentTimeStatisticsInfoResponse : AcsResponse
	{

		private int? pageNum;

		private string requestId;

		private bool? success;

		private int? totalItemNum;

		private int? pageSize;

		private int? totalPageNum;

		private List<GetPatentTimeStatisticsInfo_DataItem> data;

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public List<GetPatentTimeStatisticsInfo_DataItem> Data
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

		public class GetPatentTimeStatisticsInfo_DataItem
		{

			private string type;

			private long? halfMonthCount;

			private long? monthCount;

			private long? twoMonthCount;

			private long? threeMonthCount;

			private long? expiredCount;

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

			public long? HalfMonthCount
			{
				get
				{
					return halfMonthCount;
				}
				set	
				{
					halfMonthCount = value;
				}
			}

			public long? MonthCount
			{
				get
				{
					return monthCount;
				}
				set	
				{
					monthCount = value;
				}
			}

			public long? TwoMonthCount
			{
				get
				{
					return twoMonthCount;
				}
				set	
				{
					twoMonthCount = value;
				}
			}

			public long? ThreeMonthCount
			{
				get
				{
					return threeMonthCount;
				}
				set	
				{
					threeMonthCount = value;
				}
			}

			public long? ExpiredCount
			{
				get
				{
					return expiredCount;
				}
				set	
				{
					expiredCount = value;
				}
			}
		}
	}
}
