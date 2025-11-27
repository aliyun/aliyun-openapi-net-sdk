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
    public class UnbindAppDomainResponseUnmarshaller
    {
        public static UnbindAppDomainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnbindAppDomainResponse unbindAppDomainResponse = new UnbindAppDomainResponse();

			unbindAppDomainResponse.HttpResponse = _ctx.HttpResponse;
			unbindAppDomainResponse.RequestId = _ctx.StringValue("UnbindAppDomain.RequestId");
			unbindAppDomainResponse.DynamicCode = _ctx.StringValue("UnbindAppDomain.DynamicCode");
			unbindAppDomainResponse.DynamicMessage = _ctx.StringValue("UnbindAppDomain.DynamicMessage");
			unbindAppDomainResponse.Synchro = _ctx.BooleanValue("UnbindAppDomain.Synchro");
			unbindAppDomainResponse.AccessDeniedDetail = _ctx.StringValue("UnbindAppDomain.AccessDeniedDetail");
			unbindAppDomainResponse.RootErrorMsg = _ctx.StringValue("UnbindAppDomain.RootErrorMsg");
			unbindAppDomainResponse.RootErrorCode = _ctx.StringValue("UnbindAppDomain.RootErrorCode");
			unbindAppDomainResponse.AllowRetry = _ctx.BooleanValue("UnbindAppDomain.AllowRetry");
			unbindAppDomainResponse.AppName = _ctx.StringValue("UnbindAppDomain.AppName");

			List<string> unbindAppDomainResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("UnbindAppDomain.ErrorArgs.Length"); i++) {
				unbindAppDomainResponse_errorArgs.Add(_ctx.StringValue("UnbindAppDomain.ErrorArgs["+ i +"]"));
			}
			unbindAppDomainResponse.ErrorArgs = unbindAppDomainResponse_errorArgs;

			UnbindAppDomainResponse.UnbindAppDomain_Module module = new UnbindAppDomainResponse.UnbindAppDomain_Module();
			module.Success = _ctx.BooleanValue("UnbindAppDomain.Module.Success");
			unbindAppDomainResponse.Module = module;
        
			return unbindAppDomainResponse;
        }
    }
}
