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

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
	public class DescribeDBClusterPerformanceResponse : AcsResponse
	{

		private string endTime;

		private string requestId;

		private string startTime;

		private string dBClusterId;

		private List<DescribeDBClusterPerformance_PerformanceItem> performances;

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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public List<DescribeDBClusterPerformance_PerformanceItem> Performances
		{
			get
			{
				return performances;
			}
			set	
			{
				performances = value;
			}
		}

		public class DescribeDBClusterPerformance_PerformanceItem
		{

			private string key;

			private string unit;

			private string name;

			private List<DescribeDBClusterPerformance_SeriesItem> series;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Unit
			{
				get
				{
					return unit;
				}
				set	
				{
					unit = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public List<DescribeDBClusterPerformance_SeriesItem> Series
			{
				get
				{
					return series;
				}
				set	
				{
					series = value;
				}
			}

			public class DescribeDBClusterPerformance_SeriesItem
			{

				private string name;

				private List<DescribeDBClusterPerformance_ValueItem> values;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public List<DescribeDBClusterPerformance_ValueItem> Values
				{
					get
					{
						return values;
					}
					set	
					{
						values = value;
					}
				}

				public class DescribeDBClusterPerformance_ValueItem
				{

					private List<string> point;

					public List<string> Point
					{
						get
						{
							return point;
						}
						set	
						{
							point = value;
						}
					}
				}
			}
		}
	}
}
