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
using Aliyun.Acs.AppMallsService.Model.V20180224;

namespace Aliyun.Acs.AppMallsService.Transform.V20180224
{
    public class TaobaoFilmGetCinemasResponseUnmarshaller
    {
        public static TaobaoFilmGetCinemasResponse Unmarshall(UnmarshallerContext context)
        {
			TaobaoFilmGetCinemasResponse taobaoFilmGetCinemasResponse = new TaobaoFilmGetCinemasResponse();

			taobaoFilmGetCinemasResponse.HttpResponse = context.HttpResponse;
			taobaoFilmGetCinemasResponse.ErrorCode = context.StringValue("TaobaoFilmGetCinemas.ErrorCode");
			taobaoFilmGetCinemasResponse.Msg = context.StringValue("TaobaoFilmGetCinemas.Msg");
			taobaoFilmGetCinemasResponse.SubCode = context.StringValue("TaobaoFilmGetCinemas.SubCode");
			taobaoFilmGetCinemasResponse.SubMsg = context.StringValue("TaobaoFilmGetCinemas.SubMsg");
			taobaoFilmGetCinemasResponse.TotalCount = context.LongValue("TaobaoFilmGetCinemas.TotalCount");
			taobaoFilmGetCinemasResponse.LogsId = context.StringValue("TaobaoFilmGetCinemas.LogsId");
			taobaoFilmGetCinemasResponse.RequestId = context.StringValue("TaobaoFilmGetCinemas.RequestId");

			List<TaobaoFilmGetCinemasResponse.TaobaoFilmGetCinemas_CinemasItem> taobaoFilmGetCinemasResponse_cinemas = new List<TaobaoFilmGetCinemasResponse.TaobaoFilmGetCinemas_CinemasItem>();
			for (int i = 0; i < context.Length("TaobaoFilmGetCinemas.Cinemas.Length"); i++) {
				TaobaoFilmGetCinemasResponse.TaobaoFilmGetCinemas_CinemasItem cinemasItem = new TaobaoFilmGetCinemasResponse.TaobaoFilmGetCinemas_CinemasItem();
				cinemasItem.Address = context.StringValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].Address");
				cinemasItem.CinemaName = context.StringValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].CinemaName");
				cinemasItem.CityId = context.LongValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].CityId");
				cinemasItem.Id = context.LongValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].Id");
				cinemasItem.Latitude = context.StringValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].Latitude");
				cinemasItem.Longitude = context.StringValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].Longitude");
				cinemasItem.Phone = context.StringValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].Phone");
				cinemasItem.RegionName = context.StringValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].RegionName");
				cinemasItem.ScheduleCloseTime = context.LongValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].ScheduleCloseTime");
				cinemasItem.StandardId = context.StringValue("TaobaoFilmGetCinemas.Cinemas["+ i +"].StandardId");

				taobaoFilmGetCinemasResponse_cinemas.Add(cinemasItem);
			}
			taobaoFilmGetCinemasResponse.Cinemas = taobaoFilmGetCinemasResponse_cinemas;
        
			return taobaoFilmGetCinemasResponse;
        }
    }
}
