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
    public class DescribeVsStreamsOnlineListResponseUnmarshaller
    {
        public static DescribeVsStreamsOnlineListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsStreamsOnlineListResponse describeVsStreamsOnlineListResponse = new DescribeVsStreamsOnlineListResponse();

			describeVsStreamsOnlineListResponse.HttpResponse = context.HttpResponse;
			describeVsStreamsOnlineListResponse.RequestId = context.StringValue("DescribeVsStreamsOnlineList.RequestId");
			describeVsStreamsOnlineListResponse.PageNum = context.IntegerValue("DescribeVsStreamsOnlineList.PageNum");
			describeVsStreamsOnlineListResponse.PageSize = context.IntegerValue("DescribeVsStreamsOnlineList.PageSize");
			describeVsStreamsOnlineListResponse.TotalNum = context.IntegerValue("DescribeVsStreamsOnlineList.TotalNum");
			describeVsStreamsOnlineListResponse.TotalPage = context.IntegerValue("DescribeVsStreamsOnlineList.TotalPage");

			List<DescribeVsStreamsOnlineListResponse.DescribeVsStreamsOnlineList_LiveStreamOnlineInfo> describeVsStreamsOnlineListResponse_onlineInfo = new List<DescribeVsStreamsOnlineListResponse.DescribeVsStreamsOnlineList_LiveStreamOnlineInfo>();
			for (int i = 0; i < context.Length("DescribeVsStreamsOnlineList.OnlineInfo.Length"); i++) {
				DescribeVsStreamsOnlineListResponse.DescribeVsStreamsOnlineList_LiveStreamOnlineInfo liveStreamOnlineInfo = new DescribeVsStreamsOnlineListResponse.DescribeVsStreamsOnlineList_LiveStreamOnlineInfo();
				liveStreamOnlineInfo.DomainName = context.StringValue("DescribeVsStreamsOnlineList.OnlineInfo["+ i +"].DomainName");
				liveStreamOnlineInfo.AppName = context.StringValue("DescribeVsStreamsOnlineList.OnlineInfo["+ i +"].AppName");
				liveStreamOnlineInfo.StreamName = context.StringValue("DescribeVsStreamsOnlineList.OnlineInfo["+ i +"].StreamName");
				liveStreamOnlineInfo.PublishTime = context.StringValue("DescribeVsStreamsOnlineList.OnlineInfo["+ i +"].PublishTime");
				liveStreamOnlineInfo.PublishUrl = context.StringValue("DescribeVsStreamsOnlineList.OnlineInfo["+ i +"].PublishUrl");
				liveStreamOnlineInfo.PublishDomain = context.StringValue("DescribeVsStreamsOnlineList.OnlineInfo["+ i +"].PublishDomain");
				liveStreamOnlineInfo.PublishType = context.StringValue("DescribeVsStreamsOnlineList.OnlineInfo["+ i +"].PublishType");
				liveStreamOnlineInfo.Transcoded = context.StringValue("DescribeVsStreamsOnlineList.OnlineInfo["+ i +"].Transcoded");
				liveStreamOnlineInfo.TranscodeId = context.StringValue("DescribeVsStreamsOnlineList.OnlineInfo["+ i +"].TranscodeId");

				describeVsStreamsOnlineListResponse_onlineInfo.Add(liveStreamOnlineInfo);
			}
			describeVsStreamsOnlineListResponse.OnlineInfo = describeVsStreamsOnlineListResponse_onlineInfo;
        
			return describeVsStreamsOnlineListResponse;
        }
    }
}
