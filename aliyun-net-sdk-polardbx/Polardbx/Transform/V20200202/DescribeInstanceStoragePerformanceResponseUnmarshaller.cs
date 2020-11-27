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
    public class DescribeInstanceStoragePerformanceResponseUnmarshaller
    {
        public static DescribeInstanceStoragePerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceStoragePerformanceResponse describeInstanceStoragePerformanceResponse = new DescribeInstanceStoragePerformanceResponse();

			describeInstanceStoragePerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceStoragePerformanceResponse.RequestId = _ctx.StringValue("DescribeInstanceStoragePerformance.RequestId");
			describeInstanceStoragePerformanceResponse.Success = _ctx.BooleanValue("DescribeInstanceStoragePerformance.Success");
			describeInstanceStoragePerformanceResponse.Message = _ctx.StringValue("DescribeInstanceStoragePerformance.Message");

			DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data data = new DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data();

			List<DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data.DescribeInstanceStoragePerformance_PerformanceItem> data_performanceItems = new List<DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data.DescribeInstanceStoragePerformance_PerformanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceStoragePerformance.Data.PerformanceItems.Length"); i++) {
				DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data.DescribeInstanceStoragePerformance_PerformanceItem performanceItem = new DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data.DescribeInstanceStoragePerformance_PerformanceItem();
				performanceItem.Measurement = _ctx.StringValue("DescribeInstanceStoragePerformance.Data.PerformanceItems["+ i +"].Measurement");
				performanceItem.MetricName = _ctx.StringValue("DescribeInstanceStoragePerformance.Data.PerformanceItems["+ i +"].MetricName");

				List<DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data.DescribeInstanceStoragePerformance_PerformanceItem.DescribeInstanceStoragePerformance_Point> performanceItem_points = new List<DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data.DescribeInstanceStoragePerformance_PerformanceItem.DescribeInstanceStoragePerformance_Point>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceStoragePerformance.Data.PerformanceItems["+ i +"].Points.Length"); j++) {
					DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data.DescribeInstanceStoragePerformance_PerformanceItem.DescribeInstanceStoragePerformance_Point point = new DescribeInstanceStoragePerformanceResponse.DescribeInstanceStoragePerformance_Data.DescribeInstanceStoragePerformance_PerformanceItem.DescribeInstanceStoragePerformance_Point();
					point.Timestamp = _ctx.LongValue("DescribeInstanceStoragePerformance.Data.PerformanceItems["+ i +"].Points["+ j +"].Timestamp");
					point._Value = _ctx.StringValue("DescribeInstanceStoragePerformance.Data.PerformanceItems["+ i +"].Points["+ j +"].Value");

					performanceItem_points.Add(point);
				}
				performanceItem.Points = performanceItem_points;

				data_performanceItems.Add(performanceItem);
			}
			data.PerformanceItems = data_performanceItems;
			describeInstanceStoragePerformanceResponse.Data = data;
        
			return describeInstanceStoragePerformanceResponse;
        }
    }
}
