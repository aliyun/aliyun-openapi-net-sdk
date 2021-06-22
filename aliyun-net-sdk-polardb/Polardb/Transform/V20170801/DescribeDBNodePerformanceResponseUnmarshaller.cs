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
    public class DescribeDBNodePerformanceResponseUnmarshaller
    {
        public static DescribeDBNodePerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBNodePerformanceResponse describeDBNodePerformanceResponse = new DescribeDBNodePerformanceResponse();

			describeDBNodePerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDBNodePerformanceResponse.DBVersion = _ctx.StringValue("DescribeDBNodePerformance.DBVersion");
			describeDBNodePerformanceResponse.EndTime = _ctx.StringValue("DescribeDBNodePerformance.EndTime");
			describeDBNodePerformanceResponse.RequestId = _ctx.StringValue("DescribeDBNodePerformance.RequestId");
			describeDBNodePerformanceResponse.StartTime = _ctx.StringValue("DescribeDBNodePerformance.StartTime");
			describeDBNodePerformanceResponse.DBType = _ctx.StringValue("DescribeDBNodePerformance.DBType");
			describeDBNodePerformanceResponse.DBNodeId = _ctx.StringValue("DescribeDBNodePerformance.DBNodeId");
			describeDBNodePerformanceResponse.Engine = _ctx.StringValue("DescribeDBNodePerformance.Engine");

			List<DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem> describeDBNodePerformanceResponse_performanceKeys = new List<DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBNodePerformance.PerformanceKeys.Length"); i++) {
				DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem performanceItem = new DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem();
				performanceItem.MetricName = _ctx.StringValue("DescribeDBNodePerformance.PerformanceKeys["+ i +"].MetricName");
				performanceItem.Measurement = _ctx.StringValue("DescribeDBNodePerformance.PerformanceKeys["+ i +"].Measurement");

				List<DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem.DescribeDBNodePerformance_PerformanceItemValue> performanceItem_points = new List<DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem.DescribeDBNodePerformance_PerformanceItemValue>();
				for (int j = 0; j < _ctx.Length("DescribeDBNodePerformance.PerformanceKeys["+ i +"].Points.Length"); j++) {
					DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem.DescribeDBNodePerformance_PerformanceItemValue performanceItemValue = new DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem.DescribeDBNodePerformance_PerformanceItemValue();
					performanceItemValue._Value = _ctx.StringValue("DescribeDBNodePerformance.PerformanceKeys["+ i +"].Points["+ j +"].Value");
					performanceItemValue.Timestamp = _ctx.LongValue("DescribeDBNodePerformance.PerformanceKeys["+ i +"].Points["+ j +"].Timestamp");

					performanceItem_points.Add(performanceItemValue);
				}
				performanceItem.Points = performanceItem_points;

				describeDBNodePerformanceResponse_performanceKeys.Add(performanceItem);
			}
			describeDBNodePerformanceResponse.PerformanceKeys = describeDBNodePerformanceResponse_performanceKeys;
        
			return describeDBNodePerformanceResponse;
        }
    }
}
