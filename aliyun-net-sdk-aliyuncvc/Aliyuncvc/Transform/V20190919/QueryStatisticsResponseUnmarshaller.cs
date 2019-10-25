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
using Aliyun.Acs.aliyuncvc.Model.V20190919;

namespace Aliyun.Acs.aliyuncvc.Transform.V20190919
{
    public class QueryStatisticsResponseUnmarshaller
    {
        public static QueryStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryStatisticsResponse queryStatisticsResponse = new QueryStatisticsResponse();

			queryStatisticsResponse.HttpResponse = context.HttpResponse;
			queryStatisticsResponse.ErrorCode = context.IntegerValue("QueryStatistics.ErrorCode");
			queryStatisticsResponse.Message = context.StringValue("QueryStatistics.Message");
			queryStatisticsResponse.Success = context.BooleanValue("QueryStatistics.Success");
			queryStatisticsResponse.RequestId = context.StringValue("QueryStatistics.RequestId");

			QueryStatisticsResponse.QueryStatistics_Data data = new QueryStatisticsResponse.QueryStatistics_Data();

			QueryStatisticsResponse.QueryStatistics_Data.QueryStatistics_Total total = new QueryStatisticsResponse.QueryStatistics_Data.QueryStatistics_Total();
			total.MeetingNum = context.IntegerValue("QueryStatistics.Data.Total.MeetingNum");
			total.MeetingLength = context.IntegerValue("QueryStatistics.Data.Total.MeetingLength");
			total.MemberNum = context.IntegerValue("QueryStatistics.Data.Total.MemberNum");
			data.Total = total;

			List<QueryStatisticsResponse.QueryStatistics_Data.QueryStatistics_DayInfoItem> data_dayInfo = new List<QueryStatisticsResponse.QueryStatistics_Data.QueryStatistics_DayInfoItem>();
			for (int i = 0; i < context.Length("QueryStatistics.Data.DayInfo.Length"); i++) {
				QueryStatisticsResponse.QueryStatistics_Data.QueryStatistics_DayInfoItem dayInfoItem = new QueryStatisticsResponse.QueryStatistics_Data.QueryStatistics_DayInfoItem();
				dayInfoItem.MeetingNum = context.StringValue("QueryStatistics.Data.DayInfo["+ i +"].MeetingNum");
				dayInfoItem.MeetingLength = context.StringValue("QueryStatistics.Data.DayInfo["+ i +"].MeetingLength");
				dayInfoItem.MemberNum = context.StringValue("QueryStatistics.Data.DayInfo["+ i +"].MemberNum");
				dayInfoItem.Day = context.StringValue("QueryStatistics.Data.DayInfo["+ i +"].Day");

				data_dayInfo.Add(dayInfoItem);
			}
			data.DayInfo = data_dayInfo;
			queryStatisticsResponse.Data = data;
        
			return queryStatisticsResponse;
        }
    }
}
