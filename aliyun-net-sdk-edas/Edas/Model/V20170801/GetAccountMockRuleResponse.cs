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
	public class GetAccountMockRuleResponse : AcsResponse
	{

		private string code;

		private string message;

		private bool? success;

		private GetAccountMockRule_Data data;

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

		public GetAccountMockRule_Data Data
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

		public class GetAccountMockRule_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalSize;

			private List<GetAccountMockRule_MseMockRules> result;

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

			public List<GetAccountMockRule_MseMockRules> Result
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

			public class GetAccountMockRule_MseMockRules
			{

				private int? id;

				private string name;

				private string region;

				private bool? enable;

				private int? status;

				private string providerAppId;

				private string providerAppName;

				private string consumerAppId;

				private string consumerAppName;

				private string gmtCreate;

				private string gmtModified;

				private List<GetAccountMockRule_DubboMockItem> dubboMockItems;

				private List<GetAccountMockRule_SpringCloudMockItem> scMockItems;

				public int? Id
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

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public bool? Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public int? Status
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

				public string ProviderAppId
				{
					get
					{
						return providerAppId;
					}
					set	
					{
						providerAppId = value;
					}
				}

				public string ProviderAppName
				{
					get
					{
						return providerAppName;
					}
					set	
					{
						providerAppName = value;
					}
				}

				public string ConsumerAppId
				{
					get
					{
						return consumerAppId;
					}
					set	
					{
						consumerAppId = value;
					}
				}

				public string ConsumerAppName
				{
					get
					{
						return consumerAppName;
					}
					set	
					{
						consumerAppName = value;
					}
				}

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public List<GetAccountMockRule_DubboMockItem> DubboMockItems
				{
					get
					{
						return dubboMockItems;
					}
					set	
					{
						dubboMockItems = value;
					}
				}

				public List<GetAccountMockRule_SpringCloudMockItem> ScMockItems
				{
					get
					{
						return scMockItems;
					}
					set	
					{
						scMockItems = value;
					}
				}

				public class GetAccountMockRule_DubboMockItem
				{

					private string methodName;

					private string oper;

					private string exceptionClassName;

					private string serviceName;

					private string _value;

					private string version;

					private string executeCondition;

					private string group;

					private List<string> paramTypes;

					public string MethodName
					{
						get
						{
							return methodName;
						}
						set	
						{
							methodName = value;
						}
					}

					public string Oper
					{
						get
						{
							return oper;
						}
						set	
						{
							oper = value;
						}
					}

					public string ExceptionClassName
					{
						get
						{
							return exceptionClassName;
						}
						set	
						{
							exceptionClassName = value;
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

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
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

					public string ExecuteCondition
					{
						get
						{
							return executeCondition;
						}
						set	
						{
							executeCondition = value;
						}
					}

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

					public List<string> ParamTypes
					{
						get
						{
							return paramTypes;
						}
						set	
						{
							paramTypes = value;
						}
					}
				}

				public class GetAccountMockRule_SpringCloudMockItem
				{

					private string exceptionClassName;

					private string executeCondition;

					private string method;

					private string oper;

					private string path;

					private string serviceName;

					private string _value;

					public string ExceptionClassName
					{
						get
						{
							return exceptionClassName;
						}
						set	
						{
							exceptionClassName = value;
						}
					}

					public string ExecuteCondition
					{
						get
						{
							return executeCondition;
						}
						set	
						{
							executeCondition = value;
						}
					}

					public string Method
					{
						get
						{
							return method;
						}
						set	
						{
							method = value;
						}
					}

					public string Oper
					{
						get
						{
							return oper;
						}
						set	
						{
							oper = value;
						}
					}

					public string Path
					{
						get
						{
							return path;
						}
						set	
						{
							path = value;
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

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}
		}
	}
}
