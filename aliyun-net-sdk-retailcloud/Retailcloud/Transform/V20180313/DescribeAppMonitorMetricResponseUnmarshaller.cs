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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeAppMonitorMetricResponseUnmarshaller
    {
        public static DescribeAppMonitorMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppMonitorMetricResponse describeAppMonitorMetricResponse = new DescribeAppMonitorMetricResponse();

			describeAppMonitorMetricResponse.HttpResponse = _ctx.HttpResponse;
			describeAppMonitorMetricResponse.Code = _ctx.IntegerValue("DescribeAppMonitorMetric.Code");
			describeAppMonitorMetricResponse.ErrMsg = _ctx.StringValue("DescribeAppMonitorMetric.ErrMsg");
			describeAppMonitorMetricResponse.RequestId = _ctx.StringValue("DescribeAppMonitorMetric.RequestId");
			describeAppMonitorMetricResponse.Success = _ctx.BooleanValue("DescribeAppMonitorMetric.Success");

			List<DescribeAppMonitorMetricResponse.DescribeAppMonitorMetric_MetricItem> describeAppMonitorMetricResponse_result = new List<DescribeAppMonitorMetricResponse.DescribeAppMonitorMetric_MetricItem>();
			for (int i = 0; i < _ctx.Length("DescribeAppMonitorMetric.Result.Length"); i++) {
				DescribeAppMonitorMetricResponse.DescribeAppMonitorMetric_MetricItem metricItem = new DescribeAppMonitorMetricResponse.DescribeAppMonitorMetric_MetricItem();
				metricItem.Name = _ctx.StringValue("DescribeAppMonitorMetric.Result["+ i +"].Name");

				List<string> metricItem_data = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAppMonitorMetric.Result["+ i +"].Data.Length"); j++) {
					metricItem_data.Add(_ctx.StringValue("DescribeAppMonitorMetric.Result["+ i +"].Data["+ j +"]"));
				}
				metricItem.Data = metricItem_data;

				List<string> metricItem_categories = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAppMonitorMetric.Result["+ i +"].Categories.Length"); j++) {
					metricItem_categories.Add(_ctx.StringValue("DescribeAppMonitorMetric.Result["+ i +"].Categories["+ j +"]"));
				}
				metricItem.Categories = metricItem_categories;

				describeAppMonitorMetricResponse_result.Add(metricItem);
			}
			describeAppMonitorMetricResponse.Result = describeAppMonitorMetricResponse_result;
        
			return describeAppMonitorMetricResponse;
        }
    }
}
