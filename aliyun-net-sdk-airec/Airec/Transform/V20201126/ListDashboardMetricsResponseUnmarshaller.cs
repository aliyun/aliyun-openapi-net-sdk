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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListDashboardMetricsResponseUnmarshaller
    {
        public static ListDashboardMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDashboardMetricsResponse listDashboardMetricsResponse = new ListDashboardMetricsResponse();

			listDashboardMetricsResponse.HttpResponse = _ctx.HttpResponse;
			listDashboardMetricsResponse.RequestId = _ctx.StringValue("ListDashboardMetrics.requestId");
			listDashboardMetricsResponse.Code = _ctx.StringValue("ListDashboardMetrics.code");
			listDashboardMetricsResponse.Message = _ctx.StringValue("ListDashboardMetrics.message");

			List<ListDashboardMetricsResponse.ListDashboardMetrics_ResultItem> listDashboardMetricsResponse_result = new List<ListDashboardMetricsResponse.ListDashboardMetrics_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDashboardMetrics.Result.Length"); i++) {
				ListDashboardMetricsResponse.ListDashboardMetrics_ResultItem resultItem = new ListDashboardMetricsResponse.ListDashboardMetrics_ResultItem();
				resultItem.Total = _ctx.StringValue("ListDashboardMetrics.Result["+ i +"].total");

				List<ListDashboardMetricsResponse.ListDashboardMetrics_ResultItem.ListDashboardMetrics_DetailItem> resultItem_detail = new List<ListDashboardMetricsResponse.ListDashboardMetrics_ResultItem.ListDashboardMetrics_DetailItem>();
				for (int j = 0; j < _ctx.Length("ListDashboardMetrics.Result["+ i +"].Detail.Length"); j++) {
					ListDashboardMetricsResponse.ListDashboardMetrics_ResultItem.ListDashboardMetrics_DetailItem detailItem = new ListDashboardMetricsResponse.ListDashboardMetrics_ResultItem.ListDashboardMetrics_DetailItem();
					detailItem.EndTime = _ctx.StringValue("ListDashboardMetrics.Result["+ i +"].Detail["+ j +"].endTime");
					detailItem.StartTime = _ctx.StringValue("ListDashboardMetrics.Result["+ i +"].Detail["+ j +"].startTime");
					detailItem.Val = _ctx.StringValue("ListDashboardMetrics.Result["+ i +"].Detail["+ j +"].val");

					resultItem_detail.Add(detailItem);
				}
				resultItem.Detail = resultItem_detail;

				listDashboardMetricsResponse_result.Add(resultItem);
			}
			listDashboardMetricsResponse.Result = listDashboardMetricsResponse_result;
        
			return listDashboardMetricsResponse;
        }
    }
}
