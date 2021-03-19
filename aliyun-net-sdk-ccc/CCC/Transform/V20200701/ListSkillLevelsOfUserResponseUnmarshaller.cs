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
    public class ListSkillLevelsOfUserResponseUnmarshaller
    {
        public static ListSkillLevelsOfUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSkillLevelsOfUserResponse listSkillLevelsOfUserResponse = new ListSkillLevelsOfUserResponse();

			listSkillLevelsOfUserResponse.HttpResponse = _ctx.HttpResponse;
			listSkillLevelsOfUserResponse.Code = _ctx.StringValue("ListSkillLevelsOfUser.Code");
			listSkillLevelsOfUserResponse.HttpStatusCode = _ctx.IntegerValue("ListSkillLevelsOfUser.HttpStatusCode");
			listSkillLevelsOfUserResponse.Message = _ctx.StringValue("ListSkillLevelsOfUser.Message");
			listSkillLevelsOfUserResponse.RequestId = _ctx.StringValue("ListSkillLevelsOfUser.RequestId");

			ListSkillLevelsOfUserResponse.ListSkillLevelsOfUser_Data data = new ListSkillLevelsOfUserResponse.ListSkillLevelsOfUser_Data();
			data.PageNumber = _ctx.IntegerValue("ListSkillLevelsOfUser.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListSkillLevelsOfUser.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListSkillLevelsOfUser.Data.TotalCount");

			List<ListSkillLevelsOfUserResponse.ListSkillLevelsOfUser_Data.ListSkillLevelsOfUser_UserSkillLevel> data_list = new List<ListSkillLevelsOfUserResponse.ListSkillLevelsOfUser_Data.ListSkillLevelsOfUser_UserSkillLevel>();
			for (int i = 0; i < _ctx.Length("ListSkillLevelsOfUser.Data.List.Length"); i++) {
				ListSkillLevelsOfUserResponse.ListSkillLevelsOfUser_Data.ListSkillLevelsOfUser_UserSkillLevel userSkillLevel = new ListSkillLevelsOfUserResponse.ListSkillLevelsOfUser_Data.ListSkillLevelsOfUser_UserSkillLevel();
				userSkillLevel.SkillGroupId = _ctx.StringValue("ListSkillLevelsOfUser.Data.List["+ i +"].SkillGroupId");
				userSkillLevel.SkillGroupName = _ctx.StringValue("ListSkillLevelsOfUser.Data.List["+ i +"].SkillGroupName");
				userSkillLevel.SkillLevel = _ctx.StringValue("ListSkillLevelsOfUser.Data.List["+ i +"].SkillLevel");

				data_list.Add(userSkillLevel);
			}
			data.List = data_list;
			listSkillLevelsOfUserResponse.Data = data;
        
			return listSkillLevelsOfUserResponse;
        }
    }
}
