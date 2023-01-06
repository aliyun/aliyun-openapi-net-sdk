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
using Aliyun.Acs.Ram.Model.V20150501;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class GetPolicyResponseUnmarshaller
    {
        public static GetPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPolicyResponse getPolicyResponse = new GetPolicyResponse();

			getPolicyResponse.HttpResponse = _ctx.HttpResponse;
			getPolicyResponse.RequestId = _ctx.StringValue("GetPolicy.RequestId");

			GetPolicyResponse.GetPolicy_Policy policy = new GetPolicyResponse.GetPolicy_Policy();
			policy.DefaultVersion = _ctx.StringValue("GetPolicy.Policy.DefaultVersion");
			policy.UpdateDate = _ctx.StringValue("GetPolicy.Policy.UpdateDate");
			policy.Description = _ctx.StringValue("GetPolicy.Policy.Description");
			policy.PolicyDocument = _ctx.StringValue("GetPolicy.Policy.PolicyDocument");
			policy.AttachmentCount = _ctx.IntegerValue("GetPolicy.Policy.AttachmentCount");
			policy.PolicyName = _ctx.StringValue("GetPolicy.Policy.PolicyName");
			policy.CreateDate = _ctx.StringValue("GetPolicy.Policy.CreateDate");
			policy.PolicyType = _ctx.StringValue("GetPolicy.Policy.PolicyType");
			getPolicyResponse.Policy = policy;

			GetPolicyResponse.GetPolicy_DefaultPolicyVersion defaultPolicyVersion = new GetPolicyResponse.GetPolicy_DefaultPolicyVersion();
			defaultPolicyVersion.IsDefaultVersion = _ctx.BooleanValue("GetPolicy.DefaultPolicyVersion.IsDefaultVersion");
			defaultPolicyVersion.PolicyDocument = _ctx.StringValue("GetPolicy.DefaultPolicyVersion.PolicyDocument");
			defaultPolicyVersion.VersionId = _ctx.StringValue("GetPolicy.DefaultPolicyVersion.VersionId");
			defaultPolicyVersion.CreateDate = _ctx.StringValue("GetPolicy.DefaultPolicyVersion.CreateDate");
			getPolicyResponse.DefaultPolicyVersion = defaultPolicyVersion;
        
			return getPolicyResponse;
        }
    }
}
