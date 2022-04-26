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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListAgentSummaryReportsSinceMidnightResponseUnmarshaller
    {
        public static ListAgentSummaryReportsSinceMidnightResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAgentSummaryReportsSinceMidnightResponse listAgentSummaryReportsSinceMidnightResponse = new ListAgentSummaryReportsSinceMidnightResponse();

			listAgentSummaryReportsSinceMidnightResponse.HttpResponse = _ctx.HttpResponse;
			listAgentSummaryReportsSinceMidnightResponse.HttpStatusCode = _ctx.IntegerValue("ListAgentSummaryReportsSinceMidnight.HttpStatusCode");
			listAgentSummaryReportsSinceMidnightResponse.Code = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.Code");
			listAgentSummaryReportsSinceMidnightResponse.Message = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.Message");
			listAgentSummaryReportsSinceMidnightResponse.RequestId = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.RequestId");
			listAgentSummaryReportsSinceMidnightResponse.Success = _ctx.BooleanValue("ListAgentSummaryReportsSinceMidnight.Success");

			ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport pagedAgentSummaryReport = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport();
			pagedAgentSummaryReport.PageNumber = _ctx.IntegerValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.PageNumber");
			pagedAgentSummaryReport.PageSize = _ctx.IntegerValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.PageSize");
			pagedAgentSummaryReport.TotalCount = _ctx.IntegerValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.TotalCount");

			List<ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport> pagedAgentSummaryReport_list = new List<ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport>();
			for (int i = 0; i < _ctx.Length("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List.Length"); i++) {
				ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport agentSummaryReport = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport();
				agentSummaryReport.LoginName = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].LoginName");
				agentSummaryReport.AgentId = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].AgentId");
				agentSummaryReport.AgentName = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].AgentName");
				agentSummaryReport.SkillGroupNames = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].SkillGroupNames");
				agentSummaryReport.Timestamp = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Timestamp");
				agentSummaryReport.InstanceId = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].InstanceId");
				agentSummaryReport.SkillGroupIds = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].SkillGroupIds");

				ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Overall overall = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Overall();
				overall.TotalTalkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalTalkTime");
				overall.TotalLoggedInTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalLoggedInTime");
				overall.OccupancyRate = _ctx.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.OccupancyRate");
				overall.TotalWorkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.AverageWorkTime");
				overall.AverageTalkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.AverageTalkTime");
				overall.SatisfactionIndex = _ctx.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.AverageReadyTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.AverageReadyTime");
				overall.MaxReadyTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.MaxReadyTime");
				overall.OneTransferCalls = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.OneTransferCalls");
				overall.MaxTalkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.MaxTalkTime");
				overall.TotalReadyTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalReadyTime");
				overall.TotalBreakTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalBreakTime");
				overall.TotalCalls = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalCalls");
				agentSummaryReport.Overall = overall;

				ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Inbound inbound = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Inbound();
				inbound.TotalTalkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalTalkTime");
				inbound.CallsOffered = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.CallsOffered");
				inbound.AverageRingTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageRingTime");
				inbound.CallsHandled = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.CallsHandled");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalWorkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageWorkTime");
				inbound.AverageTalkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageTalkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.HandleRate = _ctx.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.HandleRate");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.TotalRingTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxRingTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxRingTime");
				agentSummaryReport.Inbound = inbound;

				ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Outbound outbound = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Outbound();
				outbound.TotalTalkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxDialingTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxDialingTime");
				outbound.CallsDialed = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = _ctx.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalWorkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = _ctx.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxWorkTime");
				outbound.TotalDialingTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalDialingTime");
				outbound.AverageTalkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageTalkTime");
				outbound.AverageWorkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.MaxTalkTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageDialingTime = _ctx.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageDialingTime");
				agentSummaryReport.Outbound = outbound;

				pagedAgentSummaryReport_list.Add(agentSummaryReport);
			}
			pagedAgentSummaryReport.List = pagedAgentSummaryReport_list;
			listAgentSummaryReportsSinceMidnightResponse.PagedAgentSummaryReport = pagedAgentSummaryReport;
        
			return listAgentSummaryReportsSinceMidnightResponse;
        }
    }
}
