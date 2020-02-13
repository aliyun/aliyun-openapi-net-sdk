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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeCdnDomainStagingConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeCdnDomainStagingConfig_DomainConfig> domainConfigs;

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

		public List<DescribeCdnDomainStagingConfig_DomainConfig> DomainConfigs
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

		public class DescribeCdnDomainStagingConfig_DomainConfig
		{

			private string functionName;

			private string configId;

			private string status;

			private List<DescribeCdnDomainStagingConfig_FunctionArg> functionArgs;

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

			public List<DescribeCdnDomainStagingConfig_FunctionArg> FunctionArgs
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

			public class DescribeCdnDomainStagingConfig_FunctionArg
			{

				private string argName;

				private string argValue;

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
