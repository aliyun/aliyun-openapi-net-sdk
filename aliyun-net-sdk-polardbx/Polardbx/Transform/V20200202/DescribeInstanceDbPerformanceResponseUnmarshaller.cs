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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeInstanceDbPerformanceResponseUnmarshaller
    {
        public static DescribeInstanceDbPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceDbPerformanceResponse describeInstanceDbPerformanceResponse = new DescribeInstanceDbPerformanceResponse();

			describeInstanceDbPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceDbPerformanceResponse.RequestId = _ctx.StringValue("DescribeInstanceDbPerformance.RequestId");
			describeInstanceDbPerformanceResponse.Success = _ctx.BooleanValue("DescribeInstanceDbPerformance.Success");
			describeInstanceDbPerformanceResponse.Message = _ctx.StringValue("DescribeInstanceDbPerformance.Message");

			DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data data = new DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data();

			List<DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data.DescribeInstanceDbPerformance_PerformanceItem> data_performanceItems = new List<DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data.DescribeInstanceDbPerformance_PerformanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceDbPerformance.Data.PerformanceItems.Length"); i++) {
				DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data.DescribeInstanceDbPerformance_PerformanceItem performanceItem = new DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data.DescribeInstanceDbPerformance_PerformanceItem();
				performanceItem.Measurement = _ctx.StringValue("DescribeInstanceDbPerformance.Data.PerformanceItems["+ i +"].Measurement");
				performanceItem.MetricName = _ctx.StringValue("DescribeInstanceDbPerformance.Data.PerformanceItems["+ i +"].MetricName");

				List<DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data.DescribeInstanceDbPerformance_PerformanceItem.DescribeInstanceDbPerformance_Point> performanceItem_points = new List<DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data.DescribeInstanceDbPerformance_PerformanceItem.DescribeInstanceDbPerformance_Point>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceDbPerformance.Data.PerformanceItems["+ i +"].Points.Length"); j++) {
					DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data.DescribeInstanceDbPerformance_PerformanceItem.DescribeInstanceDbPerformance_Point point = new DescribeInstanceDbPerformanceResponse.DescribeInstanceDbPerformance_Data.DescribeInstanceDbPerformance_PerformanceItem.DescribeInstanceDbPerformance_Point();
					point.Timestamp = _ctx.LongValue("DescribeInstanceDbPerformance.Data.PerformanceItems["+ i +"].Points["+ j +"].Timestamp");
					point._Value = _ctx.StringValue("DescribeInstanceDbPerformance.Data.PerformanceItems["+ i +"].Points["+ j +"].Value");

					performanceItem_points.Add(point);
				}
				performanceItem.Points = performanceItem_points;

				data_performanceItems.Add(performanceItem);
			}
			data.PerformanceItems = data_performanceItems;
			describeInstanceDbPerformanceResponse.Data = data;
        
			return describeInstanceDbPerformanceResponse;
        }
    }
}
