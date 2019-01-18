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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeDBInstancePerformanceResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private string engine;

		private string startTime;

		private string endTime;

		private List<DescribeDBInstancePerformance_PerformanceKey> performanceKeys;

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

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
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

		public List<DescribeDBInstancePerformance_PerformanceKey> PerformanceKeys
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

		public class DescribeDBInstancePerformance_PerformanceKey
		{

			private string key;

			private string unit;

			private string valueFormat;

			private List<DescribeDBInstancePerformance_PerformanceValue> performanceValues;

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

			public string ValueFormat
			{
				get
				{
					return valueFormat;
				}
				set	
				{
					valueFormat = value;
				}
			}

			public List<DescribeDBInstancePerformance_PerformanceValue> PerformanceValues
			{
				get
				{
					return performanceValues;
				}
				set	
				{
					performanceValues = value;
				}
			}

			public class DescribeDBInstancePerformance_PerformanceValue
			{

				private string _value;

				private string date;

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
			}
		}
	}
}