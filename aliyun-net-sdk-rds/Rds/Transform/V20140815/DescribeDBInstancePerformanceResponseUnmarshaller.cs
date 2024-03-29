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
    public class DescribeDBInstancePerformanceResponseUnmarshaller
    {
        public static DescribeDBInstancePerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancePerformanceResponse describeDBInstancePerformanceResponse = new DescribeDBInstancePerformanceResponse();

			describeDBInstancePerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancePerformanceResponse.EndTime = _ctx.StringValue("DescribeDBInstancePerformance.EndTime");
			describeDBInstancePerformanceResponse.StartTime = _ctx.StringValue("DescribeDBInstancePerformance.StartTime");
			describeDBInstancePerformanceResponse.DBInstanceId = _ctx.StringValue("DescribeDBInstancePerformance.DBInstanceId");
			describeDBInstancePerformanceResponse.Engine = _ctx.StringValue("DescribeDBInstancePerformance.Engine");
			describeDBInstancePerformanceResponse.RequestId = _ctx.StringValue("DescribeDBInstancePerformance.RequestId");

			List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey> describeDBInstancePerformanceResponse_performanceKeys = new List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstancePerformance.PerformanceKeys.Length"); i++) {
				DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey performanceKey = new DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey();
				performanceKey.Key = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].Key");
				performanceKey.ValueFormat = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].ValueFormat");
				performanceKey.Unit = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].Unit");

				List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue> performanceKey_values = new List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].Values.Length"); j++) {
					DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue performanceValue = new DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue();
					performanceValue.Date = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].Values["+ j +"].Date");
					performanceValue._Value = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].Values["+ j +"].Value");

					performanceKey_values.Add(performanceValue);
				}
				performanceKey.Values = performanceKey_values;

				describeDBInstancePerformanceResponse_performanceKeys.Add(performanceKey);
			}
			describeDBInstancePerformanceResponse.PerformanceKeys = describeDBInstancePerformanceResponse_performanceKeys;
        
			return describeDBInstancePerformanceResponse;
        }
    }
}
