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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CCC.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListPhoneNumbersResponseUnmarshaller
    {
        public static ListPhoneNumbersResponse Unmarshall(UnmarshallerContext context)
        {
            ListPhoneNumbersResponse listPhoneNumbersResponse = new ListPhoneNumbersResponse();

            listPhoneNumbersResponse.HttpResponse = context.HttpResponse;
            listPhoneNumbersResponse.RequestId = context.StringValue("ListPhoneNumbers.RequestId");
            listPhoneNumbersResponse.Success = context.BooleanValue("ListPhoneNumbers.Success");
            listPhoneNumbersResponse.Code = context.StringValue("ListPhoneNumbers.Code");
            listPhoneNumbersResponse.Message = context.StringValue("ListPhoneNumbers.Message");
            listPhoneNumbersResponse.HttpStatusCode = context.IntegerValue("ListPhoneNumbers.HttpStatusCode");

            List<ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber> listPhoneNumbersResponse_phoneNumbers = new List<ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber>();
            for (int i = 0; i < context.Length("ListPhoneNumbers.PhoneNumbers.Length"); i++)
            {
                ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber phoneNumber = new ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber();
                phoneNumber.PhoneNumberId = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].PhoneNumberId");
                phoneNumber.InstanceId = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].InstanceId");
                phoneNumber.Number = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].Number");
                phoneNumber.PhoneNumberDescription = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].PhoneNumberDescription");
                phoneNumber.TestOnly = context.BooleanValue("ListPhoneNumbers.PhoneNumbers[" + i + "].TestOnly");
                phoneNumber.RemainingTime = context.IntegerValue("ListPhoneNumbers.PhoneNumbers[" + i + "].RemainingTime");
                phoneNumber.AllowOutbound = context.BooleanValue("ListPhoneNumbers.PhoneNumbers[" + i + "].AllowOutbound");
                phoneNumber.Usage = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].Usage");
                phoneNumber.Trunks = context.IntegerValue("ListPhoneNumbers.PhoneNumbers[" + i + "].Trunks");
                phoneNumber.Province = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].Province");
                phoneNumber.City = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].City");

                ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_ContactFlow contactFlow = new ListPhoneNumbersResponse.ListPhoneNumbers_PhoneNumber.ListPhoneNumbers_ContactFlow();
                contactFlow.ContactFlowId = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].ContactFlow.ContactFlowId");
                contactFlow.InstanceId = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].ContactFlow.InstanceId");
                contactFlow.ContactFlowName = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].ContactFlow.ContactFlowName");
                contactFlow.ContactFlowDescription = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].ContactFlow.ContactFlowDescription");
                contactFlow.Type = context.StringValue("ListPhoneNumbers.PhoneNumbers[" + i + "].ContactFlow.Type");
                phoneNumber.ContactFlow = contactFlow;

                listPhoneNumbersResponse_phoneNumbers.Add(phoneNumber);
            }
            listPhoneNumbersResponse.PhoneNumbers = listPhoneNumbersResponse_phoneNumbers;

            return listPhoneNumbersResponse;
        }
    }
}