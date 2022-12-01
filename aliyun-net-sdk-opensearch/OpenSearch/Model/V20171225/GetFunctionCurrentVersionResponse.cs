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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class GetFunctionCurrentVersionResponse : AcsResponse
	{

		private string status;

		private long? httpCode;

		private string requestId;

		private string message;

		private string code;

		private long? latency;

		private GetFunctionCurrentVersion_Result result;

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

		public long? HttpCode
		{
			get
			{
				return httpCode;
			}
			set	
			{
				httpCode = value;
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public long? Latency
		{
			get
			{
				return latency;
			}
			set	
			{
				latency = value;
			}
		}

		public GetFunctionCurrentVersion_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class GetFunctionCurrentVersion_Result
		{

			private string functionName;

			private string functionType;

			private string modelType;

			private long? versionId;

			private string versionName;

			private GetFunctionCurrentVersion_VersionConfig versionConfig;

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

			public string FunctionType
			{
				get
				{
					return functionType;
				}
				set	
				{
					functionType = value;
				}
			}

			public string ModelType
			{
				get
				{
					return modelType;
				}
				set	
				{
					modelType = value;
				}
			}

			public long? VersionId
			{
				get
				{
					return versionId;
				}
				set	
				{
					versionId = value;
				}
			}

			public string VersionName
			{
				get
				{
					return versionName;
				}
				set	
				{
					versionName = value;
				}
			}

			public GetFunctionCurrentVersion_VersionConfig VersionConfig
			{
				get
				{
					return versionConfig;
				}
				set	
				{
					versionConfig = value;
				}
			}

			public class GetFunctionCurrentVersion_VersionConfig
			{

				private List<GetFunctionCurrentVersion_CreateParametersItem> createParameters;

				private List<GetFunctionCurrentVersion_DependsItem> depends;

				private List<GetFunctionCurrentVersion_UsageParametersItem> usageParameters;

				public List<GetFunctionCurrentVersion_CreateParametersItem> CreateParameters
				{
					get
					{
						return createParameters;
					}
					set	
					{
						createParameters = value;
					}
				}

				public List<GetFunctionCurrentVersion_DependsItem> Depends
				{
					get
					{
						return depends;
					}
					set	
					{
						depends = value;
					}
				}

				public List<GetFunctionCurrentVersion_UsageParametersItem> UsageParameters
				{
					get
					{
						return usageParameters;
					}
					set	
					{
						usageParameters = value;
					}
				}

				public class GetFunctionCurrentVersion_CreateParametersItem
				{

					private string name;

					private string required;

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

					public string Required
					{
						get
						{
							return required;
						}
						set	
						{
							required = value;
						}
					}
				}

				public class GetFunctionCurrentVersion_DependsItem
				{

					private string condition;

					private string dependency;

					private string description;

					public string Condition
					{
						get
						{
							return condition;
						}
						set	
						{
							condition = value;
						}
					}

					public string Dependency
					{
						get
						{
							return dependency;
						}
						set	
						{
							dependency = value;
						}
					}

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
				}

				public class GetFunctionCurrentVersion_UsageParametersItem
				{

					private string name;

					private string required;

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

					public string Required
					{
						get
						{
							return required;
						}
						set	
						{
							required = value;
						}
					}
				}
			}
		}
	}
}
