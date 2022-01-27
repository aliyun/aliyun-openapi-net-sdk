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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class BatchCreateDeviceResponseUnmarshaller
    {
        public static BatchCreateDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchCreateDeviceResponse batchCreateDeviceResponse = new BatchCreateDeviceResponse();

			batchCreateDeviceResponse.HttpResponse = _ctx.HttpResponse;
			batchCreateDeviceResponse.ErrorCode = _ctx.IntegerValue("BatchCreateDevice.ErrorCode");
			batchCreateDeviceResponse.Message = _ctx.StringValue("BatchCreateDevice.Message");
			batchCreateDeviceResponse.Success = _ctx.BooleanValue("BatchCreateDevice.Success");
			batchCreateDeviceResponse.RequestId = _ctx.StringValue("BatchCreateDevice.RequestId");

			List<BatchCreateDeviceResponse.BatchCreateDevice_Data> batchCreateDeviceResponse_devices = new List<BatchCreateDeviceResponse.BatchCreateDevice_Data>();
			for (int i = 0; i < _ctx.Length("BatchCreateDevice.Devices.Length"); i++) {
				BatchCreateDeviceResponse.BatchCreateDevice_Data data = new BatchCreateDeviceResponse.BatchCreateDevice_Data();
				data.DeviceErrorCode = _ctx.IntegerValue("BatchCreateDevice.Devices["+ i +"].DeviceErrorCode");
				data.DeviceMessage = _ctx.StringValue("BatchCreateDevice.Devices["+ i +"].DeviceMessage");
				data.SN = _ctx.StringValue("BatchCreateDevice.Devices["+ i +"].SN");
				data.ActiveCode = _ctx.StringValue("BatchCreateDevice.Devices["+ i +"].ActiveCode");

				batchCreateDeviceResponse_devices.Add(data);
			}
			batchCreateDeviceResponse.Devices = batchCreateDeviceResponse_devices;
        
			return batchCreateDeviceResponse;
        }
    }
}
