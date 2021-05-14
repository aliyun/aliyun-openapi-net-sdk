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
	public class DescribeRDSPerformanceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeRDSPerformance_PartialPerformanceData> data;

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

		public List<DescribeRDSPerformance_PartialPerformanceData> Data
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

		public class DescribeRDSPerformance_PartialPerformanceData
		{

			private string key;

			private string unit;

			private int? nodeNum;

			private string nodeName;

			private List<DescribeRDSPerformance_PerformanceValue> values;

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

			public string NodeName
			{
				get
				{
					return nodeName;
				}
				set	
				{
					nodeName = value;
				}
			}

			public List<DescribeRDSPerformance_PerformanceValue> Values
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

			public class DescribeRDSPerformance_PerformanceValue
			{

				private string _value;

				private long? date;

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
			}
		}
	}
}
