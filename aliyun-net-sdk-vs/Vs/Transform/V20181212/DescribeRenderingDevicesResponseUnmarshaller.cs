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
    public class DescribeRenderingDevicesResponseUnmarshaller
    {
        public static DescribeRenderingDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRenderingDevicesResponse describeRenderingDevicesResponse = new DescribeRenderingDevicesResponse();

			describeRenderingDevicesResponse.HttpResponse = _ctx.HttpResponse;
			describeRenderingDevicesResponse.RequestId = _ctx.StringValue("DescribeRenderingDevices.RequestId");
			describeRenderingDevicesResponse.Total = _ctx.LongValue("DescribeRenderingDevices.Total");

			List<DescribeRenderingDevicesResponse.DescribeRenderingDevices_Device> describeRenderingDevicesResponse_devices = new List<DescribeRenderingDevicesResponse.DescribeRenderingDevices_Device>();
			for (int i = 0; i < _ctx.Length("DescribeRenderingDevices.Devices.Length"); i++) {
				DescribeRenderingDevicesResponse.DescribeRenderingDevices_Device device = new DescribeRenderingDevicesResponse.DescribeRenderingDevices_Device();
				device.InstanceId = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].InstanceId");
				device.ClusterId = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].ClusterId");
				device.EdgeNodeName = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].EdgeNodeName");
				device.PlatformType = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].PlatformType");
				device.Specification = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].Specification");
				device.Status = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].Status");
				device.MacAddress = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].MacAddress");
				device.ServerName = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].ServerName");
				device.InstanceChargeType = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].InstanceChargeType");
				device.AutoRenew = _ctx.BooleanValue("DescribeRenderingDevices.Devices["+ i +"].AutoRenew");
				device.AutoRenewPeriod = _ctx.IntegerValue("DescribeRenderingDevices.Devices["+ i +"].AutoRenewPeriod");
				device.Period = _ctx.IntegerValue("DescribeRenderingDevices.Devices["+ i +"].Period");
				device.PeriodUnit = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].PeriodUnit");

				List<DescribeRenderingDevicesResponse.DescribeRenderingDevices_Device.DescribeRenderingDevices_IpInfo> device_ipInfos = new List<DescribeRenderingDevicesResponse.DescribeRenderingDevices_Device.DescribeRenderingDevices_IpInfo>();
				for (int j = 0; j < _ctx.Length("DescribeRenderingDevices.Devices["+ i +"].IpInfos.Length"); j++) {
					DescribeRenderingDevicesResponse.DescribeRenderingDevices_Device.DescribeRenderingDevices_IpInfo ipInfo = new DescribeRenderingDevicesResponse.DescribeRenderingDevices_Device.DescribeRenderingDevices_IpInfo();
					ipInfo.NatType = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].IpInfos["+ j +"].NatType");
					ipInfo.ExternalIp = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].IpInfos["+ j +"].ExternalIp");
					ipInfo.ExternalPort = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].IpInfos["+ j +"].ExternalPort");
					ipInfo.InternalIp = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].IpInfos["+ j +"].InternalIp");
					ipInfo.InternalPort = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].IpInfos["+ j +"].InternalPort");
					ipInfo.IpProtocol = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].IpInfos["+ j +"].IpProtocol");
					ipInfo.ISP = _ctx.StringValue("DescribeRenderingDevices.Devices["+ i +"].IpInfos["+ j +"].ISP");

					device_ipInfos.Add(ipInfo);
				}
				device.IpInfos = device_ipInfos;

				describeRenderingDevicesResponse_devices.Add(device);
			}
			describeRenderingDevicesResponse.Devices = describeRenderingDevicesResponse_devices;
        
			return describeRenderingDevicesResponse;
        }
    }
}
