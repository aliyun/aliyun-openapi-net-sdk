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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeStrategyResponseUnmarshaller
    {
        public static DescribeStrategyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStrategyResponse describeStrategyResponse = new DescribeStrategyResponse();

			describeStrategyResponse.HttpResponse = _ctx.HttpResponse;
			describeStrategyResponse.RequestId = _ctx.StringValue("DescribeStrategy.RequestId");

			List<DescribeStrategyResponse.DescribeStrategy_Strategy> describeStrategyResponse_strategies = new List<DescribeStrategyResponse.DescribeStrategy_Strategy>();
			for (int i = 0; i < _ctx.Length("DescribeStrategy.Strategies.Length"); i++) {
				DescribeStrategyResponse.DescribeStrategy_Strategy strategy = new DescribeStrategyResponse.DescribeStrategy_Strategy();
				strategy.CycleDays = _ctx.IntegerValue("DescribeStrategy.Strategies["+ i +"].CycleDays");
				strategy.Id = _ctx.IntegerValue("DescribeStrategy.Strategies["+ i +"].Id");
				strategy.CycleStartTime = _ctx.IntegerValue("DescribeStrategy.Strategies["+ i +"].CycleStartTime");
				strategy.Type = _ctx.IntegerValue("DescribeStrategy.Strategies["+ i +"].Type");
				strategy.Name = _ctx.StringValue("DescribeStrategy.Strategies["+ i +"].Name");
				strategy.RiskCount = _ctx.IntegerValue("DescribeStrategy.Strategies["+ i +"].RiskCount");
				strategy.EcsCount = _ctx.IntegerValue("DescribeStrategy.Strategies["+ i +"].EcsCount");
				strategy.ExecStatus = _ctx.IntegerValue("DescribeStrategy.Strategies["+ i +"].ExecStatus");
				strategy.ProcessRate = _ctx.IntegerValue("DescribeStrategy.Strategies["+ i +"].ProcessRate");
				strategy.PassRate = _ctx.IntegerValue("DescribeStrategy.Strategies["+ i +"].PassRate");
				strategy.AuthVersionList = _ctx.StringValue("DescribeStrategy.Strategies["+ i +"].AuthVersionList");

				List<DescribeStrategyResponse.DescribeStrategy_Strategy.DescribeStrategy_ConfigTarget> strategy_configTargets = new List<DescribeStrategyResponse.DescribeStrategy_Strategy.DescribeStrategy_ConfigTarget>();
				for (int j = 0; j < _ctx.Length("DescribeStrategy.Strategies["+ i +"].ConfigTargets.Length"); j++) {
					DescribeStrategyResponse.DescribeStrategy_Strategy.DescribeStrategy_ConfigTarget configTarget = new DescribeStrategyResponse.DescribeStrategy_Strategy.DescribeStrategy_ConfigTarget();
					configTarget.Flag = _ctx.StringValue("DescribeStrategy.Strategies["+ i +"].ConfigTargets["+ j +"].Flag");
					configTarget.TargetType = _ctx.StringValue("DescribeStrategy.Strategies["+ i +"].ConfigTargets["+ j +"].TargetType");
					configTarget.Target = _ctx.StringValue("DescribeStrategy.Strategies["+ i +"].ConfigTargets["+ j +"].Target");

					strategy_configTargets.Add(configTarget);
				}
				strategy.ConfigTargets = strategy_configTargets;

				describeStrategyResponse_strategies.Add(strategy);
			}
			describeStrategyResponse.Strategies = describeStrategyResponse_strategies;
        
			return describeStrategyResponse;
        }
    }
}
