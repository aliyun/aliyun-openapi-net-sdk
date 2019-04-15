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
    public class DescribeWhiteListStrategyStatisticsResponseUnmarshaller
    {
        public static DescribeWhiteListStrategyStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWhiteListStrategyStatisticsResponse describeWhiteListStrategyStatisticsResponse = new DescribeWhiteListStrategyStatisticsResponse();

			describeWhiteListStrategyStatisticsResponse.HttpResponse = context.HttpResponse;
			describeWhiteListStrategyStatisticsResponse.RequestId = context.StringValue("DescribeWhiteListStrategyStatistics.RequestId");
			describeWhiteListStrategyStatisticsResponse.Count = context.IntegerValue("DescribeWhiteListStrategyStatistics.Count");
			describeWhiteListStrategyStatisticsResponse.PageSize = context.IntegerValue("DescribeWhiteListStrategyStatistics.PageSize");
			describeWhiteListStrategyStatisticsResponse.TotalCount = context.IntegerValue("DescribeWhiteListStrategyStatistics.TotalCount");
			describeWhiteListStrategyStatisticsResponse.CurrentPage = context.IntegerValue("DescribeWhiteListStrategyStatistics.CurrentPage");

			List<DescribeWhiteListStrategyStatisticsResponse.DescribeWhiteListStrategyStatistics_Strategy> describeWhiteListStrategyStatisticsResponse_strategies = new List<DescribeWhiteListStrategyStatisticsResponse.DescribeWhiteListStrategyStatistics_Strategy>();
			for (int i = 0; i < context.Length("DescribeWhiteListStrategyStatistics.Strategies.Length"); i++) {
				DescribeWhiteListStrategyStatisticsResponse.DescribeWhiteListStrategyStatistics_Strategy strategy = new DescribeWhiteListStrategyStatisticsResponse.DescribeWhiteListStrategyStatistics_Strategy();
				strategy.StrategyId = context.LongValue("DescribeWhiteListStrategyStatistics.Strategies["+ i +"].StrategyId");
				strategy.StrategyName = context.StringValue("DescribeWhiteListStrategyStatistics.Strategies["+ i +"].StrategyName");
				strategy.StudyTime = context.IntegerValue("DescribeWhiteListStrategyStatistics.Strategies["+ i +"].StudyTime");
				strategy.AssetCount = context.IntegerValue("DescribeWhiteListStrategyStatistics.Strategies["+ i +"].AssetCount");
				strategy.Status = context.IntegerValue("DescribeWhiteListStrategyStatistics.Strategies["+ i +"].Status");
				strategy.TrustProcCount = context.IntegerValue("DescribeWhiteListStrategyStatistics.Strategies["+ i +"].TrustProcCount");
				strategy.SuspiciousProcCount = context.IntegerValue("DescribeWhiteListStrategyStatistics.Strategies["+ i +"].SuspiciousProcCount");
				strategy.VirusProcCount = context.IntegerValue("DescribeWhiteListStrategyStatistics.Strategies["+ i +"].VirusProcCount");
				strategy.Progress = context.IntegerValue("DescribeWhiteListStrategyStatistics.Strategies["+ i +"].Progress");

				describeWhiteListStrategyStatisticsResponse_strategies.Add(strategy);
			}
			describeWhiteListStrategyStatisticsResponse.Strategies = describeWhiteListStrategyStatisticsResponse_strategies;
        
			return describeWhiteListStrategyStatisticsResponse;
        }
    }
}
