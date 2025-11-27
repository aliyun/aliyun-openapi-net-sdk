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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class GetApplicationResponseUnmarshaller
    {
        public static GetApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetApplicationResponse getApplicationResponse = new GetApplicationResponse();

			getApplicationResponse.HttpResponse = _ctx.HttpResponse;
			getApplicationResponse.RequestId = _ctx.StringValue("GetApplication.RequestId");

			GetApplicationResponse.GetApplication_Application application = new GetApplicationResponse.GetApplication_Application();
			application.DisplayName = _ctx.StringValue("GetApplication.Application.DisplayName");
			application.AccessTokenValidity = _ctx.IntegerValue("GetApplication.Application.AccessTokenValidity");
			application.SecretRequired = _ctx.BooleanValue("GetApplication.Application.SecretRequired");
			application.AccountId = _ctx.StringValue("GetApplication.Application.AccountId");
			application.CreateDate = _ctx.StringValue("GetApplication.Application.CreateDate");
			application.AppName = _ctx.StringValue("GetApplication.Application.AppName");
			application.UpdateDate = _ctx.StringValue("GetApplication.Application.UpdateDate");
			application.AppId = _ctx.StringValue("GetApplication.Application.AppId");
			application.RefreshTokenValidity = _ctx.IntegerValue("GetApplication.Application.RefreshTokenValidity");
			application.AppPrincipalName = _ctx.StringValue("GetApplication.Application.AppPrincipalName");
			application.IsMultiTenant = _ctx.BooleanValue("GetApplication.Application.IsMultiTenant");
			application.AppType = _ctx.StringValue("GetApplication.Application.AppType");
			application.TenantId = _ctx.StringValue("GetApplication.Application.TenantId");

			List<string> application_redirectUris = new List<string>();
			for (int i = 0; i < _ctx.Length("GetApplication.Application.RedirectUris.Length"); i++) {
				application_redirectUris.Add(_ctx.StringValue("GetApplication.Application.RedirectUris["+ i +"]"));
			}
			application.RedirectUris = application_redirectUris;

			GetApplicationResponse.GetApplication_Application.GetApplication_DelegatedScope delegatedScope = new GetApplicationResponse.GetApplication_Application.GetApplication_DelegatedScope();

			List<GetApplicationResponse.GetApplication_Application.GetApplication_DelegatedScope.GetApplication_PredefinedScope> delegatedScope_predefinedScopes = new List<GetApplicationResponse.GetApplication_Application.GetApplication_DelegatedScope.GetApplication_PredefinedScope>();
			for (int i = 0; i < _ctx.Length("GetApplication.Application.DelegatedScope.PredefinedScopes.Length"); i++) {
				GetApplicationResponse.GetApplication_Application.GetApplication_DelegatedScope.GetApplication_PredefinedScope predefinedScope = new GetApplicationResponse.GetApplication_Application.GetApplication_DelegatedScope.GetApplication_PredefinedScope();
				predefinedScope.Description = _ctx.StringValue("GetApplication.Application.DelegatedScope.PredefinedScopes["+ i +"].Description");
				predefinedScope.Name = _ctx.StringValue("GetApplication.Application.DelegatedScope.PredefinedScopes["+ i +"].Name");
				predefinedScope.Required = _ctx.BooleanValue("GetApplication.Application.DelegatedScope.PredefinedScopes["+ i +"].Required");

				delegatedScope_predefinedScopes.Add(predefinedScope);
			}
			delegatedScope.PredefinedScopes = delegatedScope_predefinedScopes;
			application.DelegatedScope = delegatedScope;
			getApplicationResponse.Application = application;
        
			return getApplicationResponse;
        }
    }
}
