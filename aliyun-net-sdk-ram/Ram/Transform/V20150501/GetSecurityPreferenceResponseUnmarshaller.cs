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
    public class GetSecurityPreferenceResponseUnmarshaller
    {
        public static GetSecurityPreferenceResponse Unmarshall(UnmarshallerContext context)
        {
			GetSecurityPreferenceResponse getSecurityPreferenceResponse = new GetSecurityPreferenceResponse();

			getSecurityPreferenceResponse.HttpResponse = context.HttpResponse;
			getSecurityPreferenceResponse.RequestId = context.StringValue("GetSecurityPreference.RequestId");

			GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference securityPreference = new GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference();

			GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference.GetSecurityPreference_LoginProfilePreference loginProfilePreference = new GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference.GetSecurityPreference_LoginProfilePreference();
			loginProfilePreference.EnableSaveMFATicket = context.BooleanValue("GetSecurityPreference.SecurityPreference.LoginProfilePreference.EnableSaveMFATicket");
			loginProfilePreference.AllowUserToChangePassword = context.BooleanValue("GetSecurityPreference.SecurityPreference.LoginProfilePreference.AllowUserToChangePassword");
			securityPreference.LoginProfilePreference = loginProfilePreference;

			GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference.GetSecurityPreference_AccessKeyPreference accessKeyPreference = new GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference.GetSecurityPreference_AccessKeyPreference();
			accessKeyPreference.AllowUserToManageAccessKeys = context.BooleanValue("GetSecurityPreference.SecurityPreference.AccessKeyPreference.AllowUserToManageAccessKeys");
			securityPreference.AccessKeyPreference = accessKeyPreference;

			GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference.GetSecurityPreference_PublicKeyPreference publicKeyPreference = new GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference.GetSecurityPreference_PublicKeyPreference();
			publicKeyPreference.AllowUserToManagePublicKeys = context.BooleanValue("GetSecurityPreference.SecurityPreference.PublicKeyPreference.AllowUserToManagePublicKeys");
			securityPreference.PublicKeyPreference = publicKeyPreference;

			GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference.GetSecurityPreference_MFAPreference mFAPreference = new GetSecurityPreferenceResponse.GetSecurityPreference_SecurityPreference.GetSecurityPreference_MFAPreference();
			mFAPreference.AllowUserToManageMFADevices = context.BooleanValue("GetSecurityPreference.SecurityPreference.MFAPreference.AllowUserToManageMFADevices");
			securityPreference.MFAPreference = mFAPreference;
			getSecurityPreferenceResponse.SecurityPreference = securityPreference;
        
			return getSecurityPreferenceResponse;
        }
    }
}