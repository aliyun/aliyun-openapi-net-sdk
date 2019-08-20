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
    public class TaobaoFilmUnLockSeatResponseUnmarshaller
    {
        public static TaobaoFilmUnLockSeatResponse Unmarshall(UnmarshallerContext context)
        {
			TaobaoFilmUnLockSeatResponse taobaoFilmUnLockSeatResponse = new TaobaoFilmUnLockSeatResponse();

			taobaoFilmUnLockSeatResponse.HttpResponse = context.HttpResponse;
			taobaoFilmUnLockSeatResponse.ErrorCode = context.StringValue("TaobaoFilmUnLockSeat.ErrorCode");
			taobaoFilmUnLockSeatResponse.Msg = context.StringValue("TaobaoFilmUnLockSeat.Msg");
			taobaoFilmUnLockSeatResponse.SubCode = context.StringValue("TaobaoFilmUnLockSeat.SubCode");
			taobaoFilmUnLockSeatResponse.SubMsg = context.StringValue("TaobaoFilmUnLockSeat.SubMsg");
			taobaoFilmUnLockSeatResponse.ReturnCode = context.StringValue("TaobaoFilmUnLockSeat.ReturnCode");
			taobaoFilmUnLockSeatResponse.ReturnMessage = context.StringValue("TaobaoFilmUnLockSeat.ReturnMessage");
			taobaoFilmUnLockSeatResponse.ReturnValue = context.BooleanValue("TaobaoFilmUnLockSeat.ReturnValue");
			taobaoFilmUnLockSeatResponse.LogsId = context.StringValue("TaobaoFilmUnLockSeat.LogsId");
			taobaoFilmUnLockSeatResponse.RequestId = context.StringValue("TaobaoFilmUnLockSeat.RequestId");
        
			return taobaoFilmUnLockSeatResponse;
        }
    }
}
