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
    public class ListHistoricalAgentReportResponseUnmarshaller
    {
        public static ListHistoricalAgentReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListHistoricalAgentReportResponse listHistoricalAgentReportResponse = new ListHistoricalAgentReportResponse();

			listHistoricalAgentReportResponse.HttpResponse = _ctx.HttpResponse;
			listHistoricalAgentReportResponse.Code = _ctx.StringValue("ListHistoricalAgentReport.Code");
			listHistoricalAgentReportResponse.HttpStatusCode = _ctx.IntegerValue("ListHistoricalAgentReport.HttpStatusCode");
			listHistoricalAgentReportResponse.Message = _ctx.StringValue("ListHistoricalAgentReport.Message");
			listHistoricalAgentReportResponse.RequestId = _ctx.StringValue("ListHistoricalAgentReport.RequestId");

			ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data data = new ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data();
			data.PageNumber = _ctx.IntegerValue("ListHistoricalAgentReport.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListHistoricalAgentReport.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListHistoricalAgentReport.Data.TotalCount");

			List<ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items> data_list = new List<ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items>();
			for (int i = 0; i < _ctx.Length("ListHistoricalAgentReport.Data.List.Length"); i++) {
				ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items items = new ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items();
				items.AgentId = _ctx.StringValue("ListHistoricalAgentReport.Data.List["+ i +"].AgentId");
				items.AgentName = _ctx.StringValue("ListHistoricalAgentReport.Data.List["+ i +"].AgentName");

				ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items.ListHistoricalAgentReport_Inbound inbound = new ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items.ListHistoricalAgentReport_Inbound();
				inbound.AverageHoldTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.AverageHoldTime");
				inbound.AverageRingTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.AverageRingTime");
				inbound.AverageTalkTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.AverageTalkTime");
				inbound.AverageWorkTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.AverageWorkTime");
				inbound.CallsConsulted = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.CallsConsulted");
				inbound.CallsHandled = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.CallsHandled");
				inbound.CallsHold = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.CallsHold");
				inbound.CallsOffered = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.CallsOffered");
				inbound.CallsTransferred = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.CallsTransferred");
				inbound.HandleRate = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.HandleRate");
				inbound.MaxHoldTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.MaxHoldTime");
				inbound.MaxRingTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.MaxRingTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.MaxWorkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.TotalHoldTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.TotalHoldTime");
				inbound.TotalRingTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.TotalRingTime");
				inbound.TotalTalkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.TotalTalkTime");
				inbound.TotalWorkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Inbound.TotalWorkTime");
				items.Inbound = inbound;

				ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items.ListHistoricalAgentReport_Outbound outbound = new ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items.ListHistoricalAgentReport_Outbound();
				outbound.AnswerRate = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.AnswerRate");
				outbound.AverageDialingTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.AverageDialingTime");
				outbound.AverageHoldTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.AverageHoldTime");
				outbound.AverageTalkTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.AverageTalkTime");
				outbound.AverageWorkTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.AverageWorkTime");
				outbound.CallsAnswered = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.CallsAnswered");
				outbound.CallsDialed = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.CallsDialed");
				outbound.CallsDialedSuccess = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.CallsDialedSuccess");
				outbound.CallsHold = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.CallsHold");
				outbound.MaxDialingTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.MaxDialingTime");
				outbound.MaxHoldTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.MaxHoldTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.MaxTalkTime");
				outbound.MaxWorkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.MaxWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.TotalDialingTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalHoldTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.TotalHoldTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.TotalTalkTime");
				outbound.TotalWorkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Outbound.TotalWorkTime");
				items.Outbound = outbound;

				ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items.ListHistoricalAgentReport_Overall overall = new ListHistoricalAgentReportResponse.ListHistoricalAgentReport_Data.ListHistoricalAgentReport_Items.ListHistoricalAgentReport_Overall();
				overall.AverageBreakTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.AverageBreakTime");
				overall.AverageReadyTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.AverageReadyTime");
				overall.AverageTalkTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.AverageTalkTime");
				overall.AverageWorkTime = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.AverageWorkTime");
				overall.MaxBreakTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.MaxBreakTime");
				overall.MaxReadyTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.MaxReadyTime");
				overall.MaxTalkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.MaxTalkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.MaxWorkTime");
				overall.OccupancyRate = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.OccupancyRate");
				overall.SatisfactionIndex = _ctx.FloatValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.TotalBreakTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.TotalBreakTime");
				overall.TotalCalls = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.TotalCalls");
				overall.TotalHoldTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.TotalHoldTime");
				overall.TotalLoggedInTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalReadyTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.TotalReadyTime");
				overall.TotalTalkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.TotalTalkTime");
				overall.TotalWorkTime = _ctx.LongValue("ListHistoricalAgentReport.Data.List["+ i +"].Overall.TotalWorkTime");
				items.Overall = overall;

				data_list.Add(items);
			}
			data.List = data_list;
			listHistoricalAgentReportResponse.Data = data;
        
			return listHistoricalAgentReportResponse;
        }
    }
}
