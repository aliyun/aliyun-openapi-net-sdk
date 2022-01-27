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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryEdgeInstanceChannelResponseUnmarshaller
    {
        public static QueryEdgeInstanceChannelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEdgeInstanceChannelResponse queryEdgeInstanceChannelResponse = new QueryEdgeInstanceChannelResponse();

			queryEdgeInstanceChannelResponse.HttpResponse = _ctx.HttpResponse;
			queryEdgeInstanceChannelResponse.RequestId = _ctx.StringValue("QueryEdgeInstanceChannel.RequestId");
			queryEdgeInstanceChannelResponse.Success = _ctx.BooleanValue("QueryEdgeInstanceChannel.Success");
			queryEdgeInstanceChannelResponse.Code = _ctx.StringValue("QueryEdgeInstanceChannel.Code");
			queryEdgeInstanceChannelResponse.ErrorMessage = _ctx.StringValue("QueryEdgeInstanceChannel.ErrorMessage");

			QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data data = new QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data();
			data.Total = _ctx.IntegerValue("QueryEdgeInstanceChannel.Data.Total");
			data.PageSize = _ctx.IntegerValue("QueryEdgeInstanceChannel.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QueryEdgeInstanceChannel.Data.CurrentPage");

			List<QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel> data_channelList = new List<QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel>();
			for (int i = 0; i < _ctx.Length("QueryEdgeInstanceChannel.Data.ChannelList.Length"); i++) {
				QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel channel = new QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel();
				channel.ChannelId = _ctx.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ChannelId");
				channel.ChannelName = _ctx.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ChannelName");
				channel.GmtCreate = _ctx.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].GmtCreate");
				channel.GmtModified = _ctx.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].GmtModified");
				channel.GmtCreateTimestamp = _ctx.LongValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].GmtCreateTimestamp");
				channel.GmtModifiedTimestamp = _ctx.LongValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].GmtModifiedTimestamp");

				List<QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel.QueryEdgeInstanceChannel_Config> channel_configList = new List<QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel.QueryEdgeInstanceChannel_Config>();
				for (int j = 0; j < _ctx.Length("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList.Length"); j++) {
					QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel.QueryEdgeInstanceChannel_Config config = new QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel.QueryEdgeInstanceChannel_Config();
					config.ConfigId = _ctx.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList["+ j +"].ConfigId");
					config.Format = _ctx.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList["+ j +"].Format");
					config.Content = _ctx.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList["+ j +"].Content");
					config.Key = _ctx.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList["+ j +"].Key");

					channel_configList.Add(config);
				}
				channel.ConfigList = channel_configList;

				data_channelList.Add(channel);
			}
			data.ChannelList = data_channelList;
			queryEdgeInstanceChannelResponse.Data = data;
        
			return queryEdgeInstanceChannelResponse;
        }
    }
}
