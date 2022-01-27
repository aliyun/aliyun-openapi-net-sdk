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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class ListIsvStatisticsResponseUnmarshaller
    {
        public static ListIsvStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIsvStatisticsResponse listIsvStatisticsResponse = new ListIsvStatisticsResponse();

			listIsvStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			listIsvStatisticsResponse.ErrorCode = _ctx.IntegerValue("ListIsvStatistics.ErrorCode");
			listIsvStatisticsResponse.Message = _ctx.StringValue("ListIsvStatistics.Message");
			listIsvStatisticsResponse.Success = _ctx.BooleanValue("ListIsvStatistics.Success");
			listIsvStatisticsResponse.RequestId = _ctx.StringValue("ListIsvStatistics.RequestId");

			ListIsvStatisticsResponse.ListIsvStatistics_Data data = new ListIsvStatisticsResponse.ListIsvStatistics_Data();

			ListIsvStatisticsResponse.ListIsvStatistics_Data.ListIsvStatistics_Total total = new ListIsvStatisticsResponse.ListIsvStatistics_Data.ListIsvStatistics_Total();
			total.MeetingNumber = _ctx.IntegerValue("ListIsvStatistics.Data.Total.MeetingNumber");
			total.MeetingLength = _ctx.IntegerValue("ListIsvStatistics.Data.Total.MeetingLength");
			total.MemberNumber = _ctx.IntegerValue("ListIsvStatistics.Data.Total.MemberNumber");
			data.Total = total;

			List<ListIsvStatisticsResponse.ListIsvStatistics_Data.ListIsvStatistics_Statistic> data_statistics = new List<ListIsvStatisticsResponse.ListIsvStatistics_Data.ListIsvStatistics_Statistic>();
			for (int i = 0; i < _ctx.Length("ListIsvStatistics.Data.Statistics.Length"); i++) {
				ListIsvStatisticsResponse.ListIsvStatistics_Data.ListIsvStatistics_Statistic statistic = new ListIsvStatisticsResponse.ListIsvStatistics_Data.ListIsvStatistics_Statistic();
				statistic.MeetingNumber = _ctx.StringValue("ListIsvStatistics.Data.Statistics["+ i +"].MeetingNumber");
				statistic.MeetingLength = _ctx.StringValue("ListIsvStatistics.Data.Statistics["+ i +"].MeetingLength");
				statistic.MemberNumber = _ctx.StringValue("ListIsvStatistics.Data.Statistics["+ i +"].MemberNumber");
				statistic.Day = _ctx.StringValue("ListIsvStatistics.Data.Statistics["+ i +"].Day");

				data_statistics.Add(statistic);
			}
			data.Statistics = data_statistics;
			listIsvStatisticsResponse.Data = data;
        
			return listIsvStatisticsResponse;
        }
    }
}
