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
    public class BatchGetEdgeInstanceDeviceDriverResponseUnmarshaller
    {
        public static BatchGetEdgeInstanceDeviceDriverResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchGetEdgeInstanceDeviceDriverResponse batchGetEdgeInstanceDeviceDriverResponse = new BatchGetEdgeInstanceDeviceDriverResponse();

			batchGetEdgeInstanceDeviceDriverResponse.HttpResponse = _ctx.HttpResponse;
			batchGetEdgeInstanceDeviceDriverResponse.RequestId = _ctx.StringValue("BatchGetEdgeInstanceDeviceDriver.RequestId");
			batchGetEdgeInstanceDeviceDriverResponse.Success = _ctx.BooleanValue("BatchGetEdgeInstanceDeviceDriver.Success");
			batchGetEdgeInstanceDeviceDriverResponse.Code = _ctx.StringValue("BatchGetEdgeInstanceDeviceDriver.Code");
			batchGetEdgeInstanceDeviceDriverResponse.ErrorMessage = _ctx.StringValue("BatchGetEdgeInstanceDeviceDriver.ErrorMessage");

			List<BatchGetEdgeInstanceDeviceDriverResponse.BatchGetEdgeInstanceDeviceDriver_DeviceDriver> batchGetEdgeInstanceDeviceDriverResponse_deviceDriverList = new List<BatchGetEdgeInstanceDeviceDriverResponse.BatchGetEdgeInstanceDeviceDriver_DeviceDriver>();
			for (int i = 0; i < _ctx.Length("BatchGetEdgeInstanceDeviceDriver.DeviceDriverList.Length"); i++) {
				BatchGetEdgeInstanceDeviceDriverResponse.BatchGetEdgeInstanceDeviceDriver_DeviceDriver deviceDriver = new BatchGetEdgeInstanceDeviceDriverResponse.BatchGetEdgeInstanceDeviceDriver_DeviceDriver();
				deviceDriver.DriverId = _ctx.StringValue("BatchGetEdgeInstanceDeviceDriver.DeviceDriverList["+ i +"].DriverId");
				deviceDriver.IotId = _ctx.StringValue("BatchGetEdgeInstanceDeviceDriver.DeviceDriverList["+ i +"].IotId");

				batchGetEdgeInstanceDeviceDriverResponse_deviceDriverList.Add(deviceDriver);
			}
			batchGetEdgeInstanceDeviceDriverResponse.DeviceDriverList = batchGetEdgeInstanceDeviceDriverResponse_deviceDriverList;
        
			return batchGetEdgeInstanceDeviceDriverResponse;
        }
    }
}
