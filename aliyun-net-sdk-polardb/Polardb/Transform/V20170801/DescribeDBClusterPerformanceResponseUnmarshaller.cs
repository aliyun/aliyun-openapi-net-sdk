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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterPerformanceResponseUnmarshaller
    {
        public static DescribeDBClusterPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterPerformanceResponse describeDBClusterPerformanceResponse = new DescribeDBClusterPerformanceResponse();

			describeDBClusterPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterPerformanceResponse.RequestId = _ctx.StringValue("DescribeDBClusterPerformance.RequestId");
			describeDBClusterPerformanceResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterPerformance.DBClusterId");
			describeDBClusterPerformanceResponse.Engine = _ctx.StringValue("DescribeDBClusterPerformance.Engine");
			describeDBClusterPerformanceResponse.DBType = _ctx.StringValue("DescribeDBClusterPerformance.DBType");
			describeDBClusterPerformanceResponse.DBVersion = _ctx.StringValue("DescribeDBClusterPerformance.DBVersion");
			describeDBClusterPerformanceResponse.StartTime = _ctx.StringValue("DescribeDBClusterPerformance.StartTime");
			describeDBClusterPerformanceResponse.EndTime = _ctx.StringValue("DescribeDBClusterPerformance.EndTime");

			List<DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem> describeDBClusterPerformanceResponse_performanceKeys = new List<DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterPerformance.PerformanceKeys.Length"); i++) {
				DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem performanceItem = new DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem();
				performanceItem.DBNodeId = _ctx.StringValue("DescribeDBClusterPerformance.PerformanceKeys["+ i +"].DBNodeId");
				performanceItem.Measurement = _ctx.StringValue("DescribeDBClusterPerformance.PerformanceKeys["+ i +"].Measurement");
				performanceItem.MetricName = _ctx.StringValue("DescribeDBClusterPerformance.PerformanceKeys["+ i +"].MetricName");

				List<DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem.DescribeDBClusterPerformance_PerformanceItemValue> performanceItem_points = new List<DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem.DescribeDBClusterPerformance_PerformanceItemValue>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusterPerformance.PerformanceKeys["+ i +"].Points.Length"); j++) {
					DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem.DescribeDBClusterPerformance_PerformanceItemValue performanceItemValue = new DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem.DescribeDBClusterPerformance_PerformanceItemValue();
					performanceItemValue._Value = _ctx.StringValue("DescribeDBClusterPerformance.PerformanceKeys["+ i +"].Points["+ j +"].Value");
					performanceItemValue.Timestamp = _ctx.LongValue("DescribeDBClusterPerformance.PerformanceKeys["+ i +"].Points["+ j +"].Timestamp");

					performanceItem_points.Add(performanceItemValue);
				}
				performanceItem.Points = performanceItem_points;

				describeDBClusterPerformanceResponse_performanceKeys.Add(performanceItem);
			}
			describeDBClusterPerformanceResponse.PerformanceKeys = describeDBClusterPerformanceResponse_performanceKeys;
        
			return describeDBClusterPerformanceResponse;
        }
    }
}
