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
    public class ListIntervalInstanceReportResponseUnmarshaller
    {
        public static ListIntervalInstanceReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIntervalInstanceReportResponse listIntervalInstanceReportResponse = new ListIntervalInstanceReportResponse();

			listIntervalInstanceReportResponse.HttpResponse = _ctx.HttpResponse;
			listIntervalInstanceReportResponse.Code = _ctx.StringValue("ListIntervalInstanceReport.Code");
			listIntervalInstanceReportResponse.HttpStatusCode = _ctx.IntegerValue("ListIntervalInstanceReport.HttpStatusCode");
			listIntervalInstanceReportResponse.Message = _ctx.StringValue("ListIntervalInstanceReport.Message");
			listIntervalInstanceReportResponse.RequestId = _ctx.StringValue("ListIntervalInstanceReport.RequestId");

			List<ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem> listIntervalInstanceReportResponse_data = new List<ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem>();
			for (int i = 0; i < _ctx.Length("ListIntervalInstanceReport.Data.Length"); i++) {
				ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem dataItem = new ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem();
				dataItem.StatsTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].StatsTime");

				ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Inbound inbound = new ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Inbound();
				inbound.AbandonedRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AbandonedRate");
				inbound.AverageAbandonTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageAbandonTime");
				inbound.AverageAbandonedInIVRTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageAbandonedInIVRTime");
				inbound.AverageAbandonedInQueueTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageAbandonedInQueueTime");
				inbound.AverageAbandonedInRingTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageAbandonedInRingTime");
				inbound.AverageHoldTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageHoldTime");
				inbound.AverageRingTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageRingTime");
				inbound.AverageTalkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageTalkTime");
				inbound.AverageWaitTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageWaitTime");
				inbound.AverageWorkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.AverageWorkTime");
				inbound.CallsAbandoned = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAbandoned");
				inbound.CallsAbandonedInIVR = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAbandonedInIVR");
				inbound.CallsAbandonedInQueue = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAbandonedInQueue");
				inbound.CallsAbandonedInRinging = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsAbandonedInRinging");
				inbound.CallsConsulted = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsConsulted");
				inbound.CallsHandled = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsHandled");
				inbound.CallsHold = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsHold");
				inbound.CallsOffered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsOffered");
				inbound.CallsQueued = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsQueued");
				inbound.CallsRinged = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsRinged");
				inbound.CallsTransferred = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.CallsTransferred");
				inbound.HandleRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.HandleRate");
				inbound.MaxAbandonTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxAbandonTime");
				inbound.MaxAbandonedInIVRTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxAbandonedInIVRTime");
				inbound.MaxAbandonedInQueueTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxAbandonedInQueueTime");
				inbound.MaxAbandonedInRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxAbandonedInRingTime");
				inbound.MaxHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxHoldTime");
				inbound.MaxRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxRingTime");
				inbound.MaxTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxTalkTime");
				inbound.MaxWaitTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxWaitTime");
				inbound.MaxWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.MaxWorkTime");
				inbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.SatisfactionIndex");
				inbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.SatisfactionSurveysOffered");
				inbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.SatisfactionSurveysResponded");
				inbound.ServiceLevel20 = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.ServiceLevel20");
				inbound.TotalAbandonTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalAbandonTime");
				inbound.TotalAbandonedInIVRTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalAbandonedInIVRTime");
				inbound.TotalAbandonedInQueueTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalAbandonedInQueueTime");
				inbound.TotalAbandonedInRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalAbandonedInRingTime");
				inbound.TotalHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalHoldTime");
				inbound.TotalRingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalRingTime");
				inbound.TotalTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalTalkTime");
				inbound.TotalWaitTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalWaitTime");
				inbound.TotalWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Inbound.TotalWorkTime");
				dataItem.Inbound = inbound;

				ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Outbound outbound = new ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Outbound();
				outbound.AnswerRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AnswerRate");
				outbound.AverageDialingTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AverageDialingTime");
				outbound.AverageTalkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AverageTalkTime");
				outbound.AverageWorkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.AverageWorkTime");
				outbound.CallsAnswered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.CallsAnswered");
				outbound.CallsDialed = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.CallsDialed");
				outbound.CallsDialedSuccess = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.CallsDialedSuccess");
				outbound.MaxDialingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.MaxDialingTime");
				outbound.MaxTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.MaxTalkTime");
				outbound.MaxWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.MaxWorkTime");
				outbound.SatisfactionIndex = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.SatisfactionIndex");
				outbound.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.SatisfactionSurveysOffered");
				outbound.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.SatisfactionSurveysResponded");
				outbound.TotalDialingTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.TotalDialingTime");
				outbound.TotalHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.TotalHoldTime");
				outbound.TotalTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.TotalTalkTime");
				outbound.TotalWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Outbound.TotalWorkTime");
				dataItem.Outbound = outbound;

				ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Overall overall = new ListIntervalInstanceReportResponse.ListIntervalInstanceReport_DataItem.ListIntervalInstanceReport_Overall();
				overall.AverageBreakTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageBreakTime");
				overall.AverageHoldTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageHoldTime");
				overall.AverageReadyTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageReadyTime");
				overall.AverageTalkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageTalkTime");
				overall.AverageWorkTime = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.AverageWorkTime");
				overall.MaxBreakTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxBreakTime");
				overall.MaxHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxHoldTime");
				overall.MaxReadyTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxReadyTime");
				overall.MaxTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxTalkTime");
				overall.MaxWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.MaxWorkTime");
				overall.OccupancyRate = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.OccupancyRate");
				overall.SatisfactionIndex = _ctx.FloatValue("ListIntervalInstanceReport.Data["+ i +"].Overall.SatisfactionIndex");
				overall.SatisfactionSurveysOffered = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.SatisfactionSurveysOffered");
				overall.SatisfactionSurveysResponded = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.SatisfactionSurveysResponded");
				overall.TotalBreakTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalBreakTime");
				overall.TotalCalls = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalCalls");
				overall.TotalHoldTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalHoldTime");
				overall.TotalLoggedInTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalLoggedInTime");
				overall.TotalReadyTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalReadyTime");
				overall.TotalTalkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalTalkTime");
				overall.TotalWorkTime = _ctx.LongValue("ListIntervalInstanceReport.Data["+ i +"].Overall.TotalWorkTime");
				dataItem.Overall = overall;

				listIntervalInstanceReportResponse_data.Add(dataItem);
			}
			listIntervalInstanceReportResponse.Data = listIntervalInstanceReportResponse_data;
        
			return listIntervalInstanceReportResponse;
        }
    }
}
