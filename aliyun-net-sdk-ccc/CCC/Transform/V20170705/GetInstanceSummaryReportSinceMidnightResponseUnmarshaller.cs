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
    public class GetInstanceSummaryReportSinceMidnightResponseUnmarshaller
    {
        public static GetInstanceSummaryReportSinceMidnightResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceSummaryReportSinceMidnightResponse getInstanceSummaryReportSinceMidnightResponse = new GetInstanceSummaryReportSinceMidnightResponse();

			getInstanceSummaryReportSinceMidnightResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceSummaryReportSinceMidnightResponse.RequestId = _ctx.StringValue("GetInstanceSummaryReportSinceMidnight.RequestId");
			getInstanceSummaryReportSinceMidnightResponse.Success = _ctx.BooleanValue("GetInstanceSummaryReportSinceMidnight.Success");
			getInstanceSummaryReportSinceMidnightResponse.Code = _ctx.StringValue("GetInstanceSummaryReportSinceMidnight.Code");
			getInstanceSummaryReportSinceMidnightResponse.Message = _ctx.StringValue("GetInstanceSummaryReportSinceMidnight.Message");
			getInstanceSummaryReportSinceMidnightResponse.HttpStatusCode = _ctx.IntegerValue("GetInstanceSummaryReportSinceMidnight.HttpStatusCode");

			GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport instanceSummaryReport = new GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport();
			instanceSummaryReport.Timestamp = _ctx.StringValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Timestamp");
			instanceSummaryReport.InstanceId = _ctx.StringValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.InstanceId");

			GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Overall overall = new GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Overall();
			overall.TotalCalls = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalCalls");
			overall.TotalLoggedInTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalLoggedInTime");
			overall.TotalBreakTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalBreakTime");
			overall.OccupancyRate = _ctx.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.OccupancyRate");
			overall.TotalReadyTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalReadyTime");
			overall.MaxReadyTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.MaxReadyTime");
			overall.AverageReadyTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.AverageReadyTime");
			overall.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalTalkTime");
			overall.MaxTalkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.MaxTalkTime");
			overall.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.AverageTalkTime");
			overall.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalWorkTime");
			overall.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.MaxWorkTime");
			overall.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.AverageWorkTime");
			overall.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.SatisfactionIndex");
			overall.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.SatisfactionSurveysOffered");
			overall.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.SatisfactionSurveysResponded");
			instanceSummaryReport.Overall = overall;

			GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Inbound inbound = new GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Inbound();
			inbound.CallsIncomingLine = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsIncomingLine");
			inbound.CallsIncomingIVR = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsIncomingIVR");
			inbound.CallsAbandonedInIVR = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsAbandonedInIVR");
			inbound.CallsIncomingQueue = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsIncomingQueue");
			inbound.CallsAbandonedInQueue = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsAbandonedInQueue");
			inbound.CallsOffered = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsOffered");
			inbound.CallsHandled = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsHandled");
			inbound.HandleRate = _ctx.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.HandleRate");
			inbound.TotalRingTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.TotalRingTime");
			inbound.MaxRingTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.MaxRingTime");
			inbound.AverageRingTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.AverageRingTime");
			inbound.ServiceLevel20 = _ctx.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.ServiceLevel20");
			inbound.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.TotalTalkTime");
			inbound.MaxTalkTime = _ctx.StringValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.MaxTalkTime");
			inbound.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.AverageTalkTime");
			inbound.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.TotalWorkTime");
			inbound.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.MaxWorkTime");
			inbound.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.AverageWorkTime");
			inbound.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.SatisfactionIndex");
			inbound.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.SatisfactionSurveysOffered");
			inbound.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.SatisfactionSurveysResponded");
			inbound.TotalWaitTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.TotalWaitTime");
			inbound.MaxWaitTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.MaxWaitTime");
			inbound.AverageWaitTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.AverageWaitTime");
			instanceSummaryReport.Inbound = inbound;

			GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Outbound outbound = new GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Outbound();
			outbound.CallsDialed = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.CallsDialed");
			outbound.CallsAnswered = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.CallsAnswered");
			outbound.AnswerRate = _ctx.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.AnswerRate");
			outbound.TotalDialingTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.TotalDialingTime");
			outbound.MaxDialingTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.MaxDialingTime");
			outbound.AverageDialingTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.AverageDialingTime");
			outbound.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.TotalTalkTime");
			outbound.MaxTalkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.MaxTalkTime");
			outbound.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.AverageTalkTime");
			outbound.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.TotalWorkTime");
			outbound.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.MaxWorkTime");
			outbound.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.AverageWorkTime");
			outbound.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.SatisfactionIndex");
			outbound.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.SatisfactionSurveysOffered");
			outbound.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.SatisfactionSurveysResponded");
			instanceSummaryReport.Outbound = outbound;
			getInstanceSummaryReportSinceMidnightResponse.InstanceSummaryReport = instanceSummaryReport;
        
			return getInstanceSummaryReportSinceMidnightResponse;
        }
    }
}
