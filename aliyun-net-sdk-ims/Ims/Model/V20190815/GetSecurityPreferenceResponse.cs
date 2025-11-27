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
	public class GetSecurityPreferenceResponse : AcsResponse
	{

		private string requestId;

		private GetSecurityPreference_SecurityPreference securityPreference;

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

		public GetSecurityPreference_SecurityPreference SecurityPreference
		{
			get
			{
				return securityPreference;
			}
			set	
			{
				securityPreference = value;
			}
		}

		public class GetSecurityPreference_SecurityPreference
		{

			private GetSecurityPreference_AccessKeyPreference accessKeyPreference;

			private GetSecurityPreference_LoginProfilePreference loginProfilePreference;

			private GetSecurityPreference_MFAPreference mFAPreference;

			private GetSecurityPreference_VerificationPreference verificationPreference;

			private GetSecurityPreference_PersonalInfoPreference personalInfoPreference;

			private GetSecurityPreference_ApplicationLoginPreference applicationLoginPreference;

			public GetSecurityPreference_AccessKeyPreference AccessKeyPreference
			{
				get
				{
					return accessKeyPreference;
				}
				set	
				{
					accessKeyPreference = value;
				}
			}

			public GetSecurityPreference_LoginProfilePreference LoginProfilePreference
			{
				get
				{
					return loginProfilePreference;
				}
				set	
				{
					loginProfilePreference = value;
				}
			}

			public GetSecurityPreference_MFAPreference MFAPreference
			{
				get
				{
					return mFAPreference;
				}
				set	
				{
					mFAPreference = value;
				}
			}

			public GetSecurityPreference_VerificationPreference VerificationPreference
			{
				get
				{
					return verificationPreference;
				}
				set	
				{
					verificationPreference = value;
				}
			}

			public GetSecurityPreference_PersonalInfoPreference PersonalInfoPreference
			{
				get
				{
					return personalInfoPreference;
				}
				set	
				{
					personalInfoPreference = value;
				}
			}

			public GetSecurityPreference_ApplicationLoginPreference ApplicationLoginPreference
			{
				get
				{
					return applicationLoginPreference;
				}
				set	
				{
					applicationLoginPreference = value;
				}
			}

			public class GetSecurityPreference_AccessKeyPreference
			{

				private bool? allowUserToManageAccessKeys;

				public bool? AllowUserToManageAccessKeys
				{
					get
					{
						return allowUserToManageAccessKeys;
					}
					set	
					{
						allowUserToManageAccessKeys = value;
					}
				}
			}

			public class GetSecurityPreference_LoginProfilePreference
			{

				private bool? enableSaveMFATicket;

				private int? loginSessionDuration;

				private string loginNetworkMasks;

				private bool? allowUserToChangePassword;

				private bool? enforceMFAForLogin;

				private string operationForRiskLogin;

				private string mFAOperationForLogin;

				public bool? EnableSaveMFATicket
				{
					get
					{
						return enableSaveMFATicket;
					}
					set	
					{
						enableSaveMFATicket = value;
					}
				}

				public int? LoginSessionDuration
				{
					get
					{
						return loginSessionDuration;
					}
					set	
					{
						loginSessionDuration = value;
					}
				}

				public string LoginNetworkMasks
				{
					get
					{
						return loginNetworkMasks;
					}
					set	
					{
						loginNetworkMasks = value;
					}
				}

				public bool? AllowUserToChangePassword
				{
					get
					{
						return allowUserToChangePassword;
					}
					set	
					{
						allowUserToChangePassword = value;
					}
				}

				public bool? EnforceMFAForLogin
				{
					get
					{
						return enforceMFAForLogin;
					}
					set	
					{
						enforceMFAForLogin = value;
					}
				}

				public string OperationForRiskLogin
				{
					get
					{
						return operationForRiskLogin;
					}
					set	
					{
						operationForRiskLogin = value;
					}
				}

				public string MFAOperationForLogin
				{
					get
					{
						return mFAOperationForLogin;
					}
					set	
					{
						mFAOperationForLogin = value;
					}
				}
			}

			public class GetSecurityPreference_MFAPreference
			{

				private bool? allowUserToManageMFADevices;

				public bool? AllowUserToManageMFADevices
				{
					get
					{
						return allowUserToManageMFADevices;
					}
					set	
					{
						allowUserToManageMFADevices = value;
					}
				}
			}

			public class GetSecurityPreference_VerificationPreference
			{

				private List<string> verificationTypes;

				public List<string> VerificationTypes
				{
					get
					{
						return verificationTypes;
					}
					set	
					{
						verificationTypes = value;
					}
				}
			}

			public class GetSecurityPreference_PersonalInfoPreference
			{

				private bool? allowUserToManagePersonalDingTalk;

				public bool? AllowUserToManagePersonalDingTalk
				{
					get
					{
						return allowUserToManagePersonalDingTalk;
					}
					set	
					{
						allowUserToManagePersonalDingTalk = value;
					}
				}
			}

			public class GetSecurityPreference_ApplicationLoginPreference
			{

				private bool? allowUserLongTermLogin;

				public bool? AllowUserLongTermLogin
				{
					get
					{
						return allowUserLongTermLogin;
					}
					set	
					{
						allowUserLongTermLogin = value;
					}
				}
			}
		}
	}
}
