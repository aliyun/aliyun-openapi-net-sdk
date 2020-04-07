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
        public static GenerateAgentStatisticReportResponse Unmarshall(UnmarshallerContext context)
        {
			GenerateAgentStatisticReportResponse generateAgentStatisticReportResponse = new GenerateAgentStatisticReportResponse();

			generateAgentStatisticReportResponse.HttpResponse = context.HttpResponse;
			generateAgentStatisticReportResponse.RequestId = context.StringValue("GenerateAgentStatisticReport.RequestId");
			generateAgentStatisticReportResponse.Success = context.BooleanValue("GenerateAgentStatisticReport.Success");
			generateAgentStatisticReportResponse.Code = context.StringValue("GenerateAgentStatisticReport.Code");
			generateAgentStatisticReportResponse.Message = context.StringValue("GenerateAgentStatisticReport.Message");
			generateAgentStatisticReportResponse.HttpStatusCode = context.IntegerValue("GenerateAgentStatisticReport.HttpStatusCode");

			GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList dataList = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList();
			dataList.TotalCount = context.IntegerValue("GenerateAgentStatisticReport.DataList.TotalCount");
			dataList.PageNumber = context.IntegerValue("GenerateAgentStatisticReport.DataList.PageNumber");
			dataList.PageSize = context.IntegerValue("GenerateAgentStatisticReport.DataList.PageSize");

			List<GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic> dataList_list = new List<GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic>();
			for (int i = 0; i < context.Length("GenerateAgentStatisticReport.DataList.List.Length"); i++) {
				GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic generateAgentStatistic = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic();
				generateAgentStatistic.AgentId = context.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].AgentId");
				generateAgentStatistic.LoginName = context.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].LoginName");
				generateAgentStatistic.AgentName = context.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].AgentName");
				generateAgentStatistic.SkillGroupIds = context.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].SkillGroupIds");
				generateAgentStatistic.SkillGroupNames = context.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].SkillGroupNames");
				generateAgentStatistic.InstanceId = context.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].InstanceId");
				generateAgentStatistic.RecordDate = context.StringValue("GenerateAgentStatisticReport.DataList.List["+ i +"].RecordDate");
				generateAgentStatistic.TotalLoggedInTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].TotalLoggedInTime");
				generateAgentStatistic.TotalBreakTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].TotalBreakTime");
				generateAgentStatistic.OccupancyRate = context.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].OccupancyRate");
				generateAgentStatistic.TotalReadyTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].TotalReadyTime");
				generateAgentStatistic.MaxReadyTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].MaxReadyTime");
				generateAgentStatistic.AverageReadyTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].AverageReadyTime");

				GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Inbound inbound = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Inbound();
				inbound.TotalTalkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalHoldTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.TotalHoldTime");
				inbound.MaxHoldTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.MaxHoldTime");
				inbound.AverageHoldTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.AverageHoldTime");
				inbound.TotalWorkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionSurveysOffered = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.SatisfactionIndex = context.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.CallsOffered = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = context.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Inbound.AverageRingTime");
				generateAgentStatistic.Inbound = inbound;

				GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Outbound outbound = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Outbound();
				outbound.TotalTalkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalHoldTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalHoldTime");
				outbound.MaxHoldTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.MaxHoldTime");
				outbound.AverageHoldTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AverageHoldTime");
				outbound.TotalWorkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionSurveysOffered = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.SatisfactionIndex = context.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.CallsDialed = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = context.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalDialingTime1 = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Outbound.AverageDialingTime");
				generateAgentStatistic.Outbound = outbound;

				GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Overall overall = new GenerateAgentStatisticReportResponse.GenerateAgentStatisticReport_DataList.GenerateAgentStatisticReport_GenerateAgentStatistic.GenerateAgentStatisticReport_Overall();
				overall.TotalTalkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalHoldTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.TotalHoldTime");
				overall.MaxHoldTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.MaxHoldTime");
				overall.AverageHoldTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.AverageHoldTime");
				overall.TotalWorkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionSurveysOffered = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.SatisfactionIndex = context.FloatValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.SatisfactionIndex");
				overall.TotalCalls = context.LongValue("GenerateAgentStatisticReport.DataList.List["+ i +"].Overall.TotalCalls");
				generateAgentStatistic.Overall = overall;

				dataList_list.Add(generateAgentStatistic);
			}
			dataList.List = dataList_list;
			generateAgentStatisticReportResponse.DataList = dataList;
        
			return generateAgentStatisticReportResponse;
        }
    }
}
