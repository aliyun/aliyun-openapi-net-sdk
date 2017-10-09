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
    public class SetPasswordPolicyResponseUnmarshaller
    {
        public static SetPasswordPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			SetPasswordPolicyResponse setPasswordPolicyResponse = new SetPasswordPolicyResponse();

			setPasswordPolicyResponse.HttpResponse = context.HttpResponse;
			setPasswordPolicyResponse.RequestId = context.StringValue("SetPasswordPolicy.RequestId");

			SetPasswordPolicyResponse.SetPasswordPolicy_PasswordPolicy passwordPolicy = new SetPasswordPolicyResponse.SetPasswordPolicy_PasswordPolicy();
			passwordPolicy.MinimumPasswordLength = context.IntegerValue("SetPasswordPolicy.PasswordPolicy.MinimumPasswordLength");
			passwordPolicy.RequireLowercaseCharacters = context.BooleanValue("SetPasswordPolicy.PasswordPolicy.RequireLowercaseCharacters");
			passwordPolicy.RequireUppercaseCharacters = context.BooleanValue("SetPasswordPolicy.PasswordPolicy.RequireUppercaseCharacters");
			passwordPolicy.RequireNumbers = context.BooleanValue("SetPasswordPolicy.PasswordPolicy.RequireNumbers");
			passwordPolicy.RequireSymbols = context.BooleanValue("SetPasswordPolicy.PasswordPolicy.RequireSymbols");
			passwordPolicy.HardExpiry = context.BooleanValue("SetPasswordPolicy.PasswordPolicy.HardExpiry");
			passwordPolicy.MaxPasswordAge = context.IntegerValue("SetPasswordPolicy.PasswordPolicy.MaxPasswordAge");
			passwordPolicy.PasswordReusePrevention = context.IntegerValue("SetPasswordPolicy.PasswordPolicy.PasswordReusePrevention");
			passwordPolicy.MaxLoginAttemps = context.IntegerValue("SetPasswordPolicy.PasswordPolicy.MaxLoginAttemps");
			setPasswordPolicyResponse.PasswordPolicy = passwordPolicy;
        
			return setPasswordPolicyResponse;
        }
    }
}