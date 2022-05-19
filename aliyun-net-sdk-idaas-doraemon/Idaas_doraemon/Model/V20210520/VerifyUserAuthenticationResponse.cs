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
	public class VerifyUserAuthenticationResponse : AcsResponse
	{

		private string requestId;

		private bool? verifyResult;

		private string etasSDKString;

		private string idToken;

		private VerifyUserAuthentication_AuthenticateResultInfo authenticateResultInfo;

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

		public string EtasSDKString
		{
			get
			{
				return etasSDKString;
			}
			set	
			{
				etasSDKString = value;
			}
		}

		public string IdToken
		{
			get
			{
				return idToken;
			}
			set	
			{
				idToken = value;
			}
		}

		public VerifyUserAuthentication_AuthenticateResultInfo AuthenticateResultInfo
		{
			get
			{
				return authenticateResultInfo;
			}
			set	
			{
				authenticateResultInfo = value;
			}
		}

		public class VerifyUserAuthentication_AuthenticateResultInfo
		{

			private string userId;

			private string credentialId;

			private string bindHashBase64;

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

			public string BindHashBase64
			{
				get
				{
					return bindHashBase64;
				}
				set	
				{
					bindHashBase64 = value;
				}
			}
		}
	}
}
