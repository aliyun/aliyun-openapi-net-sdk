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
    public class DescribePortResponseUnmarshaller
    {
        public static DescribePortResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePortResponse describePortResponse = new DescribePortResponse();

			describePortResponse.HttpResponse = _ctx.HttpResponse;
			describePortResponse.RequestId = _ctx.StringValue("DescribePort.RequestId");
			describePortResponse.TotalCount = _ctx.LongValue("DescribePort.TotalCount");

			List<DescribePortResponse.DescribePort_NetworkRule> describePortResponse_networkRules = new List<DescribePortResponse.DescribePort_NetworkRule>();
			for (int i = 0; i < _ctx.Length("DescribePort.NetworkRules.Length"); i++) {
				DescribePortResponse.DescribePort_NetworkRule networkRule = new DescribePortResponse.DescribePort_NetworkRule();
				networkRule.InstanceId = _ctx.StringValue("DescribePort.NetworkRules["+ i +"].InstanceId");
				networkRule.FrontendProtocol = _ctx.StringValue("DescribePort.NetworkRules["+ i +"].FrontendProtocol");
				networkRule.FrontendPort = _ctx.IntegerValue("DescribePort.NetworkRules["+ i +"].FrontendPort");
				networkRule.BackendPort = _ctx.IntegerValue("DescribePort.NetworkRules["+ i +"].BackendPort");
				networkRule.IsAutoCreate = _ctx.BooleanValue("DescribePort.NetworkRules["+ i +"].IsAutoCreate");

				List<string> networkRule_realServers = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePort.NetworkRules["+ i +"].RealServers.Length"); j++) {
					networkRule_realServers.Add(_ctx.StringValue("DescribePort.NetworkRules["+ i +"].RealServers["+ j +"]"));
				}
				networkRule.RealServers = networkRule_realServers;

				describePortResponse_networkRules.Add(networkRule);
			}
			describePortResponse.NetworkRules = describePortResponse_networkRules;
        
			return describePortResponse;
        }
    }
}
