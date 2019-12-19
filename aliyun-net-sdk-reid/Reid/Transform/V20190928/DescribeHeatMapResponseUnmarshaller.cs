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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class DescribeHeatMapResponseUnmarshaller
    {
        public static DescribeHeatMapResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHeatMapResponse describeHeatMapResponse = new DescribeHeatMapResponse();

			describeHeatMapResponse.HttpResponse = context.HttpResponse;
			describeHeatMapResponse.ErrorCode = context.StringValue("DescribeHeatMap.ErrorCode");
			describeHeatMapResponse.ErrorMessage = context.StringValue("DescribeHeatMap.ErrorMessage");
			describeHeatMapResponse.RequestId = context.StringValue("DescribeHeatMap.RequestId");
			describeHeatMapResponse.Success = context.BooleanValue("DescribeHeatMap.Success");

			List<DescribeHeatMapResponse.DescribeHeatMap_HeatMapPoint> describeHeatMapResponse_heatMapPoints = new List<DescribeHeatMapResponse.DescribeHeatMap_HeatMapPoint>();
			for (int i = 0; i < context.Length("DescribeHeatMap.HeatMapPoints.Length"); i++) {
				DescribeHeatMapResponse.DescribeHeatMap_HeatMapPoint heatMapPoint = new DescribeHeatMapResponse.DescribeHeatMap_HeatMapPoint();
				heatMapPoint.Y = context.FloatValue("DescribeHeatMap.HeatMapPoints["+ i +"].Y");
				heatMapPoint.Weight = context.IntegerValue("DescribeHeatMap.HeatMapPoints["+ i +"].Weight");
				heatMapPoint.X = context.FloatValue("DescribeHeatMap.HeatMapPoints["+ i +"].X");

				describeHeatMapResponse_heatMapPoints.Add(heatMapPoint);
			}
			describeHeatMapResponse.HeatMapPoints = describeHeatMapResponse_heatMapPoints;
        
			return describeHeatMapResponse;
        }
    }
}
