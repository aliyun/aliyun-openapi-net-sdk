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
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceResponse.Code = _ctx.StringValue("GetInstance.Code");
			getInstanceResponse.HttpStatusCode = _ctx.IntegerValue("GetInstance.HttpStatusCode");
			getInstanceResponse.Message = _ctx.StringValue("GetInstance.Message");
			getInstanceResponse.RequestId = _ctx.StringValue("GetInstance.RequestId");

			List<string> getInstanceResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("GetInstance.Params.Length"); i++) {
				getInstanceResponse_params.Add(_ctx.StringValue("GetInstance.Params["+ i +"]"));
			}
			getInstanceResponse._Params = getInstanceResponse_params;

			GetInstanceResponse.GetInstance_Data data = new GetInstanceResponse.GetInstance_Data();
			data.AliyunUid = _ctx.StringValue("GetInstance.Data.AliyunUid");
			data.ConsoleUrl = _ctx.StringValue("GetInstance.Data.ConsoleUrl");
			data.Description = _ctx.StringValue("GetInstance.Data.Description");
			data.DomainName = _ctx.StringValue("GetInstance.Data.DomainName");
			data.Id = _ctx.StringValue("GetInstance.Data.Id");
			data.Name = _ctx.StringValue("GetInstance.Data.Name");
			data.Status = _ctx.StringValue("GetInstance.Data.Status");

			List<GetInstanceResponse.GetInstance_Data.GetInstance_User> data_adminList = new List<GetInstanceResponse.GetInstance_Data.GetInstance_User>();
			for (int i = 0; i < _ctx.Length("GetInstance.Data.AdminList.Length"); i++) {
				GetInstanceResponse.GetInstance_Data.GetInstance_User user = new GetInstanceResponse.GetInstance_Data.GetInstance_User();
				user.DisplayName = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].DisplayName");
				user.Email = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].Email");
				user.Extension = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].Extension");
				user.InstanceId = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].InstanceId");
				user.LoginName = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].LoginName");
				user.Mobile = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].Mobile");
				user.RoleId = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].RoleId");
				user.RoleName = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].RoleName");
				user.UserId = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].UserId");
				user.WorkMode = _ctx.StringValue("GetInstance.Data.AdminList["+ i +"].WorkMode");

				data_adminList.Add(user);
			}
			data.AdminList = data_adminList;

			List<GetInstanceResponse.GetInstance_Data.GetInstance_PhoneNumber> data_numberList = new List<GetInstanceResponse.GetInstance_Data.GetInstance_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("GetInstance.Data.NumberList.Length"); i++) {
				GetInstanceResponse.GetInstance_Data.GetInstance_PhoneNumber phoneNumber = new GetInstanceResponse.GetInstance_Data.GetInstance_PhoneNumber();
				phoneNumber.Active = _ctx.BooleanValue("GetInstance.Data.NumberList["+ i +"].Active");
				phoneNumber.City = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].City");
				phoneNumber.ContactFlowId = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].ContactFlowId");
				phoneNumber.InstanceId = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].InstanceId");
				phoneNumber.Number = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].Number");
				phoneNumber.Province = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].Province");
				phoneNumber.Usage = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].Usage");
				phoneNumber.UserId = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].UserId");

				List<GetInstanceResponse.GetInstance_Data.GetInstance_PhoneNumber.GetInstance_SkillGroup> phoneNumber_skillGroups = new List<GetInstanceResponse.GetInstance_Data.GetInstance_PhoneNumber.GetInstance_SkillGroup>();
				for (int j = 0; j < _ctx.Length("GetInstance.Data.NumberList["+ i +"].SkillGroups.Length"); j++) {
					GetInstanceResponse.GetInstance_Data.GetInstance_PhoneNumber.GetInstance_SkillGroup skillGroup = new GetInstanceResponse.GetInstance_Data.GetInstance_PhoneNumber.GetInstance_SkillGroup();
					skillGroup.Description = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].SkillGroups["+ j +"].Description");
					skillGroup.DisplayName = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].SkillGroups["+ j +"].DisplayName");
					skillGroup.InstanceId = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].SkillGroups["+ j +"].InstanceId");
					skillGroup.Name = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].SkillGroups["+ j +"].Name");
					skillGroup.PhoneNumberCount = _ctx.IntegerValue("GetInstance.Data.NumberList["+ i +"].SkillGroups["+ j +"].PhoneNumberCount");
					skillGroup.SkillGroupId = _ctx.StringValue("GetInstance.Data.NumberList["+ i +"].SkillGroups["+ j +"].SkillGroupId");
					skillGroup.UserCount = _ctx.IntegerValue("GetInstance.Data.NumberList["+ i +"].SkillGroups["+ j +"].UserCount");

					phoneNumber_skillGroups.Add(skillGroup);
				}
				phoneNumber.SkillGroups = phoneNumber_skillGroups;

				data_numberList.Add(phoneNumber);
			}
			data.NumberList = data_numberList;
			getInstanceResponse.Data = data;
        
			return getInstanceResponse;
        }
    }
}
