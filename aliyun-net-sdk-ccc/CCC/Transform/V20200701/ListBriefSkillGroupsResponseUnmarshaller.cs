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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListBriefSkillGroupsResponseUnmarshaller
    {
        public static ListBriefSkillGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBriefSkillGroupsResponse listBriefSkillGroupsResponse = new ListBriefSkillGroupsResponse();

			listBriefSkillGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listBriefSkillGroupsResponse.Code = _ctx.StringValue("ListBriefSkillGroups.Code");
			listBriefSkillGroupsResponse.HttpStatusCode = _ctx.IntegerValue("ListBriefSkillGroups.HttpStatusCode");
			listBriefSkillGroupsResponse.Message = _ctx.StringValue("ListBriefSkillGroups.Message");
			listBriefSkillGroupsResponse.RequestId = _ctx.StringValue("ListBriefSkillGroups.RequestId");

			ListBriefSkillGroupsResponse.ListBriefSkillGroups_Data data = new ListBriefSkillGroupsResponse.ListBriefSkillGroups_Data();
			data.PageNumber = _ctx.IntegerValue("ListBriefSkillGroups.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListBriefSkillGroups.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListBriefSkillGroups.Data.TotalCount");

			List<ListBriefSkillGroupsResponse.ListBriefSkillGroups_Data.ListBriefSkillGroups_SkillGroup> data_list = new List<ListBriefSkillGroupsResponse.ListBriefSkillGroups_Data.ListBriefSkillGroups_SkillGroup>();
			for (int i = 0; i < _ctx.Length("ListBriefSkillGroups.Data.List.Length"); i++) {
				ListBriefSkillGroupsResponse.ListBriefSkillGroups_Data.ListBriefSkillGroups_SkillGroup skillGroup = new ListBriefSkillGroupsResponse.ListBriefSkillGroups_Data.ListBriefSkillGroups_SkillGroup();
				skillGroup.Description = _ctx.StringValue("ListBriefSkillGroups.Data.List["+ i +"].Description");
				skillGroup.DisplayName = _ctx.StringValue("ListBriefSkillGroups.Data.List["+ i +"].DisplayName");
				skillGroup.InstanceId = _ctx.StringValue("ListBriefSkillGroups.Data.List["+ i +"].InstanceId");
				skillGroup.PhoneNumberCount = _ctx.IntegerValue("ListBriefSkillGroups.Data.List["+ i +"].PhoneNumberCount");
				skillGroup.SkillGroupId = _ctx.StringValue("ListBriefSkillGroups.Data.List["+ i +"].SkillGroupId");
				skillGroup.SkillGroupName = _ctx.StringValue("ListBriefSkillGroups.Data.List["+ i +"].SkillGroupName");
				skillGroup.UserCount = _ctx.IntegerValue("ListBriefSkillGroups.Data.List["+ i +"].UserCount");

				data_list.Add(skillGroup);
			}
			data.List = data_list;
			listBriefSkillGroupsResponse.Data = data;
        
			return listBriefSkillGroupsResponse;
        }
    }
}
