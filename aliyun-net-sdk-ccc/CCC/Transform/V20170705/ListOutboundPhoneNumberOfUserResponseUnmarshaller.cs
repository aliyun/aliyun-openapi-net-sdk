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
        public static ListOutboundPhoneNumberOfUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOutboundPhoneNumberOfUserResponse listOutboundPhoneNumberOfUserResponse = new ListOutboundPhoneNumberOfUserResponse();

			listOutboundPhoneNumberOfUserResponse.HttpResponse = _ctx.HttpResponse;
			listOutboundPhoneNumberOfUserResponse.RequestId = _ctx.StringValue("ListOutboundPhoneNumberOfUser.RequestId");
			listOutboundPhoneNumberOfUserResponse.Success = _ctx.BooleanValue("ListOutboundPhoneNumberOfUser.Success");
			listOutboundPhoneNumberOfUserResponse.Code = _ctx.StringValue("ListOutboundPhoneNumberOfUser.Code");
			listOutboundPhoneNumberOfUserResponse.Message = _ctx.StringValue("ListOutboundPhoneNumberOfUser.Message");
			listOutboundPhoneNumberOfUserResponse.HttpStatusCode = _ctx.IntegerValue("ListOutboundPhoneNumberOfUser.HttpStatusCode");

			List<string> listOutboundPhoneNumberOfUserResponse_numberList = new List<string>();
			for (int i = 0; i < _ctx.Length("ListOutboundPhoneNumberOfUser.NumberList.Length"); i++) {
				listOutboundPhoneNumberOfUserResponse_numberList.Add(_ctx.StringValue("ListOutboundPhoneNumberOfUser.NumberList["+ i +"]"));
			}
			listOutboundPhoneNumberOfUserResponse.NumberList = listOutboundPhoneNumberOfUserResponse_numberList;

			List<ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber> listOutboundPhoneNumberOfUserResponse_outboundPhoneNumbers = new List<ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers.Length"); i++) {
				ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber phoneNumber = new ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber();
				phoneNumber.PhoneNumberId = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = _ctx.BooleanValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = _ctx.IntegerValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = _ctx.BooleanValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = _ctx.IntegerValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].Trunks");
				phoneNumber.City = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].City");
				phoneNumber.Province = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].Province");
				phoneNumber.PrivateFlag = _ctx.BooleanValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivateFlag");
				phoneNumber.SipTelX = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].SipTelX");

				ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber.ListOutboundPhoneNumberOfUser_PrivacyNumber privacyNumber = new ListOutboundPhoneNumberOfUserResponse.ListOutboundPhoneNumberOfUser_PhoneNumber.ListOutboundPhoneNumberOfUser_PrivacyNumber();
				privacyNumber.PoolId = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.PoolId");
				privacyNumber.Type = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.Type");
				privacyNumber.TelX = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.TelX");
				privacyNumber.PoolName = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.PoolName");
				privacyNumber.PhoneNumber = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.PhoneNumber");
				privacyNumber.Extra = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.Extra");
				privacyNumber.BizId = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.BizId");
				privacyNumber.SubId = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.SubId");
				privacyNumber.RegionNameCity = _ctx.StringValue("ListOutboundPhoneNumberOfUser.OutboundPhoneNumbers["+ i +"].PrivacyNumber.RegionNameCity");
				phoneNumber.PrivacyNumber = privacyNumber;

				listOutboundPhoneNumberOfUserResponse_outboundPhoneNumbers.Add(phoneNumber);
			}
			listOutboundPhoneNumberOfUserResponse.OutboundPhoneNumbers = listOutboundPhoneNumberOfUserResponse_outboundPhoneNumbers;
        
			return listOutboundPhoneNumberOfUserResponse;
        }
    }
}
