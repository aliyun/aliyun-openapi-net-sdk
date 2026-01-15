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
	public class RefreshAppInstanceTicketResponse : AcsResponse
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

		private RefreshAppInstanceTicket_Module module;

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
		public RefreshAppInstanceTicket_Module Module
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

		public class RefreshAppInstanceTicket_Module
		{

			private string uuid;

			private string bid;

			private string parentPk;

			private string aliyunPk;

			private string attributes;

			private string authorizationGrantType;

			private string accessTokenValue;

			private string accessTokenIssuedAt;

			private string accessTokenExpiresAt;

			private string refreshTokenValue;

			private string refreshTokenIssuedAt;

			private string refreshTokenExpiresAt;

			[JsonProperty(PropertyName = "Uuid")]
			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			[JsonProperty(PropertyName = "Bid")]
			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
				}
			}

			[JsonProperty(PropertyName = "ParentPk")]
			public string ParentPk
			{
				get
				{
					return parentPk;
				}
				set	
				{
					parentPk = value;
				}
			}

			[JsonProperty(PropertyName = "AliyunPk")]
			public string AliyunPk
			{
				get
				{
					return aliyunPk;
				}
				set	
				{
					aliyunPk = value;
				}
			}

			[JsonProperty(PropertyName = "Attributes")]
			public string Attributes
			{
				get
				{
					return attributes;
				}
				set	
				{
					attributes = value;
				}
			}

			[JsonProperty(PropertyName = "AuthorizationGrantType")]
			public string AuthorizationGrantType
			{
				get
				{
					return authorizationGrantType;
				}
				set	
				{
					authorizationGrantType = value;
				}
			}

			[JsonProperty(PropertyName = "AccessTokenValue")]
			public string AccessTokenValue
			{
				get
				{
					return accessTokenValue;
				}
				set	
				{
					accessTokenValue = value;
				}
			}

			[JsonProperty(PropertyName = "AccessTokenIssuedAt")]
			public string AccessTokenIssuedAt
			{
				get
				{
					return accessTokenIssuedAt;
				}
				set	
				{
					accessTokenIssuedAt = value;
				}
			}

			[JsonProperty(PropertyName = "AccessTokenExpiresAt")]
			public string AccessTokenExpiresAt
			{
				get
				{
					return accessTokenExpiresAt;
				}
				set	
				{
					accessTokenExpiresAt = value;
				}
			}

			[JsonProperty(PropertyName = "RefreshTokenValue")]
			public string RefreshTokenValue
			{
				get
				{
					return refreshTokenValue;
				}
				set	
				{
					refreshTokenValue = value;
				}
			}

			[JsonProperty(PropertyName = "RefreshTokenIssuedAt")]
			public string RefreshTokenIssuedAt
			{
				get
				{
					return refreshTokenIssuedAt;
				}
				set	
				{
					refreshTokenIssuedAt = value;
				}
			}

			[JsonProperty(PropertyName = "RefreshTokenExpiresAt")]
			public string RefreshTokenExpiresAt
			{
				get
				{
					return refreshTokenExpiresAt;
				}
				set	
				{
					refreshTokenExpiresAt = value;
				}
			}
		}
	}
}
