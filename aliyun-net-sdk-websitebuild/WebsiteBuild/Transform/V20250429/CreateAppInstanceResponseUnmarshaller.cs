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
    public class CreateAppInstanceResponseUnmarshaller
    {
        public static CreateAppInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAppInstanceResponse createAppInstanceResponse = new CreateAppInstanceResponse();

			createAppInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createAppInstanceResponse.RequestId = _ctx.StringValue("CreateAppInstance.RequestId");
			createAppInstanceResponse.DynamicCode = _ctx.StringValue("CreateAppInstance.DynamicCode");
			createAppInstanceResponse.DynamicMessage = _ctx.StringValue("CreateAppInstance.DynamicMessage");
			createAppInstanceResponse.Synchro = _ctx.BooleanValue("CreateAppInstance.Synchro");
			createAppInstanceResponse.AccessDeniedDetail = _ctx.StringValue("CreateAppInstance.AccessDeniedDetail");
			createAppInstanceResponse.RootErrorMsg = _ctx.StringValue("CreateAppInstance.RootErrorMsg");
			createAppInstanceResponse.RootErrorCode = _ctx.StringValue("CreateAppInstance.RootErrorCode");
			createAppInstanceResponse.AllowRetry = _ctx.BooleanValue("CreateAppInstance.AllowRetry");
			createAppInstanceResponse.AppName = _ctx.StringValue("CreateAppInstance.AppName");

			List<string> createAppInstanceResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateAppInstance.ErrorArgs.Length"); i++) {
				createAppInstanceResponse_errorArgs.Add(_ctx.StringValue("CreateAppInstance.ErrorArgs["+ i +"]"));
			}
			createAppInstanceResponse.ErrorArgs = createAppInstanceResponse_errorArgs;

			CreateAppInstanceResponse.CreateAppInstance_Module module = new CreateAppInstanceResponse.CreateAppInstance_Module();
			module.BizId = _ctx.StringValue("CreateAppInstance.Module.BizId");
			module.InstanceId = _ctx.StringValue("CreateAppInstance.Module.InstanceId");
			module.OrderId = _ctx.StringValue("CreateAppInstance.Module.OrderId");
			module.SiteHost = _ctx.StringValue("CreateAppInstance.Module.SiteHost");
			createAppInstanceResponse.Module = module;
        
			return createAppInstanceResponse;
        }
    }
}
