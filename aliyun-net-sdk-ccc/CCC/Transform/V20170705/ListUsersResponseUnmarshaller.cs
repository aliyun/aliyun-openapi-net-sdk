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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = _ctx.HttpResponse;
			listUsersResponse.RequestId = _ctx.StringValue("ListUsers.RequestId");
			listUsersResponse.Success = _ctx.BooleanValue("ListUsers.Success");
			listUsersResponse.Code = _ctx.StringValue("ListUsers.Code");
			listUsersResponse.Message = _ctx.StringValue("ListUsers.Message");
			listUsersResponse.HttpStatusCode = _ctx.IntegerValue("ListUsers.HttpStatusCode");

			ListUsersResponse.ListUsers_Users users = new ListUsersResponse.ListUsers_Users();
			users.TotalCount = _ctx.IntegerValue("ListUsers.Users.TotalCount");
			users.PageNumber = _ctx.IntegerValue("ListUsers.Users.PageNumber");
			users.PageSize = _ctx.IntegerValue("ListUsers.Users.PageSize");

			List<ListUsersResponse.ListUsers_Users.ListUsers_User> users_list = new List<ListUsersResponse.ListUsers_Users.ListUsers_User>();
			for (int i = 0; i < _ctx.Length("ListUsers.Users.List.Length"); i++) {
				ListUsersResponse.ListUsers_Users.ListUsers_User user = new ListUsersResponse.ListUsers_Users.ListUsers_User();
				user.UserId = _ctx.StringValue("ListUsers.Users.List["+ i +"].UserId");
				user.RamId = _ctx.StringValue("ListUsers.Users.List["+ i +"].RamId");
				user.InstanceId = _ctx.StringValue("ListUsers.Users.List["+ i +"].InstanceId");
				user.Primary = _ctx.BooleanValue("ListUsers.Users.List["+ i +"].Primary");
				user.PrivateOutboundNumberId = _ctx.StringValue("ListUsers.Users.List["+ i +"].PrivateOutboundNumberId");

				ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_Detail detail = new ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_Detail();
				detail.LoginName = _ctx.StringValue("ListUsers.Users.List["+ i +"].Detail.LoginName");
				detail.DisplayName = _ctx.StringValue("ListUsers.Users.List["+ i +"].Detail.DisplayName");
				detail.Phone = _ctx.StringValue("ListUsers.Users.List["+ i +"].Detail.Phone");
				detail.Email = _ctx.StringValue("ListUsers.Users.List["+ i +"].Detail.Email");
				detail.Department = _ctx.StringValue("ListUsers.Users.List["+ i +"].Detail.Department");
				user.Detail = detail;

				List<ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_Role> user_roles = new List<ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_Role>();
				for (int j = 0; j < _ctx.Length("ListUsers.Users.List["+ i +"].Roles.Length"); j++) {
					ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_Role role = new ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_Role();
					role.RoleId = _ctx.StringValue("ListUsers.Users.List["+ i +"].Roles["+ j +"].RoleId");
					role.InstanceId = _ctx.StringValue("ListUsers.Users.List["+ i +"].Roles["+ j +"].InstanceId");
					role.RoleName = _ctx.StringValue("ListUsers.Users.List["+ i +"].Roles["+ j +"].RoleName");
					role.RoleDescription = _ctx.StringValue("ListUsers.Users.List["+ i +"].Roles["+ j +"].RoleDescription");

					user_roles.Add(role);
				}
				user.Roles = user_roles;

				List<ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_SkillLevel> user_skillLevels = new List<ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_SkillLevel>();
				for (int j = 0; j < _ctx.Length("ListUsers.Users.List["+ i +"].SkillLevels.Length"); j++) {
					ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_SkillLevel skillLevel = new ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_SkillLevel();
					skillLevel.SkillLevelId = _ctx.StringValue("ListUsers.Users.List["+ i +"].SkillLevels["+ j +"].SkillLevelId");
					skillLevel.Level = _ctx.IntegerValue("ListUsers.Users.List["+ i +"].SkillLevels["+ j +"].Level");

					ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_SkillLevel.ListUsers_Skill skill = new ListUsersResponse.ListUsers_Users.ListUsers_User.ListUsers_SkillLevel.ListUsers_Skill();
					skill.SkillGroupId = _ctx.StringValue("ListUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupId");
					skill.InstanceId = _ctx.StringValue("ListUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.InstanceId");
					skill.SkillGroupName = _ctx.StringValue("ListUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupName");
					skill.SkillGroupDescription = _ctx.StringValue("ListUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupDescription");
					skillLevel.Skill = skill;

					user_skillLevels.Add(skillLevel);
				}
				user.SkillLevels = user_skillLevels;

				users_list.Add(user);
			}
			users.List = users_list;
			listUsersResponse.Users = users;
        
			return listUsersResponse;
        }
    }
}
