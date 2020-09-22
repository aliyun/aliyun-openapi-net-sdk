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
        public static DescribeVsStreamsPublishListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsStreamsPublishListResponse describeVsStreamsPublishListResponse = new DescribeVsStreamsPublishListResponse();

			describeVsStreamsPublishListResponse.HttpResponse = context.HttpResponse;
			describeVsStreamsPublishListResponse.RequestId = context.StringValue("DescribeVsStreamsPublishList.RequestId");
			describeVsStreamsPublishListResponse.PageNum = context.IntegerValue("DescribeVsStreamsPublishList.PageNum");
			describeVsStreamsPublishListResponse.PageSize = context.IntegerValue("DescribeVsStreamsPublishList.PageSize");
			describeVsStreamsPublishListResponse.TotalNum = context.IntegerValue("DescribeVsStreamsPublishList.TotalNum");
			describeVsStreamsPublishListResponse.TotalPage = context.IntegerValue("DescribeVsStreamsPublishList.TotalPage");

			List<DescribeVsStreamsPublishListResponse.DescribeVsStreamsPublishList_LiveStreamPublishInfo> describeVsStreamsPublishListResponse_publishInfo = new List<DescribeVsStreamsPublishListResponse.DescribeVsStreamsPublishList_LiveStreamPublishInfo>();
			for (int i = 0; i < context.Length("DescribeVsStreamsPublishList.PublishInfo.Length"); i++) {
				DescribeVsStreamsPublishListResponse.DescribeVsStreamsPublishList_LiveStreamPublishInfo liveStreamPublishInfo = new DescribeVsStreamsPublishListResponse.DescribeVsStreamsPublishList_LiveStreamPublishInfo();
				liveStreamPublishInfo.DomainName = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].DomainName");
				liveStreamPublishInfo.AppName = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].AppName");
				liveStreamPublishInfo.StreamName = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].StreamName");
				liveStreamPublishInfo.StreamUrl = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].StreamUrl");
				liveStreamPublishInfo.PublishTime = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].PublishTime");
				liveStreamPublishInfo.StopTime = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].StopTime");
				liveStreamPublishInfo.PublishUrl = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].PublishUrl");
				liveStreamPublishInfo.ClientAddr = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].ClientAddr");
				liveStreamPublishInfo.EdgeNodeAddr = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].EdgeNodeAddr");
				liveStreamPublishInfo.PublishDomain = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].PublishDomain");
				liveStreamPublishInfo.PublishType = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].PublishType");
				liveStreamPublishInfo.Transcoded = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].Transcoded");
				liveStreamPublishInfo.TranscodeId = context.StringValue("DescribeVsStreamsPublishList.PublishInfo["+ i +"].TranscodeId");

				describeVsStreamsPublishListResponse_publishInfo.Add(liveStreamPublishInfo);
			}
			describeVsStreamsPublishListResponse.PublishInfo = describeVsStreamsPublishListResponse_publishInfo;
        
			return describeVsStreamsPublishListResponse;
        }
    }
}
