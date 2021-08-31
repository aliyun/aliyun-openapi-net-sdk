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
	public class GetMockRuleByProviderAppIdResponse : AcsResponse
	{

		private string code;

		private string httpCode;

		private string message;

		private string requestId;

		private bool? success;

		private List<GetMockRuleByProviderAppId_RuleItemList> data;

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

		public List<GetMockRuleByProviderAppId_RuleItemList> Data
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

		public class GetMockRuleByProviderAppId_RuleItemList
		{

			private string accountId;

			private string name;

			private string consumerAppId;

			private string consumerAppName;

			private bool? enable;

			private string extraJson;

			private long? id;

			private string namespaceId;

			private string providerAppId;

			private string providerAppName;

			private string region;

			private string scMockItemJson;

			private string source;

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

			public string NamespaceId
			{
				get
				{
					return namespaceId;
				}
				set	
				{
					namespaceId = value;
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

			public string ScMockItemJson
			{
				get
				{
					return scMockItemJson;
				}
				set	
				{
					scMockItemJson = value;
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
		}
	}
}
