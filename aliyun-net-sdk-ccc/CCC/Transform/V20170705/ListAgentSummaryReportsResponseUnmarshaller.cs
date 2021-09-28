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
    public class ListAgentSummaryReportsResponseUnmarshaller
    {
        public static ListAgentSummaryReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAgentSummaryReportsResponse listAgentSummaryReportsResponse = new ListAgentSummaryReportsResponse();

			listAgentSummaryReportsResponse.HttpResponse = _ctx.HttpResponse;
			listAgentSummaryReportsResponse.RequestId = _ctx.StringValue("ListAgentSummaryReports.RequestId");
			listAgentSummaryReportsResponse.Success = _ctx.BooleanValue("ListAgentSummaryReports.Success");
			listAgentSummaryReportsResponse.Code = _ctx.StringValue("ListAgentSummaryReports.Code");
			listAgentSummaryReportsResponse.Message = _ctx.StringValue("ListAgentSummaryReports.Message");
			listAgentSummaryReportsResponse.HttpStatusCode = _ctx.IntegerValue("ListAgentSummaryReports.HttpStatusCode");

			ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport pagedAgentSummaryReport = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport();
			pagedAgentSummaryReport.TotalCount = _ctx.IntegerValue("ListAgentSummaryReports.PagedAgentSummaryReport.TotalCount");
			pagedAgentSummaryReport.PageNumber = _ctx.IntegerValue("ListAgentSummaryReports.PagedAgentSummaryReport.PageNumber");
			pagedAgentSummaryReport.PageSize = _ctx.IntegerValue("ListAgentSummaryReports.PagedAgentSummaryReport.PageSize");

			List<ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport> pagedAgentSummaryReport_list = new List<ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport>();
			for (int i = 0; i < _ctx.Length("ListAgentSummaryReports.PagedAgentSummaryReport.List.Length"); i++) {
				ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport agentSummaryReport = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport();
				agentSummaryReport.InstanceId = _ctx.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].InstanceId");
				agentSummaryReport.AgentId = _ctx.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].AgentId");
				agentSummaryReport.LoginName = _ctx.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].LoginName");
				agentSummaryReport.AgentName = _ctx.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].AgentName");
				agentSummaryReport.SkillGroupIds = _ctx.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].SkillGroupIds");
				agentSummaryReport.SkillGroupNames = _ctx.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].SkillGroupNames");

				ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Overall overall = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Overall();
				overall.TotalCalls = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalCalls");
				overall.TotalLoggedInTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalBreakTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalBreakTime");
				overall.OccupancyRate = _ctx.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.OccupancyRate");
				overall.TotalReadyTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalReadyTime");
				overall.MaxReadyTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.AverageReadyTime");
				overall.TotalTalkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalWorkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionIndex = _ctx.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.OneTransferCalls = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.OneTransferCalls");
				overall.FirstLogInTime = _ctx.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.FirstLogInTime");
				overall.LastLogOutTime = _ctx.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.LastLogOutTime");
				agentSummaryReport.Overall = overall;

				ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Inbound inbound = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Inbound();
				inbound.CallsOffered = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = _ctx.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageRingTime");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalTalkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalWorkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				agentSummaryReport.Inbound = inbound;

				ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Outbound outbound = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Outbound();
				outbound.CallsDialed = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = _ctx.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageDialingTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalWorkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = _ctx.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				agentSummaryReport.Outbound = outbound;

				pagedAgentSummaryReport_list.Add(agentSummaryReport);
			}
			pagedAgentSummaryReport.List = pagedAgentSummaryReport_list;
			listAgentSummaryReportsResponse.PagedAgentSummaryReport = pagedAgentSummaryReport;
        
			return listAgentSummaryReportsResponse;
        }
    }
}
