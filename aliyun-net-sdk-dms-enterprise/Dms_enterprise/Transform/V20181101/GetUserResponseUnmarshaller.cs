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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = _ctx.HttpResponse;
			getUserResponse.RequestId = _ctx.StringValue("GetUser.RequestId");
			getUserResponse.ErrorCode = _ctx.StringValue("GetUser.ErrorCode");
			getUserResponse.ErrorMessage = _ctx.StringValue("GetUser.ErrorMessage");
			getUserResponse.Success = _ctx.BooleanValue("GetUser.Success");

			GetUserResponse.GetUser_User user = new GetUserResponse.GetUser_User();
			user.State = _ctx.StringValue("GetUser.User.State");
			user.CurResultCount = _ctx.LongValue("GetUser.User.CurResultCount");
			user.UserId = _ctx.StringValue("GetUser.User.UserId");
			user.LastLoginTime = _ctx.StringValue("GetUser.User.LastLoginTime");
			user.MaxResultCount = _ctx.LongValue("GetUser.User.MaxResultCount");
			user.ParentUid = _ctx.LongValue("GetUser.User.ParentUid");
			user.NickName = _ctx.StringValue("GetUser.User.NickName");
			user.MaxExecuteCount = _ctx.LongValue("GetUser.User.MaxExecuteCount");
			user.CurExecuteCount = _ctx.LongValue("GetUser.User.CurExecuteCount");
			user.Mobile = _ctx.StringValue("GetUser.User.Mobile");
			user.Uid = _ctx.StringValue("GetUser.User.Uid");

			List<string> user_roleIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetUser.User.RoleIdList.Length"); i++) {
				user_roleIdList.Add(_ctx.StringValue("GetUser.User.RoleIdList["+ i +"]"));
			}
			user.RoleIdList = user_roleIdList;

			List<string> user_roleNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetUser.User.RoleNameList.Length"); i++) {
				user_roleNameList.Add(_ctx.StringValue("GetUser.User.RoleNameList["+ i +"]"));
			}
			user.RoleNameList = user_roleNameList;
			getUserResponse.User = user;
        
			return getUserResponse;
        }
    }
}
