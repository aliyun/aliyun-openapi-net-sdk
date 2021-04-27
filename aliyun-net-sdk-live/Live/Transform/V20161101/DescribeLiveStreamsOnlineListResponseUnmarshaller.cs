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
    public class DescribeLiveStreamsOnlineListResponseUnmarshaller
    {
        public static DescribeLiveStreamsOnlineListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamsOnlineListResponse describeLiveStreamsOnlineListResponse = new DescribeLiveStreamsOnlineListResponse();

			describeLiveStreamsOnlineListResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamsOnlineListResponse.RequestId = _ctx.StringValue("DescribeLiveStreamsOnlineList.RequestId");
			describeLiveStreamsOnlineListResponse.PageNum = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.PageNum");
			describeLiveStreamsOnlineListResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.PageSize");
			describeLiveStreamsOnlineListResponse.TotalNum = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.TotalNum");
			describeLiveStreamsOnlineListResponse.TotalPage = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.TotalPage");

			List<DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo> describeLiveStreamsOnlineListResponse_onlineInfo = new List<DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamsOnlineList.OnlineInfo.Length"); i++) {
				DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo liveStreamOnlineInfo = new DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo();
				liveStreamOnlineInfo.DomainName = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].DomainName");
				liveStreamOnlineInfo.AppName = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].AppName");
				liveStreamOnlineInfo.StreamName = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].StreamName");
				liveStreamOnlineInfo.PublishTime = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishTime");
				liveStreamOnlineInfo.PublishUrl = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishUrl");
				liveStreamOnlineInfo.PublishDomain = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishDomain");
				liveStreamOnlineInfo.StreamUrlArgs = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].StreamUrlArgs");
				liveStreamOnlineInfo.PublishType = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishType");
				liveStreamOnlineInfo.Transcoded = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].Transcoded");
				liveStreamOnlineInfo.TranscodeId = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].TranscodeId");
				liveStreamOnlineInfo.ServerIp = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].ServerIp");
				liveStreamOnlineInfo.ClientIp = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].ClientIp");
				liveStreamOnlineInfo.VideoCodecId = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].VideoCodecId");
				liveStreamOnlineInfo.VideoDataRate = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].VideoDataRate");
				liveStreamOnlineInfo.FrameRate = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].FrameRate");
				liveStreamOnlineInfo.Width = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].Width");
				liveStreamOnlineInfo.Height = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].Height");
				liveStreamOnlineInfo.AudioCodecId = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].AudioCodecId");
				liveStreamOnlineInfo.AudioDataRate = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].AudioDataRate");

				describeLiveStreamsOnlineListResponse_onlineInfo.Add(liveStreamOnlineInfo);
			}
			describeLiveStreamsOnlineListResponse.OnlineInfo = describeLiveStreamsOnlineListResponse_onlineInfo;
        
			return describeLiveStreamsOnlineListResponse;
        }
    }
}
