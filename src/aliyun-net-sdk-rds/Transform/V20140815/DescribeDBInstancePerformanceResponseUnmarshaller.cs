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
using Aliyun.Acs.Rds.Model.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstancePerformanceResponseUnmarshaller
    {
        public static DescribeDBInstancePerformanceResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDBInstancePerformanceResponse describeDBInstancePerformanceResponse = new DescribeDBInstancePerformanceResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDBInstancePerformance.RequestId"),
                DBInstanceId = context.StringValue("DescribeDBInstancePerformance.DBInstanceId"),
                Engine = context.StringValue("DescribeDBInstancePerformance.Engine"),
                StartTime = context.StringValue("DescribeDBInstancePerformance.StartTime"),
                EndTime = context.StringValue("DescribeDBInstancePerformance.EndTime")
            };
            List<DescribeDBInstancePerformanceResponse.PerformanceKey> performanceKeys = new List<DescribeDBInstancePerformanceResponse.PerformanceKey>();
			for (int i = 0; i < context.Length("DescribeDBInstancePerformance.PerformanceKeys.Length"); i++) {
                DescribeDBInstancePerformanceResponse.PerformanceKey performanceKey = new DescribeDBInstancePerformanceResponse.PerformanceKey()
                {
                    Key = context.StringValue($"DescribeDBInstancePerformance.PerformanceKeys[{i}].Key"),
                    Unit = context.StringValue($"DescribeDBInstancePerformance.PerformanceKeys[{i}].Unit"),
                    ValueFormat = context.StringValue($"DescribeDBInstancePerformance.PerformanceKeys[{i}].ValueFormat")
                };
                List<DescribeDBInstancePerformanceResponse.PerformanceKey.PerformanceValue> values = new List<DescribeDBInstancePerformanceResponse.PerformanceKey.PerformanceValue>();
				for (int j = 0; j < context.Length($"DescribeDBInstancePerformance.PerformanceKeys[{i}].Values.Length"); j++) {
                    DescribeDBInstancePerformanceResponse.PerformanceKey.PerformanceValue performanceValue = new DescribeDBInstancePerformanceResponse.PerformanceKey.PerformanceValue()
                    {
                        Value = context.StringValue($"DescribeDBInstancePerformance.PerformanceKeys[{i}].Values[{j}].Value"),
                        Date = context.StringValue($"DescribeDBInstancePerformance.PerformanceKeys[{i}].Values[{j}].Date")
                    };
                    values.Add(performanceValue);
				}
				performanceKey.Values = values;

				performanceKeys.Add(performanceKey);
			}
			describeDBInstancePerformanceResponse.PerformanceKeys = performanceKeys;
        
			return describeDBInstancePerformanceResponse;
        }
    }
}