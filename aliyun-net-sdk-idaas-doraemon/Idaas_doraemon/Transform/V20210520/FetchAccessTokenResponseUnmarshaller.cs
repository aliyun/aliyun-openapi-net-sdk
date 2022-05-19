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
    public class FetchAccessTokenResponseUnmarshaller
    {
        public static FetchAccessTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			FetchAccessTokenResponse fetchAccessTokenResponse = new FetchAccessTokenResponse();

			fetchAccessTokenResponse.HttpResponse = _ctx.HttpResponse;
			fetchAccessTokenResponse.RequestId = _ctx.StringValue("FetchAccessToken.RequestId");
			fetchAccessTokenResponse.Message = _ctx.StringValue("FetchAccessToken.Message");
			fetchAccessTokenResponse.Code = _ctx.StringValue("FetchAccessToken.Code");
			fetchAccessTokenResponse.Success = _ctx.BooleanValue("FetchAccessToken.Success");

			FetchAccessTokenResponse.FetchAccessToken_Data data = new FetchAccessTokenResponse.FetchAccessToken_Data();
			data.Access_token = _ctx.StringValue("FetchAccessToken.Data.Access_token");
			data.Token_type = _ctx.StringValue("FetchAccessToken.Data.Token_type");
			data.Scope = _ctx.StringValue("FetchAccessToken.Data.Scope");
			data.Expires_in = _ctx.StringValue("FetchAccessToken.Data.Expires_in");
			data.Refresh_token = _ctx.StringValue("FetchAccessToken.Data.Refresh_token");
			data.Id_token = _ctx.StringValue("FetchAccessToken.Data.Id_token");
			fetchAccessTokenResponse.Data = data;
        
			return fetchAccessTokenResponse;
        }
    }
}
