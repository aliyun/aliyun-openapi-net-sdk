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
    public class ListUsersOfSkillGroupResponseUnmarshaller
    {
        public static ListUsersOfSkillGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersOfSkillGroupResponse listUsersOfSkillGroupResponse = new ListUsersOfSkillGroupResponse();

			listUsersOfSkillGroupResponse.HttpResponse = _ctx.HttpResponse;
			listUsersOfSkillGroupResponse.RequestId = _ctx.StringValue("ListUsersOfSkillGroup.RequestId");
			listUsersOfSkillGroupResponse.Success = _ctx.BooleanValue("ListUsersOfSkillGroup.Success");
			listUsersOfSkillGroupResponse.Code = _ctx.StringValue("ListUsersOfSkillGroup.Code");
			listUsersOfSkillGroupResponse.Message = _ctx.StringValue("ListUsersOfSkillGroup.Message");
			listUsersOfSkillGroupResponse.HttpStatusCode = _ctx.IntegerValue("ListUsersOfSkillGroup.HttpStatusCode");

			ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users users = new ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users();
			users.TotalCount = _ctx.IntegerValue("ListUsersOfSkillGroup.Users.TotalCount");
			users.PageNumber = _ctx.IntegerValue("ListUsersOfSkillGroup.Users.PageNumber");
			users.PageSize = _ctx.IntegerValue("ListUsersOfSkillGroup.Users.PageSize");

			List<ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User> users_list = new List<ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User>();
			for (int i = 0; i < _ctx.Length("ListUsersOfSkillGroup.Users.List.Length"); i++) {
				ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User user = new ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User();
				user.UserId = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].UserId");
				user.RamId = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].RamId");
				user.InstanceId = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].InstanceId");

				ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Detail detail = new ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Detail();
				detail.LoginName = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Detail.LoginName");
				detail.DisplayName = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Detail.DisplayName");
				detail.Phone = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Detail.Phone");
				detail.Email = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Detail.Email");
				detail.Department = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Detail.Department");
				user.Detail = detail;

				List<ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Role> user_roles = new List<ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Role>();
				for (int j = 0; j < _ctx.Length("ListUsersOfSkillGroup.Users.List["+ i +"].Roles.Length"); j++) {
					ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Role role = new ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Role();
					role.RoleId = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Roles["+ j +"].RoleId");
					role.InstanceId = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Roles["+ j +"].InstanceId");
					role.RoleName = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Roles["+ j +"].RoleName");
					role.RoleDescription = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Roles["+ j +"].RoleDescription");
					role.UserCount = _ctx.IntegerValue("ListUsersOfSkillGroup.Users.List["+ i +"].Roles["+ j +"].UserCount");

					List<ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Role.ListUsersOfSkillGroup_Privilege> role_privileges = new List<ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Role.ListUsersOfSkillGroup_Privilege>();
					for (int k = 0; k < _ctx.Length("ListUsersOfSkillGroup.Users.List["+ i +"].Roles["+ j +"].Privileges.Length"); k++) {
						ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Role.ListUsersOfSkillGroup_Privilege privilege = new ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_Role.ListUsersOfSkillGroup_Privilege();
						privilege.PrivilegeId = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Roles["+ j +"].Privileges["+ k +"].PrivilegeId");
						privilege.PrivilegeName = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Roles["+ j +"].Privileges["+ k +"].PrivilegeName");
						privilege.PrivilegeDescription = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].Roles["+ j +"].Privileges["+ k +"].PrivilegeDescription");

						role_privileges.Add(privilege);
					}
					role.Privileges = role_privileges;

					user_roles.Add(role);
				}
				user.Roles = user_roles;

				List<ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_SkillLevel> user_skillLevels = new List<ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_SkillLevel>();
				for (int j = 0; j < _ctx.Length("ListUsersOfSkillGroup.Users.List["+ i +"].SkillLevels.Length"); j++) {
					ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_SkillLevel skillLevel = new ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_SkillLevel();
					skillLevel.SkillLevelId = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].SkillLevels["+ j +"].SkillLevelId");
					skillLevel.Level = _ctx.IntegerValue("ListUsersOfSkillGroup.Users.List["+ i +"].SkillLevels["+ j +"].Level");

					ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_SkillLevel.ListUsersOfSkillGroup_Skill skill = new ListUsersOfSkillGroupResponse.ListUsersOfSkillGroup_Users.ListUsersOfSkillGroup_User.ListUsersOfSkillGroup_SkillLevel.ListUsersOfSkillGroup_Skill();
					skill.SkillGroupId = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupId");
					skill.InstanceId = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].SkillLevels["+ j +"].Skill.InstanceId");
					skill.SkillGroupName = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupName");
					skill.SkillGroupDescription = _ctx.StringValue("ListUsersOfSkillGroup.Users.List["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupDescription");
					skillLevel.Skill = skill;

					user_skillLevels.Add(skillLevel);
				}
				user.SkillLevels = user_skillLevels;

				users_list.Add(user);
			}
			users.List = users_list;
			listUsersOfSkillGroupResponse.Users = users;
        
			return listUsersOfSkillGroupResponse;
        }
    }
}
