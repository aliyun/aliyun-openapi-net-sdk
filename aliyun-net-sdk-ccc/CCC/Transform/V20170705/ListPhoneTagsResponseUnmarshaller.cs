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
    public class ListPhoneTagsResponseUnmarshaller
    {
        public static ListPhoneTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPhoneTagsResponse listPhoneTagsResponse = new ListPhoneTagsResponse();

			listPhoneTagsResponse.HttpResponse = context.HttpResponse;
			listPhoneTagsResponse.RequestId = context.StringValue("ListPhoneTags.RequestId");
			listPhoneTagsResponse.Success = context.BooleanValue("ListPhoneTags.Success");
			listPhoneTagsResponse.Code = context.StringValue("ListPhoneTags.Code");
			listPhoneTagsResponse.Message = context.StringValue("ListPhoneTags.Message");
			listPhoneTagsResponse.HttpStatusCode = context.IntegerValue("ListPhoneTags.HttpStatusCode");

			ListPhoneTagsResponse.ListPhoneTags_PhoneNumbers phoneNumbers = new ListPhoneTagsResponse.ListPhoneTags_PhoneNumbers();
			phoneNumbers.TotalCount = context.IntegerValue("ListPhoneTags.PhoneNumbers.TotalCount");
			phoneNumbers.PageNumber = context.IntegerValue("ListPhoneTags.PhoneNumbers.PageNumber");
			phoneNumbers.PageSize = context.IntegerValue("ListPhoneTags.PhoneNumbers.PageSize");

			List<ListPhoneTagsResponse.ListPhoneTags_PhoneNumbers.ListPhoneTags_PhoneNumber> phoneNumbers_list = new List<ListPhoneTagsResponse.ListPhoneTags_PhoneNumbers.ListPhoneTags_PhoneNumber>();
			for (int i = 0; i < context.Length("ListPhoneTags.PhoneNumbers.List.Length"); i++) {
				ListPhoneTagsResponse.ListPhoneTags_PhoneNumbers.ListPhoneTags_PhoneNumber phoneNumber = new ListPhoneTagsResponse.ListPhoneTags_PhoneNumbers.ListPhoneTags_PhoneNumber();
				phoneNumber.PhoneNumberId = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].InstanceId");
				phoneNumber.Number = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].PhoneNumberDescription");
				phoneNumber.Usage = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].Usage");
				phoneNumber.Province = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].Province");
				phoneNumber.City = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].City");
				phoneNumber.Type = context.IntegerValue("ListPhoneTags.PhoneNumbers.List["+ i +"].Type");
				phoneNumber.Concurrency = context.IntegerValue("ListPhoneTags.PhoneNumbers.List["+ i +"].Concurrency");
				phoneNumber.ServiceTag = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].ServiceTag");
				phoneNumber.Provider = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].Provider");
				phoneNumber.CreateTime = context.LongValue("ListPhoneTags.PhoneNumbers.List["+ i +"].CreateTime");
				phoneNumber.ContactFlowId = context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].ContactFlowId");

				List<string> phoneNumber_skillGroupIdList = new List<string>();
				for (int j = 0; j < context.Length("ListPhoneTags.PhoneNumbers.List["+ i +"].SkillGroupIdList.Length"); j++) {
					phoneNumber_skillGroupIdList.Add(context.StringValue("ListPhoneTags.PhoneNumbers.List["+ i +"].SkillGroupIdList["+ j +"]"));
				}
				phoneNumber.SkillGroupIdList = phoneNumber_skillGroupIdList;

				phoneNumbers_list.Add(phoneNumber);
			}
			phoneNumbers.List = phoneNumbers_list;
			listPhoneTagsResponse.PhoneNumbers = phoneNumbers;
        
			return listPhoneTagsResponse;
        }
    }
}
