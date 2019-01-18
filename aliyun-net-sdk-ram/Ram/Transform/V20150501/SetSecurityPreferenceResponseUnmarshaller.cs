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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ram.Model.V20150501;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class SetSecurityPreferenceResponseUnmarshaller
    {
        public static SetSecurityPreferenceResponse Unmarshall(UnmarshallerContext context)
        {
			SetSecurityPreferenceResponse setSecurityPreferenceResponse = new SetSecurityPreferenceResponse();

			setSecurityPreferenceResponse.HttpResponse = context.HttpResponse;
			setSecurityPreferenceResponse.RequestId = context.StringValue("SetSecurityPreference.RequestId");

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference securityPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference();

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_LoginProfilePreference loginProfilePreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_LoginProfilePreference();
			loginProfilePreference.EnableSaveMFATicket = context.BooleanValue("SetSecurityPreference.SecurityPreference.LoginProfilePreference.EnableSaveMFATicket");
			loginProfilePreference.AllowUserToChangePassword = context.BooleanValue("SetSecurityPreference.SecurityPreference.LoginProfilePreference.AllowUserToChangePassword");
			securityPreference.LoginProfilePreference = loginProfilePreference;

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_AccessKeyPreference accessKeyPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_AccessKeyPreference();
			accessKeyPreference.AllowUserToManageAccessKeys = context.BooleanValue("SetSecurityPreference.SecurityPreference.AccessKeyPreference.AllowUserToManageAccessKeys");
			securityPreference.AccessKeyPreference = accessKeyPreference;

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_PublicKeyPreference publicKeyPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_PublicKeyPreference();
			publicKeyPreference.AllowUserToManagePublicKeys = context.BooleanValue("SetSecurityPreference.SecurityPreference.PublicKeyPreference.AllowUserToManagePublicKeys");
			securityPreference.PublicKeyPreference = publicKeyPreference;

			SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_MFAPreference mFAPreference = new SetSecurityPreferenceResponse.SetSecurityPreference_SecurityPreference.SetSecurityPreference_MFAPreference();
			mFAPreference.AllowUserToManageMFADevices = context.BooleanValue("SetSecurityPreference.SecurityPreference.MFAPreference.AllowUserToManageMFADevices");
			securityPreference.MFAPreference = mFAPreference;
			setSecurityPreferenceResponse.SecurityPreference = securityPreference;
        
			return setSecurityPreferenceResponse;
        }
    }
}