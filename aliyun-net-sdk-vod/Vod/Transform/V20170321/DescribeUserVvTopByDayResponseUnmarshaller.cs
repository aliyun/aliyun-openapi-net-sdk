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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeUserVvTopByDayResponseUnmarshaller
    {
        public static DescribeUserVvTopByDayResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserVvTopByDayResponse describeUserVvTopByDayResponse = new DescribeUserVvTopByDayResponse();

			describeUserVvTopByDayResponse.HttpResponse = context.HttpResponse;
			describeUserVvTopByDayResponse.RequestId = context.StringValue("DescribeUserVvTopByDay.RequestId");

			List<DescribeUserVvTopByDayResponse.DescribeUserVvTopByDay_UserPlayStatisticsInfo> describeUserVvTopByDayResponse_userPlayStatisticsInfos = new List<DescribeUserVvTopByDayResponse.DescribeUserVvTopByDay_UserPlayStatisticsInfo>();
			for (int i = 0; i < context.Length("DescribeUserVvTopByDay.UserPlayStatisticsInfos.Length"); i++) {
				DescribeUserVvTopByDayResponse.DescribeUserVvTopByDay_UserPlayStatisticsInfo userPlayStatisticsInfo = new DescribeUserVvTopByDayResponse.DescribeUserVvTopByDay_UserPlayStatisticsInfo();
				userPlayStatisticsInfo.Count = context.StringValue("DescribeUserVvTopByDay.UserPlayStatisticsInfos["+ i +"].Count");
				userPlayStatisticsInfo.Videoid = context.StringValue("DescribeUserVvTopByDay.UserPlayStatisticsInfos["+ i +"].Videoid");
				userPlayStatisticsInfo.VideoName = context.StringValue("DescribeUserVvTopByDay.UserPlayStatisticsInfos["+ i +"].VideoName");

				describeUserVvTopByDayResponse_userPlayStatisticsInfos.Add(userPlayStatisticsInfo);
			}
			describeUserVvTopByDayResponse.UserPlayStatisticsInfos = describeUserVvTopByDayResponse_userPlayStatisticsInfos;
        
			return describeUserVvTopByDayResponse;
        }
    }
}