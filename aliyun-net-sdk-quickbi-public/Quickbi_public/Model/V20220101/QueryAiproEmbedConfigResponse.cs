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
	public class QueryAiproEmbedConfigResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<QueryAiproEmbedConfig_Data> result;

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

		public List<QueryAiproEmbedConfig_Data> Result
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

		public class QueryAiproEmbedConfig_Data
		{

			private int? status;

			private int? chatHistoryStatus;

			private string nextToken;

			private string config;

			private int? memoryEnabled;

			private int? maxResults;

			private int? uploadEnabled;

			private string agentName;

			private string showName;

			private string aiProId;

			public int? Status
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

			public int? ChatHistoryStatus
			{
				get
				{
					return chatHistoryStatus;
				}
				set	
				{
					chatHistoryStatus = value;
				}
			}

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public string Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}

			public int? MemoryEnabled
			{
				get
				{
					return memoryEnabled;
				}
				set	
				{
					memoryEnabled = value;
				}
			}

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

			public int? UploadEnabled
			{
				get
				{
					return uploadEnabled;
				}
				set	
				{
					uploadEnabled = value;
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

			public string AiProId
			{
				get
				{
					return aiProId;
				}
				set	
				{
					aiProId = value;
				}
			}
		}
	}
}
