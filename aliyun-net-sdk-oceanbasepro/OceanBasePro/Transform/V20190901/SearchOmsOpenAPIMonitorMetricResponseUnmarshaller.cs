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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class SearchOmsOpenAPIMonitorMetricResponseUnmarshaller
    {
        public static SearchOmsOpenAPIMonitorMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchOmsOpenAPIMonitorMetricResponse searchOmsOpenAPIMonitorMetricResponse = new SearchOmsOpenAPIMonitorMetricResponse();

			searchOmsOpenAPIMonitorMetricResponse.HttpResponse = _ctx.HttpResponse;
			searchOmsOpenAPIMonitorMetricResponse.Success = _ctx.BooleanValue("SearchOmsOpenAPIMonitorMetric.Success");
			searchOmsOpenAPIMonitorMetricResponse.Code = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.Code");
			searchOmsOpenAPIMonitorMetricResponse.Message = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.Message");
			searchOmsOpenAPIMonitorMetricResponse.Advice = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.Advice");
			searchOmsOpenAPIMonitorMetricResponse.RequestId = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.RequestId");
			searchOmsOpenAPIMonitorMetricResponse.PageNumber = _ctx.IntegerValue("SearchOmsOpenAPIMonitorMetric.PageNumber");
			searchOmsOpenAPIMonitorMetricResponse.PageSize = _ctx.IntegerValue("SearchOmsOpenAPIMonitorMetric.PageSize");
			searchOmsOpenAPIMonitorMetricResponse.TotalCount = _ctx.LongValue("SearchOmsOpenAPIMonitorMetric.TotalCount");
			searchOmsOpenAPIMonitorMetricResponse.Cost = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.Cost");

			SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_ErrorDetail errorDetail = new SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_ErrorDetail();
			errorDetail.Code = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.ErrorDetail.Code");
			errorDetail.Level = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.ErrorDetail.Level");
			errorDetail.Message = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.ErrorDetail.Message");
			errorDetail.Proposal = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.ErrorDetail.Proposal");
			searchOmsOpenAPIMonitorMetricResponse.ErrorDetail = errorDetail;

			List<SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_DataItem> searchOmsOpenAPIMonitorMetricResponse_data = new List<SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_DataItem>();
			for (int i = 0; i < _ctx.Length("SearchOmsOpenAPIMonitorMetric.Data.Length"); i++) {
				SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_DataItem dataItem = new SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_DataItem();
				dataItem.Metric = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.Data["+ i +"].Metric");
				dataItem.Tags = _ctx.StringValue("SearchOmsOpenAPIMonitorMetric.Data["+ i +"].Tags");

				List<SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_DataItem.SearchOmsOpenAPIMonitorMetric_DataPoint> dataItem_dataPoints = new List<SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_DataItem.SearchOmsOpenAPIMonitorMetric_DataPoint>();
				for (int j = 0; j < _ctx.Length("SearchOmsOpenAPIMonitorMetric.Data["+ i +"].DataPoints.Length"); j++) {
					SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_DataItem.SearchOmsOpenAPIMonitorMetric_DataPoint dataPoint = new SearchOmsOpenAPIMonitorMetricResponse.SearchOmsOpenAPIMonitorMetric_DataItem.SearchOmsOpenAPIMonitorMetric_DataPoint();
					dataPoint.Timestamp = _ctx.LongValue("SearchOmsOpenAPIMonitorMetric.Data["+ i +"].DataPoints["+ j +"].Timestamp");
					dataPoint._Value = _ctx.DoubleValue("SearchOmsOpenAPIMonitorMetric.Data["+ i +"].DataPoints["+ j +"].Value");

					dataItem_dataPoints.Add(dataPoint);
				}
				dataItem.DataPoints = dataItem_dataPoints;

				searchOmsOpenAPIMonitorMetricResponse_data.Add(dataItem);
			}
			searchOmsOpenAPIMonitorMetricResponse.Data = searchOmsOpenAPIMonitorMetricResponse_data;
        
			return searchOmsOpenAPIMonitorMetricResponse;
        }
    }
}
