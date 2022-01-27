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
    public class QueryIncomeDataResponseUnmarshaller
    {
        public static QueryIncomeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryIncomeDataResponse queryIncomeDataResponse = new QueryIncomeDataResponse();

			queryIncomeDataResponse.HttpResponse = _ctx.HttpResponse;
			queryIncomeDataResponse.Code = _ctx.StringValue("QueryIncomeData.Code");
			queryIncomeDataResponse.Success = _ctx.BooleanValue("QueryIncomeData.Success");
			queryIncomeDataResponse.Message = _ctx.StringValue("QueryIncomeData.Message");
			queryIncomeDataResponse.RequestId = _ctx.StringValue("QueryIncomeData.RequestId");

			QueryIncomeDataResponse.QueryIncomeData_Model model = new QueryIncomeDataResponse.QueryIncomeData_Model();
			model.StartTime = _ctx.LongValue("QueryIncomeData.Model.StartTime");
			model.EndTime = _ctx.LongValue("QueryIncomeData.Model.EndTime");
			model.MediaId = _ctx.StringValue("QueryIncomeData.Model.MediaId");
			model.MediaName = _ctx.StringValue("QueryIncomeData.Model.MediaName");
			model.AdSlotType = _ctx.StringValue("QueryIncomeData.Model.AdSlotType");
			model.AdSlotId = _ctx.StringValue("QueryIncomeData.Model.AdSlotId");
			model.AdSlotName = _ctx.StringValue("QueryIncomeData.Model.AdSlotName");
			model.EstimatedIncome = _ctx.LongValue("QueryIncomeData.Model.EstimatedIncome");
			model.AdSlotRequests = _ctx.LongValue("QueryIncomeData.Model.AdSlotRequests");
			model.AccessStatus = _ctx.LongValue("QueryIncomeData.Model.AccessStatus");
			model.AdSlotHitTimes = _ctx.LongValue("QueryIncomeData.Model.AdSlotHitTimes");
			model.ShowTimes = _ctx.LongValue("QueryIncomeData.Model.ShowTimes");
			model.ClickTimes = _ctx.LongValue("QueryIncomeData.Model.ClickTimes");
			model.LastDayEstimatedIncome = _ctx.LongValue("QueryIncomeData.Model.LastDayEstimatedIncome");
			model.ThisMonEstimatedIncome = _ctx.LongValue("QueryIncomeData.Model.ThisMonEstimatedIncome");
			model.ThisYearIncome = _ctx.LongValue("QueryIncomeData.Model.ThisYearIncome");
			model.AccumulatedIncome = _ctx.LongValue("QueryIncomeData.Model.AccumulatedIncome");
			model.ChannelId = _ctx.StringValue("QueryIncomeData.Model.ChannelId");
			model.ChannelName = _ctx.StringValue("QueryIncomeData.Model.ChannelName");
			model.ThisDaysEstIncome = _ctx.LongValue("QueryIncomeData.Model.ThisDaysEstIncome");
			model.AdSlotHitRate = _ctx.StringValue("QueryIncomeData.Model.AdSlotHitRate");
			model.AdSlotShowRate = _ctx.StringValue("QueryIncomeData.Model.AdSlotShowRate");
			model.AdSlotClickRate = _ctx.StringValue("QueryIncomeData.Model.AdSlotClickRate");
			model.Ecpm = _ctx.LongValue("QueryIncomeData.Model.Ecpm");
			model.EcpmRate = _ctx.StringValue("QueryIncomeData.Model.EcpmRate");
			model.ThisDaysEstIncomeRate = _ctx.StringValue("QueryIncomeData.Model.ThisDaysEstIncomeRate");
			model.ThisMonEstIncomeRate = _ctx.StringValue("QueryIncomeData.Model.ThisMonEstIncomeRate");
			model.ThisYearEstIncomeRate = _ctx.StringValue("QueryIncomeData.Model.ThisYearEstIncomeRate");
			model.AccEstIncomeRate = _ctx.StringValue("QueryIncomeData.Model.AccEstIncomeRate");
			queryIncomeDataResponse.Model = model;
        
			return queryIncomeDataResponse;
        }
    }
}
