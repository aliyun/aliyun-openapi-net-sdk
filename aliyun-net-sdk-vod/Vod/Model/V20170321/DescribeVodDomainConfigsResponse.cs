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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribeVodDomainConfigsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVodDomainConfigs_DomainConfig> domainConfigs;

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

		public List<DescribeVodDomainConfigs_DomainConfig> DomainConfigs
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

		public class DescribeVodDomainConfigs_DomainConfig
		{

			private string functionName;

			private string configId;

			private string status;

			private List<DescribeVodDomainConfigs_FunctionArg> functionArgs;

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

			public List<DescribeVodDomainConfigs_FunctionArg> FunctionArgs
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

			public class DescribeVodDomainConfigs_FunctionArg
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