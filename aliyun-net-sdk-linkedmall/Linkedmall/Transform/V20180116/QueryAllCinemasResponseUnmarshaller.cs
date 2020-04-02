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
    public class QueryAllCinemasResponseUnmarshaller
    {
        public static QueryAllCinemasResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAllCinemasResponse queryAllCinemasResponse = new QueryAllCinemasResponse();

			queryAllCinemasResponse.HttpResponse = context.HttpResponse;
			queryAllCinemasResponse.RequestId = context.StringValue("QueryAllCinemas.RequestId");
			queryAllCinemasResponse.Code = context.StringValue("QueryAllCinemas.Code");
			queryAllCinemasResponse.Message = context.StringValue("QueryAllCinemas.Message");
			queryAllCinemasResponse.SubCode = context.StringValue("QueryAllCinemas.SubCode");
			queryAllCinemasResponse.SubMessage = context.StringValue("QueryAllCinemas.SubMessage");
			queryAllCinemasResponse.LogsId = context.StringValue("QueryAllCinemas.LogsId");
			queryAllCinemasResponse.Success = context.BooleanValue("QueryAllCinemas.Success");
			queryAllCinemasResponse.TotalCount = context.LongValue("QueryAllCinemas.TotalCount");

			List<QueryAllCinemasResponse.QueryAllCinemas_Cinema> queryAllCinemasResponse_cinemas = new List<QueryAllCinemasResponse.QueryAllCinemas_Cinema>();
			for (int i = 0; i < context.Length("QueryAllCinemas.Cinemas.Length"); i++) {
				QueryAllCinemasResponse.QueryAllCinemas_Cinema cinema = new QueryAllCinemasResponse.QueryAllCinemas_Cinema();
				cinema.CityId = context.LongValue("QueryAllCinemas.Cinemas["+ i +"].CityId");
				cinema.CityName = context.StringValue("QueryAllCinemas.Cinemas["+ i +"].CityName");
				cinema.ScheduleCloseTime = context.LongValue("QueryAllCinemas.Cinemas["+ i +"].ScheduleCloseTime");
				cinema.Latitude = context.StringValue("QueryAllCinemas.Cinemas["+ i +"].Latitude");
				cinema.Longitude = context.StringValue("QueryAllCinemas.Cinemas["+ i +"].Longitude");
				cinema.CinemaName = context.StringValue("QueryAllCinemas.Cinemas["+ i +"].CinemaName");
				cinema.Address = context.StringValue("QueryAllCinemas.Cinemas["+ i +"].Address");
				cinema.Id = context.LongValue("QueryAllCinemas.Cinemas["+ i +"].Id");
				cinema.Phone = context.StringValue("QueryAllCinemas.Cinemas["+ i +"].Phone");
				cinema.StandardId = context.StringValue("QueryAllCinemas.Cinemas["+ i +"].StandardId");

				queryAllCinemasResponse_cinemas.Add(cinema);
			}
			queryAllCinemasResponse.Cinemas = queryAllCinemasResponse_cinemas;
        
			return queryAllCinemasResponse;
        }
    }
}
