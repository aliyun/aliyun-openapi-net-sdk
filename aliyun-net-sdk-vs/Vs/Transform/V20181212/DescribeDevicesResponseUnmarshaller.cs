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
        public static DescribeDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDevicesResponse describeDevicesResponse = new DescribeDevicesResponse();

			describeDevicesResponse.HttpResponse = _ctx.HttpResponse;
			describeDevicesResponse.RequestId = _ctx.StringValue("DescribeDevices.RequestId");
			describeDevicesResponse.PageSize = _ctx.LongValue("DescribeDevices.PageSize");
			describeDevicesResponse.PageNum = _ctx.LongValue("DescribeDevices.PageNum");
			describeDevicesResponse.PageCount = _ctx.LongValue("DescribeDevices.PageCount");
			describeDevicesResponse.TotalCount = _ctx.LongValue("DescribeDevices.TotalCount");

			List<DescribeDevicesResponse.DescribeDevices_Device> describeDevicesResponse_devices = new List<DescribeDevicesResponse.DescribeDevices_Device>();
			for (int i = 0; i < _ctx.Length("DescribeDevices.Devices.Length"); i++) {
				DescribeDevicesResponse.DescribeDevices_Device device = new DescribeDevicesResponse.DescribeDevices_Device();
				device.Id = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Id");
				device.Name = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Name");
				device.Description = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Description");
				device.GroupId = _ctx.StringValue("DescribeDevices.Devices["+ i +"].GroupId");
				device.ParentId = _ctx.StringValue("DescribeDevices.Devices["+ i +"].ParentId");
				device.DirectoryId = _ctx.StringValue("DescribeDevices.Devices["+ i +"].DirectoryId");
				device.Type = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Type");
				device.AutoStart = _ctx.BooleanValue("DescribeDevices.Devices["+ i +"].AutoStart");
				device.Enabled = _ctx.BooleanValue("DescribeDevices.Devices["+ i +"].Enabled");
				device.Protocol = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Protocol");
				device.Status = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Status");
				device.GbId = _ctx.StringValue("DescribeDevices.Devices["+ i +"].GbId");
				device.Ip = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Ip");
				device.Port = _ctx.LongValue("DescribeDevices.Devices["+ i +"].Port");
				device.Url = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Url");
				device.Username = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Username");
				device.Password = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Password");
				device.Vendor = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Vendor");
				device.Dsn = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Dsn");
				device.Longitude = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Longitude");
				device.Latitude = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Latitude");
				device.AutoPos = _ctx.BooleanValue("DescribeDevices.Devices["+ i +"].AutoPos");
				device.AlarmMethod = _ctx.StringValue("DescribeDevices.Devices["+ i +"].AlarmMethod");
				device.PosInterval = _ctx.LongValue("DescribeDevices.Devices["+ i +"].PosInterval");
				device.CreatedTime = _ctx.StringValue("DescribeDevices.Devices["+ i +"].CreatedTime");
				device.RegisteredTime = _ctx.StringValue("DescribeDevices.Devices["+ i +"].RegisteredTime");
				device.ChannelSyncTime = _ctx.StringValue("DescribeDevices.Devices["+ i +"].ChannelSyncTime");
				device._Params = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Params");

				DescribeDevicesResponse.DescribeDevices_Device.DescribeDevices_Stats stats = new DescribeDevicesResponse.DescribeDevices_Device.DescribeDevices_Stats();
				stats.ChannelNum = _ctx.LongValue("DescribeDevices.Devices["+ i +"].Stats.ChannelNum");
				stats.StreamNum = _ctx.LongValue("DescribeDevices.Devices["+ i +"].Stats.StreamNum");
				stats.OnlineNum = _ctx.LongValue("DescribeDevices.Devices["+ i +"].Stats.OnlineNum");
				stats.OfflineNum = _ctx.LongValue("DescribeDevices.Devices["+ i +"].Stats.OfflineNum");
				stats.FailedNum = _ctx.LongValue("DescribeDevices.Devices["+ i +"].Stats.FailedNum");
				device.Stats = stats;

				DescribeDevicesResponse.DescribeDevices_Device.DescribeDevices_Directory directory = new DescribeDevicesResponse.DescribeDevices_Device.DescribeDevices_Directory();
				directory.Id = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Directory.Id");
				directory.Name = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Directory.Name");
				directory.Description = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Directory.Description");
				directory.GroupId = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Directory.GroupId");
				directory.ParentId = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Directory.ParentId");
				directory.CreatedTime = _ctx.StringValue("DescribeDevices.Devices["+ i +"].Directory.CreatedTime");
				device.Directory = directory;

				describeDevicesResponse_devices.Add(device);
			}
			describeDevicesResponse.Devices = describeDevicesResponse_devices;
        
			return describeDevicesResponse;
        }
    }
}
