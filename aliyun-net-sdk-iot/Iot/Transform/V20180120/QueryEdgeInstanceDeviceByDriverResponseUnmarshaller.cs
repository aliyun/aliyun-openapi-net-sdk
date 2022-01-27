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
    public class QueryEdgeInstanceDeviceByDriverResponseUnmarshaller
    {
        public static QueryEdgeInstanceDeviceByDriverResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEdgeInstanceDeviceByDriverResponse queryEdgeInstanceDeviceByDriverResponse = new QueryEdgeInstanceDeviceByDriverResponse();

			queryEdgeInstanceDeviceByDriverResponse.HttpResponse = _ctx.HttpResponse;
			queryEdgeInstanceDeviceByDriverResponse.RequestId = _ctx.StringValue("QueryEdgeInstanceDeviceByDriver.RequestId");
			queryEdgeInstanceDeviceByDriverResponse.Success = _ctx.BooleanValue("QueryEdgeInstanceDeviceByDriver.Success");
			queryEdgeInstanceDeviceByDriverResponse.Code = _ctx.StringValue("QueryEdgeInstanceDeviceByDriver.Code");
			queryEdgeInstanceDeviceByDriverResponse.ErrorMessage = _ctx.StringValue("QueryEdgeInstanceDeviceByDriver.ErrorMessage");

			QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data data = new QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data();
			data.Total = _ctx.IntegerValue("QueryEdgeInstanceDeviceByDriver.Data.Total");
			data.PageSize = _ctx.IntegerValue("QueryEdgeInstanceDeviceByDriver.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QueryEdgeInstanceDeviceByDriver.Data.CurrentPage");

			List<QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data.QueryEdgeInstanceDeviceByDriver_Device> data_deviceList = new List<QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data.QueryEdgeInstanceDeviceByDriver_Device>();
			for (int i = 0; i < _ctx.Length("QueryEdgeInstanceDeviceByDriver.Data.DeviceList.Length"); i++) {
				QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data.QueryEdgeInstanceDeviceByDriver_Device device = new QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data.QueryEdgeInstanceDeviceByDriver_Device();
				device.IotId = _ctx.StringValue("QueryEdgeInstanceDeviceByDriver.Data.DeviceList["+ i +"].IotId");

				data_deviceList.Add(device);
			}
			data.DeviceList = data_deviceList;
			queryEdgeInstanceDeviceByDriverResponse.Data = data;
        
			return queryEdgeInstanceDeviceByDriverResponse;
        }
    }
}
