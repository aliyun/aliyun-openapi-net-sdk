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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class GetClusterMetricsResponseUnmarshaller
    {
        public static GetClusterMetricsResponse Unmarshall(UnmarshallerContext context)
        {
			GetClusterMetricsResponse getClusterMetricsResponse = new GetClusterMetricsResponse();

			getClusterMetricsResponse.HttpResponse = context.HttpResponse;
			getClusterMetricsResponse.RequestId = context.StringValue("GetClusterMetrics.RequestId");

			List<GetClusterMetricsResponse.GetClusterMetrics_Metric> getClusterMetricsResponse_metrics = new List<GetClusterMetricsResponse.GetClusterMetrics_Metric>();
			for (int i = 0; i < context.Length("GetClusterMetrics.Metrics.Length"); i++) {
				GetClusterMetricsResponse.GetClusterMetrics_Metric metric = new GetClusterMetricsResponse.GetClusterMetrics_Metric();
				metric.MetricName = context.StringValue("GetClusterMetrics.Metrics["+ i +"].MetricName");
				metric.Dps = context.StringValue("GetClusterMetrics.Metrics["+ i +"].Dps");
				metric.Summary = context.FloatValue("GetClusterMetrics.Metrics["+ i +"].Summary");
				metric.Tags = context.StringValue("GetClusterMetrics.Metrics["+ i +"].Tags");

				getClusterMetricsResponse_metrics.Add(metric);
			}
			getClusterMetricsResponse.Metrics = getClusterMetricsResponse_metrics;
        
			return getClusterMetricsResponse;
        }
    }
}
