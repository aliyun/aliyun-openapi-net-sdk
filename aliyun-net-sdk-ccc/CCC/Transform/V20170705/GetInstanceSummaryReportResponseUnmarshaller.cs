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
    public class GetInstanceSummaryReportResponseUnmarshaller
    {
        public static GetInstanceSummaryReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceSummaryReportResponse getInstanceSummaryReportResponse = new GetInstanceSummaryReportResponse();

			getInstanceSummaryReportResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceSummaryReportResponse.RequestId = _ctx.StringValue("GetInstanceSummaryReport.RequestId");
			getInstanceSummaryReportResponse.Success = _ctx.BooleanValue("GetInstanceSummaryReport.Success");
			getInstanceSummaryReportResponse.Code = _ctx.StringValue("GetInstanceSummaryReport.Code");
			getInstanceSummaryReportResponse.Message = _ctx.StringValue("GetInstanceSummaryReport.Message");
			getInstanceSummaryReportResponse.HttpStatusCode = _ctx.IntegerValue("GetInstanceSummaryReport.HttpStatusCode");

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport instanceSummaryReport = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport();
			instanceSummaryReport.InstanceId = _ctx.StringValue("GetInstanceSummaryReport.InstanceSummaryReport.InstanceId");

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Overall overall = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Overall();
			overall.TotalCalls = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalCalls");
			overall.TotalLoggedInTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalLoggedInTime");
			overall.TotalBreakTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalBreakTime");
			overall.OccupancyRate = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.OccupancyRate");
			overall.TotalReadyTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalReadyTime");
			overall.MaxReadyTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.MaxReadyTime");
			overall.AverageReadyTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.AverageReadyTime");
			overall.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalTalkTime");
			overall.MaxTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.MaxTalkTime");
			overall.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.AverageTalkTime");
			overall.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalWorkTime");
			overall.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.MaxWorkTime");
			overall.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.AverageWorkTime");
			overall.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.SatisfactionIndex");
			overall.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.SatisfactionSurveysOffered");
			overall.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.SatisfactionSurveysResponded");
			instanceSummaryReport.Overall = overall;

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Inbound inbound = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Inbound();
			inbound.CallsIncomingLine = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsIncomingLine");
			inbound.CallsIncomingIVR = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsIncomingIVR");
			inbound.CallsAbandonedInIVR = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsAbandonedInIVR");
			inbound.CallsIncomingQueue = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsIncomingQueue");
			inbound.CallsAbandonedInQueue = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsAbandonedInQueue");
			inbound.CallsOffered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsOffered");
			inbound.CallsHandled = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsHandled");
			inbound.HandleRate = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.HandleRate");
			inbound.TotalRingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalRingTime");
			inbound.MaxRingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxRingTime");
			inbound.AverageRingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageRingTime");
			inbound.ServiceLevel20 = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.ServiceLevel20");
			inbound.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalTalkTime");
			inbound.MaxTalkTime = _ctx.StringValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxTalkTime");
			inbound.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageTalkTime");
			inbound.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalWorkTime");
			inbound.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxWorkTime");
			inbound.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageWorkTime");
			inbound.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.SatisfactionIndex");
			inbound.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.SatisfactionSurveysOffered");
			inbound.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.SatisfactionSurveysResponded");
			inbound.TotalWaitTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalWaitTime");
			inbound.MaxWaitTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxWaitTime");
			inbound.AverageWaitTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageWaitTime");
			instanceSummaryReport.Inbound = inbound;

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Outbound outbound = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Outbound();
			outbound.CallsDialed = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.CallsDialed");
			outbound.CallsAnswered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.CallsAnswered");
			outbound.AnswerRate = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AnswerRate");
			outbound.TotalDialingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.TotalDialingTime");
			outbound.MaxDialingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.MaxDialingTime");
			outbound.AverageDialingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AverageDialingTime");
			outbound.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.TotalTalkTime");
			outbound.MaxTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.MaxTalkTime");
			outbound.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AverageTalkTime");
			outbound.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.TotalWorkTime");
			outbound.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.MaxWorkTime");
			outbound.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AverageWorkTime");
			outbound.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.SatisfactionIndex");
			outbound.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.SatisfactionSurveysOffered");
			outbound.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.SatisfactionSurveysResponded");
			instanceSummaryReport.Outbound = outbound;
			getInstanceSummaryReportResponse.InstanceSummaryReport = instanceSummaryReport;
        
			return getInstanceSummaryReportResponse;
        }
    }
}
