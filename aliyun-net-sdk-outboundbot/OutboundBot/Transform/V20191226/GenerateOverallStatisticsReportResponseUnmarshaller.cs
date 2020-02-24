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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class GenerateOverallStatisticsReportResponseUnmarshaller
    {
        public static GenerateOverallStatisticsReportResponse Unmarshall(UnmarshallerContext context)
        {
			GenerateOverallStatisticsReportResponse generateOverallStatisticsReportResponse = new GenerateOverallStatisticsReportResponse();

			generateOverallStatisticsReportResponse.HttpResponse = context.HttpResponse;
			generateOverallStatisticsReportResponse.RequestId = context.StringValue("GenerateOverallStatisticsReport.RequestId");
			generateOverallStatisticsReportResponse.Success = context.BooleanValue("GenerateOverallStatisticsReport.Success");
			generateOverallStatisticsReportResponse.Code = context.StringValue("GenerateOverallStatisticsReport.Code");
			generateOverallStatisticsReportResponse.Message = context.StringValue("GenerateOverallStatisticsReport.Message");
			generateOverallStatisticsReportResponse.HttpStatusCode = context.IntegerValue("GenerateOverallStatisticsReport.HttpStatusCode");

			GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport overallStatisticsReport = new GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport();

			List<GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair> overallStatisticsReport_indicators = new List<GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair>();
			for (int i = 0; i < context.Length("GenerateOverallStatisticsReport.OverallStatisticsReport.Indicators.Length"); i++) {
				GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair keyValuePair = new GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair();
				keyValuePair.Key = context.StringValue("GenerateOverallStatisticsReport.OverallStatisticsReport.Indicators["+ i +"].Key");
				keyValuePair._Value = context.StringValue("GenerateOverallStatisticsReport.OverallStatisticsReport.Indicators["+ i +"].Value");

				overallStatisticsReport_indicators.Add(keyValuePair);
			}
			overallStatisticsReport.Indicators = overallStatisticsReport_indicators;

			List<GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair> overallStatisticsReport_briefs = new List<GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair>();
			for (int i = 0; i < context.Length("GenerateOverallStatisticsReport.OverallStatisticsReport.Briefs.Length"); i++) {
				GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair keyValuePair = new GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair();
				keyValuePair.Key = context.StringValue("GenerateOverallStatisticsReport.OverallStatisticsReport.Briefs["+ i +"].Key");
				keyValuePair._Value = context.StringValue("GenerateOverallStatisticsReport.OverallStatisticsReport.Briefs["+ i +"].Value");

				overallStatisticsReport_briefs.Add(keyValuePair);
			}
			overallStatisticsReport.Briefs = overallStatisticsReport_briefs;

			List<GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair> overallStatisticsReport_summaries = new List<GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair>();
			for (int i = 0; i < context.Length("GenerateOverallStatisticsReport.OverallStatisticsReport.Summaries.Length"); i++) {
				GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair keyValuePair = new GenerateOverallStatisticsReportResponse.GenerateOverallStatisticsReport_OverallStatisticsReport.GenerateOverallStatisticsReport_KeyValuePair();
				keyValuePair.Key = context.StringValue("GenerateOverallStatisticsReport.OverallStatisticsReport.Summaries["+ i +"].Key");
				keyValuePair._Value = context.StringValue("GenerateOverallStatisticsReport.OverallStatisticsReport.Summaries["+ i +"].Value");

				overallStatisticsReport_summaries.Add(keyValuePair);
			}
			overallStatisticsReport.Summaries = overallStatisticsReport_summaries;
			generateOverallStatisticsReportResponse.OverallStatisticsReport = overallStatisticsReport;
        
			return generateOverallStatisticsReportResponse;
        }
    }
}
