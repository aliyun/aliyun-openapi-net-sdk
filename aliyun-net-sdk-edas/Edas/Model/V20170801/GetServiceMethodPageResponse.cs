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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetServiceMethodPageResponse : AcsResponse
	{

		private string code;

		private string message;

		private bool? success;

		private string requestId;

		private string httpCode;

		private GetServiceMethodPage_Data data;

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

		public string HttpCode
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

		public GetServiceMethodPage_Data Data
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

		public class GetServiceMethodPage_Data
		{

			private int? pageNumber;

			private int? totalSize;

			private int? pageSize;

			private List<GetServiceMethodPage_Method> result;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public int? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public List<GetServiceMethodPage_Method> Result
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

			public class GetServiceMethodPage_Method
			{

				private string name;

				private string returnType;

				private string methodController;

				private string nameDetail;

				private string returnDetails;

				private string parameterTypes;

				private string parameterNames;

				private string parameterDetails;

				private string requestMethods;

				private string paths;

				private string parameterDefinitions;

				private GetServiceMethodPage_ReturnDefinition returnDefinition;

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

				public string ParameterTypes
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

				public string ParameterNames
				{
					get
					{
						return parameterNames;
					}
					set	
					{
						parameterNames = value;
					}
				}

				public string ParameterDetails
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

				public string RequestMethods
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

				public string Paths
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

				public string ParameterDefinitions
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

				public GetServiceMethodPage_ReturnDefinition ReturnDefinition
				{
					get
					{
						return returnDefinition;
					}
					set	
					{
						returnDefinition = value;
					}
				}

				public class GetServiceMethodPage_ReturnDefinition
				{

					private string id;

					private string type;

					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
						}
					}

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
				}
			}
		}
	}
}
