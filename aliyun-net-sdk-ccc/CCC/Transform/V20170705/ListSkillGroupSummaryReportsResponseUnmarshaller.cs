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
        public static ListSkillGroupSummaryReportsResponse Unmarshall(UnmarshallerContext context)
        {
			ListSkillGroupSummaryReportsResponse listSkillGroupSummaryReportsResponse = new ListSkillGroupSummaryReportsResponse();

			listSkillGroupSummaryReportsResponse.HttpResponse = context.HttpResponse;
			listSkillGroupSummaryReportsResponse.RequestId = context.StringValue("ListSkillGroupSummaryReports.RequestId");
			listSkillGroupSummaryReportsResponse.Success = context.BooleanValue("ListSkillGroupSummaryReports.Success");
			listSkillGroupSummaryReportsResponse.Code = context.StringValue("ListSkillGroupSummaryReports.Code");
			listSkillGroupSummaryReportsResponse.Message = context.StringValue("ListSkillGroupSummaryReports.Message");
			listSkillGroupSummaryReportsResponse.HttpStatusCode = context.IntegerValue("ListSkillGroupSummaryReports.HttpStatusCode");

			ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport pagedSkillGroupSummaryReport = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport();
			pagedSkillGroupSummaryReport.TotalCount = context.IntegerValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.TotalCount");
			pagedSkillGroupSummaryReport.PageNumber = context.IntegerValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.PageNumber");
			pagedSkillGroupSummaryReport.PageSize = context.IntegerValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.PageSize");

			List<ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport> pagedSkillGroupSummaryReport_list = new List<ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport>();
			for (int i = 0; i < context.Length("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List.Length"); i++) {
				ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport skillGroupSummaryReport = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport();
				skillGroupSummaryReport.InstanceId = context.StringValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].InstanceId");
				skillGroupSummaryReport.SkillGroupId = context.StringValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupId");
				skillGroupSummaryReport.SkillGroupName = context.StringValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupName");

				ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Overall overall = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Overall();
				overall.TotalCalls = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalCalls");
				overall.TotalLoggedInTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalBreakTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalBreakTime");
				overall.OccupancyRate = context.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.OccupancyRate");
				overall.TotalReadyTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalReadyTime");
				overall.MaxReadyTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageReadyTime");
				overall.TotalTalkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageTalkTime");
				overall.TotalWorkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionIndex = context.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Overall.SatisfactionSurveysResponded");
				skillGroupSummaryReport.Overall = overall;

				ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Inbound inbound = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Inbound();
				inbound.CallsOffered = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = context.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageRingTime");
				inbound.ServiceLevel20 = context.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalTalkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = context.StringValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalWorkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionIndex = context.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.InComingQueueOfQueueCount = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.InComingQueueOfQueueCount");
				inbound.AnsweredByAgentOfQueueCount = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueCount");
				inbound.GiveUpByAgentOfQueueCount = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.GiveUpByAgentOfQueueCount");
				inbound.AbandonedInQueueOfQueueCount = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AbandonedInQueueOfQueueCount");
				inbound.OverFlowInQueueOfQueueCount = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.OverFlowInQueueOfQueueCount");
				inbound.QueueWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.QueueWaitTimeDuration");
				inbound.AnsweredByAgentOfQueueWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueWaitTimeDuration");
				inbound.QueueMaxWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.QueueMaxWaitTimeDuration");
				inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration");
				skillGroupSummaryReport.Inbound = inbound;

				ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Outbound outbound = new ListSkillGroupSummaryReportsResponse.ListSkillGroupSummaryReports_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReports_SkillGroupSummaryReport.ListSkillGroupSummaryReports_Outbound();
				outbound.CallsDialed = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = context.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageDialingTime");
				outbound.TotalTalkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalWorkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = context.FloatValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = context.LongValue("ListSkillGroupSummaryReports.PagedSkillGroupSummaryReport.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				skillGroupSummaryReport.Outbound = outbound;

				pagedSkillGroupSummaryReport_list.Add(skillGroupSummaryReport);
			}
			pagedSkillGroupSummaryReport.List = pagedSkillGroupSummaryReport_list;
			listSkillGroupSummaryReportsResponse.PagedSkillGroupSummaryReport = pagedSkillGroupSummaryReport;
        
			return listSkillGroupSummaryReportsResponse;
        }
    }
}
