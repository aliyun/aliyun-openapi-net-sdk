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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBProxyPerformanceResponseUnmarshaller
    {
        public static DescribeDBProxyPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBProxyPerformanceResponse describeDBProxyPerformanceResponse = new DescribeDBProxyPerformanceResponse();

			describeDBProxyPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDBProxyPerformanceResponse.RequestId = _ctx.StringValue("DescribeDBProxyPerformance.RequestId");
			describeDBProxyPerformanceResponse.DBInstanceId = _ctx.StringValue("DescribeDBProxyPerformance.DBInstanceId");
			describeDBProxyPerformanceResponse.StartTime = _ctx.StringValue("DescribeDBProxyPerformance.StartTime");
			describeDBProxyPerformanceResponse.EndTime = _ctx.StringValue("DescribeDBProxyPerformance.EndTime");

			List<DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceKey> describeDBProxyPerformanceResponse_performanceKeys = new List<DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceKey>();
			for (int i = 0; i < _ctx.Length("DescribeDBProxyPerformance.PerformanceKeys.Length"); i++) {
				DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceKey performanceKey = new DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceKey();
				performanceKey.Key = _ctx.StringValue("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].Key");
				performanceKey.ValueFormat = _ctx.StringValue("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].ValueFormat");

				List<DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceKey.DescribeDBProxyPerformance_PerformanceValue> performanceKey_values = new List<DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceKey.DescribeDBProxyPerformance_PerformanceValue>();
				for (int j = 0; j < _ctx.Length("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].Values.Length"); j++) {
					DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceKey.DescribeDBProxyPerformance_PerformanceValue performanceValue = new DescribeDBProxyPerformanceResponse.DescribeDBProxyPerformance_PerformanceKey.DescribeDBProxyPerformance_PerformanceValue();
					performanceValue._Value = _ctx.StringValue("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].Values["+ j +"].Value");
					performanceValue.Date = _ctx.StringValue("DescribeDBProxyPerformance.PerformanceKeys["+ i +"].Values["+ j +"].Date");

					performanceKey_values.Add(performanceValue);
				}
				performanceKey.Values = performanceKey_values;

				describeDBProxyPerformanceResponse_performanceKeys.Add(performanceKey);
			}
			describeDBProxyPerformanceResponse.PerformanceKeys = describeDBProxyPerformanceResponse_performanceKeys;
        
			return describeDBProxyPerformanceResponse;
        }
    }
}
