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
        public static GetUserResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = context.HttpResponse;
			getUserResponse.ErrorCode = context.IntegerValue("GetUser.ErrorCode");
			getUserResponse.Message = context.StringValue("GetUser.Message");
			getUserResponse.Success = context.BooleanValue("GetUser.Success");
			getUserResponse.RequestId = context.StringValue("GetUser.RequestId");

			GetUserResponse.GetUser_UserInfo userInfo = new GetUserResponse.GetUser_UserInfo();
			userInfo.UserName = context.StringValue("GetUser.UserInfo.UserName");
			userInfo.CreateTime = context.LongValue("GetUser.UserInfo.CreateTime");
			userInfo.GroupId = context.StringValue("GetUser.UserInfo.GroupId");
			userInfo.GroupName = context.StringValue("GetUser.UserInfo.GroupName");
			userInfo.UserId = context.StringValue("GetUser.UserInfo.UserId");
			userInfo.UserTel = context.StringValue("GetUser.UserInfo.UserTel");
			userInfo.UserEmail = context.StringValue("GetUser.UserInfo.UserEmail");
			userInfo.UserMobile = context.StringValue("GetUser.UserInfo.UserMobile");
			userInfo.UserAvatarUrl = context.StringValue("GetUser.UserInfo.UserAvatarUrl");
			userInfo.DepartId = context.StringValue("GetUser.UserInfo.DepartId");
			userInfo.DepartName = context.StringValue("GetUser.UserInfo.DepartName");
			userInfo.JobName = context.StringValue("GetUser.UserInfo.JobName");
			getUserResponse.UserInfo = userInfo;
        
			return getUserResponse;
        }
    }
}
