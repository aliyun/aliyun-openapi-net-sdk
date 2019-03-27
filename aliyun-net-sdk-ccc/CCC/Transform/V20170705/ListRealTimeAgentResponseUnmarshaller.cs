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
        public static ListRealTimeAgentResponse Unmarshall(UnmarshallerContext context)
        {
			ListRealTimeAgentResponse listRealTimeAgentResponse = new ListRealTimeAgentResponse();

			listRealTimeAgentResponse.HttpResponse = context.HttpResponse;
			listRealTimeAgentResponse.RequestId = context.StringValue("ListRealTimeAgent.RequestId");
			listRealTimeAgentResponse.Success = context.BooleanValue("ListRealTimeAgent.Success");
			listRealTimeAgentResponse.Code = context.StringValue("ListRealTimeAgent.Code");
			listRealTimeAgentResponse.Message = context.StringValue("ListRealTimeAgent.Message");
			listRealTimeAgentResponse.HttpStatusCode = context.IntegerValue("ListRealTimeAgent.HttpStatusCode");

			List<ListRealTimeAgentResponse.ListRealTimeAgent_User> listRealTimeAgentResponse_data = new List<ListRealTimeAgentResponse.ListRealTimeAgent_User>();
			for (int i = 0; i < context.Length("ListRealTimeAgent.Data.Length"); i++) {
				ListRealTimeAgentResponse.ListRealTimeAgent_User user = new ListRealTimeAgentResponse.ListRealTimeAgent_User();
				user.RamId = context.StringValue("ListRealTimeAgent.Data["+ i +"].RamId");
				user.DisplayName = context.StringValue("ListRealTimeAgent.Data["+ i +"].DisplayName");
				user.Phone = context.StringValue("ListRealTimeAgent.Data["+ i +"].Phone");
				user.Dn = context.StringValue("ListRealTimeAgent.Data["+ i +"].Dn");
				user.State = context.StringValue("ListRealTimeAgent.Data["+ i +"].State");
				user.StateDesc = context.StringValue("ListRealTimeAgent.Data["+ i +"].StateDesc");

				List<ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel> user_skillLevels = new List<ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel>();
				for (int j = 0; j < context.Length("ListRealTimeAgent.Data["+ i +"].SkillLevels.Length"); j++) {
					ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel skillLevel = new ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel();
					skillLevel.SkillLevelId = context.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].SkillLevelId");
					skillLevel.Level = context.IntegerValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Level");

					ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel.ListRealTimeAgent_Skill skill = new ListRealTimeAgentResponse.ListRealTimeAgent_User.ListRealTimeAgent_SkillLevel.ListRealTimeAgent_Skill();
					skill.SkillGroupId = context.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupId");
					skill.InstanceId = context.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Skill.InstanceId");
					skill.SkillGroupName = context.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupName");
					skill.SkillGroupDescription = context.StringValue("ListRealTimeAgent.Data["+ i +"].SkillLevels["+ j +"].Skill.SkillGroupDescription");
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
