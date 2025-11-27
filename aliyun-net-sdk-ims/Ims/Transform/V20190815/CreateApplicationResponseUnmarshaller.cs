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
    public class CreateApplicationResponseUnmarshaller
    {
        public static CreateApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateApplicationResponse createApplicationResponse = new CreateApplicationResponse();

			createApplicationResponse.HttpResponse = _ctx.HttpResponse;
			createApplicationResponse.RequestId = _ctx.StringValue("CreateApplication.RequestId");

			CreateApplicationResponse.CreateApplication_Application application = new CreateApplicationResponse.CreateApplication_Application();
			application.DisplayName = _ctx.StringValue("CreateApplication.Application.DisplayName");
			application.AccessTokenValidity = _ctx.IntegerValue("CreateApplication.Application.AccessTokenValidity");
			application.SecretRequired = _ctx.BooleanValue("CreateApplication.Application.SecretRequired");
			application.AccountId = _ctx.StringValue("CreateApplication.Application.AccountId");
			application.CreateDate = _ctx.StringValue("CreateApplication.Application.CreateDate");
			application.AppName = _ctx.StringValue("CreateApplication.Application.AppName");
			application.UpdateDate = _ctx.StringValue("CreateApplication.Application.UpdateDate");
			application.AppId = _ctx.StringValue("CreateApplication.Application.AppId");
			application.RefreshTokenValidity = _ctx.IntegerValue("CreateApplication.Application.RefreshTokenValidity");
			application.AppPrincipalName = _ctx.StringValue("CreateApplication.Application.AppPrincipalName");
			application.IsMultiTenant = _ctx.BooleanValue("CreateApplication.Application.IsMultiTenant");
			application.AppType = _ctx.StringValue("CreateApplication.Application.AppType");
			application.TenantId = _ctx.StringValue("CreateApplication.Application.TenantId");

			List<string> application_redirectUris = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateApplication.Application.RedirectUris.Length"); i++) {
				application_redirectUris.Add(_ctx.StringValue("CreateApplication.Application.RedirectUris["+ i +"]"));
			}
			application.RedirectUris = application_redirectUris;

			CreateApplicationResponse.CreateApplication_Application.CreateApplication_DelegatedScope delegatedScope = new CreateApplicationResponse.CreateApplication_Application.CreateApplication_DelegatedScope();

			List<CreateApplicationResponse.CreateApplication_Application.CreateApplication_DelegatedScope.CreateApplication_PredefinedScope> delegatedScope_predefinedScopes = new List<CreateApplicationResponse.CreateApplication_Application.CreateApplication_DelegatedScope.CreateApplication_PredefinedScope>();
			for (int i = 0; i < _ctx.Length("CreateApplication.Application.DelegatedScope.PredefinedScopes.Length"); i++) {
				CreateApplicationResponse.CreateApplication_Application.CreateApplication_DelegatedScope.CreateApplication_PredefinedScope predefinedScope = new CreateApplicationResponse.CreateApplication_Application.CreateApplication_DelegatedScope.CreateApplication_PredefinedScope();
				predefinedScope.Description = _ctx.StringValue("CreateApplication.Application.DelegatedScope.PredefinedScopes["+ i +"].Description");
				predefinedScope.Required = _ctx.BooleanValue("CreateApplication.Application.DelegatedScope.PredefinedScopes["+ i +"].Required");
				predefinedScope.Name = _ctx.StringValue("CreateApplication.Application.DelegatedScope.PredefinedScopes["+ i +"].Name");

				delegatedScope_predefinedScopes.Add(predefinedScope);
			}
			delegatedScope.PredefinedScopes = delegatedScope_predefinedScopes;
			application.DelegatedScope = delegatedScope;
			createApplicationResponse.Application = application;
        
			return createApplicationResponse;
        }
    }
}
