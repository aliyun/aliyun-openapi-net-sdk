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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeDBInstancePerformanceResponseUnmarshaller
    {
        public static DescribeDBInstancePerformanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstancePerformanceResponse describeDBInstancePerformanceResponse = new DescribeDBInstancePerformanceResponse();

			describeDBInstancePerformanceResponse.HttpResponse = context.HttpResponse;
			describeDBInstancePerformanceResponse.RequestId = context.StringValue("DescribeDBInstancePerformance.RequestId");
			describeDBInstancePerformanceResponse.DBInstanceId = context.StringValue("DescribeDBInstancePerformance.DBInstanceId");
			describeDBInstancePerformanceResponse.Engine = context.StringValue("DescribeDBInstancePerformance.Engine");
			describeDBInstancePerformanceResponse.StartTime = context.StringValue("DescribeDBInstancePerformance.StartTime");
			describeDBInstancePerformanceResponse.EndTime = context.StringValue("DescribeDBInstancePerformance.EndTime");

			List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey> describeDBInstancePerformanceResponse_performanceKeys = new List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey>();
			for (int i = 0; i < context.Length("DescribeDBInstancePerformance.PerformanceKeys.Length"); i++) {
				DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey performanceKey = new DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey();
				performanceKey.Key = context.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].Key");
				performanceKey.Unit = context.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].Unit");
				performanceKey.ValueFormat = context.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].ValueFormat");

				List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue> performanceKey_performanceValues = new List<DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue>();
				for (int j = 0; j < context.Length("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].PerformanceValues.Length"); j++) {
					DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue performanceValue = new DescribeDBInstancePerformanceResponse.DescribeDBInstancePerformance_PerformanceKey.DescribeDBInstancePerformance_PerformanceValue();
					performanceValue._Value = context.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].PerformanceValues["+ j +"].Value");
					performanceValue.Date = context.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"].PerformanceValues["+ j +"].Date");

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