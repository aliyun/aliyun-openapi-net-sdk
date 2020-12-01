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
    public class ListPhoneNumbersResponseUnmarshaller
    {
        public static ListPhoneNumbersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPhoneNumbersResponse listPhoneNumbersResponse = new ListPhoneNumbersResponse();

			listPhoneNumbersResponse.HttpResponse = _ctx.HttpResponse;
			listPhoneNumbersResponse.RequestId = _ctx.StringValue("ListPhoneNumbers.RequestId");
			listPhoneNumbersResponse.Success = _ctx.BooleanValue("ListPhoneNumbers.Success");
			listPhoneNumbersResponse.Code = _ctx.StringValue("ListPhoneNumbers.Code");
			listPhoneNumbersResponse.Message = _ctx.StringValue("ListPhoneNumbers.Message");
			listPhoneNumbersResponse.HttpStatusCode = _ctx.IntegerValue("ListPhoneNumbers.HttpStatusCode");

			List<ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber> listPhoneNumbersResponse_phoneNumbers = new List<ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("ListPhoneNumbers.PhoneNumbers.Length"); i++) {
				ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber phoneNumber = new ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber();
				phoneNumber.PhoneNumberId = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = _ctx.BooleanValue("ListPhoneNumbers.PhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = _ctx.IntegerValue("ListPhoneNumbers.PhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = _ctx.BooleanValue("ListPhoneNumbers.PhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = _ctx.IntegerValue("ListPhoneNumbers.PhoneNumbers["+ i +"].Trunks");
				phoneNumber.Province = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].Province");
				phoneNumber.City = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].City");
				phoneNumber.Assignee = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].Assignee");
				phoneNumber.NumberCommodityStatus = _ctx.IntegerValue("ListPhoneNumbers.PhoneNumbers["+ i +"].NumberCommodityStatus");
				phoneNumber.SipTelX = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].SipTelX");

				ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_ContactFlow contactFlow = new ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_ContactFlow();
				contactFlow.ContactFlowId = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.ContactFlowId");
				contactFlow.InstanceId = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.InstanceId");
				contactFlow.ContactFlowName = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.ContactFlowName");
				contactFlow.ContactFlowDescription = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.ContactFlowDescription");
				contactFlow.Type = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.Type");
				phoneNumber.ContactFlow = contactFlow;

				ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_PrivacyNumber privacyNumber = new ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_PrivacyNumber();
				privacyNumber.PoolId = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PrivacyNumber.PoolId");
				privacyNumber.Type = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PrivacyNumber.Type");
				privacyNumber.TelX = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PrivacyNumber.TelX");
				privacyNumber.PoolName = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PrivacyNumber.PoolName");
				privacyNumber.PhoneNumber = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PrivacyNumber.PhoneNumber");
				privacyNumber.Extra = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PrivacyNumber.Extra");
				privacyNumber.BizId = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PrivacyNumber.BizId");
				privacyNumber.SubId = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PrivacyNumber.SubId");
				privacyNumber.RegionNameCity = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].PrivacyNumber.RegionNameCity");
				phoneNumber.PrivacyNumber = privacyNumber;

				List<ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_SkillGroup> phoneNumber_skillGroups = new List<ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_SkillGroup>();
				for (int j = 0; j < _ctx.Length("ListPhoneNumbers.PhoneNumbers["+ i +"].SkillGroups.Length"); j++) {
					ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_SkillGroup skillGroup = new ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_SkillGroup();
					skillGroup.SkillGroupId = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].SkillGroups["+ j +"].SkillGroupId");
					skillGroup.SkillGroupName = _ctx.StringValue("ListPhoneNumbers.PhoneNumbers["+ i +"].SkillGroups["+ j +"].SkillGroupName");

					phoneNumber_skillGroups.Add(skillGroup);
				}
				phoneNumber.SkillGroups = phoneNumber_skillGroups;

				listPhoneNumbersResponse_phoneNumbers.Add(phoneNumber);
			}
			listPhoneNumbersResponse.PhoneNumbers = listPhoneNumbersResponse_phoneNumbers;
        
			return listPhoneNumbersResponse;
        }
    }
}
