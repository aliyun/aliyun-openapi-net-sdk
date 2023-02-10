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
using Aliyun.Acs.Ram.Model.V20150501;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class SetPasswordPolicyResponseUnmarshaller
    {
        public static SetPasswordPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetPasswordPolicyResponse setPasswordPolicyResponse = new SetPasswordPolicyResponse();

			setPasswordPolicyResponse.HttpResponse = _ctx.HttpResponse;
			setPasswordPolicyResponse.RequestId = _ctx.StringValue("SetPasswordPolicy.RequestId");

			SetPasswordPolicyResponse.SetPasswordPolicy_PasswordPolicy passwordPolicy = new SetPasswordPolicyResponse.SetPasswordPolicy_PasswordPolicy();
			passwordPolicy.RequireNumbers = _ctx.BooleanValue("SetPasswordPolicy.PasswordPolicy.RequireNumbers");
			passwordPolicy.RequireLowercaseCharacters = _ctx.BooleanValue("SetPasswordPolicy.PasswordPolicy.RequireLowercaseCharacters");
			passwordPolicy.HardExpiry = _ctx.BooleanValue("SetPasswordPolicy.PasswordPolicy.HardExpiry");
			passwordPolicy.PasswordReusePrevention = _ctx.IntegerValue("SetPasswordPolicy.PasswordPolicy.PasswordReusePrevention");
			passwordPolicy.RequireSymbols = _ctx.BooleanValue("SetPasswordPolicy.PasswordPolicy.RequireSymbols");
			passwordPolicy.MaxPasswordAge = _ctx.IntegerValue("SetPasswordPolicy.PasswordPolicy.MaxPasswordAge");
			passwordPolicy.MinimumPasswordLength = _ctx.IntegerValue("SetPasswordPolicy.PasswordPolicy.MinimumPasswordLength");
			passwordPolicy.RequireUppercaseCharacters = _ctx.BooleanValue("SetPasswordPolicy.PasswordPolicy.RequireUppercaseCharacters");
			passwordPolicy.MaxLoginAttemps = _ctx.IntegerValue("SetPasswordPolicy.PasswordPolicy.MaxLoginAttemps");
			setPasswordPolicyResponse.PasswordPolicy = passwordPolicy;
        
			return setPasswordPolicyResponse;
        }
    }
}
