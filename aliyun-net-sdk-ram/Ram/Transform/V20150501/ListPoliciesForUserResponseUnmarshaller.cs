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
    public class ListPoliciesForUserResponseUnmarshaller
    {
        public static ListPoliciesForUserResponse Unmarshall(UnmarshallerContext context)
        {
            ListPoliciesForUserResponse listPoliciesForUserResponse = new ListPoliciesForUserResponse();

            listPoliciesForUserResponse.HttpResponse = context.HttpResponse;
            listPoliciesForUserResponse.RequestId = context.StringValue("ListPoliciesForUser.RequestId");

            List<ListPoliciesForUserResponse.ListPoliciesForUser_Policy> listPoliciesForUserResponse_policies = new List<ListPoliciesForUserResponse.ListPoliciesForUser_Policy>();
            for (int i = 0; i < context.Length("ListPoliciesForUser.Policies.Length"); i++)
            {
                ListPoliciesForUserResponse.ListPoliciesForUser_Policy policy = new ListPoliciesForUserResponse.ListPoliciesForUser_Policy();
                policy.PolicyName = context.StringValue("ListPoliciesForUser.Policies[" + i + "].PolicyName");
                policy.PolicyType = context.StringValue("ListPoliciesForUser.Policies[" + i + "].PolicyType");
                policy.Description = context.StringValue("ListPoliciesForUser.Policies[" + i + "].Description");
                policy.DefaultVersion = context.StringValue("ListPoliciesForUser.Policies[" + i + "].DefaultVersion");
                policy.AttachDate = context.StringValue("ListPoliciesForUser.Policies[" + i + "].AttachDate");

                listPoliciesForUserResponse_policies.Add(policy);
            }
            listPoliciesForUserResponse.Policies = listPoliciesForUserResponse_policies;

            return listPoliciesForUserResponse;
        }
    }
}
