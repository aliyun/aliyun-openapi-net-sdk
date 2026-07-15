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
    public class DeleteSchedulerxNotificationPolicyResponseUnmarshaller
    {
        public static DeleteSchedulerxNotificationPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteSchedulerxNotificationPolicyResponse deleteSchedulerxNotificationPolicyResponse = new DeleteSchedulerxNotificationPolicyResponse();

			deleteSchedulerxNotificationPolicyResponse.HttpResponse = _ctx.HttpResponse;
			deleteSchedulerxNotificationPolicyResponse.Message = _ctx.StringValue("DeleteSchedulerxNotificationPolicy.Message");
			deleteSchedulerxNotificationPolicyResponse.RequestId = _ctx.StringValue("DeleteSchedulerxNotificationPolicy.RequestId");
			deleteSchedulerxNotificationPolicyResponse.Code = _ctx.IntegerValue("DeleteSchedulerxNotificationPolicy.Code");
			deleteSchedulerxNotificationPolicyResponse.Success = _ctx.BooleanValue("DeleteSchedulerxNotificationPolicy.Success");

			DeleteSchedulerxNotificationPolicyResponse.DeleteSchedulerxNotificationPolicy_AccessDeniedDetail accessDeniedDetail = new DeleteSchedulerxNotificationPolicyResponse.DeleteSchedulerxNotificationPolicy_AccessDeniedDetail();
			accessDeniedDetail.PolicyType = _ctx.StringValue("DeleteSchedulerxNotificationPolicy.AccessDeniedDetail.PolicyType");
			accessDeniedDetail.AuthPrincipalOwnerId = _ctx.StringValue("DeleteSchedulerxNotificationPolicy.AccessDeniedDetail.AuthPrincipalOwnerId");
			accessDeniedDetail.EncodedDiagnosticMessage = _ctx.StringValue("DeleteSchedulerxNotificationPolicy.AccessDeniedDetail.EncodedDiagnosticMessage");
			accessDeniedDetail.AuthPrincipalType = _ctx.StringValue("DeleteSchedulerxNotificationPolicy.AccessDeniedDetail.AuthPrincipalType");
			accessDeniedDetail.AuthPrincipalDisplayName = _ctx.StringValue("DeleteSchedulerxNotificationPolicy.AccessDeniedDetail.AuthPrincipalDisplayName");
			accessDeniedDetail.NoPermissionType = _ctx.StringValue("DeleteSchedulerxNotificationPolicy.AccessDeniedDetail.NoPermissionType");
			accessDeniedDetail.AuthAction = _ctx.StringValue("DeleteSchedulerxNotificationPolicy.AccessDeniedDetail.AuthAction");
			deleteSchedulerxNotificationPolicyResponse.AccessDeniedDetail = accessDeniedDetail;
        
			return deleteSchedulerxNotificationPolicyResponse;
        }
    }
}
