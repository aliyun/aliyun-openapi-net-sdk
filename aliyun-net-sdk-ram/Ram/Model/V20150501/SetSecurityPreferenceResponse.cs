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
	public class SetSecurityPreferenceResponse : AcsResponse
	{

		private string requestId;

		private SetSecurityPreference_SecurityPreference securityPreference;

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

			private SetSecurityPreference_LoginProfilePreference loginProfilePreference;

			private SetSecurityPreference_AccessKeyPreference accessKeyPreference;

			private SetSecurityPreference_PublicKeyPreference publicKeyPreference;

			private SetSecurityPreference_MFAPreference mFAPreference;

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

			public SetSecurityPreference_PublicKeyPreference PublicKeyPreference
			{
				get
				{
					return publicKeyPreference;
				}
				set	
				{
					publicKeyPreference = value;
				}
			}

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

			public class SetSecurityPreference_LoginProfilePreference
			{

				private bool? enableSaveMFATicket;

				private bool? allowUserToChangePassword;

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
			}

			public class SetSecurityPreference_AccessKeyPreference
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

			public class SetSecurityPreference_PublicKeyPreference
			{

				private bool? allowUserToManagePublicKeys;

				public bool? AllowUserToManagePublicKeys
				{
					get
					{
						return allowUserToManagePublicKeys;
					}
					set	
					{
						allowUserToManagePublicKeys = value;
					}
				}
			}

			public class SetSecurityPreference_MFAPreference
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
		}
	}
}