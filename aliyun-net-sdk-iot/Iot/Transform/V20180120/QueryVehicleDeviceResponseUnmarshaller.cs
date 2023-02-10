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
    public class QueryVehicleDeviceResponseUnmarshaller
    {
        public static QueryVehicleDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryVehicleDeviceResponse queryVehicleDeviceResponse = new QueryVehicleDeviceResponse();

			queryVehicleDeviceResponse.HttpResponse = _ctx.HttpResponse;
			queryVehicleDeviceResponse.RequestId = _ctx.StringValue("QueryVehicleDevice.RequestId");
			queryVehicleDeviceResponse.Success = _ctx.BooleanValue("QueryVehicleDevice.Success");
			queryVehicleDeviceResponse.Code = _ctx.StringValue("QueryVehicleDevice.Code");
			queryVehicleDeviceResponse.ErrorMessage = _ctx.StringValue("QueryVehicleDevice.ErrorMessage");

			QueryVehicleDeviceResponse.QueryVehicleDevice_Data data = new QueryVehicleDeviceResponse.QueryVehicleDevice_Data();
			data.IotId = _ctx.StringValue("QueryVehicleDevice.Data.IotId");
			data.ProductKey = _ctx.StringValue("QueryVehicleDevice.Data.ProductKey");
			data.DeviceName = _ctx.StringValue("QueryVehicleDevice.Data.DeviceName");
			data.Manufacturer = _ctx.StringValue("QueryVehicleDevice.Data.Manufacturer");
			data.DeviceModel = _ctx.StringValue("QueryVehicleDevice.Data.DeviceModel");
			data.DeviceId = _ctx.StringValue("QueryVehicleDevice.Data.DeviceId");
			data.Status = _ctx.StringValue("QueryVehicleDevice.Data.Status");
			data.AuthCode = _ctx.StringValue("QueryVehicleDevice.Data.AuthCode");
			data.Province = _ctx.StringValue("QueryVehicleDevice.Data.Province");
			data.City = _ctx.StringValue("QueryVehicleDevice.Data.City");
			data.VehicleColour = _ctx.StringValue("QueryVehicleDevice.Data.VehicleColour");
			data.VehicleNumber = _ctx.StringValue("QueryVehicleDevice.Data.VehicleNumber");
			data.CreateTime = _ctx.LongValue("QueryVehicleDevice.Data.CreateTime");
			data.ModifiedTime = _ctx.LongValue("QueryVehicleDevice.Data.ModifiedTime");
			data.RegisterTime = _ctx.LongValue("QueryVehicleDevice.Data.RegisterTime");
			queryVehicleDeviceResponse.Data = data;
        
			return queryVehicleDeviceResponse;
        }
    }
}
