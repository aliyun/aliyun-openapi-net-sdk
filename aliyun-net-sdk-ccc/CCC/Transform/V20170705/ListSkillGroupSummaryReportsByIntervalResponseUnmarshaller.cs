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
    public class ListSkillGroupSummaryReportsByIntervalResponseUnmarshaller
    {
        public static ListSkillGroupSummaryReportsByIntervalResponse Unmarshall(UnmarshallerContext context)
        {
			ListSkillGroupSummaryReportsByIntervalResponse listSkillGroupSummaryReportsByIntervalResponse = new ListSkillGroupSummaryReportsByIntervalResponse();

			listSkillGroupSummaryReportsByIntervalResponse.HttpResponse = context.HttpResponse;
			listSkillGroupSummaryReportsByIntervalResponse.RequestId = context.StringValue("ListSkillGroupSummaryReportsByInterval.RequestId");
			listSkillGroupSummaryReportsByIntervalResponse.Success = context.BooleanValue("ListSkillGroupSummaryReportsByInterval.Success");
			listSkillGroupSummaryReportsByIntervalResponse.Code = context.StringValue("ListSkillGroupSummaryReportsByInterval.Code");
			listSkillGroupSummaryReportsByIntervalResponse.Message = context.StringValue("ListSkillGroupSummaryReportsByInterval.Message");
			listSkillGroupSummaryReportsByIntervalResponse.HttpStatusCode = context.IntegerValue("ListSkillGroupSummaryReportsByInterval.HttpStatusCode");

			ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport pagedSkillGroupSummaryReport = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport();
			pagedSkillGroupSummaryReport.TotalCount = context.IntegerValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.TotalCount");
			pagedSkillGroupSummaryReport.PageNumber = context.IntegerValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.PageNumber");
			pagedSkillGroupSummaryReport.PageSize = context.IntegerValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.PageSize");

			List<ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport> pagedSkillGroupSummaryReport_list = new List<ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport>();
			for (int i = 0; i < context.Length("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List.Length"); i++) {
				ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport skillGroupTimeIntervalReport = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport();
				skillGroupTimeIntervalReport.SkillGroupId = context.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupId");

				List<ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport> skillGroupTimeIntervalReport_intervalList = new List<ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport>();
				for (int j = 0; j < context.Length("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList.Length"); j++) {
					ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport skillGroupSummaryReport = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport();
					skillGroupSummaryReport.Timestamp = context.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Timestamp");
					skillGroupSummaryReport.InstanceId = context.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].InstanceId");
					skillGroupSummaryReport.SkillGroupId = context.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].SkillGroupId");
					skillGroupSummaryReport.SkillGroupName = context.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].SkillGroupName");

					ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Overall overall = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Overall();
					overall.TotalCalls = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalCalls");
					overall.TotalLoggedInTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalLoggedInTime");
					overall.TotalBreakTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalBreakTime");
					overall.OccupancyRate = context.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.OccupancyRate");
					overall.TotalReadyTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalReadyTime");
					overall.MaxReadyTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxReadyTime");
					overall.AverageReadyTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageReadyTime");
					overall.TotalTalkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalTalkTime");
					overall.MaxTalkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxTalkTime");
					overall.AverageTalkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageTalkTime");
					overall.TotalWorkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalWorkTime");
					overall.MaxWorkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxWorkTime");
					overall.AverageWorkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageWorkTime");
					overall.SatisfactionIndex = context.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionIndex");
					overall.SatisfactionSurveysOffered = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionSurveysOffered");
					overall.SatisfactionSurveysResponded = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionSurveysResponded");
					skillGroupSummaryReport.Overall = overall;

					ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Inbound inbound = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Inbound();
					inbound.CallsOffered = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.CallsOffered");
					inbound.CallsHandled = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.CallsHandled");
					inbound.HandleRate = context.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.HandleRate");
					inbound.TotalRingTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalRingTime");
					inbound.MaxRingTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxRingTime");
					inbound.AverageRingTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageRingTime");
					inbound.ServiceLevel20 = context.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.ServiceLevel20");
					inbound.TotalTalkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalTalkTime");
					inbound.MaxTalkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxTalkTime");
					inbound.AverageTalkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageTalkTime");
					inbound.TotalWorkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalWorkTime");
					inbound.MaxWorkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxWorkTime");
					inbound.AverageWorkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageWorkTime");
					inbound.SatisfactionIndex = context.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionIndex");
					inbound.SatisfactionSurveysOffered = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionSurveysOffered");
					inbound.SatisfactionSurveysResponded = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionSurveysResponded");
					inbound.InComingQueueOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.InComingQueueOfQueueCount");
					inbound.AnsweredByAgentOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AnsweredByAgentOfQueueCount");
					inbound.GiveUpByAgentOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.GiveUpByAgentOfQueueCount");
					inbound.AbandonedInQueueOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AbandonedInQueueOfQueueCount");
					inbound.OverFlowInQueueOfQueueCount = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.OverFlowInQueueOfQueueCount");
					inbound.QueueWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.QueueWaitTimeDuration");
					inbound.AnsweredByAgentOfQueueWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AnsweredByAgentOfQueueWaitTimeDuration");
					inbound.QueueMaxWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.QueueMaxWaitTimeDuration");
					inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration");
					skillGroupSummaryReport.Inbound = inbound;

					ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Outbound outbound = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Outbound();
					outbound.CallsDialed = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.CallsDialed");
					outbound.CallsAnswered = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.CallsAnswered");
					outbound.AnswerRate = context.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AnswerRate");
					outbound.TotalDialingTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalDialingTime");
					outbound.MaxDialingTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxDialingTime");
					outbound.AverageDialingTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageDialingTime");
					outbound.TotalTalkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalTalkTime");
					outbound.MaxTalkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxTalkTime");
					outbound.AverageTalkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageTalkTime");
					outbound.TotalWorkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalWorkTime");
					outbound.MaxWorkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxWorkTime");
					outbound.AverageWorkTime = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageWorkTime");
					outbound.SatisfactionIndex = context.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionIndex");
					outbound.SatisfactionSurveysOffered = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionSurveysOffered");
					outbound.SatisfactionSurveysResponded = context.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionSurveysResponded");
					skillGroupSummaryReport.Outbound = outbound;

					skillGroupTimeIntervalReport_intervalList.Add(skillGroupSummaryReport);
				}
				skillGroupTimeIntervalReport.IntervalList = skillGroupTimeIntervalReport_intervalList;

				pagedSkillGroupSummaryReport_list.Add(skillGroupTimeIntervalReport);
			}
			pagedSkillGroupSummaryReport.List = pagedSkillGroupSummaryReport_list;
			listSkillGroupSummaryReportsByIntervalResponse.PagedSkillGroupSummaryReport = pagedSkillGroupSummaryReport;
        
			return listSkillGroupSummaryReportsByIntervalResponse;
        }
    }
}
