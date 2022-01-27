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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = _ctx.HttpResponse;
			getUserResponse.ErrorCode = _ctx.IntegerValue("GetUser.ErrorCode");
			getUserResponse.Message = _ctx.StringValue("GetUser.Message");
			getUserResponse.Success = _ctx.BooleanValue("GetUser.Success");
			getUserResponse.RequestId = _ctx.StringValue("GetUser.RequestId");

			GetUserResponse.GetUser_UserInfo userInfo = new GetUserResponse.GetUser_UserInfo();
			userInfo.UserName = _ctx.StringValue("GetUser.UserInfo.UserName");
			userInfo.CreateTime = _ctx.LongValue("GetUser.UserInfo.CreateTime");
			userInfo.GroupId = _ctx.StringValue("GetUser.UserInfo.GroupId");
			userInfo.GroupName = _ctx.StringValue("GetUser.UserInfo.GroupName");
			userInfo.UserId = _ctx.StringValue("GetUser.UserInfo.UserId");
			userInfo.UserTel = _ctx.StringValue("GetUser.UserInfo.UserTel");
			userInfo.UserEmail = _ctx.StringValue("GetUser.UserInfo.UserEmail");
			userInfo.UserMobile = _ctx.StringValue("GetUser.UserInfo.UserMobile");
			userInfo.UserAvatarUrl = _ctx.StringValue("GetUser.UserInfo.UserAvatarUrl");
			userInfo.DepartId = _ctx.StringValue("GetUser.UserInfo.DepartId");
			userInfo.DepartName = _ctx.StringValue("GetUser.UserInfo.DepartName");
			userInfo.JobName = _ctx.StringValue("GetUser.UserInfo.JobName");
			getUserResponse.UserInfo = userInfo;
        
			return getUserResponse;
        }
    }
}
