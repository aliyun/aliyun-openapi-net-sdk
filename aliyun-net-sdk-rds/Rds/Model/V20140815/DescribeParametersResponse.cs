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
	public class DescribeParametersResponse : AcsResponse
	{

		private string requestId;

		private string engine;

		private string engineVersion;

		private List<DescribeParameters_DBInstanceParameter> configParameters;

		private List<DescribeParameters_DBInstanceParameter1> runningParameters;

		private DescribeParameters_ParamGroupInfo paramGroupInfo;

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
		public List<DescribeParameters_DBInstanceParameter> ConfigParameters
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
		public List<DescribeParameters_DBInstanceParameter1> RunningParameters
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

		[JsonProperty(PropertyName = "ParamGroupInfo")]
		public DescribeParameters_ParamGroupInfo ParamGroupInfo
		{
			get
			{
				return paramGroupInfo;
			}
			set	
			{
				paramGroupInfo = value;
			}
		}

		public class DescribeParameters_DBInstanceParameter
		{

			private string parameterDescription;

			private string parameterName;

			private string parameterValue;

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
		}

		public class DescribeParameters_DBInstanceParameter1
		{

			private string parameterDescription;

			private string parameterName;

			private string parameterValue;

			private string parameterValueRange;

			private string parameterDefaultValue;

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

			[JsonProperty(PropertyName = "ParameterValueRange")]
			public string ParameterValueRange
			{
				get
				{
					return parameterValueRange;
				}
				set	
				{
					parameterValueRange = value;
				}
			}

			[JsonProperty(PropertyName = "ParameterDefaultValue")]
			public string ParameterDefaultValue
			{
				get
				{
					return parameterDefaultValue;
				}
				set	
				{
					parameterDefaultValue = value;
				}
			}
		}

		public class DescribeParameters_ParamGroupInfo
		{

			private string parameterGroupName;

			private string parameterGroupDesc;

			private string parameterGroupType;

			private string paramGroupId;

			[JsonProperty(PropertyName = "ParameterGroupName")]
			public string ParameterGroupName
			{
				get
				{
					return parameterGroupName;
				}
				set	
				{
					parameterGroupName = value;
				}
			}

			[JsonProperty(PropertyName = "ParameterGroupDesc")]
			public string ParameterGroupDesc
			{
				get
				{
					return parameterGroupDesc;
				}
				set	
				{
					parameterGroupDesc = value;
				}
			}

			[JsonProperty(PropertyName = "ParameterGroupType")]
			public string ParameterGroupType
			{
				get
				{
					return parameterGroupType;
				}
				set	
				{
					parameterGroupType = value;
				}
			}

			[JsonProperty(PropertyName = "ParamGroupId")]
			public string ParamGroupId
			{
				get
				{
					return paramGroupId;
				}
				set	
				{
					paramGroupId = value;
				}
			}
		}
	}
}
