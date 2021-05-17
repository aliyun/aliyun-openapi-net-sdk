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
    public class GetUserByExtensionResponseUnmarshaller
    {
        public static GetUserByExtensionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserByExtensionResponse getUserByExtensionResponse = new GetUserByExtensionResponse();

			getUserByExtensionResponse.HttpResponse = _ctx.HttpResponse;
			getUserByExtensionResponse.RequestId = _ctx.StringValue("GetUserByExtension.RequestId");
			getUserByExtensionResponse.Success = _ctx.BooleanValue("GetUserByExtension.Success");
			getUserByExtensionResponse.Code = _ctx.StringValue("GetUserByExtension.Code");
			getUserByExtensionResponse.Message = _ctx.StringValue("GetUserByExtension.Message");
			getUserByExtensionResponse.HttpStatusCode = _ctx.IntegerValue("GetUserByExtension.HttpStatusCode");

			GetUserByExtensionResponse.GetUserByExtension_User user = new GetUserByExtensionResponse.GetUserByExtension_User();
			user.UserId = _ctx.StringValue("GetUserByExtension.User.UserId");
			user.RamId = _ctx.StringValue("GetUserByExtension.User.RamId");
			user.InstanceId = _ctx.StringValue("GetUserByExtension.User.InstanceId");

			GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_Detail detail = new GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_Detail();
			detail.LoginName = _ctx.StringValue("GetUserByExtension.User.Detail.LoginName");
			detail.DisplayName = _ctx.StringValue("GetUserByExtension.User.Detail.DisplayName");
			detail.Phone = _ctx.StringValue("GetUserByExtension.User.Detail.Phone");
			detail.Email = _ctx.StringValue("GetUserByExtension.User.Detail.Email");
			detail.Department = _ctx.StringValue("GetUserByExtension.User.Detail.Department");
			detail.Extension = _ctx.StringValue("GetUserByExtension.User.Detail.Extension");
			user.Detail = detail;

			List<GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_Role> user_roles = new List<GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_Role>();
			for (int i = 0; i < _ctx.Length("GetUserByExtension.User.Roles.Length"); i++) {
				GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_Role role = new GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_Role();
				role.RoleId = _ctx.StringValue("GetUserByExtension.User.Roles["+ i +"].RoleId");
				role.InstanceId = _ctx.StringValue("GetUserByExtension.User.Roles["+ i +"].InstanceId");
				role.RoleName = _ctx.StringValue("GetUserByExtension.User.Roles["+ i +"].RoleName");
				role.RoleDescription = _ctx.StringValue("GetUserByExtension.User.Roles["+ i +"].RoleDescription");

				user_roles.Add(role);
			}
			user.Roles = user_roles;

			List<GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_SkillLevel> user_skillLevels = new List<GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_SkillLevel>();
			for (int i = 0; i < _ctx.Length("GetUserByExtension.User.SkillLevels.Length"); i++) {
				GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_SkillLevel skillLevel = new GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_SkillLevel();
				skillLevel.SkillLevelId = _ctx.StringValue("GetUserByExtension.User.SkillLevels["+ i +"].SkillLevelId");
				skillLevel.Level = _ctx.IntegerValue("GetUserByExtension.User.SkillLevels["+ i +"].Level");

				GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_SkillLevel.GetUserByExtension_Skill skill = new GetUserByExtensionResponse.GetUserByExtension_User.GetUserByExtension_SkillLevel.GetUserByExtension_Skill();
				skill.SkillGroupId = _ctx.StringValue("GetUserByExtension.User.SkillLevels["+ i +"].Skill.SkillGroupId");
				skill.InstanceId = _ctx.StringValue("GetUserByExtension.User.SkillLevels["+ i +"].Skill.InstanceId");
				skill.SkillGroupName = _ctx.StringValue("GetUserByExtension.User.SkillLevels["+ i +"].Skill.SkillGroupName");
				skill.SkillGroupDescription = _ctx.StringValue("GetUserByExtension.User.SkillLevels["+ i +"].Skill.SkillGroupDescription");
				skillLevel.Skill = skill;

				user_skillLevels.Add(skillLevel);
			}
			user.SkillLevels = user_skillLevels;
			getUserByExtensionResponse.User = user;
        
			return getUserByExtensionResponse;
        }
    }
}
