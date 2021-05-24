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
				inbound.AverageTalkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.AverageTalkTime");
				inbound.AverageWorkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.AverageWorkTime");
				inbound.CallsConsulted = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsConsulted");
				inbound.CallsHandled = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsHandled");
				inbound.CallsHold = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsHold");
				inbound.CallsOffered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsOffered");
				inbound.CallsTransferred = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.CallsTransferred");
				inbound.HandleRate = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.HandleRate");
				inbound.MaxRingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.MaxRingTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.MaxWorkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.TotalHoldTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.TotalHoldTime");
				inbound.TotalRingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.TotalRingTime");
				inbound.TotalTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.TotalTalkTime");
				inbound.TotalWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Inbound.TotalWorkTime");
				dataItem.Inbound = inbound;

				ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Outbound outbound = new ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Outbound();
				outbound.AnswerRate = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AnswerRate");
				outbound.AverageDialingTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AverageDialingTime");
				outbound.AverageTalkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AverageTalkTime");
				outbound.AverageWorkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.AverageWorkTime");
				outbound.CallsAnswered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsAnswered");
				outbound.CallsDialed = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.CallsDialed");
				outbound.MaxDialingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.MaxDialingTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.MaxTalkTime");
				outbound.MaxWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.MaxWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.TotalDialingTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalHoldTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.TotalHoldTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.TotalTalkTime");
				outbound.TotalWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Outbound.TotalWorkTime");
				dataItem.Outbound = outbound;

				ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Overall overall = new ListIntervalAgentReportResponse.ListIntervalAgentReport_DataItem.ListIntervalAgentReport_Overall();
				overall.AverageBreakTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.AverageBreakTime");
				overall.AverageReadyTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.AverageReadyTime");
				overall.AverageTalkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.AverageTalkTime");
				overall.AverageWorkTime = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.AverageWorkTime");
				overall.FirstCheckInTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.FirstCheckInTime");
				overall.LastCheckoutTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.LastCheckoutTime");
				overall.MaxBreakTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.MaxBreakTime");
				overall.MaxReadyTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.MaxReadyTime");
				overall.MaxTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.MaxTalkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.MaxWorkTime");
				overall.OccupancyRate = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.OccupancyRate");
				overall.SatisfactionIndex = _ctx.FloatValue("ListIntervalAgentReport.Data["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.TotalBreakTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalBreakTime");
				overall.TotalCalls = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalCalls");
				overall.TotalHoldTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalHoldTime");
				overall.TotalLoggedInTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalReadyTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalReadyTime");
				overall.TotalTalkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalTalkTime");
				overall.TotalWorkTime = _ctx.LongValue("ListIntervalAgentReport.Data["+ i +"].Overall.TotalWorkTime");
				dataItem.Overall = overall;

				listIntervalAgentReportResponse_data.Add(dataItem);
			}
			listIntervalAgentReportResponse.Data = listIntervalAgentReportResponse_data;
        
			return listIntervalAgentReportResponse;
        }
    }
}
