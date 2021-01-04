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
        public static DescribeGtmAccessStrategyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGtmAccessStrategyResponse describeGtmAccessStrategyResponse = new DescribeGtmAccessStrategyResponse();

			describeGtmAccessStrategyResponse.HttpResponse = _ctx.HttpResponse;
			describeGtmAccessStrategyResponse.RequestId = _ctx.StringValue("DescribeGtmAccessStrategy.RequestId");
			describeGtmAccessStrategyResponse.StrategyId = _ctx.StringValue("DescribeGtmAccessStrategy.StrategyId");
			describeGtmAccessStrategyResponse.StrategyName = _ctx.StringValue("DescribeGtmAccessStrategy.StrategyName");
			describeGtmAccessStrategyResponse.DefultAddrPoolId = _ctx.StringValue("DescribeGtmAccessStrategy.DefultAddrPoolId");
			describeGtmAccessStrategyResponse.DefaultAddrPoolName = _ctx.StringValue("DescribeGtmAccessStrategy.DefaultAddrPoolName");
			describeGtmAccessStrategyResponse.FailoverAddrPoolId = _ctx.StringValue("DescribeGtmAccessStrategy.FailoverAddrPoolId");
			describeGtmAccessStrategyResponse.FailoverAddrPoolName = _ctx.StringValue("DescribeGtmAccessStrategy.FailoverAddrPoolName");
			describeGtmAccessStrategyResponse.StrategyMode = _ctx.StringValue("DescribeGtmAccessStrategy.StrategyMode");
			describeGtmAccessStrategyResponse.AccessMode = _ctx.StringValue("DescribeGtmAccessStrategy.AccessMode");
			describeGtmAccessStrategyResponse.AccessStatus = _ctx.StringValue("DescribeGtmAccessStrategy.AccessStatus");
			describeGtmAccessStrategyResponse.InstanceId = _ctx.StringValue("DescribeGtmAccessStrategy.InstanceId");
			describeGtmAccessStrategyResponse.DefaultAddrPoolStatus = _ctx.StringValue("DescribeGtmAccessStrategy.DefaultAddrPoolStatus");
			describeGtmAccessStrategyResponse.FailoverAddrPoolStatus = _ctx.StringValue("DescribeGtmAccessStrategy.FailoverAddrPoolStatus");
			describeGtmAccessStrategyResponse.DefaultAddrPoolMonitorStatus = _ctx.StringValue("DescribeGtmAccessStrategy.DefaultAddrPoolMonitorStatus");
			describeGtmAccessStrategyResponse.FailoverAddrPoolMonitorStatus = _ctx.StringValue("DescribeGtmAccessStrategy.FailoverAddrPoolMonitorStatus");

			List<DescribeGtmAccessStrategyResponse.DescribeGtmAccessStrategy_Line> describeGtmAccessStrategyResponse_lines = new List<DescribeGtmAccessStrategyResponse.DescribeGtmAccessStrategy_Line>();
			for (int i = 0; i < _ctx.Length("DescribeGtmAccessStrategy.Lines.Length"); i++) {
				DescribeGtmAccessStrategyResponse.DescribeGtmAccessStrategy_Line line = new DescribeGtmAccessStrategyResponse.DescribeGtmAccessStrategy_Line();
				line.LineCode = _ctx.StringValue("DescribeGtmAccessStrategy.Lines["+ i +"].LineCode");
				line.LineName = _ctx.StringValue("DescribeGtmAccessStrategy.Lines["+ i +"].LineName");
				line.GroupCode = _ctx.StringValue("DescribeGtmAccessStrategy.Lines["+ i +"].GroupCode");
				line.GroupName = _ctx.StringValue("DescribeGtmAccessStrategy.Lines["+ i +"].GroupName");

				describeGtmAccessStrategyResponse_lines.Add(line);
			}
			describeGtmAccessStrategyResponse.Lines = describeGtmAccessStrategyResponse_lines;
        
			return describeGtmAccessStrategyResponse;
        }
    }
}
