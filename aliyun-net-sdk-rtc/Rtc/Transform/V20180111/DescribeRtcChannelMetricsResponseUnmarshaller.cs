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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRtcChannelMetricsResponseUnmarshaller
    {
        public static DescribeRtcChannelMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcChannelMetricsResponse describeRtcChannelMetricsResponse = new DescribeRtcChannelMetricsResponse();

			describeRtcChannelMetricsResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcChannelMetricsResponse.RequestId = _ctx.StringValue("DescribeRtcChannelMetrics.RequestId");

			List<DescribeRtcChannelMetricsResponse.DescribeRtcChannelMetrics_Metric> describeRtcChannelMetricsResponse_metrics = new List<DescribeRtcChannelMetricsResponse.DescribeRtcChannelMetrics_Metric>();
			for (int i = 0; i < _ctx.Length("DescribeRtcChannelMetrics.Metrics.Length"); i++) {
				DescribeRtcChannelMetricsResponse.DescribeRtcChannelMetrics_Metric metric = new DescribeRtcChannelMetricsResponse.DescribeRtcChannelMetrics_Metric();
				metric.Uid = _ctx.StringValue("DescribeRtcChannelMetrics.Metrics["+ i +"].Uid");
				metric.Mid = _ctx.StringValue("DescribeRtcChannelMetrics.Metrics["+ i +"].Mid");

				List<string> metric_kVs = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRtcChannelMetrics.Metrics["+ i +"].KVs.Length"); j++) {
					metric_kVs.Add(_ctx.StringValue("DescribeRtcChannelMetrics.Metrics["+ i +"].KVs["+ j +"]"));
				}
				metric.KVs = metric_kVs;

				describeRtcChannelMetricsResponse_metrics.Add(metric);
			}
			describeRtcChannelMetricsResponse.Metrics = describeRtcChannelMetricsResponse_metrics;
        
			return describeRtcChannelMetricsResponse;
        }
    }
}
