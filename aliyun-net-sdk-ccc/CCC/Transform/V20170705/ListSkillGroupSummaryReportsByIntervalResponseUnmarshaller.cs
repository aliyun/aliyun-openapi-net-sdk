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
        public static ListSkillGroupSummaryReportsByIntervalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSkillGroupSummaryReportsByIntervalResponse listSkillGroupSummaryReportsByIntervalResponse = new ListSkillGroupSummaryReportsByIntervalResponse();

			listSkillGroupSummaryReportsByIntervalResponse.HttpResponse = _ctx.HttpResponse;
			listSkillGroupSummaryReportsByIntervalResponse.RequestId = _ctx.StringValue("ListSkillGroupSummaryReportsByInterval.RequestId");
			listSkillGroupSummaryReportsByIntervalResponse.Success = _ctx.BooleanValue("ListSkillGroupSummaryReportsByInterval.Success");
			listSkillGroupSummaryReportsByIntervalResponse.Code = _ctx.StringValue("ListSkillGroupSummaryReportsByInterval.Code");
			listSkillGroupSummaryReportsByIntervalResponse.Message = _ctx.StringValue("ListSkillGroupSummaryReportsByInterval.Message");
			listSkillGroupSummaryReportsByIntervalResponse.HttpStatusCode = _ctx.IntegerValue("ListSkillGroupSummaryReportsByInterval.HttpStatusCode");

			ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport pagedSkillGroupSummaryReport = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport();
			pagedSkillGroupSummaryReport.TotalCount = _ctx.IntegerValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.TotalCount");
			pagedSkillGroupSummaryReport.PageNumber = _ctx.IntegerValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.PageNumber");
			pagedSkillGroupSummaryReport.PageSize = _ctx.IntegerValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.PageSize");

			List<ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport> pagedSkillGroupSummaryReport_list = new List<ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport>();
			for (int i = 0; i < _ctx.Length("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List.Length"); i++) {
				ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport skillGroupTimeIntervalReport = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport();
				skillGroupTimeIntervalReport.SkillGroupId = _ctx.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].SkillGroupId");

				List<ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport> skillGroupTimeIntervalReport_intervalList = new List<ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport>();
				for (int j = 0; j < _ctx.Length("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList.Length"); j++) {
					ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport skillGroupSummaryReport = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport();
					skillGroupSummaryReport.Timestamp = _ctx.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Timestamp");
					skillGroupSummaryReport.InstanceId = _ctx.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].InstanceId");
					skillGroupSummaryReport.SkillGroupId = _ctx.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].SkillGroupId");
					skillGroupSummaryReport.SkillGroupName = _ctx.StringValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].SkillGroupName");

					ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Overall overall = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Overall();
					overall.TotalCalls = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalCalls");
					overall.TotalLoggedInTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalLoggedInTime");
					overall.TotalBreakTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalBreakTime");
					overall.OccupancyRate = _ctx.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.OccupancyRate");
					overall.TotalReadyTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalReadyTime");
					overall.MaxReadyTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxReadyTime");
					overall.AverageReadyTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageReadyTime");
					overall.TotalTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalTalkTime");
					overall.MaxTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxTalkTime");
					overall.AverageTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageTalkTime");
					overall.TotalWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.TotalWorkTime");
					overall.MaxWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.MaxWorkTime");
					overall.AverageWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.AverageWorkTime");
					overall.SatisfactionIndex = _ctx.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionIndex");
					overall.SatisfactionSurveysOffered = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionSurveysOffered");
					overall.SatisfactionSurveysResponded = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Overall.SatisfactionSurveysResponded");
					skillGroupSummaryReport.Overall = overall;

					ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Inbound inbound = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Inbound();
					inbound.CallsOffered = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.CallsOffered");
					inbound.CallsHandled = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.CallsHandled");
					inbound.HandleRate = _ctx.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.HandleRate");
					inbound.TotalRingTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalRingTime");
					inbound.MaxRingTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxRingTime");
					inbound.AverageRingTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageRingTime");
					inbound.ServiceLevel20 = _ctx.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.ServiceLevel20");
					inbound.TotalTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalTalkTime");
					inbound.MaxTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxTalkTime");
					inbound.AverageTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageTalkTime");
					inbound.TotalWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.TotalWorkTime");
					inbound.MaxWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.MaxWorkTime");
					inbound.AverageWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AverageWorkTime");
					inbound.SatisfactionIndex = _ctx.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionIndex");
					inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionSurveysOffered");
					inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.SatisfactionSurveysResponded");
					inbound.InComingQueueOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.InComingQueueOfQueueCount");
					inbound.AnsweredByAgentOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AnsweredByAgentOfQueueCount");
					inbound.GiveUpByAgentOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.GiveUpByAgentOfQueueCount");
					inbound.AbandonedInQueueOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AbandonedInQueueOfQueueCount");
					inbound.OverFlowInQueueOfQueueCount = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.OverFlowInQueueOfQueueCount");
					inbound.QueueWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.QueueWaitTimeDuration");
					inbound.AnsweredByAgentOfQueueWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AnsweredByAgentOfQueueWaitTimeDuration");
					inbound.QueueMaxWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.QueueMaxWaitTimeDuration");
					inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Inbound.AnsweredByAgentOfQueueMaxWaitTimeDuration");
					skillGroupSummaryReport.Inbound = inbound;

					ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Outbound outbound = new ListSkillGroupSummaryReportsByIntervalResponse.ListSkillGroupSummaryReportsByInterval_PagedSkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_SkillGroupTimeIntervalReport.ListSkillGroupSummaryReportsByInterval_SkillGroupSummaryReport.ListSkillGroupSummaryReportsByInterval_Outbound();
					outbound.CallsDialed = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.CallsDialed");
					outbound.CallsAnswered = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.CallsAnswered");
					outbound.AnswerRate = _ctx.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AnswerRate");
					outbound.TotalDialingTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalDialingTime");
					outbound.MaxDialingTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxDialingTime");
					outbound.AverageDialingTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageDialingTime");
					outbound.TotalTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalTalkTime");
					outbound.MaxTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxTalkTime");
					outbound.AverageTalkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageTalkTime");
					outbound.TotalWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.TotalWorkTime");
					outbound.MaxWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.MaxWorkTime");
					outbound.AverageWorkTime = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.AverageWorkTime");
					outbound.SatisfactionIndex = _ctx.FloatValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionIndex");
					outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionSurveysOffered");
					outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListSkillGroupSummaryReportsByInterval.PagedSkillGroupSummaryReport.List["+ i +"].IntervalList["+ j +"].Outbound.SatisfactionSurveysResponded");
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
