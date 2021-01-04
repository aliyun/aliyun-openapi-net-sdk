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
    public class DescribeDnsGtmAccessStrategiesResponseUnmarshaller
    {
        public static DescribeDnsGtmAccessStrategiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmAccessStrategiesResponse describeDnsGtmAccessStrategiesResponse = new DescribeDnsGtmAccessStrategiesResponse();

			describeDnsGtmAccessStrategiesResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmAccessStrategiesResponse.RequestId = _ctx.StringValue("DescribeDnsGtmAccessStrategies.RequestId");
			describeDnsGtmAccessStrategiesResponse.TotalItems = _ctx.IntegerValue("DescribeDnsGtmAccessStrategies.TotalItems");
			describeDnsGtmAccessStrategiesResponse.TotalPages = _ctx.IntegerValue("DescribeDnsGtmAccessStrategies.TotalPages");
			describeDnsGtmAccessStrategiesResponse.PageNumber = _ctx.IntegerValue("DescribeDnsGtmAccessStrategies.PageNumber");
			describeDnsGtmAccessStrategiesResponse.PageSize = _ctx.IntegerValue("DescribeDnsGtmAccessStrategies.PageSize");

			List<DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy> describeDnsGtmAccessStrategiesResponse_strategies = new List<DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategies.Strategies.Length"); i++) {
				DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy strategy = new DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy();
				strategy.StrategyId = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].StrategyId");
				strategy.StrategyName = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].StrategyName");
				strategy.CreateTime = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].CreateTime");
				strategy.CreateTimestamp = _ctx.LongValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].CreateTimestamp");
				strategy.EffectiveAddrPoolGroupType = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].EffectiveAddrPoolGroupType");
				strategy.EffectiveAddrPoolType = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].EffectiveAddrPoolType");
				strategy.EffectiveLbaStrategy = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].EffectiveLbaStrategy");

				List<DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy.DescribeDnsGtmAccessStrategies_Line> strategy_lines = new List<DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy.DescribeDnsGtmAccessStrategies_Line>();
				for (int j = 0; j < _ctx.Length("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].Lines.Length"); j++) {
					DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy.DescribeDnsGtmAccessStrategies_Line line = new DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy.DescribeDnsGtmAccessStrategies_Line();
					line.LineCode = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].Lines["+ j +"].LineCode");
					line.LineName = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].Lines["+ j +"].LineName");
					line.GroupCode = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].Lines["+ j +"].GroupCode");
					line.GroupName = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].Lines["+ j +"].GroupName");

					strategy_lines.Add(line);
				}
				strategy.Lines = strategy_lines;

				List<DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy.DescribeDnsGtmAccessStrategies_EffectiveAddrPool> strategy_effectiveAddrPools = new List<DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy.DescribeDnsGtmAccessStrategies_EffectiveAddrPool>();
				for (int j = 0; j < _ctx.Length("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].EffectiveAddrPools.Length"); j++) {
					DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy.DescribeDnsGtmAccessStrategies_EffectiveAddrPool effectiveAddrPool = new DescribeDnsGtmAccessStrategiesResponse.DescribeDnsGtmAccessStrategies_Strategy.DescribeDnsGtmAccessStrategies_EffectiveAddrPool();
					effectiveAddrPool.Id = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].EffectiveAddrPools["+ j +"].Id");
					effectiveAddrPool.Name = _ctx.StringValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].EffectiveAddrPools["+ j +"].Name");
					effectiveAddrPool.AddrCount = _ctx.IntegerValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].EffectiveAddrPools["+ j +"].AddrCount");
					effectiveAddrPool.LbaWeight = _ctx.IntegerValue("DescribeDnsGtmAccessStrategies.Strategies["+ i +"].EffectiveAddrPools["+ j +"].LbaWeight");

					strategy_effectiveAddrPools.Add(effectiveAddrPool);
				}
				strategy.EffectiveAddrPools = strategy_effectiveAddrPools;

				describeDnsGtmAccessStrategiesResponse_strategies.Add(strategy);
			}
			describeDnsGtmAccessStrategiesResponse.Strategies = describeDnsGtmAccessStrategiesResponse_strategies;
        
			return describeDnsGtmAccessStrategiesResponse;
        }
    }
}
