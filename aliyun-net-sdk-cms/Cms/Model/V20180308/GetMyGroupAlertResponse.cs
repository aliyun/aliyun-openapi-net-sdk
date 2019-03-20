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
	public class GetMyGroupAlertResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private string errorMessage;

		private GetMyGroupAlert_GroupAlert groupAlert;

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

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public GetMyGroupAlert_GroupAlert GroupAlert
		{
			get
			{
				return groupAlert;
			}
			set	
			{
				groupAlert = value;
			}
		}

		public class GetMyGroupAlert_GroupAlert
		{

			private string groupId;

			private string alertName;

			private string displayName;

			private string subject;

			private string webhook;

			private string category;

			private string _namespace;

			private string metricName;

			private int? period;

			private string state;

			private string description;

			private bool? enable;

			private int? silenceTime;

			private string enableEndTime;

			private string enableStartTime;

			private string selector;

			private GetMyGroupAlert_Escalations escalations;

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

			public string AlertName
			{
				get
				{
					return alertName;
				}
				set	
				{
					alertName = value;
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

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public int? SilenceTime
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

			public string EnableEndTime
			{
				get
				{
					return enableEndTime;
				}
				set	
				{
					enableEndTime = value;
				}
			}

			public string EnableStartTime
			{
				get
				{
					return enableStartTime;
				}
				set	
				{
					enableStartTime = value;
				}
			}

			public string Selector
			{
				get
				{
					return selector;
				}
				set	
				{
					selector = value;
				}
			}

			public GetMyGroupAlert_Escalations Escalations
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

			public class GetMyGroupAlert_Escalations
			{

				private GetMyGroupAlert_Info info;

				private GetMyGroupAlert_Warn warn;

				private GetMyGroupAlert_Critical critical;

				public GetMyGroupAlert_Info Info
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

				public GetMyGroupAlert_Warn Warn
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

				public GetMyGroupAlert_Critical Critical
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

				public class GetMyGroupAlert_Info
				{

					private string statistics;

					private string comparisonOperator;

					private string threshold;

					private int? times;

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

					public int? Times
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

				public class GetMyGroupAlert_Warn
				{

					private string statistics;

					private string comparisonOperator;

					private string threshold;

					private int? times;

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

					public int? Times
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

				public class GetMyGroupAlert_Critical
				{

					private string statistics;

					private string comparisonOperator;

					private string threshold;

					private int? times;

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

					public int? Times
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
