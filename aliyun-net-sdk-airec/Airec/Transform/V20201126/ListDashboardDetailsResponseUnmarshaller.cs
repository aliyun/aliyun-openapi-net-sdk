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
    public class ListDashboardDetailsResponseUnmarshaller
    {
        public static ListDashboardDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDashboardDetailsResponse listDashboardDetailsResponse = new ListDashboardDetailsResponse();

			listDashboardDetailsResponse.HttpResponse = _ctx.HttpResponse;
			listDashboardDetailsResponse.RequestId = _ctx.StringValue("ListDashboardDetails.requestId");
			listDashboardDetailsResponse.Code = _ctx.StringValue("ListDashboardDetails.code");
			listDashboardDetailsResponse.Message = _ctx.StringValue("ListDashboardDetails.message");

			List<ListDashboardDetailsResponse.ListDashboardDetails_ResultItem> listDashboardDetailsResponse_result = new List<ListDashboardDetailsResponse.ListDashboardDetails_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDashboardDetails.Result.Length"); i++) {
				ListDashboardDetailsResponse.ListDashboardDetails_ResultItem resultItem = new ListDashboardDetailsResponse.ListDashboardDetails_ResultItem();
				resultItem.SceneId = _ctx.StringValue("ListDashboardDetails.Result["+ i +"].sceneId");
				resultItem.TraceId = _ctx.StringValue("ListDashboardDetails.Result["+ i +"].traceId");

				ListDashboardDetailsResponse.ListDashboardDetails_ResultItem.ListDashboardDetails_MetricRes metricRes = new ListDashboardDetailsResponse.ListDashboardDetails_ResultItem.ListDashboardDetails_MetricRes();
				metricRes.Detail = _ctx.StringValue("ListDashboardDetails.Result["+ i +"].MetricRes.detail");
				metricRes.Total = _ctx.StringValue("ListDashboardDetails.Result["+ i +"].MetricRes.total");
				resultItem.MetricRes = metricRes;

				listDashboardDetailsResponse_result.Add(resultItem);
			}
			listDashboardDetailsResponse.Result = listDashboardDetailsResponse_result;
        
			return listDashboardDetailsResponse;
        }
    }
}
