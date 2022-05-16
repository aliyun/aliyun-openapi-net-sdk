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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeAppServiceDetailResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private DescribeAppServiceDetail_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public DescribeAppServiceDetail_Data Data
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

		public class DescribeAppServiceDetail_Data
		{

			private string group;

			private string serviceName;

			private string version;

			private string serviceType;

			private string edasAppName;

			private string metadata;

			private string springApplicationName;

			private string dubboApplicationName;

			private List<DescribeAppServiceDetail_Method> methods;

			public string Group
			{
				get
				{
					return group;
				}
				set	
				{
					group = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string ServiceType
			{
				get
				{
					return serviceType;
				}
				set	
				{
					serviceType = value;
				}
			}

			public string EdasAppName
			{
				get
				{
					return edasAppName;
				}
				set	
				{
					edasAppName = value;
				}
			}

			public string Metadata
			{
				get
				{
					return metadata;
				}
				set	
				{
					metadata = value;
				}
			}

			public string SpringApplicationName
			{
				get
				{
					return springApplicationName;
				}
				set	
				{
					springApplicationName = value;
				}
			}

			public string DubboApplicationName
			{
				get
				{
					return dubboApplicationName;
				}
				set	
				{
					dubboApplicationName = value;
				}
			}

			public List<DescribeAppServiceDetail_Method> Methods
			{
				get
				{
					return methods;
				}
				set	
				{
					methods = value;
				}
			}

			public class DescribeAppServiceDetail_Method
			{

				private string methodController;

				private string returnType;

				private string returnDetails;

				private string name;

				private string nameDetail;

				private List<DescribeAppServiceDetail_ParameterDefinition> parameterDefinitions;

				private List<string> parameterDetails;

				private List<string> requestMethods;

				private List<string> parameterTypes;

				private List<string> paths;

				public string MethodController
				{
					get
					{
						return methodController;
					}
					set	
					{
						methodController = value;
					}
				}

				public string ReturnType
				{
					get
					{
						return returnType;
					}
					set	
					{
						returnType = value;
					}
				}

				public string ReturnDetails
				{
					get
					{
						return returnDetails;
					}
					set	
					{
						returnDetails = value;
					}
				}

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

				public string NameDetail
				{
					get
					{
						return nameDetail;
					}
					set	
					{
						nameDetail = value;
					}
				}

				public List<DescribeAppServiceDetail_ParameterDefinition> ParameterDefinitions
				{
					get
					{
						return parameterDefinitions;
					}
					set	
					{
						parameterDefinitions = value;
					}
				}

				public List<string> ParameterDetails
				{
					get
					{
						return parameterDetails;
					}
					set	
					{
						parameterDetails = value;
					}
				}

				public List<string> RequestMethods
				{
					get
					{
						return requestMethods;
					}
					set	
					{
						requestMethods = value;
					}
				}

				public List<string> ParameterTypes
				{
					get
					{
						return parameterTypes;
					}
					set	
					{
						parameterTypes = value;
					}
				}

				public List<string> Paths
				{
					get
					{
						return paths;
					}
					set	
					{
						paths = value;
					}
				}

				public class DescribeAppServiceDetail_ParameterDefinition
				{

					private string type;

					private string description;

					private string name;

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
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
				}
			}
		}
	}
}
