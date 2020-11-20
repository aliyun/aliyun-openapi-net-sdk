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
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = _ctx.HttpResponse;
			listUsersResponse.ErrorCode = _ctx.IntegerValue("ListUsers.ErrorCode");
			listUsersResponse.Message = _ctx.StringValue("ListUsers.Message");
			listUsersResponse.Success = _ctx.BooleanValue("ListUsers.Success");
			listUsersResponse.RequestId = _ctx.StringValue("ListUsers.RequestId");

			ListUsersResponse.ListUsers_Data data = new ListUsersResponse.ListUsers_Data();
			data.TotalCount = _ctx.IntegerValue("ListUsers.Data.TotalCount");
			data.PageSize = _ctx.IntegerValue("ListUsers.Data.PageSize");
			data.PageNumber = _ctx.IntegerValue("ListUsers.Data.PageNumber");

			List<ListUsersResponse.ListUsers_Data.ListUsers_UserInfo> data_userInfos = new List<ListUsersResponse.ListUsers_Data.ListUsers_UserInfo>();
			for (int i = 0; i < _ctx.Length("ListUsers.Data.UserInfos.Length"); i++) {
				ListUsersResponse.ListUsers_Data.ListUsers_UserInfo userInfo = new ListUsersResponse.ListUsers_Data.ListUsers_UserInfo();
				userInfo.CreateTime = _ctx.LongValue("ListUsers.Data.UserInfos["+ i +"].CreateTime");
				userInfo.GroupName = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].GroupName");
				userInfo.UserName = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].UserName");
				userInfo.GroupId = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].GroupId");
				userInfo.DepartName = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].DepartName");
				userInfo.DepartId = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].DepartId");
				userInfo.UserEmail = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].UserEmail");
				userInfo.UserTel = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].UserTel");
				userInfo.UserMobile = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].UserMobile");
				userInfo.UserAvatarUrl = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].UserAvatarUrl");
				userInfo.JobName = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].JobName");
				userInfo.UserId = _ctx.StringValue("ListUsers.Data.UserInfos["+ i +"].UserId");

				data_userInfos.Add(userInfo);
			}
			data.UserInfos = data_userInfos;
			listUsersResponse.Data = data;
        
			return listUsersResponse;
        }
    }
}
