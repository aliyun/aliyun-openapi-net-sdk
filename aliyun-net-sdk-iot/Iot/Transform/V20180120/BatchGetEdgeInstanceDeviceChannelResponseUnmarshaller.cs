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
    public class BatchGetEdgeInstanceDeviceChannelResponseUnmarshaller
    {
        public static BatchGetEdgeInstanceDeviceChannelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchGetEdgeInstanceDeviceChannelResponse batchGetEdgeInstanceDeviceChannelResponse = new BatchGetEdgeInstanceDeviceChannelResponse();

			batchGetEdgeInstanceDeviceChannelResponse.HttpResponse = _ctx.HttpResponse;
			batchGetEdgeInstanceDeviceChannelResponse.RequestId = _ctx.StringValue("BatchGetEdgeInstanceDeviceChannel.RequestId");
			batchGetEdgeInstanceDeviceChannelResponse.Success = _ctx.BooleanValue("BatchGetEdgeInstanceDeviceChannel.Success");
			batchGetEdgeInstanceDeviceChannelResponse.Code = _ctx.StringValue("BatchGetEdgeInstanceDeviceChannel.Code");
			batchGetEdgeInstanceDeviceChannelResponse.ErrorMessage = _ctx.StringValue("BatchGetEdgeInstanceDeviceChannel.ErrorMessage");

			List<BatchGetEdgeInstanceDeviceChannelResponse.BatchGetEdgeInstanceDeviceChannel_DeviceChannel> batchGetEdgeInstanceDeviceChannelResponse_deviceChannelList = new List<BatchGetEdgeInstanceDeviceChannelResponse.BatchGetEdgeInstanceDeviceChannel_DeviceChannel>();
			for (int i = 0; i < _ctx.Length("BatchGetEdgeInstanceDeviceChannel.DeviceChannelList.Length"); i++) {
				BatchGetEdgeInstanceDeviceChannelResponse.BatchGetEdgeInstanceDeviceChannel_DeviceChannel deviceChannel = new BatchGetEdgeInstanceDeviceChannelResponse.BatchGetEdgeInstanceDeviceChannel_DeviceChannel();
				deviceChannel.ChannelId = _ctx.StringValue("BatchGetEdgeInstanceDeviceChannel.DeviceChannelList["+ i +"].ChannelId");
				deviceChannel.ChannelName = _ctx.StringValue("BatchGetEdgeInstanceDeviceChannel.DeviceChannelList["+ i +"].ChannelName");
				deviceChannel.IotId = _ctx.StringValue("BatchGetEdgeInstanceDeviceChannel.DeviceChannelList["+ i +"].IotId");

				batchGetEdgeInstanceDeviceChannelResponse_deviceChannelList.Add(deviceChannel);
			}
			batchGetEdgeInstanceDeviceChannelResponse.DeviceChannelList = batchGetEdgeInstanceDeviceChannelResponse_deviceChannelList;
        
			return batchGetEdgeInstanceDeviceChannelResponse;
        }
    }
}
