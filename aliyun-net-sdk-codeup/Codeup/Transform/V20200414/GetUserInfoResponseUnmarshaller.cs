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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class GetUserInfoResponseUnmarshaller
    {
        public static GetUserInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserInfoResponse getUserInfoResponse = new GetUserInfoResponse();

			getUserInfoResponse.HttpResponse = _ctx.HttpResponse;
			getUserInfoResponse.RequestId = _ctx.StringValue("GetUserInfo.RequestId");
			getUserInfoResponse.ErrorCode = _ctx.StringValue("GetUserInfo.ErrorCode");
			getUserInfoResponse.Success = _ctx.BooleanValue("GetUserInfo.Success");
			getUserInfoResponse.ErrorMessage = _ctx.StringValue("GetUserInfo.ErrorMessage");

			GetUserInfoResponse.GetUserInfo_Result result = new GetUserInfoResponse.GetUserInfo_Result();
			result.Id = _ctx.LongValue("GetUserInfo.Result.Id");
			result.ExternalUserId = _ctx.StringValue("GetUserInfo.Result.ExternalUserId");
			result.Username = _ctx.StringValue("GetUserInfo.Result.Username");
			result.Name = _ctx.StringValue("GetUserInfo.Result.Name");
			result.Email = _ctx.StringValue("GetUserInfo.Result.Email");
			result.AvatarUrl = _ctx.StringValue("GetUserInfo.Result.AvatarUrl");
			getUserInfoResponse.Result = result;
        
			return getUserInfoResponse;
        }
    }
}
