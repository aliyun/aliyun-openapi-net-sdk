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
    public class ListPhoneNumbersOfSkillGroupResponseUnmarshaller
    {
        public static ListPhoneNumbersOfSkillGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPhoneNumbersOfSkillGroupResponse listPhoneNumbersOfSkillGroupResponse = new ListPhoneNumbersOfSkillGroupResponse();

			listPhoneNumbersOfSkillGroupResponse.HttpResponse = _ctx.HttpResponse;
			listPhoneNumbersOfSkillGroupResponse.Code = _ctx.StringValue("ListPhoneNumbersOfSkillGroup.Code");
			listPhoneNumbersOfSkillGroupResponse.HttpStatusCode = _ctx.IntegerValue("ListPhoneNumbersOfSkillGroup.HttpStatusCode");
			listPhoneNumbersOfSkillGroupResponse.Message = _ctx.StringValue("ListPhoneNumbersOfSkillGroup.Message");
			listPhoneNumbersOfSkillGroupResponse.RequestId = _ctx.StringValue("ListPhoneNumbersOfSkillGroup.RequestId");

			ListPhoneNumbersOfSkillGroupResponse.ListPhoneNumbersOfSkillGroup_Data data = new ListPhoneNumbersOfSkillGroupResponse.ListPhoneNumbersOfSkillGroup_Data();
			data.PageNumber = _ctx.IntegerValue("ListPhoneNumbersOfSkillGroup.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListPhoneNumbersOfSkillGroup.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListPhoneNumbersOfSkillGroup.Data.TotalCount");

			List<ListPhoneNumbersOfSkillGroupResponse.ListPhoneNumbersOfSkillGroup_Data.ListPhoneNumbersOfSkillGroup_PhoneNumber> data_list = new List<ListPhoneNumbersOfSkillGroupResponse.ListPhoneNumbersOfSkillGroup_Data.ListPhoneNumbersOfSkillGroup_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("ListPhoneNumbersOfSkillGroup.Data.List.Length"); i++) {
				ListPhoneNumbersOfSkillGroupResponse.ListPhoneNumbersOfSkillGroup_Data.ListPhoneNumbersOfSkillGroup_PhoneNumber phoneNumber = new ListPhoneNumbersOfSkillGroupResponse.ListPhoneNumbersOfSkillGroup_Data.ListPhoneNumbersOfSkillGroup_PhoneNumber();
				phoneNumber.Active = _ctx.BooleanValue("ListPhoneNumbersOfSkillGroup.Data.List["+ i +"].Active");
				phoneNumber.City = _ctx.StringValue("ListPhoneNumbersOfSkillGroup.Data.List["+ i +"].City");
				phoneNumber.ContactFlowId = _ctx.StringValue("ListPhoneNumbersOfSkillGroup.Data.List["+ i +"].ContactFlowId");
				phoneNumber.InstanceId = _ctx.StringValue("ListPhoneNumbersOfSkillGroup.Data.List["+ i +"].InstanceId");
				phoneNumber.Number = _ctx.StringValue("ListPhoneNumbersOfSkillGroup.Data.List["+ i +"].Number");
				phoneNumber.Province = _ctx.StringValue("ListPhoneNumbersOfSkillGroup.Data.List["+ i +"].Province");
				phoneNumber.Usage = _ctx.StringValue("ListPhoneNumbersOfSkillGroup.Data.List["+ i +"].Usage");

				data_list.Add(phoneNumber);
			}
			data.List = data_list;
			listPhoneNumbersOfSkillGroupResponse.Data = data;
        
			return listPhoneNumbersOfSkillGroupResponse;
        }
    }
}
