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

			private long? updateTime;

			private string appId;

			private long? createTime;

			private long? lastDisableTime;

			private bool? scaleRuleEnabled;

			private string scaleRuleType;

			private string scaleRuleName;

			private UpdateApplicationScalingRule_Timer timer;

			private UpdateApplicationScalingRule_Metric metric;

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

				private string endDate;

				private string beginDate;

				private string period;

				private List<UpdateApplicationScalingRule_Schedule> schedules;

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

			public class UpdateApplicationScalingRule_Metric
			{

				private int? maxReplicas;

				private int? minReplicas;

				private List<UpdateApplicationScalingRule_Metric1> metrics;

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
			}
		}
	}
}
