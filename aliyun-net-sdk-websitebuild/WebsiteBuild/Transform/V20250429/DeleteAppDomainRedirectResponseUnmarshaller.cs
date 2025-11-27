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
    public class DeleteAppDomainRedirectResponseUnmarshaller
    {
        public static DeleteAppDomainRedirectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteAppDomainRedirectResponse deleteAppDomainRedirectResponse = new DeleteAppDomainRedirectResponse();

			deleteAppDomainRedirectResponse.HttpResponse = _ctx.HttpResponse;
			deleteAppDomainRedirectResponse.RequestId = _ctx.StringValue("DeleteAppDomainRedirect.RequestId");
			deleteAppDomainRedirectResponse.DynamicCode = _ctx.StringValue("DeleteAppDomainRedirect.DynamicCode");
			deleteAppDomainRedirectResponse.DynamicMessage = _ctx.StringValue("DeleteAppDomainRedirect.DynamicMessage");
			deleteAppDomainRedirectResponse.Synchro = _ctx.BooleanValue("DeleteAppDomainRedirect.Synchro");
			deleteAppDomainRedirectResponse.AccessDeniedDetail = _ctx.StringValue("DeleteAppDomainRedirect.AccessDeniedDetail");
			deleteAppDomainRedirectResponse.RootErrorMsg = _ctx.StringValue("DeleteAppDomainRedirect.RootErrorMsg");
			deleteAppDomainRedirectResponse.RootErrorCode = _ctx.StringValue("DeleteAppDomainRedirect.RootErrorCode");
			deleteAppDomainRedirectResponse.AllowRetry = _ctx.BooleanValue("DeleteAppDomainRedirect.AllowRetry");
			deleteAppDomainRedirectResponse.AppName = _ctx.StringValue("DeleteAppDomainRedirect.AppName");

			List<string> deleteAppDomainRedirectResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("DeleteAppDomainRedirect.ErrorArgs.Length"); i++) {
				deleteAppDomainRedirectResponse_errorArgs.Add(_ctx.StringValue("DeleteAppDomainRedirect.ErrorArgs["+ i +"]"));
			}
			deleteAppDomainRedirectResponse.ErrorArgs = deleteAppDomainRedirectResponse_errorArgs;

			DeleteAppDomainRedirectResponse.DeleteAppDomainRedirect_Module module = new DeleteAppDomainRedirectResponse.DeleteAppDomainRedirect_Module();
			module.Success = _ctx.BooleanValue("DeleteAppDomainRedirect.Module.Success");
			deleteAppDomainRedirectResponse.Module = module;
        
			return deleteAppDomainRedirectResponse;
        }
    }
}
