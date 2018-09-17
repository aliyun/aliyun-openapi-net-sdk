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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterChannelsResponseUnmarshaller
    {
        public static DescribeCasterChannelsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCasterChannelsResponse describeCasterChannelsResponse = new DescribeCasterChannelsResponse();

			describeCasterChannelsResponse.HttpResponse = context.HttpResponse;
			describeCasterChannelsResponse.RequestId = context.StringValue("DescribeCasterChannels.RequestId");
			describeCasterChannelsResponse.Total = context.IntegerValue("DescribeCasterChannels.Total");

			List<DescribeCasterChannelsResponse.DescribeCasterChannels_Channel> describeCasterChannelsResponse_channels = new List<DescribeCasterChannelsResponse.DescribeCasterChannels_Channel>();
			for (int i = 0; i < context.Length("DescribeCasterChannels.Channels.Length"); i++) {
				DescribeCasterChannelsResponse.DescribeCasterChannels_Channel channel = new DescribeCasterChannelsResponse.DescribeCasterChannels_Channel();
				channel.ChannelId = context.StringValue("DescribeCasterChannels.Channels["+ i +"].ChannelId");
				channel.ResourceId = context.StringValue("DescribeCasterChannels.Channels["+ i +"].ResourceId");
				channel.StreamUrl = context.StringValue("DescribeCasterChannels.Channels["+ i +"].StreamUrl");

				describeCasterChannelsResponse_channels.Add(channel);
			}
			describeCasterChannelsResponse.Channels = describeCasterChannelsResponse_channels;
        
			return describeCasterChannelsResponse;
        }
    }
}