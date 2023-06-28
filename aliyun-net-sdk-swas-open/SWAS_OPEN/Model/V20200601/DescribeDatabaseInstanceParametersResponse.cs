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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class DescribeDatabaseInstanceParametersResponse : AcsResponse
	{

		private string requestId;

		private string engine;

		private string engineVersion;

		private List<DescribeDatabaseInstanceParameters_ConfigParameter> configParameters;

		private List<DescribeDatabaseInstanceParameters_RunningParameter> runningParameters;

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

		[JsonProperty(PropertyName = "ConfigParameters")]
		public List<DescribeDatabaseInstanceParameters_ConfigParameter> ConfigParameters
		{
			get
			{
				return configParameters;
			}
			set	
			{
				configParameters = value;
			}
		}

		[JsonProperty(PropertyName = "RunningParameters")]
		public List<DescribeDatabaseInstanceParameters_RunningParameter> RunningParameters
		{
			get
			{
				return runningParameters;
			}
			set	
			{
				runningParameters = value;
			}
		}

		public class DescribeDatabaseInstanceParameters_ConfigParameter
		{

			private string parameterDescription;

			private string parameterName;

			private string parameterValue;

			private string forceModify;

			private string forceRestart;

			private string checkingCode;

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
		}

		public class DescribeDatabaseInstanceParameters_RunningParameter
		{

			private string parameterDescription;

			private string parameterName;

			private string parameterValue;

			private string forceModify;

			private string forceRestart;

			private string checkingCode;

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
		}
	}
}
