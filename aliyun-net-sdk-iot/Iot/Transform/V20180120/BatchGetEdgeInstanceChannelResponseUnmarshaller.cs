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
    public class BatchGetEdgeInstanceChannelResponseUnmarshaller
    {
        public static BatchGetEdgeInstanceChannelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchGetEdgeInstanceChannelResponse batchGetEdgeInstanceChannelResponse = new BatchGetEdgeInstanceChannelResponse();

			batchGetEdgeInstanceChannelResponse.HttpResponse = _ctx.HttpResponse;
			batchGetEdgeInstanceChannelResponse.RequestId = _ctx.StringValue("BatchGetEdgeInstanceChannel.RequestId");
			batchGetEdgeInstanceChannelResponse.Success = _ctx.BooleanValue("BatchGetEdgeInstanceChannel.Success");
			batchGetEdgeInstanceChannelResponse.Code = _ctx.StringValue("BatchGetEdgeInstanceChannel.Code");
			batchGetEdgeInstanceChannelResponse.ErrorMessage = _ctx.StringValue("BatchGetEdgeInstanceChannel.ErrorMessage");

			List<BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel> batchGetEdgeInstanceChannelResponse_data = new List<BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel>();
			for (int i = 0; i < _ctx.Length("BatchGetEdgeInstanceChannel.Data.Length"); i++) {
				BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel channel = new BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel();
				channel.ChannelId = _ctx.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ChannelId");
				channel.ChannelName = _ctx.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ChannelName");

				List<BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel.BatchGetEdgeInstanceChannel_Config> channel_configList = new List<BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel.BatchGetEdgeInstanceChannel_Config>();
				for (int j = 0; j < _ctx.Length("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList.Length"); j++) {
					BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel.BatchGetEdgeInstanceChannel_Config config = new BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel.BatchGetEdgeInstanceChannel_Config();
					config.ConfigId = _ctx.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList["+ j +"].ConfigId");
					config.Format = _ctx.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList["+ j +"].Format");
					config.Content = _ctx.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList["+ j +"].Content");
					config.Key = _ctx.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList["+ j +"].Key");

					channel_configList.Add(config);
				}
				channel.ConfigList = channel_configList;

				batchGetEdgeInstanceChannelResponse_data.Add(channel);
			}
			batchGetEdgeInstanceChannelResponse.Data = batchGetEdgeInstanceChannelResponse_data;
        
			return batchGetEdgeInstanceChannelResponse;
        }
    }
}
