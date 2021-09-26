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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeNodeDevicesInfoResponseUnmarshaller
    {
        public static DescribeNodeDevicesInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNodeDevicesInfoResponse describeNodeDevicesInfoResponse = new DescribeNodeDevicesInfoResponse();

			describeNodeDevicesInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeNodeDevicesInfoResponse.RequestId = _ctx.StringValue("DescribeNodeDevicesInfo.RequestId");

			List<DescribeNodeDevicesInfoResponse.DescribeNodeDevicesInfo_NodeDevice> describeNodeDevicesInfoResponse_nodeDevices = new List<DescribeNodeDevicesInfoResponse.DescribeNodeDevicesInfo_NodeDevice>();
			for (int i = 0; i < _ctx.Length("DescribeNodeDevicesInfo.NodeDevices.Length"); i++) {
				DescribeNodeDevicesInfoResponse.DescribeNodeDevicesInfo_NodeDevice nodeDevice = new DescribeNodeDevicesInfoResponse.DescribeNodeDevicesInfo_NodeDevice();
				nodeDevice.NodeName = _ctx.StringValue("DescribeNodeDevicesInfo.NodeDevices["+ i +"].NodeName");

				List<DescribeNodeDevicesInfoResponse.DescribeNodeDevicesInfo_NodeDevice.DescribeNodeDevicesInfo_DeviceInfo> nodeDevice_deviceInfos = new List<DescribeNodeDevicesInfoResponse.DescribeNodeDevicesInfo_NodeDevice.DescribeNodeDevicesInfo_DeviceInfo>();
				for (int j = 0; j < _ctx.Length("DescribeNodeDevicesInfo.NodeDevices["+ i +"].DeviceInfos.Length"); j++) {
					DescribeNodeDevicesInfoResponse.DescribeNodeDevicesInfo_NodeDevice.DescribeNodeDevicesInfo_DeviceInfo deviceInfo = new DescribeNodeDevicesInfoResponse.DescribeNodeDevicesInfo_NodeDevice.DescribeNodeDevicesInfo_DeviceInfo();
					deviceInfo.InstanceId = _ctx.StringValue("DescribeNodeDevicesInfo.NodeDevices["+ i +"].DeviceInfos["+ j +"].InstanceId");
					deviceInfo.Name = _ctx.StringValue("DescribeNodeDevicesInfo.NodeDevices["+ i +"].DeviceInfos["+ j +"].Name");
					deviceInfo.IP = _ctx.StringValue("DescribeNodeDevicesInfo.NodeDevices["+ i +"].DeviceInfos["+ j +"].IP");
					deviceInfo.Server = _ctx.StringValue("DescribeNodeDevicesInfo.NodeDevices["+ i +"].DeviceInfos["+ j +"].Server");

					nodeDevice_deviceInfos.Add(deviceInfo);
				}
				nodeDevice.DeviceInfos = nodeDevice_deviceInfos;

				describeNodeDevicesInfoResponse_nodeDevices.Add(nodeDevice);
			}
			describeNodeDevicesInfoResponse.NodeDevices = describeNodeDevicesInfoResponse_nodeDevices;
        
			return describeNodeDevicesInfoResponse;
        }
    }
}
