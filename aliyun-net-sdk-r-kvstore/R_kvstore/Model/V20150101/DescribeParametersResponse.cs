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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeParametersResponse : AcsResponse
	{

		private string requestId;

		private string engine;

		private string engineVersion;

		private List<DescribeParameters_Parameter> configParameters;

		private List<DescribeParameters_Parameter> runningParameters;

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

		public List<DescribeParameters_Parameter> ConfigParameters
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

		public List<DescribeParameters_Parameter> RunningParameters
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

		public class DescribeParameters_Parameter
		{

			private string checkingCode;

			private string parameterName;

			private string parameterValue;

			private bool? forceRestart;

			private string parameterDescription;

			private bool? modifiableStatus;

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

			public bool? ForceRestart
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

			public bool? ModifiableStatus
			{
				get
				{
					return modifiableStatus;
				}
				set	
				{
					modifiableStatus = value;
				}
			}
		}
	}
}
