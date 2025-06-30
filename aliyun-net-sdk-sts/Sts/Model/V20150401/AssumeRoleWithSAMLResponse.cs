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

namespace Aliyun.Acs.Sts.Model.V20150401
{
	public class AssumeRoleWithSAMLResponse : AcsResponse
	{

		private string requestId;

		private string sourceIdentity;

		private AssumeRoleWithSAML_SAMLAssertionInfo sAMLAssertionInfo;

		private AssumeRoleWithSAML_AssumedRoleUser assumedRoleUser;

		private AssumeRoleWithSAML_Credentials credentials;

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

		public string SourceIdentity
		{
			get
			{
				return sourceIdentity;
			}
			set	
			{
				sourceIdentity = value;
			}
		}

		public AssumeRoleWithSAML_SAMLAssertionInfo SAMLAssertionInfo
		{
			get
			{
				return sAMLAssertionInfo;
			}
			set	
			{
				sAMLAssertionInfo = value;
			}
		}

		public AssumeRoleWithSAML_AssumedRoleUser AssumedRoleUser
		{
			get
			{
				return assumedRoleUser;
			}
			set	
			{
				assumedRoleUser = value;
			}
		}

		public AssumeRoleWithSAML_Credentials Credentials
		{
			get
			{
				return credentials;
			}
			set	
			{
				credentials = value;
			}
		}

		public class AssumeRoleWithSAML_SAMLAssertionInfo
		{

			private string subjectType;

			private string subject;

			private string issuer;

			private string recipient;

			public string SubjectType
			{
				get
				{
					return subjectType;
				}
				set	
				{
					subjectType = value;
				}
			}

			public string Subject
			{
				get
				{
					return subject;
				}
				set	
				{
					subject = value;
				}
			}

			public string Issuer
			{
				get
				{
					return issuer;
				}
				set	
				{
					issuer = value;
				}
			}

			public string Recipient
			{
				get
				{
					return recipient;
				}
				set	
				{
					recipient = value;
				}
			}
		}

		public class AssumeRoleWithSAML_AssumedRoleUser
		{

			private string assumedRoleId;

			private string arn;

			public string AssumedRoleId
			{
				get
				{
					return assumedRoleId;
				}
				set	
				{
					assumedRoleId = value;
				}
			}

			public string Arn
			{
				get
				{
					return arn;
				}
				set	
				{
					arn = value;
				}
			}
		}

		public class AssumeRoleWithSAML_Credentials
		{

			private string securityToken;

			private string expiration;

			private string accessKeySecret;

			private string accessKeyId;

			public string SecurityToken
			{
				get
				{
					return securityToken;
				}
				set	
				{
					securityToken = value;
				}
			}

			public string Expiration
			{
				get
				{
					return expiration;
				}
				set	
				{
					expiration = value;
				}
			}

			public string AccessKeySecret
			{
				get
				{
					return accessKeySecret;
				}
				set	
				{
					accessKeySecret = value;
				}
			}

			public string AccessKeyId
			{
				get
				{
					return accessKeyId;
				}
				set	
				{
					accessKeyId = value;
				}
			}
		}
	}
}
