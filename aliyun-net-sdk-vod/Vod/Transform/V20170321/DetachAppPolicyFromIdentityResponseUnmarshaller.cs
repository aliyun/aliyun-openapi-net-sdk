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
    public class DetachAppPolicyFromIdentityResponseUnmarshaller
    {
        public static DetachAppPolicyFromIdentityResponse Unmarshall(UnmarshallerContext context)
        {
			DetachAppPolicyFromIdentityResponse detachAppPolicyFromIdentityResponse = new DetachAppPolicyFromIdentityResponse();

			detachAppPolicyFromIdentityResponse.HttpResponse = context.HttpResponse;
			detachAppPolicyFromIdentityResponse.RequestId = context.StringValue("DetachAppPolicyFromIdentity.RequestId");

			List<string> detachAppPolicyFromIdentityResponse_nonExistPolicyNames = new List<string>();
			for (int i = 0; i < context.Length("DetachAppPolicyFromIdentity.NonExistPolicyNames.Length"); i++) {
				detachAppPolicyFromIdentityResponse_nonExistPolicyNames.Add(context.StringValue("DetachAppPolicyFromIdentity.NonExistPolicyNames["+ i +"]"));
			}
			detachAppPolicyFromIdentityResponse.NonExistPolicyNames = detachAppPolicyFromIdentityResponse_nonExistPolicyNames;

			List<string> detachAppPolicyFromIdentityResponse_failedPolicyNames = new List<string>();
			for (int i = 0; i < context.Length("DetachAppPolicyFromIdentity.FailedPolicyNames.Length"); i++) {
				detachAppPolicyFromIdentityResponse_failedPolicyNames.Add(context.StringValue("DetachAppPolicyFromIdentity.FailedPolicyNames["+ i +"]"));
			}
			detachAppPolicyFromIdentityResponse.FailedPolicyNames = detachAppPolicyFromIdentityResponse_failedPolicyNames;
        
			return detachAppPolicyFromIdentityResponse;
        }
    }
}
