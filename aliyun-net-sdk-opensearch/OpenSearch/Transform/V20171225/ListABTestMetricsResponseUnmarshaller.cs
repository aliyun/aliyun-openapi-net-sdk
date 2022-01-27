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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ListABTestMetricsResponseUnmarshaller
    {
        public static ListABTestMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListABTestMetricsResponse listABTestMetricsResponse = new ListABTestMetricsResponse();

			listABTestMetricsResponse.HttpResponse = _ctx.HttpResponse;
			listABTestMetricsResponse.RequestId = _ctx.StringValue("ListABTestMetrics.requestId");

			List<ListABTestMetricsResponse.ListABTestMetrics_ResultItem> listABTestMetricsResponse_result = new List<ListABTestMetricsResponse.ListABTestMetrics_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListABTestMetrics.Result.Length"); i++) {
				ListABTestMetricsResponse.ListABTestMetrics_ResultItem resultItem = new ListABTestMetricsResponse.ListABTestMetrics_ResultItem();
				resultItem.ExperimentName = _ctx.StringValue("ListABTestMetrics.Result["+ i +"].experimentName");
				resultItem.Date = _ctx.StringValue("ListABTestMetrics.Result["+ i +"].date");
				resultItem.Pv = _ctx.IntegerValue("ListABTestMetrics.Result["+ i +"].pv");
				resultItem.Ipv = _ctx.IntegerValue("ListABTestMetrics.Result["+ i +"].ipv");
				resultItem.Uv = _ctx.IntegerValue("ListABTestMetrics.Result["+ i +"].uv");
				resultItem.IpvUv = _ctx.IntegerValue("ListABTestMetrics.Result["+ i +"].ipvUv");
				resultItem.Ctr = _ctx.FloatValue("ListABTestMetrics.Result["+ i +"].ctr");
				resultItem.ZeroHitRate = _ctx.FloatValue("ListABTestMetrics.Result["+ i +"].zeroHitRate");

				listABTestMetricsResponse_result.Add(resultItem);
			}
			listABTestMetricsResponse.Result = listABTestMetricsResponse_result;
        
			return listABTestMetricsResponse;
        }
    }
}
