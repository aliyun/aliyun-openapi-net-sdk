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
    public class CreateContactFlowResponseUnmarshaller
    {
        public static CreateContactFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateContactFlowResponse createContactFlowResponse = new CreateContactFlowResponse();

			createContactFlowResponse.HttpResponse = _ctx.HttpResponse;
			createContactFlowResponse.RequestId = _ctx.StringValue("CreateContactFlow.RequestId");
			createContactFlowResponse.Success = _ctx.BooleanValue("CreateContactFlow.Success");
			createContactFlowResponse.Code = _ctx.StringValue("CreateContactFlow.Code");
			createContactFlowResponse.Message = _ctx.StringValue("CreateContactFlow.Message");
			createContactFlowResponse.HttpStatusCode = _ctx.IntegerValue("CreateContactFlow.HttpStatusCode");

			CreateContactFlowResponse.CreateContactFlow_ContactFlow contactFlow = new CreateContactFlowResponse.CreateContactFlow_ContactFlow();
			contactFlow.ContactFlowId = _ctx.StringValue("CreateContactFlow.ContactFlow.ContactFlowId");
			contactFlow.InstanceId = _ctx.StringValue("CreateContactFlow.ContactFlow.InstanceId");
			contactFlow.ContactFlowName = _ctx.StringValue("CreateContactFlow.ContactFlow.ContactFlowName");
			contactFlow.ContactFlowDescription = _ctx.StringValue("CreateContactFlow.ContactFlow.ContactFlowDescription");
			contactFlow.Type = _ctx.StringValue("CreateContactFlow.ContactFlow.Type");
			contactFlow.AppliedVersion = _ctx.StringValue("CreateContactFlow.ContactFlow.AppliedVersion");

			List<CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_ContactFlowVersion> contactFlow_versions = new List<CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_ContactFlowVersion>();
			for (int i = 0; i < _ctx.Length("CreateContactFlow.ContactFlow.Versions.Length"); i++) {
				CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_ContactFlowVersion contactFlowVersion = new CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_ContactFlowVersion();
				contactFlowVersion.ContactFlowVersionId = _ctx.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].ContactFlowVersionId");
				contactFlowVersion.Version = _ctx.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].Version");
				contactFlowVersion.ContactFlowVersionDescription = _ctx.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].ContactFlowVersionDescription");
				contactFlowVersion.Canvas = _ctx.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].Canvas");
				contactFlowVersion.Content = _ctx.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].Content");
				contactFlowVersion.LastModified = _ctx.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].LastModified");
				contactFlowVersion.LastModifiedBy = _ctx.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].LastModifiedBy");
				contactFlowVersion.LockedBy = _ctx.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].LockedBy");
				contactFlowVersion.Status = _ctx.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].Status");

				contactFlow_versions.Add(contactFlowVersion);
			}
			contactFlow.Versions = contactFlow_versions;

			List<CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_PhoneNumber> contactFlow_phoneNumbers = new List<CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("CreateContactFlow.ContactFlow.PhoneNumbers.Length"); i++) {
				CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_PhoneNumber phoneNumber = new CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_PhoneNumber();
				phoneNumber.PhoneNumberId = _ctx.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = _ctx.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = _ctx.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = _ctx.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = _ctx.BooleanValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = _ctx.IntegerValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = _ctx.BooleanValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = _ctx.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = _ctx.IntegerValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].Trunks");

				contactFlow_phoneNumbers.Add(phoneNumber);
			}
			contactFlow.PhoneNumbers = contactFlow_phoneNumbers;
			createContactFlowResponse.ContactFlow = contactFlow;
        
			return createContactFlowResponse;
        }
    }
}
