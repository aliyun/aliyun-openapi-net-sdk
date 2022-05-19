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

namespace Aliyun.Acs.idaas_doraemon.Model.V20210520
{
	public class ListAuthenticationLogsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<ListAuthenticationLogs_AuthenticationLogContentItem> authenticationLogContent;

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

		public long? PageNumber
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

		public long? PageSize
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

		public List<ListAuthenticationLogs_AuthenticationLogContentItem> AuthenticationLogContent
		{
			get
			{
				return authenticationLogContent;
			}
			set	
			{
				authenticationLogContent = value;
			}
		}

		public class ListAuthenticationLogs_AuthenticationLogContentItem
		{

			private string tenantId;

			private string aliUid;

			private string applicationUuid;

			private string applicationExternalId;

			private string userId;

			private string authenticatorUuid;

			private string authenticatorName;

			private string credentialId;

			private string authenticatorType;

			private string authenticationAction;

			private string challengeBase64;

			private long? authenticationTime;

			private string userAgent;

			private string userSourceIp;

			private string rawAuthenticationContext;

			private bool? verifyResult;

			private string errorCode;

			private string errorMessage;

			private string logTag;

			private string logParams;

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string ApplicationUuid
			{
				get
				{
					return applicationUuid;
				}
				set	
				{
					applicationUuid = value;
				}
			}

			public string ApplicationExternalId
			{
				get
				{
					return applicationExternalId;
				}
				set	
				{
					applicationExternalId = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string AuthenticatorUuid
			{
				get
				{
					return authenticatorUuid;
				}
				set	
				{
					authenticatorUuid = value;
				}
			}

			public string AuthenticatorName
			{
				get
				{
					return authenticatorName;
				}
				set	
				{
					authenticatorName = value;
				}
			}

			public string CredentialId
			{
				get
				{
					return credentialId;
				}
				set	
				{
					credentialId = value;
				}
			}

			public string AuthenticatorType
			{
				get
				{
					return authenticatorType;
				}
				set	
				{
					authenticatorType = value;
				}
			}

			public string AuthenticationAction
			{
				get
				{
					return authenticationAction;
				}
				set	
				{
					authenticationAction = value;
				}
			}

			public string ChallengeBase64
			{
				get
				{
					return challengeBase64;
				}
				set	
				{
					challengeBase64 = value;
				}
			}

			public long? AuthenticationTime
			{
				get
				{
					return authenticationTime;
				}
				set	
				{
					authenticationTime = value;
				}
			}

			public string UserAgent
			{
				get
				{
					return userAgent;
				}
				set	
				{
					userAgent = value;
				}
			}

			public string UserSourceIp
			{
				get
				{
					return userSourceIp;
				}
				set	
				{
					userSourceIp = value;
				}
			}

			public string RawAuthenticationContext
			{
				get
				{
					return rawAuthenticationContext;
				}
				set	
				{
					rawAuthenticationContext = value;
				}
			}

			public bool? VerifyResult
			{
				get
				{
					return verifyResult;
				}
				set	
				{
					verifyResult = value;
				}
			}

			public string ErrorCode
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

			public string LogTag
			{
				get
				{
					return logTag;
				}
				set	
				{
					logTag = value;
				}
			}

			public string LogParams
			{
				get
				{
					return logParams;
				}
				set	
				{
					logParams = value;
				}
			}
		}
	}
}
