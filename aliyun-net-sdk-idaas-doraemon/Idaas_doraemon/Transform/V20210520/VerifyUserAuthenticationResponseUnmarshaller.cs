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
using Aliyun.Acs.idaas_doraemon.Model.V20210520;

namespace Aliyun.Acs.idaas_doraemon.Transform.V20210520
{
    public class VerifyUserAuthenticationResponseUnmarshaller
    {
        public static VerifyUserAuthenticationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifyUserAuthenticationResponse verifyUserAuthenticationResponse = new VerifyUserAuthenticationResponse();

			verifyUserAuthenticationResponse.HttpResponse = _ctx.HttpResponse;
			verifyUserAuthenticationResponse.RequestId = _ctx.StringValue("VerifyUserAuthentication.RequestId");
			verifyUserAuthenticationResponse.VerifyResult = _ctx.BooleanValue("VerifyUserAuthentication.VerifyResult");
			verifyUserAuthenticationResponse.EtasSDKString = _ctx.StringValue("VerifyUserAuthentication.EtasSDKString");
			verifyUserAuthenticationResponse.IdToken = _ctx.StringValue("VerifyUserAuthentication.IdToken");

			VerifyUserAuthenticationResponse.VerifyUserAuthentication_AuthenticateResultInfo authenticateResultInfo = new VerifyUserAuthenticationResponse.VerifyUserAuthentication_AuthenticateResultInfo();
			authenticateResultInfo.UserId = _ctx.StringValue("VerifyUserAuthentication.AuthenticateResultInfo.UserId");
			authenticateResultInfo.CredentialId = _ctx.StringValue("VerifyUserAuthentication.AuthenticateResultInfo.CredentialId");
			authenticateResultInfo.BindHashBase64 = _ctx.StringValue("VerifyUserAuthentication.AuthenticateResultInfo.BindHashBase64");
			verifyUserAuthenticationResponse.AuthenticateResultInfo = authenticateResultInfo;
        
			return verifyUserAuthenticationResponse;
        }
    }
}
