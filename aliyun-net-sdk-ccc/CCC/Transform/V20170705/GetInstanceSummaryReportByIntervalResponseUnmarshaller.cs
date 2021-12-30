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
        public static GetInstanceSummaryReportByIntervalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceSummaryReportByIntervalResponse getInstanceSummaryReportByIntervalResponse = new GetInstanceSummaryReportByIntervalResponse();

			getInstanceSummaryReportByIntervalResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceSummaryReportByIntervalResponse.HttpStatusCode = _ctx.IntegerValue("GetInstanceSummaryReportByInterval.HttpStatusCode");
			getInstanceSummaryReportByIntervalResponse.Code = _ctx.StringValue("GetInstanceSummaryReportByInterval.Code");
			getInstanceSummaryReportByIntervalResponse.Message = _ctx.StringValue("GetInstanceSummaryReportByInterval.Message");
			getInstanceSummaryReportByIntervalResponse.RequestId = _ctx.StringValue("GetInstanceSummaryReportByInterval.RequestId");
			getInstanceSummaryReportByIntervalResponse.Success = _ctx.BooleanValue("GetInstanceSummaryReportByInterval.Success");

			GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport instanceTimeIntervalReport = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport();
			instanceTimeIntervalReport.InstanceId = _ctx.StringValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.InstanceId");

			List<GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport> instanceTimeIntervalReport_intervalList = new List<GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport>();
			for (int i = 0; i < _ctx.Length("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList.Length"); i++) {
				GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport instanceSummaryReport = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport();
				instanceSummaryReport.InstanceId = _ctx.StringValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].InstanceId");
				instanceSummaryReport.Timestamp = _ctx.StringValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Timestamp");

				GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Overall overall = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Overall();
				overall.TotalLoggedInTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalTalkTime");
				overall.OccupancyRate = _ctx.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.OccupancyRate");
				overall.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.MaxWorkTime");
				overall.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.AverageWorkTime");
				overall.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.AverageTalkTime");
				overall.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.MaxReadyTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.MaxReadyTime");
				overall.AverageReadyTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.AverageReadyTime");
				overall.TotalBreakTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalBreakTime");
				overall.TotalReadyTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalReadyTime");
				overall.MaxTalkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.MaxTalkTime");
				overall.TotalCalls = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Overall.TotalCalls");
				instanceSummaryReport.Overall = overall;

				GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Inbound inbound = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Inbound();
				inbound.CallsIncomingLine = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsIncomingLine");
				inbound.AverageRingTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.AverageRingTime");
				inbound.CallsHandled = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsHandled");
				inbound.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.TotalWorkTime");
				inbound.CallsAbandonedInIVR = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsAbandonedInIVR");
				inbound.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.MaxWorkTime");
				inbound.AverageWaitTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.AverageWaitTime");
				inbound.CallsIncomingQueue = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsIncomingQueue");
				inbound.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.AverageWorkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.SatisfactionIndex");
				inbound.TotalWaitTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.TotalWaitTime");
				inbound.TotalRingTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.TotalRingTime");
				inbound.MaxTalkTime = _ctx.StringValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxRingTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.MaxRingTime");
				inbound.CallsIncomingIVR = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsIncomingIVR");
				inbound.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.TotalTalkTime");
				inbound.CallsOffered = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsOffered");
				inbound.MaxWaitTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.MaxWaitTime");
				inbound.ServiceLevel20 = _ctx.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.ServiceLevel20");
				inbound.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.AverageTalkTime");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.HandleRate = _ctx.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.HandleRate");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.CallsAbandonedInQueue = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Inbound.CallsAbandonedInQueue");
				instanceSummaryReport.Inbound = inbound;

				GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Outbound outbound = new GetInstanceSummaryReportByIntervalResponse.GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport.GetInstanceSummaryReportByInterval_InstanceSummaryReport.GetInstanceSummaryReportByInterval_Outbound();
				outbound.TotalTalkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxDialingTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.MaxDialingTime");
				outbound.CallsDialed = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.CallsAnswered");
				outbound.AnswerRate = _ctx.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.AnswerRate");
				outbound.TotalWorkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.TotalWorkTime");
				outbound.MaxWorkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.MaxWorkTime");
				outbound.TotalDialingTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.TotalDialingTime");
				outbound.AverageTalkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.AverageTalkTime");
				outbound.AverageWorkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.AverageWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.MaxTalkTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.MaxTalkTime");
				outbound.AverageDialingTime = _ctx.LongValue("GetInstanceSummaryReportByInterval.InstanceTimeIntervalReport.IntervalList["+ i +"].Outbound.AverageDialingTime");
				instanceSummaryReport.Outbound = outbound;

				instanceTimeIntervalReport_intervalList.Add(instanceSummaryReport);
			}
			instanceTimeIntervalReport.IntervalList = instanceTimeIntervalReport_intervalList;
			getInstanceSummaryReportByIntervalResponse.InstanceTimeIntervalReport = instanceTimeIntervalReport;
        
			return getInstanceSummaryReportByIntervalResponse;
        }
    }
}
