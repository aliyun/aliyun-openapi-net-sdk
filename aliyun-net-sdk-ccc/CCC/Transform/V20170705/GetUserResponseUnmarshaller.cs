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
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = _ctx.HttpResponse;
			getUserResponse.RequestId = _ctx.StringValue("GetUser.RequestId");
			getUserResponse.Success = _ctx.BooleanValue("GetUser.Success");
			getUserResponse.Code = _ctx.StringValue("GetUser.Code");
			getUserResponse.Message = _ctx.StringValue("GetUser.Message");
			getUserResponse.HttpStatusCode = _ctx.IntegerValue("GetUser.HttpStatusCode");

			GetUserResponse.GetUser_User user = new GetUserResponse.GetUser_User();
			user.UserId = _ctx.StringValue("GetUser.User.UserId");
			user.RamId = _ctx.StringValue("GetUser.User.RamId");
			user.InstanceId = _ctx.StringValue("GetUser.User.InstanceId");

			GetUserResponse.GetUser_User.GetUser_Detail detail = new GetUserResponse.GetUser_User.GetUser_Detail();
			detail.LoginName = _ctx.StringValue("GetUser.User.Detail.LoginName");
			detail.DisplayName = _ctx.StringValue("GetUser.User.Detail.DisplayName");
			detail.Phone = _ctx.StringValue("GetUser.User.Detail.Phone");
			detail.Email = _ctx.StringValue("GetUser.User.Detail.Email");
			detail.Department = _ctx.StringValue("GetUser.User.Detail.Department");
			user.Detail = detail;

			List<GetUserResponse.GetUser_User.GetUser_Role> user_roles = new List<GetUserResponse.GetUser_User.GetUser_Role>();
			for (int i = 0; i < _ctx.Length("GetUser.User.Roles.Length"); i++) {
				GetUserResponse.GetUser_User.GetUser_Role role = new GetUserResponse.GetUser_User.GetUser_Role();
				role.RoleId = _ctx.StringValue("GetUser.User.Roles["+ i +"].RoleId");
				role.InstanceId = _ctx.StringValue("GetUser.User.Roles["+ i +"].InstanceId");
				role.RoleName = _ctx.StringValue("GetUser.User.Roles["+ i +"].RoleName");
				role.RoleDescription = _ctx.StringValue("GetUser.User.Roles["+ i +"].RoleDescription");

				user_roles.Add(role);
			}
			user.Roles = user_roles;

			List<GetUserResponse.GetUser_User.GetUser_SkillLevel> user_skillLevels = new List<GetUserResponse.GetUser_User.GetUser_SkillLevel>();
			for (int i = 0; i < _ctx.Length("GetUser.User.SkillLevels.Length"); i++) {
				GetUserResponse.GetUser_User.GetUser_SkillLevel skillLevel = new GetUserResponse.GetUser_User.GetUser_SkillLevel();
				skillLevel.SkillLevelId = _ctx.StringValue("GetUser.User.SkillLevels["+ i +"].SkillLevelId");
				skillLevel.Level = _ctx.IntegerValue("GetUser.User.SkillLevels["+ i +"].Level");

				GetUserResponse.GetUser_User.GetUser_SkillLevel.GetUser_Skill skill = new GetUserResponse.GetUser_User.GetUser_SkillLevel.GetUser_Skill();
				skill.SkillGroupId = _ctx.StringValue("GetUser.User.SkillLevels["+ i +"].Skill.SkillGroupId");
				skill.InstanceId = _ctx.StringValue("GetUser.User.SkillLevels["+ i +"].Skill.InstanceId");
				skill.SkillGroupName = _ctx.StringValue("GetUser.User.SkillLevels["+ i +"].Skill.SkillGroupName");
				skill.SkillGroupDescription = _ctx.StringValue("GetUser.User.SkillLevels["+ i +"].Skill.SkillGroupDescription");
				skillLevel.Skill = skill;

				user_skillLevels.Add(skillLevel);
			}
			user.SkillLevels = user_skillLevels;
			getUserResponse.User = user;
        
			return getUserResponse;
        }
    }
}
