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
    public class DescribeLiveStreamBitRateDataResponseUnmarshaller
    {
        public static DescribeLiveStreamBitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamBitRateDataResponse describeLiveStreamBitRateDataResponse = new DescribeLiveStreamBitRateDataResponse();

			describeLiveStreamBitRateDataResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamBitRateDataResponse.RequestId = context.StringValue("DescribeLiveStreamBitRateData.RequestId");

			List<DescribeLiveStreamBitRateDataResponse.DescribeLiveStreamBitRateData_FrameRateAndBitRateInfo> describeLiveStreamBitRateDataResponse_frameRateAndBitRateInfos = new List<DescribeLiveStreamBitRateDataResponse.DescribeLiveStreamBitRateData_FrameRateAndBitRateInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamBitRateData.FrameRateAndBitRateInfos.Length"); i++) {
				DescribeLiveStreamBitRateDataResponse.DescribeLiveStreamBitRateData_FrameRateAndBitRateInfo frameRateAndBitRateInfo = new DescribeLiveStreamBitRateDataResponse.DescribeLiveStreamBitRateData_FrameRateAndBitRateInfo();
				frameRateAndBitRateInfo.StreamUrl = context.StringValue("DescribeLiveStreamBitRateData.FrameRateAndBitRateInfos["+ i +"].StreamUrl");
				frameRateAndBitRateInfo.VideoFrameRate = context.FloatValue("DescribeLiveStreamBitRateData.FrameRateAndBitRateInfos["+ i +"].VideoFrameRate");
				frameRateAndBitRateInfo.AudioFrameRate = context.FloatValue("DescribeLiveStreamBitRateData.FrameRateAndBitRateInfos["+ i +"].AudioFrameRate");
				frameRateAndBitRateInfo.BitRate = context.FloatValue("DescribeLiveStreamBitRateData.FrameRateAndBitRateInfos["+ i +"].BitRate");
				frameRateAndBitRateInfo.Time = context.StringValue("DescribeLiveStreamBitRateData.FrameRateAndBitRateInfos["+ i +"].Time");

				describeLiveStreamBitRateDataResponse_frameRateAndBitRateInfos.Add(frameRateAndBitRateInfo);
			}
			describeLiveStreamBitRateDataResponse.FrameRateAndBitRateInfos = describeLiveStreamBitRateDataResponse_frameRateAndBitRateInfos;
        
			return describeLiveStreamBitRateDataResponse;
        }
    }
}