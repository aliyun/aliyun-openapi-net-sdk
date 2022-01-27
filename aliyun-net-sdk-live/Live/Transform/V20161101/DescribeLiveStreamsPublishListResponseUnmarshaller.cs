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
    public class DescribeLiveStreamsPublishListResponseUnmarshaller
    {
        public static DescribeLiveStreamsPublishListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamsPublishListResponse describeLiveStreamsPublishListResponse = new DescribeLiveStreamsPublishListResponse();

			describeLiveStreamsPublishListResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamsPublishListResponse.RequestId = _ctx.StringValue("DescribeLiveStreamsPublishList.RequestId");
			describeLiveStreamsPublishListResponse.PageNum = _ctx.IntegerValue("DescribeLiveStreamsPublishList.PageNum");
			describeLiveStreamsPublishListResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamsPublishList.PageSize");
			describeLiveStreamsPublishListResponse.TotalNum = _ctx.IntegerValue("DescribeLiveStreamsPublishList.TotalNum");
			describeLiveStreamsPublishListResponse.TotalPage = _ctx.IntegerValue("DescribeLiveStreamsPublishList.TotalPage");

			List<DescribeLiveStreamsPublishListResponse.DescribeLiveStreamsPublishList_LiveStreamPublishInfo> describeLiveStreamsPublishListResponse_publishInfo = new List<DescribeLiveStreamsPublishListResponse.DescribeLiveStreamsPublishList_LiveStreamPublishInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamsPublishList.PublishInfo.Length"); i++) {
				DescribeLiveStreamsPublishListResponse.DescribeLiveStreamsPublishList_LiveStreamPublishInfo liveStreamPublishInfo = new DescribeLiveStreamsPublishListResponse.DescribeLiveStreamsPublishList_LiveStreamPublishInfo();
				liveStreamPublishInfo.DomainName = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].DomainName");
				liveStreamPublishInfo.AppName = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].AppName");
				liveStreamPublishInfo.StreamName = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].StreamName");
				liveStreamPublishInfo.StreamUrl = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].StreamUrl");
				liveStreamPublishInfo.PublishTime = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].PublishTime");
				liveStreamPublishInfo.StopTime = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].StopTime");
				liveStreamPublishInfo.PublishUrl = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].PublishUrl");
				liveStreamPublishInfo.ClientAddr = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].ClientAddr");
				liveStreamPublishInfo.EdgeNodeAddr = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].EdgeNodeAddr");
				liveStreamPublishInfo.PublishDomain = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].PublishDomain");
				liveStreamPublishInfo.PublishType = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].PublishType");
				liveStreamPublishInfo.Transcoded = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].Transcoded");
				liveStreamPublishInfo.TranscodeId = _ctx.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].TranscodeId");

				describeLiveStreamsPublishListResponse_publishInfo.Add(liveStreamPublishInfo);
			}
			describeLiveStreamsPublishListResponse.PublishInfo = describeLiveStreamsPublishListResponse_publishInfo;
        
			return describeLiveStreamsPublishListResponse;
        }
    }
}
