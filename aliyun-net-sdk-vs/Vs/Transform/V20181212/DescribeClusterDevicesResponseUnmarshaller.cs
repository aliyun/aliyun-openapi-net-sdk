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
    public class DescribeClusterDevicesResponseUnmarshaller
    {
        public static DescribeClusterDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterDevicesResponse describeClusterDevicesResponse = new DescribeClusterDevicesResponse();

			describeClusterDevicesResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterDevicesResponse.RequestId = _ctx.StringValue("DescribeClusterDevices.RequestId");
			describeClusterDevicesResponse.Total = _ctx.LongValue("DescribeClusterDevices.Total");

			List<DescribeClusterDevicesResponse.DescribeClusterDevices_Device> describeClusterDevicesResponse_devices = new List<DescribeClusterDevicesResponse.DescribeClusterDevices_Device>();
			for (int i = 0; i < _ctx.Length("DescribeClusterDevices.Devices.Length"); i++) {
				DescribeClusterDevicesResponse.DescribeClusterDevices_Device device = new DescribeClusterDevicesResponse.DescribeClusterDevices_Device();
				device.InstanceId = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].InstanceId");
				device.EdgeNodeName = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].EdgeNodeName");
				device.PlatformType = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].PlatformType");
				device.Status = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].Status");
				device.MacAddress = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].MacAddress");
				device.Server = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].Server");
				device.InstanceChargeType = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].InstanceChargeType");
				device.AutoRenew = _ctx.BooleanValue("DescribeClusterDevices.Devices["+ i +"].AutoRenew");
				device.AutoRenewPeriod = _ctx.IntegerValue("DescribeClusterDevices.Devices["+ i +"].AutoRenewPeriod");
				device.Period = _ctx.IntegerValue("DescribeClusterDevices.Devices["+ i +"].Period");
				device.PeriodUnit = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].PeriodUnit");

				List<DescribeClusterDevicesResponse.DescribeClusterDevices_Device.DescribeClusterDevices_IpInfo> device_ipInfos = new List<DescribeClusterDevicesResponse.DescribeClusterDevices_Device.DescribeClusterDevices_IpInfo>();
				for (int j = 0; j < _ctx.Length("DescribeClusterDevices.Devices["+ i +"].IpInfos.Length"); j++) {
					DescribeClusterDevicesResponse.DescribeClusterDevices_Device.DescribeClusterDevices_IpInfo ipInfo = new DescribeClusterDevicesResponse.DescribeClusterDevices_Device.DescribeClusterDevices_IpInfo();
					ipInfo.NatType = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].IpInfos["+ j +"].NatType");
					ipInfo.ExternalIp = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].IpInfos["+ j +"].ExternalIp");
					ipInfo.ExternalPort = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].IpInfos["+ j +"].ExternalPort");
					ipInfo.InternalIp = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].IpInfos["+ j +"].InternalIp");
					ipInfo.InternalPort = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].IpInfos["+ j +"].InternalPort");
					ipInfo.IpProtocol = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].IpInfos["+ j +"].IpProtocol");
					ipInfo.ISP = _ctx.StringValue("DescribeClusterDevices.Devices["+ i +"].IpInfos["+ j +"].ISP");

					device_ipInfos.Add(ipInfo);
				}
				device.IpInfos = device_ipInfos;

				describeClusterDevicesResponse_devices.Add(device);
			}
			describeClusterDevicesResponse.Devices = describeClusterDevicesResponse_devices;
        
			return describeClusterDevicesResponse;
        }
    }
}
