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
    public class DescribeInstancePerformanceResponseUnmarshaller
    {
        public static DescribeInstancePerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancePerformanceResponse describeInstancePerformanceResponse = new DescribeInstancePerformanceResponse();

			describeInstancePerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancePerformanceResponse.RequestId = _ctx.StringValue("DescribeInstancePerformance.RequestId");
			describeInstancePerformanceResponse.Success = _ctx.BooleanValue("DescribeInstancePerformance.Success");
			describeInstancePerformanceResponse.Message = _ctx.StringValue("DescribeInstancePerformance.Message");

			DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data data = new DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data();

			List<DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data.DescribeInstancePerformance_PerformanceItem> data_performanceItems = new List<DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data.DescribeInstancePerformance_PerformanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstancePerformance.Data.PerformanceItems.Length"); i++) {
				DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data.DescribeInstancePerformance_PerformanceItem performanceItem = new DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data.DescribeInstancePerformance_PerformanceItem();
				performanceItem.Measurement = _ctx.StringValue("DescribeInstancePerformance.Data.PerformanceItems["+ i +"].Measurement");
				performanceItem.MetricName = _ctx.StringValue("DescribeInstancePerformance.Data.PerformanceItems["+ i +"].MetricName");

				List<DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data.DescribeInstancePerformance_PerformanceItem.DescribeInstancePerformance_Point> performanceItem_points = new List<DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data.DescribeInstancePerformance_PerformanceItem.DescribeInstancePerformance_Point>();
				for (int j = 0; j < _ctx.Length("DescribeInstancePerformance.Data.PerformanceItems["+ i +"].Points.Length"); j++) {
					DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data.DescribeInstancePerformance_PerformanceItem.DescribeInstancePerformance_Point point = new DescribeInstancePerformanceResponse.DescribeInstancePerformance_Data.DescribeInstancePerformance_PerformanceItem.DescribeInstancePerformance_Point();
					point.Timestamp = _ctx.LongValue("DescribeInstancePerformance.Data.PerformanceItems["+ i +"].Points["+ j +"].Timestamp");
					point._Value = _ctx.StringValue("DescribeInstancePerformance.Data.PerformanceItems["+ i +"].Points["+ j +"].Value");

					performanceItem_points.Add(point);
				}
				performanceItem.Points = performanceItem_points;

				data_performanceItems.Add(performanceItem);
			}
			data.PerformanceItems = data_performanceItems;
			describeInstancePerformanceResponse.Data = data;
        
			return describeInstancePerformanceResponse;
        }
    }
}
