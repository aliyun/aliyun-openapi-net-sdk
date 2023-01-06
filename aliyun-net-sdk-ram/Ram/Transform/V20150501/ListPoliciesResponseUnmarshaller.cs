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
    public class ListPoliciesResponseUnmarshaller
    {
        public static ListPoliciesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPoliciesResponse listPoliciesResponse = new ListPoliciesResponse();

			listPoliciesResponse.HttpResponse = _ctx.HttpResponse;
			listPoliciesResponse.RequestId = _ctx.StringValue("ListPolicies.RequestId");
			listPoliciesResponse.IsTruncated = _ctx.BooleanValue("ListPolicies.IsTruncated");
			listPoliciesResponse.Marker = _ctx.StringValue("ListPolicies.Marker");

			List<ListPoliciesResponse.ListPolicies_Policy> listPoliciesResponse_policies = new List<ListPoliciesResponse.ListPolicies_Policy>();
			for (int i = 0; i < _ctx.Length("ListPolicies.Policies.Length"); i++) {
				ListPoliciesResponse.ListPolicies_Policy policy = new ListPoliciesResponse.ListPolicies_Policy();
				policy.DefaultVersion = _ctx.StringValue("ListPolicies.Policies["+ i +"].DefaultVersion");
				policy.Description = _ctx.StringValue("ListPolicies.Policies["+ i +"].Description");
				policy.UpdateDate = _ctx.StringValue("ListPolicies.Policies["+ i +"].UpdateDate");
				policy.AttachmentCount = _ctx.IntegerValue("ListPolicies.Policies["+ i +"].AttachmentCount");
				policy.PolicyName = _ctx.StringValue("ListPolicies.Policies["+ i +"].PolicyName");
				policy.CreateDate = _ctx.StringValue("ListPolicies.Policies["+ i +"].CreateDate");
				policy.PolicyType = _ctx.StringValue("ListPolicies.Policies["+ i +"].PolicyType");

				listPoliciesResponse_policies.Add(policy);
			}
			listPoliciesResponse.Policies = listPoliciesResponse_policies;
        
			return listPoliciesResponse;
        }
    }
}
