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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsStreamsPublishListResponseUnmarshaller
    {
        public static DescribeVsStreamsPublishListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsStreamsPublishListResponse describeVsStreamsPublishListResponse = new DescribeVsStreamsPublishListResponse();

			describeVsStreamsPublishListResponse.HttpResponse = _ctx.HttpResponse;
			describeVsStreamsPublishListResponse.RequestId = _ctx.StringValue("DescribeVsStreamsPublishList.RequestId");
			describeVsStreamsPublishListResponse.PageNum = _ctx.IntegerValue("DescribeVsStreamsPublishList.PageNum");
			describeVsStreamsPublishListResponse.PageSize = _ctx.IntegerValue("DescribeVsStreamsPublishList.PageSize");
			describeVsStreamsPublishListResponse.TotalNum = _ctx.IntegerValue("DescribeVsStreamsPublishList.TotalNum");
			describeVsStreamsPublishListResponse.TotalPage = _ctx.IntegerValue("DescribeVsStreamsPublishList.TotalPage");

			List<DescribeVsStreamsPublishListResponse.DescribeVsStreamsPublishList_LiveStreamPublishInfo> describeVsStreamsPublishListResponse_publishInfo = new List<DescribeVsStreamsPublishListResponse.DescribeVsStreamsPublishList_LiveStreamPublishInfo>();
			for (int i = 0; i < _ctx.Length("DescribeVsStreamsPublishList.PublishInfo.Length"); i++) {
				DescribeVsStreamsPublishListResponse.DescribeVsStreamsPublishList_LiveStreamPublishInfo liveStreamPublishInfo = new DescribeVsStreamsPublishListResponse.DescribeVsStreamsPublishList_LiveStreamPublishInfo();
				liveStreamPublishInfo.DomainName = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].DomainName");
				liveStreamPublishInfo.AppName = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].AppName");
				liveStreamPublishInfo.StreamName = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].StreamName");
				liveStreamPublishInfo.StreamUrl = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].StreamUrl");
				liveStreamPublishInfo.PublishTime = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].PublishTime");
				liveStreamPublishInfo.StopTime = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].StopTime");
				liveStreamPublishInfo.PublishUrl = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].PublishUrl");
				liveStreamPublishInfo.ClientAddr = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].ClientAddr");
				liveStreamPublishInfo.EdgeNodeAddr = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].EdgeNodeAddr");
				liveStreamPublishInfo.PublishDomain = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].PublishDomain");
				liveStreamPublishInfo.PublishType = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].PublishType");
				liveStreamPublishInfo.Transcoded = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].Transcoded");
				liveStreamPublishInfo.TranscodeId = _ctx.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].TranscodeId");

				describeVsStreamsPublishListResponse_publishInfo.Add(liveStreamPublishInfo);
			}
			describeVsStreamsPublishListResponse.PublishInfo = describeVsStreamsPublishListResponse_publishInfo;
        
			return describeVsStreamsPublishListResponse;
        }
    }
}
