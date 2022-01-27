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
    public class DescribeDeviceResponseUnmarshaller
    {
        public static DescribeDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDeviceResponse describeDeviceResponse = new DescribeDeviceResponse();

			describeDeviceResponse.HttpResponse = _ctx.HttpResponse;
			describeDeviceResponse.RequestId = _ctx.StringValue("DescribeDevice.RequestId");
			describeDeviceResponse.Id = _ctx.StringValue("DescribeDevice.Id");
			describeDeviceResponse.Name = _ctx.StringValue("DescribeDevice.Name");
			describeDeviceResponse.Description = _ctx.StringValue("DescribeDevice.Description");
			describeDeviceResponse.GroupId = _ctx.StringValue("DescribeDevice.GroupId");
			describeDeviceResponse.ParentId = _ctx.StringValue("DescribeDevice.ParentId");
			describeDeviceResponse.DirectoryId = _ctx.StringValue("DescribeDevice.DirectoryId");
			describeDeviceResponse.Type = _ctx.StringValue("DescribeDevice.Type");
			describeDeviceResponse.AutoStart = _ctx.BooleanValue("DescribeDevice.AutoStart");
			describeDeviceResponse.Enabled = _ctx.BooleanValue("DescribeDevice.Enabled");
			describeDeviceResponse.Protocol = _ctx.StringValue("DescribeDevice.Protocol");
			describeDeviceResponse.Status = _ctx.StringValue("DescribeDevice.Status");
			describeDeviceResponse.GbId = _ctx.StringValue("DescribeDevice.GbId");
			describeDeviceResponse.Ip = _ctx.StringValue("DescribeDevice.Ip");
			describeDeviceResponse.Port = _ctx.LongValue("DescribeDevice.Port");
			describeDeviceResponse.Url = _ctx.StringValue("DescribeDevice.Url");
			describeDeviceResponse.Username = _ctx.StringValue("DescribeDevice.Username");
			describeDeviceResponse.Password = _ctx.StringValue("DescribeDevice.Password");
			describeDeviceResponse.Vendor = _ctx.StringValue("DescribeDevice.Vendor");
			describeDeviceResponse.Dsn = _ctx.StringValue("DescribeDevice.Dsn");
			describeDeviceResponse.Longitude = _ctx.StringValue("DescribeDevice.Longitude");
			describeDeviceResponse.Latitude = _ctx.StringValue("DescribeDevice.Latitude");
			describeDeviceResponse.AutoPos = _ctx.BooleanValue("DescribeDevice.AutoPos");
			describeDeviceResponse.PosInterval = _ctx.LongValue("DescribeDevice.PosInterval");
			describeDeviceResponse.AlarmMethod = _ctx.StringValue("DescribeDevice.AlarmMethod");
			describeDeviceResponse.CreatedTime = _ctx.StringValue("DescribeDevice.CreatedTime");
			describeDeviceResponse.RegisteredTime = _ctx.StringValue("DescribeDevice.RegisteredTime");
			describeDeviceResponse.ChannelSyncTime = _ctx.StringValue("DescribeDevice.ChannelSyncTime");
			describeDeviceResponse._Params = _ctx.StringValue("DescribeDevice.Params");

			DescribeDeviceResponse.DescribeDevice_Stats stats = new DescribeDeviceResponse.DescribeDevice_Stats();
			stats.ChannelNum = _ctx.LongValue("DescribeDevice.Stats.ChannelNum");
			stats.StreamNum = _ctx.LongValue("DescribeDevice.Stats.StreamNum");
			stats.OnlineNum = _ctx.LongValue("DescribeDevice.Stats.OnlineNum");
			stats.OfflineNum = _ctx.LongValue("DescribeDevice.Stats.OfflineNum");
			stats.FailedNum = _ctx.LongValue("DescribeDevice.Stats.FailedNum");
			describeDeviceResponse.Stats = stats;

			DescribeDeviceResponse.DescribeDevice_Directory directory = new DescribeDeviceResponse.DescribeDevice_Directory();
			directory.Id = _ctx.StringValue("DescribeDevice.Directory.Id");
			directory.Name = _ctx.StringValue("DescribeDevice.Directory.Name");
			directory.Description = _ctx.StringValue("DescribeDevice.Directory.Description");
			directory.GroupId = _ctx.StringValue("DescribeDevice.Directory.GroupId");
			directory.ParentId = _ctx.StringValue("DescribeDevice.Directory.ParentId");
			directory.CreatedTime = _ctx.StringValue("DescribeDevice.Directory.CreatedTime");
			describeDeviceResponse.Directory = directory;
        
			return describeDeviceResponse;
        }
    }
}
