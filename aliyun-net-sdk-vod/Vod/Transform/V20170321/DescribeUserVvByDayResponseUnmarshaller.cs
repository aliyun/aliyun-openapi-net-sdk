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
    public class DescribeUserVvByDayResponseUnmarshaller
    {
        public static DescribeUserVvByDayResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserVvByDayResponse describeUserVvByDayResponse = new DescribeUserVvByDayResponse();

			describeUserVvByDayResponse.HttpResponse = context.HttpResponse;
			describeUserVvByDayResponse.RequestId = context.StringValue("DescribeUserVvByDay.RequestId");

			List<DescribeUserVvByDayResponse.DescribeUserVvByDay_UserPlayStatisticsInfo> describeUserVvByDayResponse_userPlayStatisticsInfos = new List<DescribeUserVvByDayResponse.DescribeUserVvByDay_UserPlayStatisticsInfo>();
			for (int i = 0; i < context.Length("DescribeUserVvByDay.UserPlayStatisticsInfos.Length"); i++) {
				DescribeUserVvByDayResponse.DescribeUserVvByDay_UserPlayStatisticsInfo userPlayStatisticsInfo = new DescribeUserVvByDayResponse.DescribeUserVvByDay_UserPlayStatisticsInfo();
				userPlayStatisticsInfo.Date = context.StringValue("DescribeUserVvByDay.UserPlayStatisticsInfos["+ i +"].Date");
				userPlayStatisticsInfo.Android = context.StringValue("DescribeUserVvByDay.UserPlayStatisticsInfos["+ i +"].Android");
				userPlayStatisticsInfo.Ios = context.StringValue("DescribeUserVvByDay.UserPlayStatisticsInfos["+ i +"].Ios");
				userPlayStatisticsInfo.H5 = context.StringValue("DescribeUserVvByDay.UserPlayStatisticsInfos["+ i +"].H5");
				userPlayStatisticsInfo.Flash = context.StringValue("DescribeUserVvByDay.UserPlayStatisticsInfos["+ i +"].Flash");

				describeUserVvByDayResponse_userPlayStatisticsInfos.Add(userPlayStatisticsInfo);
			}
			describeUserVvByDayResponse.UserPlayStatisticsInfos = describeUserVvByDayResponse_userPlayStatisticsInfos;
        
			return describeUserVvByDayResponse;
        }
    }
}