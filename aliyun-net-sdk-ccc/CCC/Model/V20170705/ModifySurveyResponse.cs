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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class ModifySurveyResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ModifySurvey_Survey survey;

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

		public ModifySurvey_Survey Survey
		{
			get
			{
				return survey;
			}
			set	
			{
				survey = value;
			}
		}

		public class ModifySurvey_Survey
		{

			private string id;

			private string scenarioUuid;

			private string name;

			private string description;

			private string role;

			private int? round;

			private string hotWords;

			private string speechOptimizationParam;

			private string globalQuestions;

			private ModifySurvey_Flow flow;

			private ModifySurvey_AsrCustomModel asrCustomModel;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string ScenarioUuid
			{
				get
				{
					return scenarioUuid;
				}
				set	
				{
					scenarioUuid = value;
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

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
				}
			}

			public int? Round
			{
				get
				{
					return round;
				}
				set	
				{
					round = value;
				}
			}

			public string HotWords
			{
				get
				{
					return hotWords;
				}
				set	
				{
					hotWords = value;
				}
			}

			public string SpeechOptimizationParam
			{
				get
				{
					return speechOptimizationParam;
				}
				set	
				{
					speechOptimizationParam = value;
				}
			}

			public string GlobalQuestions
			{
				get
				{
					return globalQuestions;
				}
				set	
				{
					globalQuestions = value;
				}
			}

			public ModifySurvey_Flow Flow
			{
				get
				{
					return flow;
				}
				set	
				{
					flow = value;
				}
			}

			public ModifySurvey_AsrCustomModel AsrCustomModel
			{
				get
				{
					return asrCustomModel;
				}
				set	
				{
					asrCustomModel = value;
				}
			}

			public class ModifySurvey_Flow
			{

				private string flowId;

				private bool? isPublished;

				private string flowJson;

				public string FlowId
				{
					get
					{
						return flowId;
					}
					set	
					{
						flowId = value;
					}
				}

				public bool? IsPublished
				{
					get
					{
						return isPublished;
					}
					set	
					{
						isPublished = value;
					}
				}

				public string FlowJson
				{
					get
					{
						return flowJson;
					}
					set	
					{
						flowJson = value;
					}
				}
			}

			public class ModifySurvey_AsrCustomModel
			{

				private string corpora;

				private int? customModelStatus;

				public string Corpora
				{
					get
					{
						return corpora;
					}
					set	
					{
						corpora = value;
					}
				}

				public int? CustomModelStatus
				{
					get
					{
						return customModelStatus;
					}
					set	
					{
						customModelStatus = value;
					}
				}
			}
		}
	}
}