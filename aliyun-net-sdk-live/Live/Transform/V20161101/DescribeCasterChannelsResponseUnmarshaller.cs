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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterChannelsResponseUnmarshaller
    {
        public static DescribeCasterChannelsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCasterChannelsResponse describeCasterChannelsResponse = new DescribeCasterChannelsResponse();

			describeCasterChannelsResponse.HttpResponse = _ctx.HttpResponse;
			describeCasterChannelsResponse.RequestId = _ctx.StringValue("DescribeCasterChannels.RequestId");
			describeCasterChannelsResponse.Total = _ctx.IntegerValue("DescribeCasterChannels.Total");

			List<DescribeCasterChannelsResponse.DescribeCasterChannels_Channel> describeCasterChannelsResponse_channels = new List<DescribeCasterChannelsResponse.DescribeCasterChannels_Channel>();
			for (int i = 0; i < _ctx.Length("DescribeCasterChannels.Channels.Length"); i++) {
				DescribeCasterChannelsResponse.DescribeCasterChannels_Channel channel = new DescribeCasterChannelsResponse.DescribeCasterChannels_Channel();
				channel.ChannelId = _ctx.StringValue("DescribeCasterChannels.Channels["+ i +"].ChannelId");
				channel.ResourceId = _ctx.StringValue("DescribeCasterChannels.Channels["+ i +"].ResourceId");
				channel.StreamUrl = _ctx.StringValue("DescribeCasterChannels.Channels["+ i +"].StreamUrl");
				channel.RtmpUrl = _ctx.StringValue("DescribeCasterChannels.Channels["+ i +"].RtmpUrl");

				describeCasterChannelsResponse_channels.Add(channel);
			}
			describeCasterChannelsResponse.Channels = describeCasterChannelsResponse_channels;
        
			return describeCasterChannelsResponse;
        }
    }
}
