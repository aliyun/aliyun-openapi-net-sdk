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
			inbound.AbandonRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AbandonRate");
			inbound.AverageAbandonTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageAbandonTime");
			inbound.AverageAbandonedInIVRTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageAbandonedInIVRTime");
			inbound.AverageAbandonedInQueueTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageAbandonedInQueueTime");
			inbound.AverageAbandonedInRingTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageAbandonedInRingTime");
			inbound.AverageHoldTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageHoldTime");
			inbound.AverageRingTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageRingTime");
			inbound.AverageTalkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageTalkTime");
			inbound.AverageWaitTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageWaitTime");
			inbound.AverageWorkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.AverageWorkTime");
			inbound.CallsAbandoned = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAbandoned");
			inbound.CallsAbandonedInIVR = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAbandonedInIVR");
			inbound.CallsAbandonedInQueue = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAbandonedInQueue");
			inbound.CallsAbandonedInRinging = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsAbandonedInRinging");
			inbound.CallsConsulted = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsConsulted");
			inbound.CallsHandled = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsHandled");
			inbound.CallsHold = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsHold");
			inbound.CallsOffered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsOffered");
			inbound.CallsQueued = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsQueued");
			inbound.CallsRinged = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsRinged");
			inbound.CallsTransferred = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.CallsTransferred");
			inbound.HandleRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.HandleRate");
			inbound.MaxAbandonTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxAbandonTime");
			inbound.MaxAbandonedInIVRTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxAbandonedInIVRTime");
			inbound.MaxAbandonedInQueueTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxAbandonedInQueueTime");
			inbound.MaxAbandonedInRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxAbandonedInRingTime");
			inbound.MaxHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxHoldTime");
			inbound.MaxRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxRingTime");
			inbound.MaxTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxTalkTime");
			inbound.MaxWaitTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxWaitTime");
			inbound.MaxWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.MaxWorkTime");
			inbound.SatisfactionIndex = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.SatisfactionIndex");
			inbound.SatisfactionSurveysOffered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.SatisfactionSurveysOffered");
			inbound.SatisfactionSurveysResponded = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.SatisfactionSurveysResponded");
			inbound.ServiceLevel20 = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Inbound.ServiceLevel20");
			inbound.TotalAbandonTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalAbandonTime");
			inbound.TotalAbandonedInIVRTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalAbandonedInIVRTime");
			inbound.TotalAbandonedInQueueTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalAbandonedInQueueTime");
			inbound.TotalAbandonedInRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalAbandonedInRingTime");
			inbound.TotalHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalHoldTime");
			inbound.TotalRingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalRingTime");
			inbound.TotalTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalTalkTime");
			inbound.TotalWaitTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalWaitTime");
			inbound.TotalWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Inbound.TotalWorkTime");
			data.Inbound = inbound;

			GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Outbound outbound = new GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Outbound();
			outbound.AnswerRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AnswerRate");
			outbound.AverageDialingTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AverageDialingTime");
			outbound.AverageHoldTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AverageHoldTime");
			outbound.AverageTalkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AverageTalkTime");
			outbound.AverageWorkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.AverageWorkTime");
			outbound.CallsAnswered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.CallsAnswered");
			outbound.CallsDialed = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.CallsDialed");
			outbound.CallsDialedSuccess = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.CallsDialedSuccess");
			outbound.CallsHold = _ctx.IntegerValue("GetHistoricalInstanceReport.Data.Outbound.CallsHold");
			outbound.MaxDialingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.MaxDialingTime");
			outbound.MaxHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.MaxHoldTime");
			outbound.MaxTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.MaxTalkTime");
			outbound.MaxWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.MaxWorkTime");
			outbound.SatisfactionIndex = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Outbound.SatisfactionIndex");
			outbound.SatisfactionSurveysOffered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.SatisfactionSurveysOffered");
			outbound.SatisfactionSurveysResponded = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.SatisfactionSurveysResponded");
			outbound.TotalDialingTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.TotalDialingTime");
			outbound.TotalHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.TotalHoldTime");
			outbound.TotalTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.TotalTalkTime");
			outbound.TotalWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Outbound.TotalWorkTime");
			data.Outbound = outbound;

			GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Overall overall = new GetHistoricalInstanceReportResponse.GetHistoricalInstanceReport_Data.GetHistoricalInstanceReport_Overall();
			overall.AverageBreakTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageBreakTime");
			overall.AverageHoldTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageHoldTime");
			overall.AverageReadyTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageReadyTime");
			overall.AverageTalkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageTalkTime");
			overall.AverageWorkTime = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.AverageWorkTime");
			overall.MaxBreakTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxBreakTime");
			overall.MaxHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxHoldTime");
			overall.MaxReadyTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxReadyTime");
			overall.MaxTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxTalkTime");
			overall.MaxWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.MaxWorkTime");
			overall.OccupancyRate = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.OccupancyRate");
			overall.SatisfactionIndex = _ctx.FloatValue("GetHistoricalInstanceReport.Data.Overall.SatisfactionIndex");
			overall.SatisfactionSurveysOffered = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.SatisfactionSurveysOffered");
			overall.SatisfactionSurveysResponded = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.SatisfactionSurveysResponded");
			overall.TotalBreakTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalBreakTime");
			overall.TotalCalls = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalCalls");
			overall.TotalHoldTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalHoldTime");
			overall.TotalLoggedInTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalLoggedInTime");
			overall.TotalReadyTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalReadyTime");
			overall.TotalTalkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalTalkTime");
			overall.TotalWorkTime = _ctx.LongValue("GetHistoricalInstanceReport.Data.Overall.TotalWorkTime");
			data.Overall = overall;
			getHistoricalInstanceReportResponse.Data = data;
        
			return getHistoricalInstanceReportResponse;
        }
    }
}
