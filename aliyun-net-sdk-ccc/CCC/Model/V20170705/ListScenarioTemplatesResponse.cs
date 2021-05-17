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
	public class ListScenarioTemplatesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<ListScenarioTemplates_Scenario> scenarioTemplates;

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

		public List<ListScenarioTemplates_Scenario> ScenarioTemplates
		{
			get
			{
				return scenarioTemplates;
			}
			set	
			{
				scenarioTemplates = value;
			}
		}

		public class ListScenarioTemplates_Scenario
		{

			private string id;

			private string name;

			private string description;

			private string type;

			private bool? isTemplate;

			private List<ListScenarioTemplates_Survey> surveys;

			private List<ListScenarioTemplates_KeyValuePair> variables;

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

			public List<ListScenarioTemplates_Survey> Surveys
			{
				get
				{
					return surveys;
				}
				set	
				{
					surveys = value;
				}
			}

			public List<ListScenarioTemplates_KeyValuePair> Variables
			{
				get
				{
					return variables;
				}
				set	
				{
					variables = value;
				}
			}

			public class ListScenarioTemplates_Survey
			{

				private string id;

				private string name;

				private string description;

				private string role;

				private int? round;

				private string beebotId;

				private string globalQuestions;

				private List<ListScenarioTemplates_IntentNode> intents;

				private ListScenarioTemplates_Flow flow;

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

				public string BeebotId
				{
					get
					{
						return beebotId;
					}
					set	
					{
						beebotId = value;
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

				public List<ListScenarioTemplates_IntentNode> Intents
				{
					get
					{
						return intents;
					}
					set	
					{
						intents = value;
					}
				}

				public ListScenarioTemplates_Flow Flow
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

				public class ListScenarioTemplates_IntentNode
				{

					private string nodeId;

					private string intentId;

					public string NodeId
					{
						get
						{
							return nodeId;
						}
						set	
						{
							nodeId = value;
						}
					}

					public string IntentId
					{
						get
						{
							return intentId;
						}
						set	
						{
							intentId = value;
						}
					}
				}

				public class ListScenarioTemplates_Flow
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
			}

			public class ListScenarioTemplates_KeyValuePair
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
