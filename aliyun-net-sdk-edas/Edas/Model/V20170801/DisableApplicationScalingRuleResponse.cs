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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class DisableApplicationScalingRuleResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private DisableApplicationScalingRule_AppScalingRule appScalingRule;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public DisableApplicationScalingRule_AppScalingRule AppScalingRule
		{
			get
			{
				return appScalingRule;
			}
			set	
			{
				appScalingRule = value;
			}
		}

		public class DisableApplicationScalingRule_AppScalingRule
		{

			private string appId;

			private string scaleRuleName;

			private string scaleRuleType;

			private bool? scaleRuleEnabled;

			private int? minReplicas;

			private int? maxReplicas;

			private long? createTime;

			private long? updateTime;

			private long? lastDisableTime;

			private DisableApplicationScalingRule_Metric metric;

			private DisableApplicationScalingRule_Trigger trigger;

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

			public DisableApplicationScalingRule_Metric Metric
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

			public DisableApplicationScalingRule_Trigger Trigger
			{
				get
				{
					return trigger;
				}
				set	
				{
					trigger = value;
				}
			}

			public class DisableApplicationScalingRule_Metric
			{

				private int? maxReplicas;

				private int? minReplicas;

				private List<DisableApplicationScalingRule_Metric1> metrics;

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

				public List<DisableApplicationScalingRule_Metric1> Metrics
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

				public class DisableApplicationScalingRule_Metric1
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

			public class DisableApplicationScalingRule_Trigger
			{

				private int? maxReplicas;

				private int? minReplicas;

				private List<DisableApplicationScalingRule_Trigger2> triggers;

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

				public List<DisableApplicationScalingRule_Trigger2> Triggers
				{
					get
					{
						return triggers;
					}
					set	
					{
						triggers = value;
					}
				}

				public class DisableApplicationScalingRule_Trigger2
				{

					private string type;

					private string name;

					private string metaData;

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

					public string MetaData
					{
						get
						{
							return metaData;
						}
						set	
						{
							metaData = value;
						}
					}
				}
			}
		}
	}
}
