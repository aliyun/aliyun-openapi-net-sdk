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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeRDSPerformanceResponseUnmarshaller
    {
        public static DescribeRDSPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRDSPerformanceResponse describeRDSPerformanceResponse = new DescribeRDSPerformanceResponse();

			describeRDSPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeRDSPerformanceResponse.RequestId = _ctx.StringValue("DescribeRDSPerformance.RequestId");
			describeRDSPerformanceResponse.Success = _ctx.BooleanValue("DescribeRDSPerformance.Success");

			List<DescribeRDSPerformanceResponse.DescribeRDSPerformance_PartialPerformanceData> describeRDSPerformanceResponse_data = new List<DescribeRDSPerformanceResponse.DescribeRDSPerformance_PartialPerformanceData>();
			for (int i = 0; i < _ctx.Length("DescribeRDSPerformance.Data.Length"); i++) {
				DescribeRDSPerformanceResponse.DescribeRDSPerformance_PartialPerformanceData partialPerformanceData = new DescribeRDSPerformanceResponse.DescribeRDSPerformance_PartialPerformanceData();
				partialPerformanceData.Key = _ctx.StringValue("DescribeRDSPerformance.Data["+ i +"].Key");
				partialPerformanceData.Unit = _ctx.StringValue("DescribeRDSPerformance.Data["+ i +"].Unit");
				partialPerformanceData.NodeNum = _ctx.IntegerValue("DescribeRDSPerformance.Data["+ i +"].NodeNum");
				partialPerformanceData.NodeName = _ctx.StringValue("DescribeRDSPerformance.Data["+ i +"].NodeName");

				List<DescribeRDSPerformanceResponse.DescribeRDSPerformance_PartialPerformanceData.DescribeRDSPerformance_PerformanceValue> partialPerformanceData_values = new List<DescribeRDSPerformanceResponse.DescribeRDSPerformance_PartialPerformanceData.DescribeRDSPerformance_PerformanceValue>();
				for (int j = 0; j < _ctx.Length("DescribeRDSPerformance.Data["+ i +"].Values.Length"); j++) {
					DescribeRDSPerformanceResponse.DescribeRDSPerformance_PartialPerformanceData.DescribeRDSPerformance_PerformanceValue performanceValue = new DescribeRDSPerformanceResponse.DescribeRDSPerformance_PartialPerformanceData.DescribeRDSPerformance_PerformanceValue();
					performanceValue._Value = _ctx.StringValue("DescribeRDSPerformance.Data["+ i +"].Values["+ j +"].Value");
					performanceValue.Date = _ctx.LongValue("DescribeRDSPerformance.Data["+ i +"].Values["+ j +"].Date");

					partialPerformanceData_values.Add(performanceValue);
				}
				partialPerformanceData.Values = partialPerformanceData_values;

				describeRDSPerformanceResponse_data.Add(partialPerformanceData);
			}
			describeRDSPerformanceResponse.Data = describeRDSPerformanceResponse_data;
        
			return describeRDSPerformanceResponse;
        }
    }
}
