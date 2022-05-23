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
using Aliyun.Acs.btripOpen.Model.V20220517;

namespace Aliyun.Acs.btripOpen.Transform.V20220517
{
    public class TakeAccessTokenResponseUnmarshaller
    {
        public static TakeAccessTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TakeAccessTokenResponse takeAccessTokenResponse = new TakeAccessTokenResponse();

			takeAccessTokenResponse.HttpResponse = _ctx.HttpResponse;
			takeAccessTokenResponse.RequestId = _ctx.StringValue("TakeAccessToken.requestId");
			takeAccessTokenResponse.Code = _ctx.StringValue("TakeAccessToken.code");
			takeAccessTokenResponse.Message = _ctx.StringValue("TakeAccessToken.message");
			takeAccessTokenResponse.Success = _ctx.StringValue("TakeAccessToken.success");

			TakeAccessTokenResponse.TakeAccessToken_Data data = new TakeAccessTokenResponse.TakeAccessToken_Data();
			data.Access_token = _ctx.StringValue("TakeAccessToken.Data.access_token");
			data.Expire = _ctx.LongValue("TakeAccessToken.Data.expire");
			takeAccessTokenResponse.Data = data;
        
			return takeAccessTokenResponse;
        }
    }
}
