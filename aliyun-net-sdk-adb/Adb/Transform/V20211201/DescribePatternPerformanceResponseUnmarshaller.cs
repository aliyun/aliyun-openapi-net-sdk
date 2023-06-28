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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribePatternPerformanceResponseUnmarshaller
    {
        public static DescribePatternPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePatternPerformanceResponse describePatternPerformanceResponse = new DescribePatternPerformanceResponse();

			describePatternPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describePatternPerformanceResponse.EndTime = _ctx.StringValue("DescribePatternPerformance.EndTime");
			describePatternPerformanceResponse.RequestId = _ctx.StringValue("DescribePatternPerformance.RequestId");
			describePatternPerformanceResponse.StartTime = _ctx.StringValue("DescribePatternPerformance.StartTime");

			List<DescribePatternPerformanceResponse.DescribePatternPerformance_PerformanceItem> describePatternPerformanceResponse_performances = new List<DescribePatternPerformanceResponse.DescribePatternPerformance_PerformanceItem>();
			for (int i = 0; i < _ctx.Length("DescribePatternPerformance.Performances.Length"); i++) {
				DescribePatternPerformanceResponse.DescribePatternPerformance_PerformanceItem performanceItem = new DescribePatternPerformanceResponse.DescribePatternPerformance_PerformanceItem();
				performanceItem.Key = _ctx.StringValue("DescribePatternPerformance.Performances["+ i +"].Key");
				performanceItem.Unit = _ctx.StringValue("DescribePatternPerformance.Performances["+ i +"].Unit");

				List<DescribePatternPerformanceResponse.DescribePatternPerformance_PerformanceItem.DescribePatternPerformance_SeriesItem> performanceItem_series = new List<DescribePatternPerformanceResponse.DescribePatternPerformance_PerformanceItem.DescribePatternPerformance_SeriesItem>();
				for (int j = 0; j < _ctx.Length("DescribePatternPerformance.Performances["+ i +"].Series.Length"); j++) {
					DescribePatternPerformanceResponse.DescribePatternPerformance_PerformanceItem.DescribePatternPerformance_SeriesItem seriesItem = new DescribePatternPerformanceResponse.DescribePatternPerformance_PerformanceItem.DescribePatternPerformance_SeriesItem();
					seriesItem.Name = _ctx.StringValue("DescribePatternPerformance.Performances["+ i +"].Series["+ j +"].Name");

					List<string> seriesItem_values = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribePatternPerformance.Performances["+ i +"].Series["+ j +"].Values.Length"); k++) {
						seriesItem_values.Add(_ctx.StringValue("DescribePatternPerformance.Performances["+ i +"].Series["+ j +"].Values["+ k +"]"));
					}
					seriesItem.Values = seriesItem_values;

					performanceItem_series.Add(seriesItem);
				}
				performanceItem.Series = performanceItem_series;

				describePatternPerformanceResponse_performances.Add(performanceItem);
			}
			describePatternPerformanceResponse.Performances = describePatternPerformanceResponse_performances;
        
			return describePatternPerformanceResponse;
        }
    }
}
