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
    public class ListAgentSummaryReportsSinceMidnightResponseUnmarshaller
    {
        public static ListAgentSummaryReportsSinceMidnightResponse Unmarshall(UnmarshallerContext context)
        {
			ListAgentSummaryReportsSinceMidnightResponse listAgentSummaryReportsSinceMidnightResponse = new ListAgentSummaryReportsSinceMidnightResponse();

			listAgentSummaryReportsSinceMidnightResponse.HttpResponse = context.HttpResponse;
			listAgentSummaryReportsSinceMidnightResponse.RequestId = context.StringValue("ListAgentSummaryReportsSinceMidnight.RequestId");
			listAgentSummaryReportsSinceMidnightResponse.Success = context.BooleanValue("ListAgentSummaryReportsSinceMidnight.Success");
			listAgentSummaryReportsSinceMidnightResponse.Code = context.StringValue("ListAgentSummaryReportsSinceMidnight.Code");
			listAgentSummaryReportsSinceMidnightResponse.Message = context.StringValue("ListAgentSummaryReportsSinceMidnight.Message");
			listAgentSummaryReportsSinceMidnightResponse.HttpStatusCode = context.IntegerValue("ListAgentSummaryReportsSinceMidnight.HttpStatusCode");

			ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport pagedAgentSummaryReport = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport();
			pagedAgentSummaryReport.TotalCount = context.IntegerValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.TotalCount");
			pagedAgentSummaryReport.PageNumber = context.IntegerValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.PageNumber");
			pagedAgentSummaryReport.PageSize = context.IntegerValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.PageSize");

			List<ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport> pagedAgentSummaryReport_list = new List<ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport>();
			for (int i = 0; i < context.Length("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List.Length"); i++) {
				ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport agentSummaryReport = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport();
				agentSummaryReport.Timestamp = context.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Timestamp");
				agentSummaryReport.InstanceId = context.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].InstanceId");
				agentSummaryReport.AgentId = context.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].AgentId");
				agentSummaryReport.LoginName = context.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].LoginName");
				agentSummaryReport.AgentName = context.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].AgentName");
				agentSummaryReport.SkillGroupIds = context.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].SkillGroupIds");
				agentSummaryReport.SkillGroupNames = context.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].SkillGroupNames");

				ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Overall overall = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Overall();
				overall.TotalCalls = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalCalls");
				overall.TotalLoggedInTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalBreakTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalBreakTime");
				overall.OccupancyRate = context.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.OccupancyRate");
				overall.TotalReadyTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalReadyTime");
				overall.MaxReadyTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.AverageReadyTime");
				overall.TotalTalkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalWorkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionIndex = context.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.OneTransferCalls = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Overall.OneTransferCalls");
				agentSummaryReport.Overall = overall;

				ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Inbound inbound = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Inbound();
				inbound.CallsOffered = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = context.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageRingTime");
				inbound.ServiceLevel20 = context.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalTalkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalWorkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionIndex = context.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				agentSummaryReport.Inbound = inbound;

				ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Outbound outbound = new ListAgentSummaryReportsSinceMidnightResponse.ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport.ListAgentSummaryReportsSinceMidnight_AgentSummaryReport.ListAgentSummaryReportsSinceMidnight_Outbound();
				outbound.CallsDialed = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = context.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageDialingTime");
				outbound.TotalTalkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalWorkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = context.StringValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = context.FloatValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = context.LongValue("ListAgentSummaryReportsSinceMidnight.PagedAgentSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				agentSummaryReport.Outbound = outbound;

				pagedAgentSummaryReport_list.Add(agentSummaryReport);
			}
			pagedAgentSummaryReport.List = pagedAgentSummaryReport_list;
			listAgentSummaryReportsSinceMidnightResponse.PagedAgentSummaryReport = pagedAgentSummaryReport;
        
			return listAgentSummaryReportsSinceMidnightResponse;
        }
    }
}
