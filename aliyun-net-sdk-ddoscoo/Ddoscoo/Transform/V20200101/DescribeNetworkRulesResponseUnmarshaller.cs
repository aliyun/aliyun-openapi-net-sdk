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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeNetworkRulesResponseUnmarshaller
    {
        public static DescribeNetworkRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNetworkRulesResponse describeNetworkRulesResponse = new DescribeNetworkRulesResponse();

			describeNetworkRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeNetworkRulesResponse.RequestId = _ctx.StringValue("DescribeNetworkRules.RequestId");
			describeNetworkRulesResponse.TotalCount = _ctx.LongValue("DescribeNetworkRules.TotalCount");

			List<DescribeNetworkRulesResponse.DescribeNetworkRules_NetworkRule> describeNetworkRulesResponse_networkRules = new List<DescribeNetworkRulesResponse.DescribeNetworkRules_NetworkRule>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkRules.NetworkRules.Length"); i++) {
				DescribeNetworkRulesResponse.DescribeNetworkRules_NetworkRule networkRule = new DescribeNetworkRulesResponse.DescribeNetworkRules_NetworkRule();
				networkRule.InstanceId = _ctx.StringValue("DescribeNetworkRules.NetworkRules["+ i +"].InstanceId");
				networkRule.Protocol = _ctx.StringValue("DescribeNetworkRules.NetworkRules["+ i +"].Protocol");
				networkRule.FrontendPort = _ctx.IntegerValue("DescribeNetworkRules.NetworkRules["+ i +"].FrontendPort");
				networkRule.BackendPort = _ctx.IntegerValue("DescribeNetworkRules.NetworkRules["+ i +"].BackendPort");
				networkRule.IsAutoCreate = _ctx.BooleanValue("DescribeNetworkRules.NetworkRules["+ i +"].IsAutoCreate");

				List<string> networkRule_realServers = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeNetworkRules.NetworkRules["+ i +"].RealServers.Length"); j++) {
					networkRule_realServers.Add(_ctx.StringValue("DescribeNetworkRules.NetworkRules["+ i +"].RealServers["+ j +"]"));
				}
				networkRule.RealServers = networkRule_realServers;

				describeNetworkRulesResponse_networkRules.Add(networkRule);
			}
			describeNetworkRulesResponse.NetworkRules = describeNetworkRulesResponse_networkRules;
        
			return describeNetworkRulesResponse;
        }
    }
}
