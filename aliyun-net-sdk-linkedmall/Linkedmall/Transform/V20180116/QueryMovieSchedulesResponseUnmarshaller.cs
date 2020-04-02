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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryMovieSchedulesResponseUnmarshaller
    {
        public static QueryMovieSchedulesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMovieSchedulesResponse queryMovieSchedulesResponse = new QueryMovieSchedulesResponse();

			queryMovieSchedulesResponse.HttpResponse = context.HttpResponse;
			queryMovieSchedulesResponse.RequestId = context.StringValue("QueryMovieSchedules.RequestId");
			queryMovieSchedulesResponse.LogsId = context.StringValue("QueryMovieSchedules.LogsId");
			queryMovieSchedulesResponse.SubCode = context.StringValue("QueryMovieSchedules.SubCode");
			queryMovieSchedulesResponse.SubMessage = context.StringValue("QueryMovieSchedules.SubMessage");
			queryMovieSchedulesResponse.Code = context.StringValue("QueryMovieSchedules.Code");
			queryMovieSchedulesResponse.Success = context.BooleanValue("QueryMovieSchedules.Success");
			queryMovieSchedulesResponse.Message = context.StringValue("QueryMovieSchedules.Message");

			List<QueryMovieSchedulesResponse.QueryMovieSchedules_Schedule> queryMovieSchedulesResponse_schedules = new List<QueryMovieSchedulesResponse.QueryMovieSchedules_Schedule>();
			for (int i = 0; i < context.Length("QueryMovieSchedules.Schedules.Length"); i++) {
				QueryMovieSchedulesResponse.QueryMovieSchedules_Schedule schedule = new QueryMovieSchedulesResponse.QueryMovieSchedules_Schedule();
				schedule.CinemaId = context.LongValue("QueryMovieSchedules.Schedules["+ i +"].CinemaId");
				schedule.SessionEndingTime = context.StringValue("QueryMovieSchedules.Schedules["+ i +"].SessionEndingTime");
				schedule.HallName = context.StringValue("QueryMovieSchedules.Schedules["+ i +"].HallName");
				schedule.Id = context.LongValue("QueryMovieSchedules.Schedules["+ i +"].Id");
				schedule.IsExpired = context.BooleanValue("QueryMovieSchedules.Schedules["+ i +"].IsExpired");
				schedule.MaxCanBuy = context.LongValue("QueryMovieSchedules.Schedules["+ i +"].MaxCanBuy");
				schedule.Price = context.LongValue("QueryMovieSchedules.Schedules["+ i +"].Price");
				schedule.ScheduleArea = context.StringValue("QueryMovieSchedules.Schedules["+ i +"].ScheduleArea");
				schedule.SectionId = context.StringValue("QueryMovieSchedules.Schedules["+ i +"].SectionId");
				schedule.ServiceFee = context.LongValue("QueryMovieSchedules.Schedules["+ i +"].ServiceFee");
				schedule.ReleaseDate = context.StringValue("QueryMovieSchedules.Schedules["+ i +"].ReleaseDate");
				schedule.MovieId = context.LongValue("QueryMovieSchedules.Schedules["+ i +"].MovieId");
				schedule.SessionStartingTime = context.StringValue("QueryMovieSchedules.Schedules["+ i +"].SessionStartingTime");
				schedule.MovieVersion = context.StringValue("QueryMovieSchedules.Schedules["+ i +"].MovieVersion");

				queryMovieSchedulesResponse_schedules.Add(schedule);
			}
			queryMovieSchedulesResponse.Schedules = queryMovieSchedulesResponse_schedules;
        
			return queryMovieSchedulesResponse;
        }
    }
}
