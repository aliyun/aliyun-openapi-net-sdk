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
    public class UpdateApplicationResponseUnmarshaller
    {
        public static UpdateApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateApplicationResponse updateApplicationResponse = new UpdateApplicationResponse();

			updateApplicationResponse.HttpResponse = _ctx.HttpResponse;
			updateApplicationResponse.RequestId = _ctx.StringValue("UpdateApplication.RequestId");

			UpdateApplicationResponse.UpdateApplication_Application application = new UpdateApplicationResponse.UpdateApplication_Application();
			application.DisplayName = _ctx.StringValue("UpdateApplication.Application.DisplayName");
			application.AccessTokenValidity = _ctx.IntegerValue("UpdateApplication.Application.AccessTokenValidity");
			application.SecretRequired = _ctx.BooleanValue("UpdateApplication.Application.SecretRequired");
			application.AccountId = _ctx.StringValue("UpdateApplication.Application.AccountId");
			application.CreateDate = _ctx.StringValue("UpdateApplication.Application.CreateDate");
			application.AppName = _ctx.StringValue("UpdateApplication.Application.AppName");
			application.UpdateDate = _ctx.StringValue("UpdateApplication.Application.UpdateDate");
			application.AppId = _ctx.StringValue("UpdateApplication.Application.AppId");
			application.RefreshTokenValidity = _ctx.IntegerValue("UpdateApplication.Application.RefreshTokenValidity");
			application.AppPrincipalName = _ctx.StringValue("UpdateApplication.Application.AppPrincipalName");
			application.IsMultiTenant = _ctx.BooleanValue("UpdateApplication.Application.IsMultiTenant");
			application.AppType = _ctx.StringValue("UpdateApplication.Application.AppType");
			application.TenantId = _ctx.StringValue("UpdateApplication.Application.TenantId");

			List<string> application_redirectUris = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateApplication.Application.RedirectUris.Length"); i++) {
				application_redirectUris.Add(_ctx.StringValue("UpdateApplication.Application.RedirectUris["+ i +"]"));
			}
			application.RedirectUris = application_redirectUris;

			UpdateApplicationResponse.UpdateApplication_Application.UpdateApplication_DelegatedScope delegatedScope = new UpdateApplicationResponse.UpdateApplication_Application.UpdateApplication_DelegatedScope();

			List<UpdateApplicationResponse.UpdateApplication_Application.UpdateApplication_DelegatedScope.UpdateApplication_PredefinedScope> delegatedScope_predefinedScopes = new List<UpdateApplicationResponse.UpdateApplication_Application.UpdateApplication_DelegatedScope.UpdateApplication_PredefinedScope>();
			for (int i = 0; i < _ctx.Length("UpdateApplication.Application.DelegatedScope.PredefinedScopes.Length"); i++) {
				UpdateApplicationResponse.UpdateApplication_Application.UpdateApplication_DelegatedScope.UpdateApplication_PredefinedScope predefinedScope = new UpdateApplicationResponse.UpdateApplication_Application.UpdateApplication_DelegatedScope.UpdateApplication_PredefinedScope();
				predefinedScope.Description = _ctx.StringValue("UpdateApplication.Application.DelegatedScope.PredefinedScopes["+ i +"].Description");
				predefinedScope.Name = _ctx.StringValue("UpdateApplication.Application.DelegatedScope.PredefinedScopes["+ i +"].Name");
				predefinedScope.Required = _ctx.BooleanValue("UpdateApplication.Application.DelegatedScope.PredefinedScopes["+ i +"].Required");

				delegatedScope_predefinedScopes.Add(predefinedScope);
			}
			delegatedScope.PredefinedScopes = delegatedScope_predefinedScopes;
			application.DelegatedScope = delegatedScope;
			updateApplicationResponse.Application = application;
        
			return updateApplicationResponse;
        }
    }
}
