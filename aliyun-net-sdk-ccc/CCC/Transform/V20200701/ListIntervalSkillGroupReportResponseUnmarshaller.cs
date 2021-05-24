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
    public class ListIntervalSkillGroupReportResponseUnmarshaller
    {
        public static ListIntervalSkillGroupReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIntervalSkillGroupReportResponse listIntervalSkillGroupReportResponse = new ListIntervalSkillGroupReportResponse();

			listIntervalSkillGroupReportResponse.HttpResponse = _ctx.HttpResponse;
			listIntervalSkillGroupReportResponse.Code = _ctx.StringValue("ListIntervalSkillGroupReport.Code");
			listIntervalSkillGroupReportResponse.HttpStatusCode = _ctx.IntegerValue("ListIntervalSkillGroupReport.HttpStatusCode");
			listIntervalSkillGroupReportResponse.Message = _ctx.StringValue("ListIntervalSkillGroupReport.Message");
			listIntervalSkillGroupReportResponse.RequestId = _ctx.StringValue("ListIntervalSkillGroupReport.RequestId");

			List<ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem> listIntervalSkillGroupReportResponse_data = new List<ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem>();
			for (int i = 0; i < _ctx.Length("ListIntervalSkillGroupReport.Data.Length"); i++) {
				ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem dataItem = new ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem();
				dataItem.StatsTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].StatsTime");

				ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Inbound inbound = new ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Inbound();
				inbound.AbandonRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AbandonRate");
				inbound.AverageAbandonTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageAbandonTime");
				inbound.AverageAbandonedInQueueTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageAbandonedInQueueTime");
				inbound.AverageAbandonedInRingTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageAbandonedInRingTime");
				inbound.AverageRingTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageRingTime");
				inbound.AverageTalkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageTalkTime");
				inbound.AverageWaitTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageWaitTime");
				inbound.AverageWorkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageWorkTime");
				inbound.CallsAbandoned = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsAbandoned");
				inbound.CallsAbandonedInQueue = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsAbandonedInQueue");
				inbound.CallsAbandonedInRinging = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsAbandonedInRinging");
				inbound.CallsConsulted = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsConsulted");
				inbound.CallsHandled = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsHandled");
				inbound.CallsHold = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsHold");
				inbound.CallsOffered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsOffered");
				inbound.CallsQueued = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsQueued");
				inbound.CallsRinged = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsRinged");
				inbound.CallsTransferred = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsTransferred");
				inbound.HandleRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.HandleRate");
				inbound.MaxAbandonTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxAbandonTime");
				inbound.MaxAbandonedInQueueTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxAbandonedInQueueTime");
				inbound.MaxAbandonedInRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxAbandonedInRingTime");
				inbound.MaxRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxRingTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxWaitTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxWaitTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxWorkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalAbandonTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalAbandonTime");
				inbound.TotalAbandonedInQueueTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalAbandonedInQueueTime");
				inbound.TotalAbandonedInRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalAbandonedInRingTime");
				inbound.TotalHoldTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalHoldTime");
				inbound.TotalRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalRingTime");
				inbound.TotalTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalTalkTime");
				inbound.TotalWaitTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalWaitTime");
				inbound.TotalWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalWorkTime");
				dataItem.Inbound = inbound;

				ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Outbound outbound = new ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Outbound();
				outbound.AnswerRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AnswerRate");
				outbound.AverageDialingTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AverageDialingTime");
				outbound.AverageTalkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AverageTalkTime");
				outbound.AverageWorkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AverageWorkTime");
				outbound.CallsAnswered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsAnswered");
				outbound.CallsDialed = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsDialed");
				outbound.MaxDialingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.MaxDialingTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.MaxTalkTime");
				outbound.MaxWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.MaxWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.TotalDialingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalHoldTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.TotalHoldTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.TotalTalkTime");
				outbound.TotalWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.TotalWorkTime");
				dataItem.Outbound = outbound;

				ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Overall overall = new ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Overall();
				overall.AverageBreakTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.AverageBreakTime");
				overall.AverageReadyTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.AverageReadyTime");
				overall.AverageTalkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.AverageTalkTime");
				overall.AverageWorkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.AverageWorkTime");
				overall.MaxBreakTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.MaxBreakTime");
				overall.MaxReadyTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.MaxReadyTime");
				overall.MaxTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.MaxTalkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.MaxWorkTime");
				overall.OccupancyRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.OccupancyRate");
				overall.SatisfactionIndex = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.TotalBreakTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalBreakTime");
				overall.TotalCalls = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalCalls");
				overall.TotalHoldTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalHoldTime");
				overall.TotalLoggedInTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalReadyTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalReadyTime");
				overall.TotalTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalTalkTime");
				overall.TotalWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalWorkTime");
				dataItem.Overall = overall;

				listIntervalSkillGroupReportResponse_data.Add(dataItem);
			}
			listIntervalSkillGroupReportResponse.Data = listIntervalSkillGroupReportResponse_data;
        
			return listIntervalSkillGroupReportResponse;
        }
    }
}
