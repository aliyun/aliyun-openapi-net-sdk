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
    public class DescribeDeviceChannelsResponseUnmarshaller
    {
        public static DescribeDeviceChannelsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDeviceChannelsResponse describeDeviceChannelsResponse = new DescribeDeviceChannelsResponse();

			describeDeviceChannelsResponse.HttpResponse = _ctx.HttpResponse;
			describeDeviceChannelsResponse.RequestId = _ctx.StringValue("DescribeDeviceChannels.RequestId");
			describeDeviceChannelsResponse.PageSize = _ctx.LongValue("DescribeDeviceChannels.PageSize");
			describeDeviceChannelsResponse.PageNum = _ctx.LongValue("DescribeDeviceChannels.PageNum");
			describeDeviceChannelsResponse.PageCount = _ctx.LongValue("DescribeDeviceChannels.PageCount");
			describeDeviceChannelsResponse.TotalCount = _ctx.LongValue("DescribeDeviceChannels.TotalCount");

			List<DescribeDeviceChannelsResponse.DescribeDeviceChannels_Channel> describeDeviceChannelsResponse_channels = new List<DescribeDeviceChannelsResponse.DescribeDeviceChannels_Channel>();
			for (int i = 0; i < _ctx.Length("DescribeDeviceChannels.Channels.Length"); i++) {
				DescribeDeviceChannelsResponse.DescribeDeviceChannels_Channel channel = new DescribeDeviceChannelsResponse.DescribeDeviceChannels_Channel();
				channel.Name = _ctx.StringValue("DescribeDeviceChannels.Channels["+ i +"].Name");
				channel.GbId = _ctx.StringValue("DescribeDeviceChannels.Channels["+ i +"].GbId");
				channel.StreamId = _ctx.StringValue("DescribeDeviceChannels.Channels["+ i +"].StreamId");
				channel.StreamStatus = _ctx.StringValue("DescribeDeviceChannels.Channels["+ i +"].StreamStatus");
				channel.DeviceId = _ctx.StringValue("DescribeDeviceChannels.Channels["+ i +"].DeviceId");
				channel.DeviceStatus = _ctx.StringValue("DescribeDeviceChannels.Channels["+ i +"].DeviceStatus");
				channel.ChannelId = _ctx.LongValue("DescribeDeviceChannels.Channels["+ i +"].ChannelId");
				channel._Params = _ctx.StringValue("DescribeDeviceChannels.Channels["+ i +"].Params");

				describeDeviceChannelsResponse_channels.Add(channel);
			}
			describeDeviceChannelsResponse.Channels = describeDeviceChannelsResponse_channels;
        
			return describeDeviceChannelsResponse;
        }
    }
}
