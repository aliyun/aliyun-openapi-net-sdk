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
        public static GetCallMeasureSummaryReportResponse Unmarshall(UnmarshallerContext context)
        {
			GetCallMeasureSummaryReportResponse getCallMeasureSummaryReportResponse = new GetCallMeasureSummaryReportResponse();

			getCallMeasureSummaryReportResponse.HttpResponse = context.HttpResponse;
			getCallMeasureSummaryReportResponse.RequestId = context.StringValue("GetCallMeasureSummaryReport.RequestId");
			getCallMeasureSummaryReportResponse.Success = context.BooleanValue("GetCallMeasureSummaryReport.Success");
			getCallMeasureSummaryReportResponse.Code = context.StringValue("GetCallMeasureSummaryReport.Code");
			getCallMeasureSummaryReportResponse.Message = context.StringValue("GetCallMeasureSummaryReport.Message");
			getCallMeasureSummaryReportResponse.HttpStatusCode = context.IntegerValue("GetCallMeasureSummaryReport.HttpStatusCode");

			GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_SummaryReport summaryReport = new GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_SummaryReport();
			summaryReport.Year = context.IntegerValue("GetCallMeasureSummaryReport.SummaryReport.Year");
			summaryReport.Month = context.IntegerValue("GetCallMeasureSummaryReport.SummaryReport.Month");
			summaryReport.Day = context.IntegerValue("GetCallMeasureSummaryReport.SummaryReport.Day");
			summaryReport.InboundCount = context.LongValue("GetCallMeasureSummaryReport.SummaryReport.InboundCount");
			summaryReport.OutboundCount = context.LongValue("GetCallMeasureSummaryReport.SummaryReport.OutboundCount");
			summaryReport.OutboundDurationByMinute = context.LongValue("GetCallMeasureSummaryReport.SummaryReport.OutboundDurationByMinute");
			summaryReport.InboundDurationByMinute = context.LongValue("GetCallMeasureSummaryReport.SummaryReport.InboundDurationByMinute");
			getCallMeasureSummaryReportResponse.SummaryReport = summaryReport;

			GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports numberReports = new GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports();
			numberReports.TotalCount = context.IntegerValue("GetCallMeasureSummaryReport.NumberReports.TotalCount");
			numberReports.PageNumber = context.IntegerValue("GetCallMeasureSummaryReport.NumberReports.PageNumber");
			numberReports.PageSize = context.IntegerValue("GetCallMeasureSummaryReport.NumberReports.PageSize");

			List<GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports.GetCallMeasureSummaryReport_NumberReport> numberReports_list = new List<GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports.GetCallMeasureSummaryReport_NumberReport>();
			for (int i = 0; i < context.Length("GetCallMeasureSummaryReport.NumberReports.List.Length"); i++) {
				GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports.GetCallMeasureSummaryReport_NumberReport numberReport = new GetCallMeasureSummaryReportResponse.GetCallMeasureSummaryReport_NumberReports.GetCallMeasureSummaryReport_NumberReport();
				numberReport.Number = context.StringValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].Number");
				numberReport.Year = context.IntegerValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].Year");
				numberReport.Month = context.IntegerValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].Month");
				numberReport.Day = context.IntegerValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].Day");
				numberReport.InboundCount = context.LongValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].InboundCount");
				numberReport.OutboundCount = context.LongValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].OutboundCount");
				numberReport.OutboundDurationByMinute = context.LongValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].OutboundDurationByMinute");
				numberReport.InboundDurationByMinute = context.LongValue("GetCallMeasureSummaryReport.NumberReports.List["+ i +"].InboundDurationByMinute");

				numberReports_list.Add(numberReport);
			}
			numberReports.List = numberReports_list;
			getCallMeasureSummaryReportResponse.NumberReports = numberReports;
        
			return getCallMeasureSummaryReportResponse;
        }
    }
}
