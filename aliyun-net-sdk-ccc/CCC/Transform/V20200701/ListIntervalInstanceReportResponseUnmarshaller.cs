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
    public class ListIntervalInstanceReportResponseUnmarshaller
    {
        public static ListIntervalInstanceReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIntervalInstanceReportResponse listIntervalInstanceReportResponse = new ListIntervalInstanceReportResponse();

			listIntervalInstanceReportResponse.HttpResponse = _ctx.HttpResponse;
			listIntervalInstanceReportResponse.Code = _ctx.StringValue("ListIntervalInstanceReport.Code");
			listIntervalInstanceReportResponse.HttpStatusCode = _ctx.IntegerValue("ListIntervalInstanceReport.HttpStatusCode");
			listIntervalInstanceReportResponse.Message = _ctx.StringValue("ListIntervalInstanceReport.Message");
			listIntervalInstanceReportResponse.RequestId = _ctx.StringValue("ListIntervalInstanceReport.RequestId");

			List<ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem> listIntervalInstanceReportResponse_data = new List<ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem>();
			for (int i = 0; i < _ctx.Length("ListIntervalInstanceReport.Data.Length"); i++) {
				ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem dataItem = new ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem();
				dataItem.StatsTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].StatsTime");

				ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Inbound inbound = new ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Inbound();
				inbound.AverageRingTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageRingTime");
				inbound.CallsVoicemail = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsVoicemail");
				inbound.MaxAbandonedInIVRTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxAbandonedInIVRTime");
				inbound.CallsHandled = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsHandled");
				inbound.CallsIVRException = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsIVRException");
				inbound.CallsAbandonedInIVR = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAbandonedInIVR");
				inbound.MaxWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxWorkTime");
				inbound.TotalHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalHoldTime");
				inbound.MaxAbandonTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxAbandonTime");
				inbound.AverageAbandonTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageAbandonTime");
				inbound.AbandonedRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AbandonedRate");
				inbound.CallsRinged = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsRinged");
				inbound.CallsQueuingFailed = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsQueuingFailed");
				inbound.TotalRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalRingTime");
				inbound.TotalTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxAbandonedInRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxAbandonedInRingTime");
				inbound.CallsBlindTransferred = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsBlindTransferred");
				inbound.AverageAbandonedInIVRTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageAbandonedInIVRTime");
				inbound.AverageAbandonedInQueueTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageAbandonedInQueueTime");
				inbound.MaxWaitTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxWaitTime");
				inbound.AverageTalkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageTalkTime");
				inbound.CallsAttendedTransferred = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAttendedTransferred");
				inbound.TotalAbandonedInIVRTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalAbandonedInIVRTime");
				inbound.CallsQueuingOverflow = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsQueuingOverflow");
				inbound.CallsAbandonedInRing = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAbandonedInRing");
				inbound.TotalAbandonedInRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalAbandonedInRingTime");
				inbound.TotalWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalWorkTime");
				inbound.AverageWaitTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageWaitTime");
				inbound.AverageWorkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageWorkTime");
				inbound.CallsQueued = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsQueued");
				inbound.AverageAbandonedInRingTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageAbandonedInRingTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.SatisfactionIndex");
				inbound.CallsAbandoned = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAbandoned");
				inbound.MaxAbandonedInQueueTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxAbandonedInQueueTime");
				inbound.CallsAbandonedInVoiceNavigator = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAbandonedInVoiceNavigator");
				inbound.TotalWaitTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalWaitTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxRingTime");
				inbound.TotalAbandonTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalAbandonTime");
				inbound.CallsOffered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsOffered");
				inbound.CallsQueuingTimeout = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsQueuingTimeout");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.ServiceLevel20");
				inbound.MaxHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxHoldTime");
				inbound.CallsForwardToOutsideNumber = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsForwardToOutsideNumber");
				inbound.SatisfactionRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.SatisfactionRate");
				inbound.CallsHold = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsHold");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.HandleRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.HandleRate");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.AverageHoldTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageHoldTime");
				inbound.CallsAbandonedInQueue = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAbandonedInQueue");
				inbound.TotalAbandonedInQueueTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalAbandonedInQueueTime");
				dataItem.Inbound = inbound;

				ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Outbound outbound = new ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Outbound();
				outbound.AverageRingTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AverageRingTime");
				outbound.CallsDialed = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.CallsAnswered");
				outbound.TotalWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.MaxWorkTime");
				outbound.TotalDialingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.TotalHoldTime");
				outbound.AverageWorkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.SatisfactionIndex");
				outbound.CallsRinged = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.CallsRinged");
				outbound.TotalRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.TotalRingTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.MaxTalkTime");
				outbound.MaxRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.MaxRingTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxDialingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.MaxDialingTime");
				outbound.CallsBlindTransferred = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.CallsBlindTransferred");
				outbound.AnswerRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AnswerRate");
				outbound.MaxHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.MaxHoldTime");
				outbound.AverageTalkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AverageTalkTime");
				outbound.SatisfactionRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.SatisfactionRate");
				outbound.CallsAttendedTransferred = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.CallsAttendedTransferred");
				outbound.CallsHold = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.CallsHold");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.AverageHoldTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AverageHoldTime");
				outbound.AverageDialingTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AverageDialingTime");
				dataItem.Outbound = outbound;

				ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Overall overall = new ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Overall();
				overall.TotalTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalTalkTime");
				overall.TotalLoggedInTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalLoggedInTime");
				overall.OccupancyRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.OccupancyRate");
				overall.TotalWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalWorkTime");
				overall.MaxHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxHoldTime");
				overall.MaxWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxWorkTime");
				overall.AverageBreakTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageBreakTime");
				overall.TotalHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalHoldTime");
				overall.SatisfactionRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.SatisfactionRate");
				overall.MaxBreakTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxBreakTime");
				overall.AverageWorkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageWorkTime");
				overall.AverageTalkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageTalkTime");
				overall.SatisfactionIndex = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.MaxReadyTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageReadyTime");
				overall.AverageHoldTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageHoldTime");
				overall.TotalReadyTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalReadyTime");
				overall.TotalBreakTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalBreakTime");
				overall.MaxTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxTalkTime");
				overall.TotalCalls = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalCalls");
				dataItem.Overall = overall;

				listIntervalInstanceReportResponse_data.Add(dataItem);
			}
			listIntervalInstanceReportResponse.Data = listIntervalInstanceReportResponse_data;
        
			return listIntervalInstanceReportResponse;
        }
    }
}
