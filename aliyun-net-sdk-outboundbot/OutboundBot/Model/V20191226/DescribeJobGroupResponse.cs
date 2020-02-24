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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class DescribeJobGroupResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private DescribeJobGroup_JobGroup jobGroup;

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

		public string Code
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public DescribeJobGroup_JobGroup JobGroup
		{
			get
			{
				return jobGroup;
			}
			set	
			{
				jobGroup = value;
			}
		}

		public class DescribeJobGroup_JobGroup
		{

			private string jobGroupId;

			private string jobGroupName;

			private string jobGroupDescription;

			private string scenarioId;

			private string scriptId;

			private string scriptName;

			private string jobFilePath;

			private long? creationTime;

			private List<string> callingNumbers;

			private DescribeJobGroup_Strategy strategy;

			private DescribeJobGroup_Progress progress;

			public string JobGroupId
			{
				get
				{
					return jobGroupId;
				}
				set	
				{
					jobGroupId = value;
				}
			}

			public string JobGroupName
			{
				get
				{
					return jobGroupName;
				}
				set	
				{
					jobGroupName = value;
				}
			}

			public string JobGroupDescription
			{
				get
				{
					return jobGroupDescription;
				}
				set	
				{
					jobGroupDescription = value;
				}
			}

			public string ScenarioId
			{
				get
				{
					return scenarioId;
				}
				set	
				{
					scenarioId = value;
				}
			}

			public string ScriptId
			{
				get
				{
					return scriptId;
				}
				set	
				{
					scriptId = value;
				}
			}

			public string ScriptName
			{
				get
				{
					return scriptName;
				}
				set	
				{
					scriptName = value;
				}
			}

			public string JobFilePath
			{
				get
				{
					return jobFilePath;
				}
				set	
				{
					jobFilePath = value;
				}
			}

			public long? CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public List<string> CallingNumbers
			{
				get
				{
					return callingNumbers;
				}
				set	
				{
					callingNumbers = value;
				}
			}

			public DescribeJobGroup_Strategy Strategy
			{
				get
				{
					return strategy;
				}
				set	
				{
					strategy = value;
				}
			}

			public DescribeJobGroup_Progress Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public class DescribeJobGroup_Strategy
			{

				private string strategyId;

				private string strategyName;

				private string strategyDescription;

				private string type;

				private long? startTime;

				private long? endTime;

				private string repeatBy;

				private int? maxAttemptsPerDay;

				private int? minAttemptInterval;

				private string customized;

				private string routingStrategy;

				private string followUpStrategy;

				private bool? isTemplate;

				private List<DescribeJobGroup_TimeFrame> workingTime;

				private List<string> repeatDays;

				public string StrategyId
				{
					get
					{
						return strategyId;
					}
					set	
					{
						strategyId = value;
					}
				}

				public string StrategyName
				{
					get
					{
						return strategyName;
					}
					set	
					{
						strategyName = value;
					}
				}

				public string StrategyDescription
				{
					get
					{
						return strategyDescription;
					}
					set	
					{
						strategyDescription = value;
					}
				}

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

				public long? StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public long? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public string RepeatBy
				{
					get
					{
						return repeatBy;
					}
					set	
					{
						repeatBy = value;
					}
				}

				public int? MaxAttemptsPerDay
				{
					get
					{
						return maxAttemptsPerDay;
					}
					set	
					{
						maxAttemptsPerDay = value;
					}
				}

				public int? MinAttemptInterval
				{
					get
					{
						return minAttemptInterval;
					}
					set	
					{
						minAttemptInterval = value;
					}
				}

				public string Customized
				{
					get
					{
						return customized;
					}
					set	
					{
						customized = value;
					}
				}

				public string RoutingStrategy
				{
					get
					{
						return routingStrategy;
					}
					set	
					{
						routingStrategy = value;
					}
				}

				public string FollowUpStrategy
				{
					get
					{
						return followUpStrategy;
					}
					set	
					{
						followUpStrategy = value;
					}
				}

				public bool? IsTemplate
				{
					get
					{
						return isTemplate;
					}
					set	
					{
						isTemplate = value;
					}
				}

				public List<DescribeJobGroup_TimeFrame> WorkingTime
				{
					get
					{
						return workingTime;
					}
					set	
					{
						workingTime = value;
					}
				}

				public List<string> RepeatDays
				{
					get
					{
						return repeatDays;
					}
					set	
					{
						repeatDays = value;
					}
				}

				public class DescribeJobGroup_TimeFrame
				{

					private string beginTime;

					private string endTime;

					public string BeginTime
					{
						get
						{
							return beginTime;
						}
						set	
						{
							beginTime = value;
						}
					}

					public string EndTime
					{
						get
						{
							return endTime;
						}
						set	
						{
							endTime = value;
						}
					}
				}
			}

			public class DescribeJobGroup_Progress
			{

				private int? totalJobs;

				private string status;

				private int? totalNotAnswered;

				private int? totalCompleted;

				private long? startTime;

				private int? duration;

				private int? scheduling;

				private int? executing;

				private int? paused;

				private int? failed;

				private int? cancelled;

				private List<DescribeJobGroup_KeyValuePair> categories;

				private List<DescribeJobGroup_KeyValuePair> briefs;

				public int? TotalJobs
				{
					get
					{
						return totalJobs;
					}
					set	
					{
						totalJobs = value;
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

				public int? TotalNotAnswered
				{
					get
					{
						return totalNotAnswered;
					}
					set	
					{
						totalNotAnswered = value;
					}
				}

				public int? TotalCompleted
				{
					get
					{
						return totalCompleted;
					}
					set	
					{
						totalCompleted = value;
					}
				}

				public long? StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public int? Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public int? Scheduling
				{
					get
					{
						return scheduling;
					}
					set	
					{
						scheduling = value;
					}
				}

				public int? Executing
				{
					get
					{
						return executing;
					}
					set	
					{
						executing = value;
					}
				}

				public int? Paused
				{
					get
					{
						return paused;
					}
					set	
					{
						paused = value;
					}
				}

				public int? Failed
				{
					get
					{
						return failed;
					}
					set	
					{
						failed = value;
					}
				}

				public int? Cancelled
				{
					get
					{
						return cancelled;
					}
					set	
					{
						cancelled = value;
					}
				}

				public List<DescribeJobGroup_KeyValuePair> Categories
				{
					get
					{
						return categories;
					}
					set	
					{
						categories = value;
					}
				}

				public List<DescribeJobGroup_KeyValuePair> Briefs
				{
					get
					{
						return briefs;
					}
					set	
					{
						briefs = value;
					}
				}

				public class DescribeJobGroup_KeyValuePair
				{

					private string key;

					private string _value;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}
		}
	}
}
