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
    public class ListAgentSummaryReportsByIntervalResponseUnmarshaller
    {
        public static ListAgentSummaryReportsByIntervalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAgentSummaryReportsByIntervalResponse listAgentSummaryReportsByIntervalResponse = new ListAgentSummaryReportsByIntervalResponse();

			listAgentSummaryReportsByIntervalResponse.HttpResponse = _ctx.HttpResponse;
			listAgentSummaryReportsByIntervalResponse.RequestId = _ctx.StringValue("ListAgentSummaryReportsByInterval.RequestId");
			listAgentSummaryReportsByIntervalResponse.Success = _ctx.BooleanValue("ListAgentSummaryReportsByInterval.Success");
			listAgentSummaryReportsByIntervalResponse.Code = _ctx.StringValue("ListAgentSummaryReportsByInterval.Code");
			listAgentSummaryReportsByIntervalResponse.Message = _ctx.StringValue("ListAgentSummaryReportsByInterval.Message");
			listAgentSummaryReportsByIntervalResponse.HttpStatusCode = _ctx.IntegerValue("ListAgentSummaryReportsByInterval.HttpStatusCode");

			ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport pagedAgentSummaryReport = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport();
			pagedAgentSummaryReport.TotalCount = _ctx.IntegerValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.TotalCount");
			pagedAgentSummaryReport.PageNumber = _ctx.IntegerValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.PageNumber");
			pagedAgentSummaryReport.PageSize = _ctx.IntegerValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.PageSize");

			List<ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport> pagedAgentSummaryReport_list = new List<ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport>();
			for (int i = 0; i < _ctx.Length("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List.Length"); i++) {
				ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport agentTimeIntervalReport = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport();
				agentTimeIntervalReport.AgentId = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].AgentId");

				List<ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport> agentTimeIntervalReport_intervalList = new List<ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport>();
				for (int j = 0; j < _ctx.Length("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList.Length"); j++) {
					ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport agentSummaryReport = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport();
					agentSummaryReport.Timestamp = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Timestamp");
					agentSummaryReport.InstanceId = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].InstanceId");
					agentSummaryReport.AgentId = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].AgentId");
					agentSummaryReport.LoginName = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].LoginName");
					agentSummaryReport.AgentName = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].AgentName");
					agentSummaryReport.SkillGroupIds = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].SkillGroupIds");
					agentSummaryReport.SkillGroupNames = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].SkillGroupNames");

					ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Overall overall = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Overall();
					overall.TotalCalls = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalCalls");
					overall.TotalLoggedInTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalLoggedInTime");
					overall.TotalBreakTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalBreakTime");
					overall.OccupancyRate = _ctx.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.OccupancyRate");
					overall.TotalReadyTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalReadyTime");
					overall.MaxReadyTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxReadyTime");
					overall.AverageReadyTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageReadyTime");
					overall.TotalTalkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalTalkTime");
					overall.MaxTalkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxTalkTime");
					overall.AverageTalkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageTalkTime");
					overall.TotalWorkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalWorkTime");
					overall.MaxWorkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxWorkTime");
					overall.AverageWorkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageWorkTime");
					overall.SatisfactionIndex = _ctx.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionIndex");
					overall.SatisfactionSurveysOffered = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionSurveysOffered");
					overall.SatisfactionSurveysResponded = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionSurveysResponded");
					overall.OneTransferCalls = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.OneTransferCalls");
					overall.FirstLogInTime = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.FirstLogInTime");
					overall.LastLogOutTime = _ctx.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.LastLogOutTime");
					agentSummaryReport.Overall = overall;

					ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Inbound inbound = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Inbound();
					inbound.CallsOffered = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.CallsOffered");
					inbound.CallsHandled = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.CallsHandled");
					inbound.HandleRate = _ctx.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.HandleRate");
					inbound.TotalRingTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalRingTime");
					inbound.MaxRingTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxRingTime");
					inbound.AverageRingTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageRingTime");
					inbound.ServiceLevel20 = _ctx.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.ServiceLevel20");
					inbound.TotalTalkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalTalkTime");
					inbound.MaxTalkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxTalkTime");
					inbound.AverageTalkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageTalkTime");
					inbound.TotalWorkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalWorkTime");
					inbound.MaxWorkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxWorkTime");
					inbound.AverageWorkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageWorkTime");
					inbound.SatisfactionIndex = _ctx.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionIndex");
					inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionSurveysOffered");
					inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionSurveysResponded");
					agentSummaryReport.Inbound = inbound;

					ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Outbound outbound = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Outbound();
					outbound.CallsDialed = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.CallsDialed");
					outbound.CallsAnswered = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.CallsAnswered");
					outbound.AnswerRate = _ctx.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AnswerRate");
					outbound.TotalDialingTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalDialingTime");
					outbound.MaxDialingTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxDialingTime");
					outbound.AverageDialingTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageDialingTime");
					outbound.TotalTalkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalTalkTime");
					outbound.MaxTalkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxTalkTime");
					outbound.AverageTalkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageTalkTime");
					outbound.TotalWorkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalWorkTime");
					outbound.MaxWorkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxWorkTime");
					outbound.AverageWorkTime = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageWorkTime");
					outbound.SatisfactionIndex = _ctx.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionIndex");
					outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionSurveysOffered");
					outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionSurveysResponded");
					agentSummaryReport.Outbound = outbound;

					agentTimeIntervalReport_intervalList.Add(agentSummaryReport);
				}
				agentTimeIntervalReport.IntervalList = agentTimeIntervalReport_intervalList;

				pagedAgentSummaryReport_list.Add(agentTimeIntervalReport);
			}
			pagedAgentSummaryReport.List = pagedAgentSummaryReport_list;
			listAgentSummaryReportsByIntervalResponse.PagedAgentSummaryReport = pagedAgentSummaryReport;
        
			return listAgentSummaryReportsByIntervalResponse;
        }
    }
}
