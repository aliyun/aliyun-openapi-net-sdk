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
    public class CreateLoginProfileResponseUnmarshaller
    {
        public static CreateLoginProfileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateLoginProfileResponse createLoginProfileResponse = new CreateLoginProfileResponse();

			createLoginProfileResponse.HttpResponse = _ctx.HttpResponse;
			createLoginProfileResponse.RequestId = _ctx.StringValue("CreateLoginProfile.RequestId");

			CreateLoginProfileResponse.CreateLoginProfile_LoginProfile loginProfile = new CreateLoginProfileResponse.CreateLoginProfile_LoginProfile();
			loginProfile.UserPrincipalName = _ctx.StringValue("CreateLoginProfile.LoginProfile.UserPrincipalName");
			loginProfile.Status = _ctx.StringValue("CreateLoginProfile.LoginProfile.Status");
			loginProfile.Password = _ctx.StringValue("CreateLoginProfile.LoginProfile.Password");
			loginProfile.UpdateDate = _ctx.StringValue("CreateLoginProfile.LoginProfile.UpdateDate");
			loginProfile.PasswordResetRequired = _ctx.BooleanValue("CreateLoginProfile.LoginProfile.PasswordResetRequired");
			loginProfile.MFABindRequired = _ctx.BooleanValue("CreateLoginProfile.LoginProfile.MFABindRequired");
			loginProfile.CreateDate = _ctx.StringValue("CreateLoginProfile.LoginProfile.CreateDate");
			createLoginProfileResponse.LoginProfile = loginProfile;
        
			return createLoginProfileResponse;
        }
    }
}
