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
    public class QueryMovieSeatsResponseUnmarshaller
    {
        public static QueryMovieSeatsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMovieSeatsResponse queryMovieSeatsResponse = new QueryMovieSeatsResponse();

			queryMovieSeatsResponse.HttpResponse = context.HttpResponse;
			queryMovieSeatsResponse.RequestId = context.StringValue("QueryMovieSeats.RequestId");
			queryMovieSeatsResponse.Code = context.StringValue("QueryMovieSeats.Code");
			queryMovieSeatsResponse.Message = context.StringValue("QueryMovieSeats.Message");
			queryMovieSeatsResponse.SubCode = context.StringValue("QueryMovieSeats.SubCode");
			queryMovieSeatsResponse.SubMessage = context.StringValue("QueryMovieSeats.SubMessage");
			queryMovieSeatsResponse.LogsId = context.StringValue("QueryMovieSeats.LogsId");
			queryMovieSeatsResponse.Success = context.BooleanValue("QueryMovieSeats.Success");

			QueryMovieSeatsResponse.QueryMovieSeats_SeatMap seatMap = new QueryMovieSeatsResponse.QueryMovieSeats_SeatMap();
			seatMap.MaxCanBuy = context.LongValue("QueryMovieSeats.SeatMap.MaxCanBuy");
			seatMap.MaxColumn = context.LongValue("QueryMovieSeats.SeatMap.MaxColumn");
			seatMap.MaxLeftPx = context.LongValue("QueryMovieSeats.SeatMap.MaxLeftPx");
			seatMap.MaxRow = context.LongValue("QueryMovieSeats.SeatMap.MaxRow");
			seatMap.MaxTopPx = context.LongValue("QueryMovieSeats.SeatMap.MaxTopPx");
			seatMap.MinColumn = context.LongValue("QueryMovieSeats.SeatMap.MinColumn");
			seatMap.MinLeftPx = context.LongValue("QueryMovieSeats.SeatMap.MinLeftPx");
			seatMap.MinRow = context.LongValue("QueryMovieSeats.SeatMap.MinRow");
			seatMap.MinTopPx = context.LongValue("QueryMovieSeats.SeatMap.MinTopPx");
			seatMap.Notice = context.StringValue("QueryMovieSeats.SeatMap.Notice");
			seatMap.Regular = context.BooleanValue("QueryMovieSeats.SeatMap.Regular");
			seatMap.SeatCount = context.LongValue("QueryMovieSeats.SeatMap.SeatCount");
			seatMap.SoldCount = context.LongValue("QueryMovieSeats.SeatMap.SoldCount");
			seatMap.TipMessage = context.StringValue("QueryMovieSeats.SeatMap.TipMessage");

			List<QueryMovieSeatsResponse.QueryMovieSeats_SeatMap.QueryMovieSeats_Seat> seatMap_seats = new List<QueryMovieSeatsResponse.QueryMovieSeats_SeatMap.QueryMovieSeats_Seat>();
			for (int i = 0; i < context.Length("QueryMovieSeats.SeatMap.Seats.Length"); i++) {
				QueryMovieSeatsResponse.QueryMovieSeats_SeatMap.QueryMovieSeats_Seat seat = new QueryMovieSeatsResponse.QueryMovieSeats_SeatMap.QueryMovieSeats_Seat();
				seat.Area = context.StringValue("QueryMovieSeats.SeatMap.Seats["+ i +"].Area");
				seat.Column = context.LongValue("QueryMovieSeats.SeatMap.Seats["+ i +"].Column");
				seat.ExtId = context.StringValue("QueryMovieSeats.SeatMap.Seats["+ i +"].ExtId");
				seat.Flag = context.LongValue("QueryMovieSeats.SeatMap.Seats["+ i +"].Flag");
				seat.LeftPx = context.LongValue("QueryMovieSeats.SeatMap.Seats["+ i +"].LeftPx");
				seat.Name = context.StringValue("QueryMovieSeats.SeatMap.Seats["+ i +"].Name");
				seat.Row = context.LongValue("QueryMovieSeats.SeatMap.Seats["+ i +"].Row");
				seat.RowName = context.StringValue("QueryMovieSeats.SeatMap.Seats["+ i +"].RowName");
				seat.Status = context.LongValue("QueryMovieSeats.SeatMap.Seats["+ i +"].Status");
				seat.TopPx = context.LongValue("QueryMovieSeats.SeatMap.Seats["+ i +"].TopPx");

				seatMap_seats.Add(seat);
			}
			seatMap.Seats = seatMap_seats;
			queryMovieSeatsResponse.SeatMap = seatMap;
        
			return queryMovieSeatsResponse;
        }
    }
}
