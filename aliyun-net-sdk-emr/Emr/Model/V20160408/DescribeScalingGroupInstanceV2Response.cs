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
	public class DescribeScalingGroupInstanceV2Response : AcsResponse
	{

		private string requestId;

		private string hostGroupId;

		private string scalingGroupId;

		private int? minSize;

		private int? maxSize;

		private int? defaultCooldown;

		private string activeRuleCategory;

		private bool? withGrace;

		private long? timeoutWithGrace;

		private string multiAvailablePolicy;

		private string multiAvailablePolicyParam;

		private List<DescribeScalingGroupInstanceV2_ScalingRule> scalingRuleList;

		private DescribeScalingGroupInstanceV2_ScalingConfig scalingConfig;

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

		public string HostGroupId
		{
			get
			{
				return hostGroupId;
			}
			set	
			{
				hostGroupId = value;
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

		public int? MinSize
		{
			get
			{
				return minSize;
			}
			set	
			{
				minSize = value;
			}
		}

		public int? MaxSize
		{
			get
			{
				return maxSize;
			}
			set	
			{
				maxSize = value;
			}
		}

		public int? DefaultCooldown
		{
			get
			{
				return defaultCooldown;
			}
			set	
			{
				defaultCooldown = value;
			}
		}

		public string ActiveRuleCategory
		{
			get
			{
				return activeRuleCategory;
			}
			set	
			{
				activeRuleCategory = value;
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

		public string MultiAvailablePolicy
		{
			get
			{
				return multiAvailablePolicy;
			}
			set	
			{
				multiAvailablePolicy = value;
			}
		}

		public string MultiAvailablePolicyParam
		{
			get
			{
				return multiAvailablePolicyParam;
			}
			set	
			{
				multiAvailablePolicyParam = value;
			}
		}

		public List<DescribeScalingGroupInstanceV2_ScalingRule> ScalingRuleList
		{
			get
			{
				return scalingRuleList;
			}
			set	
			{
				scalingRuleList = value;
			}
		}

		public DescribeScalingGroupInstanceV2_ScalingConfig ScalingConfig
		{
			get
			{
				return scalingConfig;
			}
			set	
			{
				scalingConfig = value;
			}
		}

		public class DescribeScalingGroupInstanceV2_ScalingRule
		{

			private string ruleCategory;

			private string essScalingRuleId;

			private long? scalingGroupId;

			private string ruleName;

			private string adjustmentType;

			private int? adjustmentValue;

			private int? cooldown;

			private string status;

			private string launchTime;

			private int? launchExpirationTime;

			private string recurrenceType;

			private string recurrenceValue;

			private string recurrenceEndTime;

			private bool? withGrace;

			private long? timeoutWithGrace;

			private DescribeScalingGroupInstanceV2_SchedulerTrigger schedulerTrigger;

			private DescribeScalingGroupInstanceV2_CloudWatchTrigger cloudWatchTrigger;

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

			public string EssScalingRuleId
			{
				get
				{
					return essScalingRuleId;
				}
				set	
				{
					essScalingRuleId = value;
				}
			}

			public long? ScalingGroupId
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

			public string LaunchTime
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

			public string RecurrenceEndTime
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

			public DescribeScalingGroupInstanceV2_SchedulerTrigger SchedulerTrigger
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

			public DescribeScalingGroupInstanceV2_CloudWatchTrigger CloudWatchTrigger
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

			public class DescribeScalingGroupInstanceV2_SchedulerTrigger
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

			public class DescribeScalingGroupInstanceV2_CloudWatchTrigger
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

		public class DescribeScalingGroupInstanceV2_ScalingConfig
		{

			private string spotStrategy;

			private string payType;

			private string dataDiskCategory;

			private int? dataDiskSize;

			private int? dataDiskCount;

			private string sysDiskCategory;

			private int? sysDiskSize;

			private List<DescribeScalingGroupInstanceV2_SpotPriceLimit> spotPriceLimits;

			private List<string> instanceTypeList;

			public string SpotStrategy
			{
				get
				{
					return spotStrategy;
				}
				set	
				{
					spotStrategy = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string DataDiskCategory
			{
				get
				{
					return dataDiskCategory;
				}
				set	
				{
					dataDiskCategory = value;
				}
			}

			public int? DataDiskSize
			{
				get
				{
					return dataDiskSize;
				}
				set	
				{
					dataDiskSize = value;
				}
			}

			public int? DataDiskCount
			{
				get
				{
					return dataDiskCount;
				}
				set	
				{
					dataDiskCount = value;
				}
			}

			public string SysDiskCategory
			{
				get
				{
					return sysDiskCategory;
				}
				set	
				{
					sysDiskCategory = value;
				}
			}

			public int? SysDiskSize
			{
				get
				{
					return sysDiskSize;
				}
				set	
				{
					sysDiskSize = value;
				}
			}

			public List<DescribeScalingGroupInstanceV2_SpotPriceLimit> SpotPriceLimits
			{
				get
				{
					return spotPriceLimits;
				}
				set	
				{
					spotPriceLimits = value;
				}
			}

			public List<string> InstanceTypeList
			{
				get
				{
					return instanceTypeList;
				}
				set	
				{
					instanceTypeList = value;
				}
			}

			public class DescribeScalingGroupInstanceV2_SpotPriceLimit
			{

				private string instanceType;

				private float? priceLimit;

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public float? PriceLimit
				{
					get
					{
						return priceLimit;
					}
					set	
					{
						priceLimit = value;
					}
				}
			}
		}
	}
}
