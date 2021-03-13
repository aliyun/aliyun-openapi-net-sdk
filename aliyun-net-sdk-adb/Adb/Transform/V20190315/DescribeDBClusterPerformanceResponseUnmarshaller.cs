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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDBClusterPerformanceResponseUnmarshaller
    {
        public static DescribeDBClusterPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterPerformanceResponse describeDBClusterPerformanceResponse = new DescribeDBClusterPerformanceResponse();

			describeDBClusterPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterPerformanceResponse.RequestId = _ctx.StringValue("DescribeDBClusterPerformance.RequestId");
			describeDBClusterPerformanceResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterPerformance.DBClusterId");
			describeDBClusterPerformanceResponse.StartTime = _ctx.StringValue("DescribeDBClusterPerformance.StartTime");
			describeDBClusterPerformanceResponse.EndTime = _ctx.StringValue("DescribeDBClusterPerformance.EndTime");

			List<DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem> describeDBClusterPerformanceResponse_performances = new List<DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterPerformance.Performances.Length"); i++) {
				DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem performanceItem = new DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem();
				performanceItem.Key = _ctx.StringValue("DescribeDBClusterPerformance.Performances["+ i +"].Key");
				performanceItem.Unit = _ctx.StringValue("DescribeDBClusterPerformance.Performances["+ i +"].Unit");

				List<DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem.DescribeDBClusterPerformance_SeriesItem> performanceItem_series = new List<DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem.DescribeDBClusterPerformance_SeriesItem>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusterPerformance.Performances["+ i +"].Series.Length"); j++) {
					DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem.DescribeDBClusterPerformance_SeriesItem seriesItem = new DescribeDBClusterPerformanceResponse.DescribeDBClusterPerformance_PerformanceItem.DescribeDBClusterPerformance_SeriesItem();
					seriesItem.Name = _ctx.StringValue("DescribeDBClusterPerformance.Performances["+ i +"].Series["+ j +"].Name");

					List<string> seriesItem_values = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeDBClusterPerformance.Performances["+ i +"].Series["+ j +"].Values.Length"); k++) {
						seriesItem_values.Add(_ctx.StringValue("DescribeDBClusterPerformance.Performances["+ i +"].Series["+ j +"].Values["+ k +"]"));
					}
					seriesItem.Values = seriesItem_values;

					performanceItem_series.Add(seriesItem);
				}
				performanceItem.Series = performanceItem_series;

				describeDBClusterPerformanceResponse_performances.Add(performanceItem);
			}
			describeDBClusterPerformanceResponse.Performances = describeDBClusterPerformanceResponse_performances;
        
			return describeDBClusterPerformanceResponse;
        }
    }
}
