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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribePlaybookMetricsResponseUnmarshaller
    {
        public static DescribePlaybookMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlaybookMetricsResponse describePlaybookMetricsResponse = new DescribePlaybookMetricsResponse();

			describePlaybookMetricsResponse.HttpResponse = _ctx.HttpResponse;
			describePlaybookMetricsResponse.RequestId = _ctx.StringValue("DescribePlaybookMetrics.RequestId");

			DescribePlaybookMetricsResponse.DescribePlaybookMetrics_Metrics metrics = new DescribePlaybookMetricsResponse.DescribePlaybookMetrics_Metrics();
			metrics.DisplayName = _ctx.StringValue("DescribePlaybookMetrics.Metrics.DisplayName");
			metrics.PlaybookUuid = _ctx.StringValue("DescribePlaybookMetrics.Metrics.PlaybookUuid");
			metrics.OwnType = _ctx.StringValue("DescribePlaybookMetrics.Metrics.OwnType");
			metrics.Active = _ctx.IntegerValue("DescribePlaybookMetrics.Metrics.Active");
			metrics.LastRuntime = _ctx.LongValue("DescribePlaybookMetrics.Metrics.LastRuntime");
			metrics.Permission = _ctx.IntegerValue("DescribePlaybookMetrics.Metrics.Permission");
			metrics.GmtCreate = _ctx.LongValue("DescribePlaybookMetrics.Metrics.GmtCreate");
			metrics.HistoryMd5 = _ctx.IntegerValue("DescribePlaybookMetrics.Metrics.HistoryMd5");
			metrics.SuccNum = _ctx.IntegerValue("DescribePlaybookMetrics.Metrics.SuccNum");
			metrics.FailNum = _ctx.IntegerValue("DescribePlaybookMetrics.Metrics.FailNum");
			metrics.FailRate = _ctx.DoubleValue("DescribePlaybookMetrics.Metrics.FailRate");
			metrics.PlaybookStatus = _ctx.IntegerValue("DescribePlaybookMetrics.Metrics.PlaybookStatus");
			metrics.Description = _ctx.StringValue("DescribePlaybookMetrics.Metrics.Description");
			describePlaybookMetricsResponse.Metrics = metrics;
        
			return describePlaybookMetricsResponse;
        }
    }
}
