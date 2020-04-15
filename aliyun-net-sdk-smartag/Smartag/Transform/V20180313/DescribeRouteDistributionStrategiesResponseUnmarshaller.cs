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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeRouteDistributionStrategiesResponseUnmarshaller
    {
        public static DescribeRouteDistributionStrategiesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRouteDistributionStrategiesResponse describeRouteDistributionStrategiesResponse = new DescribeRouteDistributionStrategiesResponse();

			describeRouteDistributionStrategiesResponse.HttpResponse = context.HttpResponse;
			describeRouteDistributionStrategiesResponse.RequestId = context.StringValue("DescribeRouteDistributionStrategies.RequestId");
			describeRouteDistributionStrategiesResponse.TotalCount = context.IntegerValue("DescribeRouteDistributionStrategies.TotalCount");
			describeRouteDistributionStrategiesResponse.PageNumber = context.IntegerValue("DescribeRouteDistributionStrategies.PageNumber");
			describeRouteDistributionStrategiesResponse.PageSize = context.IntegerValue("DescribeRouteDistributionStrategies.PageSize");

			List<DescribeRouteDistributionStrategiesResponse.DescribeRouteDistributionStrategies_Strategy> describeRouteDistributionStrategiesResponse_strategies = new List<DescribeRouteDistributionStrategiesResponse.DescribeRouteDistributionStrategies_Strategy>();
			for (int i = 0; i < context.Length("DescribeRouteDistributionStrategies.Strategies.Length"); i++) {
				DescribeRouteDistributionStrategiesResponse.DescribeRouteDistributionStrategies_Strategy strategy = new DescribeRouteDistributionStrategiesResponse.DescribeRouteDistributionStrategies_Strategy();
				strategy.CreateTime = context.LongValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].CreateTime");
				strategy.InstanceId = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].InstanceId");
				strategy.SmartAGId = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].SmartAGId");
				strategy.HcInstanceId = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].HcInstanceId");
				strategy.SourceType = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].SourceType");
				strategy.DestCidrBlock = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].DestCidrBlock");
				strategy.RouteSource = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].RouteSource");
				strategy.RouteDistribution = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].RouteDistribution");
				strategy.Status = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].Status");
				strategy.IsConflict = context.BooleanValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].IsConflict");
				strategy.StrategyPublishStatus = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].StrategyPublishStatus");
				strategy.ConflictInfo = context.StringValue("DescribeRouteDistributionStrategies.Strategies["+ i +"].ConflictInfo");

				describeRouteDistributionStrategiesResponse_strategies.Add(strategy);
			}
			describeRouteDistributionStrategiesResponse.Strategies = describeRouteDistributionStrategiesResponse_strategies;
        
			return describeRouteDistributionStrategiesResponse;
        }
    }
}
