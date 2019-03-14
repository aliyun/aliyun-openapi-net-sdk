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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
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

			List<string> describeDBInstancePerformanceResponse_performanceKeys = new List<string>();
			for (int i = 0; i < context.Length("DescribeDBInstancePerformance.PerformanceKeys.Length"); i++) {
				describeDBInstancePerformanceResponse_performanceKeys.Add(context.StringValue("DescribeDBInstancePerformance.PerformanceKeys["+ i +"]"));
			}
			describeDBInstancePerformanceResponse.PerformanceKeys = describeDBInstancePerformanceResponse_performanceKeys;
        
			return describeDBInstancePerformanceResponse;
        }
    }
}
