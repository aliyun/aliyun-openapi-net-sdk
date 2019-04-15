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
    public class DescribeStratetyResponseUnmarshaller
    {
        public static DescribeStratetyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStratetyResponse describeStratetyResponse = new DescribeStratetyResponse();

			describeStratetyResponse.HttpResponse = context.HttpResponse;
			describeStratetyResponse.RequestId = context.StringValue("DescribeStratety.RequestId");

			List<DescribeStratetyResponse.DescribeStratety_Strategy> describeStratetyResponse_strategies = new List<DescribeStratetyResponse.DescribeStratety_Strategy>();
			for (int i = 0; i < context.Length("DescribeStratety.Strategies.Length"); i++) {
				DescribeStratetyResponse.DescribeStratety_Strategy strategy = new DescribeStratetyResponse.DescribeStratety_Strategy();
				strategy.CycleDays = context.IntegerValue("DescribeStratety.Strategies["+ i +"].CycleDays");
				strategy.Id = context.IntegerValue("DescribeStratety.Strategies["+ i +"].Id");
				strategy.CycleStartTime = context.IntegerValue("DescribeStratety.Strategies["+ i +"].CycleStartTime");
				strategy.Type = context.IntegerValue("DescribeStratety.Strategies["+ i +"].Type");
				strategy.Name = context.StringValue("DescribeStratety.Strategies["+ i +"].Name");
				strategy.RiskCount = context.IntegerValue("DescribeStratety.Strategies["+ i +"].RiskCount");
				strategy.EcsCount = context.IntegerValue("DescribeStratety.Strategies["+ i +"].EcsCount");
				strategy.ExecStatus = context.IntegerValue("DescribeStratety.Strategies["+ i +"].ExecStatus");
				strategy.ProcessRate = context.IntegerValue("DescribeStratety.Strategies["+ i +"].ProcessRate");
				strategy.PassRate = context.IntegerValue("DescribeStratety.Strategies["+ i +"].PassRate");

				List<DescribeStratetyResponse.DescribeStratety_Strategy.DescribeStratety_ConfigTarget> strategy_configTargets = new List<DescribeStratetyResponse.DescribeStratety_Strategy.DescribeStratety_ConfigTarget>();
				for (int j = 0; j < context.Length("DescribeStratety.Strategies["+ i +"].ConfigTargets.Length"); j++) {
					DescribeStratetyResponse.DescribeStratety_Strategy.DescribeStratety_ConfigTarget configTarget = new DescribeStratetyResponse.DescribeStratety_Strategy.DescribeStratety_ConfigTarget();
					configTarget.Flag = context.StringValue("DescribeStratety.Strategies["+ i +"].ConfigTargets["+ j +"].Flag");
					configTarget.TargetType = context.StringValue("DescribeStratety.Strategies["+ i +"].ConfigTargets["+ j +"].TargetType");
					configTarget.Target = context.StringValue("DescribeStratety.Strategies["+ i +"].ConfigTargets["+ j +"].Target");

					strategy_configTargets.Add(configTarget);
				}
				strategy.ConfigTargets = strategy_configTargets;

				describeStratetyResponse_strategies.Add(strategy);
			}
			describeStratetyResponse.Strategies = describeStratetyResponse_strategies;
        
			return describeStratetyResponse;
        }
    }
}
