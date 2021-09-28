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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class GetPredictiveJobGroupResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetPredictiveJobGroup_JobGroup jobGroup;

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

		public GetPredictiveJobGroup_JobGroup JobGroup
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

		public class GetPredictiveJobGroup_JobGroup
		{

			private long? creationTime;

			private string jobGroupId;

			private string description;

			private string skillGroupId;

			private string skillGroupName;

			private string instanceId;

			private string name;

			private long? ratio;

			private GetPredictiveJobGroup_Progress progress;

			private GetPredictiveJobGroup_Strategy strategy;

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

			public string SkillGroupId
			{
				get
				{
					return skillGroupId;
				}
				set	
				{
					skillGroupId = value;
				}
			}

			public string SkillGroupName
			{
				get
				{
					return skillGroupName;
				}
				set	
				{
					skillGroupName = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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

			public long? Ratio
			{
				get
				{
					return ratio;
				}
				set	
				{
					ratio = value;
				}
			}

			public GetPredictiveJobGroup_Progress Progress
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

			public GetPredictiveJobGroup_Strategy Strategy
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

			public class GetPredictiveJobGroup_Progress
			{

				private string status;

				private int? totalNotAnswered;

				private long? startTime;

				private int? totalJobs;

				private int? totalCompleted;

				private int? duration;

				private List<GetPredictiveJobGroup_KeyValuePair> categories;

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

				public List<GetPredictiveJobGroup_KeyValuePair> Categories
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

				public class GetPredictiveJobGroup_KeyValuePair
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

			public class GetPredictiveJobGroup_Strategy
			{

				private int? minAttemptInterval;

				private long? endTime;

				private long? startTime;

				private string strategyId;

				private int? maxAttemptsPerDay;

				private List<GetPredictiveJobGroup_TimeFrame> workingTime;

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

				public List<GetPredictiveJobGroup_TimeFrame> WorkingTime
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

				public class GetPredictiveJobGroup_TimeFrame
				{

					private string endTime;

					private string beginTime;

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
				}
			}
		}
	}
}
