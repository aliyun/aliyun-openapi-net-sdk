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
    public class SetAppDomainCertificateResponseUnmarshaller
    {
        public static SetAppDomainCertificateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetAppDomainCertificateResponse setAppDomainCertificateResponse = new SetAppDomainCertificateResponse();

			setAppDomainCertificateResponse.HttpResponse = _ctx.HttpResponse;
			setAppDomainCertificateResponse.RequestId = _ctx.StringValue("SetAppDomainCertificate.RequestId");
			setAppDomainCertificateResponse.DynamicCode = _ctx.StringValue("SetAppDomainCertificate.DynamicCode");
			setAppDomainCertificateResponse.DynamicMessage = _ctx.StringValue("SetAppDomainCertificate.DynamicMessage");
			setAppDomainCertificateResponse.Synchro = _ctx.BooleanValue("SetAppDomainCertificate.Synchro");
			setAppDomainCertificateResponse.AccessDeniedDetail = _ctx.StringValue("SetAppDomainCertificate.AccessDeniedDetail");
			setAppDomainCertificateResponse.RootErrorMsg = _ctx.StringValue("SetAppDomainCertificate.RootErrorMsg");
			setAppDomainCertificateResponse.RootErrorCode = _ctx.StringValue("SetAppDomainCertificate.RootErrorCode");
			setAppDomainCertificateResponse.AllowRetry = _ctx.BooleanValue("SetAppDomainCertificate.AllowRetry");
			setAppDomainCertificateResponse.AppName = _ctx.StringValue("SetAppDomainCertificate.AppName");

			List<string> setAppDomainCertificateResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("SetAppDomainCertificate.ErrorArgs.Length"); i++) {
				setAppDomainCertificateResponse_errorArgs.Add(_ctx.StringValue("SetAppDomainCertificate.ErrorArgs["+ i +"]"));
			}
			setAppDomainCertificateResponse.ErrorArgs = setAppDomainCertificateResponse_errorArgs;

			SetAppDomainCertificateResponse.SetAppDomainCertificate_Module module = new SetAppDomainCertificateResponse.SetAppDomainCertificate_Module();
			module.Success = _ctx.BooleanValue("SetAppDomainCertificate.Module.Success");
			setAppDomainCertificateResponse.Module = module;
        
			return setAppDomainCertificateResponse;
        }
    }
}
