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
    public class ListDashboardMetricsFlowsResponseUnmarshaller
    {
        public static ListDashboardMetricsFlowsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDashboardMetricsFlowsResponse listDashboardMetricsFlowsResponse = new ListDashboardMetricsFlowsResponse();

			listDashboardMetricsFlowsResponse.HttpResponse = _ctx.HttpResponse;
			listDashboardMetricsFlowsResponse.RequestId = _ctx.StringValue("ListDashboardMetricsFlows.requestId");
			listDashboardMetricsFlowsResponse.Code = _ctx.StringValue("ListDashboardMetricsFlows.code");
			listDashboardMetricsFlowsResponse.Message = _ctx.StringValue("ListDashboardMetricsFlows.message");

			List<ListDashboardMetricsFlowsResponse.ListDashboardMetricsFlows_ResultItem> listDashboardMetricsFlowsResponse_result = new List<ListDashboardMetricsFlowsResponse.ListDashboardMetricsFlows_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDashboardMetricsFlows.Result.Length"); i++) {
				ListDashboardMetricsFlowsResponse.ListDashboardMetricsFlows_ResultItem resultItem = new ListDashboardMetricsFlowsResponse.ListDashboardMetricsFlows_ResultItem();
				resultItem.MetricData = _ctx.StringValue("ListDashboardMetricsFlows.Result["+ i +"].metricData");
				resultItem.MetricType = _ctx.StringValue("ListDashboardMetricsFlows.Result["+ i +"].metricType");

				listDashboardMetricsFlowsResponse_result.Add(resultItem);
			}
			listDashboardMetricsFlowsResponse.Result = listDashboardMetricsFlowsResponse_result;
        
			return listDashboardMetricsFlowsResponse;
        }
    }
}
