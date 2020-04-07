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
        public static ListAgentSummaryReportsResponse Unmarshall(UnmarshallerContext context)
        {
			ListAgentSummaryReportsResponse listAgentSummaryReportsResponse = new ListAgentSummaryReportsResponse();

			listAgentSummaryReportsResponse.HttpResponse = context.HttpResponse;
			listAgentSummaryReportsResponse.RequestId = context.StringValue("ListAgentSummaryReports.RequestId");
			listAgentSummaryReportsResponse.Success = context.BooleanValue("ListAgentSummaryReports.Success");
			listAgentSummaryReportsResponse.Code = context.StringValue("ListAgentSummaryReports.Code");
			listAgentSummaryReportsResponse.Message = context.StringValue("ListAgentSummaryReports.Message");
			listAgentSummaryReportsResponse.HttpStatusCode = context.IntegerValue("ListAgentSummaryReports.HttpStatusCode");

			ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport pagedAgentSummaryReport = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport();
			pagedAgentSummaryReport.TotalCount = context.IntegerValue("ListAgentSummaryReports.PagedAgentSummaryReport.TotalCount");
			pagedAgentSummaryReport.PageNumber = context.IntegerValue("ListAgentSummaryReports.PagedAgentSummaryReport.PageNumber");
			pagedAgentSummaryReport.PageSize = context.IntegerValue("ListAgentSummaryReports.PagedAgentSummaryReport.PageSize");

			List<ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport> pagedAgentSummaryReport_list = new List<ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport>();
			for (int i = 0; i < context.Length("ListAgentSummaryReports.PagedAgentSummaryReport.List.Length"); i++) {
				ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport agentSummaryReport = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport();
				agentSummaryReport.InstanceId = context.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].InstanceId");
				agentSummaryReport.AgentId = context.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].AgentId");
				agentSummaryReport.LoginName = context.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].LoginName");
				agentSummaryReport.AgentName = context.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].AgentName");
				agentSummaryReport.SkillGroupIds = context.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].SkillGroupIds");
				agentSummaryReport.SkillGroupNames = context.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].SkillGroupNames");

				ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Overall overall = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Overall();
				overall.TotalCalls = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalCalls");
				overall.TotalLoggedInTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalBreakTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalBreakTime");
				overall.OccupancyRate = context.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.OccupancyRate");
				overall.TotalReadyTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalReadyTime");
				overall.MaxReadyTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.AverageReadyTime");
				overall.TotalTalkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalWorkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionIndex = context.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.OneTransferCalls = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Overall.OneTransferCalls");
				agentSummaryReport.Overall = overall;

				ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Inbound inbound = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Inbound();
				inbound.CallsOffered = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = context.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageRingTime");
				inbound.ServiceLevel20 = context.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalTalkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalWorkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionIndex = context.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				agentSummaryReport.Inbound = inbound;

				ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Outbound outbound = new ListAgentSummaryReportsResponse.ListAgentSummaryReports_PagedAgentSummaryReport.ListAgentSummaryReports_AgentSummaryReport.ListAgentSummaryReports_Outbound();
				outbound.CallsDialed = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = context.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageDialingTime");
				outbound.TotalTalkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalWorkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = context.StringValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = context.FloatValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = context.LongValue("ListAgentSummaryReports.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				agentSummaryReport.Outbound = outbound;

				pagedAgentSummaryReport_list.Add(agentSummaryReport);
			}
			pagedAgentSummaryReport.List = pagedAgentSummaryReport_list;
			listAgentSummaryReportsResponse.PagedAgentSummaryReport = pagedAgentSummaryReport;
        
			return listAgentSummaryReportsResponse;
        }
    }
}
