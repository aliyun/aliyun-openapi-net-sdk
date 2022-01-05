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
				items.SkillGroupName = _ctx.StringValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].SkillGroupName");
				items.SkillGroupId = _ctx.StringValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].SkillGroupId");

				ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Inbound inbound = new ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Inbound();
				inbound.AverageRingTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageRingTime");
				inbound.CallsOverflow = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsOverflow");
				inbound.CallsAbandonedInRing = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsAbandonedInRing");
				inbound.CallsHandled = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsHandled");
				inbound.TotalWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalWorkTime");
				inbound.TotalAbandonedInRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalAbandonedInRingTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxWorkTime");
				inbound.CallsAttendedTransferOut = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsAttendedTransferOut");
				inbound.AverageWaitTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageWaitTime");
				inbound.TotalHoldTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalHoldTime");
				inbound.MaxAbandonTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxAbandonTime");
				inbound.AverageWorkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageWorkTime");
				inbound.CallsQueued = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsQueued");
				inbound.CallsBlindTransferIn = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsBlindTransferIn");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.AverageAbandonedInRingTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageAbandonedInRingTime");
				inbound.AverageAbandonTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageAbandonTime");
				inbound.CallsRinged = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsRinged");
				inbound.CallsBlindTransferOut = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsBlindTransferOut");
				inbound.CallsAttendedTransferIn = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsAttendedTransferIn");
				inbound.CallsAbandoned = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsAbandoned");
				inbound.MaxAbandonedInQueueTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxAbandonedInQueueTime");
				inbound.TotalWaitTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalWaitTime");
				inbound.TotalRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalRingTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxRingTime");
				inbound.AbandonRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AbandonRate");
				inbound.TotalTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalTalkTime");
				inbound.TotalAbandonTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalAbandonTime");
				inbound.CallsOffered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsOffered");
				inbound.MaxAbandonedInRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxAbandonedInRingTime");
				inbound.MaxWaitTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxWaitTime");
				inbound.AverageAbandonedInQueueTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageAbandonedInQueueTime");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.ServiceLevel20");
				inbound.MaxHoldTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.MaxHoldTime");
				inbound.SatisfactionRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.SatisfactionRate");
				inbound.AverageTalkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageTalkTime");
				inbound.CallsHold = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsHold");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.HandleRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.HandleRate");
				inbound.CallsTimeout = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsTimeout");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.AverageHoldTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.AverageHoldTime");
				inbound.TotalAbandonedInQueueTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.TotalAbandonedInQueueTime");
				inbound.CallsAbandonedInQueue = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Inbound.CallsAbandonedInQueue");
				items.Inbound = inbound;

				ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Outbound outbound = new ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Outbound();
				outbound.AverageRingTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AverageRingTime");
				outbound.CallsDialed = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsAnswered");
				outbound.TotalWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.TotalWorkTime");
				outbound.CallsAttendedTransferOut = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsAttendedTransferOut");
				outbound.MaxWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.MaxWorkTime");
				outbound.TotalDialingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalHoldTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.TotalHoldTime");
				outbound.AverageWorkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AverageWorkTime");
				outbound.CallsBlindTransferIn = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsBlindTransferIn");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.CallsRinged = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsRinged");
				outbound.CallsAttendedTransferIn = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsAttendedTransferIn");
				outbound.CallsBlindTransferOut = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsBlindTransferOut");
				outbound.TotalRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.TotalRingTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.MaxTalkTime");
				outbound.MaxRingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.MaxRingTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxDialingTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.MaxDialingTime");
				outbound.AnswerRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AnswerRate");
				outbound.MaxHoldTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.MaxHoldTime");
				outbound.AverageTalkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AverageTalkTime");
				outbound.SatisfactionRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.SatisfactionRate");
				outbound.CallsHold = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.CallsHold");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.AverageHoldTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AverageHoldTime");
				outbound.AverageDialingTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Outbound.AverageDialingTime");
				items.Outbound = outbound;

				ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Overall overall = new ListHistoricalSkillGroupReportResponse.ListHistoricalSkillGroupReport_Data.ListHistoricalSkillGroupReport_Items.ListHistoricalSkillGroupReport_Overall();
				overall.TotalTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalTalkTime");
				overall.TotalLoggedInTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalLoggedInTime");
				overall.OccupancyRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.OccupancyRate");
				overall.TotalWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalWorkTime");
				overall.MaxHoldTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.MaxHoldTime");
				overall.MaxWorkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.MaxWorkTime");
				overall.AverageBreakTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.AverageBreakTime");
				overall.TotalHoldTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalHoldTime");
				overall.SatisfactionRate = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.SatisfactionRate");
				overall.MaxBreakTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.MaxBreakTime");
				overall.AverageWorkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.AverageWorkTime");
				overall.AverageTalkTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.AverageTalkTime");
				overall.SatisfactionIndex = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.MaxReadyTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.AverageReadyTime");
				overall.AverageHoldTime = _ctx.FloatValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.AverageHoldTime");
				overall.TotalReadyTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalReadyTime");
				overall.TotalBreakTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalBreakTime");
				overall.MaxTalkTime = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.MaxTalkTime");
				overall.TotalCalls = _ctx.LongValue("ListHistoricalSkillGroupReport.Data.List["+ i +"].Overall.TotalCalls");
				items.Overall = overall;

				data_list.Add(items);
			}
			data.List = data_list;
			listHistoricalSkillGroupReportResponse.Data = data;
        
			return listHistoricalSkillGroupReportResponse;
        }
    }
}
