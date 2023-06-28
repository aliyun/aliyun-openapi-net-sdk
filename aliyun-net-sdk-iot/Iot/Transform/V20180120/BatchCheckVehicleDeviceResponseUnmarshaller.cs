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
    public class BatchCheckVehicleDeviceResponseUnmarshaller
    {
        public static BatchCheckVehicleDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchCheckVehicleDeviceResponse batchCheckVehicleDeviceResponse = new BatchCheckVehicleDeviceResponse();

			batchCheckVehicleDeviceResponse.HttpResponse = _ctx.HttpResponse;
			batchCheckVehicleDeviceResponse.RequestId = _ctx.StringValue("BatchCheckVehicleDevice.RequestId");
			batchCheckVehicleDeviceResponse.Success = _ctx.BooleanValue("BatchCheckVehicleDevice.Success");
			batchCheckVehicleDeviceResponse.Code = _ctx.StringValue("BatchCheckVehicleDevice.Code");
			batchCheckVehicleDeviceResponse.ErrorMessage = _ctx.StringValue("BatchCheckVehicleDevice.ErrorMessage");

			BatchCheckVehicleDeviceResponse.BatchCheckVehicleDevice_Data data = new BatchCheckVehicleDeviceResponse.BatchCheckVehicleDevice_Data();

			List<string> data_invalidManufacturerList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckVehicleDevice.Data.InvalidManufacturerList.Length"); i++) {
				data_invalidManufacturerList.Add(_ctx.StringValue("BatchCheckVehicleDevice.Data.InvalidManufacturerList["+ i +"]"));
			}
			data.InvalidManufacturerList = data_invalidManufacturerList;

			List<string> data_invalidDeviceModelList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckVehicleDevice.Data.InvalidDeviceModelList.Length"); i++) {
				data_invalidDeviceModelList.Add(_ctx.StringValue("BatchCheckVehicleDevice.Data.InvalidDeviceModelList["+ i +"]"));
			}
			data.InvalidDeviceModelList = data_invalidDeviceModelList;

			List<string> data_invalidDeviceIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckVehicleDevice.Data.InvalidDeviceIdList.Length"); i++) {
				data_invalidDeviceIdList.Add(_ctx.StringValue("BatchCheckVehicleDevice.Data.InvalidDeviceIdList["+ i +"]"));
			}
			data.InvalidDeviceIdList = data_invalidDeviceIdList;

			List<string> data_repeatedDeviceIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckVehicleDevice.Data.RepeatedDeviceIdList.Length"); i++) {
				data_repeatedDeviceIdList.Add(_ctx.StringValue("BatchCheckVehicleDevice.Data.RepeatedDeviceIdList["+ i +"]"));
			}
			data.RepeatedDeviceIdList = data_repeatedDeviceIdList;

			List<string> data_invalidDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckVehicleDevice.Data.InvalidDeviceNameList.Length"); i++) {
				data_invalidDeviceNameList.Add(_ctx.StringValue("BatchCheckVehicleDevice.Data.InvalidDeviceNameList["+ i +"]"));
			}
			data.InvalidDeviceNameList = data_invalidDeviceNameList;

			List<string> data_repeatedDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckVehicleDevice.Data.RepeatedDeviceNameList.Length"); i++) {
				data_repeatedDeviceNameList.Add(_ctx.StringValue("BatchCheckVehicleDevice.Data.RepeatedDeviceNameList["+ i +"]"));
			}
			data.RepeatedDeviceNameList = data_repeatedDeviceNameList;

			List<BatchCheckVehicleDeviceResponse.BatchCheckVehicleDevice_Data.BatchCheckVehicleDevice_InvalidDetailListItem> data_invalidDetailList = new List<BatchCheckVehicleDeviceResponse.BatchCheckVehicleDevice_Data.BatchCheckVehicleDevice_InvalidDetailListItem>();
			for (int i = 0; i < _ctx.Length("BatchCheckVehicleDevice.Data.InvalidDetailList.Length"); i++) {
				BatchCheckVehicleDeviceResponse.BatchCheckVehicleDevice_Data.BatchCheckVehicleDevice_InvalidDetailListItem invalidDetailListItem = new BatchCheckVehicleDeviceResponse.BatchCheckVehicleDevice_Data.BatchCheckVehicleDevice_InvalidDetailListItem();
				invalidDetailListItem.Manufacturer = _ctx.StringValue("BatchCheckVehicleDevice.Data.InvalidDetailList["+ i +"].Manufacturer");
				invalidDetailListItem.DeviceModel = _ctx.StringValue("BatchCheckVehicleDevice.Data.InvalidDetailList["+ i +"].DeviceModel");
				invalidDetailListItem.DeviceId = _ctx.StringValue("BatchCheckVehicleDevice.Data.InvalidDetailList["+ i +"].DeviceId");
				invalidDetailListItem.DeviceName = _ctx.StringValue("BatchCheckVehicleDevice.Data.InvalidDetailList["+ i +"].DeviceName");
				invalidDetailListItem.ErrorMsg = _ctx.StringValue("BatchCheckVehicleDevice.Data.InvalidDetailList["+ i +"].ErrorMsg");

				data_invalidDetailList.Add(invalidDetailListItem);
			}
			data.InvalidDetailList = data_invalidDetailList;
			batchCheckVehicleDeviceResponse.Data = data;
        
			return batchCheckVehicleDeviceResponse;
        }
    }
}
