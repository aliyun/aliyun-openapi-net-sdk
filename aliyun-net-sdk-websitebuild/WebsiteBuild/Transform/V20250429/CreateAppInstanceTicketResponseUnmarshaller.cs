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
    public class CreateAppInstanceTicketResponseUnmarshaller
    {
        public static CreateAppInstanceTicketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAppInstanceTicketResponse createAppInstanceTicketResponse = new CreateAppInstanceTicketResponse();

			createAppInstanceTicketResponse.HttpResponse = _ctx.HttpResponse;
			createAppInstanceTicketResponse.RequestId = _ctx.StringValue("CreateAppInstanceTicket.RequestId");
			createAppInstanceTicketResponse.DynamicCode = _ctx.StringValue("CreateAppInstanceTicket.DynamicCode");
			createAppInstanceTicketResponse.DynamicMessage = _ctx.StringValue("CreateAppInstanceTicket.DynamicMessage");
			createAppInstanceTicketResponse.Synchro = _ctx.BooleanValue("CreateAppInstanceTicket.Synchro");
			createAppInstanceTicketResponse.AccessDeniedDetail = _ctx.StringValue("CreateAppInstanceTicket.AccessDeniedDetail");
			createAppInstanceTicketResponse.RootErrorMsg = _ctx.StringValue("CreateAppInstanceTicket.RootErrorMsg");
			createAppInstanceTicketResponse.RootErrorCode = _ctx.StringValue("CreateAppInstanceTicket.RootErrorCode");
			createAppInstanceTicketResponse.AllowRetry = _ctx.BooleanValue("CreateAppInstanceTicket.AllowRetry");
			createAppInstanceTicketResponse.AppName = _ctx.StringValue("CreateAppInstanceTicket.AppName");

			List<string> createAppInstanceTicketResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateAppInstanceTicket.ErrorArgs.Length"); i++) {
				createAppInstanceTicketResponse_errorArgs.Add(_ctx.StringValue("CreateAppInstanceTicket.ErrorArgs["+ i +"]"));
			}
			createAppInstanceTicketResponse.ErrorArgs = createAppInstanceTicketResponse_errorArgs;

			CreateAppInstanceTicketResponse.CreateAppInstanceTicket_Module module = new CreateAppInstanceTicketResponse.CreateAppInstanceTicket_Module();
			module.Uuid = _ctx.StringValue("CreateAppInstanceTicket.Module.Uuid");
			module.Bid = _ctx.StringValue("CreateAppInstanceTicket.Module.Bid");
			module.ParentPk = _ctx.StringValue("CreateAppInstanceTicket.Module.ParentPk");
			module.AliyunPk = _ctx.StringValue("CreateAppInstanceTicket.Module.AliyunPk");
			module.Attributes = _ctx.StringValue("CreateAppInstanceTicket.Module.Attributes");
			module.AuthorizationGrantType = _ctx.StringValue("CreateAppInstanceTicket.Module.AuthorizationGrantType");
			module.AccessTokenValue = _ctx.StringValue("CreateAppInstanceTicket.Module.AccessTokenValue");
			module.AccessTokenIssuedAt = _ctx.StringValue("CreateAppInstanceTicket.Module.AccessTokenIssuedAt");
			module.AccessTokenExpiresAt = _ctx.StringValue("CreateAppInstanceTicket.Module.AccessTokenExpiresAt");
			module.RefreshTokenValue = _ctx.StringValue("CreateAppInstanceTicket.Module.RefreshTokenValue");
			module.RefreshTokenIssuedAt = _ctx.StringValue("CreateAppInstanceTicket.Module.RefreshTokenIssuedAt");
			module.RefreshTokenExpiresAt = _ctx.StringValue("CreateAppInstanceTicket.Module.RefreshTokenExpiresAt");
			createAppInstanceTicketResponse.Module = module;
        
			return createAppInstanceTicketResponse;
        }
    }
}
