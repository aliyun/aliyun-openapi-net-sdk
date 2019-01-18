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
    public class GetPasswordPolicyResponseUnmarshaller
    {
        public static GetPasswordPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			GetPasswordPolicyResponse getPasswordPolicyResponse = new GetPasswordPolicyResponse();

			getPasswordPolicyResponse.HttpResponse = context.HttpResponse;
			getPasswordPolicyResponse.RequestId = context.StringValue("GetPasswordPolicy.RequestId");

			GetPasswordPolicyResponse.GetPasswordPolicy_PasswordPolicy passwordPolicy = new GetPasswordPolicyResponse.GetPasswordPolicy_PasswordPolicy();
			passwordPolicy.MinimumPasswordLength = context.IntegerValue("GetPasswordPolicy.PasswordPolicy.MinimumPasswordLength");
			passwordPolicy.RequireLowercaseCharacters = context.BooleanValue("GetPasswordPolicy.PasswordPolicy.RequireLowercaseCharacters");
			passwordPolicy.RequireUppercaseCharacters = context.BooleanValue("GetPasswordPolicy.PasswordPolicy.RequireUppercaseCharacters");
			passwordPolicy.RequireNumbers = context.BooleanValue("GetPasswordPolicy.PasswordPolicy.RequireNumbers");
			passwordPolicy.RequireSymbols = context.BooleanValue("GetPasswordPolicy.PasswordPolicy.RequireSymbols");
			passwordPolicy.HardExpiry = context.BooleanValue("GetPasswordPolicy.PasswordPolicy.HardExpiry");
			passwordPolicy.MaxPasswordAge = context.IntegerValue("GetPasswordPolicy.PasswordPolicy.MaxPasswordAge");
			passwordPolicy.PasswordReusePrevention = context.IntegerValue("GetPasswordPolicy.PasswordPolicy.PasswordReusePrevention");
			passwordPolicy.MaxLoginAttemps = context.IntegerValue("GetPasswordPolicy.PasswordPolicy.MaxLoginAttemps");
			getPasswordPolicyResponse.PasswordPolicy = passwordPolicy;
        
			return getPasswordPolicyResponse;
        }
    }
}