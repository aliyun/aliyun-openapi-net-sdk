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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDampPoliciesByCidResponseUnmarshaller
    {
        public static DescribeDampPoliciesByCidResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDampPoliciesByCidResponse describeDampPoliciesByCidResponse = new DescribeDampPoliciesByCidResponse();

			describeDampPoliciesByCidResponse.HttpResponse = context.HttpResponse;
			describeDampPoliciesByCidResponse.RequestId = context.StringValue("DescribeDampPoliciesByCid.RequestId");

			List<DescribeDampPoliciesByCidResponse.Policy> policies = new List<DescribeDampPoliciesByCidResponse.Policy>();
			for (int i = 0; i < context.Length("DescribeDampPoliciesByCid.Policies.Length"); i++) {
				DescribeDampPoliciesByCidResponse.Policy policy = new DescribeDampPoliciesByCidResponse.Policy();
				policy.PolicyName = context.StringValue("DescribeDampPoliciesByCid.Policies["+ i +"].PolicyName");
				policy.Comment = context.StringValue("DescribeDampPoliciesByCid.Policies["+ i +"].Comment");

				policies.Add(policy);
			}
			describeDampPoliciesByCidResponse.Policies = policies;
        
			return describeDampPoliciesByCidResponse;
        }
    }
}