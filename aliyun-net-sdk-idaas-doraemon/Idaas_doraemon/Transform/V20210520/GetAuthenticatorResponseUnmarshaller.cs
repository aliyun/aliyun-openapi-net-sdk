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
    public class GetAuthenticatorResponseUnmarshaller
    {
        public static GetAuthenticatorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAuthenticatorResponse getAuthenticatorResponse = new GetAuthenticatorResponse();

			getAuthenticatorResponse.HttpResponse = _ctx.HttpResponse;
			getAuthenticatorResponse.RequestId = _ctx.StringValue("GetAuthenticator.RequestId");

			GetAuthenticatorResponse.GetAuthenticator_Authenticator authenticator = new GetAuthenticatorResponse.GetAuthenticator_Authenticator();
			authenticator.AuthenticatorUuid = _ctx.StringValue("GetAuthenticator.Authenticator.AuthenticatorUuid");
			authenticator.CredentialId = _ctx.StringValue("GetAuthenticator.Authenticator.CredentialId");
			authenticator.Type = _ctx.StringValue("GetAuthenticator.Authenticator.Type");
			authenticator.AuthenticatorName = _ctx.StringValue("GetAuthenticator.Authenticator.AuthenticatorName");
			authenticator.RegisterTime = _ctx.LongValue("GetAuthenticator.Authenticator.RegisterTime");
			authenticator.LastVerifyTime = _ctx.LongValue("GetAuthenticator.Authenticator.LastVerifyTime");
			authenticator.RegisterSourceIp = _ctx.StringValue("GetAuthenticator.Authenticator.RegisterSourceIp");
			authenticator.LastVerifySourceIp = _ctx.StringValue("GetAuthenticator.Authenticator.LastVerifySourceIp");
			authenticator.LastVerifyUserAgent = _ctx.StringValue("GetAuthenticator.Authenticator.LastVerifyUserAgent");
			authenticator.CustomAuthenticator = _ctx.StringValue("GetAuthenticator.Authenticator.CustomAuthenticator");
			getAuthenticatorResponse.Authenticator = authenticator;
        
			return getAuthenticatorResponse;
        }
    }
}
