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
        public static QueryEdgeInstanceDeviceByDriverResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEdgeInstanceDeviceByDriverResponse queryEdgeInstanceDeviceByDriverResponse = new QueryEdgeInstanceDeviceByDriverResponse();

			queryEdgeInstanceDeviceByDriverResponse.HttpResponse = context.HttpResponse;
			queryEdgeInstanceDeviceByDriverResponse.RequestId = context.StringValue("QueryEdgeInstanceDeviceByDriver.RequestId");
			queryEdgeInstanceDeviceByDriverResponse.Success = context.BooleanValue("QueryEdgeInstanceDeviceByDriver.Success");
			queryEdgeInstanceDeviceByDriverResponse.Code = context.StringValue("QueryEdgeInstanceDeviceByDriver.Code");
			queryEdgeInstanceDeviceByDriverResponse.ErrorMessage = context.StringValue("QueryEdgeInstanceDeviceByDriver.ErrorMessage");

			QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data data = new QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data();
			data.Total = context.IntegerValue("QueryEdgeInstanceDeviceByDriver.Data.Total");
			data.PageSize = context.IntegerValue("QueryEdgeInstanceDeviceByDriver.Data.PageSize");
			data.CurrentPage = context.IntegerValue("QueryEdgeInstanceDeviceByDriver.Data.CurrentPage");

			List<QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data.QueryEdgeInstanceDeviceByDriver_Device> data_deviceList = new List<QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data.QueryEdgeInstanceDeviceByDriver_Device>();
			for (int i = 0; i < context.Length("QueryEdgeInstanceDeviceByDriver.Data.DeviceList.Length"); i++) {
				QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data.QueryEdgeInstanceDeviceByDriver_Device device = new QueryEdgeInstanceDeviceByDriverResponse.QueryEdgeInstanceDeviceByDriver_Data.QueryEdgeInstanceDeviceByDriver_Device();
				device.IotId = context.StringValue("QueryEdgeInstanceDeviceByDriver.Data.DeviceList["+ i +"].IotId");

				data_deviceList.Add(device);
			}
			data.DeviceList = data_deviceList;
			queryEdgeInstanceDeviceByDriverResponse.Data = data;
        
			return queryEdgeInstanceDeviceByDriverResponse;
        }
    }
}
