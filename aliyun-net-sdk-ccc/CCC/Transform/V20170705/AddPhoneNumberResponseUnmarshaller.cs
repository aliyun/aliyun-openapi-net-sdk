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
    public class AddPhoneNumberResponseUnmarshaller
    {
        public static AddPhoneNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddPhoneNumberResponse addPhoneNumberResponse = new AddPhoneNumberResponse();

			addPhoneNumberResponse.HttpResponse = _ctx.HttpResponse;
			addPhoneNumberResponse.RequestId = _ctx.StringValue("AddPhoneNumber.RequestId");
			addPhoneNumberResponse.Success = _ctx.BooleanValue("AddPhoneNumber.Success");
			addPhoneNumberResponse.Code = _ctx.StringValue("AddPhoneNumber.Code");
			addPhoneNumberResponse.Message = _ctx.StringValue("AddPhoneNumber.Message");
			addPhoneNumberResponse.HttpStatusCode = _ctx.IntegerValue("AddPhoneNumber.HttpStatusCode");

			AddPhoneNumberResponse.AddPhoneNumber_PhoneNumber phoneNumber = new AddPhoneNumberResponse.AddPhoneNumber_PhoneNumber();
			phoneNumber.PhoneNumberId = _ctx.StringValue("AddPhoneNumber.PhoneNumber.PhoneNumberId");
			phoneNumber.InstanceId = _ctx.StringValue("AddPhoneNumber.PhoneNumber.InstanceId");
			phoneNumber.Number = _ctx.StringValue("AddPhoneNumber.PhoneNumber.Number");
			phoneNumber.PhoneNumberDescription = _ctx.StringValue("AddPhoneNumber.PhoneNumber.PhoneNumberDescription");
			phoneNumber.TestOnly = _ctx.BooleanValue("AddPhoneNumber.PhoneNumber.TestOnly");
			phoneNumber.RemainingTime = _ctx.IntegerValue("AddPhoneNumber.PhoneNumber.RemainingTime");
			phoneNumber.AllowOutbound = _ctx.BooleanValue("AddPhoneNumber.PhoneNumber.AllowOutbound");
			phoneNumber.Usage = _ctx.StringValue("AddPhoneNumber.PhoneNumber.Usage");
			phoneNumber.Trunks = _ctx.IntegerValue("AddPhoneNumber.PhoneNumber.Trunks");

			AddPhoneNumberResponse.AddPhoneNumber_PhoneNumber.AddPhoneNumber_ContactFlow contactFlow = new AddPhoneNumberResponse.AddPhoneNumber_PhoneNumber.AddPhoneNumber_ContactFlow();
			contactFlow.ContactFlowId = _ctx.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.ContactFlowId");
			contactFlow.InstanceId = _ctx.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.InstanceId");
			contactFlow.ContactFlowName = _ctx.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.ContactFlowName");
			contactFlow.ContactFlowDescription = _ctx.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.ContactFlowDescription");
			contactFlow.Type = _ctx.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.Type");
			phoneNumber.ContactFlow = contactFlow;
			addPhoneNumberResponse.PhoneNumber = phoneNumber;
        
			return addPhoneNumberResponse;
        }
    }
}
