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
    public class BatchGetDeviceBindStatusResponseUnmarshaller
    {
        public static BatchGetDeviceBindStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchGetDeviceBindStatusResponse batchGetDeviceBindStatusResponse = new BatchGetDeviceBindStatusResponse();

			batchGetDeviceBindStatusResponse.HttpResponse = _ctx.HttpResponse;
			batchGetDeviceBindStatusResponse.RequestId = _ctx.StringValue("BatchGetDeviceBindStatus.RequestId");
			batchGetDeviceBindStatusResponse.Success = _ctx.BooleanValue("BatchGetDeviceBindStatus.Success");
			batchGetDeviceBindStatusResponse.Code = _ctx.StringValue("BatchGetDeviceBindStatus.Code");
			batchGetDeviceBindStatusResponse.ErrorMessage = _ctx.StringValue("BatchGetDeviceBindStatus.ErrorMessage");

			List<BatchGetDeviceBindStatusResponse.BatchGetDeviceBindStatus_DeviceStatus> batchGetDeviceBindStatusResponse_data = new List<BatchGetDeviceBindStatusResponse.BatchGetDeviceBindStatus_DeviceStatus>();
			for (int i = 0; i < _ctx.Length("BatchGetDeviceBindStatus.Data.Length"); i++) {
				BatchGetDeviceBindStatusResponse.BatchGetDeviceBindStatus_DeviceStatus deviceStatus = new BatchGetDeviceBindStatusResponse.BatchGetDeviceBindStatus_DeviceStatus();
				deviceStatus.IotId = _ctx.StringValue("BatchGetDeviceBindStatus.Data["+ i +"].IotId");
				deviceStatus.BindStatus = _ctx.IntegerValue("BatchGetDeviceBindStatus.Data["+ i +"].BindStatus");

				batchGetDeviceBindStatusResponse_data.Add(deviceStatus);
			}
			batchGetDeviceBindStatusResponse.Data = batchGetDeviceBindStatusResponse_data;
        
			return batchGetDeviceBindStatusResponse;
        }
    }
}
