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
    public class RenewAppInstanceResponseUnmarshaller
    {
        public static RenewAppInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RenewAppInstanceResponse renewAppInstanceResponse = new RenewAppInstanceResponse();

			renewAppInstanceResponse.HttpResponse = _ctx.HttpResponse;
			renewAppInstanceResponse.RequestId = _ctx.StringValue("RenewAppInstance.RequestId");
			renewAppInstanceResponse.DynamicCode = _ctx.StringValue("RenewAppInstance.DynamicCode");
			renewAppInstanceResponse.DynamicMessage = _ctx.StringValue("RenewAppInstance.DynamicMessage");
			renewAppInstanceResponse.Synchro = _ctx.BooleanValue("RenewAppInstance.Synchro");
			renewAppInstanceResponse.AccessDeniedDetail = _ctx.StringValue("RenewAppInstance.AccessDeniedDetail");
			renewAppInstanceResponse.RootErrorMsg = _ctx.StringValue("RenewAppInstance.RootErrorMsg");
			renewAppInstanceResponse.RootErrorCode = _ctx.StringValue("RenewAppInstance.RootErrorCode");
			renewAppInstanceResponse.AllowRetry = _ctx.BooleanValue("RenewAppInstance.AllowRetry");
			renewAppInstanceResponse.AppName = _ctx.StringValue("RenewAppInstance.AppName");

			List<string> renewAppInstanceResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("RenewAppInstance.ErrorArgs.Length"); i++) {
				renewAppInstanceResponse_errorArgs.Add(_ctx.StringValue("RenewAppInstance.ErrorArgs["+ i +"]"));
			}
			renewAppInstanceResponse.ErrorArgs = renewAppInstanceResponse_errorArgs;

			RenewAppInstanceResponse.RenewAppInstance_Module module = new RenewAppInstanceResponse.RenewAppInstance_Module();
			module.OrderId = _ctx.StringValue("RenewAppInstance.Module.OrderId");
			renewAppInstanceResponse.Module = module;
        
			return renewAppInstanceResponse;
        }
    }
}
