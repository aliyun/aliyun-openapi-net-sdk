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
        public static ListAppPoliciesForIdentityResponse Unmarshall(UnmarshallerContext context)
        {
			ListAppPoliciesForIdentityResponse listAppPoliciesForIdentityResponse = new ListAppPoliciesForIdentityResponse();

			listAppPoliciesForIdentityResponse.HttpResponse = context.HttpResponse;
			listAppPoliciesForIdentityResponse.RequestId = context.StringValue("ListAppPoliciesForIdentity.RequestId");

			List<ListAppPoliciesForIdentityResponse.ListAppPoliciesForIdentity_AppPolicy> listAppPoliciesForIdentityResponse_appPolicyList = new List<ListAppPoliciesForIdentityResponse.ListAppPoliciesForIdentity_AppPolicy>();
			for (int i = 0; i < context.Length("ListAppPoliciesForIdentity.AppPolicyList.Length"); i++) {
				ListAppPoliciesForIdentityResponse.ListAppPoliciesForIdentity_AppPolicy appPolicy = new ListAppPoliciesForIdentityResponse.ListAppPoliciesForIdentity_AppPolicy();
				appPolicy.AppId = context.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].AppId");
				appPolicy.CreationTime = context.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].CreationTime");
				appPolicy.PolicyName = context.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].PolicyName");
				appPolicy.PolicyType = context.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].PolicyType");
				appPolicy.PolicyValue = context.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].PolicyValue");
				appPolicy.Description = context.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].Description");
				appPolicy.ModificationTime = context.StringValue("ListAppPoliciesForIdentity.AppPolicyList["+ i +"].ModificationTime");

				listAppPoliciesForIdentityResponse_appPolicyList.Add(appPolicy);
			}
			listAppPoliciesForIdentityResponse.AppPolicyList = listAppPoliciesForIdentityResponse_appPolicyList;
        
			return listAppPoliciesForIdentityResponse;
        }
    }
}
