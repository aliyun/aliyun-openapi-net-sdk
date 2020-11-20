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

namespace Aliyun.Acs.Ess.Model.V20140828
{
	public class DescribeAlarmsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeAlarms_Alarm> alarmList;

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

		public List<DescribeAlarms_Alarm> AlarmList
		{
			get
			{
				return alarmList;
			}
			set	
			{
				alarmList = value;
			}
		}

		public class DescribeAlarms_Alarm
		{

			private string alarmTaskId;

			private string name;

			private string description;

			private string metricType;

			private string metricName;

			private int? period;

			private string statistics;

			private string comparisonOperator;

			private float? threshold;

			private int? evaluationCount;

			private string state;

			private string scalingGroupId;

			private bool? enable;

			private string effective;

			private List<DescribeAlarms_Dimension> dimensions;

			private List<string> alarmActions;

			public string AlarmTaskId
			{
				get
				{
					return alarmTaskId;
				}
				set	
				{
					alarmTaskId = value;
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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string MetricType
			{
				get
				{
					return metricType;
				}
				set	
				{
					metricType = value;
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

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string Statistics
			{
				get
				{
					return statistics;
				}
				set	
				{
					statistics = value;
				}
			}

			public string ComparisonOperator
			{
				get
				{
					return comparisonOperator;
				}
				set	
				{
					comparisonOperator = value;
				}
			}

			public float? Threshold
			{
				get
				{
					return threshold;
				}
				set	
				{
					threshold = value;
				}
			}

			public int? EvaluationCount
			{
				get
				{
					return evaluationCount;
				}
				set	
				{
					evaluationCount = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string ScalingGroupId
			{
				get
				{
					return scalingGroupId;
				}
				set	
				{
					scalingGroupId = value;
				}
			}

			public bool? Enable
			{
				get
				{
					return enable;
				}
				set	
				{
					enable = value;
				}
			}

			public string Effective
			{
				get
				{
					return effective;
				}
				set	
				{
					effective = value;
				}
			}

			public List<DescribeAlarms_Dimension> Dimensions
			{
				get
				{
					return dimensions;
				}
				set	
				{
					dimensions = value;
				}
			}

			public List<string> AlarmActions
			{
				get
				{
					return alarmActions;
				}
				set	
				{
					alarmActions = value;
				}
			}

			public class DescribeAlarms_Dimension
			{

				private string dimensionKey;

				private string dimensionValue;

				public string DimensionKey
				{
					get
					{
						return dimensionKey;
					}
					set	
					{
						dimensionKey = value;
					}
				}

				public string DimensionValue
				{
					get
					{
						return dimensionValue;
					}
					set	
					{
						dimensionValue = value;
					}
				}
			}
		}
	}
}
