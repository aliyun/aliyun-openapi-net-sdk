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
using Aliyun.Acs.Push.Model.V20160801;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryDeviceInfoResponseUnmarshaller
    {
        public static QueryDeviceInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceInfoResponse queryDeviceInfoResponse = new QueryDeviceInfoResponse();

			queryDeviceInfoResponse.HttpResponse = context.HttpResponse;
			queryDeviceInfoResponse.RequestId = context.StringValue("QueryDeviceInfo.RequestId");

			QueryDeviceInfoResponse.DeviceInfo_ deviceInfo = new QueryDeviceInfoResponse.DeviceInfo_();
			deviceInfo.DeviceId = context.StringValue("QueryDeviceInfo.DeviceInfo.DeviceId");
			deviceInfo.DeviceType = context.StringValue("QueryDeviceInfo.DeviceInfo.DeviceType");
			deviceInfo.Account = context.StringValue("QueryDeviceInfo.DeviceInfo.Account");
			deviceInfo.DeviceToken = context.StringValue("QueryDeviceInfo.DeviceInfo.DeviceToken");
			deviceInfo.Tags = context.StringValue("QueryDeviceInfo.DeviceInfo.Tags");
			deviceInfo.Alias = context.StringValue("QueryDeviceInfo.DeviceInfo.Alias");
			deviceInfo.LastOnlineTime = context.StringValue("QueryDeviceInfo.DeviceInfo.LastOnlineTime");
			deviceInfo.Online = context.BooleanValue("QueryDeviceInfo.DeviceInfo.Online");
			queryDeviceInfoResponse.DeviceInfo = deviceInfo;
        
			return queryDeviceInfoResponse;
        }
    }
}