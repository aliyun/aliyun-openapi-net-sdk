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
using Aliyun.Acs.AiMiaoBi.Model.V20230801;

namespace Aliyun.Acs.AiMiaoBi.Transform.V20230801
{
    public class CreateTokenResponseUnmarshaller
    {
        public static CreateTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTokenResponse createTokenResponse = new CreateTokenResponse();

			createTokenResponse.HttpResponse = _ctx.HttpResponse;
			createTokenResponse.RequestId = _ctx.StringValue("CreateToken.RequestId");
			createTokenResponse.Success = _ctx.BooleanValue("CreateToken.Success");
			createTokenResponse.Code = _ctx.StringValue("CreateToken.Code");
			createTokenResponse.Message = _ctx.StringValue("CreateToken.Message");
			createTokenResponse.HttpStatusCode = _ctx.IntegerValue("CreateToken.HttpStatusCode");

			CreateTokenResponse.CreateToken_Data data = new CreateTokenResponse.CreateToken_Data();
			data.Token = _ctx.StringValue("CreateToken.Data.Token");
			data.ExpiredTime = _ctx.LongValue("CreateToken.Data.ExpiredTime");
			createTokenResponse.Data = data;
        
			return createTokenResponse;
        }
    }
}
