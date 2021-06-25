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
	public class ModifyJobGroupResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private ModifyJobGroup_JobGroup jobGroup;

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

		public ModifyJobGroup_JobGroup JobGroup
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

		public class ModifyJobGroup_JobGroup
		{

			private long? creationTime;

			private string jobDataParsingTaskId;

			private string jobFilePath;

			private string jobGroupDescription;

			private string jobGroupId;

			private string jobGroupName;

			private string modifyTime;

			private string scenarioId;

			private string scriptName;

			private string scriptVersion;

			private string status;

			private List<string> callingNumbers;

			private ModifyJobGroup_ExportProgress exportProgress;

			private ModifyJobGroup_Strategy strategy;

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

			public string JobDataParsingTaskId
			{
				get
				{
					return jobDataParsingTaskId;
				}
				set	
				{
					jobDataParsingTaskId = value;
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

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
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

			public string ScriptVersion
			{
				get
				{
					return scriptVersion;
				}
				set	
				{
					scriptVersion = value;
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

			public ModifyJobGroup_ExportProgress ExportProgress
			{
				get
				{
					return exportProgress;
				}
				set	
				{
					exportProgress = value;
				}
			}

			public ModifyJobGroup_Strategy Strategy
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

			public class ModifyJobGroup_ExportProgress
			{

				private string fileHttpUrl;

				private string progress;

				private string status;

				public string FileHttpUrl
				{
					get
					{
						return fileHttpUrl;
					}
					set	
					{
						fileHttpUrl = value;
					}
				}

				public string Progress
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
			}

			public class ModifyJobGroup_Strategy
			{

				private string customized;

				private long? endTime;

				private string followUpStrategy;

				private bool? isTemplate;

				private int? maxAttemptsPerDay;

				private int? minAttemptInterval;

				private string repeatBy;

				private string routingStrategy;

				private long? startTime;

				private string strategyDescription;

				private string strategyId;

				private string strategyName;

				private string type;

				private List<ModifyJobGroup_TimeFrame> workingTime;

				private List<string> repeatDays;

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

				public List<ModifyJobGroup_TimeFrame> WorkingTime
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

				public class ModifyJobGroup_TimeFrame
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
		}
	}
}
