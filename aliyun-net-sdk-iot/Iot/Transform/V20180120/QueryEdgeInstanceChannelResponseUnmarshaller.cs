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
        public static QueryEdgeInstanceChannelResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEdgeInstanceChannelResponse queryEdgeInstanceChannelResponse = new QueryEdgeInstanceChannelResponse();

			queryEdgeInstanceChannelResponse.HttpResponse = context.HttpResponse;
			queryEdgeInstanceChannelResponse.RequestId = context.StringValue("QueryEdgeInstanceChannel.RequestId");
			queryEdgeInstanceChannelResponse.Success = context.BooleanValue("QueryEdgeInstanceChannel.Success");
			queryEdgeInstanceChannelResponse.Code = context.StringValue("QueryEdgeInstanceChannel.Code");
			queryEdgeInstanceChannelResponse.ErrorMessage = context.StringValue("QueryEdgeInstanceChannel.ErrorMessage");

			QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data data = new QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data();
			data.Total = context.IntegerValue("QueryEdgeInstanceChannel.Data.Total");
			data.PageSize = context.IntegerValue("QueryEdgeInstanceChannel.Data.PageSize");
			data.CurrentPage = context.IntegerValue("QueryEdgeInstanceChannel.Data.CurrentPage");

			List<QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel> data_channelList = new List<QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel>();
			for (int i = 0; i < context.Length("QueryEdgeInstanceChannel.Data.ChannelList.Length"); i++) {
				QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel channel = new QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel();
				channel.ChannelId = context.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ChannelId");
				channel.ChannelName = context.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ChannelName");
				channel.GmtCreate = context.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].GmtCreate");
				channel.GmtModified = context.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].GmtModified");
				channel.GmtCreateTimestamp = context.LongValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].GmtCreateTimestamp");
				channel.GmtModifiedTimestamp = context.LongValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].GmtModifiedTimestamp");

				List<QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel.QueryEdgeInstanceChannel_Config> channel_configList = new List<QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel.QueryEdgeInstanceChannel_Config>();
				for (int j = 0; j < context.Length("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList.Length"); j++) {
					QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel.QueryEdgeInstanceChannel_Config config = new QueryEdgeInstanceChannelResponse.QueryEdgeInstanceChannel_Data.QueryEdgeInstanceChannel_Channel.QueryEdgeInstanceChannel_Config();
					config.ConfigId = context.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList["+ j +"].ConfigId");
					config.Format = context.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList["+ j +"].Format");
					config.Content = context.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList["+ j +"].Content");
					config.Key = context.StringValue("QueryEdgeInstanceChannel.Data.ChannelList["+ i +"].ConfigList["+ j +"].Key");

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
