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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeLifecyclePoliciesResponseUnmarshaller
    {
        public static DescribeLifecyclePoliciesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLifecyclePoliciesResponse describeLifecyclePoliciesResponse = new DescribeLifecyclePoliciesResponse();

			describeLifecyclePoliciesResponse.HttpResponse = _ctx.HttpResponse;
			describeLifecyclePoliciesResponse.TotalCount = _ctx.IntegerValue("DescribeLifecyclePolicies.TotalCount");
			describeLifecyclePoliciesResponse.PageSize = _ctx.IntegerValue("DescribeLifecyclePolicies.PageSize");
			describeLifecyclePoliciesResponse.RequestId = _ctx.StringValue("DescribeLifecyclePolicies.RequestId");
			describeLifecyclePoliciesResponse.PageNumber = _ctx.IntegerValue("DescribeLifecyclePolicies.PageNumber");

			List<DescribeLifecyclePoliciesResponse.DescribeLifecyclePolicies_LifecyclePolicy> describeLifecyclePoliciesResponse_lifecyclePolicies = new List<DescribeLifecyclePoliciesResponse.DescribeLifecyclePolicies_LifecyclePolicy>();
			for (int i = 0; i < _ctx.Length("DescribeLifecyclePolicies.LifecyclePolicies.Length"); i++) {
				DescribeLifecyclePoliciesResponse.DescribeLifecyclePolicies_LifecyclePolicy lifecyclePolicy = new DescribeLifecyclePoliciesResponse.DescribeLifecyclePolicies_LifecyclePolicy();
				lifecyclePolicy.Path = _ctx.StringValue("DescribeLifecyclePolicies.LifecyclePolicies["+ i +"].Path");
				lifecyclePolicy.LifecyclePolicyName = _ctx.StringValue("DescribeLifecyclePolicies.LifecyclePolicies["+ i +"].LifecyclePolicyName");
				lifecyclePolicy.StorageType = _ctx.StringValue("DescribeLifecyclePolicies.LifecyclePolicies["+ i +"].StorageType");
				lifecyclePolicy.LifecycleRuleName = _ctx.StringValue("DescribeLifecyclePolicies.LifecyclePolicies["+ i +"].LifecycleRuleName");
				lifecyclePolicy.CreateTime = _ctx.StringValue("DescribeLifecyclePolicies.LifecyclePolicies["+ i +"].CreateTime");
				lifecyclePolicy.FileSystemId = _ctx.StringValue("DescribeLifecyclePolicies.LifecyclePolicies["+ i +"].FileSystemId");

				List<string> lifecyclePolicy_paths = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeLifecyclePolicies.LifecyclePolicies["+ i +"].Paths.Length"); j++) {
					lifecyclePolicy_paths.Add(_ctx.StringValue("DescribeLifecyclePolicies.LifecyclePolicies["+ i +"].Paths["+ j +"]"));
				}
				lifecyclePolicy.Paths = lifecyclePolicy_paths;

				describeLifecyclePoliciesResponse_lifecyclePolicies.Add(lifecyclePolicy);
			}
			describeLifecyclePoliciesResponse.LifecyclePolicies = describeLifecyclePoliciesResponse_lifecyclePolicies;
        
			return describeLifecyclePoliciesResponse;
        }
    }
}
