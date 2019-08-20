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
    public class TaobaoFilmGetSeatsResponseUnmarshaller
    {
        public static TaobaoFilmGetSeatsResponse Unmarshall(UnmarshallerContext context)
        {
			TaobaoFilmGetSeatsResponse taobaoFilmGetSeatsResponse = new TaobaoFilmGetSeatsResponse();

			taobaoFilmGetSeatsResponse.HttpResponse = context.HttpResponse;
			taobaoFilmGetSeatsResponse.ErrorCode = context.StringValue("TaobaoFilmGetSeats.ErrorCode");
			taobaoFilmGetSeatsResponse.Msg = context.StringValue("TaobaoFilmGetSeats.Msg");
			taobaoFilmGetSeatsResponse.SubCode = context.StringValue("TaobaoFilmGetSeats.SubCode");
			taobaoFilmGetSeatsResponse.SubMsg = context.StringValue("TaobaoFilmGetSeats.SubMsg");
			taobaoFilmGetSeatsResponse.LogsId = context.StringValue("TaobaoFilmGetSeats.LogsId");
			taobaoFilmGetSeatsResponse.RequestId = context.StringValue("TaobaoFilmGetSeats.RequestId");

			TaobaoFilmGetSeatsResponse.TaobaoFilmGetSeats_SeatMap seatMap = new TaobaoFilmGetSeatsResponse.TaobaoFilmGetSeats_SeatMap();
			seatMap.MaxCanBuy = context.LongValue("TaobaoFilmGetSeats.SeatMap.MaxCanBuy");
			seatMap.MaxColumn = context.LongValue("TaobaoFilmGetSeats.SeatMap.MaxColumn");
			seatMap.MaxLeftPx = context.LongValue("TaobaoFilmGetSeats.SeatMap.MaxLeftPx");
			seatMap.MaxRow = context.LongValue("TaobaoFilmGetSeats.SeatMap.MaxRow");
			seatMap.MaxTopPx = context.LongValue("TaobaoFilmGetSeats.SeatMap.MaxTopPx");
			seatMap.MinColumn = context.LongValue("TaobaoFilmGetSeats.SeatMap.MinColumn");
			seatMap.MinLeftPx = context.LongValue("TaobaoFilmGetSeats.SeatMap.MinLeftPx");
			seatMap.MinRow = context.LongValue("TaobaoFilmGetSeats.SeatMap.MinRow");
			seatMap.MinTopPx = context.LongValue("TaobaoFilmGetSeats.SeatMap.MinTopPx");
			seatMap.Notice = context.StringValue("TaobaoFilmGetSeats.SeatMap.Notice");
			seatMap.Regular = context.BooleanValue("TaobaoFilmGetSeats.SeatMap.Regular");
			seatMap.SeatCount = context.LongValue("TaobaoFilmGetSeats.SeatMap.SeatCount");
			seatMap.SoldCount = context.LongValue("TaobaoFilmGetSeats.SeatMap.SoldCount");
			seatMap.TipMessage = context.StringValue("TaobaoFilmGetSeats.SeatMap.TipMessage");

			List<TaobaoFilmGetSeatsResponse.TaobaoFilmGetSeats_SeatMap.TaobaoFilmGetSeats_SeatsItem> seatMap_seats = new List<TaobaoFilmGetSeatsResponse.TaobaoFilmGetSeats_SeatMap.TaobaoFilmGetSeats_SeatsItem>();
			for (int i = 0; i < context.Length("TaobaoFilmGetSeats.SeatMap.Seats.Length"); i++) {
				TaobaoFilmGetSeatsResponse.TaobaoFilmGetSeats_SeatMap.TaobaoFilmGetSeats_SeatsItem seatsItem = new TaobaoFilmGetSeatsResponse.TaobaoFilmGetSeats_SeatMap.TaobaoFilmGetSeats_SeatsItem();
				seatsItem.Area = context.StringValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].Area");
				seatsItem.Column = context.LongValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].Column");
				seatsItem.ExtId = context.StringValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].ExtId");
				seatsItem.Flag = context.LongValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].Flag");
				seatsItem.LeftPx = context.LongValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].LeftPx");
				seatsItem.Name = context.StringValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].Name");
				seatsItem.Row = context.LongValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].Row");
				seatsItem.RowName = context.StringValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].RowName");
				seatsItem.Status = context.LongValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].Status");
				seatsItem.TopPx = context.LongValue("TaobaoFilmGetSeats.SeatMap.Seats["+ i +"].TopPx");

				seatMap_seats.Add(seatsItem);
			}
			seatMap.Seats = seatMap_seats;
			taobaoFilmGetSeatsResponse.SeatMap = seatMap;
        
			return taobaoFilmGetSeatsResponse;
        }
    }
}
