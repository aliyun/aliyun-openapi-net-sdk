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
    public class DescribeUserAvgTimeByDayResponseUnmarshaller
    {
        public static DescribeUserAvgTimeByDayResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserAvgTimeByDayResponse describeUserAvgTimeByDayResponse = new DescribeUserAvgTimeByDayResponse();

			describeUserAvgTimeByDayResponse.HttpResponse = context.HttpResponse;
			describeUserAvgTimeByDayResponse.RequestId = context.StringValue("DescribeUserAvgTimeByDay.RequestId");

			List<DescribeUserAvgTimeByDayResponse.DescribeUserAvgTimeByDay_UserPlayStatisticsInfo> describeUserAvgTimeByDayResponse_userPlayStatisticsInfos = new List<DescribeUserAvgTimeByDayResponse.DescribeUserAvgTimeByDay_UserPlayStatisticsInfo>();
			for (int i = 0; i < context.Length("DescribeUserAvgTimeByDay.UserPlayStatisticsInfos.Length"); i++) {
				DescribeUserAvgTimeByDayResponse.DescribeUserAvgTimeByDay_UserPlayStatisticsInfo userPlayStatisticsInfo = new DescribeUserAvgTimeByDayResponse.DescribeUserAvgTimeByDay_UserPlayStatisticsInfo();
				userPlayStatisticsInfo.Date = context.StringValue("DescribeUserAvgTimeByDay.UserPlayStatisticsInfos["+ i +"].Date");
				userPlayStatisticsInfo.All = context.StringValue("DescribeUserAvgTimeByDay.UserPlayStatisticsInfos["+ i +"].All");

				describeUserAvgTimeByDayResponse_userPlayStatisticsInfos.Add(userPlayStatisticsInfo);
			}
			describeUserAvgTimeByDayResponse.UserPlayStatisticsInfos = describeUserAvgTimeByDayResponse_userPlayStatisticsInfos;
        
			return describeUserAvgTimeByDayResponse;
        }
    }
}