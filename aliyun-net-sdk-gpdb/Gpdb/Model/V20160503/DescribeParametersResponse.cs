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

namespace Aliyun.Acs.gpdb.Model.V20160503
{
	public class DescribeParametersResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeParameters_ParametersItem> parameters;

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

		public List<DescribeParameters_ParametersItem> Parameters
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

		public class DescribeParameters_ParametersItem
		{

			private string isChangeableConfig;

			private string forceRestartInstance;

			private string optionalRange;

			private string parameterName;

			private string parameterValue;

			private string parameterDescription;

			private string currentValue;

			public string IsChangeableConfig
			{
				get
				{
					return isChangeableConfig;
				}
				set	
				{
					isChangeableConfig = value;
				}
			}

			public string ForceRestartInstance
			{
				get
				{
					return forceRestartInstance;
				}
				set	
				{
					forceRestartInstance = value;
				}
			}

			public string OptionalRange
			{
				get
				{
					return optionalRange;
				}
				set	
				{
					optionalRange = value;
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

			public string CurrentValue
			{
				get
				{
					return currentValue;
				}
				set	
				{
					currentValue = value;
				}
			}
		}
	}
}
