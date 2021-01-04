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
    public class DescribeDnsGtmAccessStrategyResponseUnmarshaller
    {
        public static DescribeDnsGtmAccessStrategyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmAccessStrategyResponse describeDnsGtmAccessStrategyResponse = new DescribeDnsGtmAccessStrategyResponse();

			describeDnsGtmAccessStrategyResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmAccessStrategyResponse.RequestId = _ctx.StringValue("DescribeDnsGtmAccessStrategy.RequestId");
			describeDnsGtmAccessStrategyResponse.StrategyId = _ctx.StringValue("DescribeDnsGtmAccessStrategy.StrategyId");
			describeDnsGtmAccessStrategyResponse.StrategyName = _ctx.StringValue("DescribeDnsGtmAccessStrategy.StrategyName");
			describeDnsGtmAccessStrategyResponse.StrategyMode = _ctx.StringValue("DescribeDnsGtmAccessStrategy.StrategyMode");
			describeDnsGtmAccessStrategyResponse.InstanceId = _ctx.StringValue("DescribeDnsGtmAccessStrategy.InstanceId");
			describeDnsGtmAccessStrategyResponse.DefaultAddrPoolType = _ctx.StringValue("DescribeDnsGtmAccessStrategy.DefaultAddrPoolType");
			describeDnsGtmAccessStrategyResponse.DefaultLbaStrategy = _ctx.StringValue("DescribeDnsGtmAccessStrategy.DefaultLbaStrategy");
			describeDnsGtmAccessStrategyResponse.DefaultMinAvailableAddrNum = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.DefaultMinAvailableAddrNum");
			describeDnsGtmAccessStrategyResponse.DefaultMaxReturnAddrNum = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.DefaultMaxReturnAddrNum");
			describeDnsGtmAccessStrategyResponse.DefaultLatencyOptimization = _ctx.StringValue("DescribeDnsGtmAccessStrategy.DefaultLatencyOptimization");
			describeDnsGtmAccessStrategyResponse.DefaultAddrPoolGroupStatus = _ctx.StringValue("DescribeDnsGtmAccessStrategy.DefaultAddrPoolGroupStatus");
			describeDnsGtmAccessStrategyResponse.FailoverAddrPoolType = _ctx.StringValue("DescribeDnsGtmAccessStrategy.FailoverAddrPoolType");
			describeDnsGtmAccessStrategyResponse.FailoverLbaStrategy = _ctx.StringValue("DescribeDnsGtmAccessStrategy.FailoverLbaStrategy");
			describeDnsGtmAccessStrategyResponse.FailoverMinAvailableAddrNum = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.FailoverMinAvailableAddrNum");
			describeDnsGtmAccessStrategyResponse.FailoverMaxReturnAddrNum = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.FailoverMaxReturnAddrNum");
			describeDnsGtmAccessStrategyResponse.FailoverLatencyOptimization = _ctx.StringValue("DescribeDnsGtmAccessStrategy.FailoverLatencyOptimization");
			describeDnsGtmAccessStrategyResponse.FailoverAddrPoolGroupStatus = _ctx.StringValue("DescribeDnsGtmAccessStrategy.FailoverAddrPoolGroupStatus");
			describeDnsGtmAccessStrategyResponse.AccessMode = _ctx.StringValue("DescribeDnsGtmAccessStrategy.AccessMode");
			describeDnsGtmAccessStrategyResponse.EffectiveAddrPoolGroupType = _ctx.StringValue("DescribeDnsGtmAccessStrategy.EffectiveAddrPoolGroupType");
			describeDnsGtmAccessStrategyResponse.CreateTime = _ctx.StringValue("DescribeDnsGtmAccessStrategy.CreateTime");
			describeDnsGtmAccessStrategyResponse.CreateTimestamp = _ctx.LongValue("DescribeDnsGtmAccessStrategy.CreateTimestamp");
			describeDnsGtmAccessStrategyResponse.DefaultAvailableAddrNum = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.DefaultAvailableAddrNum");
			describeDnsGtmAccessStrategyResponse.FailoverAvailableAddrNum = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.FailoverAvailableAddrNum");

			List<DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_Line> describeDnsGtmAccessStrategyResponse_lines = new List<DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_Line>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategy.Lines.Length"); i++) {
				DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_Line line = new DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_Line();
				line.LineCode = _ctx.StringValue("DescribeDnsGtmAccessStrategy.Lines["+ i +"].LineCode");
				line.LineName = _ctx.StringValue("DescribeDnsGtmAccessStrategy.Lines["+ i +"].LineName");
				line.GroupCode = _ctx.StringValue("DescribeDnsGtmAccessStrategy.Lines["+ i +"].GroupCode");
				line.GroupName = _ctx.StringValue("DescribeDnsGtmAccessStrategy.Lines["+ i +"].GroupName");

				describeDnsGtmAccessStrategyResponse_lines.Add(line);
			}
			describeDnsGtmAccessStrategyResponse.Lines = describeDnsGtmAccessStrategyResponse_lines;

			List<DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_DefaultAddrPool> describeDnsGtmAccessStrategyResponse_defaultAddrPools = new List<DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_DefaultAddrPool>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategy.DefaultAddrPools.Length"); i++) {
				DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_DefaultAddrPool defaultAddrPool = new DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_DefaultAddrPool();
				defaultAddrPool.Id = _ctx.StringValue("DescribeDnsGtmAccessStrategy.DefaultAddrPools["+ i +"].Id");
				defaultAddrPool.Name = _ctx.StringValue("DescribeDnsGtmAccessStrategy.DefaultAddrPools["+ i +"].Name");
				defaultAddrPool.AddrCount = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.DefaultAddrPools["+ i +"].AddrCount");
				defaultAddrPool.LbaWeight = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.DefaultAddrPools["+ i +"].LbaWeight");

				describeDnsGtmAccessStrategyResponse_defaultAddrPools.Add(defaultAddrPool);
			}
			describeDnsGtmAccessStrategyResponse.DefaultAddrPools = describeDnsGtmAccessStrategyResponse_defaultAddrPools;

			List<DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_FailoverAddrPool> describeDnsGtmAccessStrategyResponse_failoverAddrPools = new List<DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_FailoverAddrPool>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategy.FailoverAddrPools.Length"); i++) {
				DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_FailoverAddrPool failoverAddrPool = new DescribeDnsGtmAccessStrategyResponse.DescribeDnsGtmAccessStrategy_FailoverAddrPool();
				failoverAddrPool.Id = _ctx.StringValue("DescribeDnsGtmAccessStrategy.FailoverAddrPools["+ i +"].Id");
				failoverAddrPool.Name = _ctx.StringValue("DescribeDnsGtmAccessStrategy.FailoverAddrPools["+ i +"].Name");
				failoverAddrPool.AddrCount = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.FailoverAddrPools["+ i +"].AddrCount");
				failoverAddrPool.LbaWeight = _ctx.IntegerValue("DescribeDnsGtmAccessStrategy.FailoverAddrPools["+ i +"].LbaWeight");

				describeDnsGtmAccessStrategyResponse_failoverAddrPools.Add(failoverAddrPool);
			}
			describeDnsGtmAccessStrategyResponse.FailoverAddrPools = describeDnsGtmAccessStrategyResponse_failoverAddrPools;
        
			return describeDnsGtmAccessStrategyResponse;
        }
    }
}
