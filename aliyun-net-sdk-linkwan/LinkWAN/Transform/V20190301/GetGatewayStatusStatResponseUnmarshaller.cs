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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class GetGatewayStatusStatResponseUnmarshaller
    {
        public static GetGatewayStatusStatResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetGatewayStatusStatResponse getGatewayStatusStatResponse = new GetGatewayStatusStatResponse();

			getGatewayStatusStatResponse.HttpResponse = _ctx.HttpResponse;
			getGatewayStatusStatResponse.RequestId = _ctx.StringValue("GetGatewayStatusStat.RequestId");
			getGatewayStatusStatResponse.Success = _ctx.BooleanValue("GetGatewayStatusStat.Success");

			GetGatewayStatusStatResponse.GetGatewayStatusStat_Data data = new GetGatewayStatusStatResponse.GetGatewayStatusStat_Data();
			data.GwEui = _ctx.StringValue("GetGatewayStatusStat.Data.GwEui");
			data.CpuRadio = _ctx.FloatValue("GetGatewayStatusStat.Data.CpuRadio");
			data.MemoryRadio = _ctx.FloatValue("GetGatewayStatusStat.Data.MemoryRadio");
			data.RxCount = _ctx.LongValue("GetGatewayStatusStat.Data.RxCount");
			data.TxCount = _ctx.LongValue("GetGatewayStatusStat.Data.TxCount");
			data.OnlineState = _ctx.StringValue("GetGatewayStatusStat.Data.OnlineState");
			data.OnlineHour = _ctx.LongValue("GetGatewayStatusStat.Data.OnlineHour");
			data.Enabled = _ctx.BooleanValue("GetGatewayStatusStat.Data.Enabled");
			getGatewayStatusStatResponse.Data = data;
        
			return getGatewayStatusStatResponse;
        }
    }
}
