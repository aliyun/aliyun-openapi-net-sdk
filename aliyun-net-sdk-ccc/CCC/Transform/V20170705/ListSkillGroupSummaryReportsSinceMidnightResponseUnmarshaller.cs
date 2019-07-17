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
    public class ListSkillGroupSummaryReportsSinceMidnightResponseUnmarshaller
    {
        public static ListSkillGroupSummaryReportsSinceMidnightResponse Unmarshall(UnmarshallerContext context)
        {
			ListSkillGroupSummaryReportsSinceMidnightResponse listSkillGroupSummaryReportsSinceMidnightResponse = new ListSkillGroupSummaryReportsSinceMidnightResponse();

			listSkillGroupSummaryReportsSinceMidnightResponse.HttpResponse = context.HttpResponse;
			listSkillGroupSummaryReportsSinceMidnightResponse.RequestId = context.StringValue("ListSkillGroupSummaryReportsSinceMidnight.RequestId");
			listSkillGroupSummaryReportsSinceMidnightResponse.Success = context.BooleanValue("ListSkillGroupSummaryReportsSinceMidnight.Success");
			listSkillGroupSummaryReportsSinceMidnightResponse.Code = context.StringValue("ListSkillGroupSummaryReportsSinceMidnight.Code");
			listSkillGroupSummaryReportsSinceMidnightResponse.Message = context.StringValue("ListSkillGroupSummaryReportsSinceMidnight.Message");
			listSkillGroupSummaryReportsSinceMidnightResponse.HttpStatusCode = context.IntegerValue("ListSkillGroupSummaryReportsSinceMidnight.HttpStatusCode");

			ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport pagedSkillGroupSummaryReport = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport();
			pagedSkillGroupSummaryReport.TotalCount = context.IntegerValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.TotalCount");
			pagedSkillGroupSummaryReport.PageNumber = context.IntegerValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.PageNumber");
			pagedSkillGroupSummaryReport.PageSize = context.IntegerValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.PageSize");

			List<ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport> pagedSkillGroupSummaryReport_list = new List<ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport>();
			for (int i = 0; i < context.Length("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List.Length"); i++) {
				ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport skillGroupSummaryReport = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport();
				skillGroupSummaryReport.Timestamp = context.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Timestamp");
				skillGroupSummaryReport.InstanceId = context.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].InstanceId");
				skillGroupSummaryReport.SkillGroupId = context.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupId");
				skillGroupSummaryReport.SkillGroupName = context.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupName");

				ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Overall overall = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Overall();
				overall.TotalCalls = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalCalls");
				overall.TotalLoggedInTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalBreakTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalBreakTime");
				overall.OccupancyRate = context.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.OccupancyRate");
				overall.TotalReadyTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalReadyTime");
				overall.MaxReadyTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageReadyTime");
				overall.TotalTalkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalWorkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionIndex = context.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionSurveysResponded");
				skillGroupSummaryReport.Overall = overall;

				ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Inbound inbound = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Inbound();
				inbound.CallsOffered = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = context.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageRingTime");
				inbound.ServiceLevel20 = context.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalTalkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = context.StringValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalWorkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionIndex = context.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.InComingQueueOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.InComingQueueOfQueueCount");
				inbound.AnsweredByAgentOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueCount");
				inbound.GiveUpByAgentOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.GiveUpByAgentOfQueueCount");
				inbound.AbandonedInQueueOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AbandonedInQueueOfQueueCount");
				inbound.OverFlowInQueueOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.OverFlowInQueueOfQueueCount");
				inbound.QueueWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.QueueWaitTimeDuration");
				inbound.AnsweredByAgentOfQueueWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueWaitTimeDuration");
				inbound.QueueMaxWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.QueueMaxWaitTimeDuration");
				inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration");
				skillGroupSummaryReport.Inbound = inbound;

				ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Outbound outbound = new ListSkillGroupSummaryReportsSinceMidnightResponse.ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport.ListSkillGroupSummaryReportsSinceMidnight_Outbound();
				outbound.CallsDialed = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = context.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageDialingTime");
				outbound.TotalTalkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalWorkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = context.FloatValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = context.LongValue("ListSkillGroupSummaryReportsSinceMidnight.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				skillGroupSummaryReport.Outbound = outbound;

				pagedSkillGroupSummaryReport_list.Add(skillGroupSummaryReport);
			}
			pagedSkillGroupSummaryReport.List = pagedSkillGroupSummaryReport_list;
			listSkillGroupSummaryReportsSinceMidnightResponse.PagedSkillGroupSummaryReport = pagedSkillGroupSummaryReport;
        
			return listSkillGroupSummaryReportsSinceMidnightResponse;
        }
    }
}
