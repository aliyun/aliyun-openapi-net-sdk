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
    public class DescribeGtmAccessStrategiesResponseUnmarshaller
    {
        public static DescribeGtmAccessStrategiesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmAccessStrategiesResponse describeGtmAccessStrategiesResponse = new DescribeGtmAccessStrategiesResponse();

			describeGtmAccessStrategiesResponse.HttpResponse = context.HttpResponse;
			describeGtmAccessStrategiesResponse.RequestId = context.StringValue("DescribeGtmAccessStrategies.RequestId");
			describeGtmAccessStrategiesResponse.TotalItems = context.IntegerValue("DescribeGtmAccessStrategies.TotalItems");
			describeGtmAccessStrategiesResponse.TotalPages = context.IntegerValue("DescribeGtmAccessStrategies.TotalPages");
			describeGtmAccessStrategiesResponse.PageNumber = context.IntegerValue("DescribeGtmAccessStrategies.PageNumber");
			describeGtmAccessStrategiesResponse.PageSize = context.IntegerValue("DescribeGtmAccessStrategies.PageSize");

			List<DescribeGtmAccessStrategiesResponse.DescribeGtmAccessStrategies_Strategy> describeGtmAccessStrategiesResponse_strategies = new List<DescribeGtmAccessStrategiesResponse.DescribeGtmAccessStrategies_Strategy>();
			for (int i = 0; i < context.Length("DescribeGtmAccessStrategies.Strategies.Length"); i++) {
				DescribeGtmAccessStrategiesResponse.DescribeGtmAccessStrategies_Strategy strategy = new DescribeGtmAccessStrategiesResponse.DescribeGtmAccessStrategies_Strategy();
				strategy.StrategyId = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].StrategyId");
				strategy.StrategyName = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].StrategyName");
				strategy.CreateTime = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].CreateTime");
				strategy.CreateTimestamp = context.LongValue("DescribeGtmAccessStrategies.Strategies["+ i +"].CreateTimestamp");
				strategy.DefaultAddrPoolId = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].DefaultAddrPoolId");
				strategy.DefaultAddrPoolName = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].DefaultAddrPoolName");
				strategy.FailoverAddrPoolId = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].FailoverAddrPoolId");
				strategy.FailoverAddrPoolName = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].FailoverAddrPoolName");
				strategy.AccessMode = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].AccessMode");
				strategy.AccessStatus = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].AccessStatus");
				strategy.StrategyMode = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].StrategyMode");
				strategy.InstanceId = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].InstanceId");
				strategy.DefaultAddrPoolStatus = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].DefaultAddrPoolStatus");
				strategy.FailoverAddrPoolStatus = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].FailoverAddrPoolStatus");
				strategy.DefaultAddrPoolMonitorStatus = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].DefaultAddrPoolMonitorStatus");
				strategy.FailoverAddrPoolMonitorStatus = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].FailoverAddrPoolMonitorStatus");

				List<DescribeGtmAccessStrategiesResponse.DescribeGtmAccessStrategies_Strategy.DescribeGtmAccessStrategies_Line> strategy_lines = new List<DescribeGtmAccessStrategiesResponse.DescribeGtmAccessStrategies_Strategy.DescribeGtmAccessStrategies_Line>();
				for (int j = 0; j < context.Length("DescribeGtmAccessStrategies.Strategies["+ i +"].Lines.Length"); j++) {
					DescribeGtmAccessStrategiesResponse.DescribeGtmAccessStrategies_Strategy.DescribeGtmAccessStrategies_Line line = new DescribeGtmAccessStrategiesResponse.DescribeGtmAccessStrategies_Strategy.DescribeGtmAccessStrategies_Line();
					line.LineCode = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].Lines["+ j +"].LineCode");
					line.LineName = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].Lines["+ j +"].LineName");
					line.GroupCode = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].Lines["+ j +"].GroupCode");
					line.GroupName = context.StringValue("DescribeGtmAccessStrategies.Strategies["+ i +"].Lines["+ j +"].GroupName");

					strategy_lines.Add(line);
				}
				strategy.Lines = strategy_lines;

				describeGtmAccessStrategiesResponse_strategies.Add(strategy);
			}
			describeGtmAccessStrategiesResponse.Strategies = describeGtmAccessStrategiesResponse_strategies;
        
			return describeGtmAccessStrategiesResponse;
        }
    }
}
