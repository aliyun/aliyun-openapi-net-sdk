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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class GetBaseStrategyPeriodResponseUnmarshaller
    {
        public static GetBaseStrategyPeriodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetBaseStrategyPeriodResponse getBaseStrategyPeriodResponse = new GetBaseStrategyPeriodResponse();

			getBaseStrategyPeriodResponse.HttpResponse = _ctx.HttpResponse;
			getBaseStrategyPeriodResponse.HttpStatusCode = _ctx.IntegerValue("GetBaseStrategyPeriod.HttpStatusCode");
			getBaseStrategyPeriodResponse.OnlyWeekdays = _ctx.BooleanValue("GetBaseStrategyPeriod.OnlyWeekdays");
			getBaseStrategyPeriodResponse.RequestId = _ctx.StringValue("GetBaseStrategyPeriod.RequestId");
			getBaseStrategyPeriodResponse.Success = _ctx.BooleanValue("GetBaseStrategyPeriod.Success");
			getBaseStrategyPeriodResponse.Code = _ctx.StringValue("GetBaseStrategyPeriod.Code");
			getBaseStrategyPeriodResponse.Message = _ctx.StringValue("GetBaseStrategyPeriod.Message");

			List<GetBaseStrategyPeriodResponse.GetBaseStrategyPeriod_TimeFrame> getBaseStrategyPeriodResponse_workingTime = new List<GetBaseStrategyPeriodResponse.GetBaseStrategyPeriod_TimeFrame>();
			for (int i = 0; i < _ctx.Length("GetBaseStrategyPeriod.WorkingTime.Length"); i++) {
				GetBaseStrategyPeriodResponse.GetBaseStrategyPeriod_TimeFrame timeFrame = new GetBaseStrategyPeriodResponse.GetBaseStrategyPeriod_TimeFrame();
				timeFrame.EndTime = _ctx.StringValue("GetBaseStrategyPeriod.WorkingTime["+ i +"].EndTime");
				timeFrame.BeginTimeMillis = _ctx.LongValue("GetBaseStrategyPeriod.WorkingTime["+ i +"].BeginTimeMillis");
				timeFrame.EndTimeMillis = _ctx.LongValue("GetBaseStrategyPeriod.WorkingTime["+ i +"].EndTimeMillis");
				timeFrame.BeginTime = _ctx.StringValue("GetBaseStrategyPeriod.WorkingTime["+ i +"].BeginTime");

				getBaseStrategyPeriodResponse_workingTime.Add(timeFrame);
			}
			getBaseStrategyPeriodResponse.WorkingTime = getBaseStrategyPeriodResponse_workingTime;
        
			return getBaseStrategyPeriodResponse;
        }
    }
}
