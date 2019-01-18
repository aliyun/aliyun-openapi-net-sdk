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
    public class ListPoliciesForRoleResponseUnmarshaller
    {
        public static ListPoliciesForRoleResponse Unmarshall(UnmarshallerContext context)
        {
			ListPoliciesForRoleResponse listPoliciesForRoleResponse = new ListPoliciesForRoleResponse();

			listPoliciesForRoleResponse.HttpResponse = context.HttpResponse;
			listPoliciesForRoleResponse.RequestId = context.StringValue("ListPoliciesForRole.RequestId");

			List<ListPoliciesForRoleResponse.ListPoliciesForRole_Policy> listPoliciesForRoleResponse_policies = new List<ListPoliciesForRoleResponse.ListPoliciesForRole_Policy>();
			for (int i = 0; i < context.Length("ListPoliciesForRole.Policies.Length"); i++) {
				ListPoliciesForRoleResponse.ListPoliciesForRole_Policy policy = new ListPoliciesForRoleResponse.ListPoliciesForRole_Policy();
				policy.PolicyName = context.StringValue("ListPoliciesForRole.Policies["+ i +"].PolicyName");
				policy.PolicyType = context.StringValue("ListPoliciesForRole.Policies["+ i +"].PolicyType");
				policy.Description = context.StringValue("ListPoliciesForRole.Policies["+ i +"].Description");
				policy.DefaultVersion = context.StringValue("ListPoliciesForRole.Policies["+ i +"].DefaultVersion");
				policy.AttachDate = context.StringValue("ListPoliciesForRole.Policies["+ i +"].AttachDate");

				listPoliciesForRoleResponse_policies.Add(policy);
			}
			listPoliciesForRoleResponse.Policies = listPoliciesForRoleResponse_policies;
        
			return listPoliciesForRoleResponse;
        }
    }
}