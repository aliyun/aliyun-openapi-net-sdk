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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeParameterTemplatesResponse : AcsResponse
	{

		private string requestId;

		private string engine;

		private string parameterCount;

		private string engineVersion;

		private List<DescribeParameterTemplates_TemplateRecord> parameters;

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

		[JsonProperty(PropertyName = "Engine")]
		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
			}
		}

		[JsonProperty(PropertyName = "ParameterCount")]
		public string ParameterCount
		{
			get
			{
				return parameterCount;
			}
			set	
			{
				parameterCount = value;
			}
		}

		[JsonProperty(PropertyName = "EngineVersion")]
		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
			}
		}

		[JsonProperty(PropertyName = "Parameters")]
		public List<DescribeParameterTemplates_TemplateRecord> Parameters
		{
			get
			{
				return parameters;
			}
			set	
			{
				parameters = value;
			}
		}

		public class DescribeParameterTemplates_TemplateRecord
		{

			private string checkingCode;

			private string parameterName;

			private string parameterValue;

			private string forceModify;

			private string forceRestart;

			private string parameterDescription;

			[JsonProperty(PropertyName = "CheckingCode")]
			public string CheckingCode
			{
				get
				{
					return checkingCode;
				}
				set	
				{
					checkingCode = value;
				}
			}

			[JsonProperty(PropertyName = "ParameterName")]
			public string ParameterName
			{
				get
				{
					return parameterName;
				}
				set	
				{
					parameterName = value;
				}
			}

			[JsonProperty(PropertyName = "ParameterValue")]
			public string ParameterValue
			{
				get
				{
					return parameterValue;
				}
				set	
				{
					parameterValue = value;
				}
			}

			[JsonProperty(PropertyName = "ForceModify")]
			public string ForceModify
			{
				get
				{
					return forceModify;
				}
				set	
				{
					forceModify = value;
				}
			}

			[JsonProperty(PropertyName = "ForceRestart")]
			public string ForceRestart
			{
				get
				{
					return forceRestart;
				}
				set	
				{
					forceRestart = value;
				}
			}

			[JsonProperty(PropertyName = "ParameterDescription")]
			public string ParameterDescription
			{
				get
				{
					return parameterDescription;
				}
				set	
				{
					parameterDescription = value;
				}
			}
		}
	}
}
