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
    public class ListTagMetricsResponseUnmarshaller
    {
        public static ListTagMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagMetricsResponse listTagMetricsResponse = new ListTagMetricsResponse();

			listTagMetricsResponse.HttpResponse = _ctx.HttpResponse;
			listTagMetricsResponse.Code = _ctx.StringValue("ListTagMetrics.Code");
			listTagMetricsResponse.Message = _ctx.StringValue("ListTagMetrics.Message");
			listTagMetricsResponse.RequestId = _ctx.StringValue("ListTagMetrics.RequestId");
			listTagMetricsResponse.PageNumber = _ctx.StringValue("ListTagMetrics.PageNumber");
			listTagMetricsResponse.PageSize = _ctx.StringValue("ListTagMetrics.PageSize");
			listTagMetricsResponse.TotalCount = _ctx.StringValue("ListTagMetrics.TotalCount");

			List<ListTagMetricsResponse.ListTagMetrics_DataItem> listTagMetricsResponse_data = new List<ListTagMetricsResponse.ListTagMetrics_DataItem>();
			for (int i = 0; i < _ctx.Length("ListTagMetrics.Data.Length"); i++) {
				ListTagMetricsResponse.ListTagMetrics_DataItem dataItem = new ListTagMetricsResponse.ListTagMetrics_DataItem();
				dataItem.DateTime = _ctx.StringValue("ListTagMetrics.Data["+ i +"].DateTime");
				dataItem.TagCode = _ctx.StringValue("ListTagMetrics.Data["+ i +"].TagCode");
				dataItem.TagValue = _ctx.StringValue("ListTagMetrics.Data["+ i +"].TagValue");
				dataItem.TagMetric = _ctx.StringValue("ListTagMetrics.Data["+ i +"].TagMetric");
				dataItem.CorpId = _ctx.StringValue("ListTagMetrics.Data["+ i +"].CorpId");

				listTagMetricsResponse_data.Add(dataItem);
			}
			listTagMetricsResponse.Data = listTagMetricsResponse_data;
        
			return listTagMetricsResponse;
        }
    }
}
