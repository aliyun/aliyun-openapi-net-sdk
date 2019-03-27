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
        public static FindUsersResponse Unmarshall(UnmarshallerContext context)
        {
			FindUsersResponse findUsersResponse = new FindUsersResponse();

			findUsersResponse.HttpResponse = context.HttpResponse;
			findUsersResponse.RequestId = context.StringValue("FindUsers.RequestId");
			findUsersResponse.Success = context.BooleanValue("FindUsers.Success");
			findUsersResponse.Code = context.StringValue("FindUsers.Code");
			findUsersResponse.Message = context.StringValue("FindUsers.Message");
			findUsersResponse.HttpStatusCode = context.IntegerValue("FindUsers.HttpStatusCode");

			FindUsersResponse.FindUsers_Users users = new FindUsersResponse.FindUsers_Users();
			users.TotalCount = context.IntegerValue("FindUsers.Users.TotalCount");
			users.PageNumber = context.IntegerValue("FindUsers.Users.PageNumber");
			users.PageSize = context.IntegerValue("FindUsers.Users.PageSize");

			List<FindUsersResponse.FindUsers_Users.FindUsers_User> users_list = new List<FindUsersResponse.FindUsers_Users.FindUsers_User>();
			for (int i = 0; i < context.Length("FindUsers.Users.List.Length"); i++) {
				FindUsersResponse.FindUsers_Users.FindUsers_User user = new FindUsersResponse.FindUsers_Users.FindUsers_User();
				user.UserId = context.StringValue("FindUsers.Users.List["+ i +"].UserId");
				user.RamId = context.StringValue("FindUsers.Users.List["+ i +"].RamId");
				user.InstanceId = context.StringValue("FindUsers.Users.List["+ i +"].InstanceId");
				user.PrivateOutboundNumberId = context.StringValue("FindUsers.Users.List["+ i +"].PrivateOutboundNumberId");

				FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Detail detail = new FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Detail();
				detail.LoginName = context.StringValue("FindUsers.Users.List["+ i +"].Detail.LoginName");
				detail.DisplayName = context.StringValue("FindUsers.Users.List["+ i +"].Detail.DisplayName");
				detail.Phone = context.StringValue("FindUsers.Users.List["+ i +"].Detail.Phone");
				detail.Email = context.StringValue("FindUsers.Users.List["+ i +"].Detail.Email");
				detail.Department = context.StringValue("FindUsers.Users.List["+ i +"].Detail.Department");
				user.Detail = detail;

				List<FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Role> user_roles = new List<FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Role>();
				for (int j = 0; j < context.Length("FindUsers.Users.List["+ i +"].Roles.Length"); j++) {
					FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Role role = new FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_Role();
					role.RoleId = context.StringValue("FindUsers.Users.List["+ i +"].Roles["+ j +"].RoleId");
					role.InstanceId = context.StringValue("FindUsers.Users.List["+ i +"].Roles["+ j +"].InstanceId");
					role.RoleName = context.StringValue("FindUsers.Users.List["+ i +"].Roles["+ j +"].RoleName");
					role.RoleDescription = context.StringValue("FindUsers.Users.List["+ i +"].Roles["+ j +"].RoleDescription");

					user_roles.Add(role);
				}
				user.Roles = user_roles;

				List<FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel> user_skillLevels = new List<FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel>();
				for (int j = 0; j < context.Length("FindUsers.Users.List["+ i +"].SkillLevels.Length"); j++) {
					FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel skillLevel = new FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel();
					skillLevel.SkillLevelId = context.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].SkillLevelId");
					skillLevel.Level = context.IntegerValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Level");

					FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel.FindUsers_Skill skill = new FindUsersResponse.FindUsers_Users.FindUsers_User.FindUsers_SkillLevel.FindUsers_Skill();
					skill.SkillGroupId = context.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupId");
					skill.InstanceId = context.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.InstanceId");
					skill.SkillGroupName = context.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupName");
					skill.SkillGroupDescription = context.StringValue("FindUsers.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupDescription");
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
