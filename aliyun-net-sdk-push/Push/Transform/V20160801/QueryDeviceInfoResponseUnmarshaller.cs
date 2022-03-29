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
using Aliyun.Acs.Push.Model.V20160801;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryDeviceInfoResponseUnmarshaller
    {
        public static QueryDeviceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceInfoResponse queryDeviceInfoResponse = new QueryDeviceInfoResponse();

			queryDeviceInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceInfoResponse.RequestId = _ctx.StringValue("QueryDeviceInfo.RequestId");

			QueryDeviceInfoResponse.QueryDeviceInfo_DeviceInfo deviceInfo = new QueryDeviceInfoResponse.QueryDeviceInfo_DeviceInfo();
			deviceInfo.Account = _ctx.StringValue("QueryDeviceInfo.DeviceInfo.Account");
			deviceInfo.LastOnlineTime = _ctx.StringValue("QueryDeviceInfo.DeviceInfo.LastOnlineTime");
			deviceInfo.PhoneNumber = _ctx.StringValue("QueryDeviceInfo.DeviceInfo.PhoneNumber");
			deviceInfo.PushEnabled = _ctx.BooleanValue("QueryDeviceInfo.DeviceInfo.PushEnabled");
			deviceInfo.DeviceType = _ctx.StringValue("QueryDeviceInfo.DeviceInfo.DeviceType");
			deviceInfo.DeviceId = _ctx.StringValue("QueryDeviceInfo.DeviceInfo.DeviceId");
			deviceInfo.Online = _ctx.BooleanValue("QueryDeviceInfo.DeviceInfo.Online");
			deviceInfo.Tags = _ctx.StringValue("QueryDeviceInfo.DeviceInfo.Tags");
			deviceInfo.DeviceToken = _ctx.StringValue("QueryDeviceInfo.DeviceInfo.DeviceToken");
			deviceInfo.Alias = _ctx.StringValue("QueryDeviceInfo.DeviceInfo.Alias");
			queryDeviceInfoResponse.DeviceInfo = deviceInfo;
        
			return queryDeviceInfoResponse;
        }
    }
}
