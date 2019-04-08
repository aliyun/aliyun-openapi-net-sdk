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
    public class BatchGetDeviceStateResponseUnmarshaller
    {
        public static BatchGetDeviceStateResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetDeviceStateResponse batchGetDeviceStateResponse = new BatchGetDeviceStateResponse();

			batchGetDeviceStateResponse.HttpResponse = context.HttpResponse;
			batchGetDeviceStateResponse.RequestId = context.StringValue("BatchGetDeviceState.RequestId");
			batchGetDeviceStateResponse.Success = context.BooleanValue("BatchGetDeviceState.Success");
			batchGetDeviceStateResponse.Code = context.StringValue("BatchGetDeviceState.Code");
			batchGetDeviceStateResponse.ErrorMessage = context.StringValue("BatchGetDeviceState.ErrorMessage");

			List<BatchGetDeviceStateResponse.BatchGetDeviceState_DeviceStatus> batchGetDeviceStateResponse_deviceStatusList = new List<BatchGetDeviceStateResponse.BatchGetDeviceState_DeviceStatus>();
			for (int i = 0; i < context.Length("BatchGetDeviceState.DeviceStatusList.Length"); i++) {
				BatchGetDeviceStateResponse.BatchGetDeviceState_DeviceStatus deviceStatus = new BatchGetDeviceStateResponse.BatchGetDeviceState_DeviceStatus();
				deviceStatus.DeviceId = context.StringValue("BatchGetDeviceState.DeviceStatusList["+ i +"].DeviceId");
				deviceStatus.DeviceName = context.StringValue("BatchGetDeviceState.DeviceStatusList["+ i +"].DeviceName");
				deviceStatus.Status = context.StringValue("BatchGetDeviceState.DeviceStatusList["+ i +"].Status");
				deviceStatus.AsAddress = context.StringValue("BatchGetDeviceState.DeviceStatusList["+ i +"].AsAddress");
				deviceStatus.LastOnlineTime = context.StringValue("BatchGetDeviceState.DeviceStatusList["+ i +"].LastOnlineTime");
				deviceStatus.IotId = context.StringValue("BatchGetDeviceState.DeviceStatusList["+ i +"].IotId");

				batchGetDeviceStateResponse_deviceStatusList.Add(deviceStatus);
			}
			batchGetDeviceStateResponse.DeviceStatusList = batchGetDeviceStateResponse_deviceStatusList;
        
			return batchGetDeviceStateResponse;
        }
    }
}
