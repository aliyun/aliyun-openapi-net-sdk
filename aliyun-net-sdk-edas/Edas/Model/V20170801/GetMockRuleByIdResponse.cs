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
	public class GetMockRuleByIdResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetMockRuleById_Data data;

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

		public GetMockRuleById_Data Data
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

		public class GetMockRuleById_Data
		{

			private string accountId;

			private string name;

			private string consumerAppId;

			private string consumerAppName;

			private bool? enable;

			private string extraJson;

			private long? id;

			private string providerAppId;

			private string providerAppName;

			private string region;

			private string source;

			private List<GetMockRuleById_SpringCloudMockItem> scMockItems;

			private List<GetMockRuleById_DubboMockItem> dubboMockItems;

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
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

			public string ExtraJson
			{
				get
				{
					return extraJson;
				}
				set	
				{
					extraJson = value;
				}
			}

			public long? Id
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

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public List<GetMockRuleById_SpringCloudMockItem> ScMockItems
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

			public List<GetMockRuleById_DubboMockItem> DubboMockItems
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

			public class GetMockRuleById_SpringCloudMockItem
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

			public class GetMockRuleById_DubboMockItem
			{

				private string exceptionClassName;

				private string executeCondition;

				private string methodName;

				private string oper;

				private string path;

				private string serviceName;

				private string _value;

				private string version;

				private string group;

				private string paramTypes;

				private string exceptionMessage;

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

				public string ParamTypes
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

				public string ExceptionMessage
				{
					get
					{
						return exceptionMessage;
					}
					set	
					{
						exceptionMessage = value;
					}
				}
			}
		}
	}
}
