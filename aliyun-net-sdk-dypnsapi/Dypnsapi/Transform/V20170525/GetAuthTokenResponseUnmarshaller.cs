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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class GetAuthTokenResponseUnmarshaller
    {
        public static GetAuthTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAuthTokenResponse getAuthTokenResponse = new GetAuthTokenResponse();

			getAuthTokenResponse.HttpResponse = _ctx.HttpResponse;
			getAuthTokenResponse.RequestId = _ctx.StringValue("GetAuthToken.RequestId");
			getAuthTokenResponse.Code = _ctx.StringValue("GetAuthToken.Code");
			getAuthTokenResponse.Message = _ctx.StringValue("GetAuthToken.Message");

			GetAuthTokenResponse.GetAuthToken_TokenInfo tokenInfo = new GetAuthTokenResponse.GetAuthToken_TokenInfo();
			tokenInfo.JwtToken = _ctx.StringValue("GetAuthToken.TokenInfo.JwtToken");
			tokenInfo.AccessToken = _ctx.StringValue("GetAuthToken.TokenInfo.AccessToken");
			getAuthTokenResponse.TokenInfo = tokenInfo;
        
			return getAuthTokenResponse;
        }
    }
}
