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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveDomainStagingConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDomainStagingConfig_DomainConfig> domainConfigs;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "DomainConfigs")]
		public List<DescribeLiveDomainStagingConfig_DomainConfig> DomainConfigs
		{
			get
			{
				return domainConfigs;
			}
			set	
			{
				domainConfigs = value;
			}
		}

		public class DescribeLiveDomainStagingConfig_DomainConfig
		{

			private string status;

			private string configId;

			private string functionName;

			private List<DescribeLiveDomainStagingConfig_FunctionArg> functionArgs;

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "ConfigId")]
			public string ConfigId
			{
				get
				{
					return configId;
				}
				set	
				{
					configId = value;
				}
			}

			[JsonProperty(PropertyName = "FunctionName")]
			public string FunctionName
			{
				get
				{
					return functionName;
				}
				set	
				{
					functionName = value;
				}
			}

			[JsonProperty(PropertyName = "FunctionArgs")]
			public List<DescribeLiveDomainStagingConfig_FunctionArg> FunctionArgs
			{
				get
				{
					return functionArgs;
				}
				set	
				{
					functionArgs = value;
				}
			}

			public class DescribeLiveDomainStagingConfig_FunctionArg
			{

				private string argName;

				private string argValue;

				[JsonProperty(PropertyName = "ArgName")]
				public string ArgName
				{
					get
					{
						return argName;
					}
					set	
					{
						argName = value;
					}
				}

				[JsonProperty(PropertyName = "ArgValue")]
				public string ArgValue
				{
					get
					{
						return argValue;
					}
					set	
					{
						argValue = value;
					}
				}
			}
		}
	}
}
