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
    public class GetPasswordPolicyResponseUnmarshaller
    {
        public static GetPasswordPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPasswordPolicyResponse getPasswordPolicyResponse = new GetPasswordPolicyResponse();

			getPasswordPolicyResponse.HttpResponse = _ctx.HttpResponse;
			getPasswordPolicyResponse.RequestId = _ctx.StringValue("GetPasswordPolicy.RequestId");

			GetPasswordPolicyResponse.GetPasswordPolicy_PasswordPolicy passwordPolicy = new GetPasswordPolicyResponse.GetPasswordPolicy_PasswordPolicy();
			passwordPolicy.RequireNumbers = _ctx.BooleanValue("GetPasswordPolicy.PasswordPolicy.RequireNumbers");
			passwordPolicy.RequireLowercaseCharacters = _ctx.BooleanValue("GetPasswordPolicy.PasswordPolicy.RequireLowercaseCharacters");
			passwordPolicy.PasswordReusePrevention = _ctx.IntegerValue("GetPasswordPolicy.PasswordPolicy.PasswordReusePrevention");
			passwordPolicy.RequireSymbols = _ctx.BooleanValue("GetPasswordPolicy.PasswordPolicy.RequireSymbols");
			passwordPolicy.PasswordNotContainUserName = _ctx.BooleanValue("GetPasswordPolicy.PasswordPolicy.PasswordNotContainUserName");
			passwordPolicy.MinimumPasswordDifferentCharacter = _ctx.IntegerValue("GetPasswordPolicy.PasswordPolicy.MinimumPasswordDifferentCharacter");
			passwordPolicy.MaxPasswordAge = _ctx.IntegerValue("GetPasswordPolicy.PasswordPolicy.MaxPasswordAge");
			passwordPolicy.HardExpire = _ctx.BooleanValue("GetPasswordPolicy.PasswordPolicy.HardExpire");
			passwordPolicy.MinimumPasswordLength = _ctx.IntegerValue("GetPasswordPolicy.PasswordPolicy.MinimumPasswordLength");
			passwordPolicy.RequireUppercaseCharacters = _ctx.BooleanValue("GetPasswordPolicy.PasswordPolicy.RequireUppercaseCharacters");
			passwordPolicy.MaxLoginAttemps = _ctx.IntegerValue("GetPasswordPolicy.PasswordPolicy.MaxLoginAttemps");
			getPasswordPolicyResponse.PasswordPolicy = passwordPolicy;
        
			return getPasswordPolicyResponse;
        }
    }
}
