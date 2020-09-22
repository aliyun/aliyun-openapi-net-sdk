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
    public class DescribeParentPlatformDevicesResponseUnmarshaller
    {
        public static DescribeParentPlatformDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeParentPlatformDevicesResponse describeParentPlatformDevicesResponse = new DescribeParentPlatformDevicesResponse();

			describeParentPlatformDevicesResponse.HttpResponse = context.HttpResponse;
			describeParentPlatformDevicesResponse.RequestId = context.StringValue("DescribeParentPlatformDevices.RequestId");
			describeParentPlatformDevicesResponse.PageSize = context.LongValue("DescribeParentPlatformDevices.PageSize");
			describeParentPlatformDevicesResponse.PageNum = context.LongValue("DescribeParentPlatformDevices.PageNum");
			describeParentPlatformDevicesResponse.PageCount = context.LongValue("DescribeParentPlatformDevices.PageCount");
			describeParentPlatformDevicesResponse.TotalCount = context.LongValue("DescribeParentPlatformDevices.TotalCount");

			List<DescribeParentPlatformDevicesResponse.DescribeParentPlatformDevices_Device> describeParentPlatformDevicesResponse_devices = new List<DescribeParentPlatformDevicesResponse.DescribeParentPlatformDevices_Device>();
			for (int i = 0; i < context.Length("DescribeParentPlatformDevices.Devices.Length"); i++) {
				DescribeParentPlatformDevicesResponse.DescribeParentPlatformDevices_Device device = new DescribeParentPlatformDevicesResponse.DescribeParentPlatformDevices_Device();
				device.Id = context.StringValue("DescribeParentPlatformDevices.Devices["+ i +"].Id");
				device.Name = context.StringValue("DescribeParentPlatformDevices.Devices["+ i +"].Name");
				device.GbId = context.StringValue("DescribeParentPlatformDevices.Devices["+ i +"].GbId");
				device.GroupId = context.StringValue("DescribeParentPlatformDevices.Devices["+ i +"].GroupId");
				device.ParentId = context.StringValue("DescribeParentPlatformDevices.Devices["+ i +"].ParentId");

				describeParentPlatformDevicesResponse_devices.Add(device);
			}
			describeParentPlatformDevicesResponse.Devices = describeParentPlatformDevicesResponse_devices;
        
			return describeParentPlatformDevicesResponse;
        }
    }
}
