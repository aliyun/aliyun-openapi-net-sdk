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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDiagnosticReportListResponseUnmarshaller
    {
        public static DescribeDiagnosticReportListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDiagnosticReportListResponse describeDiagnosticReportListResponse = new DescribeDiagnosticReportListResponse();

			describeDiagnosticReportListResponse.HttpResponse = context.HttpResponse;
			describeDiagnosticReportListResponse.RequestId = context.StringValue("DescribeDiagnosticReportList.RequestId");

			List<DescribeDiagnosticReportListResponse.Report> reportList = new List<DescribeDiagnosticReportListResponse.Report>();
			for (int i = 0; i < context.Length("DescribeDiagnosticReportList.ReportList.Length"); i++) {
				DescribeDiagnosticReportListResponse.Report report = new DescribeDiagnosticReportListResponse.Report();
				report.DiagnosticTime = context.StringValue("DescribeDiagnosticReportList.ReportList["+ i +"].DiagnosticTime");
				report.Score = context.IntegerValue("DescribeDiagnosticReportList.ReportList["+ i +"].Score");
				report.StartTime = context.StringValue("DescribeDiagnosticReportList.ReportList["+ i +"].StartTime");
				report.EndTime = context.StringValue("DescribeDiagnosticReportList.ReportList["+ i +"].EndTime");
				report.DownloadURL = context.StringValue("DescribeDiagnosticReportList.ReportList["+ i +"].DownloadURL");

				reportList.Add(report);
			}
			describeDiagnosticReportListResponse.ReportList = reportList;
        
			return describeDiagnosticReportListResponse;
        }
    }
}