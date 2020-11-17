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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class DescribeDiagnoseReportResponseUnmarshaller
    {
        public static DescribeDiagnoseReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDiagnoseReportResponse describeDiagnoseReportResponse = new DescribeDiagnoseReportResponse();

			describeDiagnoseReportResponse.HttpResponse = _ctx.HttpResponse;
			describeDiagnoseReportResponse.RequestId = _ctx.StringValue("DescribeDiagnoseReport.RequestId");

			DescribeDiagnoseReportResponse.DescribeDiagnoseReport_Result result = new DescribeDiagnoseReportResponse.DescribeDiagnoseReport_Result();
			result.ReportId = _ctx.StringValue("DescribeDiagnoseReport.Result.reportId");
			result.InstanceId = _ctx.StringValue("DescribeDiagnoseReport.Result.instanceId");
			result.State = _ctx.StringValue("DescribeDiagnoseReport.Result.state");
			result.CreateTime = _ctx.LongValue("DescribeDiagnoseReport.Result.createTime");
			result.Health = _ctx.StringValue("DescribeDiagnoseReport.Result.health");
			result.Trigger = _ctx.StringValue("DescribeDiagnoseReport.Result.trigger");

			List<DescribeDiagnoseReportResponse.DescribeDiagnoseReport_Result.DescribeDiagnoseReport_DiagnoseItemsItem> result_diagnoseItems = new List<DescribeDiagnoseReportResponse.DescribeDiagnoseReport_Result.DescribeDiagnoseReport_DiagnoseItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnoseReport.Result.DiagnoseItems.Length"); i++) {
				DescribeDiagnoseReportResponse.DescribeDiagnoseReport_Result.DescribeDiagnoseReport_DiagnoseItemsItem diagnoseItemsItem = new DescribeDiagnoseReportResponse.DescribeDiagnoseReport_Result.DescribeDiagnoseReport_DiagnoseItemsItem();
				diagnoseItemsItem.Item = _ctx.StringValue("DescribeDiagnoseReport.Result.DiagnoseItems["+ i +"].item");
				diagnoseItemsItem.Health = _ctx.StringValue("DescribeDiagnoseReport.Result.DiagnoseItems["+ i +"].health");

				DescribeDiagnoseReportResponse.DescribeDiagnoseReport_Result.DescribeDiagnoseReport_DiagnoseItemsItem.DescribeDiagnoseReport_Detail detail = new DescribeDiagnoseReportResponse.DescribeDiagnoseReport_Result.DescribeDiagnoseReport_DiagnoseItemsItem.DescribeDiagnoseReport_Detail();
				detail.Name = _ctx.StringValue("DescribeDiagnoseReport.Result.DiagnoseItems["+ i +"].Detail.name");
				detail.Desc = _ctx.StringValue("DescribeDiagnoseReport.Result.DiagnoseItems["+ i +"].Detail.desc");
				detail.Type = _ctx.StringValue("DescribeDiagnoseReport.Result.DiagnoseItems["+ i +"].Detail.type");
				detail.Suggest = _ctx.StringValue("DescribeDiagnoseReport.Result.DiagnoseItems["+ i +"].Detail.suggest");
				detail.Result = _ctx.StringValue("DescribeDiagnoseReport.Result.DiagnoseItems["+ i +"].Detail.result");
				diagnoseItemsItem.Detail = detail;

				result_diagnoseItems.Add(diagnoseItemsItem);
			}
			result.DiagnoseItems = result_diagnoseItems;
			describeDiagnoseReportResponse.Result = result;
        
			return describeDiagnoseReportResponse;
        }
    }
}
