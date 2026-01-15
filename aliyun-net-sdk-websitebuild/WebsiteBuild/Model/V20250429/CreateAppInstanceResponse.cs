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

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
	public class CreateAppInstanceResponse : AcsResponse
	{

		private string requestId;

		private string dynamicCode;

		private string dynamicMessage;

		private bool? synchro;

		private string accessDeniedDetail;

		private string rootErrorMsg;

		private string rootErrorCode;

		private bool? allowRetry;

		private string appName;

		private List<string> errorArgs;

		private CreateAppInstance_Module module;

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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public bool? Synchro
		{
			get
			{
				return synchro;
			}
			set	
			{
				synchro = value;
			}
		}

		public string AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		public string RootErrorMsg
		{
			get
			{
				return rootErrorMsg;
			}
			set	
			{
				rootErrorMsg = value;
			}
		}

		public string RootErrorCode
		{
			get
			{
				return rootErrorCode;
			}
			set	
			{
				rootErrorCode = value;
			}
		}

		public bool? AllowRetry
		{
			get
			{
				return allowRetry;
			}
			set	
			{
				allowRetry = value;
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
			}
		}

		public List<string> ErrorArgs
		{
			get
			{
				return errorArgs;
			}
			set	
			{
				errorArgs = value;
			}
		}

		public CreateAppInstance_Module Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public class CreateAppInstance_Module
		{

			private string bizId;

			private string instanceId;

			private string orderId;

			private string siteHost;

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public string SiteHost
			{
				get
				{
					return siteHost;
				}
				set	
				{
					siteHost = value;
				}
			}
		}
	}
}
