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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeWhiteListStrategyListResponseUnmarshaller
    {
        public static DescribeWhiteListStrategyListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWhiteListStrategyListResponse describeWhiteListStrategyListResponse = new DescribeWhiteListStrategyListResponse();

			describeWhiteListStrategyListResponse.HttpResponse = context.HttpResponse;
			describeWhiteListStrategyListResponse.RequestId = context.StringValue("DescribeWhiteListStrategyList.RequestId");

			List<DescribeWhiteListStrategyListResponse.DescribeWhiteListStrategyList_Strategy> describeWhiteListStrategyListResponse_strategies = new List<DescribeWhiteListStrategyListResponse.DescribeWhiteListStrategyList_Strategy>();
			for (int i = 0; i < context.Length("DescribeWhiteListStrategyList.Strategies.Length"); i++) {
				DescribeWhiteListStrategyListResponse.DescribeWhiteListStrategyList_Strategy strategy = new DescribeWhiteListStrategyListResponse.DescribeWhiteListStrategyList_Strategy();
				strategy.StrategyId = context.LongValue("DescribeWhiteListStrategyList.Strategies["+ i +"].StrategyId");
				strategy.StrategyName = context.StringValue("DescribeWhiteListStrategyList.Strategies["+ i +"].StrategyName");
				strategy.StudyTime = context.IntegerValue("DescribeWhiteListStrategyList.Strategies["+ i +"].StudyTime");
				strategy.Status = context.IntegerValue("DescribeWhiteListStrategyList.Strategies["+ i +"].Status");

				describeWhiteListStrategyListResponse_strategies.Add(strategy);
			}
			describeWhiteListStrategyListResponse.Strategies = describeWhiteListStrategyListResponse_strategies;
        
			return describeWhiteListStrategyListResponse;
        }
    }
}
