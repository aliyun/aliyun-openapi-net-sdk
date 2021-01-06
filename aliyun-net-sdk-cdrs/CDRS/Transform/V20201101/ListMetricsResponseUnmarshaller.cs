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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListMetricsResponseUnmarshaller
    {
        public static ListMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMetricsResponse listMetricsResponse = new ListMetricsResponse();

			listMetricsResponse.HttpResponse = _ctx.HttpResponse;
			listMetricsResponse.Code = _ctx.StringValue("ListMetrics.Code");
			listMetricsResponse.Message = _ctx.StringValue("ListMetrics.Message");
			listMetricsResponse.RequestId = _ctx.StringValue("ListMetrics.RequestId");
			listMetricsResponse.PageNumber = _ctx.StringValue("ListMetrics.PageNumber");
			listMetricsResponse.PageSize = _ctx.StringValue("ListMetrics.PageSize");
			listMetricsResponse.TotalCount = _ctx.StringValue("ListMetrics.TotalCount");

			List<ListMetricsResponse.ListMetrics_DataItem> listMetricsResponse_data = new List<ListMetricsResponse.ListMetrics_DataItem>();
			for (int i = 0; i < _ctx.Length("ListMetrics.Data.Length"); i++) {
				ListMetricsResponse.ListMetrics_DataItem dataItem = new ListMetricsResponse.ListMetrics_DataItem();
				dataItem.DateTime = _ctx.StringValue("ListMetrics.Data["+ i +"].DateTime");
				dataItem.TagCode = _ctx.StringValue("ListMetrics.Data["+ i +"].TagCode");
				dataItem.TagValue = _ctx.StringValue("ListMetrics.Data["+ i +"].TagValue");
				dataItem.DateTime1 = _ctx.StringValue("ListMetrics.Data["+ i +"].DateTime");

				listMetricsResponse_data.Add(dataItem);
			}
			listMetricsResponse.Data = listMetricsResponse_data;
        
			return listMetricsResponse;
        }
    }
}
