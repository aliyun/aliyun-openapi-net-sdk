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
	public class QueryDataRangeResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryDataRange_Result result;

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

		public QueryDataRange_Result Result
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

		public class QueryDataRange_Result
		{

			private List<QueryDataRange_ApiCopilotLlmCubeModelsItem> apiCopilotLlmCubeModels;

			private List<QueryDataRange_ApiCopilotThemeModelsItem> apiCopilotThemeModels;

			public List<QueryDataRange_ApiCopilotLlmCubeModelsItem> ApiCopilotLlmCubeModels
			{
				get
				{
					return apiCopilotLlmCubeModels;
				}
				set	
				{
					apiCopilotLlmCubeModels = value;
				}
			}

			public List<QueryDataRange_ApiCopilotThemeModelsItem> ApiCopilotThemeModels
			{
				get
				{
					return apiCopilotThemeModels;
				}
				set	
				{
					apiCopilotThemeModels = value;
				}
			}

			public class QueryDataRange_ApiCopilotLlmCubeModelsItem
			{

				private string llmCubeId;

				private string alias;

				private string createUser;

				public string LlmCubeId
				{
					get
					{
						return llmCubeId;
					}
					set	
					{
						llmCubeId = value;
					}
				}

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
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
			}

			public class QueryDataRange_ApiCopilotThemeModelsItem
			{

				private string themeId;

				private string themeName;

				private string createUser;

				private List<QueryDataRange_ApiCopilotLlmCubeModelsItem2> apiCopilotLlmCubeModels1;

				public string ThemeId
				{
					get
					{
						return themeId;
					}
					set	
					{
						themeId = value;
					}
				}

				public string ThemeName
				{
					get
					{
						return themeName;
					}
					set	
					{
						themeName = value;
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

				public List<QueryDataRange_ApiCopilotLlmCubeModelsItem2> ApiCopilotLlmCubeModels1
				{
					get
					{
						return apiCopilotLlmCubeModels1;
					}
					set	
					{
						apiCopilotLlmCubeModels1 = value;
					}
				}

				public class QueryDataRange_ApiCopilotLlmCubeModelsItem2
				{

					private string llmCubeId;

					private string alias;

					private string createUser;

					public string LlmCubeId
					{
						get
						{
							return llmCubeId;
						}
						set	
						{
							llmCubeId = value;
						}
					}

					public string Alias
					{
						get
						{
							return alias;
						}
						set	
						{
							alias = value;
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
				}
			}
		}
	}
}
