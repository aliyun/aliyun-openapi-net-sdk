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
        public static QueryDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceResponse queryDeviceResponse = new QueryDeviceResponse();

			queryDeviceResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceResponse.RequestId = _ctx.StringValue("QueryDevice.RequestId");
			queryDeviceResponse.Success = _ctx.BooleanValue("QueryDevice.Success");
			queryDeviceResponse.Code = _ctx.StringValue("QueryDevice.Code");
			queryDeviceResponse.ErrorMessage = _ctx.StringValue("QueryDevice.ErrorMessage");
			queryDeviceResponse.Total = _ctx.IntegerValue("QueryDevice.Total");
			queryDeviceResponse.PageSize = _ctx.IntegerValue("QueryDevice.PageSize");
			queryDeviceResponse.PageCount = _ctx.IntegerValue("QueryDevice.PageCount");
			queryDeviceResponse.Page = _ctx.IntegerValue("QueryDevice.Page");
			queryDeviceResponse.NextToken = _ctx.StringValue("QueryDevice.NextToken");

			List<QueryDeviceResponse.QueryDevice_DeviceInfo> queryDeviceResponse_data = new List<QueryDeviceResponse.QueryDevice_DeviceInfo>();
			for (int i = 0; i < _ctx.Length("QueryDevice.Data.Length"); i++) {
				QueryDeviceResponse.QueryDevice_DeviceInfo deviceInfo = new QueryDeviceResponse.QueryDevice_DeviceInfo();
				deviceInfo.DeviceId = _ctx.StringValue("QueryDevice.Data["+ i +"].DeviceId");
				deviceInfo.DeviceSecret = _ctx.StringValue("QueryDevice.Data["+ i +"].DeviceSecret");
				deviceInfo.ProductKey = _ctx.StringValue("QueryDevice.Data["+ i +"].ProductKey");
				deviceInfo.DeviceStatus = _ctx.StringValue("QueryDevice.Data["+ i +"].DeviceStatus");
				deviceInfo.DeviceName = _ctx.StringValue("QueryDevice.Data["+ i +"].DeviceName");
				deviceInfo.DeviceType = _ctx.StringValue("QueryDevice.Data["+ i +"].DeviceType");
				deviceInfo.GmtCreate = _ctx.StringValue("QueryDevice.Data["+ i +"].GmtCreate");
				deviceInfo.GmtModified = _ctx.StringValue("QueryDevice.Data["+ i +"].GmtModified");
				deviceInfo.UtcCreate = _ctx.StringValue("QueryDevice.Data["+ i +"].UtcCreate");
				deviceInfo.UtcModified = _ctx.StringValue("QueryDevice.Data["+ i +"].UtcModified");
				deviceInfo.IotId = _ctx.StringValue("QueryDevice.Data["+ i +"].IotId");
				deviceInfo.Nickname = _ctx.StringValue("QueryDevice.Data["+ i +"].Nickname");

				queryDeviceResponse_data.Add(deviceInfo);
			}
			queryDeviceResponse.Data = queryDeviceResponse_data;
        
			return queryDeviceResponse;
        }
    }
}
