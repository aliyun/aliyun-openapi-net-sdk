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
    public class ListUserLevelsOfSkillGroupResponseUnmarshaller
    {
        public static ListUserLevelsOfSkillGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserLevelsOfSkillGroupResponse listUserLevelsOfSkillGroupResponse = new ListUserLevelsOfSkillGroupResponse();

			listUserLevelsOfSkillGroupResponse.HttpResponse = _ctx.HttpResponse;
			listUserLevelsOfSkillGroupResponse.Code = _ctx.StringValue("ListUserLevelsOfSkillGroup.Code");
			listUserLevelsOfSkillGroupResponse.HttpStatusCode = _ctx.IntegerValue("ListUserLevelsOfSkillGroup.HttpStatusCode");
			listUserLevelsOfSkillGroupResponse.Message = _ctx.StringValue("ListUserLevelsOfSkillGroup.Message");
			listUserLevelsOfSkillGroupResponse.RequestId = _ctx.StringValue("ListUserLevelsOfSkillGroup.RequestId");

			ListUserLevelsOfSkillGroupResponse.ListUserLevelsOfSkillGroup_Data data = new ListUserLevelsOfSkillGroupResponse.ListUserLevelsOfSkillGroup_Data();
			data.PageNumber = _ctx.IntegerValue("ListUserLevelsOfSkillGroup.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListUserLevelsOfSkillGroup.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListUserLevelsOfSkillGroup.Data.TotalCount");

			List<ListUserLevelsOfSkillGroupResponse.ListUserLevelsOfSkillGroup_Data.ListUserLevelsOfSkillGroup_UserSkillLevel> data_list = new List<ListUserLevelsOfSkillGroupResponse.ListUserLevelsOfSkillGroup_Data.ListUserLevelsOfSkillGroup_UserSkillLevel>();
			for (int i = 0; i < _ctx.Length("ListUserLevelsOfSkillGroup.Data.List.Length"); i++) {
				ListUserLevelsOfSkillGroupResponse.ListUserLevelsOfSkillGroup_Data.ListUserLevelsOfSkillGroup_UserSkillLevel userSkillLevel = new ListUserLevelsOfSkillGroupResponse.ListUserLevelsOfSkillGroup_Data.ListUserLevelsOfSkillGroup_UserSkillLevel();
				userSkillLevel.DisplayName = _ctx.StringValue("ListUserLevelsOfSkillGroup.Data.List["+ i +"].DisplayName");
				userSkillLevel.LoginName = _ctx.StringValue("ListUserLevelsOfSkillGroup.Data.List["+ i +"].LoginName");
				userSkillLevel.RoleId = _ctx.StringValue("ListUserLevelsOfSkillGroup.Data.List["+ i +"].RoleId");
				userSkillLevel.RoleName = _ctx.StringValue("ListUserLevelsOfSkillGroup.Data.List["+ i +"].RoleName");
				userSkillLevel.SkillGroupId = _ctx.StringValue("ListUserLevelsOfSkillGroup.Data.List["+ i +"].SkillGroupId");
				userSkillLevel.SkillGroupName = _ctx.StringValue("ListUserLevelsOfSkillGroup.Data.List["+ i +"].SkillGroupName");
				userSkillLevel.SkillLevel = _ctx.IntegerValue("ListUserLevelsOfSkillGroup.Data.List["+ i +"].SkillLevel");
				userSkillLevel.UserId = _ctx.StringValue("ListUserLevelsOfSkillGroup.Data.List["+ i +"].UserId");

				data_list.Add(userSkillLevel);
			}
			data.List = data_list;
			listUserLevelsOfSkillGroupResponse.Data = data;
        
			return listUserLevelsOfSkillGroupResponse;
        }
    }
}
