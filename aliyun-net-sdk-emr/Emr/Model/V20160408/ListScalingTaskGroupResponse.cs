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
	public class ListScalingTaskGroupResponse : AcsResponse
	{

		private string requestId;

		private List<ListScalingTaskGroup_Group> groupList;

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

		public List<ListScalingTaskGroup_Group> GroupList
		{
			get
			{
				return groupList;
			}
			set	
			{
				groupList = value;
			}
		}

		public class ListScalingTaskGroup_Group
		{

			private string scalingGroupId;

			private string hostGroupId;

			private int? minSize;

			private int? maxSize;

			private int? defaultCooldown;

			private string activeRuleCategory;

			private string status;

			private string payType;

			private string dataDiskCategory;

			private int? dataDiskSize;

			private int? dataDiskCount;

			private string sysDiskCategory;

			private int? sysDiskSize;

			private int? cpuCount;

			private int? memSize;

			private string spotStrategy;

			private List<ListScalingTaskGroup_SpotPriceLimit> spotPriceLimits;

			private List<ListScalingTaskGroup_ScalingRule> scalingRuleList;

			private List<string> instanceTypeList;

			private ListScalingTaskGroup_ScalingConfig scalingConfig;

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

			public int? CpuCount
			{
				get
				{
					return cpuCount;
				}
				set	
				{
					cpuCount = value;
				}
			}

			public int? MemSize
			{
				get
				{
					return memSize;
				}
				set	
				{
					memSize = value;
				}
			}

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

			public List<ListScalingTaskGroup_SpotPriceLimit> SpotPriceLimits
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

			public List<ListScalingTaskGroup_ScalingRule> ScalingRuleList
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

			public ListScalingTaskGroup_ScalingConfig ScalingConfig
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

			public class ListScalingTaskGroup_SpotPriceLimit
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

			public class ListScalingTaskGroup_ScalingRule
			{

				private string id;

				private string ruleCategory;

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

				private ListScalingTaskGroup_SchedulerTrigger schedulerTrigger;

				private ListScalingTaskGroup_CloudWatchTrigger cloudWatchTrigger;

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

				public ListScalingTaskGroup_SchedulerTrigger SchedulerTrigger
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

				public ListScalingTaskGroup_CloudWatchTrigger CloudWatchTrigger
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

				public class ListScalingTaskGroup_SchedulerTrigger
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

				public class ListScalingTaskGroup_CloudWatchTrigger
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

			public class ListScalingTaskGroup_ScalingConfig
			{

				private string payType;

				private string dataDiskCategory;

				private int? dataDiskSize;

				private int? dataDiskCount;

				private string sysDiskCategory;

				private int? sysDiskSize;

				private int? cpuCount;

				private int? memSize;

				private string spotStrategy;

				private List<ListScalingTaskGroup_SpotPriceLimit3> spotPriceLimits2;

				private List<string> instanceTypeList1;

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

				public int? CpuCount
				{
					get
					{
						return cpuCount;
					}
					set	
					{
						cpuCount = value;
					}
				}

				public int? MemSize
				{
					get
					{
						return memSize;
					}
					set	
					{
						memSize = value;
					}
				}

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

				public List<ListScalingTaskGroup_SpotPriceLimit3> SpotPriceLimits2
				{
					get
					{
						return spotPriceLimits2;
					}
					set	
					{
						spotPriceLimits2 = value;
					}
				}

				public List<string> InstanceTypeList1
				{
					get
					{
						return instanceTypeList1;
					}
					set	
					{
						instanceTypeList1 = value;
					}
				}

				public class ListScalingTaskGroup_SpotPriceLimit3
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
}
