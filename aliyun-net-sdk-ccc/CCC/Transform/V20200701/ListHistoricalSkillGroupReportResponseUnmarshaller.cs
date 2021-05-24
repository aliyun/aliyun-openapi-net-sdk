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
    public class ListHistoricalSkillGroupReportResponseUnmarshaller
    {
        public static ListHistoricalSkillGroupReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListHistoricalSkillGroupReportResponse listHistoricalSkillGroupReportResponse = new ListHistoricalSkillGroupReportResponse();

			listHistoricalSkillGroupReportResponse.HttpResponse = _ctx.HttpResponse;
			listHistoricalSkillGroupReportResponse.Code = _ctx.StringValue("ListHistoricalSkillGroupReport.Code");
			listHistoricalSkillGroupReportResponse.HttpStatusCode = _ctx.IntegerValue("ListHistoricalSkillGroupReport.HttpStatusCode");
			listHistoricalSkillGroupReportResponse.Message = _ctx.StringValue("ListHistoricalSkillGroupReport.Message");
			listHistoricalSkillGroupReportResponse.RequestId = _ctx.StringValue("ListHistoricalSkillGroupReport.RequestId");

			ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data data = new ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data();
			data.PageNumber = _ctx.IntegerValue("ListHistoricalSkillGroupReport.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListHistoricalSkillGroupReport.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListHistoricalSkillGroupReport.Data.TotalCount");

			List<ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items> data_list = new List<ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items>();
			for (int i = 0; i < _ctx.Length("ListHistoricalSkillGroupReport.Data.List.Length"); i++) {
				ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items items = new ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items();
				items.SkillGroupId = _ctx.StringValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].SkillGroupId");
				items.SkillGroupName = _ctx.StringValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].SkillGroupName");

				ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Inbound inbound = new ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Inbound();
				inbound.AbandonRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AbandonRate");
				inbound.AverageAbandonTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageAbandonTime");
				inbound.AverageAbandonedInQueueTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageAbandonedInQueueTime");
				inbound.AverageAbandonedInRingTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageAbandonedInRingTime");
				inbound.AverageRingTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageRingTime");
				inbound.AverageTalkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageTalkTime");
				inbound.AverageWaitTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageWaitTime");
				inbound.AverageWorkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageWorkTime");
				inbound.CallsAbandoned = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsAbandoned");
				inbound.CallsAbandonedInQueue = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsAbandonedInQueue");
				inbound.CallsAbandonedInRinging = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsAbandonedInRinging");
				inbound.CallsConsulted = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsConsulted");
				inbound.CallsHandled = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsHandled");
				inbound.CallsHold = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsHold");
				inbound.CallsOffered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsQueued = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsQueued");
				inbound.CallsRinged = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsRinged");
				inbound.CallsTransferred = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsTransferred");
				inbound.HandleRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.HandleRate");
				inbound.MaxAbandonTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxAbandonTime");
				inbound.MaxAbandonedInQueueTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxAbandonedInQueueTime");
				inbound.MaxAbandonedInRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxAbandonedInRingTime");
				inbound.MaxRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxRingTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxWaitTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxWaitTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxWorkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalAbandonTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalAbandonTime");
				inbound.TotalAbandonedInQueueTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalAbandonedInQueueTime");
				inbound.TotalAbandonedInRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalAbandonedInRingTime");
				inbound.TotalHoldTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalHoldTime");
				inbound.TotalRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalRingTime");
				inbound.TotalTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalTalkTime");
				inbound.TotalWaitTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalWaitTime");
				inbound.TotalWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalWorkTime");
				items.Inbound = inbound;

				ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Outbound outbound = new ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Outbound();
				outbound.AnswerRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AnswerRate");
				outbound.AverageDialingTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AverageDialingTime");
				outbound.AverageTalkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AverageTalkTime");
				outbound.AverageWorkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AverageWorkTime");
				outbound.CallsAnswered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsAnswered");
				outbound.CallsDialed = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsDialed");
				outbound.MaxDialingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.MaxDialingTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.MaxTalkTime");
				outbound.MaxWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.MaxWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.TotalDialingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalHoldTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.TotalHoldTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.TotalTalkTime");
				outbound.TotalWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.TotalWorkTime");
				items.Outbound = outbound;

				ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Overall overall = new ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Overall();
				overall.AverageBreakTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.AverageBreakTime");
				overall.AverageReadyTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.AverageReadyTime");
				overall.AverageTalkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.AverageTalkTime");
				overall.AverageWorkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.AverageWorkTime");
				overall.MaxBreakTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.MaxBreakTime");
				overall.MaxReadyTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.MaxReadyTime");
				overall.MaxTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.MaxTalkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.MaxWorkTime");
				overall.OccupancyRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.OccupancyRate");
				overall.SatisfactionIndex = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.TotalBreakTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalBreakTime");
				overall.TotalCalls = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalCalls");
				overall.TotalHoldTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalHoldTime");
				overall.TotalLoggedInTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalReadyTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalReadyTime");
				overall.TotalTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalTalkTime");
				overall.TotalWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalWorkTime");
				items.Overall = overall;

				data_list.Add(items);
			}
			data.List = data_list;
			listHistoricalSkillGroupReportResponse.Data = data;
        
			return listHistoricalSkillGroupReportResponse;
        }
    }
}
