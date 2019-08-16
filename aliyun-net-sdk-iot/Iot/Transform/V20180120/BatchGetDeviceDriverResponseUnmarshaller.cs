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
    public class BatchGetDeviceDriverResponseUnmarshaller
    {
        public static BatchGetDeviceDriverResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetDeviceDriverResponse batchGetDeviceDriverResponse = new BatchGetDeviceDriverResponse();

			batchGetDeviceDriverResponse.HttpResponse = context.HttpResponse;
			batchGetDeviceDriverResponse.RequestId = context.StringValue("BatchGetDeviceDriver.RequestId");
			batchGetDeviceDriverResponse.Success = context.BooleanValue("BatchGetDeviceDriver.Success");
			batchGetDeviceDriverResponse.Code = context.StringValue("BatchGetDeviceDriver.Code");
			batchGetDeviceDriverResponse.ErrorMessage = context.StringValue("BatchGetDeviceDriver.ErrorMessage");

			List<BatchGetDeviceDriverResponse.BatchGetDeviceDriver_DeviceDriver> batchGetDeviceDriverResponse_deviceDriverList = new List<BatchGetDeviceDriverResponse.BatchGetDeviceDriver_DeviceDriver>();
			for (int i = 0; i < context.Length("BatchGetDeviceDriver.DeviceDriverList.Length"); i++) {
				BatchGetDeviceDriverResponse.BatchGetDeviceDriver_DeviceDriver deviceDriver = new BatchGetDeviceDriverResponse.BatchGetDeviceDriver_DeviceDriver();
				deviceDriver.DriverId = context.StringValue("BatchGetDeviceDriver.DeviceDriverList["+ i +"].DriverId");
				deviceDriver.IotId = context.StringValue("BatchGetDeviceDriver.DeviceDriverList["+ i +"].IotId");

				batchGetDeviceDriverResponse_deviceDriverList.Add(deviceDriver);
			}
			batchGetDeviceDriverResponse.DeviceDriverList = batchGetDeviceDriverResponse_deviceDriverList;
        
			return batchGetDeviceDriverResponse;
        }
    }
}
