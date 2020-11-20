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
    public class DescribeRtcChannelDetailResponseUnmarshaller
    {
        public static DescribeRtcChannelDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcChannelDetailResponse describeRtcChannelDetailResponse = new DescribeRtcChannelDetailResponse();

			describeRtcChannelDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcChannelDetailResponse.RequestId = _ctx.StringValue("DescribeRtcChannelDetail.RequestId");
			describeRtcChannelDetailResponse.ChannelId = _ctx.StringValue("DescribeRtcChannelDetail.ChannelId");
			describeRtcChannelDetailResponse.PageSize = _ctx.LongValue("DescribeRtcChannelDetail.PageSize");
			describeRtcChannelDetailResponse.PageNo = _ctx.LongValue("DescribeRtcChannelDetail.PageNo");
			describeRtcChannelDetailResponse.TotalCnt = _ctx.LongValue("DescribeRtcChannelDetail.TotalCnt");

			List<DescribeRtcChannelDetailResponse.DescribeRtcChannelDetail_Detail> describeRtcChannelDetailResponse_channelInfo = new List<DescribeRtcChannelDetailResponse.DescribeRtcChannelDetail_Detail>();
			for (int i = 0; i < _ctx.Length("DescribeRtcChannelDetail.ChannelInfo.Length"); i++) {
				DescribeRtcChannelDetailResponse.DescribeRtcChannelDetail_Detail detail = new DescribeRtcChannelDetailResponse.DescribeRtcChannelDetail_Detail();
				detail.Sid = _ctx.StringValue("DescribeRtcChannelDetail.ChannelInfo["+ i +"].Sid");
				detail.Uid = _ctx.StringValue("DescribeRtcChannelDetail.ChannelInfo["+ i +"].Uid");
				detail.JoinTime = _ctx.StringValue("DescribeRtcChannelDetail.ChannelInfo["+ i +"].JoinTime");
				detail.LeaveTime = _ctx.StringValue("DescribeRtcChannelDetail.ChannelInfo["+ i +"].LeaveTime");
				detail.SdkVersion = _ctx.StringValue("DescribeRtcChannelDetail.ChannelInfo["+ i +"].SdkVersion");
				detail.Platform = _ctx.StringValue("DescribeRtcChannelDetail.ChannelInfo["+ i +"].Platform");
				detail.OS = _ctx.StringValue("DescribeRtcChannelDetail.ChannelInfo["+ i +"].OS");
				detail.DeviceType = _ctx.StringValue("DescribeRtcChannelDetail.ChannelInfo["+ i +"].DeviceType");

				describeRtcChannelDetailResponse_channelInfo.Add(detail);
			}
			describeRtcChannelDetailResponse.ChannelInfo = describeRtcChannelDetailResponse_channelInfo;
        
			return describeRtcChannelDetailResponse;
        }
    }
}
