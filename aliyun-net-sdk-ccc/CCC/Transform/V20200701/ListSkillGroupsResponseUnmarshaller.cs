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
    public class ListSkillGroupsResponseUnmarshaller
    {
        public static ListSkillGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSkillGroupsResponse listSkillGroupsResponse = new ListSkillGroupsResponse();

			listSkillGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listSkillGroupsResponse.Code = _ctx.StringValue("ListSkillGroups.Code");
			listSkillGroupsResponse.HttpStatusCode = _ctx.IntegerValue("ListSkillGroups.HttpStatusCode");
			listSkillGroupsResponse.Message = _ctx.StringValue("ListSkillGroups.Message");
			listSkillGroupsResponse.RequestId = _ctx.StringValue("ListSkillGroups.RequestId");

			ListSkillGroupsResponse.ListSkillGroups_Data data = new ListSkillGroupsResponse.ListSkillGroups_Data();
			data.PageNumber = _ctx.IntegerValue("ListSkillGroups.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListSkillGroups.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListSkillGroups.Data.TotalCount");

			List<ListSkillGroupsResponse.ListSkillGroups_Data.ListSkillGroups_SkillGroup> data_list = new List<ListSkillGroupsResponse.ListSkillGroups_Data.ListSkillGroups_SkillGroup>();
			for (int i = 0; i < _ctx.Length("ListSkillGroups.Data.List.Length"); i++) {
				ListSkillGroupsResponse.ListSkillGroups_Data.ListSkillGroups_SkillGroup skillGroup = new ListSkillGroupsResponse.ListSkillGroups_Data.ListSkillGroups_SkillGroup();
				skillGroup.Description = _ctx.StringValue("ListSkillGroups.Data.List["+ i +"].Description");
				skillGroup.DisplayName = _ctx.StringValue("ListSkillGroups.Data.List["+ i +"].DisplayName");
				skillGroup.InstanceId = _ctx.StringValue("ListSkillGroups.Data.List["+ i +"].InstanceId");
				skillGroup.PhoneNumberCount = _ctx.IntegerValue("ListSkillGroups.Data.List["+ i +"].PhoneNumberCount");
				skillGroup.SkillGroupId = _ctx.StringValue("ListSkillGroups.Data.List["+ i +"].SkillGroupId");
				skillGroup.SkillGroupName = _ctx.StringValue("ListSkillGroups.Data.List["+ i +"].SkillGroupName");
				skillGroup.UserCount = _ctx.IntegerValue("ListSkillGroups.Data.List["+ i +"].UserCount");

				data_list.Add(skillGroup);
			}
			data.List = data_list;
			listSkillGroupsResponse.Data = data;
        
			return listSkillGroupsResponse;
        }
    }
}
