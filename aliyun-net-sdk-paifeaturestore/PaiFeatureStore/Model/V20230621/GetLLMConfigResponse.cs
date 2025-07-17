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

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class GetLLMConfigResponse : AcsResponse
	{

		private string requestId;

		private string lLMConfigId;

		private string name;

		private string apiKey;

		private string model;

		private string baseUrl;

		private int? rps;

		private int? maxTokens;

		private string gmtCreateTime;

		private string gmtModifiedTime;

		private int? batchSize;

		private string workspaceId;

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

		public string LLMConfigId
		{
			get
			{
				return lLMConfigId;
			}
			set	
			{
				lLMConfigId = value;
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

		public string ApiKey
		{
			get
			{
				return apiKey;
			}
			set	
			{
				apiKey = value;
			}
		}

		public string Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public string BaseUrl
		{
			get
			{
				return baseUrl;
			}
			set	
			{
				baseUrl = value;
			}
		}

		public int? Rps
		{
			get
			{
				return rps;
			}
			set	
			{
				rps = value;
			}
		}

		public int? MaxTokens
		{
			get
			{
				return maxTokens;
			}
			set	
			{
				maxTokens = value;
			}
		}

		public string GmtCreateTime
		{
			get
			{
				return gmtCreateTime;
			}
			set	
			{
				gmtCreateTime = value;
			}
		}

		public string GmtModifiedTime
		{
			get
			{
				return gmtModifiedTime;
			}
			set	
			{
				gmtModifiedTime = value;
			}
		}

		public int? BatchSize
		{
			get
			{
				return batchSize;
			}
			set	
			{
				batchSize = value;
			}
		}

		public string WorkspaceId
		{
			get
			{
				return workspaceId;
			}
			set	
			{
				workspaceId = value;
			}
		}
	}
}
