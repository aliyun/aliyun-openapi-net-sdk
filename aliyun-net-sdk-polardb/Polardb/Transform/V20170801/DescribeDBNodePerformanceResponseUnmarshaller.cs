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
        public static DescribeDBNodePerformanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBNodePerformanceResponse describeDBNodePerformanceResponse = new DescribeDBNodePerformanceResponse();

			describeDBNodePerformanceResponse.HttpResponse = context.HttpResponse;
			describeDBNodePerformanceResponse.RequestId = context.StringValue("DescribeDBNodePerformance.RequestId");
			describeDBNodePerformanceResponse.DBNodeId = context.StringValue("DescribeDBNodePerformance.DBNodeId");
			describeDBNodePerformanceResponse.Engine = context.StringValue("DescribeDBNodePerformance.Engine");
			describeDBNodePerformanceResponse.DBType = context.StringValue("DescribeDBNodePerformance.DBType");
			describeDBNodePerformanceResponse.DBVersion = context.StringValue("DescribeDBNodePerformance.DBVersion");
			describeDBNodePerformanceResponse.StartTime = context.StringValue("DescribeDBNodePerformance.StartTime");
			describeDBNodePerformanceResponse.EndTime = context.StringValue("DescribeDBNodePerformance.EndTime");

			List<DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem> describeDBNodePerformanceResponse_performanceKeys = new List<DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem>();
			for (int i = 0; i < context.Length("DescribeDBNodePerformance.PerformanceKeys.Length"); i++) {
				DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem performanceItem = new DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem();
				performanceItem.MetricName = context.StringValue("DescribeDBNodePerformance.PerformanceKeys["+ i +"].MetricName");
				performanceItem.Measurement = context.StringValue("DescribeDBNodePerformance.PerformanceKeys["+ i +"].Measurement");

				List<DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem.DescribeDBNodePerformance_PerformanceItemValue> performanceItem_points = new List<DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem.DescribeDBNodePerformance_PerformanceItemValue>();
				for (int j = 0; j < context.Length("DescribeDBNodePerformance.PerformanceKeys["+ i +"].Points.Length"); j++) {
					DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem.DescribeDBNodePerformance_PerformanceItemValue performanceItemValue = new DescribeDBNodePerformanceResponse.DescribeDBNodePerformance_PerformanceItem.DescribeDBNodePerformance_PerformanceItemValue();
					performanceItemValue._Value = context.StringValue("DescribeDBNodePerformance.PerformanceKeys["+ i +"].Points["+ j +"].Value");
					performanceItemValue.Timestamp = context.LongValue("DescribeDBNodePerformance.PerformanceKeys["+ i +"].Points["+ j +"].Timestamp");

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
