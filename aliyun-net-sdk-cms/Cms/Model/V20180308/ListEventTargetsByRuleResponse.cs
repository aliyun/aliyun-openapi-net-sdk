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

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class ListEventTargetsByRuleResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private int? parameterCount;

		private List<ListEventTargetsByRule_ContactParameter> contactParameters;

		private List<ListEventTargetsByRule_FCParameter> fcParameters;

		private List<ListEventTargetsByRule_MnsParameter> mnsParameters;

		private List<ListEventTargetsByRule_WebhookParameter> webhookParameters;

		private List<ListEventTargetsByRule_SlsParameter> slsParameters;

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

		public List<ListEventTargetsByRule_ContactParameter> ContactParameters
		{
			get
			{
				return contactParameters;
			}
			set	
			{
				contactParameters = value;
			}
		}

		public List<ListEventTargetsByRule_FCParameter> FcParameters
		{
			get
			{
				return fcParameters;
			}
			set	
			{
				fcParameters = value;
			}
		}

		public List<ListEventTargetsByRule_MnsParameter> MnsParameters
		{
			get
			{
				return mnsParameters;
			}
			set	
			{
				mnsParameters = value;
			}
		}

		public List<ListEventTargetsByRule_WebhookParameter> WebhookParameters
		{
			get
			{
				return webhookParameters;
			}
			set	
			{
				webhookParameters = value;
			}
		}

		public List<ListEventTargetsByRule_SlsParameter> SlsParameters
		{
			get
			{
				return slsParameters;
			}
			set	
			{
				slsParameters = value;
			}
		}

		public class ListEventTargetsByRule_ContactParameter
		{

			private string contactGroupName;

			private string level;

			private string id;

			public string ContactGroupName
			{
				get
				{
					return contactGroupName;
				}
				set	
				{
					contactGroupName = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

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
		}

		public class ListEventTargetsByRule_FCParameter
		{

			private string region;

			private string serviceName;

			private string functionName;

			private string id;

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
		}

		public class ListEventTargetsByRule_MnsParameter
		{

			private string region;

			private string queue;

			private string id;

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

			public string Queue
			{
				get
				{
					return queue;
				}
				set	
				{
					queue = value;
				}
			}

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
		}

		public class ListEventTargetsByRule_WebhookParameter
		{

			private string id;

			private string protocol;

			private string method;

			private string url;

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

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
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

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}
		}

		public class ListEventTargetsByRule_SlsParameter
		{

			private string id;

			private string region;

			private string project;

			private string logStore;

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

			public string Project
			{
				get
				{
					return project;
				}
				set	
				{
					project = value;
				}
			}

			public string LogStore
			{
				get
				{
					return logStore;
				}
				set	
				{
					logStore = value;
				}
			}
		}
	}
}
