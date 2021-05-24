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
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = _ctx.HttpResponse;
			listUsersResponse.Code = _ctx.StringValue("ListUsers.Code");
			listUsersResponse.HttpStatusCode = _ctx.IntegerValue("ListUsers.HttpStatusCode");
			listUsersResponse.Message = _ctx.StringValue("ListUsers.Message");
			listUsersResponse.RequestId = _ctx.StringValue("ListUsers.RequestId");

			List<string> listUsersResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ListUsers.Params.Length"); i++) {
				listUsersResponse_params.Add(_ctx.StringValue("ListUsers.Params["+ i +"]"));
			}
			listUsersResponse._Params = listUsersResponse_params;

			ListUsersResponse.ListUsers_Data data = new ListUsersResponse.ListUsers_Data();
			data.PageNumber = _ctx.IntegerValue("ListUsers.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListUsers.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListUsers.Data.TotalCount");

			List<ListUsersResponse.ListUsers_Data.ListUsers_UserDetail> data_list = new List<ListUsersResponse.ListUsers_Data.ListUsers_UserDetail>();
			for (int i = 0; i < _ctx.Length("ListUsers.Data.List.Length"); i++) {
				ListUsersResponse.ListUsers_Data.ListUsers_UserDetail userDetail = new ListUsersResponse.ListUsers_Data.ListUsers_UserDetail();
				userDetail.DisplayName = _ctx.StringValue("ListUsers.Data.List["+ i +"].DisplayName");
				userDetail.Email = _ctx.StringValue("ListUsers.Data.List["+ i +"].Email");
				userDetail.LoginName = _ctx.StringValue("ListUsers.Data.List["+ i +"].LoginName");
				userDetail.Mobile = _ctx.StringValue("ListUsers.Data.List["+ i +"].Mobile");
				userDetail.RoleId = _ctx.StringValue("ListUsers.Data.List["+ i +"].RoleId");
				userDetail.RoleName = _ctx.StringValue("ListUsers.Data.List["+ i +"].RoleName");
				userDetail.UserId = _ctx.StringValue("ListUsers.Data.List["+ i +"].UserId");
				userDetail.WorkMode = _ctx.StringValue("ListUsers.Data.List["+ i +"].WorkMode");
				userDetail.PrimaryAccount = _ctx.BooleanValue("ListUsers.Data.List["+ i +"].PrimaryAccount");

				List<ListUsersResponse.ListUsers_Data.ListUsers_UserDetail.ListUsers_PhoneNumber> userDetail_personalOutboundNumberList = new List<ListUsersResponse.ListUsers_Data.ListUsers_UserDetail.ListUsers_PhoneNumber>();
				for (int j = 0; j < _ctx.Length("ListUsers.Data.List["+ i +"].PersonalOutboundNumberList.Length"); j++) {
					ListUsersResponse.ListUsers_Data.ListUsers_UserDetail.ListUsers_PhoneNumber phoneNumber = new ListUsersResponse.ListUsers_Data.ListUsers_UserDetail.ListUsers_PhoneNumber();
					phoneNumber.Active = _ctx.BooleanValue("ListUsers.Data.List["+ i +"].PersonalOutboundNumberList["+ j +"].Active");
					phoneNumber.City = _ctx.StringValue("ListUsers.Data.List["+ i +"].PersonalOutboundNumberList["+ j +"].City");
					phoneNumber.Number = _ctx.StringValue("ListUsers.Data.List["+ i +"].PersonalOutboundNumberList["+ j +"].Number");
					phoneNumber.Province = _ctx.StringValue("ListUsers.Data.List["+ i +"].PersonalOutboundNumberList["+ j +"].Province");
					phoneNumber.Usage = _ctx.StringValue("ListUsers.Data.List["+ i +"].PersonalOutboundNumberList["+ j +"].Usage");

					userDetail_personalOutboundNumberList.Add(phoneNumber);
				}
				userDetail.PersonalOutboundNumberList = userDetail_personalOutboundNumberList;

				List<ListUsersResponse.ListUsers_Data.ListUsers_UserDetail.ListUsers_UserSkillLevel> userDetail_skillLevelList = new List<ListUsersResponse.ListUsers_Data.ListUsers_UserDetail.ListUsers_UserSkillLevel>();
				for (int j = 0; j < _ctx.Length("ListUsers.Data.List["+ i +"].SkillLevelList.Length"); j++) {
					ListUsersResponse.ListUsers_Data.ListUsers_UserDetail.ListUsers_UserSkillLevel userSkillLevel = new ListUsersResponse.ListUsers_Data.ListUsers_UserDetail.ListUsers_UserSkillLevel();
					userSkillLevel.SkillGroupId = _ctx.StringValue("ListUsers.Data.List["+ i +"].SkillLevelList["+ j +"].SkillGroupId");
					userSkillLevel.SkillGroupName = _ctx.StringValue("ListUsers.Data.List["+ i +"].SkillLevelList["+ j +"].SkillGroupName");
					userSkillLevel.SkillLevel = _ctx.IntegerValue("ListUsers.Data.List["+ i +"].SkillLevelList["+ j +"].SkillLevel");

					userDetail_skillLevelList.Add(userSkillLevel);
				}
				userDetail.SkillLevelList = userDetail_skillLevelList;

				data_list.Add(userDetail);
			}
			data.List = data_list;
			listUsersResponse.Data = data;
        
			return listUsersResponse;
        }
    }
}
