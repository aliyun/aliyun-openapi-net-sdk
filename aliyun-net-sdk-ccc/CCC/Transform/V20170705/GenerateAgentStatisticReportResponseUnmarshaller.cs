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
    public class GenerateAgentStatisticReportResponseUnmarshaller
    {
        public static GenerateAgentStatisticReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateAgentStatisticReportResponse generateAgentStatisticReportResponse = new GenerateAgentStatisticReportResponse();

			generateAgentStatisticReportResponse.HttpResponse = _ctx.HttpResponse;
			generateAgentStatisticReportResponse.RequestId = _ctx.StringValue("GenerateAgentStatisticReport.RequestId");
			generateAgentStatisticReportResponse.Success = _ctx.BooleanValue("GenerateAgentStatisticReport.Success");
			generateAgentStatisticReportResponse.Code = _ctx.StringValue("GenerateAgentStatisticReport.Code");
			generateAgentStatisticReportResponse.Message = _ctx.StringValue("GenerateAgentStatisticReport.Message");
			generateAgentStatisticReportResponse.HttpStatusCode = _ctx.IntegerValue("GenerateAgentStatisticReport.HttpStatusCode");

			GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList dataList = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList();
			dataList.TotalCount = _ctx.IntegerValue("GenerateAgentStatisticReport.DataList.TotalCount");
			dataList.PageNumber = _ctx.IntegerValue("GenerateAgentStatisticReport.DataList.PageNumber");
			dataList.PageSize = _ctx.IntegerValue("GenerateAgentStatisticReport.DataList.PageSize");

			List<GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic> dataList_list = new List<GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic>();
			for (int i = 0; i < _ctx.Length("GenerateAgentStatisticReport.DataList.List.Length"); i++) {
				GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic generateAgentStatistic = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic();
				generateAgentStatistic.AgentId = _ctx.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].AgentId");
				generateAgentStatistic.LoginName = _ctx.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].LoginName");
				generateAgentStatistic.AgentName = _ctx.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].AgentName");
				generateAgentStatistic.SkillGroupIds = _ctx.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].SkillGroupIds");
				generateAgentStatistic.SkillGroupNames = _ctx.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].SkillGroupNames");
				generateAgentStatistic.InstanceId = _ctx.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].InstanceId");
				generateAgentStatistic.RecordDate = _ctx.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].RecordDate");
				generateAgentStatistic.TotalLoggedInTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].TotalLoggedInTime");
				generateAgentStatistic.TotalBreakTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].TotalBreakTime");
				generateAgentStatistic.OccupancyRate = _ctx.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].OccupancyRate");
				generateAgentStatistic.TotalReadyTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].TotalReadyTime");
				generateAgentStatistic.MaxReadyTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].MaxReadyTime");
				generateAgentStatistic.AverageReadyTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].AverageReadyTime");

				GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Inbound inbound = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Inbound();
				inbound.TotalTalkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalHoldTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.TotalHoldTime");
				inbound.MaxHoldTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.MaxHoldTime");
				inbound.AverageHoldTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.AverageHoldTime");
				inbound.TotalWorkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.SatisfactionIndex = _ctx.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.CallsOffered = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = _ctx.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.AverageRingTime");
				generateAgentStatistic.Inbound = inbound;

				GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Outbound outbound = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Outbound();
				outbound.TotalTalkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalHoldTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalHoldTime");
				outbound.MaxHoldTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.MaxHoldTime");
				outbound.AverageHoldTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AverageHoldTime");
				outbound.TotalWorkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.SatisfactionIndex = _ctx.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.CallsDialed = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = _ctx.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalDialingTime1 = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AverageDialingTime");
				generateAgentStatistic.Outbound = outbound;

				GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Overall overall = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Overall();
				overall.TotalTalkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalHoldTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.TotalHoldTime");
				overall.MaxHoldTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.MaxHoldTime");
				overall.AverageHoldTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.AverageHoldTime");
				overall.TotalWorkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.SatisfactionIndex = _ctx.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.SatisfactionIndex");
				overall.TotalCalls = _ctx.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.TotalCalls");
				generateAgentStatistic.Overall = overall;

				dataList_list.Add(generateAgentStatistic);
			}
			dataList.List = dataList_list;
			generateAgentStatisticReportResponse.DataList = dataList;
        
			return generateAgentStatisticReportResponse;
        }
    }
}
