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
    public class ListDeviceChannelsResponseUnmarshaller
    {
        public static ListDeviceChannelsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceChannelsResponse listDeviceChannelsResponse = new ListDeviceChannelsResponse();

			listDeviceChannelsResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceChannelsResponse.RequestId = _ctx.StringValue("ListDeviceChannels.RequestId");
			listDeviceChannelsResponse.PageSize = _ctx.LongValue("ListDeviceChannels.PageSize");
			listDeviceChannelsResponse.PageNum = _ctx.LongValue("ListDeviceChannels.PageNum");
			listDeviceChannelsResponse.PageCount = _ctx.LongValue("ListDeviceChannels.PageCount");
			listDeviceChannelsResponse.TotalCount = _ctx.LongValue("ListDeviceChannels.TotalCount");

			List<ListDeviceChannelsResponse.ListDeviceChannels_Channel> listDeviceChannelsResponse_channels = new List<ListDeviceChannelsResponse.ListDeviceChannels_Channel>();
			for (int i = 0; i < _ctx.Length("ListDeviceChannels.Channels.Length"); i++) {
				ListDeviceChannelsResponse.ListDeviceChannels_Channel channel = new ListDeviceChannelsResponse.ListDeviceChannels_Channel();
				channel.Name = _ctx.StringValue("ListDeviceChannels.Channels["+ i +"].Name");
				channel.DeviceId = _ctx.StringValue("ListDeviceChannels.Channels["+ i +"].DeviceId");
				channel.DeviceStatus = _ctx.StringValue("ListDeviceChannels.Channels["+ i +"].DeviceStatus");
				channel.ChannelId = _ctx.LongValue("ListDeviceChannels.Channels["+ i +"].ChannelId");
				channel._Params = _ctx.StringValue("ListDeviceChannels.Channels["+ i +"].Params");

				listDeviceChannelsResponse_channels.Add(channel);
			}
			listDeviceChannelsResponse.Channels = listDeviceChannelsResponse_channels;
        
			return listDeviceChannelsResponse;
        }
    }
}
