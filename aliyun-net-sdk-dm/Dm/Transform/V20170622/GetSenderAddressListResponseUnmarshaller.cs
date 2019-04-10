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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class GetSenderAddressListResponseUnmarshaller
    {
        public static GetSenderAddressListResponse Unmarshall(UnmarshallerContext context)
        {
			GetSenderAddressListResponse getSenderAddressListResponse = new GetSenderAddressListResponse();

			getSenderAddressListResponse.HttpResponse = context.HttpResponse;
			getSenderAddressListResponse.RequestId = context.StringValue("GetSenderAddressList.RequestId");
			getSenderAddressListResponse.Total = context.IntegerValue("GetSenderAddressList.Total");
			getSenderAddressListResponse.PageNo = context.IntegerValue("GetSenderAddressList.PageNo");
			getSenderAddressListResponse.PageSize = context.IntegerValue("GetSenderAddressList.PageSize");

			List<GetSenderAddressListResponse.GetSenderAddressList_SenderAddressNotificationInfo> getSenderAddressListResponse_data = new List<GetSenderAddressListResponse.GetSenderAddressList_SenderAddressNotificationInfo>();
			for (int i = 0; i < context.Length("GetSenderAddressList.Data.Length"); i++) {
				GetSenderAddressListResponse.GetSenderAddressList_SenderAddressNotificationInfo senderAddressNotificationInfo = new GetSenderAddressListResponse.GetSenderAddressList_SenderAddressNotificationInfo();
				senderAddressNotificationInfo.Region = context.StringValue("GetSenderAddressList.Data["+ i +"].Region");
				senderAddressNotificationInfo.UpdateTime = context.StringValue("GetSenderAddressList.Data["+ i +"].UpdateTime");
				senderAddressNotificationInfo.Status = context.StringValue("GetSenderAddressList.Data["+ i +"].Status");
				senderAddressNotificationInfo.SenderAddressId = context.StringValue("GetSenderAddressList.Data["+ i +"].SenderAddressId");
				senderAddressNotificationInfo.SenderAddress = context.StringValue("GetSenderAddressList.Data["+ i +"].SenderAddress");

				getSenderAddressListResponse_data.Add(senderAddressNotificationInfo);
			}
			getSenderAddressListResponse.Data = getSenderAddressListResponse_data;
        
			return getSenderAddressListResponse;
        }
    }
}
