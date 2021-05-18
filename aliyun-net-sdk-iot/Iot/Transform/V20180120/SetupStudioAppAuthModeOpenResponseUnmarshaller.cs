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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class SetupStudioAppAuthModeOpenResponseUnmarshaller
    {
        public static SetupStudioAppAuthModeOpenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetupStudioAppAuthModeOpenResponse setupStudioAppAuthModeOpenResponse = new SetupStudioAppAuthModeOpenResponse();

			setupStudioAppAuthModeOpenResponse.HttpResponse = _ctx.HttpResponse;
			setupStudioAppAuthModeOpenResponse.RequestId = _ctx.StringValue("SetupStudioAppAuthModeOpen.RequestId");
			setupStudioAppAuthModeOpenResponse.Success = _ctx.BooleanValue("SetupStudioAppAuthModeOpen.Success");
			setupStudioAppAuthModeOpenResponse.Code = _ctx.StringValue("SetupStudioAppAuthModeOpen.Code");
			setupStudioAppAuthModeOpenResponse.ErrorMessage = _ctx.StringValue("SetupStudioAppAuthModeOpen.ErrorMessage");

			SetupStudioAppAuthModeOpenResponse.SetupStudioAppAuthModeOpen_Data data = new SetupStudioAppAuthModeOpenResponse.SetupStudioAppAuthModeOpen_Data();
			data.AuthMode = _ctx.IntegerValue("SetupStudioAppAuthModeOpen.Data.AuthMode");

			SetupStudioAppAuthModeOpenResponse.SetupStudioAppAuthModeOpen_Data.SetupStudioAppAuthModeOpen_TokenInfo tokenInfo = new SetupStudioAppAuthModeOpenResponse.SetupStudioAppAuthModeOpen_Data.SetupStudioAppAuthModeOpen_TokenInfo();
			tokenInfo.IsEnable = _ctx.StringValue("SetupStudioAppAuthModeOpen.Data.TokenInfo.IsEnable");
			tokenInfo.Type = _ctx.StringValue("SetupStudioAppAuthModeOpen.Data.TokenInfo.Type");
			tokenInfo.BizType = _ctx.StringValue("SetupStudioAppAuthModeOpen.Data.TokenInfo.BizType");
			tokenInfo.Token = _ctx.StringValue("SetupStudioAppAuthModeOpen.Data.TokenInfo.Token");
			tokenInfo.BizId = _ctx.StringValue("SetupStudioAppAuthModeOpen.Data.TokenInfo.BizId");
			data.TokenInfo = tokenInfo;
			setupStudioAppAuthModeOpenResponse.Data = data;
        
			return setupStudioAppAuthModeOpenResponse;
        }
    }
}
