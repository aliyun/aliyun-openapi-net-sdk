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
	public class ModifyAppInstanceSpecResponse : AcsResponse
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

		private ModifyAppInstanceSpec_Module module;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "DynamicCode")]
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

		[JsonProperty(PropertyName = "DynamicMessage")]
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

		[JsonProperty(PropertyName = "Synchro")]
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

		[JsonProperty(PropertyName = "AccessDeniedDetail")]
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

		[JsonProperty(PropertyName = "RootErrorMsg")]
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

		[JsonProperty(PropertyName = "RootErrorCode")]
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

		[JsonProperty(PropertyName = "AllowRetry")]
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

		[JsonProperty(PropertyName = "AppName")]
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

		[JsonProperty(PropertyName = "ErrorArgs")]
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

		[JsonProperty(PropertyName = "Module")]
		public ModifyAppInstanceSpec_Module Module
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

		public class ModifyAppInstanceSpec_Module
		{

			private string orderId;

			[JsonProperty(PropertyName = "OrderId")]
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
		}
	}
}
