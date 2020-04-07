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
    public class GetInstanceSummaryReportByIntervalResponseUnmarshaller
    {
        public static GetInstanceSummaryReportByIntervalResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceSummaryReportByIntervalResponse getInstanceSummaryReportByIntervalResponse = new GetInstanceSummaryReportByIntervalResponse();

			getInstanceSummaryReportByIntervalResponse.HttpResponse = context.HttpResponse;
			getInstanceSummaryReportByIntervalResponse.RequestId = context.StringValue("GetInstanceSummaryReportByInterval.RequestId");
			getInstanceSummaryReportByIntervalResponse.Success = context.BooleanValue("GetInstanceSummaryReportByInterval.Success");
			getInstanceSummaryReportByIntervalResponse.Code = context.StringValue("GetInstanceSummaryReportByInterval.Code");
			getInstanceSummaryReportByIntervalResponse.Message = context.StringValue("GetInstanceSummaryReportByInterval.Message");
			getInstanceSummaryReportByIntervalResponse.HttpStatusCode = context.IntegerValue("GetInstanceSummaryReportByInterval.HttpStatusCode");

			GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport instanceTimeIntervalReport = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport();
			instanceTimeIntervalReport.InstanceId = context.StringValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.InstanceId");

			List<GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport> instanceTimeIntervalReport_intervalList = new List<GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport>();
			for (int i = 0; i < context.Length("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList.Length"); i++) {
				GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport instanceSummaryReport = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport();
				instanceSummaryReport.Timestamp = context.StringValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Timestamp");
				instanceSummaryReport.InstanceId = context.StringValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].InstanceId");

				GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Overall overall = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Overall();
				overall.TotalCalls = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalCalls");
				overall.TotalLoggedInTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalBreakTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalBreakTime");
				overall.OccupancyRate = context.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.OccupancyRate");
				overall.TotalReadyTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalReadyTime");
				overall.MaxReadyTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.AverageReadyTime");
				overall.TotalTalkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalTalkTime");
				overall.MaxTalkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.MaxTalkTime");
				overall.AverageTalkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.AverageTalkTime");
				overall.TotalWorkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.AverageWorkTime");
				overall.SatisfactionIndex = context.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.SatisfactionSurveysResponded");
				instanceSummaryReport.Overall = overall;

				GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Inbound inbound = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Inbound();
				inbound.CallsIncomingLine = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsIncomingLine");
				inbound.CallsIncomingIVR = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsIncomingIVR");
				inbound.CallsAbandonedInIVR = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsAbandonedInIVR");
				inbound.CallsIncomingQueue = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsIncomingQueue");
				inbound.CallsAbandonedInQueue = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsAbandonedInQueue");
				inbound.CallsOffered = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsOffered");
				inbound.CallsHandled = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsHandled");
				inbound.HandleRate = context.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.HandleRate");
				inbound.TotalRingTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.TotalRingTime");
				inbound.MaxRingTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.MaxRingTime");
				inbound.AverageRingTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.AverageRingTime");
				inbound.ServiceLevel20 = context.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalTalkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.TotalTalkTime");
				inbound.MaxTalkTime = context.StringValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.MaxTalkTime");
				inbound.AverageTalkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.AverageTalkTime");
				inbound.TotalWorkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.TotalWorkTime");
				inbound.MaxWorkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWorkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionIndex = context.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.TotalWaitTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.TotalWaitTime");
				inbound.MaxWaitTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.MaxWaitTime");
				inbound.AverageWaitTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.AverageWaitTime");
				instanceSummaryReport.Inbound = inbound;

				GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Outbound outbound = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Outbound();
				outbound.CallsDialed = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = context.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.AnswerRate");
				outbound.TotalDialingTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.TotalDialingTime");
				outbound.MaxDialingTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.MaxDialingTime");
				outbound.AverageDialingTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.AverageDialingTime");
				outbound.TotalTalkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxTalkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageTalkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.AverageTalkTime");
				outbound.TotalWorkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.MaxWorkTime");
				outbound.AverageWorkTime = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = context.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = context.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.SatisfactionSurveysResponded");
				instanceSummaryReport.Outbound = outbound;

				instanceTimeIntervalReport_intervalList.Add(instanceSummaryReport);
			}
			instanceTimeIntervalReport.IntervalList = instanceTimeIntervalReport_intervalList;
			getInstanceSummaryReportByIntervalResponse.InstanceTimeIntervalReport = instanceTimeIntervalReport;
        
			return getInstanceSummaryReportByIntervalResponse;
        }
    }
}
