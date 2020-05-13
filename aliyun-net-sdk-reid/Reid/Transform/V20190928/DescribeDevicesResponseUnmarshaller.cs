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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class DescribeDevicesResponseUnmarshaller
    {
        public static DescribeDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDevicesResponse describeDevicesResponse = new DescribeDevicesResponse();

			describeDevicesResponse.HttpResponse = context.HttpResponse;
			describeDevicesResponse.ErrorCode = context.StringValue("DescribeDevices.ErrorCode");
			describeDevicesResponse.ErrorMessage = context.StringValue("DescribeDevices.ErrorMessage");
			describeDevicesResponse.Message = context.StringValue("DescribeDevices.Message");
			describeDevicesResponse.Code = context.StringValue("DescribeDevices.Code");
			describeDevicesResponse.DynamicCode = context.StringValue("DescribeDevices.DynamicCode");
			describeDevicesResponse.RequestId = context.StringValue("DescribeDevices.RequestId");
			describeDevicesResponse.Success = context.BooleanValue("DescribeDevices.Success");
			describeDevicesResponse.DynamicMessage = context.StringValue("DescribeDevices.DynamicMessage");

			List<DescribeDevicesResponse.DescribeDevices_Device> describeDevicesResponse_devices = new List<DescribeDevicesResponse.DescribeDevices_Device>();
			for (int i = 0; i < context.Length("DescribeDevices.Devices.Length"); i++) {
				DescribeDevicesResponse.DescribeDevices_Device device = new DescribeDevicesResponse.DescribeDevices_Device();
				device.AgentStatus = context.StringValue("DescribeDevices.Devices["+ i +"].AgentStatus");
				device.IpcStatus = context.StringValue("DescribeDevices.Devices["+ i +"].IpcStatus");
				device.AgentIp = context.StringValue("DescribeDevices.Devices["+ i +"].AgentIp");
				device.IpcIp = context.StringValue("DescribeDevices.Devices["+ i +"].IpcIp");
				device.AgentReceiveTime = context.LongValue("DescribeDevices.Devices["+ i +"].AgentReceiveTime");
				device.AgentMac = context.StringValue("DescribeDevices.Devices["+ i +"].AgentMac");
				device.IpcReceiveTime = context.LongValue("DescribeDevices.Devices["+ i +"].IpcReceiveTime");
				device.IpcId = context.LongValue("DescribeDevices.Devices["+ i +"].IpcId");
				device.IpcName = context.StringValue("DescribeDevices.Devices["+ i +"].IpcName");

				describeDevicesResponse_devices.Add(device);
			}
			describeDevicesResponse.Devices = describeDevicesResponse_devices;
        
			return describeDevicesResponse;
        }
    }
}
