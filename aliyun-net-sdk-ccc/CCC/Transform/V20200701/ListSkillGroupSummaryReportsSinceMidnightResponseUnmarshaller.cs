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
    public class ListSkillGroupSummaryReportsSinceMidnightResponseUnmarshaller
    {
        public static ListSkillGroupSummaryReportsSinceMidnightResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSkillGroupSummaryReportsSinceMidnightResponse listSkillGroupSummaryReportsSinceMidnightResponse = new ListSkillGroupSummaryReportsSinceMidnightResponse();

			listSkillGroupSummaryReportsSinceMidnightResponse.HttpResponse = _ctx.HttpResponse;
			listSkillGroupSummaryReportsSinceMidnightResponse.HttpStatusCode = _ctx.IntegerValue("ListSkillGroupSummaryReportsSinceMidnight.HttpStatusCode");
			listSkillGroupSummaryReportsSinceMidnightResponse.Code = _ctx.StringValue("ListSkillGroupSummaryReportsSinceMidnight.Code");
			listSkillGroupSummaryReportsSinceMidnightResponse.Message = _ctx.StringValue("ListSkillGroupSummaryReportsSinceMidnight.Message");
			listSkillGroupSummaryReportsSinceMidnightResponse.RequestId = _ctx.StringValue("ListSkillGroupSummaryReportsSinceMidnight.RequestId");
			listSkillGroupSummaryReportsSinceMidnightResponse.Success = _ctx.BooleanValue("ListSkillGroupSummaryReportsSinceMidnight.Success");

			ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport pagedSkillGroupSummaryReport = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport();
			pagedSkillGroupSummaryReport.PageNumber = _ctx.IntegerValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.PageNumber");
			pagedSkillGroupSummaryReport.PageSize = _ctx.IntegerValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.PageSize");
			pagedSkillGroupSummaryReport.TotalCount = _ctx.IntegerValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.TotalCount");

			List<ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport> pagedSkillGroupSummaryReport_list = new List<ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport>();
			for (int i = 0; i < _ctx.Length("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List.Length"); i++) {
				ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport skillGroupSummaryReport = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport();
				skillGroupSummaryReport.Timestamp = _ctx.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Timestamp");
				skillGroupSummaryReport.InstanceId = _ctx.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].InstanceId");
				skillGroupSummaryReport.SkillGroupName = _ctx.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupName");
				skillGroupSummaryReport.SkillGroupId = _ctx.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupId");

				ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Overall overall = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Overall();
				overall.TotalLoggedInTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalTalkTime");
				overall.OccupancyRate = _ctx.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.OccupancyRate");
				overall.TotalWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageWorkTime");
				overall.AverageTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageTalkTime");
				overall.SatisfactionIndex = _ctx.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.MaxReadyTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageReadyTime");
				overall.TotalBreakTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalBreakTime");
				overall.TotalReadyTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalReadyTime");
				overall.MaxTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxTalkTime");
				overall.TotalCalls = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalCalls");
				skillGroupSummaryReport.Overall = overall;

				ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Inbound inbound = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Inbound();
				inbound.AverageRingTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageRingTime");
				inbound.CallsHandled = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsHandled");
				inbound.TotalWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxWorkTime");
				inbound.QueueMaxWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.QueueMaxWaitTimeDuration");
				inbound.AverageWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.AnsweredByAgentOfQueueWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueWaitTimeDuration");
				inbound.TotalRingTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalRingTime");
				inbound.InComingQueueOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.InComingQueueOfQueueCount");
				inbound.MaxTalkTime = _ctx.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxRingTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxRingTime");
				inbound.TotalTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalTalkTime");
				inbound.CallsOffered = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsOffered");
				inbound.AbandonedInQueueOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AbandonedInQueueOfQueueCount");
				inbound.OverFlowInQueueOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.OverFlowInQueueOfQueueCount");
				inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.ServiceLevel20");
				inbound.AverageTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageTalkTime");
				inbound.AnsweredByAgentOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueCount");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.HandleRate = _ctx.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.HandleRate");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.GiveUpByAgentOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.GiveUpByAgentOfQueueCount");
				inbound.QueueWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.QueueWaitTimeDuration");
				inbound.CallsServiceLevel20 = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsServiceLevel20");
				inbound.CallsServiceLevel30 = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsServiceLevel30");
				skillGroupSummaryReport.Inbound = inbound;

				ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Outbound outbound = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Outbound();
				outbound.TotalTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxDialingTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxDialingTime");
				outbound.CallsDialed = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = _ctx.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxWorkTime");
				outbound.TotalDialingTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalDialingTime");
				outbound.AverageTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageTalkTime");
				outbound.AverageWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.MaxTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageDialingTime = _ctx.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageDialingTime");
				skillGroupSummaryReport.Outbound = outbound;

				pagedSkillGroupSummaryReport_list.Add(skillGroupSummaryReport);
			}
			pagedSkillGroupSummaryReport.List = pagedSkillGroupSummaryReport_list;
			listSkillGroupSummaryReportsSinceMidnightResponse.PagedSkillGroupSummaryReport = pagedSkillGroupSummaryReport;
        
			return listSkillGroupSummaryReportsSinceMidnightResponse;
        }
    }
}
