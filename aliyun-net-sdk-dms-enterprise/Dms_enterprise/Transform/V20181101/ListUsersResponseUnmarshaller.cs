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
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = _ctx.HttpResponse;
			listUsersResponse.TotalCount = _ctx.LongValue("ListUsers.TotalCount");
			listUsersResponse.RequestId = _ctx.StringValue("ListUsers.RequestId");
			listUsersResponse.ErrorCode = _ctx.StringValue("ListUsers.ErrorCode");
			listUsersResponse.ErrorMessage = _ctx.StringValue("ListUsers.ErrorMessage");
			listUsersResponse.Success = _ctx.BooleanValue("ListUsers.Success");

			List<ListUsersResponse.ListUsers_User> listUsersResponse_userList = new List<ListUsersResponse.ListUsers_User>();
			for (int i = 0; i < _ctx.Length("ListUsers.UserList.Length"); i++) {
				ListUsersResponse.ListUsers_User user = new ListUsersResponse.ListUsers_User();
				user.State = _ctx.StringValue("ListUsers.UserList["+ i +"].State");
				user.CurResultCount = _ctx.LongValue("ListUsers.UserList["+ i +"].CurResultCount");
				user.UserId = _ctx.StringValue("ListUsers.UserList["+ i +"].UserId");
				user.LastLoginTime = _ctx.StringValue("ListUsers.UserList["+ i +"].LastLoginTime");
				user.MaxResultCount = _ctx.LongValue("ListUsers.UserList["+ i +"].MaxResultCount");
				user.ParentUid = _ctx.StringValue("ListUsers.UserList["+ i +"].ParentUid");
				user.NickName = _ctx.StringValue("ListUsers.UserList["+ i +"].NickName");
				user.MaxExecuteCount = _ctx.LongValue("ListUsers.UserList["+ i +"].MaxExecuteCount");
				user.CurExecuteCount = _ctx.LongValue("ListUsers.UserList["+ i +"].CurExecuteCount");
				user.Mobile = _ctx.StringValue("ListUsers.UserList["+ i +"].Mobile");
				user.Uid = _ctx.StringValue("ListUsers.UserList["+ i +"].Uid");

				List<string> user_roleIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListUsers.UserList["+ i +"].RoleIdList.Length"); j++) {
					user_roleIdList.Add(_ctx.StringValue("ListUsers.UserList["+ i +"].RoleIdList["+ j +"]"));
				}
				user.RoleIdList = user_roleIdList;

				List<string> user_roleNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListUsers.UserList["+ i +"].RoleNameList.Length"); j++) {
					user_roleNameList.Add(_ctx.StringValue("ListUsers.UserList["+ i +"].RoleNameList["+ j +"]"));
				}
				user.RoleNameList = user_roleNameList;

				listUsersResponse_userList.Add(user);
			}
			listUsersResponse.UserList = listUsersResponse_userList;
        
			return listUsersResponse;
        }
    }
}
