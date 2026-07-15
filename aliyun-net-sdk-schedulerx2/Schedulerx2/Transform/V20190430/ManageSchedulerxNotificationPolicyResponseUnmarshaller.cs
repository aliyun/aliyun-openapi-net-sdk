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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class ManageSchedulerxNotificationPolicyResponseUnmarshaller
    {
        public static ManageSchedulerxNotificationPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ManageSchedulerxNotificationPolicyResponse manageSchedulerxNotificationPolicyResponse = new ManageSchedulerxNotificationPolicyResponse();

			manageSchedulerxNotificationPolicyResponse.HttpResponse = _ctx.HttpResponse;
			manageSchedulerxNotificationPolicyResponse.Message = _ctx.StringValue("ManageSchedulerxNotificationPolicy.Message");
			manageSchedulerxNotificationPolicyResponse.RequestId = _ctx.StringValue("ManageSchedulerxNotificationPolicy.RequestId");
			manageSchedulerxNotificationPolicyResponse.Code = _ctx.IntegerValue("ManageSchedulerxNotificationPolicy.Code");
			manageSchedulerxNotificationPolicyResponse.Success = _ctx.BooleanValue("ManageSchedulerxNotificationPolicy.Success");

			ManageSchedulerxNotificationPolicyResponse.ManageSchedulerxNotificationPolicy_AccessDeniedDetail accessDeniedDetail = new ManageSchedulerxNotificationPolicyResponse.ManageSchedulerxNotificationPolicy_AccessDeniedDetail();
			accessDeniedDetail.PolicyType = _ctx.StringValue("ManageSchedulerxNotificationPolicy.AccessDeniedDetail.PolicyType");
			accessDeniedDetail.AuthPrincipalOwnerId = _ctx.StringValue("ManageSchedulerxNotificationPolicy.AccessDeniedDetail.AuthPrincipalOwnerId");
			accessDeniedDetail.EncodedDiagnosticMessage = _ctx.StringValue("ManageSchedulerxNotificationPolicy.AccessDeniedDetail.EncodedDiagnosticMessage");
			accessDeniedDetail.AuthPrincipalType = _ctx.StringValue("ManageSchedulerxNotificationPolicy.AccessDeniedDetail.AuthPrincipalType");
			accessDeniedDetail.AuthPrincipalDisplayName = _ctx.StringValue("ManageSchedulerxNotificationPolicy.AccessDeniedDetail.AuthPrincipalDisplayName");
			accessDeniedDetail.NoPermissionType = _ctx.StringValue("ManageSchedulerxNotificationPolicy.AccessDeniedDetail.NoPermissionType");
			accessDeniedDetail.AuthAction = _ctx.StringValue("ManageSchedulerxNotificationPolicy.AccessDeniedDetail.AuthAction");
			manageSchedulerxNotificationPolicyResponse.AccessDeniedDetail = accessDeniedDetail;
        
			return manageSchedulerxNotificationPolicyResponse;
        }
    }
}
