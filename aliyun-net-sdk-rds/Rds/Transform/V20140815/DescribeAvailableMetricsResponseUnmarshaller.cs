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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeAvailableMetricsResponseUnmarshaller
    {
        public static DescribeAvailableMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableMetricsResponse describeAvailableMetricsResponse = new DescribeAvailableMetricsResponse();

			describeAvailableMetricsResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableMetricsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeAvailableMetrics.TotalRecordCount");
			describeAvailableMetricsResponse.RequestId = _ctx.StringValue("DescribeAvailableMetrics.RequestId");
			describeAvailableMetricsResponse.DBInstanceName = _ctx.StringValue("DescribeAvailableMetrics.DBInstanceName");

			List<DescribeAvailableMetricsResponse.DescribeAvailableMetrics_Metrics> describeAvailableMetricsResponse_items = new List<DescribeAvailableMetricsResponse.DescribeAvailableMetrics_Metrics>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableMetrics.Items.Length"); i++) {
				DescribeAvailableMetricsResponse.DescribeAvailableMetrics_Metrics metrics = new DescribeAvailableMetricsResponse.DescribeAvailableMetrics_Metrics();
				metrics.GroupKey = _ctx.StringValue("DescribeAvailableMetrics.Items["+ i +"].GroupKey");
				metrics.SortRule = _ctx.IntegerValue("DescribeAvailableMetrics.Items["+ i +"].SortRule");
				metrics.Description = _ctx.StringValue("DescribeAvailableMetrics.Items["+ i +"].Description");
				metrics.Unit = _ctx.StringValue("DescribeAvailableMetrics.Items["+ i +"].Unit");
				metrics.DbType = _ctx.StringValue("DescribeAvailableMetrics.Items["+ i +"].DbType");
				metrics.MetricsKey = _ctx.StringValue("DescribeAvailableMetrics.Items["+ i +"].MetricsKey");
				metrics.GroupKeyType = _ctx.StringValue("DescribeAvailableMetrics.Items["+ i +"].GroupKeyType");
				metrics.MetricsKeyAlias = _ctx.StringValue("DescribeAvailableMetrics.Items["+ i +"].MetricsKeyAlias");
				metrics.Method = _ctx.StringValue("DescribeAvailableMetrics.Items["+ i +"].Method");
				metrics.Dimension = _ctx.StringValue("DescribeAvailableMetrics.Items["+ i +"].Dimension");

				describeAvailableMetricsResponse_items.Add(metrics);
			}
			describeAvailableMetricsResponse.Items = describeAvailableMetricsResponse_items;
        
			return describeAvailableMetricsResponse;
        }
    }
}
