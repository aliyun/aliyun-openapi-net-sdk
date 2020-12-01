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
    public class GetCallMeasureSummaryReportResponseUnmarshaller
    {
        public static GetCallMeasureSummaryReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCallMeasureSummaryReportResponse getCallMeasureSummaryReportResponse = new GetCallMeasureSummaryReportResponse();

			getCallMeasureSummaryReportResponse.HttpResponse = _ctx.HttpResponse;
			getCallMeasureSummaryReportResponse.RequestId = _ctx.StringValue("GetCallMeasureSummaryReport.RequestId");
			getCallMeasureSummaryReportResponse.Success = _ctx.BooleanValue("GetCallMeasureSummaryReport.Success");
			getCallMeasureSummaryReportResponse.Code = _ctx.StringValue("GetCallMeasureSummaryReport.Code");
			getCallMeasureSummaryReportResponse.Message = _ctx.StringValue("GetCallMeasureSummaryReport.Message");
			getCallMeasureSummaryReportResponse.HttpStatusCode = _ctx.IntegerValue("GetCallMeasureSummaryReport.HttpStatusCode");

			GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_SummaryReport summaryReport = new GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_SummaryReport();
			summaryReport.Year = _ctx.IntegerValue("GetCallMeasureSummaryReport.SummaryReport.Year");
			summaryReport.Month = _ctx.IntegerValue("GetCallMeasureSummaryReport.SummaryReport.Month");
			summaryReport.Day = _ctx.IntegerValue("GetCallMeasureSummaryReport.SummaryReport.Day");
			summaryReport.InboundCount = _ctx.LongValue("GetCallMeasureSummaryReport.SummaryReport.InboundCount");
			summaryReport.OutboundCount = _ctx.LongValue("GetCallMeasureSummaryReport.SummaryReport.OutboundCount");
			summaryReport.OutboundDurationByMinute = _ctx.LongValue("GetCallMeasureSummaryReport.SummaryReport.OutboundDurationByMinute");
			summaryReport.InboundDurationByMinute = _ctx.LongValue("GetCallMeasureSummaryReport.SummaryReport.InboundDurationByMinute");
			getCallMeasureSummaryReportResponse.SummaryReport = summaryReport;

			GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports numberReports = new GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports();
			numberReports.TotalCount = _ctx.IntegerValue("GetCallMeasureSummaryReport.NumberReports.TotalCount");
			numberReports.PageNumber = _ctx.IntegerValue("GetCallMeasureSummaryReport.NumberReports.PageNumber");
			numberReports.PageSize = _ctx.IntegerValue("GetCallMeasureSummaryReport.NumberReports.PageSize");

			List<GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports.GetCallMeasureSummaryReport_NumberReport> numberReports_list = new List<GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports.GetCallMeasureSummaryReport_NumberReport>();
			for (int i = 0; i < _ctx.Length("GetCallMeasureSummaryReport.NumberReports.List.Length"); i++) {
				GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports.GetCallMeasureSummaryReport_NumberReport numberReport = new GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports.GetCallMeasureSummaryReport_NumberReport();
				numberReport.Number = _ctx.StringValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].Number");
				numberReport.Year = _ctx.IntegerValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].Year");
				numberReport.Month = _ctx.IntegerValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].Month");
				numberReport.Day = _ctx.IntegerValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].Day");
				numberReport.InboundCount = _ctx.LongValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].InboundCount");
				numberReport.OutboundCount = _ctx.LongValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].OutboundCount");
				numberReport.OutboundDurationByMinute = _ctx.LongValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].OutboundDurationByMinute");
				numberReport.InboundDurationByMinute = _ctx.LongValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].InboundDurationByMinute");

				numberReports_list.Add(numberReport);
			}
			numberReports.List = numberReports_list;
			getCallMeasureSummaryReportResponse.NumberReports = numberReports;
        
			return getCallMeasureSummaryReportResponse;
        }
    }
}
