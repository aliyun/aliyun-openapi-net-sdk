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

namespace Aliyun.Acs.Ram.Model.V20150501
{
	public class GetPolicyResponse : AcsResponse
	{

		private string requestId;

		private GetPolicy_Policy policy;

		private GetPolicy_DefaultPolicyVersion defaultPolicyVersion;

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

		public GetPolicy_Policy Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
			}
		}

		public GetPolicy_DefaultPolicyVersion DefaultPolicyVersion
		{
			get
			{
				return defaultPolicyVersion;
			}
			set	
			{
				defaultPolicyVersion = value;
			}
		}

		public class GetPolicy_Policy
		{

			private string defaultVersion;

			private string updateDate;

			private string description;

			private string policyDocument;

			private int? attachmentCount;

			private string policyName;

			private string createDate;

			private string policyType;

			public string DefaultVersion
			{
				get
				{
					return defaultVersion;
				}
				set	
				{
					defaultVersion = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string PolicyDocument
			{
				get
				{
					return policyDocument;
				}
				set	
				{
					policyDocument = value;
				}
			}

			public int? AttachmentCount
			{
				get
				{
					return attachmentCount;
				}
				set	
				{
					attachmentCount = value;
				}
			}

			public string PolicyName
			{
				get
				{
					return policyName;
				}
				set	
				{
					policyName = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public string PolicyType
			{
				get
				{
					return policyType;
				}
				set	
				{
					policyType = value;
				}
			}
		}

		public class GetPolicy_DefaultPolicyVersion
		{

			private bool? isDefaultVersion;

			private string policyDocument;

			private string versionId;

			private string createDate;

			public bool? IsDefaultVersion
			{
				get
				{
					return isDefaultVersion;
				}
				set	
				{
					isDefaultVersion = value;
				}
			}

			public string PolicyDocument
			{
				get
				{
					return policyDocument;
				}
				set	
				{
					policyDocument = value;
				}
			}

			public string VersionId
			{
				get
				{
					return versionId;
				}
				set	
				{
					versionId = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}
		}
	}
}
