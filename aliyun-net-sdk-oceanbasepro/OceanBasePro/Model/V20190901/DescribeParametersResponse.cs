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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeParametersResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeParameters_Data> parameters;

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

		[JsonProperty(PropertyName = "Parameters")]
		public List<DescribeParameters_Data> Parameters
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

		public class DescribeParameters_Data
		{

			private string description;

			private string valueType;

			private string currentValue;

			private bool? needReboot;

			private string name;

			private string defaultValue;

			private bool? _readonly;

			private string unit;

			private List<string> rejectedValue;

			private List<string> acceptableValue;

			[JsonProperty(PropertyName = "Description")]
			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			[JsonProperty(PropertyName = "ValueType")]
			public string ValueType
			{
				get
				{
					return valueType;
				}
				set	
				{
					valueType = value;
				}
			}

			[JsonProperty(PropertyName = "CurrentValue")]
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

			[JsonProperty(PropertyName = "NeedReboot")]
			public bool? NeedReboot
			{
				get
				{
					return needReboot;
				}
				set	
				{
					needReboot = value;
				}
			}

			[JsonProperty(PropertyName = "Name")]
			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			[JsonProperty(PropertyName = "DefaultValue")]
			public string DefaultValue
			{
				get
				{
					return defaultValue;
				}
				set	
				{
					defaultValue = value;
				}
			}

			[JsonProperty(PropertyName = "_Readonly")]
			public bool? _Readonly
			{
				get
				{
					return _readonly;
				}
				set	
				{
					_readonly = value;
				}
			}

			[JsonProperty(PropertyName = "Unit")]
			public string Unit
			{
				get
				{
					return unit;
				}
				set	
				{
					unit = value;
				}
			}

			[JsonProperty(PropertyName = "RejectedValue")]
			public List<string> RejectedValue
			{
				get
				{
					return rejectedValue;
				}
				set	
				{
					rejectedValue = value;
				}
			}

			[JsonProperty(PropertyName = "AcceptableValue")]
			public List<string> AcceptableValue
			{
				get
				{
					return acceptableValue;
				}
				set	
				{
					acceptableValue = value;
				}
			}
		}
	}
}
