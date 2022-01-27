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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class ListTrafficMarkingPoliciesResponseUnmarshaller
    {
        public static ListTrafficMarkingPoliciesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTrafficMarkingPoliciesResponse listTrafficMarkingPoliciesResponse = new ListTrafficMarkingPoliciesResponse();

			listTrafficMarkingPoliciesResponse.HttpResponse = _ctx.HttpResponse;
			listTrafficMarkingPoliciesResponse.NextToken = _ctx.StringValue("ListTrafficMarkingPolicies.NextToken");
			listTrafficMarkingPoliciesResponse.RequestId = _ctx.StringValue("ListTrafficMarkingPolicies.RequestId");
			listTrafficMarkingPoliciesResponse.TotalCount = _ctx.IntegerValue("ListTrafficMarkingPolicies.TotalCount");
			listTrafficMarkingPoliciesResponse.MaxResults = _ctx.IntegerValue("ListTrafficMarkingPolicies.MaxResults");

			List<ListTrafficMarkingPoliciesResponse.ListTrafficMarkingPolicies_TrafficMarkingPolicy> listTrafficMarkingPoliciesResponse_trafficMarkingPolicies = new List<ListTrafficMarkingPoliciesResponse.ListTrafficMarkingPolicies_TrafficMarkingPolicy>();
			for (int i = 0; i < _ctx.Length("ListTrafficMarkingPolicies.TrafficMarkingPolicies.Length"); i++) {
				ListTrafficMarkingPoliciesResponse.ListTrafficMarkingPolicies_TrafficMarkingPolicy trafficMarkingPolicy = new ListTrafficMarkingPoliciesResponse.ListTrafficMarkingPolicies_TrafficMarkingPolicy();
				trafficMarkingPolicy.TrafficMarkingPolicyStatus = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMarkingPolicyStatus");
				trafficMarkingPolicy.TrafficMarkingPolicyId = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMarkingPolicyId");
				trafficMarkingPolicy.MarkingDscp = _ctx.IntegerValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].MarkingDscp");
				trafficMarkingPolicy.TrafficMarkingPolicyName = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMarkingPolicyName");
				trafficMarkingPolicy.Priority = _ctx.IntegerValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].Priority");
				trafficMarkingPolicy.TrafficMarkingPolicyDescription = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMarkingPolicyDescription");

				List<ListTrafficMarkingPoliciesResponse.ListTrafficMarkingPolicies_TrafficMarkingPolicy.ListTrafficMarkingPolicies_TrafficMatchRule> trafficMarkingPolicy_trafficMatchRules = new List<ListTrafficMarkingPoliciesResponse.ListTrafficMarkingPolicies_TrafficMarkingPolicy.ListTrafficMarkingPolicies_TrafficMatchRule>();
				for (int j = 0; j < _ctx.Length("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules.Length"); j++) {
					ListTrafficMarkingPoliciesResponse.ListTrafficMarkingPolicies_TrafficMarkingPolicy.ListTrafficMarkingPolicies_TrafficMatchRule trafficMatchRule = new ListTrafficMarkingPoliciesResponse.ListTrafficMarkingPolicies_TrafficMarkingPolicy.ListTrafficMarkingPolicies_TrafficMatchRule();
					trafficMatchRule.MatchDscp = _ctx.IntegerValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].MatchDscp");
					trafficMatchRule.DstCidr = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].DstCidr");
					trafficMatchRule.TrafficMatchRuleDescription = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].TrafficMatchRuleDescription");
					trafficMatchRule.Protocol = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].Protocol");
					trafficMatchRule.TrafficMatchRuleId = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].TrafficMatchRuleId");
					trafficMatchRule.SrcCidr = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].SrcCidr");
					trafficMatchRule.TrafficMatchRuleName = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].TrafficMatchRuleName");
					trafficMatchRule.TrafficMatchRuleStatus = _ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].TrafficMatchRuleStatus");

					List<string> trafficMatchRule_dstPortRange = new List<string>();
					for (int k = 0; k < _ctx.Length("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].DstPortRange.Length"); k++) {
						trafficMatchRule_dstPortRange.Add(_ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].DstPortRange["+ k +"]"));
					}
					trafficMatchRule.DstPortRange = trafficMatchRule_dstPortRange;

					List<string> trafficMatchRule_srcPortRange = new List<string>();
					for (int k = 0; k < _ctx.Length("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].SrcPortRange.Length"); k++) {
						trafficMatchRule_srcPortRange.Add(_ctx.StringValue("ListTrafficMarkingPolicies.TrafficMarkingPolicies["+ i +"].TrafficMatchRules["+ j +"].SrcPortRange["+ k +"]"));
					}
					trafficMatchRule.SrcPortRange = trafficMatchRule_srcPortRange;

					trafficMarkingPolicy_trafficMatchRules.Add(trafficMatchRule);
				}
				trafficMarkingPolicy.TrafficMatchRules = trafficMarkingPolicy_trafficMatchRules;

				listTrafficMarkingPoliciesResponse_trafficMarkingPolicies.Add(trafficMarkingPolicy);
			}
			listTrafficMarkingPoliciesResponse.TrafficMarkingPolicies = listTrafficMarkingPoliciesResponse_trafficMarkingPolicies;
        
			return listTrafficMarkingPoliciesResponse;
        }
    }
}
