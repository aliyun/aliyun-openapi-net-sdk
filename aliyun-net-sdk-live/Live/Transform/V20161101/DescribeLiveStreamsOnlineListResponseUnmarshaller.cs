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
    public class DescribeLiveStreamsOnlineListResponseUnmarshaller
    {
        public static DescribeLiveStreamsOnlineListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamsOnlineListResponse describeLiveStreamsOnlineListResponse = new DescribeLiveStreamsOnlineListResponse();

			describeLiveStreamsOnlineListResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamsOnlineListResponse.RequestId = context.StringValue("DescribeLiveStreamsOnlineList.RequestId");
			describeLiveStreamsOnlineListResponse.PageNum = context.IntegerValue("DescribeLiveStreamsOnlineList.PageNum");
			describeLiveStreamsOnlineListResponse.PageSize = context.IntegerValue("DescribeLiveStreamsOnlineList.PageSize");
			describeLiveStreamsOnlineListResponse.TotalNum = context.IntegerValue("DescribeLiveStreamsOnlineList.TotalNum");
			describeLiveStreamsOnlineListResponse.TotalPage = context.IntegerValue("DescribeLiveStreamsOnlineList.TotalPage");

			List<DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo> describeLiveStreamsOnlineListResponse_onlineInfo = new List<DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamsOnlineList.OnlineInfo.Length"); i++) {
				DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo liveStreamOnlineInfo = new DescribeLiveStreamsOnlineListResponse.DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo();
				liveStreamOnlineInfo.DomainName = context.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].DomainName");
				liveStreamOnlineInfo.AppName = context.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].AppName");
				liveStreamOnlineInfo.StreamName = context.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].StreamName");
				liveStreamOnlineInfo.PublishTime = context.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishTime");
				liveStreamOnlineInfo.PublishUrl = context.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishUrl");
				liveStreamOnlineInfo.PublishDomain = context.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishDomain");
				liveStreamOnlineInfo.PublishType = context.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].PublishType");
				liveStreamOnlineInfo.Transcoded = context.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].Transcoded");
				liveStreamOnlineInfo.TranscodeId = context.StringValue("DescribeLiveStreamsOnlineList.OnlineInfo["+ i +"].TranscodeId");

				describeLiveStreamsOnlineListResponse_onlineInfo.Add(liveStreamOnlineInfo);
			}
			describeLiveStreamsOnlineListResponse.OnlineInfo = describeLiveStreamsOnlineListResponse_onlineInfo;
        
			return describeLiveStreamsOnlineListResponse;
        }
    }
}