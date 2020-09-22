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
        public static DescribeDeviceChannelsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDeviceChannelsResponse describeDeviceChannelsResponse = new DescribeDeviceChannelsResponse();

			describeDeviceChannelsResponse.HttpResponse = context.HttpResponse;
			describeDeviceChannelsResponse.RequestId = context.StringValue("DescribeDeviceChannels.RequestId");
			describeDeviceChannelsResponse.PageSize = context.LongValue("DescribeDeviceChannels.PageSize");
			describeDeviceChannelsResponse.PageNum = context.LongValue("DescribeDeviceChannels.PageNum");
			describeDeviceChannelsResponse.PageCount = context.LongValue("DescribeDeviceChannels.PageCount");
			describeDeviceChannelsResponse.TotalCount = context.LongValue("DescribeDeviceChannels.TotalCount");

			List<DescribeDeviceChannelsResponse.DescribeDeviceChannels_Channel> describeDeviceChannelsResponse_channels = new List<DescribeDeviceChannelsResponse.DescribeDeviceChannels_Channel>();
			for (int i = 0; i < context.Length("DescribeDeviceChannels.Channels.Length"); i++) {
				DescribeDeviceChannelsResponse.DescribeDeviceChannels_Channel channel = new DescribeDeviceChannelsResponse.DescribeDeviceChannels_Channel();
				channel.Name = context.StringValue("DescribeDeviceChannels.Channels["+ i +"].Name");
				channel.GbId = context.StringValue("DescribeDeviceChannels.Channels["+ i +"].GbId");
				channel.StreamId = context.StringValue("DescribeDeviceChannels.Channels["+ i +"].StreamId");
				channel.StreamStatus = context.StringValue("DescribeDeviceChannels.Channels["+ i +"].StreamStatus");
				channel.DeviceId = context.StringValue("DescribeDeviceChannels.Channels["+ i +"].DeviceId");
				channel.DeviceStatus = context.StringValue("DescribeDeviceChannels.Channels["+ i +"].DeviceStatus");
				channel.ChannelId = context.LongValue("DescribeDeviceChannels.Channels["+ i +"].ChannelId");
				channel._Params = context.StringValue("DescribeDeviceChannels.Channels["+ i +"].Params");

				describeDeviceChannelsResponse_channels.Add(channel);
			}
			describeDeviceChannelsResponse.Channels = describeDeviceChannelsResponse_channels;
        
			return describeDeviceChannelsResponse;
        }
    }
}
