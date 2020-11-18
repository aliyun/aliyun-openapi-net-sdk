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
    public class DescribeRtcChannelMetricResponseUnmarshaller
    {
        public static DescribeRtcChannelMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcChannelMetricResponse describeRtcChannelMetricResponse = new DescribeRtcChannelMetricResponse();

			describeRtcChannelMetricResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcChannelMetricResponse.RequestId = _ctx.StringValue("DescribeRtcChannelMetric.RequestId");

			DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo channelMetricInfo = new DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo();

			DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo.DescribeRtcChannelMetric_ChannelMetric channelMetric = new DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo.DescribeRtcChannelMetric_ChannelMetric();
			channelMetric.ChannelId = _ctx.StringValue("DescribeRtcChannelMetric.ChannelMetricInfo.ChannelMetric.ChannelId");
			channelMetric.UserCount = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.ChannelMetric.UserCount");
			channelMetric.PubUserCount = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.ChannelMetric.PubUserCount");
			channelMetric.SubUserCount = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.ChannelMetric.SubUserCount");
			channelMetric.StartTime = _ctx.StringValue("DescribeRtcChannelMetric.ChannelMetricInfo.ChannelMetric.StartTime");
			channelMetric.EndTime = _ctx.StringValue("DescribeRtcChannelMetric.ChannelMetricInfo.ChannelMetric.EndTime");
			channelMetricInfo.ChannelMetric = channelMetric;

			DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo.DescribeRtcChannelMetric_Duration duration = new DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo.DescribeRtcChannelMetric_Duration();

			DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo.DescribeRtcChannelMetric_Duration.DescribeRtcChannelMetric_PubDuration pubDuration = new DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo.DescribeRtcChannelMetric_Duration.DescribeRtcChannelMetric_PubDuration();
			pubDuration.Audio = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.PubDuration.Audio");
			pubDuration.Video360 = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.PubDuration.Video360");
			pubDuration.Video720 = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.PubDuration.Video720");
			pubDuration.Video1080 = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.PubDuration.Video1080");
			pubDuration.Content = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.PubDuration.Content");
			duration.PubDuration = pubDuration;

			DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo.DescribeRtcChannelMetric_Duration.DescribeRtcChannelMetric_SubDuration subDuration = new DescribeRtcChannelMetricResponse.DescribeRtcChannelMetric_ChannelMetricInfo.DescribeRtcChannelMetric_Duration.DescribeRtcChannelMetric_SubDuration();
			subDuration.Audio = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.SubDuration.Audio");
			subDuration.Video360 = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.SubDuration.Video360");
			subDuration.Video720 = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.SubDuration.Video720");
			subDuration.Video1080 = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.SubDuration.Video1080");
			subDuration.Content = _ctx.IntegerValue("DescribeRtcChannelMetric.ChannelMetricInfo.Duration.SubDuration.Content");
			duration.SubDuration = subDuration;
			channelMetricInfo.Duration = duration;
			describeRtcChannelMetricResponse.ChannelMetricInfo = channelMetricInfo;
        
			return describeRtcChannelMetricResponse;
        }
    }
}
