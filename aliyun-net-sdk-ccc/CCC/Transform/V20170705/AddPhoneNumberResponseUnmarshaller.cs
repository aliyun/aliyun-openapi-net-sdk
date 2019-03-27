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
        public static AddPhoneNumberResponse Unmarshall(UnmarshallerContext context)
        {
			AddPhoneNumberResponse addPhoneNumberResponse = new AddPhoneNumberResponse();

			addPhoneNumberResponse.HttpResponse = context.HttpResponse;
			addPhoneNumberResponse.RequestId = context.StringValue("AddPhoneNumber.RequestId");
			addPhoneNumberResponse.Success = context.BooleanValue("AddPhoneNumber.Success");
			addPhoneNumberResponse.Code = context.StringValue("AddPhoneNumber.Code");
			addPhoneNumberResponse.Message = context.StringValue("AddPhoneNumber.Message");
			addPhoneNumberResponse.HttpStatusCode = context.IntegerValue("AddPhoneNumber.HttpStatusCode");

			AddPhoneNumberResponse.AddPhoneNumber_PhoneNumber phoneNumber = new AddPhoneNumberResponse.AddPhoneNumber_PhoneNumber();
			phoneNumber.PhoneNumberId = context.StringValue("AddPhoneNumber.PhoneNumber.PhoneNumberId");
			phoneNumber.InstanceId = context.StringValue("AddPhoneNumber.PhoneNumber.InstanceId");
			phoneNumber.Number = context.StringValue("AddPhoneNumber.PhoneNumber.Number");
			phoneNumber.PhoneNumberDescription = context.StringValue("AddPhoneNumber.PhoneNumber.PhoneNumberDescription");
			phoneNumber.TestOnly = context.BooleanValue("AddPhoneNumber.PhoneNumber.TestOnly");
			phoneNumber.RemainingTime = context.IntegerValue("AddPhoneNumber.PhoneNumber.RemainingTime");
			phoneNumber.AllowOutbound = context.BooleanValue("AddPhoneNumber.PhoneNumber.AllowOutbound");
			phoneNumber.Usage = context.StringValue("AddPhoneNumber.PhoneNumber.Usage");
			phoneNumber.Trunks = context.IntegerValue("AddPhoneNumber.PhoneNumber.Trunks");

			AddPhoneNumberResponse.AddPhoneNumber_PhoneNumber.AddPhoneNumber_ContactFlow contactFlow = new AddPhoneNumberResponse.AddPhoneNumber_PhoneNumber.AddPhoneNumber_ContactFlow();
			contactFlow.ContactFlowId = context.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.ContactFlowId");
			contactFlow.InstanceId = context.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.InstanceId");
			contactFlow.ContactFlowName = context.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.ContactFlowName");
			contactFlow.ContactFlowDescription = context.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.ContactFlowDescription");
			contactFlow.Type = context.StringValue("AddPhoneNumber.PhoneNumber.ContactFlow.Type");
			phoneNumber.ContactFlow = contactFlow;
			addPhoneNumberResponse.PhoneNumber = phoneNumber;
        
			return addPhoneNumberResponse;
        }
    }
}
