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
			getInstanceSummaryReportResponse.HttpStatusCode = _ctx.IntegerValue("GetInstanceSummaryReport.HttpStatusCode");
			getInstanceSummaryReportResponse.Code = _ctx.StringValue("GetInstanceSummaryReport.Code");
			getInstanceSummaryReportResponse.Message = _ctx.StringValue("GetInstanceSummaryReport.Message");
			getInstanceSummaryReportResponse.RequestId = _ctx.StringValue("GetInstanceSummaryReport.RequestId");
			getInstanceSummaryReportResponse.Success = _ctx.BooleanValue("GetInstanceSummaryReport.Success");

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport instanceSummaryReport = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport();
			instanceSummaryReport.InstanceId = _ctx.StringValue("GetInstanceSummaryReport.InstanceSummaryReport.InstanceId");

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Overall overall = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Overall();
			overall.TotalLoggedInTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalLoggedInTime");
			overall.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalTalkTime");
			overall.OccupancyRate = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.OccupancyRate");
			overall.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalWorkTime");
			overall.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.MaxWorkTime");
			overall.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.AverageWorkTime");
			overall.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.AverageTalkTime");
			overall.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.SatisfactionIndex");
			overall.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.SatisfactionSurveysOffered");
			overall.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.SatisfactionSurveysResponded");
			overall.MaxReadyTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.MaxReadyTime");
			overall.AverageReadyTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.AverageReadyTime");
			overall.TotalBreakTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalBreakTime");
			overall.TotalReadyTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalReadyTime");
			overall.MaxTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.MaxTalkTime");
			overall.TotalCalls = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalCalls");
			instanceSummaryReport.Overall = overall;

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Inbound inbound = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Inbound();
			inbound.CallsIncomingLine = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsIncomingLine");
			inbound.AverageRingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageRingTime");
			inbound.CallsHandled = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsHandled");
			inbound.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalWorkTime");
			inbound.CallsAbandonedInIVR = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsAbandonedInIVR");
			inbound.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxWorkTime");
			inbound.AverageWaitTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageWaitTime");
			inbound.CallsIncomingQueue = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsIncomingQueue");
			inbound.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageWorkTime");
			inbound.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.SatisfactionIndex");
			inbound.TotalWaitTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalWaitTime");
			inbound.TotalRingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalRingTime");
			inbound.MaxTalkTime = _ctx.StringValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxTalkTime");
			inbound.MaxRingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxRingTime");
			inbound.CallsIncomingIVR = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsIncomingIVR");
			inbound.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalTalkTime");
			inbound.CallsOffered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsOffered");
			inbound.MaxWaitTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxWaitTime");
			inbound.ServiceLevel20 = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.ServiceLevel20");
			inbound.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageTalkTime");
			inbound.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.SatisfactionSurveysOffered");
			inbound.HandleRate = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.HandleRate");
			inbound.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.SatisfactionSurveysResponded");
			inbound.CallsAbandonedInQueue = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsAbandonedInQueue");
			instanceSummaryReport.Inbound = inbound;

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Outbound outbound = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Outbound();
			outbound.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.TotalTalkTime");
			outbound.MaxDialingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.MaxDialingTime");
			outbound.CallsDialed = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.CallsDialed");
			outbound.CallsAnswered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.CallsAnswered");
			outbound.AnswerRate = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AnswerRate");
			outbound.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.TotalWorkTime");
			outbound.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.MaxWorkTime");
			outbound.TotalDialingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.TotalDialingTime");
			outbound.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AverageTalkTime");
			outbound.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AverageWorkTime");
			outbound.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.SatisfactionIndex");
			outbound.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.SatisfactionSurveysOffered");
			outbound.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.SatisfactionSurveysResponded");
			outbound.MaxTalkTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.MaxTalkTime");
			outbound.AverageDialingTime = _ctx.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AverageDialingTime");
			instanceSummaryReport.Outbound = outbound;
			getInstanceSummaryReportResponse.InstanceSummaryReport = instanceSummaryReport;
        
			return getInstanceSummaryReportResponse;
        }
    }
}
