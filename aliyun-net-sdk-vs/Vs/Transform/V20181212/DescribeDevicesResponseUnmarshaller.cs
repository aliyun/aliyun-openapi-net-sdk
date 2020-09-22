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
    public class DescribeDevicesResponseUnmarshaller
    {
        public static DescribeDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDevicesResponse describeDevicesResponse = new DescribeDevicesResponse();

			describeDevicesResponse.HttpResponse = context.HttpResponse;
			describeDevicesResponse.RequestId = context.StringValue("DescribeDevices.RequestId");
			describeDevicesResponse.PageSize = context.LongValue("DescribeDevices.PageSize");
			describeDevicesResponse.PageNum = context.LongValue("DescribeDevices.PageNum");
			describeDevicesResponse.PageCount = context.LongValue("DescribeDevices.PageCount");
			describeDevicesResponse.TotalCount = context.LongValue("DescribeDevices.TotalCount");

			List<DescribeDevicesResponse.DescribeDevices_Device> describeDevicesResponse_devices = new List<DescribeDevicesResponse.DescribeDevices_Device>();
			for (int i = 0; i < context.Length("DescribeDevices.Devices.Length"); i++) {
				DescribeDevicesResponse.DescribeDevices_Device device = new DescribeDevicesResponse.DescribeDevices_Device();
				device.Id = context.StringValue("DescribeDevices.Devices["+ i +"].Id");
				device.Name = context.StringValue("DescribeDevices.Devices["+ i +"].Name");
				device.Description = context.StringValue("DescribeDevices.Devices["+ i +"].Description");
				device.GroupId = context.StringValue("DescribeDevices.Devices["+ i +"].GroupId");
				device.ParentId = context.StringValue("DescribeDevices.Devices["+ i +"].ParentId");
				device.DirectoryId = context.StringValue("DescribeDevices.Devices["+ i +"].DirectoryId");
				device.Type = context.StringValue("DescribeDevices.Devices["+ i +"].Type");
				device.AutoStart = context.BooleanValue("DescribeDevices.Devices["+ i +"].AutoStart");
				device.Enabled = context.BooleanValue("DescribeDevices.Devices["+ i +"].Enabled");
				device.Protocol = context.StringValue("DescribeDevices.Devices["+ i +"].Protocol");
				device.Status = context.StringValue("DescribeDevices.Devices["+ i +"].Status");
				device.GbId = context.StringValue("DescribeDevices.Devices["+ i +"].GbId");
				device.Ip = context.StringValue("DescribeDevices.Devices["+ i +"].Ip");
				device.Port = context.LongValue("DescribeDevices.Devices["+ i +"].Port");
				device.Url = context.StringValue("DescribeDevices.Devices["+ i +"].Url");
				device.Username = context.StringValue("DescribeDevices.Devices["+ i +"].Username");
				device.Password = context.StringValue("DescribeDevices.Devices["+ i +"].Password");
				device.Vendor = context.StringValue("DescribeDevices.Devices["+ i +"].Vendor");
				device.Dsn = context.StringValue("DescribeDevices.Devices["+ i +"].Dsn");
				device.Longitude = context.StringValue("DescribeDevices.Devices["+ i +"].Longitude");
				device.Latitude = context.StringValue("DescribeDevices.Devices["+ i +"].Latitude");
				device.AutoPos = context.BooleanValue("DescribeDevices.Devices["+ i +"].AutoPos");
				device.AlarmMethod = context.StringValue("DescribeDevices.Devices["+ i +"].AlarmMethod");
				device.PosInterval = context.LongValue("DescribeDevices.Devices["+ i +"].PosInterval");
				device.CreatedTime = context.StringValue("DescribeDevices.Devices["+ i +"].CreatedTime");
				device.RegisteredTime = context.StringValue("DescribeDevices.Devices["+ i +"].RegisteredTime");
				device.ChannelSyncTime = context.StringValue("DescribeDevices.Devices["+ i +"].ChannelSyncTime");
				device._Params = context.StringValue("DescribeDevices.Devices["+ i +"].Params");

				DescribeDevicesResponse.DescribeDevices_Device.DescribeDevices_Stats stats = new DescribeDevicesResponse.DescribeDevices_Device.DescribeDevices_Stats();
				stats.ChannelNum = context.LongValue("DescribeDevices.Devices["+ i +"].Stats.ChannelNum");
				stats.StreamNum = context.LongValue("DescribeDevices.Devices["+ i +"].Stats.StreamNum");
				stats.OnlineNum = context.LongValue("DescribeDevices.Devices["+ i +"].Stats.OnlineNum");
				stats.OfflineNum = context.LongValue("DescribeDevices.Devices["+ i +"].Stats.OfflineNum");
				stats.FailedNum = context.LongValue("DescribeDevices.Devices["+ i +"].Stats.FailedNum");
				device.Stats = stats;

				DescribeDevicesResponse.DescribeDevices_Device.DescribeDevices_Directory directory = new DescribeDevicesResponse.DescribeDevices_Device.DescribeDevices_Directory();
				directory.Id = context.StringValue("DescribeDevices.Devices["+ i +"].Directory.Id");
				directory.Name = context.StringValue("DescribeDevices.Devices["+ i +"].Directory.Name");
				directory.Description = context.StringValue("DescribeDevices.Devices["+ i +"].Directory.Description");
				directory.GroupId = context.StringValue("DescribeDevices.Devices["+ i +"].Directory.GroupId");
				directory.ParentId = context.StringValue("DescribeDevices.Devices["+ i +"].Directory.ParentId");
				directory.CreatedTime = context.StringValue("DescribeDevices.Devices["+ i +"].Directory.CreatedTime");
				device.Directory = directory;

				describeDevicesResponse_devices.Add(device);
			}
			describeDevicesResponse.Devices = describeDevicesResponse_devices;
        
			return describeDevicesResponse;
        }
    }
}
