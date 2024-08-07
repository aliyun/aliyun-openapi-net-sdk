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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryCopilotEmbedConfigResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<QueryCopilotEmbedConfig_ResultItem> result;

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

		public List<QueryCopilotEmbedConfig_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryCopilotEmbedConfig_ResultItem
		{

			private string copilotId;

			private string showName;

			private string createUser;

			private string createUserName;

			private string modifyUser;

			private string moduleName;

			private string agentName;

			private QueryCopilotEmbedConfig_DataRange dataRange;

			public string CopilotId
			{
				get
				{
					return copilotId;
				}
				set	
				{
					copilotId = value;
				}
			}

			public string ShowName
			{
				get
				{
					return showName;
				}
				set	
				{
					showName = value;
				}
			}

			public string CreateUser
			{
				get
				{
					return createUser;
				}
				set	
				{
					createUser = value;
				}
			}

			public string CreateUserName
			{
				get
				{
					return createUserName;
				}
				set	
				{
					createUserName = value;
				}
			}

			public string ModifyUser
			{
				get
				{
					return modifyUser;
				}
				set	
				{
					modifyUser = value;
				}
			}

			public string ModuleName
			{
				get
				{
					return moduleName;
				}
				set	
				{
					moduleName = value;
				}
			}

			public string AgentName
			{
				get
				{
					return agentName;
				}
				set	
				{
					agentName = value;
				}
			}

			public QueryCopilotEmbedConfig_DataRange DataRange
			{
				get
				{
					return dataRange;
				}
				set	
				{
					dataRange = value;
				}
			}

			public class QueryCopilotEmbedConfig_DataRange
			{

				private bool? allTheme;

				private bool? allCube;

				private List<string> themes;

				private List<string> llmCubes;

				public bool? AllTheme
				{
					get
					{
						return allTheme;
					}
					set	
					{
						allTheme = value;
					}
				}

				public bool? AllCube
				{
					get
					{
						return allCube;
					}
					set	
					{
						allCube = value;
					}
				}

				public List<string> Themes
				{
					get
					{
						return themes;
					}
					set	
					{
						themes = value;
					}
				}

				public List<string> LlmCubes
				{
					get
					{
						return llmCubes;
					}
					set	
					{
						llmCubes = value;
					}
				}
			}
		}
	}
}
