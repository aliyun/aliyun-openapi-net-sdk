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
using Aliyun.Acs.marketplaceIntl.Model.V20221230;

namespace Aliyun.Acs.marketplaceIntl.Transform.V20221230
{
    public class NoticeInstanceUserResponseUnmarshaller
    {
        public static NoticeInstanceUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			NoticeInstanceUserResponse noticeInstanceUserResponse = new NoticeInstanceUserResponse();

			noticeInstanceUserResponse.HttpResponse = _ctx.HttpResponse;
			noticeInstanceUserResponse.Result = _ctx.BooleanValue("NoticeInstanceUser.Result");
			noticeInstanceUserResponse.Success = _ctx.BooleanValue("NoticeInstanceUser.Success");
			noticeInstanceUserResponse.Code = _ctx.StringValue("NoticeInstanceUser.Code");
			noticeInstanceUserResponse.Message = _ctx.StringValue("NoticeInstanceUser.Message");
			noticeInstanceUserResponse.RequestId = _ctx.StringValue("NoticeInstanceUser.RequestId");

			NoticeInstanceUserResponse.NoticeInstanceUser_AccessDeniedDetail accessDeniedDetail = new NoticeInstanceUserResponse.NoticeInstanceUser_AccessDeniedDetail();
			accessDeniedDetail.AuthAction = _ctx.StringValue("NoticeInstanceUser.AccessDeniedDetail.AuthAction");
			accessDeniedDetail.AuthPrincipalDisplayName = _ctx.StringValue("NoticeInstanceUser.AccessDeniedDetail.AuthPrincipalDisplayName");
			accessDeniedDetail.AuthPrincipalOwnerId = _ctx.StringValue("NoticeInstanceUser.AccessDeniedDetail.AuthPrincipalOwnerId");
			accessDeniedDetail.AuthPrincipalType = _ctx.StringValue("NoticeInstanceUser.AccessDeniedDetail.AuthPrincipalType");
			accessDeniedDetail.EncodedDiagnosticMessage = _ctx.StringValue("NoticeInstanceUser.AccessDeniedDetail.EncodedDiagnosticMessage");
			accessDeniedDetail.NoPermissionType = _ctx.StringValue("NoticeInstanceUser.AccessDeniedDetail.NoPermissionType");
			accessDeniedDetail.PolicyType = _ctx.StringValue("NoticeInstanceUser.AccessDeniedDetail.PolicyType");
			noticeInstanceUserResponse.AccessDeniedDetail = accessDeniedDetail;
        
			return noticeInstanceUserResponse;
        }
    }
}
