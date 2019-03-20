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

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class DescribeAlarmsForResourcesResponse : AcsResponse
	{

		private string requestId;

		private string traceId;

		private bool? success;

		private int? code;

		private string message;

		private string total;

		private string dimensions;

		private List<DescribeAlarmsForResources_Alarm> datapoints;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public string Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public string Dimensions
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

		public List<DescribeAlarmsForResources_Alarm> Datapoints
		{
			get
			{
				return datapoints;
			}
			set	
			{
				datapoints = value;
			}
		}

		public class DescribeAlarmsForResources_Alarm
		{

			private string uuid;

			private string name;

			private string _namespace;

			private string metricName;

			private string period;

			private string evaluationCount;

			private string effectiveInterval;

			private string noEffectiveInterval;

			private string silenceTime;

			private bool? enable;

			private string state;

			private string contactGroups;

			private string webhook;

			private string subject;

			private string displayName;

			private string resources;

			private string level;

			private string groupId;

			private string groupName;

			private string statistics;

			private string comparisonOperator;

			private string threshold;

			private DescribeAlarmsForResources_Escalations escalations;

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
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

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
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

			public string EffectiveInterval
			{
				get
				{
					return effectiveInterval;
				}
				set	
				{
					effectiveInterval = value;
				}
			}

			public string NoEffectiveInterval
			{
				get
				{
					return noEffectiveInterval;
				}
				set	
				{
					noEffectiveInterval = value;
				}
			}

			public string SilenceTime
			{
				get
				{
					return silenceTime;
				}
				set	
				{
					silenceTime = value;
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

			public string ContactGroups
			{
				get
				{
					return contactGroups;
				}
				set	
				{
					contactGroups = value;
				}
			}

			public string Webhook
			{
				get
				{
					return webhook;
				}
				set	
				{
					webhook = value;
				}
			}

			public string Subject
			{
				get
				{
					return subject;
				}
				set	
				{
					subject = value;
				}
			}

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public string Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
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

			public DescribeAlarmsForResources_Escalations Escalations
			{
				get
				{
					return escalations;
				}
				set	
				{
					escalations = value;
				}
			}

			public class DescribeAlarmsForResources_Escalations
			{

				private DescribeAlarmsForResources_Info info;

				private DescribeAlarmsForResources_Warn warn;

				private DescribeAlarmsForResources_Critical critical;

				public DescribeAlarmsForResources_Info Info
				{
					get
					{
						return info;
					}
					set	
					{
						info = value;
					}
				}

				public DescribeAlarmsForResources_Warn Warn
				{
					get
					{
						return warn;
					}
					set	
					{
						warn = value;
					}
				}

				public DescribeAlarmsForResources_Critical Critical
				{
					get
					{
						return critical;
					}
					set	
					{
						critical = value;
					}
				}

				public class DescribeAlarmsForResources_Info
				{

					private string comparisonOperator;

					private string statistics;

					private string threshold;

					private string times;

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

					public string Times
					{
						get
						{
							return times;
						}
						set	
						{
							times = value;
						}
					}
				}

				public class DescribeAlarmsForResources_Warn
				{

					private string comparisonOperator;

					private string statistics;

					private string threshold;

					private string times;

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

					public string Times
					{
						get
						{
							return times;
						}
						set	
						{
							times = value;
						}
					}
				}

				public class DescribeAlarmsForResources_Critical
				{

					private string comparisonOperator;

					private string statistics;

					private string threshold;

					private string times;

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

					public string Times
					{
						get
						{
							return times;
						}
						set	
						{
							times = value;
						}
					}
				}
			}
		}
	}
}
