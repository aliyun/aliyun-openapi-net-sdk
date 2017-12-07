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
using Aliyun.Acs.Iot.Model.V20170420;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20170420
{
    public class QueryDeviceByNameResponseUnmarshaller
    {
        public static QueryDeviceByNameResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceByNameResponse queryDeviceByNameResponse = new QueryDeviceByNameResponse();

			queryDeviceByNameResponse.HttpResponse = context.HttpResponse;
			queryDeviceByNameResponse.RequestId = context.StringValue("QueryDeviceByName.RequestId");
			queryDeviceByNameResponse.Success = context.BooleanValue("QueryDeviceByName.Success");
			queryDeviceByNameResponse.ErrorMessage = context.StringValue("QueryDeviceByName.ErrorMessage");

			QueryDeviceByNameResponse.QueryDeviceByName_DeviceInfo deviceInfo = new QueryDeviceByNameResponse.QueryDeviceByName_DeviceInfo();
			deviceInfo.DeviceId = context.StringValue("QueryDeviceByName.DeviceInfo.DeviceId");
			deviceInfo.DeviceSecret = context.StringValue("QueryDeviceByName.DeviceInfo.DeviceSecret");
			deviceInfo.ProductKey = context.StringValue("QueryDeviceByName.DeviceInfo.ProductKey");
			deviceInfo.DeviceStatus = context.StringValue("QueryDeviceByName.DeviceInfo.DeviceStatus");
			deviceInfo.DeviceName = context.StringValue("QueryDeviceByName.DeviceInfo.DeviceName");
			deviceInfo.DeviceType = context.StringValue("QueryDeviceByName.DeviceInfo.DeviceType");
			deviceInfo.GmtCreate = context.StringValue("QueryDeviceByName.DeviceInfo.GmtCreate");
			deviceInfo.GmtModified = context.StringValue("QueryDeviceByName.DeviceInfo.GmtModified");
			queryDeviceByNameResponse.DeviceInfo = deviceInfo;
        
			return queryDeviceByNameResponse;
        }
    }
}