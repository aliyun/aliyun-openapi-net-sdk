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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeApplicationScalingRulesResponse : AcsResponse
	{

		private string requestId;

		private string traceId;

		private DescribeApplicationScalingRules_Data data;

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

		public DescribeApplicationScalingRules_Data Data
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

		public class DescribeApplicationScalingRules_Data
		{

			private int? pageSize;

			private int? currentPage;

			private int? totalSize;

			private List<DescribeApplicationScalingRules_ApplicationScalingRule> applicationScalingRules;

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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

			public int? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			public List<DescribeApplicationScalingRules_ApplicationScalingRule> ApplicationScalingRules
			{
				get
				{
					return applicationScalingRules;
				}
				set	
				{
					applicationScalingRules = value;
				}
			}

			public class DescribeApplicationScalingRules_ApplicationScalingRule
			{

				private bool? scaleRuleEnabled;

				private long? lastDisableTime;

				private string appId;

				private long? createTime;

				private long? updateTime;

				private string scaleRuleName;

				private string scaleRuleType;

				private DescribeApplicationScalingRules_Timer timer;

				private DescribeApplicationScalingRules_Metric metric;

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

				public DescribeApplicationScalingRules_Timer Timer
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

				public DescribeApplicationScalingRules_Metric Metric
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

				public class DescribeApplicationScalingRules_Timer
				{

					private string period;

					private string endDate;

					private string beginDate;

					private List<DescribeApplicationScalingRules_Schedule> schedules;

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

					public List<DescribeApplicationScalingRules_Schedule> Schedules
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

					public class DescribeApplicationScalingRules_Schedule
					{

						private int? targetReplicas;

						private string atTime;

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
					}
				}

				public class DescribeApplicationScalingRules_Metric
				{

					private int? minReplicas;

					private int? maxReplicas;

					private List<DescribeApplicationScalingRules_Metric1> metrics;

					private DescribeApplicationScalingRules_MetricsStatus metricsStatus;

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

					public List<DescribeApplicationScalingRules_Metric1> Metrics
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

					public DescribeApplicationScalingRules_MetricsStatus MetricsStatus
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

					public class DescribeApplicationScalingRules_Metric1
					{

						private string metricType;

						private int? metricTargetAverageUtilization;

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
					}

					public class DescribeApplicationScalingRules_MetricsStatus
					{

						private long? desiredReplicas;

						private long? currentReplicas;

						private int? nextScaleTimePeriod;

						private string lastScaleTime;

						private List<DescribeApplicationScalingRules_NextScaleMetric> nextScaleMetrics;

						private List<DescribeApplicationScalingRules_CurrentMetric> currentMetrics;

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

						public List<DescribeApplicationScalingRules_NextScaleMetric> NextScaleMetrics
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

						public List<DescribeApplicationScalingRules_CurrentMetric> CurrentMetrics
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

						public class DescribeApplicationScalingRules_NextScaleMetric
						{

							private int? nextScaleInAverageUtilization;

							private string name;

							private int? nextScaleOutAverageUtilization;

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
						}

						public class DescribeApplicationScalingRules_CurrentMetric
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
					}
				}
			}
		}
	}
}
