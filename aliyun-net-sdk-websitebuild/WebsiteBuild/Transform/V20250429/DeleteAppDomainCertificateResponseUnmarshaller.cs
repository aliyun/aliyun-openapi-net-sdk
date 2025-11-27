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
    public class DeleteAppDomainCertificateResponseUnmarshaller
    {
        public static DeleteAppDomainCertificateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteAppDomainCertificateResponse deleteAppDomainCertificateResponse = new DeleteAppDomainCertificateResponse();

			deleteAppDomainCertificateResponse.HttpResponse = _ctx.HttpResponse;
			deleteAppDomainCertificateResponse.RequestId = _ctx.StringValue("DeleteAppDomainCertificate.RequestId");
			deleteAppDomainCertificateResponse.DynamicCode = _ctx.StringValue("DeleteAppDomainCertificate.DynamicCode");
			deleteAppDomainCertificateResponse.DynamicMessage = _ctx.StringValue("DeleteAppDomainCertificate.DynamicMessage");
			deleteAppDomainCertificateResponse.Synchro = _ctx.BooleanValue("DeleteAppDomainCertificate.Synchro");
			deleteAppDomainCertificateResponse.AccessDeniedDetail = _ctx.StringValue("DeleteAppDomainCertificate.AccessDeniedDetail");
			deleteAppDomainCertificateResponse.RootErrorMsg = _ctx.StringValue("DeleteAppDomainCertificate.RootErrorMsg");
			deleteAppDomainCertificateResponse.RootErrorCode = _ctx.StringValue("DeleteAppDomainCertificate.RootErrorCode");
			deleteAppDomainCertificateResponse.AllowRetry = _ctx.BooleanValue("DeleteAppDomainCertificate.AllowRetry");
			deleteAppDomainCertificateResponse.AppName = _ctx.StringValue("DeleteAppDomainCertificate.AppName");

			List<string> deleteAppDomainCertificateResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("DeleteAppDomainCertificate.ErrorArgs.Length"); i++) {
				deleteAppDomainCertificateResponse_errorArgs.Add(_ctx.StringValue("DeleteAppDomainCertificate.ErrorArgs["+ i +"]"));
			}
			deleteAppDomainCertificateResponse.ErrorArgs = deleteAppDomainCertificateResponse_errorArgs;

			DeleteAppDomainCertificateResponse.DeleteAppDomainCertificate_Module module = new DeleteAppDomainCertificateResponse.DeleteAppDomainCertificate_Module();
			module.Success = _ctx.BooleanValue("DeleteAppDomainCertificate.Module.Success");
			deleteAppDomainCertificateResponse.Module = module;
        
			return deleteAppDomainCertificateResponse;
        }
    }
}
