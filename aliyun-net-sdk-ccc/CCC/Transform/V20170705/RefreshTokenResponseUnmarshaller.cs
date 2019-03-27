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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class RefreshTokenResponseUnmarshaller
    {
        public static RefreshTokenResponse Unmarshall(UnmarshallerContext context)
        {
			RefreshTokenResponse refreshTokenResponse = new RefreshTokenResponse();

			refreshTokenResponse.HttpResponse = context.HttpResponse;
			refreshTokenResponse.RequestId = context.StringValue("RefreshToken.RequestId");
			refreshTokenResponse.Success = context.BooleanValue("RefreshToken.Success");
			refreshTokenResponse.Code = context.StringValue("RefreshToken.Code");
			refreshTokenResponse.Message = context.StringValue("RefreshToken.Message");
			refreshTokenResponse.HttpStatusCode = context.IntegerValue("RefreshToken.HttpStatusCode");

			RefreshTokenResponse.RefreshToken_Token token = new RefreshTokenResponse.RefreshToken_Token();
			token.Signature = context.StringValue("RefreshToken.Token.Signature");
			token.SignData = context.StringValue("RefreshToken.Token.SignData");
			refreshTokenResponse.Token = token;
        
			return refreshTokenResponse;
        }
    }
}
