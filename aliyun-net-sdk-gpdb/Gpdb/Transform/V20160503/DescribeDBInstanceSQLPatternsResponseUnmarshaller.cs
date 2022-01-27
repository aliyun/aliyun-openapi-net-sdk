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
    public class DescribeDBInstanceSQLPatternsResponseUnmarshaller
    {
        public static DescribeDBInstanceSQLPatternsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceSQLPatternsResponse describeDBInstanceSQLPatternsResponse = new DescribeDBInstanceSQLPatternsResponse();

			describeDBInstanceSQLPatternsResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceSQLPatternsResponse.EndTime = _ctx.StringValue("DescribeDBInstanceSQLPatterns.EndTime");
			describeDBInstanceSQLPatternsResponse.RequestId = _ctx.StringValue("DescribeDBInstanceSQLPatterns.RequestId");
			describeDBInstanceSQLPatternsResponse.StartTime = _ctx.StringValue("DescribeDBInstanceSQLPatterns.StartTime");
			describeDBInstanceSQLPatternsResponse.DBClusterId = _ctx.StringValue("DescribeDBInstanceSQLPatterns.DBClusterId");

			List<DescribeDBInstanceSQLPatternsResponse.DescribeDBInstanceSQLPatterns_Pattern> describeDBInstanceSQLPatternsResponse_patterns = new List<DescribeDBInstanceSQLPatternsResponse.DescribeDBInstanceSQLPatterns_Pattern>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceSQLPatterns.Patterns.Length"); i++) {
				DescribeDBInstanceSQLPatternsResponse.DescribeDBInstanceSQLPatterns_Pattern pattern = new DescribeDBInstanceSQLPatternsResponse.DescribeDBInstanceSQLPatterns_Pattern();
				pattern.Name = _ctx.StringValue("DescribeDBInstanceSQLPatterns.Patterns["+ i +"].Name");
				pattern.Values = _ctx.StringValue("DescribeDBInstanceSQLPatterns.Patterns["+ i +"].Values");

				describeDBInstanceSQLPatternsResponse_patterns.Add(pattern);
			}
			describeDBInstanceSQLPatternsResponse.Patterns = describeDBInstanceSQLPatternsResponse_patterns;
        
			return describeDBInstanceSQLPatternsResponse;
        }
    }
}
