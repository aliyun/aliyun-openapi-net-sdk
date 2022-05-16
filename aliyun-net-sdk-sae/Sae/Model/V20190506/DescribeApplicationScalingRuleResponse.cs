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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeApplicationScalingRuleResponse : AcsResponse
	{

		private string requestId;

		private string traceId;

		private DescribeApplicationScalingRule_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public DescribeApplicationScalingRule_Data Data
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

		public class DescribeApplicationScalingRule_Data
		{

			private long? updateTime;

			private string appId;

			private long? createTime;

			private long? lastDisableTime;

			private bool? scaleRuleEnabled;

			private string scaleRuleType;

			private string scaleRuleName;

			private DescribeApplicationScalingRule_Timer timer;

			private DescribeApplicationScalingRule_Metric metric;

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? LastDisableTime
			{
				get
				{
					return lastDisableTime;
				}
				set	
				{
					lastDisableTime = value;
				}
			}

			public bool? ScaleRuleEnabled
			{
				get
				{
					return scaleRuleEnabled;
				}
				set	
				{
					scaleRuleEnabled = value;
				}
			}

			public string ScaleRuleType
			{
				get
				{
					return scaleRuleType;
				}
				set	
				{
					scaleRuleType = value;
				}
			}

			public string ScaleRuleName
			{
				get
				{
					return scaleRuleName;
				}
				set	
				{
					scaleRuleName = value;
				}
			}

			public DescribeApplicationScalingRule_Timer Timer
			{
				get
				{
					return timer;
				}
				set	
				{
					timer = value;
				}
			}

			public DescribeApplicationScalingRule_Metric Metric
			{
				get
				{
					return metric;
				}
				set	
				{
					metric = value;
				}
			}

			public class DescribeApplicationScalingRule_Timer
			{

				private string endDate;

				private string beginDate;

				private string period;

				private List<DescribeApplicationScalingRule_Schedule> schedules;

				public string EndDate
				{
					get
					{
						return endDate;
					}
					set	
					{
						endDate = value;
					}
				}

				public string BeginDate
				{
					get
					{
						return beginDate;
					}
					set	
					{
						beginDate = value;
					}
				}

				public string Period
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

				public List<DescribeApplicationScalingRule_Schedule> Schedules
				{
					get
					{
						return schedules;
					}
					set	
					{
						schedules = value;
					}
				}

				public class DescribeApplicationScalingRule_Schedule
				{

					private string atTime;

					private int? targetReplicas;

					public string AtTime
					{
						get
						{
							return atTime;
						}
						set	
						{
							atTime = value;
						}
					}

					public int? TargetReplicas
					{
						get
						{
							return targetReplicas;
						}
						set	
						{
							targetReplicas = value;
						}
					}
				}
			}

			public class DescribeApplicationScalingRule_Metric
			{

				private int? maxReplicas;

				private int? minReplicas;

				private List<DescribeApplicationScalingRule_Metric1> metrics;

				private DescribeApplicationScalingRule_MetricsStatus metricsStatus;

				private DescribeApplicationScalingRule_ScaleUpRules scaleUpRules;

				private DescribeApplicationScalingRule_ScaleDownRules scaleDownRules;

				public int? MaxReplicas
				{
					get
					{
						return maxReplicas;
					}
					set	
					{
						maxReplicas = value;
					}
				}

				public int? MinReplicas
				{
					get
					{
						return minReplicas;
					}
					set	
					{
						minReplicas = value;
					}
				}

				public List<DescribeApplicationScalingRule_Metric1> Metrics
				{
					get
					{
						return metrics;
					}
					set	
					{
						metrics = value;
					}
				}

				public DescribeApplicationScalingRule_MetricsStatus MetricsStatus
				{
					get
					{
						return metricsStatus;
					}
					set	
					{
						metricsStatus = value;
					}
				}

				public DescribeApplicationScalingRule_ScaleUpRules ScaleUpRules
				{
					get
					{
						return scaleUpRules;
					}
					set	
					{
						scaleUpRules = value;
					}
				}

				public DescribeApplicationScalingRule_ScaleDownRules ScaleDownRules
				{
					get
					{
						return scaleDownRules;
					}
					set	
					{
						scaleDownRules = value;
					}
				}

				public class DescribeApplicationScalingRule_Metric1
				{

					private int? metricTargetAverageUtilization;

					private string metricType;

					public int? MetricTargetAverageUtilization
					{
						get
						{
							return metricTargetAverageUtilization;
						}
						set	
						{
							metricTargetAverageUtilization = value;
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
				}

				public class DescribeApplicationScalingRule_MetricsStatus
				{

					private long? desiredReplicas;

					private int? nextScaleTimePeriod;

					private long? currentReplicas;

					private string lastScaleTime;

					private List<DescribeApplicationScalingRule_CurrentMetric> currentMetrics;

					private List<DescribeApplicationScalingRule_NextScaleMetric> nextScaleMetrics;

					public long? DesiredReplicas
					{
						get
						{
							return desiredReplicas;
						}
						set	
						{
							desiredReplicas = value;
						}
					}

					public int? NextScaleTimePeriod
					{
						get
						{
							return nextScaleTimePeriod;
						}
						set	
						{
							nextScaleTimePeriod = value;
						}
					}

					public long? CurrentReplicas
					{
						get
						{
							return currentReplicas;
						}
						set	
						{
							currentReplicas = value;
						}
					}

					public string LastScaleTime
					{
						get
						{
							return lastScaleTime;
						}
						set	
						{
							lastScaleTime = value;
						}
					}

					public List<DescribeApplicationScalingRule_CurrentMetric> CurrentMetrics
					{
						get
						{
							return currentMetrics;
						}
						set	
						{
							currentMetrics = value;
						}
					}

					public List<DescribeApplicationScalingRule_NextScaleMetric> NextScaleMetrics
					{
						get
						{
							return nextScaleMetrics;
						}
						set	
						{
							nextScaleMetrics = value;
						}
					}

					public class DescribeApplicationScalingRule_CurrentMetric
					{

						private string type;

						private long? currentValue;

						private string name;

						public string Type
						{
							get
							{
								return type;
							}
							set	
							{
								type = value;
							}
						}

						public long? CurrentValue
						{
							get
							{
								return currentValue;
							}
							set	
							{
								currentValue = value;
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
					}

					public class DescribeApplicationScalingRule_NextScaleMetric
					{

						private int? nextScaleOutAverageUtilization;

						private int? nextScaleInAverageUtilization;

						private string name;

						public int? NextScaleOutAverageUtilization
						{
							get
							{
								return nextScaleOutAverageUtilization;
							}
							set	
							{
								nextScaleOutAverageUtilization = value;
							}
						}

						public int? NextScaleInAverageUtilization
						{
							get
							{
								return nextScaleInAverageUtilization;
							}
							set	
							{
								nextScaleInAverageUtilization = value;
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
					}
				}

				public class DescribeApplicationScalingRule_ScaleUpRules
				{

					private long? step;

					private long? stabilizationWindowSeconds;

					private bool? disabled;

					public long? Step
					{
						get
						{
							return step;
						}
						set	
						{
							step = value;
						}
					}

					public long? StabilizationWindowSeconds
					{
						get
						{
							return stabilizationWindowSeconds;
						}
						set	
						{
							stabilizationWindowSeconds = value;
						}
					}

					public bool? Disabled
					{
						get
						{
							return disabled;
						}
						set	
						{
							disabled = value;
						}
					}
				}

				public class DescribeApplicationScalingRule_ScaleDownRules
				{

					private long? step;

					private long? stabilizationWindowSeconds;

					private bool? disabled;

					public long? Step
					{
						get
						{
							return step;
						}
						set	
						{
							step = value;
						}
					}

					public long? StabilizationWindowSeconds
					{
						get
						{
							return stabilizationWindowSeconds;
						}
						set	
						{
							stabilizationWindowSeconds = value;
						}
					}

					public bool? Disabled
					{
						get
						{
							return disabled;
						}
						set	
						{
							disabled = value;
						}
					}
				}
			}
		}
	}
}
