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
	public class DescribeConfigOfVersionResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeConfigOfVersion_VersionConfig> versionConfigs;

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

		public List<DescribeConfigOfVersion_VersionConfig> VersionConfigs
		{
			get
			{
				return versionConfigs;
			}
			set	
			{
				versionConfigs = value;
			}
		}

		public class DescribeConfigOfVersion_VersionConfig
		{

			private string status;

			private string configId;

			private string functionName;

			private List<DescribeConfigOfVersion_FunctionArg> functionArgs;

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

			public List<DescribeConfigOfVersion_FunctionArg> FunctionArgs
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

			public class DescribeConfigOfVersion_FunctionArg
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
