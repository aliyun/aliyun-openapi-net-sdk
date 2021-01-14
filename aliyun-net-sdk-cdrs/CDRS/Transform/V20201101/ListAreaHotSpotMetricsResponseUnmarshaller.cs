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
    public class ListAreaHotSpotMetricsResponseUnmarshaller
    {
        public static ListAreaHotSpotMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAreaHotSpotMetricsResponse listAreaHotSpotMetricsResponse = new ListAreaHotSpotMetricsResponse();

			listAreaHotSpotMetricsResponse.HttpResponse = _ctx.HttpResponse;
			listAreaHotSpotMetricsResponse.Code = _ctx.StringValue("ListAreaHotSpotMetrics.Code");
			listAreaHotSpotMetricsResponse.Message = _ctx.StringValue("ListAreaHotSpotMetrics.Message");
			listAreaHotSpotMetricsResponse.RequestId = _ctx.StringValue("ListAreaHotSpotMetrics.RequestId");
			listAreaHotSpotMetricsResponse.PageNumber = _ctx.StringValue("ListAreaHotSpotMetrics.PageNumber");
			listAreaHotSpotMetricsResponse.PageSize = _ctx.StringValue("ListAreaHotSpotMetrics.PageSize");
			listAreaHotSpotMetricsResponse.TotalCount = _ctx.StringValue("ListAreaHotSpotMetrics.TotalCount");

			List<ListAreaHotSpotMetricsResponse.ListAreaHotSpotMetrics_DataItem> listAreaHotSpotMetricsResponse_data = new List<ListAreaHotSpotMetricsResponse.ListAreaHotSpotMetrics_DataItem>();
			for (int i = 0; i < _ctx.Length("ListAreaHotSpotMetrics.Data.Length"); i++) {
				ListAreaHotSpotMetricsResponse.ListAreaHotSpotMetrics_DataItem dataItem = new ListAreaHotSpotMetricsResponse.ListAreaHotSpotMetrics_DataItem();
				dataItem.Times = _ctx.StringValue("ListAreaHotSpotMetrics.Data["+ i +"].Times");
				dataItem.Coordinates = _ctx.StringValue("ListAreaHotSpotMetrics.Data["+ i +"].Coordinates");
				dataItem.DeviceId = _ctx.StringValue("ListAreaHotSpotMetrics.Data["+ i +"].DeviceId");
				dataItem.PersonId = _ctx.StringValue("ListAreaHotSpotMetrics.Data["+ i +"].PersonId");
				dataItem.IntervalTime = _ctx.StringValue("ListAreaHotSpotMetrics.Data["+ i +"].IntervalTime");

				listAreaHotSpotMetricsResponse_data.Add(dataItem);
			}
			listAreaHotSpotMetricsResponse.Data = listAreaHotSpotMetricsResponse_data;
        
			return listAreaHotSpotMetricsResponse;
        }
    }
}
