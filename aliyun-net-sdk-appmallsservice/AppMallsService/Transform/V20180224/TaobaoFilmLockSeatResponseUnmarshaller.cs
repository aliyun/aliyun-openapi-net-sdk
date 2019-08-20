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
    public class TaobaoFilmLockSeatResponseUnmarshaller
    {
        public static TaobaoFilmLockSeatResponse Unmarshall(UnmarshallerContext context)
        {
			TaobaoFilmLockSeatResponse taobaoFilmLockSeatResponse = new TaobaoFilmLockSeatResponse();

			taobaoFilmLockSeatResponse.HttpResponse = context.HttpResponse;
			taobaoFilmLockSeatResponse.ErrorCode = context.StringValue("TaobaoFilmLockSeat.ErrorCode");
			taobaoFilmLockSeatResponse.Msg = context.StringValue("TaobaoFilmLockSeat.Msg");
			taobaoFilmLockSeatResponse.SubCode = context.StringValue("TaobaoFilmLockSeat.SubCode");
			taobaoFilmLockSeatResponse.SubMsg = context.StringValue("TaobaoFilmLockSeat.SubMsg");
			taobaoFilmLockSeatResponse.LogsId = context.StringValue("TaobaoFilmLockSeat.LogsId");
			taobaoFilmLockSeatResponse.RequestId = context.StringValue("TaobaoFilmLockSeat.RequestId");

			TaobaoFilmLockSeatResponse.TaobaoFilmLockSeat_SeatLocked seatLocked = new TaobaoFilmLockSeatResponse.TaobaoFilmLockSeat_SeatLocked();
			seatLocked.ApplyKey = context.StringValue("TaobaoFilmLockSeat.SeatLocked.ApplyKey");
			seatLocked.DefaultLockSecond = context.LongValue("TaobaoFilmLockSeat.SeatLocked.DefaultLockSecond");
			seatLocked.LockTime = context.LongValue("TaobaoFilmLockSeat.SeatLocked.LockTime");
			seatLocked.Status = context.StringValue("TaobaoFilmLockSeat.SeatLocked.Status");
			taobaoFilmLockSeatResponse.SeatLocked = seatLocked;
        
			return taobaoFilmLockSeatResponse;
        }
    }
}
