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
        public static ListAgentSummaryReportsByIntervalResponse Unmarshall(UnmarshallerContext context)
        {
			ListAgentSummaryReportsByIntervalResponse listAgentSummaryReportsByIntervalResponse = new ListAgentSummaryReportsByIntervalResponse();

			listAgentSummaryReportsByIntervalResponse.HttpResponse = context.HttpResponse;
			listAgentSummaryReportsByIntervalResponse.RequestId = context.StringValue("ListAgentSummaryReportsByInterval.RequestId");
			listAgentSummaryReportsByIntervalResponse.Success = context.BooleanValue("ListAgentSummaryReportsByInterval.Success");
			listAgentSummaryReportsByIntervalResponse.Code = context.StringValue("ListAgentSummaryReportsByInterval.Code");
			listAgentSummaryReportsByIntervalResponse.Message = context.StringValue("ListAgentSummaryReportsByInterval.Message");
			listAgentSummaryReportsByIntervalResponse.HttpStatusCode = context.IntegerValue("ListAgentSummaryReportsByInterval.HttpStatusCode");

			ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport pagedAgentSummaryReport = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport();
			pagedAgentSummaryReport.TotalCount = context.IntegerValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.TotalCount");
			pagedAgentSummaryReport.PageNumber = context.IntegerValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.PageNumber");
			pagedAgentSummaryReport.PageSize = context.IntegerValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.PageSize");

			List<ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport> pagedAgentSummaryReport_list = new List<ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport>();
			for (int i = 0; i < context.Length("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List.Length"); i++) {
				ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport agentTimeIntervalReport = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport();
				agentTimeIntervalReport.AgentId = context.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].AgentId");

				List<ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport> agentTimeIntervalReport_intervalList = new List<ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport>();
				for (int j = 0; j < context.Length("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList.Length"); j++) {
					ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport agentSummaryReport = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport();
					agentSummaryReport.Timestamp = context.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Timestamp");
					agentSummaryReport.InstanceId = context.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].InstanceId");
					agentSummaryReport.AgentId = context.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].AgentId");
					agentSummaryReport.LoginName = context.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].LoginName");
					agentSummaryReport.AgentName = context.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].AgentName");
					agentSummaryReport.SkillGroupIds = context.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].SkillGroupIds");
					agentSummaryReport.SkillGroupNames = context.StringValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].SkillGroupNames");

					ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Overall overall = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Overall();
					overall.TotalCalls = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalCalls");
					overall.TotalLoggedInTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalLoggedInTime");
					overall.TotalBreakTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalBreakTime");
					overall.OccupancyRate = context.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.OccupancyRate");
					overall.TotalReadyTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalReadyTime");
					overall.MaxReadyTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxReadyTime");
					overall.AverageReadyTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageReadyTime");
					overall.TotalTalkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalTalkTime");
					overall.MaxTalkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxTalkTime");
					overall.AverageTalkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageTalkTime");
					overall.TotalWorkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalWorkTime");
					overall.MaxWorkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxWorkTime");
					overall.AverageWorkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageWorkTime");
					overall.SatisfactionIndex = context.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionIndex");
					overall.SatisfactionSurveysOffered = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionSurveysOffered");
					overall.SatisfactionSurveysResponded = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionSurveysResponded");
					overall.OneTransferCalls = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.OneTransferCalls");
					agentSummaryReport.Overall = overall;

					ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Inbound inbound = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Inbound();
					inbound.CallsOffered = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.CallsOffered");
					inbound.CallsHandled = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.CallsHandled");
					inbound.HandleRate = context.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.HandleRate");
					inbound.TotalRingTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalRingTime");
					inbound.MaxRingTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxRingTime");
					inbound.AverageRingTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageRingTime");
					inbound.ServiceLevel20 = context.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.ServiceLevel20");
					inbound.TotalTalkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalTalkTime");
					inbound.MaxTalkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxTalkTime");
					inbound.AverageTalkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageTalkTime");
					inbound.TotalWorkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalWorkTime");
					inbound.MaxWorkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxWorkTime");
					inbound.AverageWorkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageWorkTime");
					inbound.SatisfactionIndex = context.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionIndex");
					inbound.SatisfactionSurveysOffered = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionSurveysOffered");
					inbound.SatisfactionSurveysResponded = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionSurveysResponded");
					agentSummaryReport.Inbound = inbound;

					ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Outbound outbound = new ListAgentSummaryReportsByIntervalResponse.ListAgentSummaryReportsByInterval_PagedAgentSummaryReport.ListAgentSummaryReportsByInterval_AgentTimeIntervalReport.ListAgentSummaryReportsByInterval_AgentSummaryReport.ListAgentSummaryReportsByInterval_Outbound();
					outbound.CallsDialed = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.CallsDialed");
					outbound.CallsAnswered = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.CallsAnswered");
					outbound.AnswerRate = context.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AnswerRate");
					outbound.TotalDialingTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalDialingTime");
					outbound.MaxDialingTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxDialingTime");
					outbound.AverageDialingTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageDialingTime");
					outbound.TotalTalkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalTalkTime");
					outbound.MaxTalkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxTalkTime");
					outbound.AverageTalkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageTalkTime");
					outbound.TotalWorkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalWorkTime");
					outbound.MaxWorkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxWorkTime");
					outbound.AverageWorkTime = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageWorkTime");
					outbound.SatisfactionIndex = context.FloatValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionIndex");
					outbound.SatisfactionSurveysOffered = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionSurveysOffered");
					outbound.SatisfactionSurveysResponded = context.LongValue("ListAgentSummaryReportsByInterval.PagedAgentSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionSurveysResponded");
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
