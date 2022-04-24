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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterParametersResponse : AcsResponse
	{

		private string dBVersion;

		private string requestId;

		private string dBType;

		private string engine;

		private List<DescribeDBClusterParameters_Parameter> runningParameters;

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
			}
		}

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

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
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

		public List<DescribeDBClusterParameters_Parameter> RunningParameters
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

		public class DescribeDBClusterParameters_Parameter
		{

			private string checkingCode;

			private string dataType;

			private string parameterName;

			private string parameterValue;

			private bool? forceRestart;

			private string parameterDescription;

			private string parameterStatus;

			private string defaultParameterValue;

			private bool? isModifiable;

			private string isNodeAvailable;

			private string paramRelyRule;

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

			public string DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
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

			public string ParameterStatus
			{
				get
				{
					return parameterStatus;
				}
				set	
				{
					parameterStatus = value;
				}
			}

			public string DefaultParameterValue
			{
				get
				{
					return defaultParameterValue;
				}
				set	
				{
					defaultParameterValue = value;
				}
			}

			public bool? IsModifiable
			{
				get
				{
					return isModifiable;
				}
				set	
				{
					isModifiable = value;
				}
			}

			public string IsNodeAvailable
			{
				get
				{
					return isNodeAvailable;
				}
				set	
				{
					isNodeAvailable = value;
				}
			}

			public string ParamRelyRule
			{
				get
				{
					return paramRelyRule;
				}
				set	
				{
					paramRelyRule = value;
				}
			}
		}
	}
}
