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
    public class QueryEdgeInstanceDeviceResponseUnmarshaller
    {
        public static QueryEdgeInstanceDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEdgeInstanceDeviceResponse queryEdgeInstanceDeviceResponse = new QueryEdgeInstanceDeviceResponse();

			queryEdgeInstanceDeviceResponse.HttpResponse = _ctx.HttpResponse;
			queryEdgeInstanceDeviceResponse.RequestId = _ctx.StringValue("QueryEdgeInstanceDevice.RequestId");
			queryEdgeInstanceDeviceResponse.Success = _ctx.BooleanValue("QueryEdgeInstanceDevice.Success");
			queryEdgeInstanceDeviceResponse.Code = _ctx.StringValue("QueryEdgeInstanceDevice.Code");
			queryEdgeInstanceDeviceResponse.ErrorMessage = _ctx.StringValue("QueryEdgeInstanceDevice.ErrorMessage");

			QueryEdgeInstanceDeviceResponse.QueryEdgeInstanceDevice_Data data = new QueryEdgeInstanceDeviceResponse.QueryEdgeInstanceDevice_Data();
			data.Total = _ctx.IntegerValue("QueryEdgeInstanceDevice.Data.Total");
			data.PageSize = _ctx.IntegerValue("QueryEdgeInstanceDevice.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QueryEdgeInstanceDevice.Data.CurrentPage");

			List<QueryEdgeInstanceDeviceResponse.QueryEdgeInstanceDevice_Data.QueryEdgeInstanceDevice_Device> data_deviceList = new List<QueryEdgeInstanceDeviceResponse.QueryEdgeInstanceDevice_Data.QueryEdgeInstanceDevice_Device>();
			for (int i = 0; i < _ctx.Length("QueryEdgeInstanceDevice.Data.DeviceList.Length"); i++) {
				QueryEdgeInstanceDeviceResponse.QueryEdgeInstanceDevice_Data.QueryEdgeInstanceDevice_Device device = new QueryEdgeInstanceDeviceResponse.QueryEdgeInstanceDevice_Data.QueryEdgeInstanceDevice_Device();
				device.IotId = _ctx.StringValue("QueryEdgeInstanceDevice.Data.DeviceList["+ i +"].IotId");
				device.ProductKey = _ctx.StringValue("QueryEdgeInstanceDevice.Data.DeviceList["+ i +"].ProductKey");
				device.DeviceName = _ctx.StringValue("QueryEdgeInstanceDevice.Data.DeviceList["+ i +"].DeviceName");
				device.DriverId = _ctx.StringValue("QueryEdgeInstanceDevice.Data.DeviceList["+ i +"].DriverId");

				data_deviceList.Add(device);
			}
			data.DeviceList = data_deviceList;
			queryEdgeInstanceDeviceResponse.Data = data;
        
			return queryEdgeInstanceDeviceResponse;
        }
    }
}
