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
        public static BatchGetEdgeInstanceChannelResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetEdgeInstanceChannelResponse batchGetEdgeInstanceChannelResponse = new BatchGetEdgeInstanceChannelResponse();

			batchGetEdgeInstanceChannelResponse.HttpResponse = context.HttpResponse;
			batchGetEdgeInstanceChannelResponse.RequestId = context.StringValue("BatchGetEdgeInstanceChannel.RequestId");
			batchGetEdgeInstanceChannelResponse.Success = context.BooleanValue("BatchGetEdgeInstanceChannel.Success");
			batchGetEdgeInstanceChannelResponse.Code = context.StringValue("BatchGetEdgeInstanceChannel.Code");
			batchGetEdgeInstanceChannelResponse.ErrorMessage = context.StringValue("BatchGetEdgeInstanceChannel.ErrorMessage");

			List<BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel> batchGetEdgeInstanceChannelResponse_data = new List<BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel>();
			for (int i = 0; i < context.Length("BatchGetEdgeInstanceChannel.Data.Length"); i++) {
				BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel channel = new BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel();
				channel.ChannelId = context.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ChannelId");
				channel.ChannelName = context.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ChannelName");

				List<BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel.BatchGetEdgeInstanceChannel_Config> channel_configList = new List<BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel.BatchGetEdgeInstanceChannel_Config>();
				for (int j = 0; j < context.Length("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList.Length"); j++) {
					BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel.BatchGetEdgeInstanceChannel_Config config = new BatchGetEdgeInstanceChannelResponse.BatchGetEdgeInstanceChannel_Channel.BatchGetEdgeInstanceChannel_Config();
					config.ConfigId = context.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList["+ j +"].ConfigId");
					config.Format = context.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList["+ j +"].Format");
					config.Content = context.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList["+ j +"].Content");
					config.Key = context.StringValue("BatchGetEdgeInstanceChannel.Data["+ i +"].ConfigList["+ j +"].Key");

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
