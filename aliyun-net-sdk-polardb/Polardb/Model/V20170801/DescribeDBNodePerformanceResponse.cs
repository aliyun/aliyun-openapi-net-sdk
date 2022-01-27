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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBNodePerformanceResponse : AcsResponse
	{

		private string dBVersion;

		private string endTime;

		private string requestId;

		private string startTime;

		private string dBType;

		private string dBNodeId;

		private string engine;

		private List<DescribeDBNodePerformance_PerformanceItem> performanceKeys;

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
			}
		}

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

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
			}
		}

		public string DBNodeId
		{
			get
			{
				return dBNodeId;
			}
			set	
			{
				dBNodeId = value;
			}
		}

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
			}
		}

		public List<DescribeDBNodePerformance_PerformanceItem> PerformanceKeys
		{
			get
			{
				return performanceKeys;
			}
			set	
			{
				performanceKeys = value;
			}
		}

		public class DescribeDBNodePerformance_PerformanceItem
		{

			private string metricName;

			private string measurement;

			private List<DescribeDBNodePerformance_PerformanceItemValue> points;

			public string MetricName
			{
				get
				{
					return metricName;
				}
				set	
				{
					metricName = value;
				}
			}

			public string Measurement
			{
				get
				{
					return measurement;
				}
				set	
				{
					measurement = value;
				}
			}

			public List<DescribeDBNodePerformance_PerformanceItemValue> Points
			{
				get
				{
					return points;
				}
				set	
				{
					points = value;
				}
			}

			public class DescribeDBNodePerformance_PerformanceItemValue
			{

				private string _value;

				private long? timestamp;

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public long? Timestamp
				{
					get
					{
						return timestamp;
					}
					set	
					{
						timestamp = value;
					}
				}
			}
		}
	}
}
