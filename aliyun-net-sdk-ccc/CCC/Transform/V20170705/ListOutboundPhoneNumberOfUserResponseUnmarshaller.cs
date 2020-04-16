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
    public class ListOutboundPhoneNumberOfUserResponseUnmarshaller
    {
        public static ListOutboundPhoneNumberOfUserResponse Unmarshall(UnmarshallerContext context)
        {
			ListOutboundPhoneNumberOfUserResponse listOutboundPhoneNumberOfUserResponse = new ListOutboundPhoneNumberOfUserResponse();

			listOutboundPhoneNumberOfUserResponse.HttpResponse = context.HttpResponse;
			listOutboundPhoneNumberOfUserResponse.RequestId = context.StringValue("ListOutboundPhoneNumberOfUser.RequestId");
			listOutboundPhoneNumberOfUserResponse.Success = context.BooleanValue("ListOutboundPhoneNumberOfUser.Success");
			listOutboundPhoneNumberOfUserResponse.Code = context.StringValue("ListOutboundPhoneNumberOfUser.Code");
			listOutboundPhoneNumberOfUserResponse.Message = context.StringValue("ListOutboundPhoneNumberOfUser.Message");
			listOutboundPhoneNumberOfUserResponse.HttpStatusCode = context.IntegerValue("ListOutboundPhoneNumberOfUser.HttpStatusCode");

			List<string> listOutboundPhoneNumberOfUserResponse_numberList = new List<string>();
			for (int i = 0; i < context.Length("ListOutboundPhoneNumberOfUser.NumberList.Length"); i++) {
				listOutboundPhoneNumberOfUserResponse_numberList.Add(context.StringValue("ListOutboundPhoneNumberOfUser.NumberList["+ i +"]"));
			}
			listOutboundPhoneNumberOfUserResponse.NumberList = listOutboundPhoneNumberOfUserResponse_numberList;

			List<ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber> listOutboundPhoneNumberOfUserResponse_outboundPhoneNumbers = new List<ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber>();
			for (int i = 0; i < context.Length("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers.Length"); i++) {
				ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber phoneNumber = new ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber();
				phoneNumber.PhoneNumberId = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = context.BooleanValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = context.IntegerValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = context.BooleanValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = context.IntegerValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].Trunks");
				phoneNumber.City = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].City");
				phoneNumber.Province = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].Province");
				phoneNumber.PrivateFlag = context.BooleanValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivateFlag");
				phoneNumber.SipTelX = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].SipTelX");

				ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber.ListOutboundPhoneNumberOfUser_PrivacyNumber privacyNumber = new ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber.ListOutboundPhoneNumberOfUser_PrivacyNumber();
				privacyNumber.PoolId = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.PoolId");
				privacyNumber.Type = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.Type");
				privacyNumber.TelX = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.TelX");
				privacyNumber.PoolName = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.PoolName");
				privacyNumber.PhoneNumber = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.PhoneNumber");
				privacyNumber.Extra = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.Extra");
				privacyNumber.BizId = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.BizId");
				privacyNumber.SubId = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.SubId");
				privacyNumber.RegionNameCity = context.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.RegionNameCity");
				phoneNumber.PrivacyNumber = privacyNumber;

				listOutboundPhoneNumberOfUserResponse_outboundPhoneNumbers.Add(phoneNumber);
			}
			listOutboundPhoneNumberOfUserResponse.OutboundPhoneNumbers = listOutboundPhoneNumberOfUserResponse_outboundPhoneNumbers;
        
			return listOutboundPhoneNumberOfUserResponse;
        }
    }
}
