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
    public class DescribeDBInstanceMetricsResponseUnmarshaller
    {
        public static DescribeDBInstanceMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceMetricsResponse describeDBInstanceMetricsResponse = new DescribeDBInstanceMetricsResponse();

			describeDBInstanceMetricsResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceMetricsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDBInstanceMetrics.TotalRecordCount");
			describeDBInstanceMetricsResponse.RequestId = _ctx.StringValue("DescribeDBInstanceMetrics.RequestId");
			describeDBInstanceMetricsResponse.DBInstanceName = _ctx.StringValue("DescribeDBInstanceMetrics.DBInstanceName");

			List<DescribeDBInstanceMetricsResponse.DescribeDBInstanceMetrics_Metrics> describeDBInstanceMetricsResponse_items = new List<DescribeDBInstanceMetricsResponse.DescribeDBInstanceMetrics_Metrics>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceMetrics.Items.Length"); i++) {
				DescribeDBInstanceMetricsResponse.DescribeDBInstanceMetrics_Metrics metrics = new DescribeDBInstanceMetricsResponse.DescribeDBInstanceMetrics_Metrics();
				metrics.GroupKey = _ctx.StringValue("DescribeDBInstanceMetrics.Items["+ i +"].GroupKey");
				metrics.SortRule = _ctx.IntegerValue("DescribeDBInstanceMetrics.Items["+ i +"].SortRule");
				metrics.Description = _ctx.StringValue("DescribeDBInstanceMetrics.Items["+ i +"].Description");
				metrics.Unit = _ctx.StringValue("DescribeDBInstanceMetrics.Items["+ i +"].Unit");
				metrics.DbType = _ctx.StringValue("DescribeDBInstanceMetrics.Items["+ i +"].DbType");
				metrics.MetricsKey = _ctx.StringValue("DescribeDBInstanceMetrics.Items["+ i +"].MetricsKey");
				metrics.GroupKeyType = _ctx.StringValue("DescribeDBInstanceMetrics.Items["+ i +"].GroupKeyType");
				metrics.Method = _ctx.StringValue("DescribeDBInstanceMetrics.Items["+ i +"].Method");
				metrics.Dimension = _ctx.StringValue("DescribeDBInstanceMetrics.Items["+ i +"].Dimension");
				metrics.MetricsKeyAlias = _ctx.StringValue("DescribeDBInstanceMetrics.Items["+ i +"].MetricsKeyAlias");

				describeDBInstanceMetricsResponse_items.Add(metrics);
			}
			describeDBInstanceMetricsResponse.Items = describeDBInstanceMetricsResponse_items;
        
			return describeDBInstanceMetricsResponse;
        }
    }
}
