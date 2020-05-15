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
        public static BatchGetEdgeInstanceDeviceChannelResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetEdgeInstanceDeviceChannelResponse batchGetEdgeInstanceDeviceChannelResponse = new BatchGetEdgeInstanceDeviceChannelResponse();

			batchGetEdgeInstanceDeviceChannelResponse.HttpResponse = context.HttpResponse;
			batchGetEdgeInstanceDeviceChannelResponse.RequestId = context.StringValue("BatchGetEdgeInstanceDeviceChannel.RequestId");
			batchGetEdgeInstanceDeviceChannelResponse.Success = context.BooleanValue("BatchGetEdgeInstanceDeviceChannel.Success");
			batchGetEdgeInstanceDeviceChannelResponse.Code = context.StringValue("BatchGetEdgeInstanceDeviceChannel.Code");
			batchGetEdgeInstanceDeviceChannelResponse.ErrorMessage = context.StringValue("BatchGetEdgeInstanceDeviceChannel.ErrorMessage");

			List<BatchGetEdgeInstanceDeviceChannelResponse.BatchGetEdgeInstanceDeviceChannel_DeviceChannel> batchGetEdgeInstanceDeviceChannelResponse_deviceChannelList = new List<BatchGetEdgeInstanceDeviceChannelResponse.BatchGetEdgeInstanceDeviceChannel_DeviceChannel>();
			for (int i = 0; i < context.Length("BatchGetEdgeInstanceDeviceChannel.DeviceChannelList.Length"); i++) {
				BatchGetEdgeInstanceDeviceChannelResponse.BatchGetEdgeInstanceDeviceChannel_DeviceChannel deviceChannel = new BatchGetEdgeInstanceDeviceChannelResponse.BatchGetEdgeInstanceDeviceChannel_DeviceChannel();
				deviceChannel.ChannelId = context.StringValue("BatchGetEdgeInstanceDeviceChannel.DeviceChannelList["+ i +"].ChannelId");
				deviceChannel.ChannelName = context.StringValue("BatchGetEdgeInstanceDeviceChannel.DeviceChannelList["+ i +"].ChannelName");
				deviceChannel.IotId = context.StringValue("BatchGetEdgeInstanceDeviceChannel.DeviceChannelList["+ i +"].IotId");

				batchGetEdgeInstanceDeviceChannelResponse_deviceChannelList.Add(deviceChannel);
			}
			batchGetEdgeInstanceDeviceChannelResponse.DeviceChannelList = batchGetEdgeInstanceDeviceChannelResponse_deviceChannelList;
        
			return batchGetEdgeInstanceDeviceChannelResponse;
        }
    }
}
