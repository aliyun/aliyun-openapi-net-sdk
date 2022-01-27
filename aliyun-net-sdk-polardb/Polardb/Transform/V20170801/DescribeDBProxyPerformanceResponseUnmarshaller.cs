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
    public class DescribeDBProxyPerformanceResponseUnmarshaller
    {
        public static DescribeDBProxyPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBProxyPerformanceResponse describeDBProxyPerformanceResponse = new DescribeDBProxyPerformanceResponse();

			describeDBProxyPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDBProxyPerformanceResponse.DBVersion = _ctx.StringValue("DescribeDBProxyPerformance.DBVersion");
			describeDBProxyPerformanceResponse.EndTime = _ctx.StringValue("DescribeDBProxyPerformance.EndTime");
			describeDBProxyPerformanceResponse.RequestId = _ctx.StringValue("DescribeDBProxyPerformance.RequestId");
			describeDBProxyPerformanceResponse.StartTime = _ctx.StringValue("DescribeDBProxyPerformance.StartTime");
			describeDBProxyPerformanceResponse.DBClusterId = _ctx.StringValue("DescribeDBProxyPerformance.DBClusterId");
			describeDBProxyPerformanceResponse.DBType = _ctx.StringValue("DescribeDBProxyPerformance.DBType");
			describeDBProxyPerformanceResponse.Engine = _ctx.StringValue("DescribeDBProxyPerformance.Engine");

			List<DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceItem> describeDBProxyPerformanceResponse_performanceKeys = new List<DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBProxyPerformance.PerformanceKeys.Length"); i++) {
				DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceItem performanceItem = new DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceItem();
				performanceItem.MetricName = _ctx.StringValue("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].MetricName");
				performanceItem.Measurement = _ctx.StringValue("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].Measurement");
				performanceItem.DBNodeId = _ctx.StringValue("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].DBNodeId");

				List<DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceItem.DescribeDBProxyPerformance_PerformanceItemValue> performanceItem_points = new List<DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceItem.DescribeDBProxyPerformance_PerformanceItemValue>();
				for (int j = 0; j < _ctx.Length("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].Points.Length"); j++) {
					DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceItem.DescribeDBProxyPerformance_PerformanceItemValue performanceItemValue = new DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceItem.DescribeDBProxyPerformance_PerformanceItemValue();
					performanceItemValue._Value = _ctx.StringValue("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].Points["+ j +"].Value");
					performanceItemValue.Timestamp = _ctx.LongValue("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].Points["+ j +"].Timestamp");

					performanceItem_points.Add(performanceItemValue);
				}
				performanceItem.Points = performanceItem_points;

				describeDBProxyPerformanceResponse_performanceKeys.Add(performanceItem);
			}
			describeDBProxyPerformanceResponse.PerformanceKeys = describeDBProxyPerformanceResponse_performanceKeys;
        
			return describeDBProxyPerformanceResponse;
        }
    }
}
