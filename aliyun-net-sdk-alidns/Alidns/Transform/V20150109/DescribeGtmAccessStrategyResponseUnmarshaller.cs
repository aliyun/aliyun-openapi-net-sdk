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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeGtmAccessStrategyResponseUnmarshaller
    {
        public static DescribeGtmAccessStrategyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmAccessStrategyResponse describeGtmAccessStrategyResponse = new DescribeGtmAccessStrategyResponse();

			describeGtmAccessStrategyResponse.HttpResponse = context.HttpResponse;
			describeGtmAccessStrategyResponse.RequestId = context.StringValue("DescribeGtmAccessStrategy.RequestId");
			describeGtmAccessStrategyResponse.StrategyId = context.StringValue("DescribeGtmAccessStrategy.StrategyId");
			describeGtmAccessStrategyResponse.StrategyName = context.StringValue("DescribeGtmAccessStrategy.StrategyName");
			describeGtmAccessStrategyResponse.DefultAddrPoolId = context.StringValue("DescribeGtmAccessStrategy.DefultAddrPoolId");
			describeGtmAccessStrategyResponse.DefaultAddrPoolName = context.StringValue("DescribeGtmAccessStrategy.DefaultAddrPoolName");
			describeGtmAccessStrategyResponse.FailoverAddrPoolId = context.StringValue("DescribeGtmAccessStrategy.FailoverAddrPoolId");
			describeGtmAccessStrategyResponse.FailoverAddrPoolName = context.StringValue("DescribeGtmAccessStrategy.FailoverAddrPoolName");
			describeGtmAccessStrategyResponse.StrategyMode = context.StringValue("DescribeGtmAccessStrategy.StrategyMode");
			describeGtmAccessStrategyResponse.AccessMode = context.StringValue("DescribeGtmAccessStrategy.AccessMode");
			describeGtmAccessStrategyResponse.AccessStatus = context.StringValue("DescribeGtmAccessStrategy.AccessStatus");
			describeGtmAccessStrategyResponse.InstanceId = context.StringValue("DescribeGtmAccessStrategy.InstanceId");

			List<DescribeGtmAccessStrategyResponse.DescribeGtmAccessStrategy_Line> describeGtmAccessStrategyResponse_lines = new List<DescribeGtmAccessStrategyResponse.DescribeGtmAccessStrategy_Line>();
			for (int i = 0; i < context.Length("DescribeGtmAccessStrategy.Lines.Length"); i++) {
				DescribeGtmAccessStrategyResponse.DescribeGtmAccessStrategy_Line line = new DescribeGtmAccessStrategyResponse.DescribeGtmAccessStrategy_Line();
				line.LineCode = context.StringValue("DescribeGtmAccessStrategy.Lines["+ i +"].LineCode");
				line.LineName = context.StringValue("DescribeGtmAccessStrategy.Lines["+ i +"].LineName");
				line.GroupCode = context.StringValue("DescribeGtmAccessStrategy.Lines["+ i +"].GroupCode");
				line.GroupName = context.StringValue("DescribeGtmAccessStrategy.Lines["+ i +"].GroupName");

				describeGtmAccessStrategyResponse_lines.Add(line);
			}
			describeGtmAccessStrategyResponse.Lines = describeGtmAccessStrategyResponse_lines;
        
			return describeGtmAccessStrategyResponse;
        }
    }
}
