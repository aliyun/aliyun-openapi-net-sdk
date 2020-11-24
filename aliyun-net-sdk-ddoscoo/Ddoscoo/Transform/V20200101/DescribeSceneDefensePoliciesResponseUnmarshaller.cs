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
    public class DescribeSceneDefensePoliciesResponseUnmarshaller
    {
        public static DescribeSceneDefensePoliciesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSceneDefensePoliciesResponse describeSceneDefensePoliciesResponse = new DescribeSceneDefensePoliciesResponse();

			describeSceneDefensePoliciesResponse.HttpResponse = _ctx.HttpResponse;
			describeSceneDefensePoliciesResponse.RequestId = _ctx.StringValue("DescribeSceneDefensePolicies.RequestId");
			describeSceneDefensePoliciesResponse.Success = _ctx.BooleanValue("DescribeSceneDefensePolicies.Success");

			List<DescribeSceneDefensePoliciesResponse.DescribeSceneDefensePolicies_Policy> describeSceneDefensePoliciesResponse_policies = new List<DescribeSceneDefensePoliciesResponse.DescribeSceneDefensePolicies_Policy>();
			for (int i = 0; i < _ctx.Length("DescribeSceneDefensePolicies.Policies.Length"); i++) {
				DescribeSceneDefensePoliciesResponse.DescribeSceneDefensePolicies_Policy policy = new DescribeSceneDefensePoliciesResponse.DescribeSceneDefensePolicies_Policy();
				policy.PolicyId = _ctx.StringValue("DescribeSceneDefensePolicies.Policies["+ i +"].PolicyId");
				policy.Name = _ctx.StringValue("DescribeSceneDefensePolicies.Policies["+ i +"].Name");
				policy.Template = _ctx.StringValue("DescribeSceneDefensePolicies.Policies["+ i +"].Template");
				policy.StartTime = _ctx.LongValue("DescribeSceneDefensePolicies.Policies["+ i +"].StartTime");
				policy.EndTime = _ctx.LongValue("DescribeSceneDefensePolicies.Policies["+ i +"].EndTime");
				policy.Status = _ctx.IntegerValue("DescribeSceneDefensePolicies.Policies["+ i +"].Status");
				policy.Done = _ctx.IntegerValue("DescribeSceneDefensePolicies.Policies["+ i +"].Done");
				policy.ObjectCount = _ctx.IntegerValue("DescribeSceneDefensePolicies.Policies["+ i +"].ObjectCount");

				List<DescribeSceneDefensePoliciesResponse.DescribeSceneDefensePolicies_Policy.DescribeSceneDefensePolicies_Policy1> policy_runtimePolicies = new List<DescribeSceneDefensePoliciesResponse.DescribeSceneDefensePolicies_Policy.DescribeSceneDefensePolicies_Policy1>();
				for (int j = 0; j < _ctx.Length("DescribeSceneDefensePolicies.Policies["+ i +"].RuntimePolicies.Length"); j++) {
					DescribeSceneDefensePoliciesResponse.DescribeSceneDefensePolicies_Policy.DescribeSceneDefensePolicies_Policy1 policy1 = new DescribeSceneDefensePoliciesResponse.DescribeSceneDefensePolicies_Policy.DescribeSceneDefensePolicies_Policy1();
					policy1.PolicyType = _ctx.IntegerValue("DescribeSceneDefensePolicies.Policies["+ i +"].RuntimePolicies["+ j +"].PolicyType");
					policy1.Status = _ctx.IntegerValue("DescribeSceneDefensePolicies.Policies["+ i +"].RuntimePolicies["+ j +"].Status");
					policy1.OldValue = _ctx.StringValue("DescribeSceneDefensePolicies.Policies["+ i +"].RuntimePolicies["+ j +"].oldValue");
					policy1.NewValue = _ctx.StringValue("DescribeSceneDefensePolicies.Policies["+ i +"].RuntimePolicies["+ j +"].NewValue");

					policy_runtimePolicies.Add(policy1);
				}
				policy.RuntimePolicies = policy_runtimePolicies;

				describeSceneDefensePoliciesResponse_policies.Add(policy);
			}
			describeSceneDefensePoliciesResponse.Policies = describeSceneDefensePoliciesResponse_policies;
        
			return describeSceneDefensePoliciesResponse;
        }
    }
}
