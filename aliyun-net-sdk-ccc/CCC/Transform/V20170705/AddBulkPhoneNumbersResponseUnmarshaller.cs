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
    public class AddBulkPhoneNumbersResponseUnmarshaller
    {
        public static AddBulkPhoneNumbersResponse Unmarshall(UnmarshallerContext context)
        {
			AddBulkPhoneNumbersResponse addBulkPhoneNumbersResponse = new AddBulkPhoneNumbersResponse();

			addBulkPhoneNumbersResponse.HttpResponse = context.HttpResponse;
			addBulkPhoneNumbersResponse.RequestId = context.StringValue("AddBulkPhoneNumbers.RequestId");
			addBulkPhoneNumbersResponse.Success = context.BooleanValue("AddBulkPhoneNumbers.Success");
			addBulkPhoneNumbersResponse.Code = context.StringValue("AddBulkPhoneNumbers.Code");
			addBulkPhoneNumbersResponse.Message = context.StringValue("AddBulkPhoneNumbers.Message");
			addBulkPhoneNumbersResponse.HttpStatusCode = context.IntegerValue("AddBulkPhoneNumbers.HttpStatusCode");

			List<string> addBulkPhoneNumbersResponse_arrearagePhoneNumbers = new List<string>();
			for (int i = 0; i < context.Length("AddBulkPhoneNumbers.ArrearagePhoneNumbers.Length"); i++) {
				addBulkPhoneNumbersResponse_arrearagePhoneNumbers.Add(context.StringValue("AddBulkPhoneNumbers.ArrearagePhoneNumbers["+ i +"]"));
			}
			addBulkPhoneNumbersResponse.ArrearagePhoneNumbers = addBulkPhoneNumbersResponse_arrearagePhoneNumbers;

			List<string> addBulkPhoneNumbersResponse_failedPhoneNumbers = new List<string>();
			for (int i = 0; i < context.Length("AddBulkPhoneNumbers.FailedPhoneNumbers.Length"); i++) {
				addBulkPhoneNumbersResponse_failedPhoneNumbers.Add(context.StringValue("AddBulkPhoneNumbers.FailedPhoneNumbers["+ i +"]"));
			}
			addBulkPhoneNumbersResponse.FailedPhoneNumbers = addBulkPhoneNumbersResponse_failedPhoneNumbers;

			List<string> addBulkPhoneNumbersResponse_userdPhoneNumbers = new List<string>();
			for (int i = 0; i < context.Length("AddBulkPhoneNumbers.UserdPhoneNumbers.Length"); i++) {
				addBulkPhoneNumbersResponse_userdPhoneNumbers.Add(context.StringValue("AddBulkPhoneNumbers.UserdPhoneNumbers["+ i +"]"));
			}
			addBulkPhoneNumbersResponse.UserdPhoneNumbers = addBulkPhoneNumbersResponse_userdPhoneNumbers;

			List<AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber> addBulkPhoneNumbersResponse_phoneNumbers = new List<AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber>();
			for (int i = 0; i < context.Length("AddBulkPhoneNumbers.PhoneNumbers.Length"); i++) {
				AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber phoneNumber = new AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber();
				phoneNumber.PhoneNumberId = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = context.BooleanValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = context.IntegerValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = context.BooleanValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = context.IntegerValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].Trunks");

				AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber.AddBulkPhoneNumbers_ContactFlow contactFlow = new AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber.AddBulkPhoneNumbers_ContactFlow();
				contactFlow.ContactFlowId = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.ContactFlowId");
				contactFlow.InstanceId = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.InstanceId");
				contactFlow.ContactFlowName = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.ContactFlowName");
				contactFlow.ContactFlowDescription = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.ContactFlowDescription");
				contactFlow.Type = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].ContactFlow.Type");
				phoneNumber.ContactFlow = contactFlow;

				List<AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber.AddBulkPhoneNumbers_SkillGroup> phoneNumber_skillGroups = new List<AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber.AddBulkPhoneNumbers_SkillGroup>();
				for (int j = 0; j < context.Length("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].SkillGroups.Length"); j++) {
					AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber.AddBulkPhoneNumbers_SkillGroup skillGroup = new AddBulkPhoneNumbersResponse.AddBulkPhoneNumbers_PhoneNumber.AddBulkPhoneNumbers_SkillGroup();
					skillGroup.SkillGroupId = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].SkillGroups["+ j +"].SkillGroupId");
					skillGroup.SkillGroupName = context.StringValue("AddBulkPhoneNumbers.PhoneNumbers["+ i +"].SkillGroups["+ j +"].SkillGroupName");

					phoneNumber_skillGroups.Add(skillGroup);
				}
				phoneNumber.SkillGroups = phoneNumber_skillGroups;

				addBulkPhoneNumbersResponse_phoneNumbers.Add(phoneNumber);
			}
			addBulkPhoneNumbersResponse.PhoneNumbers = addBulkPhoneNumbersResponse_phoneNumbers;
        
			return addBulkPhoneNumbersResponse;
        }
    }
}
