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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeParameterTemplatesResponse : AcsResponse
	{

		private string requestId;

		private DescribeParameterTemplates_Data data;

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

		public DescribeParameterTemplates_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeParameterTemplates_Data
		{

			private string engineVersion;

			private string engine;

			private int? parameterCount;

			private List<DescribeParameterTemplates_TemplateRecord> parameters;

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

			public int? ParameterCount
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

				private string parameterName;

				private string parameterValue;

				private string parameterDescription;

				private string checkingCode;

				private int? revisable;

				private int? _dynamic;

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

				public int? Revisable
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

				public int? _Dynamic
				{
					get
					{
						return _dynamic;
					}
					set	
					{
						_dynamic = value;
					}
				}
			}
		}
	}
}
