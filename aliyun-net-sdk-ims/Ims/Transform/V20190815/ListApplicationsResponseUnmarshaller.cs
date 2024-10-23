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
    public class ListApplicationsResponseUnmarshaller
    {
        public static ListApplicationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApplicationsResponse listApplicationsResponse = new ListApplicationsResponse();

			listApplicationsResponse.HttpResponse = _ctx.HttpResponse;
			listApplicationsResponse.RequestId = _ctx.StringValue("ListApplications.RequestId");

			List<ListApplicationsResponse.ListApplications_Application> listApplicationsResponse_applications = new List<ListApplicationsResponse.ListApplications_Application>();
			for (int i = 0; i < _ctx.Length("ListApplications.Applications.Length"); i++) {
				ListApplicationsResponse.ListApplications_Application application = new ListApplicationsResponse.ListApplications_Application();
				application.DisplayName = _ctx.StringValue("ListApplications.Applications["+ i +"].DisplayName");
				application.AccessTokenValidity = _ctx.IntegerValue("ListApplications.Applications["+ i +"].AccessTokenValidity");
				application.SecretRequired = _ctx.BooleanValue("ListApplications.Applications["+ i +"].SecretRequired");
				application.AccountId = _ctx.StringValue("ListApplications.Applications["+ i +"].AccountId");
				application.CreateDate = _ctx.StringValue("ListApplications.Applications["+ i +"].CreateDate");
				application.AppName = _ctx.StringValue("ListApplications.Applications["+ i +"].AppName");
				application.UpdateDate = _ctx.StringValue("ListApplications.Applications["+ i +"].UpdateDate");
				application.AppId = _ctx.StringValue("ListApplications.Applications["+ i +"].AppId");
				application.RefreshTokenValidity = _ctx.IntegerValue("ListApplications.Applications["+ i +"].RefreshTokenValidity");
				application.AppPrincipalName = _ctx.StringValue("ListApplications.Applications["+ i +"].AppPrincipalName");
				application.IsMultiTenant = _ctx.BooleanValue("ListApplications.Applications["+ i +"].IsMultiTenant");
				application.AppType = _ctx.StringValue("ListApplications.Applications["+ i +"].AppType");
				application.TenantId = _ctx.StringValue("ListApplications.Applications["+ i +"].TenantId");

				List<string> application_redirectUris = new List<string>();
				for (int j = 0; j < _ctx.Length("ListApplications.Applications["+ i +"].RedirectUris.Length"); j++) {
					application_redirectUris.Add(_ctx.StringValue("ListApplications.Applications["+ i +"].RedirectUris["+ j +"]"));
				}
				application.RedirectUris = application_redirectUris;

				ListApplicationsResponse.ListApplications_Application.ListApplications_DelegatedScope delegatedScope = new ListApplicationsResponse.ListApplications_Application.ListApplications_DelegatedScope();

				List<ListApplicationsResponse.ListApplications_Application.ListApplications_DelegatedScope.ListApplications_PredefinedScope> delegatedScope_predefinedScopes = new List<ListApplicationsResponse.ListApplications_Application.ListApplications_DelegatedScope.ListApplications_PredefinedScope>();
				for (int j = 0; j < _ctx.Length("ListApplications.Applications["+ i +"].DelegatedScope.PredefinedScopes.Length"); j++) {
					ListApplicationsResponse.ListApplications_Application.ListApplications_DelegatedScope.ListApplications_PredefinedScope predefinedScope = new ListApplicationsResponse.ListApplications_Application.ListApplications_DelegatedScope.ListApplications_PredefinedScope();
					predefinedScope.Description = _ctx.StringValue("ListApplications.Applications["+ i +"].DelegatedScope.PredefinedScopes["+ j +"].Description");
					predefinedScope.Name = _ctx.StringValue("ListApplications.Applications["+ i +"].DelegatedScope.PredefinedScopes["+ j +"].Name");
					predefinedScope.Required = _ctx.BooleanValue("ListApplications.Applications["+ i +"].DelegatedScope.PredefinedScopes["+ j +"].Required");

					delegatedScope_predefinedScopes.Add(predefinedScope);
				}
				delegatedScope.PredefinedScopes = delegatedScope_predefinedScopes;
				application.DelegatedScope = delegatedScope;

				listApplicationsResponse_applications.Add(application);
			}
			listApplicationsResponse.Applications = listApplicationsResponse_applications;
        
			return listApplicationsResponse;
        }
    }
}
