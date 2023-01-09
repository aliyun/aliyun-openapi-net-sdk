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
using Aliyun.Acs.PTS.Model.V20201020;

namespace Aliyun.Acs.PTS.Transform.V20201020
{
    public class ListJMeterReportsResponseUnmarshaller
    {
        public static ListJMeterReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJMeterReportsResponse listJMeterReportsResponse = new ListJMeterReportsResponse();

			listJMeterReportsResponse.HttpResponse = _ctx.HttpResponse;
			listJMeterReportsResponse.TotalCount = _ctx.LongValue("ListJMeterReports.TotalCount");
			listJMeterReportsResponse.RequestId = _ctx.StringValue("ListJMeterReports.RequestId");
			listJMeterReportsResponse.Message = _ctx.StringValue("ListJMeterReports.Message");
			listJMeterReportsResponse.PageSize = _ctx.IntegerValue("ListJMeterReports.PageSize");
			listJMeterReportsResponse.PageNumber = _ctx.IntegerValue("ListJMeterReports.PageNumber");
			listJMeterReportsResponse.HttpStatusCode = _ctx.IntegerValue("ListJMeterReports.HttpStatusCode");
			listJMeterReportsResponse.Code = _ctx.StringValue("ListJMeterReports.Code");
			listJMeterReportsResponse.Success = _ctx.BooleanValue("ListJMeterReports.Success");

			List<ListJMeterReportsResponse.ListJMeterReports_JMeterReportView> listJMeterReportsResponse_reports = new List<ListJMeterReportsResponse.ListJMeterReports_JMeterReportView>();
			for (int i = 0; i < _ctx.Length("ListJMeterReports.Reports.Length"); i++) {
				ListJMeterReportsResponse.ListJMeterReports_JMeterReportView jMeterReportView = new ListJMeterReportsResponse.ListJMeterReports_JMeterReportView();
				jMeterReportView.ReportName = _ctx.StringValue("ListJMeterReports.Reports["+ i +"].ReportName");
				jMeterReportView.Duration = _ctx.StringValue("ListJMeterReports.Reports["+ i +"].Duration");
				jMeterReportView.ReportId = _ctx.StringValue("ListJMeterReports.Reports["+ i +"].ReportId");
				jMeterReportView.Vum = _ctx.LongValue("ListJMeterReports.Reports["+ i +"].Vum");
				jMeterReportView.ActualStartTime = _ctx.LongValue("ListJMeterReports.Reports["+ i +"].ActualStartTime");

				listJMeterReportsResponse_reports.Add(jMeterReportView);
			}
			listJMeterReportsResponse.Reports = listJMeterReportsResponse_reports;
        
			return listJMeterReportsResponse;
        }
    }
}
