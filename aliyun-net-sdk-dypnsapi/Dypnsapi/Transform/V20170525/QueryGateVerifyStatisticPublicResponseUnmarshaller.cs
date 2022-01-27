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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class QueryGateVerifyStatisticPublicResponseUnmarshaller
    {
        public static QueryGateVerifyStatisticPublicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryGateVerifyStatisticPublicResponse queryGateVerifyStatisticPublicResponse = new QueryGateVerifyStatisticPublicResponse();

			queryGateVerifyStatisticPublicResponse.HttpResponse = _ctx.HttpResponse;
			queryGateVerifyStatisticPublicResponse.Code = _ctx.StringValue("QueryGateVerifyStatisticPublic.Code");
			queryGateVerifyStatisticPublicResponse.Message = _ctx.StringValue("QueryGateVerifyStatisticPublic.Message");
			queryGateVerifyStatisticPublicResponse.RequestId = _ctx.StringValue("QueryGateVerifyStatisticPublic.RequestId");

			QueryGateVerifyStatisticPublicResponse.QueryGateVerifyStatisticPublic_Data data = new QueryGateVerifyStatisticPublicResponse.QueryGateVerifyStatisticPublic_Data();
			data.TotalFail = _ctx.LongValue("QueryGateVerifyStatisticPublic.Data.TotalFail");
			data.Total = _ctx.LongValue("QueryGateVerifyStatisticPublic.Data.Total");
			data.TotalSuccess = _ctx.LongValue("QueryGateVerifyStatisticPublic.Data.TotalSuccess");
			data.TotalUnknown = _ctx.LongValue("QueryGateVerifyStatisticPublic.Data.TotalUnknown");

			List<QueryGateVerifyStatisticPublicResponse.QueryGateVerifyStatisticPublic_Data.QueryGateVerifyStatisticPublic_DayStatisticItem> data_dayStatistic = new List<QueryGateVerifyStatisticPublicResponse.QueryGateVerifyStatisticPublic_Data.QueryGateVerifyStatisticPublic_DayStatisticItem>();
			for (int i = 0; i < _ctx.Length("QueryGateVerifyStatisticPublic.Data.DayStatistic.Length"); i++) {
				QueryGateVerifyStatisticPublicResponse.QueryGateVerifyStatisticPublic_Data.QueryGateVerifyStatisticPublic_DayStatisticItem dayStatisticItem = new QueryGateVerifyStatisticPublicResponse.QueryGateVerifyStatisticPublic_Data.QueryGateVerifyStatisticPublic_DayStatisticItem();
				dayStatisticItem.StatisticDateStr = _ctx.StringValue("QueryGateVerifyStatisticPublic.Data.DayStatistic["+ i +"].StatisticDateStr");
				dayStatisticItem.TotalSuccess = _ctx.LongValue("QueryGateVerifyStatisticPublic.Data.DayStatistic["+ i +"].TotalSuccess");
				dayStatisticItem.TotalFail = _ctx.LongValue("QueryGateVerifyStatisticPublic.Data.DayStatistic["+ i +"].TotalFail");
				dayStatisticItem.TotalUnknown = _ctx.LongValue("QueryGateVerifyStatisticPublic.Data.DayStatistic["+ i +"].TotalUnknown");

				data_dayStatistic.Add(dayStatisticItem);
			}
			data.DayStatistic = data_dayStatistic;
			queryGateVerifyStatisticPublicResponse.Data = data;
        
			return queryGateVerifyStatisticPublicResponse;
        }
    }
}
