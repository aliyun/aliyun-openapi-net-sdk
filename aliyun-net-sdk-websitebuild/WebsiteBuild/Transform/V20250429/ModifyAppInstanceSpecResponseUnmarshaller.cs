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
    public class ModifyAppInstanceSpecResponseUnmarshaller
    {
        public static ModifyAppInstanceSpecResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyAppInstanceSpecResponse modifyAppInstanceSpecResponse = new ModifyAppInstanceSpecResponse();

			modifyAppInstanceSpecResponse.HttpResponse = _ctx.HttpResponse;
			modifyAppInstanceSpecResponse.RequestId = _ctx.StringValue("ModifyAppInstanceSpec.RequestId");
			modifyAppInstanceSpecResponse.DynamicCode = _ctx.StringValue("ModifyAppInstanceSpec.DynamicCode");
			modifyAppInstanceSpecResponse.DynamicMessage = _ctx.StringValue("ModifyAppInstanceSpec.DynamicMessage");
			modifyAppInstanceSpecResponse.Synchro = _ctx.BooleanValue("ModifyAppInstanceSpec.Synchro");
			modifyAppInstanceSpecResponse.AccessDeniedDetail = _ctx.StringValue("ModifyAppInstanceSpec.AccessDeniedDetail");
			modifyAppInstanceSpecResponse.RootErrorMsg = _ctx.StringValue("ModifyAppInstanceSpec.RootErrorMsg");
			modifyAppInstanceSpecResponse.RootErrorCode = _ctx.StringValue("ModifyAppInstanceSpec.RootErrorCode");
			modifyAppInstanceSpecResponse.AllowRetry = _ctx.BooleanValue("ModifyAppInstanceSpec.AllowRetry");
			modifyAppInstanceSpecResponse.AppName = _ctx.StringValue("ModifyAppInstanceSpec.AppName");

			List<string> modifyAppInstanceSpecResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("ModifyAppInstanceSpec.ErrorArgs.Length"); i++) {
				modifyAppInstanceSpecResponse_errorArgs.Add(_ctx.StringValue("ModifyAppInstanceSpec.ErrorArgs["+ i +"]"));
			}
			modifyAppInstanceSpecResponse.ErrorArgs = modifyAppInstanceSpecResponse_errorArgs;

			ModifyAppInstanceSpecResponse.ModifyAppInstanceSpec_Module module = new ModifyAppInstanceSpecResponse.ModifyAppInstanceSpec_Module();
			module.OrderId = _ctx.StringValue("ModifyAppInstanceSpec.Module.OrderId");
			modifyAppInstanceSpecResponse.Module = module;
        
			return modifyAppInstanceSpecResponse;
        }
    }
}
