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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDiagnosticReportListResponseUnmarshaller
    {
        public static DescribeDiagnosticReportListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDiagnosticReportListResponse describeDiagnosticReportListResponse = new DescribeDiagnosticReportListResponse();

			describeDiagnosticReportListResponse.HttpResponse = _ctx.HttpResponse;
			describeDiagnosticReportListResponse.RequestId = _ctx.StringValue("DescribeDiagnosticReportList.RequestId");

			List<DescribeDiagnosticReportListResponse.DescribeDiagnosticReportList_Report> describeDiagnosticReportListResponse_reportList = new List<DescribeDiagnosticReportListResponse.DescribeDiagnosticReportList_Report>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnosticReportList.ReportList.Length"); i++) {
				DescribeDiagnosticReportListResponse.DescribeDiagnosticReportList_Report report = new DescribeDiagnosticReportListResponse.DescribeDiagnosticReportList_Report();
				report.DiagnosticTime = _ctx.StringValue("DescribeDiagnosticReportList.ReportList["+ i +"].DiagnosticTime");
				report.Score = _ctx.IntegerValue("DescribeDiagnosticReportList.ReportList["+ i +"].Score");
				report.StartTime = _ctx.StringValue("DescribeDiagnosticReportList.ReportList["+ i +"].StartTime");
				report.EndTime = _ctx.StringValue("DescribeDiagnosticReportList.ReportList["+ i +"].EndTime");
				report.DownloadURL = _ctx.StringValue("DescribeDiagnosticReportList.ReportList["+ i +"].DownloadURL");

				describeDiagnosticReportListResponse_reportList.Add(report);
			}
			describeDiagnosticReportListResponse.ReportList = describeDiagnosticReportListResponse_reportList;
        
			return describeDiagnosticReportListResponse;
        }
    }
}
