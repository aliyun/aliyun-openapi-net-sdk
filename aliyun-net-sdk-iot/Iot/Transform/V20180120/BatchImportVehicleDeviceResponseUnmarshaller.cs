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
    public class BatchImportVehicleDeviceResponseUnmarshaller
    {
        public static BatchImportVehicleDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchImportVehicleDeviceResponse batchImportVehicleDeviceResponse = new BatchImportVehicleDeviceResponse();

			batchImportVehicleDeviceResponse.HttpResponse = _ctx.HttpResponse;
			batchImportVehicleDeviceResponse.RequestId = _ctx.StringValue("BatchImportVehicleDevice.RequestId");
			batchImportVehicleDeviceResponse.Success = _ctx.BooleanValue("BatchImportVehicleDevice.Success");
			batchImportVehicleDeviceResponse.Code = _ctx.StringValue("BatchImportVehicleDevice.Code");
			batchImportVehicleDeviceResponse.ErrorMessage = _ctx.StringValue("BatchImportVehicleDevice.ErrorMessage");

			BatchImportVehicleDeviceResponse.BatchImportVehicleDevice_Data data = new BatchImportVehicleDeviceResponse.BatchImportVehicleDevice_Data();
			data.ApplyId = _ctx.LongValue("BatchImportVehicleDevice.Data.ApplyId");

			List<string> data_invalidManufacturerList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportVehicleDevice.Data.InvalidManufacturerList.Length"); i++) {
				data_invalidManufacturerList.Add(_ctx.StringValue("BatchImportVehicleDevice.Data.InvalidManufacturerList["+ i +"]"));
			}
			data.InvalidManufacturerList = data_invalidManufacturerList;

			List<string> data_invalidDeviceModelList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportVehicleDevice.Data.InvalidDeviceModelList.Length"); i++) {
				data_invalidDeviceModelList.Add(_ctx.StringValue("BatchImportVehicleDevice.Data.InvalidDeviceModelList["+ i +"]"));
			}
			data.InvalidDeviceModelList = data_invalidDeviceModelList;

			List<string> data_invalidDeviceIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportVehicleDevice.Data.InvalidDeviceIdList.Length"); i++) {
				data_invalidDeviceIdList.Add(_ctx.StringValue("BatchImportVehicleDevice.Data.InvalidDeviceIdList["+ i +"]"));
			}
			data.InvalidDeviceIdList = data_invalidDeviceIdList;

			List<string> data_repeatedDeviceIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportVehicleDevice.Data.RepeatedDeviceIdList.Length"); i++) {
				data_repeatedDeviceIdList.Add(_ctx.StringValue("BatchImportVehicleDevice.Data.RepeatedDeviceIdList["+ i +"]"));
			}
			data.RepeatedDeviceIdList = data_repeatedDeviceIdList;

			List<string> data_invalidDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportVehicleDevice.Data.InvalidDeviceNameList.Length"); i++) {
				data_invalidDeviceNameList.Add(_ctx.StringValue("BatchImportVehicleDevice.Data.InvalidDeviceNameList["+ i +"]"));
			}
			data.InvalidDeviceNameList = data_invalidDeviceNameList;

			List<string> data_repeatedDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportVehicleDevice.Data.RepeatedDeviceNameList.Length"); i++) {
				data_repeatedDeviceNameList.Add(_ctx.StringValue("BatchImportVehicleDevice.Data.RepeatedDeviceNameList["+ i +"]"));
			}
			data.RepeatedDeviceNameList = data_repeatedDeviceNameList;

			List<BatchImportVehicleDeviceResponse.BatchImportVehicleDevice_Data.BatchImportVehicleDevice_InvalidDetailListItem> data_invalidDetailList = new List<BatchImportVehicleDeviceResponse.BatchImportVehicleDevice_Data.BatchImportVehicleDevice_InvalidDetailListItem>();
			for (int i = 0; i < _ctx.Length("BatchImportVehicleDevice.Data.InvalidDetailList.Length"); i++) {
				BatchImportVehicleDeviceResponse.BatchImportVehicleDevice_Data.BatchImportVehicleDevice_InvalidDetailListItem invalidDetailListItem = new BatchImportVehicleDeviceResponse.BatchImportVehicleDevice_Data.BatchImportVehicleDevice_InvalidDetailListItem();
				invalidDetailListItem.Manufacturer = _ctx.StringValue("BatchImportVehicleDevice.Data.InvalidDetailList["+ i +"].Manufacturer");
				invalidDetailListItem.DeviceModel = _ctx.StringValue("BatchImportVehicleDevice.Data.InvalidDetailList["+ i +"].DeviceModel");
				invalidDetailListItem.DeviceId = _ctx.StringValue("BatchImportVehicleDevice.Data.InvalidDetailList["+ i +"].DeviceId");
				invalidDetailListItem.DeviceName = _ctx.StringValue("BatchImportVehicleDevice.Data.InvalidDetailList["+ i +"].DeviceName");
				invalidDetailListItem.ErrorMsg = _ctx.StringValue("BatchImportVehicleDevice.Data.InvalidDetailList["+ i +"].ErrorMsg");

				data_invalidDetailList.Add(invalidDetailListItem);
			}
			data.InvalidDetailList = data_invalidDetailList;
			batchImportVehicleDeviceResponse.Data = data;
        
			return batchImportVehicleDeviceResponse;
        }
    }
}
