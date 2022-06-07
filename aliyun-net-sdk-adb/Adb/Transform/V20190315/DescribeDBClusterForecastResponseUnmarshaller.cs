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
    public class DescribeDBClusterForecastResponseUnmarshaller
    {
        public static DescribeDBClusterForecastResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterForecastResponse describeDBClusterForecastResponse = new DescribeDBClusterForecastResponse();

			describeDBClusterForecastResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterForecastResponse.RequestId = _ctx.StringValue("DescribeDBClusterForecast.RequestId");

			List<DescribeDBClusterForecastResponse.DescribeDBClusterForecast_PerformancesItem> describeDBClusterForecastResponse_performances = new List<DescribeDBClusterForecastResponse.DescribeDBClusterForecast_PerformancesItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterForecast.Performances.Length"); i++) {
				DescribeDBClusterForecastResponse.DescribeDBClusterForecast_PerformancesItem performancesItem = new DescribeDBClusterForecastResponse.DescribeDBClusterForecast_PerformancesItem();
				performancesItem.Key = _ctx.StringValue("DescribeDBClusterForecast.Performances["+ i +"].Key");
				performancesItem.Unit = _ctx.StringValue("DescribeDBClusterForecast.Performances["+ i +"].Unit");

				List<DescribeDBClusterForecastResponse.DescribeDBClusterForecast_PerformancesItem.DescribeDBClusterForecast_SeriesItem> performancesItem_series = new List<DescribeDBClusterForecastResponse.DescribeDBClusterForecast_PerformancesItem.DescribeDBClusterForecast_SeriesItem>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusterForecast.Performances["+ i +"].Series.Length"); j++) {
					DescribeDBClusterForecastResponse.DescribeDBClusterForecast_PerformancesItem.DescribeDBClusterForecast_SeriesItem seriesItem = new DescribeDBClusterForecastResponse.DescribeDBClusterForecast_PerformancesItem.DescribeDBClusterForecast_SeriesItem();
					seriesItem.Name = _ctx.StringValue("DescribeDBClusterForecast.Performances["+ i +"].Series["+ j +"].Name");
					seriesItem.Values = _ctx.StringValue("DescribeDBClusterForecast.Performances["+ i +"].Series["+ j +"].Values");

					performancesItem_series.Add(seriesItem);
				}
				performancesItem.Series = performancesItem_series;

				describeDBClusterForecastResponse_performances.Add(performancesItem);
			}
			describeDBClusterForecastResponse.Performances = describeDBClusterForecastResponse_performances;
        
			return describeDBClusterForecastResponse;
        }
    }
}
