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
	public class ListPoliciesForGroupResponse : AcsResponse
	{

		private string requestId;

		private List<ListPoliciesForGroup_Policy> policies;

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

		public List<ListPoliciesForGroup_Policy> Policies
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

		public class ListPoliciesForGroup_Policy
		{

			private string policyName;

			private string policyType;

			private string description;

			private string defaultVersion;

			private string attachDate;

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

			public string AttachDate
			{
				get
				{
					return attachDate;
				}
				set	
				{
					attachDate = value;
				}
			}
		}
	}
}