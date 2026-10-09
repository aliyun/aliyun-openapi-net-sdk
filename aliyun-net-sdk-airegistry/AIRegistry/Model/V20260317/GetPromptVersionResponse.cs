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

namespace Aliyun.Acs.AIRegistry.Model.V20260317
{
	public class GetPromptVersionResponse : AcsResponse
	{

		private string requestId;

		private GetPromptVersion_Data data;

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

		public GetPromptVersion_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetPromptVersion_Data
		{

			private string status;

			private string version;

			private string srcUser;

			private string promptKey;

			private long? gmtModified;

			private string commitMsg;

			private string template;

			private string md5;

			private List<GetPromptVersion_Variable> variables;

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

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string SrcUser
			{
				get
				{
					return srcUser;
				}
				set	
				{
					srcUser = value;
				}
			}

			public string PromptKey
			{
				get
				{
					return promptKey;
				}
				set	
				{
					promptKey = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string CommitMsg
			{
				get
				{
					return commitMsg;
				}
				set	
				{
					commitMsg = value;
				}
			}

			public string Template
			{
				get
				{
					return template;
				}
				set	
				{
					template = value;
				}
			}

			public string Md5
			{
				get
				{
					return md5;
				}
				set	
				{
					md5 = value;
				}
			}

			public List<GetPromptVersion_Variable> Variables
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

			public class GetPromptVersion_Variable
			{

				private string defaultValue;

				private string description;

				private string name;

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
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
			}
		}
	}
}
