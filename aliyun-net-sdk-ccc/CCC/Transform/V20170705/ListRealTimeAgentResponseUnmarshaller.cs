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
    public class ListRealTimeAgentResponseUnmarshaller
    {
        public static ListRealTimeAgentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRealTimeAgentResponse listRealTimeAgentResponse = new ListRealTimeAgentResponse();

			listRealTimeAgentResponse.HttpResponse = _ctx.HttpResponse;
			listRealTimeAgentResponse.RequestId = _ctx.StringValue("ListRealTimeAgent.RequestId");
			listRealTimeAgentResponse.Success = _ctx.BooleanValue("ListRealTimeAgent.Success");
			listRealTimeAgentResponse.Code = _ctx.StringValue("ListRealTimeAgent.Code");
			listRealTimeAgentResponse.Message = _ctx.StringValue("ListRealTimeAgent.Message");
			listRealTimeAgentResponse.HttpStatusCode = _ctx.IntegerValue("ListRealTimeAgent.HttpStatusCode");

			List<ListRealTimeAgentResponse.ListRealTimeAgent_User> listRealTimeAgentResponse_data = new List<ListRealTimeAgentResponse.ListRealTimeAgent_User>();
			for (int i = 0; i < _ctx.Length("ListRealTimeAgent.Data.Length"); i++) {
				ListRealTimeAgentResponse.ListRealTimeAgent_User user = new ListRealTimeAgentResponse.ListRealTimeAgent_User();
				user.RamId = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].RamId");
				user.DisplayName = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].DisplayName");
				user.Phone = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].Phone");
				user.Dn = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].Dn");
				user.State = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].State");
				user.StateDesc = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].StateDesc");

				List<ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel> user_skillLevels = new List<ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel>();
				for (int j = 0; j < _ctx.Length("ListRealTimeAgent.Data["+ i +"].SkillLevels.Length"); j++) {
					ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel skillLevel = new ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel();
					skillLevel.SkillLevelId = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].SkillLevelId");
					skillLevel.Level = _ctx.IntegerValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Level");

					ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel.ListRealTimeAgent_Skill skill = new ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel.ListRealTimeAgent_Skill();
					skill.SkillGroupId = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupId");
					skill.InstanceId = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Skill.InstanceId");
					skill.SkillGroupName = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupName");
					skill.SkillGroupDescription = _ctx.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupDescription");
					skillLevel.Skill = skill;

					user_skillLevels.Add(skillLevel);
				}
				user.SkillLevels = user_skillLevels;

				listRealTimeAgentResponse_data.Add(user);
			}
			listRealTimeAgentResponse.Data = listRealTimeAgentResponse_data;
        
			return listRealTimeAgentResponse;
        }
    }
}
