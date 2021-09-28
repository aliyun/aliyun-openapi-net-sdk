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
    public class ListTransferableSkillGroupsResponseUnmarshaller
    {
        public static ListTransferableSkillGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransferableSkillGroupsResponse listTransferableSkillGroupsResponse = new ListTransferableSkillGroupsResponse();

			listTransferableSkillGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listTransferableSkillGroupsResponse.RequestId = _ctx.StringValue("ListTransferableSkillGroups.RequestId");
			listTransferableSkillGroupsResponse.Success = _ctx.BooleanValue("ListTransferableSkillGroups.Success");
			listTransferableSkillGroupsResponse.Code = _ctx.StringValue("ListTransferableSkillGroups.Code");
			listTransferableSkillGroupsResponse.Message = _ctx.StringValue("ListTransferableSkillGroups.Message");
			listTransferableSkillGroupsResponse.HttpStatusCode = _ctx.IntegerValue("ListTransferableSkillGroups.HttpStatusCode");

			List<ListTransferableSkillGroupsResponse.ListTransferableSkillGroups_SkillGroup> listTransferableSkillGroupsResponse_skillGroups = new List<ListTransferableSkillGroupsResponse.ListTransferableSkillGroups_SkillGroup>();
			for (int i = 0; i < _ctx.Length("ListTransferableSkillGroups.SkillGroups.Length"); i++) {
				ListTransferableSkillGroupsResponse.ListTransferableSkillGroups_SkillGroup skillGroup = new ListTransferableSkillGroupsResponse.ListTransferableSkillGroups_SkillGroup();
				skillGroup.SkillGroupId = _ctx.StringValue("ListTransferableSkillGroups.SkillGroups["+ i +"].SkillGroupId");
				skillGroup.InstanceId = _ctx.StringValue("ListTransferableSkillGroups.SkillGroups["+ i +"].InstanceId");
				skillGroup.SkillGroupName = _ctx.StringValue("ListTransferableSkillGroups.SkillGroups["+ i +"].SkillGroupName");
				skillGroup.AccSkillGroupName = _ctx.StringValue("ListTransferableSkillGroups.SkillGroups["+ i +"].AccSkillGroupName");
				skillGroup.AccQueueName = _ctx.StringValue("ListTransferableSkillGroups.SkillGroups["+ i +"].AccQueueName");
				skillGroup.SkillGroupDescription = _ctx.StringValue("ListTransferableSkillGroups.SkillGroups["+ i +"].SkillGroupDescription");
				skillGroup.RoutingStrategy = _ctx.StringValue("ListTransferableSkillGroups.SkillGroups["+ i +"].RoutingStrategy");
				skillGroup.AllowPrivateOutboundNumber = _ctx.BooleanValue("ListTransferableSkillGroups.SkillGroups["+ i +"].AllowPrivateOutboundNumber");
				skillGroup.UserCount = _ctx.IntegerValue("ListTransferableSkillGroups.SkillGroups["+ i +"].UserCount");

				listTransferableSkillGroupsResponse_skillGroups.Add(skillGroup);
			}
			listTransferableSkillGroupsResponse.SkillGroups = listTransferableSkillGroupsResponse_skillGroups;
        
			return listTransferableSkillGroupsResponse;
        }
    }
}
