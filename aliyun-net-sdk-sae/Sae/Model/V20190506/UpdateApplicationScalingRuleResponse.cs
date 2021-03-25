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
	public class UpdateApplicationScalingRuleResponse : AcsResponse
	{

		private string requestId;

		private string traceId;

		private UpdateApplicationScalingRule_Data data;

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

		public UpdateApplicationScalingRule_Data Data
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

		public class UpdateApplicationScalingRule_Data
		{

			private bool? scaleRuleEnabled;

			private long? lastDisableTime;

			private string appId;

			private long? createTime;

			private long? updateTime;

			private string scaleRuleName;

			private string scaleRuleType;

			private UpdateApplicationScalingRule_Timer timer;

			private UpdateApplicationScalingRule_Metric metric;

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

			public UpdateApplicationScalingRule_Timer Timer
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

			public UpdateApplicationScalingRule_Metric Metric
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

			public class UpdateApplicationScalingRule_Timer
			{

				private string period;

				private string endDate;

				private string beginDate;

				private List<UpdateApplicationScalingRule_Schedule> schedules;

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

				public List<UpdateApplicationScalingRule_Schedule> Schedules
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

				public class UpdateApplicationScalingRule_Schedule
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

			public class UpdateApplicationScalingRule_Metric
			{

				private int? minReplicas;

				private int? maxReplicas;

				private List<UpdateApplicationScalingRule_Metric1> metrics;

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

				public List<UpdateApplicationScalingRule_Metric1> Metrics
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

				public class UpdateApplicationScalingRule_Metric1
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
			}
		}
	}
}
