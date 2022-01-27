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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeInstancePerformanceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string message;

		private DescribeInstancePerformance_Data data;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public DescribeInstancePerformance_Data Data
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

		public class DescribeInstancePerformance_Data
		{

			private List<DescribeInstancePerformance_PerformanceItem> performanceItems;

			public List<DescribeInstancePerformance_PerformanceItem> PerformanceItems
			{
				get
				{
					return performanceItems;
				}
				set	
				{
					performanceItems = value;
				}
			}

			public class DescribeInstancePerformance_PerformanceItem
			{

				private string measurement;

				private string metricName;

				private List<DescribeInstancePerformance_Point> points;

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

				public List<DescribeInstancePerformance_Point> Points
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

				public class DescribeInstancePerformance_Point
				{

					private long? timestamp;

					private string _value;

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
				}
			}
		}
	}
}
