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
    public class ListDiagnoseReportResponseUnmarshaller
    {
        public static ListDiagnoseReportResponse Unmarshall(UnmarshallerContext context)
        {
			ListDiagnoseReportResponse listDiagnoseReportResponse = new ListDiagnoseReportResponse();

			listDiagnoseReportResponse.HttpResponse = context.HttpResponse;
			listDiagnoseReportResponse.RequestId = context.StringValue("ListDiagnoseReport.RequestId");

			ListDiagnoseReportResponse.ListDiagnoseReport_Headers headers = new ListDiagnoseReportResponse.ListDiagnoseReport_Headers();
			headers.XTotalCount = context.IntegerValue("ListDiagnoseReport.Headers.X-Total-Count");
			listDiagnoseReportResponse.Headers = headers;

			List<ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem> listDiagnoseReportResponse_result = new List<ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem>();
			for (int i = 0; i < context.Length("ListDiagnoseReport.Result.Length"); i++) {
				ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem resultItem = new ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem();
				resultItem.ReportId = context.StringValue("ListDiagnoseReport.Result["+ i +"].reportId");
				resultItem.InstanceId = context.StringValue("ListDiagnoseReport.Result["+ i +"].instanceId");
				resultItem.State = context.StringValue("ListDiagnoseReport.Result["+ i +"].state");
				resultItem.Trigger = context.StringValue("ListDiagnoseReport.Result["+ i +"].trigger");
				resultItem.Health = context.StringValue("ListDiagnoseReport.Result["+ i +"].health");
				resultItem.CreateTime = context.LongValue("ListDiagnoseReport.Result["+ i +"].createTime");

				List<ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem.ListDiagnoseReport_DiagnoseItemsItem> resultItem_diagnoseItems = new List<ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem.ListDiagnoseReport_DiagnoseItemsItem>();
				for (int j = 0; j < context.Length("ListDiagnoseReport.Result["+ i +"].DiagnoseItems.Length"); j++) {
					ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem.ListDiagnoseReport_DiagnoseItemsItem diagnoseItemsItem = new ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem.ListDiagnoseReport_DiagnoseItemsItem();
					diagnoseItemsItem.Item = context.StringValue("ListDiagnoseReport.Result["+ i +"].DiagnoseItems["+ j +"].item");
					diagnoseItemsItem.Health = context.StringValue("ListDiagnoseReport.Result["+ i +"].DiagnoseItems["+ j +"].health");

					ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem.ListDiagnoseReport_DiagnoseItemsItem.ListDiagnoseReport_Detail detail = new ListDiagnoseReportResponse.ListDiagnoseReport_ResultItem.ListDiagnoseReport_DiagnoseItemsItem.ListDiagnoseReport_Detail();
					detail.Name = context.StringValue("ListDiagnoseReport.Result["+ i +"].DiagnoseItems["+ j +"].Detail.name");
					detail.Desc = context.StringValue("ListDiagnoseReport.Result["+ i +"].DiagnoseItems["+ j +"].Detail.desc");
					detail.Type = context.StringValue("ListDiagnoseReport.Result["+ i +"].DiagnoseItems["+ j +"].Detail.type");
					detail.Suggest = context.StringValue("ListDiagnoseReport.Result["+ i +"].DiagnoseItems["+ j +"].Detail.suggest");
					detail.Result = context.StringValue("ListDiagnoseReport.Result["+ i +"].DiagnoseItems["+ j +"].Detail.result");
					diagnoseItemsItem.Detail = detail;

					resultItem_diagnoseItems.Add(diagnoseItemsItem);
				}
				resultItem.DiagnoseItems = resultItem_diagnoseItems;

				listDiagnoseReportResponse_result.Add(resultItem);
			}
			listDiagnoseReportResponse.Result = listDiagnoseReportResponse_result;
        
			return listDiagnoseReportResponse;
        }
    }
}
