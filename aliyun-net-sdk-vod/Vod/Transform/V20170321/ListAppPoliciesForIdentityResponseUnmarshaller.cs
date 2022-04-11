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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListAppPoliciesForIdentityResponseUnmarshaller
    {
        public static ListAppPoliciesForIdentityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppPoliciesForIdentityResponse listAppPoliciesForIdentityResponse = new ListAppPoliciesForIdentityResponse();

			listAppPoliciesForIdentityResponse.HttpResponse = _ctx.HttpResponse;
			listAppPoliciesForIdentityResponse.RequestId = _ctx.StringValue("ListAppPoliciesForIdentity.RequestId");

			List<ListAppPoliciesForIdentityResponse.ListAppPoliciesForIdentity_AppPolicy> listAppPoliciesForIdentityResponse_appPolicyList = new List<ListAppPoliciesForIdentityResponse.ListAppPoliciesForIdentity_AppPolicy>();
			for (int i = 0; i < _ctx.Length("ListAppPoliciesForIdentity.AppPolicyList.Length"); i++) {
				ListAppPoliciesForIdentityResponse.ListAppPoliciesForIdentity_AppPolicy appPolicy = new ListAppPoliciesForIdentityResponse.ListAppPoliciesForIdentity_AppPolicy();
				appPolicy.CreationTime = _ctx.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].CreationTime");
				appPolicy.Description = _ctx.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].Description");
				appPolicy.AppId = _ctx.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].AppId");
				appPolicy.PolicyValue = _ctx.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].PolicyValue");
				appPolicy.PolicyName = _ctx.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].PolicyName");
				appPolicy.ModificationTime = _ctx.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].ModificationTime");
				appPolicy.PolicyType = _ctx.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].PolicyType");

				listAppPoliciesForIdentityResponse_appPolicyList.Add(appPolicy);
			}
			listAppPoliciesForIdentityResponse.AppPolicyList = listAppPoliciesForIdentityResponse_appPolicyList;
        
			return listAppPoliciesForIdentityResponse;
        }
    }
}
