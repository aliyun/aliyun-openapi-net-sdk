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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetAgentDataResponseUnmarshaller
    {
        public static GetAgentDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAgentDataResponse getAgentDataResponse = new GetAgentDataResponse();

			getAgentDataResponse.HttpResponse = _ctx.HttpResponse;
			getAgentDataResponse.RequestId = _ctx.StringValue("GetAgentData.RequestId");
			getAgentDataResponse.Success = _ctx.BooleanValue("GetAgentData.Success");
			getAgentDataResponse.Code = _ctx.StringValue("GetAgentData.Code");
			getAgentDataResponse.Message = _ctx.StringValue("GetAgentData.Message");
			getAgentDataResponse.HttpStatusCode = _ctx.IntegerValue("GetAgentData.HttpStatusCode");

			GetAgentDataResponse.GetAgentData_DataList dataList = new GetAgentDataResponse.GetAgentData_DataList();
			dataList.TotalCount = _ctx.IntegerValue("GetAgentData.DataList.TotalCount");
			dataList.PageNumber = _ctx.IntegerValue("GetAgentData.DataList.PageNumber");
			dataList.PageSize = _ctx.IntegerValue("GetAgentData.DataList.PageSize");

			List<GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic> dataList_list = new List<GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic>();
			for (int i = 0; i < _ctx.Length("GetAgentData.DataList.List.Length"); i++) {
				GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic generateAgentStatistic = new GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic();
				generateAgentStatistic.AgentId = _ctx.StringValue("GetAgentData.DataList.List["+ i +"].AgentId");
				generateAgentStatistic.LoginName = _ctx.StringValue("GetAgentData.DataList.List["+ i +"].LoginName");
				generateAgentStatistic.AgentName = _ctx.StringValue("GetAgentData.DataList.List["+ i +"].AgentName");
				generateAgentStatistic.SkillGroupIds = _ctx.StringValue("GetAgentData.DataList.List["+ i +"].SkillGroupIds");
				generateAgentStatistic.SkillGroupNames = _ctx.StringValue("GetAgentData.DataList.List["+ i +"].SkillGroupNames");
				generateAgentStatistic.InstanceId = _ctx.StringValue("GetAgentData.DataList.List["+ i +"].InstanceId");
				generateAgentStatistic.RecordDate = _ctx.StringValue("GetAgentData.DataList.List["+ i +"].RecordDate");
				generateAgentStatistic.TotalLoggedInTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].TotalLoggedInTime");
				generateAgentStatistic.TotalBreakTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].TotalBreakTime");
				generateAgentStatistic.OccupancyRate = _ctx.FloatValue("GetAgentData.DataList.List["+ i +"].OccupancyRate");
				generateAgentStatistic.TotalReadyTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].TotalReadyTime");
				generateAgentStatistic.MaxReadyTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].MaxReadyTime");
				generateAgentStatistic.AverageReadyTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].AverageReadyTime");

				GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Inbound inbound = new GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Inbound();
				inbound.TotalTalkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalHoldTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.TotalHoldTime");
				inbound.MaxHoldTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.MaxHoldTime");
				inbound.AverageHoldTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.AverageHoldTime");
				inbound.TotalWorkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.SatisfactionIndex = _ctx.FloatValue("GetAgentData.DataList.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.CallsOffered = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = _ctx.FloatValue("GetAgentData.DataList.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Inbound.AverageRingTime");
				generateAgentStatistic.Inbound = inbound;

				GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Outbound outbound = new GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Outbound();
				outbound.TotalTalkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalHoldTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalHoldTime");
				outbound.MaxHoldTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.MaxHoldTime");
				outbound.AverageHoldTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.AverageHoldTime");
				outbound.TotalWorkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.SatisfactionIndex = _ctx.FloatValue("GetAgentData.DataList.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.CallsDialed = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = _ctx.FloatValue("GetAgentData.DataList.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalDialingTime1 = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Outbound.AverageDialingTime");
				generateAgentStatistic.Outbound = outbound;

				GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Overall overall = new GetAgentDataResponse.GetAgentData_DataList.GetAgentData_GenerateAgentStatistic.GetAgentData_Overall();
				overall.TotalTalkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalHoldTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.TotalHoldTime");
				overall.MaxHoldTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.MaxHoldTime");
				overall.AverageHoldTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.AverageHoldTime");
				overall.TotalWorkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.SatisfactionIndex = _ctx.FloatValue("GetAgentData.DataList.List["+ i +"].Overall.SatisfactionIndex");
				overall.TotalCalls = _ctx.LongValue("GetAgentData.DataList.List["+ i +"].Overall.TotalCalls");
				generateAgentStatistic.Overall = overall;

				dataList_list.Add(generateAgentStatistic);
			}
			dataList.List = dataList_list;
			getAgentDataResponse.DataList = dataList;
        
			return getAgentDataResponse;
        }
    }
}
