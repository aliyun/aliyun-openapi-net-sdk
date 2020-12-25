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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeScalingRuleResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string gmtCreate;

		private string gmtModified;

		private string ruleName;

		private string ruleCategory;

		private string adjustmentType;

		private int? adjustmentValue;

		private int? cooldown;

		private string status;

		private bool? withGrace;

		private long? timeoutWithGrace;

		private DescribeScalingRule_SchedulerTrigger schedulerTrigger;

		private DescribeScalingRule_CloudWatchTrigger cloudWatchTrigger;

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

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
			}
		}

		public string GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
			}
		}

		public string GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
			}
		}

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
			}
		}

		public string RuleCategory
		{
			get
			{
				return ruleCategory;
			}
			set	
			{
				ruleCategory = value;
			}
		}

		public string AdjustmentType
		{
			get
			{
				return adjustmentType;
			}
			set	
			{
				adjustmentType = value;
			}
		}

		public int? AdjustmentValue
		{
			get
			{
				return adjustmentValue;
			}
			set	
			{
				adjustmentValue = value;
			}
		}

		public int? Cooldown
		{
			get
			{
				return cooldown;
			}
			set	
			{
				cooldown = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public bool? WithGrace
		{
			get
			{
				return withGrace;
			}
			set	
			{
				withGrace = value;
			}
		}

		public long? TimeoutWithGrace
		{
			get
			{
				return timeoutWithGrace;
			}
			set	
			{
				timeoutWithGrace = value;
			}
		}

		public DescribeScalingRule_SchedulerTrigger SchedulerTrigger
		{
			get
			{
				return schedulerTrigger;
			}
			set	
			{
				schedulerTrigger = value;
			}
		}

		public DescribeScalingRule_CloudWatchTrigger CloudWatchTrigger
		{
			get
			{
				return cloudWatchTrigger;
			}
			set	
			{
				cloudWatchTrigger = value;
			}
		}

		public class DescribeScalingRule_SchedulerTrigger
		{

			private long? launchTime;

			private int? launchExpirationTime;

			private string recurrenceType;

			private string recurrenceValue;

			private long? recurrenceEndTime;

			public long? LaunchTime
			{
				get
				{
					return launchTime;
				}
				set	
				{
					launchTime = value;
				}
			}

			public int? LaunchExpirationTime
			{
				get
				{
					return launchExpirationTime;
				}
				set	
				{
					launchExpirationTime = value;
				}
			}

			public string RecurrenceType
			{
				get
				{
					return recurrenceType;
				}
				set	
				{
					recurrenceType = value;
				}
			}

			public string RecurrenceValue
			{
				get
				{
					return recurrenceValue;
				}
				set	
				{
					recurrenceValue = value;
				}
			}

			public long? RecurrenceEndTime
			{
				get
				{
					return recurrenceEndTime;
				}
				set	
				{
					recurrenceEndTime = value;
				}
			}
		}

		public class DescribeScalingRule_CloudWatchTrigger
		{

			private string metricName;

			private int? period;

			private string statistics;

			private string comparisonOperator;

			private string threshold;

			private string evaluationCount;

			private string unit;

			private string metricDisplayName;

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

			public string Threshold
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

			public string EvaluationCount
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

			public string MetricDisplayName
			{
				get
				{
					return metricDisplayName;
				}
				set	
				{
					metricDisplayName = value;
				}
			}
		}
	}
}
