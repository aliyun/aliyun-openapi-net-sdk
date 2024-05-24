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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveStreamDetailFrameRateAndBitRateDataResponseUnmarshaller
    {
        public static DescribeLiveStreamDetailFrameRateAndBitRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamDetailFrameRateAndBitRateDataResponse describeLiveStreamDetailFrameRateAndBitRateDataResponse = new DescribeLiveStreamDetailFrameRateAndBitRateDataResponse();

			describeLiveStreamDetailFrameRateAndBitRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamDetailFrameRateAndBitRateDataResponse.RequestId = _ctx.StringValue("DescribeLiveStreamDetailFrameRateAndBitRateData.RequestId");

			List<DescribeLiveStreamDetailFrameRateAndBitRateDataResponse.DescribeLiveStreamDetailFrameRateAndBitRateData_Frabr> describeLiveStreamDetailFrameRateAndBitRateDataResponse_frameRateAndBitRateInfos = new List<DescribeLiveStreamDetailFrameRateAndBitRateDataResponse.DescribeLiveStreamDetailFrameRateAndBitRateData_Frabr>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamDetailFrameRateAndBitRateData.FrameRateAndBitRateInfos.Length"); i++) {
				DescribeLiveStreamDetailFrameRateAndBitRateDataResponse.DescribeLiveStreamDetailFrameRateAndBitRateData_Frabr frabr = new DescribeLiveStreamDetailFrameRateAndBitRateDataResponse.DescribeLiveStreamDetailFrameRateAndBitRateData_Frabr();
				frabr.AudioBitRate = _ctx.FloatValue("DescribeLiveStreamDetailFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].AudioBitRate");
				frabr.AudioFrameRate = _ctx.FloatValue("DescribeLiveStreamDetailFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].AudioFrameRate");
				frabr.BitRate = _ctx.FloatValue("DescribeLiveStreamDetailFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].BitRate");
				frabr.StreamUrl = _ctx.StringValue("DescribeLiveStreamDetailFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].StreamUrl");
				frabr.Time = _ctx.StringValue("DescribeLiveStreamDetailFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].Time");
				frabr.VideoBitRate = _ctx.FloatValue("DescribeLiveStreamDetailFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].VideoBitRate");
				frabr.VideoFrameRate = _ctx.FloatValue("DescribeLiveStreamDetailFrameRateAndBitRateData.FrameRateAndBitRateInfos["+ i +"].VideoFrameRate");

				describeLiveStreamDetailFrameRateAndBitRateDataResponse_frameRateAndBitRateInfos.Add(frabr);
			}
			describeLiveStreamDetailFrameRateAndBitRateDataResponse.FrameRateAndBitRateInfos = describeLiveStreamDetailFrameRateAndBitRateDataResponse_frameRateAndBitRateInfos;
        
			return describeLiveStreamDetailFrameRateAndBitRateDataResponse;
        }
    }
}
