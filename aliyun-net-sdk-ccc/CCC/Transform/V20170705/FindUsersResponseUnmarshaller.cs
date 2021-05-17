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
    public class FindUsersResponseUnmarshaller
    {
        public static FindUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			FindUsersResponse findUsersResponse = new FindUsersResponse();

			findUsersResponse.HttpResponse = _ctx.HttpResponse;
			findUsersResponse.RequestId = _ctx.StringValue("FindUsers.RequestId");
			findUsersResponse.Success = _ctx.BooleanValue("FindUsers.Success");
			findUsersResponse.Code = _ctx.StringValue("FindUsers.Code");
			findUsersResponse.Message = _ctx.StringValue("FindUsers.Message");
			findUsersResponse.HttpStatusCode = _ctx.IntegerValue("FindUsers.HttpStatusCode");

			FindUsersResponse.FindUsers_Users users = new FindUsersResponse.FindUsers_Users();
			users.TotalCount = _ctx.IntegerValue("FindUsers.Users.TotalCount");
			users.PageNumber = _ctx.IntegerValue("FindUsers.Users.PageNumber");
			users.PageSize = _ctx.IntegerValue("FindUsers.Users.PageSize");

			List<FindUsersResponse.FindUsers_Users.FindUsers_User> users_list = new List<FindUsersResponse.FindUsers_Users.FindUsers_User>();
			for (int i = 0; i < _ctx.Length("FindUsers.Users.List.Length"); i++) {
				FindUsersResponse.FindUsers_Users.FindUsers_User user = new FindUsersResponse.FindUsers_Users.FindUsers_User();
				user.UserId = _ctx.StringValue("FindUsers.Users.List["+ i +"].UserId");
				user.RamId = _ctx.StringValue("FindUsers.Users.List["+ i +"].RamId");
				user.InstanceId = _ctx.StringValue("FindUsers.Users.List["+ i +"].InstanceId");
				user.PrivateOutboundNumberId = _ctx.StringValue("FindUsers.Users.List["+ i +"].PrivateOutboundNumberId");

				FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Detail detail = new FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Detail();
				detail.LoginName = _ctx.StringValue("FindUsers.Users.List["+ i +"].Detail.LoginName");
				detail.DisplayName = _ctx.StringValue("FindUsers.Users.List["+ i +"].Detail.DisplayName");
				detail.Phone = _ctx.StringValue("FindUsers.Users.List["+ i +"].Detail.Phone");
				detail.Email = _ctx.StringValue("FindUsers.Users.List["+ i +"].Detail.Email");
				detail.Department = _ctx.StringValue("FindUsers.Users.List["+ i +"].Detail.Department");
				user.Detail = detail;

				List<FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Role> user_roles = new List<FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Role>();
				for (int j = 0; j < _ctx.Length("FindUsers.Users.List["+ i +"].Roles.Length"); j++) {
					FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Role role = new FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Role();
					role.RoleId = _ctx.StringValue("FindUsers.Users.List["+ i +"].Roles["+ j +"].RoleId");
					role.InstanceId = _ctx.StringValue("FindUsers.Users.List["+ i +"].Roles["+ j +"].InstanceId");
					role.RoleName = _ctx.StringValue("FindUsers.Users.List["+ i +"].Roles["+ j +"].RoleName");
					role.RoleDescription = _ctx.StringValue("FindUsers.Users.List["+ i +"].Roles["+ j +"].RoleDescription");

					user_roles.Add(role);
				}
				user.Roles = user_roles;

				List<FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel> user_skillLevels = new List<FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel>();
				for (int j = 0; j < _ctx.Length("FindUsers.Users.List["+ i +"].SkillLevels.Length"); j++) {
					FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel skillLevel = new FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel();
					skillLevel.SkillLevelId = _ctx.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].SkillLevelId");
					skillLevel.Level = _ctx.IntegerValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Level");

					FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel.FindUsers_Skill skill = new FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel.FindUsers_Skill();
					skill.SkillGroupId = _ctx.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupId");
					skill.InstanceId = _ctx.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.InstanceId");
					skill.SkillGroupName = _ctx.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupName");
					skill.SkillGroupDescription = _ctx.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupDescription");
					skillLevel.Skill = skill;

					user_skillLevels.Add(skillLevel);
				}
				user.SkillLevels = user_skillLevels;

				users_list.Add(user);
			}
			users.List = users_list;
			findUsersResponse.Users = users;
        
			return findUsersResponse;
        }
    }
}
