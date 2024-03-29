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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstancePerformanceResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string dBInstanceId;

		private string engine;

		private string requestId;

		private List<DescribeDBInstancePerformance_PerformanceKey> performanceKeys;

		[JsonProperty(PropertyName = "EndTime")]
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

		[JsonProperty(PropertyName = "StartTime")]
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

		[JsonProperty(PropertyName = "DBInstanceId")]
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

		[JsonProperty(PropertyName = "Engine")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PerformanceKeys")]
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

			private string valueFormat;

			private string unit;

			private List<DescribeDBInstancePerformance_PerformanceValue> values;

			[JsonProperty(PropertyName = "Key")]
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

			[JsonProperty(PropertyName = "ValueFormat")]
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

			[JsonProperty(PropertyName = "Unit")]
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

			[JsonProperty(PropertyName = "Values")]
			public List<DescribeDBInstancePerformance_PerformanceValue> Values
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

			public class DescribeDBInstancePerformance_PerformanceValue
			{

				private string date;

				private string _value;

				[JsonProperty(PropertyName = "Date")]
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

				[JsonProperty(PropertyName = "_Value")]
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
