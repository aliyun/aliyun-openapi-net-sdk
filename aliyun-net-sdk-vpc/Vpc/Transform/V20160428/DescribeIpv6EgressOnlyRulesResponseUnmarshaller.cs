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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeIpv6EgressOnlyRulesResponseUnmarshaller
    {
        public static DescribeIpv6EgressOnlyRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpv6EgressOnlyRulesResponse describeIpv6EgressOnlyRulesResponse = new DescribeIpv6EgressOnlyRulesResponse();

			describeIpv6EgressOnlyRulesResponse.HttpResponse = context.HttpResponse;
			describeIpv6EgressOnlyRulesResponse.RequestId = context.StringValue("DescribeIpv6EgressOnlyRules.RequestId");
			describeIpv6EgressOnlyRulesResponse.TotalCount = context.IntegerValue("DescribeIpv6EgressOnlyRules.TotalCount");
			describeIpv6EgressOnlyRulesResponse.PageNumber = context.IntegerValue("DescribeIpv6EgressOnlyRules.PageNumber");
			describeIpv6EgressOnlyRulesResponse.PageSize = context.IntegerValue("DescribeIpv6EgressOnlyRules.PageSize");

			List<DescribeIpv6EgressOnlyRulesResponse.DescribeIpv6EgressOnlyRules_Ipv6EgressOnlyRule> describeIpv6EgressOnlyRulesResponse_ipv6EgressOnlyRules = new List<DescribeIpv6EgressOnlyRulesResponse.DescribeIpv6EgressOnlyRules_Ipv6EgressOnlyRule>();
			for (int i = 0; i < context.Length("DescribeIpv6EgressOnlyRules.Ipv6EgressOnlyRules.Length"); i++) {
				DescribeIpv6EgressOnlyRulesResponse.DescribeIpv6EgressOnlyRules_Ipv6EgressOnlyRule ipv6EgressOnlyRule = new DescribeIpv6EgressOnlyRulesResponse.DescribeIpv6EgressOnlyRules_Ipv6EgressOnlyRule();
				ipv6EgressOnlyRule.Ipv6EgressOnlyRuleId = context.StringValue("DescribeIpv6EgressOnlyRules.Ipv6EgressOnlyRules["+ i +"].Ipv6EgressOnlyRuleId");
				ipv6EgressOnlyRule.InstanceType = context.StringValue("DescribeIpv6EgressOnlyRules.Ipv6EgressOnlyRules["+ i +"].InstanceType");
				ipv6EgressOnlyRule.InstanceId = context.StringValue("DescribeIpv6EgressOnlyRules.Ipv6EgressOnlyRules["+ i +"].InstanceId");
				ipv6EgressOnlyRule.Status = context.StringValue("DescribeIpv6EgressOnlyRules.Ipv6EgressOnlyRules["+ i +"].Status");
				ipv6EgressOnlyRule.Name = context.StringValue("DescribeIpv6EgressOnlyRules.Ipv6EgressOnlyRules["+ i +"].Name");
				ipv6EgressOnlyRule.Description = context.StringValue("DescribeIpv6EgressOnlyRules.Ipv6EgressOnlyRules["+ i +"].Description");

				describeIpv6EgressOnlyRulesResponse_ipv6EgressOnlyRules.Add(ipv6EgressOnlyRule);
			}
			describeIpv6EgressOnlyRulesResponse.Ipv6EgressOnlyRules = describeIpv6EgressOnlyRulesResponse_ipv6EgressOnlyRules;
        
			return describeIpv6EgressOnlyRulesResponse;
        }
    }
}
