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
    public class GetHistoricalInstanceReportResponseUnmarshaller
    {
        public static GetHistoricalInstanceReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetHistoricalInstanceReportResponse getHistoricalInstanceReportResponse = new GetHistoricalInstanceReportResponse();

			getHistoricalInstanceReportResponse.HttpResponse = _ctx.HttpResponse;
			getHistoricalInstanceReportResponse.Code = _ctx.StringValue("GetHistoricalInstanceReport.Code");
			getHistoricalInstanceReportResponse.HttpStatusCode = _ctx.IntegerValue("GetHistoricalInstanceReport.HttpStatusCode");
			getHistoricalInstanceReportResponse.Message = _ctx.StringValue("GetHistoricalInstanceReport.Message");
			getHistoricalInstanceReportResponse.RequestId = _ctx.StringValue("GetHistoricalInstanceReport.RequestId");

			GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data data = new GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data();

			GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Inbound inbound = new GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Inbound();
			inbound.AverageRingTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageRingTime");
			inbound.CallsVoicemail = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsVoicemail");
			inbound.MaxAbandonedInIVRTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxAbandonedInIVRTime");
			inbound.CallsHandled = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsHandled");
			inbound.CallsIVRException = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsIVRException");
			inbound.CallsAbandonedInIVR = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAbandonedInIVR");
			inbound.MaxWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxWorkTime");
			inbound.TotalHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalHoldTime");
			inbound.MaxAbandonTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxAbandonTime");
			inbound.AverageAbandonTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageAbandonTime");
			inbound.CallsRinged = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsRinged");
			inbound.CallsQueuingFailed = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsQueuingFailed");
			inbound.TotalRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalRingTime");
			inbound.AbandonRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AbandonRate");
			inbound.TotalTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalTalkTime");
			inbound.MaxAbandonedInRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxAbandonedInRingTime");
			inbound.CallsBlindTransferred = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsBlindTransferred");
			inbound.AverageAbandonedInIVRTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageAbandonedInIVRTime");
			inbound.AverageAbandonedInQueueTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageAbandonedInQueueTime");
			inbound.MaxWaitTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxWaitTime");
			inbound.AverageTalkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageTalkTime");
			inbound.CallsAttendedTransferred = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAttendedTransferred");
			inbound.TotalAbandonedInIVRTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalAbandonedInIVRTime");
			inbound.CallsQueuingOverflow = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsQueuingOverflow");
			inbound.CallsAbandonedInRing = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAbandonedInRing");
			inbound.TotalAbandonedInRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalAbandonedInRingTime");
			inbound.TotalWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalWorkTime");
			inbound.AverageWaitTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageWaitTime");
			inbound.AverageWorkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageWorkTime");
			inbound.CallsQueued = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsQueued");
			inbound.AverageAbandonedInRingTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageAbandonedInRingTime");
			inbound.SatisfactionIndex = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.SatisfactionIndex");
			inbound.CallsAbandoned = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAbandoned");
			inbound.MaxAbandonedInQueueTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxAbandonedInQueueTime");
			inbound.CallsAbandonedInVoiceNavigator = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAbandonedInVoiceNavigator");
			inbound.TotalWaitTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalWaitTime");
			inbound.MaxTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxTalkTime");
			inbound.MaxRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxRingTime");
			inbound.TotalAbandonTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalAbandonTime");
			inbound.CallsOffered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsOffered");
			inbound.CallsQueuingTimeout = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsQueuingTimeout");
			inbound.ServiceLevel20 = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.ServiceLevel20");
			inbound.MaxHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxHoldTime");
			inbound.CallsForwardToOutsideNumber = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsForwardToOutsideNumber");
			inbound.SatisfactionRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.SatisfactionRate");
			inbound.CallsHold = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsHold");
			inbound.SatisfactionSurveysOffered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.SatisfactionSurveysOffered");
			inbound.HandleRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.HandleRate");
			inbound.SatisfactionSurveysResponded = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.SatisfactionSurveysResponded");
			inbound.AverageHoldTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageHoldTime");
			inbound.CallsAbandonedInQueue = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAbandonedInQueue");
			inbound.TotalAbandonedInQueueTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalAbandonedInQueueTime");
			data.Inbound = inbound;

			GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Outbound outbound = new GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Outbound();
			outbound.AverageRingTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AverageRingTime");
			outbound.CallsDialed = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.CallsDialed");
			outbound.CallsAnswered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.CallsAnswered");
			outbound.TotalWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.TotalWorkTime");
			outbound.MaxWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.MaxWorkTime");
			outbound.TotalDialingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.TotalDialingTime");
			outbound.TotalHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.TotalHoldTime");
			outbound.AverageWorkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AverageWorkTime");
			outbound.SatisfactionIndex = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.SatisfactionIndex");
			outbound.CallsRinged = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.CallsRinged");
			outbound.TotalRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.TotalRingTime");
			outbound.MaxTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.MaxTalkTime");
			outbound.MaxRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.MaxRingTime");
			outbound.TotalTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.TotalTalkTime");
			outbound.MaxDialingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.MaxDialingTime");
			outbound.CallsBlindTransferred = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.CallsBlindTransferred");
			outbound.AnswerRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AnswerRate");
			outbound.MaxHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.MaxHoldTime");
			outbound.AverageTalkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AverageTalkTime");
			outbound.SatisfactionRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.SatisfactionRate");
			outbound.CallsAttendedTransferred = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.CallsAttendedTransferred");
			outbound.CallsHold = _ctx.IntegerValue("GetHistoricalInstanceReport.Data.Outbound.CallsHold");
			outbound.SatisfactionSurveysOffered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.SatisfactionSurveysOffered");
			outbound.SatisfactionSurveysResponded = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.SatisfactionSurveysResponded");
			outbound.AverageHoldTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AverageHoldTime");
			outbound.AverageDialingTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AverageDialingTime");
			data.Outbound = outbound;

			GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Overall overall = new GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Overall();
			overall.TotalTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalTalkTime");
			overall.TotalLoggedInTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalLoggedInTime");
			overall.OccupancyRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.OccupancyRate");
			overall.TotalWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalWorkTime");
			overall.MaxHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxHoldTime");
			overall.MaxWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxWorkTime");
			overall.AverageBreakTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageBreakTime");
			overall.TotalHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalHoldTime");
			overall.SatisfactionRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.SatisfactionRate");
			overall.MaxBreakTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxBreakTime");
			overall.AverageWorkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageWorkTime");
			overall.AverageTalkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageTalkTime");
			overall.SatisfactionIndex = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.SatisfactionIndex");
			overall.SatisfactionSurveysOffered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.SatisfactionSurveysOffered");
			overall.SatisfactionSurveysResponded = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.SatisfactionSurveysResponded");
			overall.MaxReadyTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxReadyTime");
			overall.AverageReadyTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageReadyTime");
			overall.AverageHoldTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageHoldTime");
			overall.TotalReadyTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalReadyTime");
			overall.TotalBreakTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalBreakTime");
			overall.MaxTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxTalkTime");
			overall.TotalCalls = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalCalls");
			data.Overall = overall;
			getHistoricalInstanceReportResponse.Data = data;
        
			return getHistoricalInstanceReportResponse;
        }
    }
}
