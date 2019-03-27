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
    public class ListContactFlowsResponseUnmarshaller
    {
        public static ListContactFlowsResponse Unmarshall(UnmarshallerContext context)
        {
			ListContactFlowsResponse listContactFlowsResponse = new ListContactFlowsResponse();

			listContactFlowsResponse.HttpResponse = context.HttpResponse;
			listContactFlowsResponse.RequestId = context.StringValue("ListContactFlows.RequestId");
			listContactFlowsResponse.Success = context.BooleanValue("ListContactFlows.Success");
			listContactFlowsResponse.Code = context.StringValue("ListContactFlows.Code");
			listContactFlowsResponse.Message = context.StringValue("ListContactFlows.Message");
			listContactFlowsResponse.HttpStatusCode = context.IntegerValue("ListContactFlows.HttpStatusCode");

			List<ListContactFlowsResponse.ListContactFlows_ContactFlow> listContactFlowsResponse_contactFlows = new List<ListContactFlowsResponse.ListContactFlows_ContactFlow>();
			for (int i = 0; i < context.Length("ListContactFlows.ContactFlows.Length"); i++) {
				ListContactFlowsResponse.ListContactFlows_ContactFlow contactFlow = new ListContactFlowsResponse.ListContactFlows_ContactFlow();
				contactFlow.ContactFlowId = context.StringValue("ListContactFlows.ContactFlows["+ i +"].ContactFlowId");
				contactFlow.InstanceId = context.StringValue("ListContactFlows.ContactFlows["+ i +"].InstanceId");
				contactFlow.ContactFlowName = context.StringValue("ListContactFlows.ContactFlows["+ i +"].ContactFlowName");
				contactFlow.ContactFlowDescription = context.StringValue("ListContactFlows.ContactFlows["+ i +"].ContactFlowDescription");
				contactFlow.Type = context.StringValue("ListContactFlows.ContactFlows["+ i +"].Type");
				contactFlow.AppliedVersion = context.StringValue("ListContactFlows.ContactFlows["+ i +"].AppliedVersion");

				List<ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_ContactFlowVersion> contactFlow_versions = new List<ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_ContactFlowVersion>();
				for (int j = 0; j < context.Length("ListContactFlows.ContactFlows["+ i +"].Versions.Length"); j++) {
					ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_ContactFlowVersion contactFlowVersion = new ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_ContactFlowVersion();
					contactFlowVersion.ContactFlowVersionId = context.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].ContactFlowVersionId");
					contactFlowVersion.Version = context.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].Version");
					contactFlowVersion.ContactFlowVersionDescription = context.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].ContactFlowVersionDescription");
					contactFlowVersion.LastModified = context.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].LastModified");
					contactFlowVersion.LastModifiedBy = context.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].LastModifiedBy");
					contactFlowVersion.LockedBy = context.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].LockedBy");
					contactFlowVersion.Status = context.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].Status");

					contactFlow_versions.Add(contactFlowVersion);
				}
				contactFlow.Versions = contactFlow_versions;

				List<ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_PhoneNumber> contactFlow_phoneNumbers = new List<ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_PhoneNumber>();
				for (int j = 0; j < context.Length("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers.Length"); j++) {
					ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_PhoneNumber phoneNumber = new ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_PhoneNumber();
					phoneNumber.PhoneNumberId = context.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].PhoneNumberId");
					phoneNumber.InstanceId = context.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].InstanceId");
					phoneNumber.Number = context.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].Number");
					phoneNumber.PhoneNumberDescription = context.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].PhoneNumberDescription");
					phoneNumber.TestOnly = context.BooleanValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].TestOnly");
					phoneNumber.RemainingTime = context.IntegerValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].RemainingTime");
					phoneNumber.AllowOutbound = context.BooleanValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].AllowOutbound");
					phoneNumber.Usage = context.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].Usage");
					phoneNumber.Trunks = context.IntegerValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].Trunks");

					contactFlow_phoneNumbers.Add(phoneNumber);
				}
				contactFlow.PhoneNumbers = contactFlow_phoneNumbers;

				listContactFlowsResponse_contactFlows.Add(contactFlow);
			}
			listContactFlowsResponse.ContactFlows = listContactFlowsResponse_contactFlows;
        
			return listContactFlowsResponse;
        }
    }
}
