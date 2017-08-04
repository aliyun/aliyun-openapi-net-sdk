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
    public class DescribeLiveStreamOnlineBpsResponseUnmarshaller
    {
        public static DescribeLiveStreamOnlineBpsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamOnlineBpsResponse describeLiveStreamOnlineBpsResponse = new DescribeLiveStreamOnlineBpsResponse();

			describeLiveStreamOnlineBpsResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamOnlineBpsResponse.RequestId = context.StringValue("DescribeLiveStreamOnlineBps.RequestId");
			describeLiveStreamOnlineBpsResponse.TotalUserNumber = context.LongValue("DescribeLiveStreamOnlineBps.TotalUserNumber");
			describeLiveStreamOnlineBpsResponse.FlvBps = context.FloatValue("DescribeLiveStreamOnlineBps.FlvBps");
			describeLiveStreamOnlineBpsResponse.HlsBps = context.FloatValue("DescribeLiveStreamOnlineBps.HlsBps");

			List<DescribeLiveStreamOnlineBpsResponse.DescribeLiveStreamOnlineBps_LiveStreamOnlineBpsInfo> describeLiveStreamOnlineBpsResponse_liveStreamOnlineBpsInfos = new List<DescribeLiveStreamOnlineBpsResponse.DescribeLiveStreamOnlineBps_LiveStreamOnlineBpsInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamOnlineBps.LiveStreamOnlineBpsInfos.Length"); i++) {
				DescribeLiveStreamOnlineBpsResponse.DescribeLiveStreamOnlineBps_LiveStreamOnlineBpsInfo liveStreamOnlineBpsInfo = new DescribeLiveStreamOnlineBpsResponse.DescribeLiveStreamOnlineBps_LiveStreamOnlineBpsInfo();
				liveStreamOnlineBpsInfo.StreamUrl = context.StringValue("DescribeLiveStreamOnlineBps.LiveStreamOnlineBpsInfos["+ i +"].StreamUrl");
				liveStreamOnlineBpsInfo.UpBps = context.FloatValue("DescribeLiveStreamOnlineBps.LiveStreamOnlineBpsInfos["+ i +"].UpBps");
				liveStreamOnlineBpsInfo.DownBps = context.FloatValue("DescribeLiveStreamOnlineBps.LiveStreamOnlineBpsInfos["+ i +"].DownBps");
				liveStreamOnlineBpsInfo.Time = context.StringValue("DescribeLiveStreamOnlineBps.LiveStreamOnlineBpsInfos["+ i +"].Time");

				describeLiveStreamOnlineBpsResponse_liveStreamOnlineBpsInfos.Add(liveStreamOnlineBpsInfo);
			}
			describeLiveStreamOnlineBpsResponse.LiveStreamOnlineBpsInfos = describeLiveStreamOnlineBpsResponse_liveStreamOnlineBpsInfos;
        
			return describeLiveStreamOnlineBpsResponse;
        }
    }
}