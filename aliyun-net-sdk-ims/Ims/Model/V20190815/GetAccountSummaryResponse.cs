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

namespace Aliyun.Acs.Ims.Model.V20190815
{
	public class GetAccountSummaryResponse : AcsResponse
	{

		private string requestId;

		private GetAccountSummary_SummaryMap summaryMap;

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

		public GetAccountSummary_SummaryMap SummaryMap
		{
			get
			{
				return summaryMap;
			}
			set	
			{
				summaryMap = value;
			}
		}

		public class GetAccountSummary_SummaryMap
		{

			private int? mFADevices;

			private int? accessKeysPerUserQuota;

			private int? attachedPoliciesPerGroupQuota;

			private int? attachedSystemPoliciesPerRoleQuota;

			private int? attachedPoliciesPerRoleQuota;

			private int? groupsPerUserQuota;

			private int? roles;

			private int? policySizeQuota;

			private int? attachedSystemPoliciesPerGroupQuota;

			private int? attachedSystemPoliciesPerUserQuota;

			private int? attachedPoliciesPerUserQuota;

			private int? groupsQuota;

			private int? groups;

			private int? policiesQuota;

			private int? virtualMFADevicesQuota;

			private int? versionsPerPolicyQuota;

			private int? rolesQuota;

			private int? usersQuota;

			private int? policies;

			private int? users;

			private int? mFADevicesInUse;

			public int? MFADevices
			{
				get
				{
					return mFADevices;
				}
				set	
				{
					mFADevices = value;
				}
			}

			public int? AccessKeysPerUserQuota
			{
				get
				{
					return accessKeysPerUserQuota;
				}
				set	
				{
					accessKeysPerUserQuota = value;
				}
			}

			public int? AttachedPoliciesPerGroupQuota
			{
				get
				{
					return attachedPoliciesPerGroupQuota;
				}
				set	
				{
					attachedPoliciesPerGroupQuota = value;
				}
			}

			public int? AttachedSystemPoliciesPerRoleQuota
			{
				get
				{
					return attachedSystemPoliciesPerRoleQuota;
				}
				set	
				{
					attachedSystemPoliciesPerRoleQuota = value;
				}
			}

			public int? AttachedPoliciesPerRoleQuota
			{
				get
				{
					return attachedPoliciesPerRoleQuota;
				}
				set	
				{
					attachedPoliciesPerRoleQuota = value;
				}
			}

			public int? GroupsPerUserQuota
			{
				get
				{
					return groupsPerUserQuota;
				}
				set	
				{
					groupsPerUserQuota = value;
				}
			}

			public int? Roles
			{
				get
				{
					return roles;
				}
				set	
				{
					roles = value;
				}
			}

			public int? PolicySizeQuota
			{
				get
				{
					return policySizeQuota;
				}
				set	
				{
					policySizeQuota = value;
				}
			}

			public int? AttachedSystemPoliciesPerGroupQuota
			{
				get
				{
					return attachedSystemPoliciesPerGroupQuota;
				}
				set	
				{
					attachedSystemPoliciesPerGroupQuota = value;
				}
			}

			public int? AttachedSystemPoliciesPerUserQuota
			{
				get
				{
					return attachedSystemPoliciesPerUserQuota;
				}
				set	
				{
					attachedSystemPoliciesPerUserQuota = value;
				}
			}

			public int? AttachedPoliciesPerUserQuota
			{
				get
				{
					return attachedPoliciesPerUserQuota;
				}
				set	
				{
					attachedPoliciesPerUserQuota = value;
				}
			}

			public int? GroupsQuota
			{
				get
				{
					return groupsQuota;
				}
				set	
				{
					groupsQuota = value;
				}
			}

			public int? Groups
			{
				get
				{
					return groups;
				}
				set	
				{
					groups = value;
				}
			}

			public int? PoliciesQuota
			{
				get
				{
					return policiesQuota;
				}
				set	
				{
					policiesQuota = value;
				}
			}

			public int? VirtualMFADevicesQuota
			{
				get
				{
					return virtualMFADevicesQuota;
				}
				set	
				{
					virtualMFADevicesQuota = value;
				}
			}

			public int? VersionsPerPolicyQuota
			{
				get
				{
					return versionsPerPolicyQuota;
				}
				set	
				{
					versionsPerPolicyQuota = value;
				}
			}

			public int? RolesQuota
			{
				get
				{
					return rolesQuota;
				}
				set	
				{
					rolesQuota = value;
				}
			}

			public int? UsersQuota
			{
				get
				{
					return usersQuota;
				}
				set	
				{
					usersQuota = value;
				}
			}

			public int? Policies
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

			public int? Users
			{
				get
				{
					return users;
				}
				set	
				{
					users = value;
				}
			}

			public int? MFADevicesInUse
			{
				get
				{
					return mFADevicesInUse;
				}
				set	
				{
					mFADevicesInUse = value;
				}
			}
		}
	}
}
