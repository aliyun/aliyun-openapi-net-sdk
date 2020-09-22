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
        public static DescribeDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDeviceResponse describeDeviceResponse = new DescribeDeviceResponse();

			describeDeviceResponse.HttpResponse = context.HttpResponse;
			describeDeviceResponse.RequestId = context.StringValue("DescribeDevice.RequestId");
			describeDeviceResponse.Id = context.StringValue("DescribeDevice.Id");
			describeDeviceResponse.Name = context.StringValue("DescribeDevice.Name");
			describeDeviceResponse.Description = context.StringValue("DescribeDevice.Description");
			describeDeviceResponse.GroupId = context.StringValue("DescribeDevice.GroupId");
			describeDeviceResponse.ParentId = context.StringValue("DescribeDevice.ParentId");
			describeDeviceResponse.DirectoryId = context.StringValue("DescribeDevice.DirectoryId");
			describeDeviceResponse.Type = context.StringValue("DescribeDevice.Type");
			describeDeviceResponse.AutoStart = context.BooleanValue("DescribeDevice.AutoStart");
			describeDeviceResponse.Enabled = context.BooleanValue("DescribeDevice.Enabled");
			describeDeviceResponse.Protocol = context.StringValue("DescribeDevice.Protocol");
			describeDeviceResponse.Status = context.StringValue("DescribeDevice.Status");
			describeDeviceResponse.GbId = context.StringValue("DescribeDevice.GbId");
			describeDeviceResponse.Ip = context.StringValue("DescribeDevice.Ip");
			describeDeviceResponse.Port = context.LongValue("DescribeDevice.Port");
			describeDeviceResponse.Url = context.StringValue("DescribeDevice.Url");
			describeDeviceResponse.Username = context.StringValue("DescribeDevice.Username");
			describeDeviceResponse.Password = context.StringValue("DescribeDevice.Password");
			describeDeviceResponse.Vendor = context.StringValue("DescribeDevice.Vendor");
			describeDeviceResponse.Dsn = context.StringValue("DescribeDevice.Dsn");
			describeDeviceResponse.Longitude = context.StringValue("DescribeDevice.Longitude");
			describeDeviceResponse.Latitude = context.StringValue("DescribeDevice.Latitude");
			describeDeviceResponse.AutoPos = context.BooleanValue("DescribeDevice.AutoPos");
			describeDeviceResponse.PosInterval = context.LongValue("DescribeDevice.PosInterval");
			describeDeviceResponse.AlarmMethod = context.StringValue("DescribeDevice.AlarmMethod");
			describeDeviceResponse.CreatedTime = context.StringValue("DescribeDevice.CreatedTime");
			describeDeviceResponse.RegisteredTime = context.StringValue("DescribeDevice.RegisteredTime");
			describeDeviceResponse.ChannelSyncTime = context.StringValue("DescribeDevice.ChannelSyncTime");
			describeDeviceResponse._Params = context.StringValue("DescribeDevice.Params");

			DescribeDeviceResponse.DescribeDevice_Stats stats = new DescribeDeviceResponse.DescribeDevice_Stats();
			stats.ChannelNum = context.LongValue("DescribeDevice.Stats.ChannelNum");
			stats.StreamNum = context.LongValue("DescribeDevice.Stats.StreamNum");
			stats.OnlineNum = context.LongValue("DescribeDevice.Stats.OnlineNum");
			stats.OfflineNum = context.LongValue("DescribeDevice.Stats.OfflineNum");
			stats.FailedNum = context.LongValue("DescribeDevice.Stats.FailedNum");
			describeDeviceResponse.Stats = stats;

			DescribeDeviceResponse.DescribeDevice_Directory directory = new DescribeDeviceResponse.DescribeDevice_Directory();
			directory.Id = context.StringValue("DescribeDevice.Directory.Id");
			directory.Name = context.StringValue("DescribeDevice.Directory.Name");
			directory.Description = context.StringValue("DescribeDevice.Directory.Description");
			directory.GroupId = context.StringValue("DescribeDevice.Directory.GroupId");
			directory.ParentId = context.StringValue("DescribeDevice.Directory.ParentId");
			directory.CreatedTime = context.StringValue("DescribeDevice.Directory.CreatedTime");
			describeDeviceResponse.Directory = directory;
        
			return describeDeviceResponse;
        }
    }
}
