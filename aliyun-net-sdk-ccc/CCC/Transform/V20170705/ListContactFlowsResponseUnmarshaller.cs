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
        public static ListContactFlowsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListContactFlowsResponse listContactFlowsResponse = new ListContactFlowsResponse();

			listContactFlowsResponse.HttpResponse = _ctx.HttpResponse;
			listContactFlowsResponse.RequestId = _ctx.StringValue("ListContactFlows.RequestId");
			listContactFlowsResponse.Success = _ctx.BooleanValue("ListContactFlows.Success");
			listContactFlowsResponse.Code = _ctx.StringValue("ListContactFlows.Code");
			listContactFlowsResponse.Message = _ctx.StringValue("ListContactFlows.Message");
			listContactFlowsResponse.HttpStatusCode = _ctx.IntegerValue("ListContactFlows.HttpStatusCode");

			List<ListContactFlowsResponse.ListContactFlows_ContactFlow> listContactFlowsResponse_contactFlows = new List<ListContactFlowsResponse.ListContactFlows_ContactFlow>();
			for (int i = 0; i < _ctx.Length("ListContactFlows.ContactFlows.Length"); i++) {
				ListContactFlowsResponse.ListContactFlows_ContactFlow contactFlow = new ListContactFlowsResponse.ListContactFlows_ContactFlow();
				contactFlow.ContactFlowId = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].ContactFlowId");
				contactFlow.InstanceId = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].InstanceId");
				contactFlow.ContactFlowName = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].ContactFlowName");
				contactFlow.ContactFlowDescription = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].ContactFlowDescription");
				contactFlow.Type = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].Type");
				contactFlow.AppliedVersion = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].AppliedVersion");

				List<ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_ContactFlowVersion> contactFlow_versions = new List<ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_ContactFlowVersion>();
				for (int j = 0; j < _ctx.Length("ListContactFlows.ContactFlows["+ i +"].Versions.Length"); j++) {
					ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_ContactFlowVersion contactFlowVersion = new ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_ContactFlowVersion();
					contactFlowVersion.ContactFlowVersionId = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].ContactFlowVersionId");
					contactFlowVersion.Version = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].Version");
					contactFlowVersion.ContactFlowVersionDescription = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].ContactFlowVersionDescription");
					contactFlowVersion.LastModified = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].LastModified");
					contactFlowVersion.LastModifiedBy = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].LastModifiedBy");
					contactFlowVersion.LockedBy = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].LockedBy");
					contactFlowVersion.Status = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].Versions["+ j +"].Status");

					contactFlow_versions.Add(contactFlowVersion);
				}
				contactFlow.Versions = contactFlow_versions;

				List<ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_PhoneNumber> contactFlow_phoneNumbers = new List<ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_PhoneNumber>();
				for (int j = 0; j < _ctx.Length("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers.Length"); j++) {
					ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_PhoneNumber phoneNumber = new ListContactFlowsResponse.ListContactFlows_ContactFlow.ListContactFlows_PhoneNumber();
					phoneNumber.PhoneNumberId = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].PhoneNumberId");
					phoneNumber.InstanceId = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].InstanceId");
					phoneNumber.Number = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].Number");
					phoneNumber.PhoneNumberDescription = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].PhoneNumberDescription");
					phoneNumber.TestOnly = _ctx.BooleanValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].TestOnly");
					phoneNumber.RemainingTime = _ctx.IntegerValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].RemainingTime");
					phoneNumber.AllowOutbound = _ctx.BooleanValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].AllowOutbound");
					phoneNumber.Usage = _ctx.StringValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].Usage");
					phoneNumber.Trunks = _ctx.IntegerValue("ListContactFlows.ContactFlows["+ i +"].PhoneNumbers["+ j +"].Trunks");

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
