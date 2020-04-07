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
        public static GetInstanceSummaryReportResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceSummaryReportResponse getInstanceSummaryReportResponse = new GetInstanceSummaryReportResponse();

			getInstanceSummaryReportResponse.HttpResponse = context.HttpResponse;
			getInstanceSummaryReportResponse.RequestId = context.StringValue("GetInstanceSummaryReport.RequestId");
			getInstanceSummaryReportResponse.Success = context.BooleanValue("GetInstanceSummaryReport.Success");
			getInstanceSummaryReportResponse.Code = context.StringValue("GetInstanceSummaryReport.Code");
			getInstanceSummaryReportResponse.Message = context.StringValue("GetInstanceSummaryReport.Message");
			getInstanceSummaryReportResponse.HttpStatusCode = context.IntegerValue("GetInstanceSummaryReport.HttpStatusCode");

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport instanceSummaryReport = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport();
			instanceSummaryReport.InstanceId = context.StringValue("GetInstanceSummaryReport.InstanceSummaryReport.InstanceId");

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Overall overall = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Overall();
			overall.TotalCalls = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalCalls");
			overall.TotalLoggedInTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalLoggedInTime");
			overall.TotalBreakTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalBreakTime");
			overall.OccupancyRate = context.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.OccupancyRate");
			overall.TotalReadyTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalReadyTime");
			overall.MaxReadyTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.MaxReadyTime");
			overall.AverageReadyTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.AverageReadyTime");
			overall.TotalTalkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalTalkTime");
			overall.MaxTalkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.MaxTalkTime");
			overall.AverageTalkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.AverageTalkTime");
			overall.TotalWorkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.TotalWorkTime");
			overall.MaxWorkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.MaxWorkTime");
			overall.AverageWorkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.AverageWorkTime");
			overall.SatisfactionIndex = context.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.SatisfactionIndex");
			overall.SatisfactionSurveysOffered = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.SatisfactionSurveysOffered");
			overall.SatisfactionSurveysResponded = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Overall.SatisfactionSurveysResponded");
			instanceSummaryReport.Overall = overall;

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Inbound inbound = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Inbound();
			inbound.CallsIncomingLine = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsIncomingLine");
			inbound.CallsIncomingIVR = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsIncomingIVR");
			inbound.CallsAbandonedInIVR = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsAbandonedInIVR");
			inbound.CallsIncomingQueue = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsIncomingQueue");
			inbound.CallsAbandonedInQueue = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsAbandonedInQueue");
			inbound.CallsOffered = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsOffered");
			inbound.CallsHandled = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.CallsHandled");
			inbound.HandleRate = context.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.HandleRate");
			inbound.TotalRingTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalRingTime");
			inbound.MaxRingTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxRingTime");
			inbound.AverageRingTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageRingTime");
			inbound.ServiceLevel20 = context.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.ServiceLevel20");
			inbound.TotalTalkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalTalkTime");
			inbound.MaxTalkTime = context.StringValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxTalkTime");
			inbound.AverageTalkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageTalkTime");
			inbound.TotalWorkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalWorkTime");
			inbound.MaxWorkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxWorkTime");
			inbound.AverageWorkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageWorkTime");
			inbound.SatisfactionIndex = context.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.SatisfactionIndex");
			inbound.SatisfactionSurveysOffered = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.SatisfactionSurveysOffered");
			inbound.SatisfactionSurveysResponded = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.SatisfactionSurveysResponded");
			inbound.TotalWaitTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.TotalWaitTime");
			inbound.MaxWaitTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.MaxWaitTime");
			inbound.AverageWaitTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Inbound.AverageWaitTime");
			instanceSummaryReport.Inbound = inbound;

			GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Outbound outbound = new GetInstanceSummaryReportResponse.GetInstanceSummaryReport_InstanceSummaryReport.GetInstanceSummaryReport_Outbound();
			outbound.CallsDialed = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.CallsDialed");
			outbound.CallsAnswered = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.CallsAnswered");
			outbound.AnswerRate = context.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AnswerRate");
			outbound.TotalDialingTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.TotalDialingTime");
			outbound.MaxDialingTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.MaxDialingTime");
			outbound.AverageDialingTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AverageDialingTime");
			outbound.TotalTalkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.TotalTalkTime");
			outbound.MaxTalkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.MaxTalkTime");
			outbound.AverageTalkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AverageTalkTime");
			outbound.TotalWorkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.TotalWorkTime");
			outbound.MaxWorkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.MaxWorkTime");
			outbound.AverageWorkTime = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.AverageWorkTime");
			outbound.SatisfactionIndex = context.FloatValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.SatisfactionIndex");
			outbound.SatisfactionSurveysOffered = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.SatisfactionSurveysOffered");
			outbound.SatisfactionSurveysResponded = context.LongValue("GetInstanceSummaryReport.InstanceSummaryReport.Outbound.SatisfactionSurveysResponded");
			instanceSummaryReport.Outbound = outbound;
			getInstanceSummaryReportResponse.InstanceSummaryReport = instanceSummaryReport;
        
			return getInstanceSummaryReportResponse;
        }
    }
}
