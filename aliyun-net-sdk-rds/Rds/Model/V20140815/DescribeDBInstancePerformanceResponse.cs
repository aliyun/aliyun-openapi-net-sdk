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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstancePerformanceResponse : AcsResponse
	{

		private string dBInstanceId;

		private string engine;

		private string startTime;

		private string endTime;

		private List<PerformanceKey> performanceKeys;

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

		public List<PerformanceKey> PerformanceKeys
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

		public class PerformanceKey{

			private string key;

			private string unit;

			private string valueFormat;

			private List<PerformanceValue> values;

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

			public List<PerformanceValue> Values
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

			public class PerformanceValue{

				private string value_;

				private string date;

				public string Value
				{
					get
					{
						return value_;
					}
					set	
					{
						value_ = value;
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