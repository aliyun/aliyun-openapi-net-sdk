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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class SetSecurityPreferenceResponseUnmarshaller
    {
        public static SetSecurityPreferenceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetSecurityPreferenceResponse setSecurityPreferenceResponse = new SetSecurityPreferenceResponse();

			setSecurityPreferenceResponse.HttpResponse = _ctx.HttpResponse;
			setSecurityPreferenceResponse.RequestId = _ctx.StringValue("SetSecurityPreference.RequestId");

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference securityPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference();

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_AccessKeyPreference accessKeyPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_AccessKeyPreference();
			accessKeyPreference.AllowUserToManageAccessKeys = _ctx.BooleanValue("SetSecurityPreference.SecurityPreference.AccessKeyPreference.AllowUserToManageAccessKeys");
			securityPreference.AccessKeyPreference = accessKeyPreference;

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_LoginProfilePreference loginProfilePreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_LoginProfilePreference();
			loginProfilePreference.EnableSaveMFATicket = _ctx.BooleanValue("SetSecurityPreference.SecurityPreference.LoginProfilePreference.EnableSaveMFATicket");
			loginProfilePreference.LoginSessionDuration = _ctx.IntegerValue("SetSecurityPreference.SecurityPreference.LoginProfilePreference.LoginSessionDuration");
			loginProfilePreference.LoginNetworkMasks = _ctx.StringValue("SetSecurityPreference.SecurityPreference.LoginProfilePreference.LoginNetworkMasks");
			loginProfilePreference.AllowUserToChangePassword = _ctx.BooleanValue("SetSecurityPreference.SecurityPreference.LoginProfilePreference.AllowUserToChangePassword");
			loginProfilePreference.EnforceMFAForLogin = _ctx.BooleanValue("SetSecurityPreference.SecurityPreference.LoginProfilePreference.EnforceMFAForLogin");
			loginProfilePreference.OperationForRiskLogin = _ctx.StringValue("SetSecurityPreference.SecurityPreference.LoginProfilePreference.OperationForRiskLogin");
			loginProfilePreference.MFAOperationForLogin = _ctx.StringValue("SetSecurityPreference.SecurityPreference.LoginProfilePreference.MFAOperationForLogin");
			securityPreference.LoginProfilePreference = loginProfilePreference;

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_MFAPreference mFAPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_MFAPreference();
			mFAPreference.AllowUserToManageMFADevices = _ctx.BooleanValue("SetSecurityPreference.SecurityPreference.MFAPreference.AllowUserToManageMFADevices");
			securityPreference.MFAPreference = mFAPreference;

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_VerificationPreference verificationPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_VerificationPreference();

			List<string> verificationPreference_verificationTypes = new List<string>();
			for (int i = 0; i < _ctx.Length("SetSecurityPreference.SecurityPreference.VerificationPreference.VerificationTypes.Length"); i++) {
				verificationPreference_verificationTypes.Add(_ctx.StringValue("SetSecurityPreference.SecurityPreference.VerificationPreference.VerificationTypes["+ i +"]"));
			}
			verificationPreference.VerificationTypes = verificationPreference_verificationTypes;
			securityPreference.VerificationPreference = verificationPreference;

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_PersonalInfoPreference personalInfoPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_PersonalInfoPreference();
			personalInfoPreference.AllowUserToManagePersonalDingTalk = _ctx.BooleanValue("SetSecurityPreference.SecurityPreference.PersonalInfoPreference.AllowUserToManagePersonalDingTalk");
			securityPreference.PersonalInfoPreference = personalInfoPreference;

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_ApplicationLoginPreference applicationLoginPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_ApplicationLoginPreference();
			applicationLoginPreference.AllowUserLongTermLogin = _ctx.BooleanValue("SetSecurityPreference.SecurityPreference.ApplicationLoginPreference.AllowUserLongTermLogin");
			securityPreference.ApplicationLoginPreference = applicationLoginPreference;
			setSecurityPreferenceResponse.SecurityPreference = securityPreference;
        
			return setSecurityPreferenceResponse;
        }
    }
}
