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
    public class UpdateLoginProfileResponseUnmarshaller
    {
        public static UpdateLoginProfileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateLoginProfileResponse updateLoginProfileResponse = new UpdateLoginProfileResponse();

			updateLoginProfileResponse.HttpResponse = _ctx.HttpResponse;
			updateLoginProfileResponse.RequestId = _ctx.StringValue("UpdateLoginProfile.RequestId");

			UpdateLoginProfileResponse.UpdateLoginProfile_LoginProfile loginProfile = new UpdateLoginProfileResponse.UpdateLoginProfile_LoginProfile();
			loginProfile.UserPrincipalName = _ctx.StringValue("UpdateLoginProfile.LoginProfile.UserPrincipalName");
			loginProfile.Status = _ctx.StringValue("UpdateLoginProfile.LoginProfile.Status");
			loginProfile.Password = _ctx.StringValue("UpdateLoginProfile.LoginProfile.Password");
			loginProfile.UpdateDate = _ctx.StringValue("UpdateLoginProfile.LoginProfile.UpdateDate");
			loginProfile.PasswordResetRequired = _ctx.BooleanValue("UpdateLoginProfile.LoginProfile.PasswordResetRequired");
			loginProfile.MFABindRequired = _ctx.BooleanValue("UpdateLoginProfile.LoginProfile.MFABindRequired");
			loginProfile.CreateDate = _ctx.StringValue("UpdateLoginProfile.LoginProfile.CreateDate");
			updateLoginProfileResponse.LoginProfile = loginProfile;
        
			return updateLoginProfileResponse;
        }
    }
}
