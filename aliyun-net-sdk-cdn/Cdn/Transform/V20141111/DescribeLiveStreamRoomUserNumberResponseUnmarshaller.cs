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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveStreamRoomUserNumberResponseUnmarshaller
    {
        public static DescribeLiveStreamRoomUserNumberResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamRoomUserNumberResponse describeLiveStreamRoomUserNumberResponse = new DescribeLiveStreamRoomUserNumberResponse();

			describeLiveStreamRoomUserNumberResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamRoomUserNumberResponse.RequestId = context.StringValue("DescribeLiveStreamRoomUserNumber.RequestId");
			describeLiveStreamRoomUserNumberResponse.TotalUserNumber = context.LongValue("DescribeLiveStreamRoomUserNumber.TotalUserNumber");

			List<DescribeLiveStreamRoomUserNumberResponse.DescribeLiveStreamRoomUserNumber_LiveStreamOnlineUserNumInfo> describeLiveStreamRoomUserNumberResponse_onlineUserInfo = new List<DescribeLiveStreamRoomUserNumberResponse.DescribeLiveStreamRoomUserNumber_LiveStreamOnlineUserNumInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamRoomUserNumber.OnlineUserInfo.Length"); i++) {
				DescribeLiveStreamRoomUserNumberResponse.DescribeLiveStreamRoomUserNumber_LiveStreamOnlineUserNumInfo liveStreamOnlineUserNumInfo = new DescribeLiveStreamRoomUserNumberResponse.DescribeLiveStreamRoomUserNumber_LiveStreamOnlineUserNumInfo();
				liveStreamOnlineUserNumInfo.StreamUrl = context.StringValue("DescribeLiveStreamRoomUserNumber.OnlineUserInfo["+ i +"].StreamUrl");
				liveStreamOnlineUserNumInfo.UserNumber = context.LongValue("DescribeLiveStreamRoomUserNumber.OnlineUserInfo["+ i +"].UserNumber");
				liveStreamOnlineUserNumInfo.Time = context.StringValue("DescribeLiveStreamRoomUserNumber.OnlineUserInfo["+ i +"].Time");

				describeLiveStreamRoomUserNumberResponse_onlineUserInfo.Add(liveStreamOnlineUserNumInfo);
			}
			describeLiveStreamRoomUserNumberResponse.OnlineUserInfo = describeLiveStreamRoomUserNumberResponse_onlineUserInfo;
        
			return describeLiveStreamRoomUserNumberResponse;
        }
    }
}