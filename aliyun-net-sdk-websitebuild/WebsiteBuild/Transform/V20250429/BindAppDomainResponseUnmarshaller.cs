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
    public class BindAppDomainResponseUnmarshaller
    {
        public static BindAppDomainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BindAppDomainResponse bindAppDomainResponse = new BindAppDomainResponse();

			bindAppDomainResponse.HttpResponse = _ctx.HttpResponse;
			bindAppDomainResponse.RequestId = _ctx.StringValue("BindAppDomain.RequestId");
			bindAppDomainResponse.DynamicCode = _ctx.StringValue("BindAppDomain.DynamicCode");
			bindAppDomainResponse.DynamicMessage = _ctx.StringValue("BindAppDomain.DynamicMessage");
			bindAppDomainResponse.Synchro = _ctx.BooleanValue("BindAppDomain.Synchro");
			bindAppDomainResponse.AccessDeniedDetail = _ctx.StringValue("BindAppDomain.AccessDeniedDetail");
			bindAppDomainResponse.RootErrorMsg = _ctx.StringValue("BindAppDomain.RootErrorMsg");
			bindAppDomainResponse.RootErrorCode = _ctx.StringValue("BindAppDomain.RootErrorCode");
			bindAppDomainResponse.AllowRetry = _ctx.BooleanValue("BindAppDomain.AllowRetry");
			bindAppDomainResponse.AppName = _ctx.StringValue("BindAppDomain.AppName");

			List<string> bindAppDomainResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("BindAppDomain.ErrorArgs.Length"); i++) {
				bindAppDomainResponse_errorArgs.Add(_ctx.StringValue("BindAppDomain.ErrorArgs["+ i +"]"));
			}
			bindAppDomainResponse.ErrorArgs = bindAppDomainResponse_errorArgs;

			BindAppDomainResponse.BindAppDomain_Module module = new BindAppDomainResponse.BindAppDomain_Module();
			module.Success = _ctx.BooleanValue("BindAppDomain.Module.Success");
			bindAppDomainResponse.Module = module;
        
			return bindAppDomainResponse;
        }
    }
}
