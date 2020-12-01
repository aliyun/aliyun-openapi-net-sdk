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
    public class ListCallMeasureSummaryReportsResponseUnmarshaller
    {
        public static ListCallMeasureSummaryReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCallMeasureSummaryReportsResponse listCallMeasureSummaryReportsResponse = new ListCallMeasureSummaryReportsResponse();

			listCallMeasureSummaryReportsResponse.HttpResponse = _ctx.HttpResponse;
			listCallMeasureSummaryReportsResponse.RequestId = _ctx.StringValue("ListCallMeasureSummaryReports.RequestId");
			listCallMeasureSummaryReportsResponse.Success = _ctx.BooleanValue("ListCallMeasureSummaryReports.Success");
			listCallMeasureSummaryReportsResponse.Code = _ctx.StringValue("ListCallMeasureSummaryReports.Code");
			listCallMeasureSummaryReportsResponse.Message = _ctx.StringValue("ListCallMeasureSummaryReports.Message");
			listCallMeasureSummaryReportsResponse.HttpStatusCode = _ctx.IntegerValue("ListCallMeasureSummaryReports.HttpStatusCode");

			List<ListCallMeasureSummaryReportsResponse.ListCallMeasureSummaryReports_CallMeasureSummaryReport> listCallMeasureSummaryReportsResponse_callMeasureSummaryReportList = new List<ListCallMeasureSummaryReportsResponse.ListCallMeasureSummaryReports_CallMeasureSummaryReport>();
			for (int i = 0; i < _ctx.Length("ListCallMeasureSummaryReports.CallMeasureSummaryReportList.Length"); i++) {
				ListCallMeasureSummaryReportsResponse.ListCallMeasureSummaryReports_CallMeasureSummaryReport callMeasureSummaryReport = new ListCallMeasureSummaryReportsResponse.ListCallMeasureSummaryReports_CallMeasureSummaryReport();
				callMeasureSummaryReport.Year = _ctx.StringValue("ListCallMeasureSummaryReports.CallMeasureSummaryReportList["+ i +"].Year");
				callMeasureSummaryReport.Month = _ctx.StringValue("ListCallMeasureSummaryReports.CallMeasureSummaryReportList["+ i +"].Month");
				callMeasureSummaryReport.Day = _ctx.StringValue("ListCallMeasureSummaryReports.CallMeasureSummaryReportList["+ i +"].Day");
				callMeasureSummaryReport.InboundCount = _ctx.LongValue("ListCallMeasureSummaryReports.CallMeasureSummaryReportList["+ i +"].InboundCount");
				callMeasureSummaryReport.OutboundCount = _ctx.LongValue("ListCallMeasureSummaryReports.CallMeasureSummaryReportList["+ i +"].OutboundCount");
				callMeasureSummaryReport.OutboundDurationByMinute = _ctx.LongValue("ListCallMeasureSummaryReports.CallMeasureSummaryReportList["+ i +"].OutboundDurationByMinute");
				callMeasureSummaryReport.InboundDurationByMinute = _ctx.LongValue("ListCallMeasureSummaryReports.CallMeasureSummaryReportList["+ i +"].InboundDurationByMinute");

				listCallMeasureSummaryReportsResponse_callMeasureSummaryReportList.Add(callMeasureSummaryReport);
			}
			listCallMeasureSummaryReportsResponse.CallMeasureSummaryReportList = listCallMeasureSummaryReportsResponse_callMeasureSummaryReportList;
        
			return listCallMeasureSummaryReportsResponse;
        }
    }
}
