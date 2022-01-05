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
				inbound.AverageRingTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageRingTime");
				inbound.CallsOverflow = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsOverflow");
				inbound.CallsAbandonedInRing = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsAbandonedInRing");
				inbound.CallsHandled = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsHandled");
				inbound.TotalWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalWorkTime");
				inbound.TotalAbandonedInRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalAbandonedInRingTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxWorkTime");
				inbound.CallsAttendedTransferOut = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsAttendedTransferOut");
				inbound.AverageWaitTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageWaitTime");
				inbound.TotalHoldTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalHoldTime");
				inbound.MaxAbandonTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxAbandonTime");
				inbound.AverageWorkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageWorkTime");
				inbound.CallsQueued = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsQueued");
				inbound.CallsBlindTransferIn = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsBlindTransferIn");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.SatisfactionIndex");
				inbound.AverageAbandonedInRingTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageAbandonedInRingTime");
				inbound.AverageAbandonTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageAbandonTime");
				inbound.CallsRinged = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsRinged");
				inbound.CallsBlindTransferOut = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsBlindTransferOut");
				inbound.CallsAttendedTransferIn = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsAttendedTransferIn");
				inbound.CallsAbandoned = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsAbandoned");
				inbound.MaxAbandonedInQueueTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxAbandonedInQueueTime");
				inbound.TotalWaitTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalWaitTime");
				inbound.TotalRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalRingTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxRingTime");
				inbound.AbandonRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AbandonRate");
				inbound.TotalTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalTalkTime");
				inbound.TotalAbandonTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalAbandonTime");
				inbound.CallsOffered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsOffered");
				inbound.MaxAbandonedInRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxAbandonedInRingTime");
				inbound.MaxWaitTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxWaitTime");
				inbound.AverageAbandonedInQueueTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageAbandonedInQueueTime");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.ServiceLevel20");
				inbound.MaxHoldTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.MaxHoldTime");
				inbound.SatisfactionRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.SatisfactionRate");
				inbound.AverageTalkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageTalkTime");
				inbound.CallsHold = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsHold");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.HandleRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.HandleRate");
				inbound.CallsTimeout = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsTimeout");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.AverageHoldTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.AverageHoldTime");
				inbound.TotalAbandonedInQueueTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.TotalAbandonedInQueueTime");
				inbound.CallsAbandonedInQueue = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Inbound.CallsAbandonedInQueue");
				dataItem.Inbound = inbound;

				ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Outbound outbound = new ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Outbound();
				outbound.AverageRingTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AverageRingTime");
				outbound.CallsDialed = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsAnswered");
				outbound.TotalWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.TotalWorkTime");
				outbound.CallsAttendedTransferOut = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsAttendedTransferOut");
				outbound.MaxWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.MaxWorkTime");
				outbound.TotalDialingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalHoldTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.TotalHoldTime");
				outbound.AverageWorkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AverageWorkTime");
				outbound.CallsBlindTransferIn = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsBlindTransferIn");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.SatisfactionIndex");
				outbound.CallsRinged = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsRinged");
				outbound.CallsAttendedTransferIn = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsAttendedTransferIn");
				outbound.CallsBlindTransferOut = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsBlindTransferOut");
				outbound.TotalRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.TotalRingTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.MaxTalkTime");
				outbound.MaxRingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.MaxRingTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxDialingTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.MaxDialingTime");
				outbound.AnswerRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AnswerRate");
				outbound.MaxHoldTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.MaxHoldTime");
				outbound.AverageTalkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AverageTalkTime");
				outbound.SatisfactionRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.SatisfactionRate");
				outbound.CallsHold = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.CallsHold");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.AverageHoldTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AverageHoldTime");
				outbound.AverageDialingTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Outbound.AverageDialingTime");
				dataItem.Outbound = outbound;

				ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Overall overall = new ListIntervalSkillGroupReportResponse.ListIntervalSkillGroupReport_DataItem.ListIntervalSkillGroupReport_Overall();
				overall.TotalTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalTalkTime");
				overall.TotalLoggedInTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalLoggedInTime");
				overall.OccupancyRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.OccupancyRate");
				overall.TotalWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalWorkTime");
				overall.MaxHoldTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.MaxHoldTime");
				overall.MaxWorkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.MaxWorkTime");
				overall.AverageBreakTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.AverageBreakTime");
				overall.TotalHoldTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalHoldTime");
				overall.SatisfactionRate = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.SatisfactionRate");
				overall.MaxBreakTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.MaxBreakTime");
				overall.AverageWorkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.AverageWorkTime");
				overall.AverageTalkTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.AverageTalkTime");
				overall.SatisfactionIndex = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.MaxReadyTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.AverageReadyTime");
				overall.AverageHoldTime = _ctx.FloatValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.AverageHoldTime");
				overall.TotalReadyTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalReadyTime");
				overall.TotalBreakTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalBreakTime");
				overall.MaxTalkTime = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.MaxTalkTime");
				overall.TotalCalls = _ctx.LongValue("ListIntervalSkillGroupReport.Data["+ i +"].Overall.TotalCalls");
				dataItem.Overall = overall;

				listIntervalSkillGroupReportResponse_data.Add(dataItem);
			}
			listIntervalSkillGroupReportResponse.Data = listIntervalSkillGroupReportResponse_data;
        
			return listIntervalSkillGroupReportResponse;
        }
    }
}
