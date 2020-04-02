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
    public class ReserveMovieSeatResponseUnmarshaller
    {
        public static ReserveMovieSeatResponse Unmarshall(UnmarshallerContext context)
        {
			ReserveMovieSeatResponse reserveMovieSeatResponse = new ReserveMovieSeatResponse();

			reserveMovieSeatResponse.HttpResponse = context.HttpResponse;
			reserveMovieSeatResponse.RequestId = context.StringValue("ReserveMovieSeat.RequestId");
			reserveMovieSeatResponse.Code = context.StringValue("ReserveMovieSeat.Code");
			reserveMovieSeatResponse.Message = context.StringValue("ReserveMovieSeat.Message");
			reserveMovieSeatResponse.SubCode = context.StringValue("ReserveMovieSeat.SubCode");
			reserveMovieSeatResponse.SubMessage = context.StringValue("ReserveMovieSeat.SubMessage");
			reserveMovieSeatResponse.LogsId = context.StringValue("ReserveMovieSeat.LogsId");
			reserveMovieSeatResponse.Success = context.BooleanValue("ReserveMovieSeat.Success");

			ReserveMovieSeatResponse.ReserveMovieSeat_ReservedSeat reservedSeat = new ReserveMovieSeatResponse.ReserveMovieSeat_ReservedSeat();
			reservedSeat.ApplyKey = context.StringValue("ReserveMovieSeat.ReservedSeat.ApplyKey");
			reservedSeat.DefaultLockSecond = context.LongValue("ReserveMovieSeat.ReservedSeat.DefaultLockSecond");
			reservedSeat.ReservedTime = context.LongValue("ReserveMovieSeat.ReservedSeat.ReservedTime");
			reservedSeat.Status = context.StringValue("ReserveMovieSeat.ReservedSeat.Status");
			reserveMovieSeatResponse.ReservedSeat = reservedSeat;
        
			return reserveMovieSeatResponse;
        }
    }
}
