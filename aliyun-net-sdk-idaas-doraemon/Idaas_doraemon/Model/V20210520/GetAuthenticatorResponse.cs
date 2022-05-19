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
	public class GetAuthenticatorResponse : AcsResponse
	{

		private string requestId;

		private GetAuthenticator_Authenticator authenticator;

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

		public GetAuthenticator_Authenticator Authenticator
		{
			get
			{
				return authenticator;
			}
			set	
			{
				authenticator = value;
			}
		}

		public class GetAuthenticator_Authenticator
		{

			private string authenticatorUuid;

			private string credentialId;

			private string type;

			private string authenticatorName;

			private long? registerTime;

			private long? lastVerifyTime;

			private string registerSourceIp;

			private string lastVerifySourceIp;

			private string lastVerifyUserAgent;

			private string customAuthenticator;

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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			public long? RegisterTime
			{
				get
				{
					return registerTime;
				}
				set	
				{
					registerTime = value;
				}
			}

			public long? LastVerifyTime
			{
				get
				{
					return lastVerifyTime;
				}
				set	
				{
					lastVerifyTime = value;
				}
			}

			public string RegisterSourceIp
			{
				get
				{
					return registerSourceIp;
				}
				set	
				{
					registerSourceIp = value;
				}
			}

			public string LastVerifySourceIp
			{
				get
				{
					return lastVerifySourceIp;
				}
				set	
				{
					lastVerifySourceIp = value;
				}
			}

			public string LastVerifyUserAgent
			{
				get
				{
					return lastVerifyUserAgent;
				}
				set	
				{
					lastVerifyUserAgent = value;
				}
			}

			public string CustomAuthenticator
			{
				get
				{
					return customAuthenticator;
				}
				set	
				{
					customAuthenticator = value;
				}
			}
		}
	}
}
