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
	public class SetSecurityPreferenceResponse : AcsResponse
	{

		private string requestId;

		private SetSecurityPreference_SecurityPreference securityPreference;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "SecurityPreference")]
		public SetSecurityPreference_SecurityPreference SecurityPreference
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

		public class SetSecurityPreference_SecurityPreference
		{

			private SetSecurityPreference_AccessKeyPreference accessKeyPreference;

			private SetSecurityPreference_LoginProfilePreference loginProfilePreference;

			private SetSecurityPreference_MFAPreference mFAPreference;

			private SetSecurityPreference_VerificationPreference verificationPreference;

			private SetSecurityPreference_PersonalInfoPreference personalInfoPreference;

			private SetSecurityPreference_ApplicationLoginPreference applicationLoginPreference;

			[JsonProperty(PropertyName = "AccessKeyPreference")]
			public SetSecurityPreference_AccessKeyPreference AccessKeyPreference
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

			[JsonProperty(PropertyName = "LoginProfilePreference")]
			public SetSecurityPreference_LoginProfilePreference LoginProfilePreference
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

			[JsonProperty(PropertyName = "MFAPreference")]
			public SetSecurityPreference_MFAPreference MFAPreference
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

			[JsonProperty(PropertyName = "VerificationPreference")]
			public SetSecurityPreference_VerificationPreference VerificationPreference
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

			[JsonProperty(PropertyName = "PersonalInfoPreference")]
			public SetSecurityPreference_PersonalInfoPreference PersonalInfoPreference
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

			[JsonProperty(PropertyName = "ApplicationLoginPreference")]
			public SetSecurityPreference_ApplicationLoginPreference ApplicationLoginPreference
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

			public class SetSecurityPreference_AccessKeyPreference
			{

				private bool? allowUserToManageAccessKeys;

				[JsonProperty(PropertyName = "AllowUserToManageAccessKeys")]
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

			public class SetSecurityPreference_LoginProfilePreference
			{

				private bool? enableSaveMFATicket;

				private int? loginSessionDuration;

				private string loginNetworkMasks;

				private bool? allowUserToChangePassword;

				private bool? enforceMFAForLogin;

				private string operationForRiskLogin;

				private string mFAOperationForLogin;

				[JsonProperty(PropertyName = "EnableSaveMFATicket")]
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

				[JsonProperty(PropertyName = "LoginSessionDuration")]
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

				[JsonProperty(PropertyName = "LoginNetworkMasks")]
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

				[JsonProperty(PropertyName = "AllowUserToChangePassword")]
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

				[JsonProperty(PropertyName = "EnforceMFAForLogin")]
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

				[JsonProperty(PropertyName = "OperationForRiskLogin")]
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

				[JsonProperty(PropertyName = "MFAOperationForLogin")]
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

			public class SetSecurityPreference_MFAPreference
			{

				private bool? allowUserToManageMFADevices;

				[JsonProperty(PropertyName = "AllowUserToManageMFADevices")]
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

			public class SetSecurityPreference_VerificationPreference
			{

				private List<string> verificationTypes;

				[JsonProperty(PropertyName = "VerificationTypes")]
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

			public class SetSecurityPreference_PersonalInfoPreference
			{

				private bool? allowUserToManagePersonalDingTalk;

				[JsonProperty(PropertyName = "AllowUserToManagePersonalDingTalk")]
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

			public class SetSecurityPreference_ApplicationLoginPreference
			{

				private bool? allowUserLongTermLogin;

				[JsonProperty(PropertyName = "AllowUserLongTermLogin")]
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
