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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRtcChannelListResponseUnmarshaller
    {
        public static DescribeRtcChannelListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcChannelListResponse describeRtcChannelListResponse = new DescribeRtcChannelListResponse();

			describeRtcChannelListResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcChannelListResponse.RequestId = _ctx.StringValue("DescribeRtcChannelList.RequestId");
			describeRtcChannelListResponse.PageSize = _ctx.LongValue("DescribeRtcChannelList.PageSize");
			describeRtcChannelListResponse.PageNo = _ctx.LongValue("DescribeRtcChannelList.PageNo");
			describeRtcChannelListResponse.TotalCnt = _ctx.LongValue("DescribeRtcChannelList.TotalCnt");

			List<DescribeRtcChannelListResponse.DescribeRtcChannelList_ChannelListItem> describeRtcChannelListResponse_channelList = new List<DescribeRtcChannelListResponse.DescribeRtcChannelList_ChannelListItem>();
			for (int i = 0; i < _ctx.Length("DescribeRtcChannelList.ChannelList.Length"); i++) {
				DescribeRtcChannelListResponse.DescribeRtcChannelList_ChannelListItem channelListItem = new DescribeRtcChannelListResponse.DescribeRtcChannelList_ChannelListItem();
				channelListItem.ChannelId = _ctx.StringValue("DescribeRtcChannelList.ChannelList["+ i +"].ChannelId");
				channelListItem.StartTime = _ctx.StringValue("DescribeRtcChannelList.ChannelList["+ i +"].StartTime");
				channelListItem.EndTime = _ctx.StringValue("DescribeRtcChannelList.ChannelList["+ i +"].EndTime");
				channelListItem.TotalUserCnt = _ctx.LongValue("DescribeRtcChannelList.ChannelList["+ i +"].TotalUserCnt");

				List<string> channelListItem_callArea = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRtcChannelList.ChannelList["+ i +"].CallArea.Length"); j++) {
					channelListItem_callArea.Add(_ctx.StringValue("DescribeRtcChannelList.ChannelList["+ i +"].CallArea["+ j +"]"));
				}
				channelListItem.CallArea = channelListItem_callArea;

				describeRtcChannelListResponse_channelList.Add(channelListItem);
			}
			describeRtcChannelListResponse.ChannelList = describeRtcChannelListResponse_channelList;
        
			return describeRtcChannelListResponse;
        }
    }
}
