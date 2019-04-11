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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class ListAppPoliciesForIdentityResponse : AcsResponse
	{

		private string requestId;

		private List<ListAppPoliciesForIdentity_AppPolicy> appPolicyList;

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

		public List<ListAppPoliciesForIdentity_AppPolicy> AppPolicyList
		{
			get
			{
				return appPolicyList;
			}
			set	
			{
				appPolicyList = value;
			}
		}

		public class ListAppPoliciesForIdentity_AppPolicy
		{

			private string appId;

			private string creationTime;

			private string policyName;

			private string policyType;

			private string policyValue;

			private string description;

			private string modificationTime;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
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

			public string PolicyValue
			{
				get
				{
					return policyValue;
				}
				set	
				{
					policyValue = value;
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

			public string ModificationTime
			{
				get
				{
					return modificationTime;
				}
				set	
				{
					modificationTime = value;
				}
			}
		}
	}
}
