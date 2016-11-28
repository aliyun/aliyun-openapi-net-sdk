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
using Aliyun.Acs.Iot.Model.V20160530;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20160530
{
    public class QueryDeviceByIdResponseUnmarshaller
    {
        public static QueryDeviceByIdResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceByIdResponse queryDeviceByIdResponse = new QueryDeviceByIdResponse();

			queryDeviceByIdResponse.HttpResponse = context.HttpResponse;
			queryDeviceByIdResponse.RequestId = context.StringValue("QueryDeviceById.RequestId");
			queryDeviceByIdResponse.Success = context.BooleanValue("QueryDeviceById.Success");
			queryDeviceByIdResponse.ErrorMessage = context.StringValue("QueryDeviceById.ErrorMessage");

			QueryDeviceByIdResponse.DeviceInfo_ deviceInfo = new QueryDeviceByIdResponse.DeviceInfo_();
			deviceInfo.DeviceId = context.StringValue("QueryDeviceById.DeviceInfo.DeviceId");
			deviceInfo.DeviceSecret = context.StringValue("QueryDeviceById.DeviceInfo.DeviceSecret");
			deviceInfo.ProductKey = context.StringValue("QueryDeviceById.DeviceInfo.ProductKey");
			deviceInfo.DeviceStatus = context.StringValue("QueryDeviceById.DeviceInfo.DeviceStatus");
			deviceInfo.DeviceName = context.StringValue("QueryDeviceById.DeviceInfo.DeviceName");
			deviceInfo.GmtCreate = context.StringValue("QueryDeviceById.DeviceInfo.GmtCreate");
			deviceInfo.GmtModified = context.StringValue("QueryDeviceById.DeviceInfo.GmtModified");
			queryDeviceByIdResponse.DeviceInfo = deviceInfo;
        
			return queryDeviceByIdResponse;
        }
    }
}