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
	public class DescribeParameterGroupTemplateListResponse : AcsResponse
	{

		private string requestId;

		private string engineVersion;

		private List<DescribeParameterGroupTemplateList_ParametersItem> parameters;

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

		public List<DescribeParameterGroupTemplateList_ParametersItem> Parameters
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

		public class DescribeParameterGroupTemplateList_ParametersItem
		{

			private bool? supportModifyForMinorVersion;

			private string checkingCode;

			private string parameterValue;

			private long? revisable;

			private long? factor;

			private string parameterName;

			private string unit;

			private string parameterDescription;

			private long? effective;

			public bool? SupportModifyForMinorVersion
			{
				get
				{
					return supportModifyForMinorVersion;
				}
				set	
				{
					supportModifyForMinorVersion = value;
				}
			}

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

			public long? Revisable
			{
				get
				{
					return revisable;
				}
				set	
				{
					revisable = value;
				}
			}

			public long? Factor
			{
				get
				{
					return factor;
				}
				set	
				{
					factor = value;
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

			public long? Effective
			{
				get
				{
					return effective;
				}
				set	
				{
					effective = value;
				}
			}
		}
	}
}
