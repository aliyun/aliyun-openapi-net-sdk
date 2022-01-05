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
    public class ListInstancesOfUserResponseUnmarshaller
    {
        public static ListInstancesOfUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesOfUserResponse listInstancesOfUserResponse = new ListInstancesOfUserResponse();

			listInstancesOfUserResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesOfUserResponse.Code = _ctx.StringValue("ListInstancesOfUser.Code");
			listInstancesOfUserResponse.HttpStatusCode = _ctx.IntegerValue("ListInstancesOfUser.HttpStatusCode");
			listInstancesOfUserResponse.Message = _ctx.StringValue("ListInstancesOfUser.Message");
			listInstancesOfUserResponse.RequestId = _ctx.StringValue("ListInstancesOfUser.RequestId");

			List<string> listInstancesOfUserResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ListInstancesOfUser.Params.Length"); i++) {
				listInstancesOfUserResponse_params.Add(_ctx.StringValue("ListInstancesOfUser.Params["+ i +"]"));
			}
			listInstancesOfUserResponse._Params = listInstancesOfUserResponse_params;

			ListInstancesOfUserResponse.ListInstancesOfUser_Data data = new ListInstancesOfUserResponse.ListInstancesOfUser_Data();
			data.PageNumber = _ctx.IntegerValue("ListInstancesOfUser.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListInstancesOfUser.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListInstancesOfUser.Data.TotalCount");

			List<ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance> data_list = new List<ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance>();
			for (int i = 0; i < _ctx.Length("ListInstancesOfUser.Data.List.Length"); i++) {
				ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance callCenterInstance = new ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance();
				callCenterInstance.Status = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].Status");
				callCenterInstance.ConsoleUrl = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].ConsoleUrl");
				callCenterInstance.Description = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].Description");
				callCenterInstance.AliyunUid = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AliyunUid");
				callCenterInstance.Name = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].Name");
				callCenterInstance.DomainName = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].DomainName");
				callCenterInstance.Id = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].Id");

				List<ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User> callCenterInstance_adminList = new List<ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User>();
				for (int j = 0; j < _ctx.Length("ListInstancesOfUser.Data.List["+ i +"].AdminList.Length"); j++) {
					ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User user = new ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User();
					user.DisplayName = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].DisplayName");
					user.Extension = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].Extension");
					user.LoginName = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].LoginName");
					user.Email = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].Email");
					user.WorkMode = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].WorkMode");
					user.Mobile = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].Mobile");
					user.UserId = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].UserId");
					user.RoleName = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].RoleName");
					user.InstanceId = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].InstanceId");
					user.RoleId = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].AdminList["+ j +"].RoleId");

					callCenterInstance_adminList.Add(user);
				}
				callCenterInstance.AdminList = callCenterInstance_adminList;

				List<ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber> callCenterInstance_numberList = new List<ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber>();
				for (int j = 0; j < _ctx.Length("ListInstancesOfUser.Data.List["+ i +"].NumberList.Length"); j++) {
					ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber phoneNumber = new ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber();
					phoneNumber.Active = _ctx.BooleanValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].Active");
					phoneNumber.UserId = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].UserId");
					phoneNumber.Number = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].Number");
					phoneNumber.City = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].City");
					phoneNumber.InstanceId = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].InstanceId");
					phoneNumber.Usage = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].Usage");
					phoneNumber.ContactFlowId = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].ContactFlowId");
					phoneNumber.Province = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].Province");

					List<ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber.ListInstancesOfUser_SkillGroup> phoneNumber_skillGroups = new List<ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber.ListInstancesOfUser_SkillGroup>();
					for (int k = 0; k < _ctx.Length("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].SkillGroups.Length"); k++) {
						ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber.ListInstancesOfUser_SkillGroup skillGroup = new ListInstancesOfUserResponse.ListInstancesOfUser_Data.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber.ListInstancesOfUser_SkillGroup();
						skillGroup.DisplayName = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].SkillGroups["+ k +"].DisplayName");
						skillGroup.Description = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].SkillGroups["+ k +"].Description");
						skillGroup.PhoneNumberCount = _ctx.IntegerValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].SkillGroups["+ k +"].PhoneNumberCount");
						skillGroup.SkillGroupId = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].SkillGroups["+ k +"].SkillGroupId");
						skillGroup.UserCount = _ctx.IntegerValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].SkillGroups["+ k +"].UserCount");
						skillGroup.InstanceId = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].SkillGroups["+ k +"].InstanceId");
						skillGroup.Name = _ctx.StringValue("ListInstancesOfUser.Data.List["+ i +"].NumberList["+ j +"].SkillGroups["+ k +"].Name");

						phoneNumber_skillGroups.Add(skillGroup);
					}
					phoneNumber.SkillGroups = phoneNumber_skillGroups;

					callCenterInstance_numberList.Add(phoneNumber);
				}
				callCenterInstance.NumberList = callCenterInstance_numberList;

				data_list.Add(callCenterInstance);
			}
			data.List = data_list;
			listInstancesOfUserResponse.Data = data;
        
			return listInstancesOfUserResponse;
        }
    }
}
