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
    public class ListDashboardDetailsFlowsResponseUnmarshaller
    {
        public static ListDashboardDetailsFlowsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDashboardDetailsFlowsResponse listDashboardDetailsFlowsResponse = new ListDashboardDetailsFlowsResponse();

			listDashboardDetailsFlowsResponse.HttpResponse = _ctx.HttpResponse;
			listDashboardDetailsFlowsResponse.RequestId = _ctx.StringValue("ListDashboardDetailsFlows.requestId");
			listDashboardDetailsFlowsResponse.Code = _ctx.StringValue("ListDashboardDetailsFlows.code");
			listDashboardDetailsFlowsResponse.Message = _ctx.StringValue("ListDashboardDetailsFlows.message");

			ListDashboardDetailsFlowsResponse.ListDashboardDetailsFlows_Result result = new ListDashboardDetailsFlowsResponse.ListDashboardDetailsFlows_Result();
			result.MetricType = _ctx.StringValue("ListDashboardDetailsFlows.Result.metricType");

			List<ListDashboardDetailsFlowsResponse.ListDashboardDetailsFlows_Result.ListDashboardDetailsFlows_MetricDataItem> result_metricData = new List<ListDashboardDetailsFlowsResponse.ListDashboardDetailsFlows_Result.ListDashboardDetailsFlows_MetricDataItem>();
			for (int i = 0; i < _ctx.Length("ListDashboardDetailsFlows.Result.MetricData.Length"); i++) {
				ListDashboardDetailsFlowsResponse.ListDashboardDetailsFlows_Result.ListDashboardDetailsFlows_MetricDataItem metricDataItem = new ListDashboardDetailsFlowsResponse.ListDashboardDetailsFlows_Result.ListDashboardDetailsFlows_MetricDataItem();
				metricDataItem.MetricRes = _ctx.StringValue("ListDashboardDetailsFlows.Result.MetricData["+ i +"].metricRes");
				metricDataItem.SceneId = _ctx.StringValue("ListDashboardDetailsFlows.Result.MetricData["+ i +"].sceneId");
				metricDataItem.TraceId = _ctx.StringValue("ListDashboardDetailsFlows.Result.MetricData["+ i +"].traceId");

				result_metricData.Add(metricDataItem);
			}
			result.MetricData = result_metricData;
			listDashboardDetailsFlowsResponse.Result = result;
        
			return listDashboardDetailsFlowsResponse;
        }
    }
}
