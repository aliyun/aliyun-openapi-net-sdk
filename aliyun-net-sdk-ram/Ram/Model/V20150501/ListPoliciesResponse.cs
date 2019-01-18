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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Model.V20150501
{
	public class ListPoliciesResponse : AcsResponse
	{

		private string requestId;

		private bool? isTruncated;

		private string marker;

		private List<ListPolicies_Policy> policies;

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

		public bool? IsTruncated
		{
			get
			{
				return isTruncated;
			}
			set	
			{
				isTruncated = value;
			}
		}

		public string Marker
		{
			get
			{
				return marker;
			}
			set	
			{
				marker = value;
			}
		}

		public List<ListPolicies_Policy> Policies
		{
			get
			{
				return policies;
			}
			set	
			{
				policies = value;
			}
		}

		public class ListPolicies_Policy
		{

			private string policyName;

			private string policyType;

			private string description;

			private string defaultVersion;

			private string createDate;

			private string updateDate;

			private int? attachmentCount;

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
		}
	}
}