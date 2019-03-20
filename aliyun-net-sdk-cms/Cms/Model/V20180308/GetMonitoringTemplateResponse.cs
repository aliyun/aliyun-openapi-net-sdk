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
	public class GetMonitoringTemplateResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private string errorMessage;

		private GetMonitoringTemplate_Resource resource;

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

		public int? ErrorCode
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public GetMonitoringTemplate_Resource Resource
		{
			get
			{
				return resource;
			}
			set	
			{
				resource = value;
			}
		}

		public class GetMonitoringTemplate_Resource
		{

			private string name;

			private string id;

			private string restVersion;

			private string _namespace;

			private string description;

			private string alertTemplatesJson;

			private string eventRuleTemplatesJson;

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

			public string RestVersion
			{
				get
				{
					return restVersion;
				}
				set	
				{
					restVersion = value;
				}
			}

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
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

			public string AlertTemplatesJson
			{
				get
				{
					return alertTemplatesJson;
				}
				set	
				{
					alertTemplatesJson = value;
				}
			}

			public string EventRuleTemplatesJson
			{
				get
				{
					return eventRuleTemplatesJson;
				}
				set	
				{
					eventRuleTemplatesJson = value;
				}
			}
		}
	}
}
