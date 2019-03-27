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
        public static CreateContactFlowResponse Unmarshall(UnmarshallerContext context)
        {
			CreateContactFlowResponse createContactFlowResponse = new CreateContactFlowResponse();

			createContactFlowResponse.HttpResponse = context.HttpResponse;
			createContactFlowResponse.RequestId = context.StringValue("CreateContactFlow.RequestId");
			createContactFlowResponse.Success = context.BooleanValue("CreateContactFlow.Success");
			createContactFlowResponse.Code = context.StringValue("CreateContactFlow.Code");
			createContactFlowResponse.Message = context.StringValue("CreateContactFlow.Message");
			createContactFlowResponse.HttpStatusCode = context.IntegerValue("CreateContactFlow.HttpStatusCode");

			CreateContactFlowResponse.CreateContactFlow_ContactFlow contactFlow = new CreateContactFlowResponse.CreateContactFlow_ContactFlow();
			contactFlow.ContactFlowId = context.StringValue("CreateContactFlow.ContactFlow.ContactFlowId");
			contactFlow.InstanceId = context.StringValue("CreateContactFlow.ContactFlow.InstanceId");
			contactFlow.ContactFlowName = context.StringValue("CreateContactFlow.ContactFlow.ContactFlowName");
			contactFlow.ContactFlowDescription = context.StringValue("CreateContactFlow.ContactFlow.ContactFlowDescription");
			contactFlow.Type = context.StringValue("CreateContactFlow.ContactFlow.Type");
			contactFlow.AppliedVersion = context.StringValue("CreateContactFlow.ContactFlow.AppliedVersion");

			List<CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_ContactFlowVersion> contactFlow_versions = new List<CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_ContactFlowVersion>();
			for (int i = 0; i < context.Length("CreateContactFlow.ContactFlow.Versions.Length"); i++) {
				CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_ContactFlowVersion contactFlowVersion = new CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_ContactFlowVersion();
				contactFlowVersion.ContactFlowVersionId = context.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].ContactFlowVersionId");
				contactFlowVersion.Version = context.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].Version");
				contactFlowVersion.ContactFlowVersionDescription = context.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].ContactFlowVersionDescription");
				contactFlowVersion.Canvas = context.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].Canvas");
				contactFlowVersion.Content = context.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].Content");
				contactFlowVersion.LastModified = context.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].LastModified");
				contactFlowVersion.LastModifiedBy = context.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].LastModifiedBy");
				contactFlowVersion.LockedBy = context.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].LockedBy");
				contactFlowVersion.Status = context.StringValue("CreateContactFlow.ContactFlow.Versions["+ i +"].Status");

				contactFlow_versions.Add(contactFlowVersion);
			}
			contactFlow.Versions = contactFlow_versions;

			List<CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_PhoneNumber> contactFlow_phoneNumbers = new List<CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_PhoneNumber>();
			for (int i = 0; i < context.Length("CreateContactFlow.ContactFlow.PhoneNumbers.Length"); i++) {
				CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_PhoneNumber phoneNumber = new CreateContactFlowResponse.CreateContactFlow_ContactFlow.CreateContactFlow_PhoneNumber();
				phoneNumber.PhoneNumberId = context.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = context.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = context.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = context.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = context.BooleanValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = context.IntegerValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = context.BooleanValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = context.StringValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = context.IntegerValue("CreateContactFlow.ContactFlow.PhoneNumbers["+ i +"].Trunks");

				contactFlow_phoneNumbers.Add(phoneNumber);
			}
			contactFlow.PhoneNumbers = contactFlow_phoneNumbers;
			createContactFlowResponse.ContactFlow = contactFlow;
        
			return createContactFlowResponse;
        }
    }
}
