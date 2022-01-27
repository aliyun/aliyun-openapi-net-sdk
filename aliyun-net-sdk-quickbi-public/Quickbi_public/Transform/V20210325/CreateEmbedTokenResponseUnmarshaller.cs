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
using Aliyun.Acs.quickbi_public.Model.V20210325;

namespace Aliyun.Acs.quickbi_public.Transform.V20210325
{
    public class CreateEmbedTokenResponseUnmarshaller
    {
        public static CreateEmbedTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateEmbedTokenResponse createEmbedTokenResponse = new CreateEmbedTokenResponse();

			createEmbedTokenResponse.HttpResponse = _ctx.HttpResponse;
			createEmbedTokenResponse.RequestId = _ctx.StringValue("CreateEmbedToken.RequestId");
			createEmbedTokenResponse.Success = _ctx.BooleanValue("CreateEmbedToken.Success");

			CreateEmbedTokenResponse.CreateEmbedToken_Result result = new CreateEmbedTokenResponse.CreateEmbedToken_Result();
			result.AccessToken = _ctx.StringValue("CreateEmbedToken.Result.AccessToken");
			result.TokeType = _ctx.LongValue("CreateEmbedToken.Result.TokeType");
			result.InvalidTime = _ctx.StringValue("CreateEmbedToken.Result.InvalidTime");
			result.RegisterTime = _ctx.StringValue("CreateEmbedToken.Result.RegisterTime");
			createEmbedTokenResponse.Result = result;
        
			return createEmbedTokenResponse;
        }
    }
}
