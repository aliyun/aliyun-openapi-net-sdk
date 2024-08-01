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
			describeLiveStreamsOnlineListResponse.TotalPage = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.TotalPage");
			describeLiveStreamsOnlineListResponse.PageNum = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.PageNum");
			describeLiveStreamsOnlineListResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.PageSize");
			describeLiveStreamsOnlineListResponse.TotalNum = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.TotalNum");

			List<DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo> describeLiveStreamsOnlineListResponse_onlineInfo = new List<DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamsOnlineList.OnlineInfo.Length"); i++) {
				DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo liveStreamOnlineInfo = new DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo();
				liveStreamOnlineInfo.AudioDataRate = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].AudioDataRate");
				liveStreamOnlineInfo.FrameRate = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].FrameRate");
				liveStreamOnlineInfo.PublishUrl = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishUrl");
				liveStreamOnlineInfo.StreamName = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].StreamName");
				liveStreamOnlineInfo.AudioCodecId = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].AudioCodecId");
				liveStreamOnlineInfo.Height = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].Height");
				liveStreamOnlineInfo.VideoDataRate = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].VideoDataRate");
				liveStreamOnlineInfo.DomainName = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].DomainName");
				liveStreamOnlineInfo.TranscodeId = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].TranscodeId");
				liveStreamOnlineInfo.TranscodeDrm = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].TranscodeDrm");
				liveStreamOnlineInfo.PublishDomain = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishDomain");
				liveStreamOnlineInfo.PublishTime = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishTime");
				liveStreamOnlineInfo.AppName = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].AppName");
				liveStreamOnlineInfo.PublishType = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishType");
				liveStreamOnlineInfo.VideoCodecId = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].VideoCodecId");
				liveStreamOnlineInfo.Transcoded = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].Transcoded");
				liveStreamOnlineInfo.Width = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].Width");
				liveStreamOnlineInfo.ClientIp = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].ClientIp");
				liveStreamOnlineInfo.ServerIp = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].ServerIp");
				liveStreamOnlineInfo.StreamUrlArgs = _ctx.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].StreamUrlArgs");
				liveStreamOnlineInfo.CurrAudioDataRate = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].CurrAudioDataRate");
				liveStreamOnlineInfo.CurrVideoDataRate = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].CurrVideoDataRate");
				liveStreamOnlineInfo.CurrWidth = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].CurrWidth");
				liveStreamOnlineInfo.CurrHeight = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].CurrHeight");
				liveStreamOnlineInfo.CurrFrameRate = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].CurrFrameRate");
				liveStreamOnlineInfo.CurrVideoCodecId = _ctx.IntegerValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].CurrVideoCodecId");

				describeLiveStreamsOnlineListResponse_onlineInfo.Add(liveStreamOnlineInfo);
			}
			describeLiveStreamsOnlineListResponse.OnlineInfo = describeLiveStreamsOnlineListResponse_onlineInfo;
        
			return describeLiveStreamsOnlineListResponse;
        }
    }
}
