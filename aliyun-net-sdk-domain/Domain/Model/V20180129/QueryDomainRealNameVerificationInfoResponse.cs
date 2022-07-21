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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryDomainRealNameVerificationInfoResponse : AcsResponse
	{

		private string identityCredentialType;

		private string requestId;

		private string instanceId;

		private string domainName;

		private string identityCredential;

		private string submissionDate;

		private string identityCredentialNo;

		private string identityCredentialUrl;

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

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
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
