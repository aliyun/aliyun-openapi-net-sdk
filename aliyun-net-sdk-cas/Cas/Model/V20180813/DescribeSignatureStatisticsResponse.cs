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

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeSignatureStatisticsResponse : AcsResponse
	{

		private string requestId;

		private int? unSignCount;

		private int? signCount;

		private int? failCount;

		private List<DescribeSignatureStatistics_DayData> dayDataList;

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

		public int? UnSignCount
		{
			get
			{
				return unSignCount;
			}
			set	
			{
				unSignCount = value;
			}
		}

		public int? SignCount
		{
			get
			{
				return signCount;
			}
			set	
			{
				signCount = value;
			}
		}

		public int? FailCount
		{
			get
			{
				return failCount;
			}
			set	
			{
				failCount = value;
			}
		}

		public List<DescribeSignatureStatistics_DayData> DayDataList
		{
			get
			{
				return dayDataList;
			}
			set	
			{
				dayDataList = value;
			}
		}

		public class DescribeSignatureStatistics_DayData
		{

			private string date;

			private int? unSignCount;

			private int? signCount;

			private int? failCount;

			public string Date
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

			public int? UnSignCount
			{
				get
				{
					return unSignCount;
				}
				set	
				{
					unSignCount = value;
				}
			}

			public int? SignCount
			{
				get
				{
					return signCount;
				}
				set	
				{
					signCount = value;
				}
			}

			public int? FailCount
			{
				get
				{
					return failCount;
				}
				set	
				{
					failCount = value;
				}
			}
		}
	}
}
