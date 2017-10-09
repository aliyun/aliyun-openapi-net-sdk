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
using Aliyun.Acs.Ram.Model.V20150501;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class CreatePolicyResponseUnmarshaller
    {
        public static CreatePolicyResponse Unmarshall(UnmarshallerContext context)
        {
			CreatePolicyResponse createPolicyResponse = new CreatePolicyResponse();

			createPolicyResponse.HttpResponse = context.HttpResponse;
			createPolicyResponse.RequestId = context.StringValue("CreatePolicy.RequestId");

			CreatePolicyResponse.CreatePolicy_Policy policy = new CreatePolicyResponse.CreatePolicy_Policy();
			policy.PolicyName = context.StringValue("CreatePolicy.Policy.PolicyName");
			policy.PolicyType = context.StringValue("CreatePolicy.Policy.PolicyType");
			policy.Description = context.StringValue("CreatePolicy.Policy.Description");
			policy.DefaultVersion = context.StringValue("CreatePolicy.Policy.DefaultVersion");
			policy.CreateDate = context.StringValue("CreatePolicy.Policy.CreateDate");
			createPolicyResponse.Policy = policy;
        
			return createPolicyResponse;
        }
    }
}