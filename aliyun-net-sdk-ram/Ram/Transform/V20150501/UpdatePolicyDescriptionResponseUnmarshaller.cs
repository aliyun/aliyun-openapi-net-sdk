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
    public class UpdatePolicyDescriptionResponseUnmarshaller
    {
        public static UpdatePolicyDescriptionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdatePolicyDescriptionResponse updatePolicyDescriptionResponse = new UpdatePolicyDescriptionResponse();

			updatePolicyDescriptionResponse.HttpResponse = _ctx.HttpResponse;
			updatePolicyDescriptionResponse.RequestId = _ctx.StringValue("UpdatePolicyDescription.RequestId");

			UpdatePolicyDescriptionResponse.UpdatePolicyDescription_Policy policy = new UpdatePolicyDescriptionResponse.UpdatePolicyDescription_Policy();
			policy.PolicyName = _ctx.StringValue("UpdatePolicyDescription.Policy.PolicyName");
			policy.PolicyType = _ctx.StringValue("UpdatePolicyDescription.Policy.PolicyType");
			policy.CreateDate = _ctx.StringValue("UpdatePolicyDescription.Policy.CreateDate");
			policy.UpdateDate = _ctx.StringValue("UpdatePolicyDescription.Policy.UpdateDate");
			policy.Description = _ctx.StringValue("UpdatePolicyDescription.Policy.Description");
			policy.DefaultVersion = _ctx.StringValue("UpdatePolicyDescription.Policy.DefaultVersion");
			updatePolicyDescriptionResponse.Policy = policy;
        
			return updatePolicyDescriptionResponse;
        }
    }
}
