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
	public class ListFunctionInstancesResponse : AcsResponse
	{

		private string status;

		private long? httpCode;

		private long? totalCount;

		private string requestId;

		private string message;

		private string code;

		private long? latency;

		private List<ListFunctionInstances_ResultItem> result;

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

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public List<ListFunctionInstances_ResultItem> Result
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

		public class ListFunctionInstances_ResultItem
		{

			private long? createTime;

			private string cron;

			private string description;

			private string extendInfo;

			private string functionName;

			private string functionType;

			private string instanceName;

			private string modelType;

			private string source;

			private string status;

			private long? versionId;

			private List<ListFunctionInstances_CreateParametersItem> createParameters;

			private List<ListFunctionInstances_UsageParametersItem> usageParameters;

			private ListFunctionInstances_Belongs belongs;

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string Cron
			{
				get
				{
					return cron;
				}
				set	
				{
					cron = value;
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

			public string ExtendInfo
			{
				get
				{
					return extendInfo;
				}
				set	
				{
					extendInfo = value;
				}
			}

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

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
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

			public List<ListFunctionInstances_CreateParametersItem> CreateParameters
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

			public List<ListFunctionInstances_UsageParametersItem> UsageParameters
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

			public ListFunctionInstances_Belongs Belongs
			{
				get
				{
					return belongs;
				}
				set	
				{
					belongs = value;
				}
			}

			public class ListFunctionInstances_CreateParametersItem
			{

				private string name;

				private string _value;

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

			public class ListFunctionInstances_UsageParametersItem
			{

				private string name;

				private string _value;

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

			public class ListFunctionInstances_Belongs
			{

				private string category;

				private string domain;

				private string language;

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public string Domain
				{
					get
					{
						return domain;
					}
					set	
					{
						domain = value;
					}
				}

				public string Language
				{
					get
					{
						return language;
					}
					set	
					{
						language = value;
					}
				}
			}
		}
	}
}
