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
    public class DescribeUserAvgCountByDayResponseUnmarshaller
    {
        public static DescribeUserAvgCountByDayResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserAvgCountByDayResponse describeUserAvgCountByDayResponse = new DescribeUserAvgCountByDayResponse();

			describeUserAvgCountByDayResponse.HttpResponse = context.HttpResponse;
			describeUserAvgCountByDayResponse.RequestId = context.StringValue("DescribeUserAvgCountByDay.RequestId");

			List<DescribeUserAvgCountByDayResponse.DescribeUserAvgCountByDay_UserPlayStatisticsInfo> describeUserAvgCountByDayResponse_userPlayStatisticsInfos = new List<DescribeUserAvgCountByDayResponse.DescribeUserAvgCountByDay_UserPlayStatisticsInfo>();
			for (int i = 0; i < context.Length("DescribeUserAvgCountByDay.UserPlayStatisticsInfos.Length"); i++) {
				DescribeUserAvgCountByDayResponse.DescribeUserAvgCountByDay_UserPlayStatisticsInfo userPlayStatisticsInfo = new DescribeUserAvgCountByDayResponse.DescribeUserAvgCountByDay_UserPlayStatisticsInfo();
				userPlayStatisticsInfo.Date = context.StringValue("DescribeUserAvgCountByDay.UserPlayStatisticsInfos["+ i +"].Date");
				userPlayStatisticsInfo.All = context.StringValue("DescribeUserAvgCountByDay.UserPlayStatisticsInfos["+ i +"].All");

				describeUserAvgCountByDayResponse_userPlayStatisticsInfos.Add(userPlayStatisticsInfo);
			}
			describeUserAvgCountByDayResponse.UserPlayStatisticsInfos = describeUserAvgCountByDayResponse_userPlayStatisticsInfos;
        
			return describeUserAvgCountByDayResponse;
        }
    }
}