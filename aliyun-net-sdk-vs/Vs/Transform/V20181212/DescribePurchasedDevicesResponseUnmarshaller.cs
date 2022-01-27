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
    public class DescribePurchasedDevicesResponseUnmarshaller
    {
        public static DescribePurchasedDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePurchasedDevicesResponse describePurchasedDevicesResponse = new DescribePurchasedDevicesResponse();

			describePurchasedDevicesResponse.HttpResponse = _ctx.HttpResponse;
			describePurchasedDevicesResponse.RequestId = _ctx.StringValue("DescribePurchasedDevices.RequestId");
			describePurchasedDevicesResponse.PageSize = _ctx.LongValue("DescribePurchasedDevices.PageSize");
			describePurchasedDevicesResponse.PageNum = _ctx.LongValue("DescribePurchasedDevices.PageNum");
			describePurchasedDevicesResponse.PageCount = _ctx.LongValue("DescribePurchasedDevices.PageCount");
			describePurchasedDevicesResponse.TotalCount = _ctx.LongValue("DescribePurchasedDevices.TotalCount");

			List<DescribePurchasedDevicesResponse.DescribePurchasedDevices_Device> describePurchasedDevicesResponse_devices = new List<DescribePurchasedDevicesResponse.DescribePurchasedDevices_Device>();
			for (int i = 0; i < _ctx.Length("DescribePurchasedDevices.Devices.Length"); i++) {
				DescribePurchasedDevicesResponse.DescribePurchasedDevices_Device device = new DescribePurchasedDevicesResponse.DescribePurchasedDevices_Device();
				device.Id = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].Id");
				device.Name = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].Name");
				device.Description = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].Description");
				device.Type = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].Type");
				device.SubType = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].SubType");
				device.RegisterCode = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].RegisterCode");
				device.Vendor = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].Vendor");
				device.OrderId = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].OrderId");
				device.Region = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].Region");
				device.GroupId = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].GroupId");
				device.GroupName = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].GroupName");
				device.CreatedTime = _ctx.StringValue("DescribePurchasedDevices.Devices["+ i +"].CreatedTime");

				describePurchasedDevicesResponse_devices.Add(device);
			}
			describePurchasedDevicesResponse.Devices = describePurchasedDevicesResponse_devices;
        
			return describePurchasedDevicesResponse;
        }
    }
}
