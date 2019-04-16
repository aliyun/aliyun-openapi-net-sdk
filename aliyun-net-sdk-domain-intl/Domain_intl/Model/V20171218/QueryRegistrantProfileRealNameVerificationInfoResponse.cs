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

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
	public class QueryRegistrantProfileRealNameVerificationInfoResponse : AcsResponse
	{

		private string requestId;

		private string submissionDate;

		private string modificationDate;

		private string identityCredential;

		private long? registrantProfileId;

		private string identityCredentialNo;

		private string identityCredentialType;

		private string identityCredentialUrl;

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

		public string SubmissionDate
		{
			get
			{
				return submissionDate;
			}
			set	
			{
				submissionDate = value;
			}
		}

		public string ModificationDate
		{
			get
			{
				return modificationDate;
			}
			set	
			{
				modificationDate = value;
			}
		}

		public string IdentityCredential
		{
			get
			{
				return identityCredential;
			}
			set	
			{
				identityCredential = value;
			}
		}

		public long? RegistrantProfileId
		{
			get
			{
				return registrantProfileId;
			}
			set	
			{
				registrantProfileId = value;
			}
		}

		public string IdentityCredentialNo
		{
			get
			{
				return identityCredentialNo;
			}
			set	
			{
				identityCredentialNo = value;
			}
		}

		public string IdentityCredentialType
		{
			get
			{
				return identityCredentialType;
			}
			set	
			{
				identityCredentialType = value;
			}
		}

		public string IdentityCredentialUrl
		{
			get
			{
				return identityCredentialUrl;
			}
			set	
			{
				identityCredentialUrl = value;
			}
		}
	}
}
