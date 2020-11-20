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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeDBInstancePerformanceResponseUnmarshaller
    {
        public static DescribeDBInstancePerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancePerformanceResponse describeDBInstancePerformanceResponse = new DescribeDBInstancePerformanceResponse();

			describeDBInstancePerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancePerformanceResponse.RequestId = _ctx.StringValue("DescribeDBInstancePerformance.RequestId");
			describeDBInstancePerformanceResponse.DBInstanceId = _ctx.StringValue("DescribeDBInstancePerformance.DBInstanceId");
			describeDBInstancePerformanceResponse.Engine = _ctx.StringValue("DescribeDBInstancePerformance.Engine");
			describeDBInstancePerformanceResponse.StartTime = _ctx.StringValue("DescribeDBInstancePerformance.StartTime");
			describeDBInstancePerformanceResponse.EndTime = _ctx.StringValue("DescribeDBInstancePerformance.EndTime");

			List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey> describeDBInstancePerformanceResponse_performanceKeys = new List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstancePerformance.PerformanceKeys.Length"); i++) {
				DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey performanceKey = new DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey();
				performanceKey.Key = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].Key");
				performanceKey.Unit = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].Unit");
				performanceKey.ValueFormat = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].ValueFormat");

				List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue> performanceKey_performanceValues = new List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].PerformanceValues.Length"); j++) {
					DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue performanceValue = new DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue();
					performanceValue._Value = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].PerformanceValues["+ j +"].Value");
					performanceValue.Date = _ctx.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].PerformanceValues["+ j +"].Date");

					performanceKey_performanceValues.Add(performanceValue);
				}
				performanceKey.PerformanceValues = performanceKey_performanceValues;

				describeDBInstancePerformanceResponse_performanceKeys.Add(performanceKey);
			}
			describeDBInstancePerformanceResponse.PerformanceKeys = describeDBInstancePerformanceResponse_performanceKeys;
        
			return describeDBInstancePerformanceResponse;
        }
    }
}
