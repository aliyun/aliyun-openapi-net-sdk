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
    public class ListPhoneNumbersResponseUnmarshaller
    {
        public static ListPhoneNumbersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPhoneNumbersResponse listPhoneNumbersResponse = new ListPhoneNumbersResponse();

			listPhoneNumbersResponse.HttpResponse = _ctx.HttpResponse;
			listPhoneNumbersResponse.Code = _ctx.StringValue("ListPhoneNumbers.Code");
			listPhoneNumbersResponse.HttpStatusCode = _ctx.IntegerValue("ListPhoneNumbers.HttpStatusCode");
			listPhoneNumbersResponse.Message = _ctx.StringValue("ListPhoneNumbers.Message");
			listPhoneNumbersResponse.PageNumber = _ctx.IntegerValue("ListPhoneNumbers.PageNumber");
			listPhoneNumbersResponse.PageSize = _ctx.IntegerValue("ListPhoneNumbers.PageSize");
			listPhoneNumbersResponse.RequestId = _ctx.StringValue("ListPhoneNumbers.RequestId");

			ListPhoneNumbersResponse.ListPhoneNumbers_Data data = new ListPhoneNumbersResponse.ListPhoneNumbers_Data();
			data.PageNumber = _ctx.IntegerValue("ListPhoneNumbers.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListPhoneNumbers.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListPhoneNumbers.Data.TotalCount");

			List<ListPhoneNumbersResponse.ListPhoneNumbers_Data.ListPhoneNumbers_PhoneNumber> data_list = new List<ListPhoneNumbersResponse.ListPhoneNumbers_Data.ListPhoneNumbers_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("ListPhoneNumbers.Data.List.Length"); i++) {
				ListPhoneNumbersResponse.ListPhoneNumbers_Data.ListPhoneNumbers_PhoneNumber phoneNumber = new ListPhoneNumbersResponse.ListPhoneNumbers_Data.ListPhoneNumbers_PhoneNumber();
				phoneNumber.Active = _ctx.BooleanValue("ListPhoneNumbers.Data.List["+ i +"].Active");
				phoneNumber.City = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].City");
				phoneNumber.ContactFlowId = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].ContactFlowId");
				phoneNumber.ContactFlowName = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].ContactFlowName");
				phoneNumber.InstanceId = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].InstanceId");
				phoneNumber.Number = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].Number");
				phoneNumber.Province = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].Province");
				phoneNumber.Usage = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].Usage");
				phoneNumber.UserId = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].UserId");
				phoneNumber.Provider = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].Provider");
				phoneNumber.Tags = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].Tags");
				phoneNumber.CreateTime = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].CreateTime");

				List<ListPhoneNumbersResponse.ListPhoneNumbers_Data.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_SkillGroup> phoneNumber_skillGroups = new List<ListPhoneNumbersResponse.ListPhoneNumbers_Data.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_SkillGroup>();
				for (int j = 0; j < _ctx.Length("ListPhoneNumbers.Data.List["+ i +"].SkillGroups.Length"); j++) {
					ListPhoneNumbersResponse.ListPhoneNumbers_Data.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_SkillGroup skillGroup = new ListPhoneNumbersResponse.ListPhoneNumbers_Data.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_SkillGroup();
					skillGroup.DisplayName = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].SkillGroups["+ j +"].DisplayName");
					skillGroup.InstanceId = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].SkillGroups["+ j +"].InstanceId");
					skillGroup.Name = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].SkillGroups["+ j +"].Name");
					skillGroup.SkillGroupId = _ctx.StringValue("ListPhoneNumbers.Data.List["+ i +"].SkillGroups["+ j +"].SkillGroupId");

					phoneNumber_skillGroups.Add(skillGroup);
				}
				phoneNumber.SkillGroups = phoneNumber_skillGroups;

				data_list.Add(phoneNumber);
			}
			data.List = data_list;
			listPhoneNumbersResponse.Data = data;
        
			return listPhoneNumbersResponse;
        }
    }
}
