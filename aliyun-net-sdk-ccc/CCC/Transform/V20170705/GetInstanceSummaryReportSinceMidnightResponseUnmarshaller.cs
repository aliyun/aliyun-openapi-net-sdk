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
        public static GetInstanceSummaryReportSinceMidnightResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceSummaryReportSinceMidnightResponse getInstanceSummaryReportSinceMidnightResponse = new GetInstanceSummaryReportSinceMidnightResponse();

			getInstanceSummaryReportSinceMidnightResponse.HttpResponse = context.HttpResponse;
			getInstanceSummaryReportSinceMidnightResponse.RequestId = context.StringValue("GetInstanceSummaryReportSinceMidnight.RequestId");
			getInstanceSummaryReportSinceMidnightResponse.Success = context.BooleanValue("GetInstanceSummaryReportSinceMidnight.Success");
			getInstanceSummaryReportSinceMidnightResponse.Code = context.StringValue("GetInstanceSummaryReportSinceMidnight.Code");
			getInstanceSummaryReportSinceMidnightResponse.Message = context.StringValue("GetInstanceSummaryReportSinceMidnight.Message");
			getInstanceSummaryReportSinceMidnightResponse.HttpStatusCode = context.IntegerValue("GetInstanceSummaryReportSinceMidnight.HttpStatusCode");

			GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport instanceSummaryReport = new GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport();
			instanceSummaryReport.Timestamp = context.StringValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Timestamp");
			instanceSummaryReport.InstanceId = context.StringValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.InstanceId");

			GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Overall overall = new GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Overall();
			overall.TotalCalls = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalCalls");
			overall.TotalLoggedInTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalLoggedInTime");
			overall.TotalBreakTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalBreakTime");
			overall.OccupancyRate = context.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.OccupancyRate");
			overall.TotalReadyTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalReadyTime");
			overall.MaxReadyTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.MaxReadyTime");
			overall.AverageReadyTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.AverageReadyTime");
			overall.TotalTalkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalTalkTime");
			overall.MaxTalkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.MaxTalkTime");
			overall.AverageTalkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.AverageTalkTime");
			overall.TotalWorkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.TotalWorkTime");
			overall.MaxWorkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.MaxWorkTime");
			overall.AverageWorkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.AverageWorkTime");
			overall.SatisfactionIndex = context.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.SatisfactionIndex");
			overall.SatisfactionSurveysOffered = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.SatisfactionSurveysOffered");
			overall.SatisfactionSurveysResponded = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Overall.SatisfactionSurveysResponded");
			instanceSummaryReport.Overall = overall;

			GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Inbound inbound = new GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Inbound();
			inbound.CallsIncomingLine = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsIncomingLine");
			inbound.CallsIncomingIVR = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsIncomingIVR");
			inbound.CallsAbandonedInIVR = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsAbandonedInIVR");
			inbound.CallsIncomingQueue = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsIncomingQueue");
			inbound.CallsAbandonedInQueue = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsAbandonedInQueue");
			inbound.CallsOffered = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsOffered");
			inbound.CallsHandled = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.CallsHandled");
			inbound.HandleRate = context.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.HandleRate");
			inbound.TotalRingTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.TotalRingTime");
			inbound.MaxRingTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.MaxRingTime");
			inbound.AverageRingTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.AverageRingTime");
			inbound.ServiceLevel20 = context.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.ServiceLevel20");
			inbound.TotalTalkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.TotalTalkTime");
			inbound.MaxTalkTime = context.StringValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.MaxTalkTime");
			inbound.AverageTalkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.AverageTalkTime");
			inbound.TotalWorkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.TotalWorkTime");
			inbound.MaxWorkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.MaxWorkTime");
			inbound.AverageWorkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.AverageWorkTime");
			inbound.SatisfactionIndex = context.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.SatisfactionIndex");
			inbound.SatisfactionSurveysOffered = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.SatisfactionSurveysOffered");
			inbound.SatisfactionSurveysResponded = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.SatisfactionSurveysResponded");
			inbound.TotalWaitTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.TotalWaitTime");
			inbound.MaxWaitTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.MaxWaitTime");
			inbound.AverageWaitTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Inbound.AverageWaitTime");
			instanceSummaryReport.Inbound = inbound;

			GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Outbound outbound = new GetInstanceSummaryReportSinceMidnightResponse.GetInstanceSummaryReportSinceMidnight_InstanceSummaryReport.GetInstanceSummaryReportSinceMidnight_Outbound();
			outbound.CallsDialed = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.CallsDialed");
			outbound.CallsAnswered = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.CallsAnswered");
			outbound.AnswerRate = context.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.AnswerRate");
			outbound.TotalDialingTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.TotalDialingTime");
			outbound.MaxDialingTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.MaxDialingTime");
			outbound.AverageDialingTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.AverageDialingTime");
			outbound.TotalTalkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.TotalTalkTime");
			outbound.MaxTalkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.MaxTalkTime");
			outbound.AverageTalkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.AverageTalkTime");
			outbound.TotalWorkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.TotalWorkTime");
			outbound.MaxWorkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.MaxWorkTime");
			outbound.AverageWorkTime = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.AverageWorkTime");
			outbound.SatisfactionIndex = context.FloatValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.SatisfactionIndex");
			outbound.SatisfactionSurveysOffered = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.SatisfactionSurveysOffered");
			outbound.SatisfactionSurveysResponded = context.LongValue("GetInstanceSummaryReportSinceMidnight.InstanceSummaryReport.Outbound.SatisfactionSurveysResponded");
			instanceSummaryReport.Outbound = outbound;
			getInstanceSummaryReportSinceMidnightResponse.InstanceSummaryReport = instanceSummaryReport;
        
			return getInstanceSummaryReportSinceMidnightResponse;
        }
    }
}
