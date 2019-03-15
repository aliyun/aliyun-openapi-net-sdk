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
    public class DescribeStatisResponseUnmarshaller
    {
        public static DescribeStatisResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStatisResponse describeStatisResponse = new DescribeStatisResponse();

			describeStatisResponse.HttpResponse = context.HttpResponse;
			describeStatisResponse.RequestId = context.StringValue("DescribeStatis.RequestId");

			List<DescribeStatisResponse.DescribeStatis_StatisInfo> describeStatisResponse_statisInfos = new List<DescribeStatisResponse.DescribeStatis_StatisInfo>();
			for (int i = 0; i < context.Length("DescribeStatis.StatisInfos.Length"); i++) {
				DescribeStatisResponse.DescribeStatis_StatisInfo statisInfo = new DescribeStatisResponse.DescribeStatis_StatisInfo();
				statisInfo.Time = context.StringValue("DescribeStatis.StatisInfos["+ i +"].Time");

				List<DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_DurationItem> statisInfo_duration = new List<DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_DurationItem>();
				for (int j = 0; j < context.Length("DescribeStatis.StatisInfos["+ i +"].Duration.Length"); j++) {
					DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_DurationItem durationItem = new DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_DurationItem();
					durationItem.TotalDuration = context.FloatValue("DescribeStatis.StatisInfos["+ i +"].Duration["+ j +"].TotalDuration");
					durationItem.AudioDuration = context.FloatValue("DescribeStatis.StatisInfos["+ i +"].Duration["+ j +"].AudioDuration");
					durationItem.SdDuration = context.FloatValue("DescribeStatis.StatisInfos["+ i +"].Duration["+ j +"].SdDuration");
					durationItem.HdDuration = context.FloatValue("DescribeStatis.StatisInfos["+ i +"].Duration["+ j +"].HdDuration");
					durationItem.FhdDuration = context.FloatValue("DescribeStatis.StatisInfos["+ i +"].Duration["+ j +"].FhdDuration");

					statisInfo_duration.Add(durationItem);
				}
				statisInfo.Duration = statisInfo_duration;

				List<DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_UserStatisItem> statisInfo_userStatis = new List<DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_UserStatisItem>();
				for (int j = 0; j < context.Length("DescribeStatis.StatisInfos["+ i +"].UserStatis.Length"); j++) {
					DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_UserStatisItem userStatisItem = new DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_UserStatisItem();
					userStatisItem.ActiveUserCnt = context.LongValue("DescribeStatis.StatisInfos["+ i +"].UserStatis["+ j +"].ActiveUserCnt");
					userStatisItem.ConSessionPeak = context.LongValue("DescribeStatis.StatisInfos["+ i +"].UserStatis["+ j +"].ConSessionPeak");
					userStatisItem.ConSessionPeakTime = context.StringValue("DescribeStatis.StatisInfos["+ i +"].UserStatis["+ j +"].ConSessionPeakTime");

					statisInfo_userStatis.Add(userStatisItem);
				}
				statisInfo.UserStatis = statisInfo_userStatis;

				List<DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_ChannelStatisItem> statisInfo_channelStatis = new List<DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_ChannelStatisItem>();
				for (int j = 0; j < context.Length("DescribeStatis.StatisInfos["+ i +"].ChannelStatis.Length"); j++) {
					DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_ChannelStatisItem channelStatisItem = new DescribeStatisResponse.DescribeStatis_StatisInfo.DescribeStatis_ChannelStatisItem();
					channelStatisItem.AccChannelCnt = context.LongValue("DescribeStatis.StatisInfos["+ i +"].ChannelStatis["+ j +"].AccChannelCnt");
					channelStatisItem.ConChannelPeak = context.LongValue("DescribeStatis.StatisInfos["+ i +"].ChannelStatis["+ j +"].ConChannelPeak");
					channelStatisItem.ConChannelPeakTime = context.StringValue("DescribeStatis.StatisInfos["+ i +"].ChannelStatis["+ j +"].ConChannelPeakTime");

					statisInfo_channelStatis.Add(channelStatisItem);
				}
				statisInfo.ChannelStatis = statisInfo_channelStatis;

				describeStatisResponse_statisInfos.Add(statisInfo);
			}
			describeStatisResponse.StatisInfos = describeStatisResponse_statisInfos;
        
			return describeStatisResponse;
        }
    }
}
