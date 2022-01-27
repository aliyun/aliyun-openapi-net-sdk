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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class QueryIncomeTrendResponseUnmarshaller
    {
        public static QueryIncomeTrendResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryIncomeTrendResponse queryIncomeTrendResponse = new QueryIncomeTrendResponse();

			queryIncomeTrendResponse.HttpResponse = _ctx.HttpResponse;
			queryIncomeTrendResponse.Code = _ctx.StringValue("QueryIncomeTrend.Code");
			queryIncomeTrendResponse.Success = _ctx.BooleanValue("QueryIncomeTrend.Success");
			queryIncomeTrendResponse.Message = _ctx.StringValue("QueryIncomeTrend.Message");
			queryIncomeTrendResponse.RequestId = _ctx.StringValue("QueryIncomeTrend.RequestId");
			queryIncomeTrendResponse.PageNumber = _ctx.IntegerValue("QueryIncomeTrend.PageNumber");
			queryIncomeTrendResponse.PageSize = _ctx.IntegerValue("QueryIncomeTrend.PageSize");
			queryIncomeTrendResponse.Total = _ctx.LongValue("QueryIncomeTrend.Total");

			List<QueryIncomeTrendResponse.QueryIncomeTrend_Data> queryIncomeTrendResponse_model = new List<QueryIncomeTrendResponse.QueryIncomeTrend_Data>();
			for (int i = 0; i < _ctx.Length("QueryIncomeTrend.Model.Length"); i++) {
				QueryIncomeTrendResponse.QueryIncomeTrend_Data data = new QueryIncomeTrendResponse.QueryIncomeTrend_Data();
				data.StartTime = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].StartTime");
				data.EndTime = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].EndTime");
				data.MediaId = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].MediaId");
				data.MediaName = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].MediaName");
				data.AdSlotType = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].AdSlotType");
				data.AdSlotId = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].AdSlotId");
				data.AdSlotName = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].AdSlotName");
				data.EstimatedIncome = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].EstimatedIncome");
				data.AdSlotRequests = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].AdSlotRequests");
				data.AccessStatus = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].AccessStatus");
				data.AdSlotHitTimes = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].AdSlotHitTimes");
				data.ShowTimes = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].ShowTimes");
				data.ClickTimes = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].ClickTimes");
				data.ChannelId = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].ChannelId");
				data.ChannelName = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].ChannelName");
				data.BizDate = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].BizDate");
				data.ThisDaysEstIncome = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].ThisDaysEstIncome");
				data.AdSlotHitRate = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].AdSlotHitRate");
				data.AdSlotShowRate = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].AdSlotShowRate");
				data.AdSlotClickRate = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].AdSlotClickRate");
				data.Ecpm = _ctx.LongValue("QueryIncomeTrend.Model["+ i +"].Ecpm");
				data.EcpmRate = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].EcpmRate");
				data.ThisDaysEstIncomeRate = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].ThisDaysEstIncomeRate");
				data.ThisMonEstIncomeRate = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].ThisMonEstIncomeRate");
				data.ThisYearEstIncomeRate = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].ThisYearEstIncomeRate");
				data.AccEstIncomeRate = _ctx.StringValue("QueryIncomeTrend.Model["+ i +"].AccEstIncomeRate");

				queryIncomeTrendResponse_model.Add(data);
			}
			queryIncomeTrendResponse.Model = queryIncomeTrendResponse_model;
        
			return queryIncomeTrendResponse;
        }
    }
}
