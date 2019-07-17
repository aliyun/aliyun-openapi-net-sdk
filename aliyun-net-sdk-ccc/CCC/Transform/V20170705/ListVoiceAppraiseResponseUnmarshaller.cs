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
    public class ListVoiceAppraiseResponseUnmarshaller
    {
        public static ListVoiceAppraiseResponse Unmarshall(UnmarshallerContext context)
        {
			ListVoiceAppraiseResponse listVoiceAppraiseResponse = new ListVoiceAppraiseResponse();

			listVoiceAppraiseResponse.HttpResponse = context.HttpResponse;
			listVoiceAppraiseResponse.RequestId = context.StringValue("ListVoiceAppraise.RequestId");
			listVoiceAppraiseResponse.Success = context.BooleanValue("ListVoiceAppraise.Success");
			listVoiceAppraiseResponse.Code = context.StringValue("ListVoiceAppraise.Code");
			listVoiceAppraiseResponse.Message = context.StringValue("ListVoiceAppraise.Message");
			listVoiceAppraiseResponse.HttpStatusCode = context.IntegerValue("ListVoiceAppraise.HttpStatusCode");
			listVoiceAppraiseResponse.Notice = context.StringValue("ListVoiceAppraise.Notice");

			ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow contactFlow = new ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow();
			contactFlow.ContactFlowId = context.StringValue("ListVoiceAppraise.ContactFlow.ContactFlowId");
			contactFlow.InstanceId = context.StringValue("ListVoiceAppraise.ContactFlow.InstanceId");
			contactFlow.ContactFlowName = context.StringValue("ListVoiceAppraise.ContactFlow.ContactFlowName");
			contactFlow.ContactFlowDescription = context.StringValue("ListVoiceAppraise.ContactFlow.ContactFlowDescription");
			contactFlow.Type = context.StringValue("ListVoiceAppraise.ContactFlow.Type");
			contactFlow.AppliedVersion = context.StringValue("ListVoiceAppraise.ContactFlow.AppliedVersion");

			List<ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow.ListVoiceAppraise_ContactFlowVersion> contactFlow_versions = new List<ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow.ListVoiceAppraise_ContactFlowVersion>();
			for (int i = 0; i < context.Length("ListVoiceAppraise.ContactFlow.Versions.Length"); i++) {
				ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow.ListVoiceAppraise_ContactFlowVersion contactFlowVersion = new ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow.ListVoiceAppraise_ContactFlowVersion();
				contactFlowVersion.ContactFlowVersionId = context.StringValue("ListVoiceAppraise.ContactFlow.Versions["+ i +"].ContactFlowVersionId");
				contactFlowVersion.Version = context.StringValue("ListVoiceAppraise.ContactFlow.Versions["+ i +"].Version");
				contactFlowVersion.ContactFlowVersionDescription = context.StringValue("ListVoiceAppraise.ContactFlow.Versions["+ i +"].ContactFlowVersionDescription");
				contactFlowVersion.Content = context.StringValue("ListVoiceAppraise.ContactFlow.Versions["+ i +"].Content");
				contactFlowVersion.LastModified = context.StringValue("ListVoiceAppraise.ContactFlow.Versions["+ i +"].LastModified");
				contactFlowVersion.LastModifiedBy = context.StringValue("ListVoiceAppraise.ContactFlow.Versions["+ i +"].LastModifiedBy");
				contactFlowVersion.Status = context.StringValue("ListVoiceAppraise.ContactFlow.Versions["+ i +"].Status");

				contactFlow_versions.Add(contactFlowVersion);
			}
			contactFlow.Versions = contactFlow_versions;

			List<ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow.ListVoiceAppraise_PhoneNumber> contactFlow_phoneNumbers = new List<ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow.ListVoiceAppraise_PhoneNumber>();
			for (int i = 0; i < context.Length("ListVoiceAppraise.ContactFlow.PhoneNumbers.Length"); i++) {
				ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow.ListVoiceAppraise_PhoneNumber phoneNumber = new ListVoiceAppraiseResponse.ListVoiceAppraise_ContactFlow.ListVoiceAppraise_PhoneNumber();
				phoneNumber.PhoneNumberId = context.StringValue("ListVoiceAppraise.ContactFlow.PhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = context.StringValue("ListVoiceAppraise.ContactFlow.PhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = context.StringValue("ListVoiceAppraise.ContactFlow.PhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = context.StringValue("ListVoiceAppraise.ContactFlow.PhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.RemainingTime = context.IntegerValue("ListVoiceAppraise.ContactFlow.PhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.Trunks = context.IntegerValue("ListVoiceAppraise.ContactFlow.PhoneNumbers["+ i +"].Trunks");

				contactFlow_phoneNumbers.Add(phoneNumber);
			}
			contactFlow.PhoneNumbers = contactFlow_phoneNumbers;
			listVoiceAppraiseResponse.ContactFlow = contactFlow;
        
			return listVoiceAppraiseResponse;
        }
    }
}
