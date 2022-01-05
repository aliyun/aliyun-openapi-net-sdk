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
    public class ListIntervalAgentReportResponseUnmarshaller
    {
        public static ListIntervalAgentReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIntervalAgentReportResponse listIntervalAgentReportResponse = new ListIntervalAgentReportResponse();

			listIntervalAgentReportResponse.HttpResponse = _ctx.HttpResponse;
			listIntervalAgentReportResponse.Code = _ctx.StringValue("ListIntervalAgentReport.Code");
			listIntervalAgentReportResponse.HttpStatusCode = _ctx.IntegerValue("ListIntervalAgentReport.HttpStatusCode");
			listIntervalAgentReportResponse.Message = _ctx.StringValue("ListIntervalAgentReport.Message");
			listIntervalAgentReportResponse.RequestId = _ctx.StringValue("ListIntervalAgentReport.RequestId");

			List<ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem> listIntervalAgentReportResponse_data = new List<ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem>();
			for (int i = 0; i < _ctx.Length("ListIntervalAgentReport.Data.Length"); i++) {
				ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem dataItem = new ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem();
				dataItem.StatsTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].StatsTime");

				ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Inbound inbound = new ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Inbound();
				inbound.AverageRingTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.AverageRingTime");
				inbound.CallsHandled = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsHandled");
				inbound.TotalWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.TotalWorkTime");
				inbound.CallsAttendedTransferOut = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsAttendedTransferOut");
				inbound.MaxWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.MaxWorkTime");
				inbound.TotalHoldTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.TotalHoldTime");
				inbound.AverageWorkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.AverageWorkTime");
				inbound.CallsBlindTransferIn = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsBlindTransferIn");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.SatisfactionIndex");
				inbound.CallsRinged = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsRinged");
				inbound.CallsAttendedTransferIn = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsAttendedTransferIn");
				inbound.CallsBlindTransferOut = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsBlindTransferOut");
				inbound.TotalRingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.TotalRingTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxRingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.MaxRingTime");
				inbound.TotalTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.TotalTalkTime");
				inbound.CallsOffered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsOffered");
				inbound.MaxHoldTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.MaxHoldTime");
				inbound.AverageTalkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.AverageTalkTime");
				inbound.SatisfactionRate = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.SatisfactionRate");
				inbound.CallsHold = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsHold");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.HandleRate = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.HandleRate");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.AverageHoldTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.AverageHoldTime");
				dataItem.Inbound = inbound;

				ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Outbound outbound = new ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Outbound();
				outbound.AverageRingTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AverageRingTime");
				outbound.CallsDialed = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsDialed");
				outbound.CallsAnswered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsAnswered");
				outbound.TotalWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.TotalWorkTime");
				outbound.CallsAttendedTransferOut = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsAttendedTransferOut");
				outbound.MaxWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.MaxWorkTime");
				outbound.TotalDialingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalHoldTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.TotalHoldTime");
				outbound.AverageWorkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AverageWorkTime");
				outbound.CallsBlindTransferIn = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsBlindTransferIn");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.SatisfactionIndex");
				outbound.CallsRinged = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsRinged");
				outbound.CallsAttendedTransferIn = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsAttendedTransferIn");
				outbound.CallsBlindTransferOut = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsBlindTransferOut");
				outbound.TotalRingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.TotalRingTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.MaxTalkTime");
				outbound.MaxRingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.MaxRingTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.TotalTalkTime");
				outbound.MaxDialingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.MaxDialingTime");
				outbound.AnswerRate = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AnswerRate");
				outbound.MaxHoldTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.MaxHoldTime");
				outbound.AverageTalkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AverageTalkTime");
				outbound.SatisfactionRate = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.SatisfactionRate");
				outbound.CallsHold = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsHold");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.AverageHoldTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AverageHoldTime");
				outbound.AverageDialingTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AverageDialingTime");
				dataItem.Outbound = outbound;

				ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Overall overall = new ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Overall();
				overall.OccupancyRate = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.OccupancyRate");
				overall.TotalWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalWorkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.MaxWorkTime");
				overall.TotalHoldTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalHoldTime");
				overall.AverageWorkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.AverageWorkTime");
				overall.MaxBreakTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.MaxBreakTime");
				overall.SatisfactionIndex = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.SatisfactionIndex");
				overall.MaxReadyTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.MaxReadyTime");
				overall.MaxTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.MaxTalkTime");
				overall.TotalReadyTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalReadyTime");
				overall.LastCheckoutTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.LastCheckoutTime");
				overall.TotalCalls = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalCalls");
				overall.TotalLoggedInTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalTalkTime");
				overall.MaxHoldTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.MaxHoldTime");
				overall.AverageBreakTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.AverageBreakTime");
				overall.AverageTalkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.AverageTalkTime");
				overall.SatisfactionRate = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.SatisfactionRate");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.FirstCheckInTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.FirstCheckInTime");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.AverageHoldTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.AverageHoldTime");
				overall.AverageReadyTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.AverageReadyTime");
				overall.TotalBreakTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalBreakTime");
				dataItem.Overall = overall;

				listIntervalAgentReportResponse_data.Add(dataItem);
			}
			listIntervalAgentReportResponse.Data = listIntervalAgentReportResponse_data;
        
			return listIntervalAgentReportResponse;
        }
    }
}
