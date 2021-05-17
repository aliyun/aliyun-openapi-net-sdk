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
    public class ListSkillGroupSummaryReportsResponseUnmarshaller
    {
        public static ListSkillGroupSummaryReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSkillGroupSummaryReportsResponse listSkillGroupSummaryReportsResponse = new ListSkillGroupSummaryReportsResponse();

			listSkillGroupSummaryReportsResponse.HttpResponse = _ctx.HttpResponse;
			listSkillGroupSummaryReportsResponse.RequestId = _ctx.StringValue("ListSkillGroupSummaryReports.RequestId");
			listSkillGroupSummaryReportsResponse.Success = _ctx.BooleanValue("ListSkillGroupSummaryReports.Success");
			listSkillGroupSummaryReportsResponse.Code = _ctx.StringValue("ListSkillGroupSummaryReports.Code");
			listSkillGroupSummaryReportsResponse.Message = _ctx.StringValue("ListSkillGroupSummaryReports.Message");
			listSkillGroupSummaryReportsResponse.HttpStatusCode = _ctx.IntegerValue("ListSkillGroupSummaryReports.HttpStatusCode");

			ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport pagedSkillGroupSummaryReport = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport();
			pagedSkillGroupSummaryReport.TotalCount = _ctx.IntegerValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.TotalCount");
			pagedSkillGroupSummaryReport.PageNumber = _ctx.IntegerValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.PageNumber");
			pagedSkillGroupSummaryReport.PageSize = _ctx.IntegerValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.PageSize");

			List<ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport> pagedSkillGroupSummaryReport_list = new List<ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport>();
			for (int i = 0; i < _ctx.Length("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List.Length"); i++) {
				ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport skillGroupSummaryReport = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport();
				skillGroupSummaryReport.InstanceId = _ctx.StringValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].InstanceId");
				skillGroupSummaryReport.SkillGroupId = _ctx.StringValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupId");
				skillGroupSummaryReport.SkillGroupName = _ctx.StringValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupName");

				ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Overall overall = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Overall();
				overall.TotalCalls = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalCalls");
				overall.TotalLoggedInTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalBreakTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalBreakTime");
				overall.OccupancyRate = _ctx.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.OccupancyRate");
				overall.TotalReadyTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalReadyTime");
				overall.MaxReadyTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageReadyTime");
				overall.TotalTalkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalWorkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionIndex = _ctx.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionSurveysResponded");
				skillGroupSummaryReport.Overall = overall;

				ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Inbound inbound = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Inbound();
				inbound.CallsOffered = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = _ctx.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageRingTime");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalTalkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = _ctx.StringValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalWorkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.InComingQueueOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.InComingQueueOfQueueCount");
				inbound.AnsweredByAgentOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueCount");
				inbound.GiveUpByAgentOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.GiveUpByAgentOfQueueCount");
				inbound.AbandonedInQueueOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AbandonedInQueueOfQueueCount");
				inbound.OverFlowInQueueOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.OverFlowInQueueOfQueueCount");
				inbound.QueueWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.QueueWaitTimeDuration");
				inbound.AnsweredByAgentOfQueueWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueWaitTimeDuration");
				inbound.QueueMaxWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.QueueMaxWaitTimeDuration");
				inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration");
				skillGroupSummaryReport.Inbound = inbound;

				ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Outbound outbound = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Outbound();
				outbound.CallsDialed = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = _ctx.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageDialingTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalWorkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				skillGroupSummaryReport.Outbound = outbound;

				pagedSkillGroupSummaryReport_list.Add(skillGroupSummaryReport);
			}
			pagedSkillGroupSummaryReport.List = pagedSkillGroupSummaryReport_list;
			listSkillGroupSummaryReportsResponse.PagedSkillGroupSummaryReport = pagedSkillGroupSummaryReport;
        
			return listSkillGroupSummaryReportsResponse;
        }
    }
}
