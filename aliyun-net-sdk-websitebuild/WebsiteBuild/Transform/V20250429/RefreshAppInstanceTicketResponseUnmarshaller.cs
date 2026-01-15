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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class RefreshAppInstanceTicketResponseUnmarshaller
    {
        public static RefreshAppInstanceTicketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RefreshAppInstanceTicketResponse refreshAppInstanceTicketResponse = new RefreshAppInstanceTicketResponse();

			refreshAppInstanceTicketResponse.HttpResponse = _ctx.HttpResponse;
			refreshAppInstanceTicketResponse.RequestId = _ctx.StringValue("RefreshAppInstanceTicket.RequestId");
			refreshAppInstanceTicketResponse.DynamicCode = _ctx.StringValue("RefreshAppInstanceTicket.DynamicCode");
			refreshAppInstanceTicketResponse.DynamicMessage = _ctx.StringValue("RefreshAppInstanceTicket.DynamicMessage");
			refreshAppInstanceTicketResponse.Synchro = _ctx.BooleanValue("RefreshAppInstanceTicket.Synchro");
			refreshAppInstanceTicketResponse.AccessDeniedDetail = _ctx.StringValue("RefreshAppInstanceTicket.AccessDeniedDetail");
			refreshAppInstanceTicketResponse.RootErrorMsg = _ctx.StringValue("RefreshAppInstanceTicket.RootErrorMsg");
			refreshAppInstanceTicketResponse.RootErrorCode = _ctx.StringValue("RefreshAppInstanceTicket.RootErrorCode");
			refreshAppInstanceTicketResponse.AllowRetry = _ctx.BooleanValue("RefreshAppInstanceTicket.AllowRetry");
			refreshAppInstanceTicketResponse.AppName = _ctx.StringValue("RefreshAppInstanceTicket.AppName");

			List<string> refreshAppInstanceTicketResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("RefreshAppInstanceTicket.ErrorArgs.Length"); i++) {
				refreshAppInstanceTicketResponse_errorArgs.Add(_ctx.StringValue("RefreshAppInstanceTicket.ErrorArgs["+ i +"]"));
			}
			refreshAppInstanceTicketResponse.ErrorArgs = refreshAppInstanceTicketResponse_errorArgs;

			RefreshAppInstanceTicketResponse.RefreshAppInstanceTicket_Module module = new RefreshAppInstanceTicketResponse.RefreshAppInstanceTicket_Module();
			module.Uuid = _ctx.StringValue("RefreshAppInstanceTicket.Module.Uuid");
			module.Bid = _ctx.StringValue("RefreshAppInstanceTicket.Module.Bid");
			module.ParentPk = _ctx.StringValue("RefreshAppInstanceTicket.Module.ParentPk");
			module.AliyunPk = _ctx.StringValue("RefreshAppInstanceTicket.Module.AliyunPk");
			module.Attributes = _ctx.StringValue("RefreshAppInstanceTicket.Module.Attributes");
			module.AuthorizationGrantType = _ctx.StringValue("RefreshAppInstanceTicket.Module.AuthorizationGrantType");
			module.AccessTokenValue = _ctx.StringValue("RefreshAppInstanceTicket.Module.AccessTokenValue");
			module.AccessTokenIssuedAt = _ctx.StringValue("RefreshAppInstanceTicket.Module.AccessTokenIssuedAt");
			module.AccessTokenExpiresAt = _ctx.StringValue("RefreshAppInstanceTicket.Module.AccessTokenExpiresAt");
			module.RefreshTokenValue = _ctx.StringValue("RefreshAppInstanceTicket.Module.RefreshTokenValue");
			module.RefreshTokenIssuedAt = _ctx.StringValue("RefreshAppInstanceTicket.Module.RefreshTokenIssuedAt");
			module.RefreshTokenExpiresAt = _ctx.StringValue("RefreshAppInstanceTicket.Module.RefreshTokenExpiresAt");
			refreshAppInstanceTicketResponse.Module = module;
        
			return refreshAppInstanceTicketResponse;
        }
    }
}
