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
	public class ListAuthenticatorsResponse : AcsResponse
	{

		private string requestId;

		private long? pageNumber;

		private long? totalCount;

		private long? pageSize;

		private List<ListAuthenticators_AuthenticatorListDTO> authenticator;

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

		public List<ListAuthenticators_AuthenticatorListDTO> Authenticator
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

		public class ListAuthenticators_AuthenticatorListDTO
		{

			private string applicationExternalId;

			private string authenticatorUuid;

			private string credentialId;

			private string type;

			private string authenticatorName;

			private long? registerTime;

			private long? lastVerifyTime;

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
		}
	}
}
