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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeDomainSlowRatioResponse : AcsResponse
	{

		private string endTime;

		private int? dataInterval;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private string startTime;

		private List<DescribeDomainSlowRatio_SlowRatioData> slowRatioDataPerInterval;

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public int? DataInterval
		{
			get
			{
				return dataInterval;
			}
			set	
			{
				dataInterval = value;
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

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public List<DescribeDomainSlowRatio_SlowRatioData> SlowRatioDataPerInterval
		{
			get
			{
				return slowRatioDataPerInterval;
			}
			set	
			{
				slowRatioDataPerInterval = value;
			}
		}

		public class DescribeDomainSlowRatio_SlowRatioData
		{

			private int? totalUsers;

			private int? slowUsers;

			private float? slowRatio;

			private string regionNameZh;

			private string regionNameEn;

			private string ispNameZh;

			private string ispNameEn;

			private string time;

			public int? TotalUsers
			{
				get
				{
					return totalUsers;
				}
				set	
				{
					totalUsers = value;
				}
			}

			public int? SlowUsers
			{
				get
				{
					return slowUsers;
				}
				set	
				{
					slowUsers = value;
				}
			}

			public float? SlowRatio
			{
				get
				{
					return slowRatio;
				}
				set	
				{
					slowRatio = value;
				}
			}

			public string RegionNameZh
			{
				get
				{
					return regionNameZh;
				}
				set	
				{
					regionNameZh = value;
				}
			}

			public string RegionNameEn
			{
				get
				{
					return regionNameEn;
				}
				set	
				{
					regionNameEn = value;
				}
			}

			public string IspNameZh
			{
				get
				{
					return ispNameZh;
				}
				set	
				{
					ispNameZh = value;
				}
			}

			public string IspNameEn
			{
				get
				{
					return ispNameEn;
				}
				set	
				{
					ispNameEn = value;
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
		}
	}
}