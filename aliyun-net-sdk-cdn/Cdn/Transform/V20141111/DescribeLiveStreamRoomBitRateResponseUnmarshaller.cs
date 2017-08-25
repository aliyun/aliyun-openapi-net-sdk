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
    public class DescribeLiveStreamRoomBitRateResponseUnmarshaller
    {
        public static DescribeLiveStreamRoomBitRateResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamRoomBitRateResponse describeLiveStreamRoomBitRateResponse = new DescribeLiveStreamRoomBitRateResponse();

			describeLiveStreamRoomBitRateResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamRoomBitRateResponse.RequestId = context.StringValue("DescribeLiveStreamRoomBitRate.RequestId");

			List<DescribeLiveStreamRoomBitRateResponse.DescribeLiveStreamRoomBitRate_FrameRateAndBitRateInfo> describeLiveStreamRoomBitRateResponse_frameRateAndBitRateInfos = new List<DescribeLiveStreamRoomBitRateResponse.DescribeLiveStreamRoomBitRate_FrameRateAndBitRateInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamRoomBitRate.FrameRateAndBitRateInfos.Length"); i++) {
				DescribeLiveStreamRoomBitRateResponse.DescribeLiveStreamRoomBitRate_FrameRateAndBitRateInfo frameRateAndBitRateInfo = new DescribeLiveStreamRoomBitRateResponse.DescribeLiveStreamRoomBitRate_FrameRateAndBitRateInfo();
				frameRateAndBitRateInfo.StreamUrl = context.StringValue("DescribeLiveStreamRoomBitRate.FrameRateAndBitRateInfos["+ i +"].StreamUrl");
				frameRateAndBitRateInfo.VideoFrameRate = context.FloatValue("DescribeLiveStreamRoomBitRate.FrameRateAndBitRateInfos["+ i +"].VideoFrameRate");
				frameRateAndBitRateInfo.AudioFrameRate = context.FloatValue("DescribeLiveStreamRoomBitRate.FrameRateAndBitRateInfos["+ i +"].AudioFrameRate");
				frameRateAndBitRateInfo.BitRate = context.FloatValue("DescribeLiveStreamRoomBitRate.FrameRateAndBitRateInfos["+ i +"].BitRate");
				frameRateAndBitRateInfo.Time = context.StringValue("DescribeLiveStreamRoomBitRate.FrameRateAndBitRateInfos["+ i +"].Time");

				describeLiveStreamRoomBitRateResponse_frameRateAndBitRateInfos.Add(frameRateAndBitRateInfo);
			}
			describeLiveStreamRoomBitRateResponse.FrameRateAndBitRateInfos = describeLiveStreamRoomBitRateResponse_frameRateAndBitRateInfos;
        
			return describeLiveStreamRoomBitRateResponse;
        }
    }
}