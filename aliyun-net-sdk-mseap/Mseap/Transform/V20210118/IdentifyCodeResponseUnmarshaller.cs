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
using Aliyun.Acs.mseap.Model.V20210118;

namespace Aliyun.Acs.mseap.Transform.V20210118
{
    public class IdentifyCodeResponseUnmarshaller
    {
        public static IdentifyCodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			IdentifyCodeResponse identifyCodeResponse = new IdentifyCodeResponse();

			identifyCodeResponse.HttpResponse = _ctx.HttpResponse;
			identifyCodeResponse.AllowRetry = _ctx.BooleanValue("IdentifyCode.AllowRetry");
			identifyCodeResponse.RequestId = _ctx.StringValue("IdentifyCode.RequestId");
			identifyCodeResponse.ErrorMsg = _ctx.StringValue("IdentifyCode.ErrorMsg");
			identifyCodeResponse.HttpStatusCode = _ctx.IntegerValue("IdentifyCode.HttpStatusCode");
			identifyCodeResponse.DynamicCode = _ctx.StringValue("IdentifyCode.DynamicCode");
			identifyCodeResponse.ErrorCode = _ctx.StringValue("IdentifyCode.ErrorCode");
			identifyCodeResponse.DynamicMessage = _ctx.StringValue("IdentifyCode.DynamicMessage");
			identifyCodeResponse.Module = _ctx.StringValue("IdentifyCode.Module");
			identifyCodeResponse.Success = _ctx.BooleanValue("IdentifyCode.Success");
			identifyCodeResponse.AppName = _ctx.StringValue("IdentifyCode.AppName");
        
			return identifyCodeResponse;
        }
    }
}
