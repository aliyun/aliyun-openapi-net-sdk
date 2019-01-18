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
    public class DescribeLiveStreamsFrameRateAndBitRateDataResponseUnmarshaller
    {
        public static DescribeLiveStreamsFrameRateAndBitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamsFrameRateAndBitRateDataResponse describeLiveStreamsFrameRateAndBitRateDataResponse = new DescribeLiveStreamsFrameRateAndBitRateDataResponse();

			describeLiveStreamsFrameRateAndBitRateDataResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamsFrameRateAndBitRateDataResponse.RequestId = context.StringValue("DescribeLiveStreamsFrameRateAndBitRateData.RequestId");

			List<DescribeLiveStreamsFrameRateAndBitRateDataResponse.DescribeLiveStreamsFrameRateAndBitRateData_FrameRateAndBitRateInfo> describeLiveStreamsFrameRateAndBitRateDataResponse_frameRateAndBitRateInfos = new List<DescribeLiveStreamsFrameRateAndBitRateDataResponse.DescribeLiveStreamsFrameRateAndBitRateData_FrameRateAndBitRateInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamsFrameRateAndBitRateData.FrameRateAndBitRateInfos.Length"); i++) {
				DescribeLiveStreamsFrameRateAndBitRateDataResponse.DescribeLiveStreamsFrameRateAndBitRateData_FrameRateAndBitRateInfo frameRateAndBitRateInfo = new DescribeLiveStreamsFrameRateAndBitRateDataResponse.DescribeLiveStreamsFrameRateAndBitRateData_FrameRateAndBitRateInfo();
				frameRateAndBitRateInfo.StreamUrl = context.StringValue("DescribeLiveStreamsFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].StreamUrl");
				frameRateAndBitRateInfo.VideoFrameRate = context.FloatValue("DescribeLiveStreamsFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].VideoFrameRate");
				frameRateAndBitRateInfo.AudioFrameRate = context.FloatValue("DescribeLiveStreamsFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].AudioFrameRate");
				frameRateAndBitRateInfo.BitRate = context.FloatValue("DescribeLiveStreamsFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].BitRate");
				frameRateAndBitRateInfo.Time = context.StringValue("DescribeLiveStreamsFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].Time");

				describeLiveStreamsFrameRateAndBitRateDataResponse_frameRateAndBitRateInfos.Add(frameRateAndBitRateInfo);
			}
			describeLiveStreamsFrameRateAndBitRateDataResponse.FrameRateAndBitRateInfos = describeLiveStreamsFrameRateAndBitRateDataResponse_frameRateAndBitRateInfos;
        
			return describeLiveStreamsFrameRateAndBitRateDataResponse;
        }
    }
}