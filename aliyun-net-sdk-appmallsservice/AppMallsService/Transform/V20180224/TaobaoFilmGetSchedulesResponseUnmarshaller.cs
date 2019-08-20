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
    public class TaobaoFilmGetSchedulesResponseUnmarshaller
    {
        public static TaobaoFilmGetSchedulesResponse Unmarshall(UnmarshallerContext context)
        {
			TaobaoFilmGetSchedulesResponse taobaoFilmGetSchedulesResponse = new TaobaoFilmGetSchedulesResponse();

			taobaoFilmGetSchedulesResponse.HttpResponse = context.HttpResponse;
			taobaoFilmGetSchedulesResponse.ErrorCode = context.StringValue("TaobaoFilmGetSchedules.ErrorCode");
			taobaoFilmGetSchedulesResponse.Msg = context.StringValue("TaobaoFilmGetSchedules.Msg");
			taobaoFilmGetSchedulesResponse.SubCode = context.StringValue("TaobaoFilmGetSchedules.SubCode");
			taobaoFilmGetSchedulesResponse.SubMsg = context.StringValue("TaobaoFilmGetSchedules.SubMsg");
			taobaoFilmGetSchedulesResponse.LogsId = context.StringValue("TaobaoFilmGetSchedules.LogsId");
			taobaoFilmGetSchedulesResponse.RequestId = context.StringValue("TaobaoFilmGetSchedules.RequestId");

			List<TaobaoFilmGetSchedulesResponse.TaobaoFilmGetSchedules_SchedulesItem> taobaoFilmGetSchedulesResponse_schedules = new List<TaobaoFilmGetSchedulesResponse.TaobaoFilmGetSchedules_SchedulesItem>();
			for (int i = 0; i < context.Length("TaobaoFilmGetSchedules.Schedules.Length"); i++) {
				TaobaoFilmGetSchedulesResponse.TaobaoFilmGetSchedules_SchedulesItem schedulesItem = new TaobaoFilmGetSchedulesResponse.TaobaoFilmGetSchedules_SchedulesItem();
				schedulesItem.CinemaId = context.LongValue("TaobaoFilmGetSchedules.Schedules["+ i +"].CinemaId");
				schedulesItem.CloseTime = context.StringValue("TaobaoFilmGetSchedules.Schedules["+ i +"].CloseTime");
				schedulesItem.HallName = context.StringValue("TaobaoFilmGetSchedules.Schedules["+ i +"].HallName");
				schedulesItem.Id = context.LongValue("TaobaoFilmGetSchedules.Schedules["+ i +"].Id");
				schedulesItem.IsExpired = context.BooleanValue("TaobaoFilmGetSchedules.Schedules["+ i +"].IsExpired");
				schedulesItem.MaxCanBuy = context.LongValue("TaobaoFilmGetSchedules.Schedules["+ i +"].MaxCanBuy");
				schedulesItem.Price = context.LongValue("TaobaoFilmGetSchedules.Schedules["+ i +"].Price");
				schedulesItem.ScheduleArea = context.StringValue("TaobaoFilmGetSchedules.Schedules["+ i +"].ScheduleArea");
				schedulesItem.SectionId = context.StringValue("TaobaoFilmGetSchedules.Schedules["+ i +"].SectionId");
				schedulesItem.ServiceFee = context.LongValue("TaobaoFilmGetSchedules.Schedules["+ i +"].ServiceFee");
				schedulesItem.ShowDate = context.StringValue("TaobaoFilmGetSchedules.Schedules["+ i +"].ShowDate");
				schedulesItem.ShowId = context.LongValue("TaobaoFilmGetSchedules.Schedules["+ i +"].ShowId");
				schedulesItem.ShowTime = context.StringValue("TaobaoFilmGetSchedules.Schedules["+ i +"].ShowTime");
				schedulesItem.ShowVersion = context.StringValue("TaobaoFilmGetSchedules.Schedules["+ i +"].ShowVersion");
				schedulesItem.HallId = context.StringValue("TaobaoFilmGetSchedules.Schedules["+ i +"].HallId");

				taobaoFilmGetSchedulesResponse_schedules.Add(schedulesItem);
			}
			taobaoFilmGetSchedulesResponse.Schedules = taobaoFilmGetSchedulesResponse_schedules;
        
			return taobaoFilmGetSchedulesResponse;
        }
    }
}
