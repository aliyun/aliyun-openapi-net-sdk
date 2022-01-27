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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class DescribeDevicesResponseUnmarshaller
    {
        public static DescribeDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDevicesResponse describeDevicesResponse = new DescribeDevicesResponse();

			describeDevicesResponse.HttpResponse = _ctx.HttpResponse;
			describeDevicesResponse.ErrorCode = _ctx.StringValue("DescribeDevices.ErrorCode");
			describeDevicesResponse.ErrorMessage = _ctx.StringValue("DescribeDevices.ErrorMessage");
			describeDevicesResponse.Message = _ctx.StringValue("DescribeDevices.Message");
			describeDevicesResponse.Code = _ctx.StringValue("DescribeDevices.Code");
			describeDevicesResponse.DynamicCode = _ctx.StringValue("DescribeDevices.DynamicCode");
			describeDevicesResponse.RequestId = _ctx.StringValue("DescribeDevices.RequestId");
			describeDevicesResponse.Success = _ctx.BooleanValue("DescribeDevices.Success");
			describeDevicesResponse.DynamicMessage = _ctx.StringValue("DescribeDevices.DynamicMessage");

			List<DescribeDevicesResponse.DescribeDevices_Device> describeDevicesResponse_devices = new List<DescribeDevicesResponse.DescribeDevices_Device>();
			for (int i = 0; i < _ctx.Length("DescribeDevices.Devices.Length"); i++) {
				DescribeDevicesResponse.DescribeDevices_Device device = new DescribeDevicesResponse.DescribeDevices_Device();
				device.AgentStatus = _ctx.StringValue("DescribeDevices.Devices["+ i +"].AgentStatus");
				device.IpcStatus = _ctx.StringValue("DescribeDevices.Devices["+ i +"].IpcStatus");
				device.AgentIp = _ctx.StringValue("DescribeDevices.Devices["+ i +"].AgentIp");
				device.IpcIp = _ctx.StringValue("DescribeDevices.Devices["+ i +"].IpcIp");
				device.AgentReceiveTime = _ctx.LongValue("DescribeDevices.Devices["+ i +"].AgentReceiveTime");
				device.IpcId = _ctx.LongValue("DescribeDevices.Devices["+ i +"].IpcId");
				device.AgentMac = _ctx.StringValue("DescribeDevices.Devices["+ i +"].AgentMac");
				device.IpcName = _ctx.StringValue("DescribeDevices.Devices["+ i +"].IpcName");
				device.IpcReceiveTime = _ctx.LongValue("DescribeDevices.Devices["+ i +"].IpcReceiveTime");

				describeDevicesResponse_devices.Add(device);
			}
			describeDevicesResponse.Devices = describeDevicesResponse_devices;
        
			return describeDevicesResponse;
        }
    }
}
