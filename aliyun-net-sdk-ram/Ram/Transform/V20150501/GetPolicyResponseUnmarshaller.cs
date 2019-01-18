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
    public class GetPolicyResponseUnmarshaller
    {
        public static GetPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			GetPolicyResponse getPolicyResponse = new GetPolicyResponse();

			getPolicyResponse.HttpResponse = context.HttpResponse;
			getPolicyResponse.RequestId = context.StringValue("GetPolicy.RequestId");

			GetPolicyResponse.GetPolicy_Policy policy = new GetPolicyResponse.GetPolicy_Policy();
			policy.PolicyName = context.StringValue("GetPolicy.Policy.PolicyName");
			policy.PolicyType = context.StringValue("GetPolicy.Policy.PolicyType");
			policy.Description = context.StringValue("GetPolicy.Policy.Description");
			policy.DefaultVersion = context.StringValue("GetPolicy.Policy.DefaultVersion");
			policy.PolicyDocument = context.StringValue("GetPolicy.Policy.PolicyDocument");
			policy.CreateDate = context.StringValue("GetPolicy.Policy.CreateDate");
			policy.UpdateDate = context.StringValue("GetPolicy.Policy.UpdateDate");
			policy.AttachmentCount = context.IntegerValue("GetPolicy.Policy.AttachmentCount");
			getPolicyResponse.Policy = policy;
        
			return getPolicyResponse;
        }
    }
}