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
	public class DescribeScalingRulesResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<DescribeScalingRules_ScalingRule> scalingRules;

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

		public List<DescribeScalingRules_ScalingRule> ScalingRules
		{
			get
			{
				return scalingRules;
			}
			set	
			{
				scalingRules = value;
			}
		}

		public class DescribeScalingRules_ScalingRule
		{

			private string scalingRuleId;

			private string scalingGroupId;

			private string scalingRuleName;

			private int? cooldown;

			private int? minAdjustmentMagnitude;

			private string adjustmentType;

			private int? adjustmentValue;

			private int? minSize;

			private int? maxSize;

			private string scalingRuleAri;

			private string scalingRuleType;

			private int? estimatedInstanceWarmup;

			private string metricName;

			private float? targetValue;

			private bool? disableScaleIn;

			private int? scaleInEvaluationCount;

			private int? scaleOutEvaluationCount;

			private string predictiveScalingMode;

			private string predictiveValueBehavior;

			private int? predictiveValueBuffer;

			private int? predictiveTaskBufferTime;

			private int? initialMaxSize;

			private List<DescribeScalingRules_Alarm> alarms;

			private List<DescribeScalingRules_StepAdjustment> stepAdjustments;

			public string ScalingRuleId
			{
				get
				{
					return scalingRuleId;
				}
				set	
				{
					scalingRuleId = value;
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

			public string ScalingRuleName
			{
				get
				{
					return scalingRuleName;
				}
				set	
				{
					scalingRuleName = value;
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

			public int? MinAdjustmentMagnitude
			{
				get
				{
					return minAdjustmentMagnitude;
				}
				set	
				{
					minAdjustmentMagnitude = value;
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

			public string ScalingRuleAri
			{
				get
				{
					return scalingRuleAri;
				}
				set	
				{
					scalingRuleAri = value;
				}
			}

			public string ScalingRuleType
			{
				get
				{
					return scalingRuleType;
				}
				set	
				{
					scalingRuleType = value;
				}
			}

			public int? EstimatedInstanceWarmup
			{
				get
				{
					return estimatedInstanceWarmup;
				}
				set	
				{
					estimatedInstanceWarmup = value;
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

			public float? TargetValue
			{
				get
				{
					return targetValue;
				}
				set	
				{
					targetValue = value;
				}
			}

			public bool? DisableScaleIn
			{
				get
				{
					return disableScaleIn;
				}
				set	
				{
					disableScaleIn = value;
				}
			}

			public int? ScaleInEvaluationCount
			{
				get
				{
					return scaleInEvaluationCount;
				}
				set	
				{
					scaleInEvaluationCount = value;
				}
			}

			public int? ScaleOutEvaluationCount
			{
				get
				{
					return scaleOutEvaluationCount;
				}
				set	
				{
					scaleOutEvaluationCount = value;
				}
			}

			public string PredictiveScalingMode
			{
				get
				{
					return predictiveScalingMode;
				}
				set	
				{
					predictiveScalingMode = value;
				}
			}

			public string PredictiveValueBehavior
			{
				get
				{
					return predictiveValueBehavior;
				}
				set	
				{
					predictiveValueBehavior = value;
				}
			}

			public int? PredictiveValueBuffer
			{
				get
				{
					return predictiveValueBuffer;
				}
				set	
				{
					predictiveValueBuffer = value;
				}
			}

			public int? PredictiveTaskBufferTime
			{
				get
				{
					return predictiveTaskBufferTime;
				}
				set	
				{
					predictiveTaskBufferTime = value;
				}
			}

			public int? InitialMaxSize
			{
				get
				{
					return initialMaxSize;
				}
				set	
				{
					initialMaxSize = value;
				}
			}

			public List<DescribeScalingRules_Alarm> Alarms
			{
				get
				{
					return alarms;
				}
				set	
				{
					alarms = value;
				}
			}

			public List<DescribeScalingRules_StepAdjustment> StepAdjustments
			{
				get
				{
					return stepAdjustments;
				}
				set	
				{
					stepAdjustments = value;
				}
			}

			public class DescribeScalingRules_Alarm
			{

				private string alarmTaskName;

				private string alarmTaskId;

				private string comparisonOperator;

				private string statistics;

				private string metricName;

				private float? threshold;

				private int? evaluationCount;

				private List<DescribeScalingRules_Dimension> dimensions;

				public string AlarmTaskName
				{
					get
					{
						return alarmTaskName;
					}
					set	
					{
						alarmTaskName = value;
					}
				}

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

				public List<DescribeScalingRules_Dimension> Dimensions
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

				public class DescribeScalingRules_Dimension
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

			public class DescribeScalingRules_StepAdjustment
			{

				private float? metricIntervalLowerBound;

				private float? metricIntervalUpperBound;

				private int? scalingAdjustment;

				public float? MetricIntervalLowerBound
				{
					get
					{
						return metricIntervalLowerBound;
					}
					set	
					{
						metricIntervalLowerBound = value;
					}
				}

				public float? MetricIntervalUpperBound
				{
					get
					{
						return metricIntervalUpperBound;
					}
					set	
					{
						metricIntervalUpperBound = value;
					}
				}

				public int? ScalingAdjustment
				{
					get
					{
						return scalingAdjustment;
					}
					set	
					{
						scalingAdjustment = value;
					}
				}
			}
		}
	}
}
