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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryDeviceResponseUnmarshaller
    {
        public static QueryDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceResponse queryDeviceResponse = new QueryDeviceResponse();

			queryDeviceResponse.HttpResponse = context.HttpResponse;
			queryDeviceResponse.RequestId = context.StringValue("QueryDevice.RequestId");
			queryDeviceResponse.Success = context.BooleanValue("QueryDevice.Success");
			queryDeviceResponse.Code = context.StringValue("QueryDevice.Code");
			queryDeviceResponse.ErrorMessage = context.StringValue("QueryDevice.ErrorMessage");
			queryDeviceResponse.Total = context.IntegerValue("QueryDevice.Total");
			queryDeviceResponse.PageSize = context.IntegerValue("QueryDevice.PageSize");
			queryDeviceResponse.PageCount = context.IntegerValue("QueryDevice.PageCount");
			queryDeviceResponse.Page = context.IntegerValue("QueryDevice.Page");

			List<QueryDeviceResponse.QueryDevice_DeviceInfo> queryDeviceResponse_data = new List<QueryDeviceResponse.QueryDevice_DeviceInfo>();
			for (int i = 0; i < context.Length("QueryDevice.Data.Length"); i++) {
				QueryDeviceResponse.QueryDevice_DeviceInfo deviceInfo = new QueryDeviceResponse.QueryDevice_DeviceInfo();
				deviceInfo.DeviceId = context.StringValue("QueryDevice.Data["+ i +"].DeviceId");
				deviceInfo.DeviceSecret = context.StringValue("QueryDevice.Data["+ i +"].DeviceSecret");
				deviceInfo.ProductKey = context.StringValue("QueryDevice.Data["+ i +"].ProductKey");
				deviceInfo.DeviceStatus = context.StringValue("QueryDevice.Data["+ i +"].DeviceStatus");
				deviceInfo.DeviceName = context.StringValue("QueryDevice.Data["+ i +"].DeviceName");
				deviceInfo.DeviceType = context.StringValue("QueryDevice.Data["+ i +"].DeviceType");
				deviceInfo.GmtCreate = context.StringValue("QueryDevice.Data["+ i +"].GmtCreate");
				deviceInfo.GmtModified = context.StringValue("QueryDevice.Data["+ i +"].GmtModified");
				deviceInfo.UtcCreate = context.StringValue("QueryDevice.Data["+ i +"].UtcCreate");
				deviceInfo.UtcModified = context.StringValue("QueryDevice.Data["+ i +"].UtcModified");
				deviceInfo.IotId = context.StringValue("QueryDevice.Data["+ i +"].IotId");
				deviceInfo.Nickname = context.StringValue("QueryDevice.Data["+ i +"].Nickname");

				queryDeviceResponse_data.Add(deviceInfo);
			}
			queryDeviceResponse.Data = queryDeviceResponse_data;
        
			return queryDeviceResponse;
        }
    }
}
