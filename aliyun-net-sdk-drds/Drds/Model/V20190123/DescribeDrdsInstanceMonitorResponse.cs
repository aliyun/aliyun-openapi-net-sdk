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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsInstanceMonitorResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDrdsInstanceMonitor_PartialPerformanceData> data;

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

		public List<DescribeDrdsInstanceMonitor_PartialPerformanceData> Data
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

		public class DescribeDrdsInstanceMonitor_PartialPerformanceData
		{

			private string key;

			private string unit;

			private int? nodeNum;

			private List<DescribeDrdsInstanceMonitor_PerformanceValue> values;

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

			public int? NodeNum
			{
				get
				{
					return nodeNum;
				}
				set	
				{
					nodeNum = value;
				}
			}

			public List<DescribeDrdsInstanceMonitor_PerformanceValue> Values
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

			public class DescribeDrdsInstanceMonitor_PerformanceValue
			{

				private long? date;

				private string _value;

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
