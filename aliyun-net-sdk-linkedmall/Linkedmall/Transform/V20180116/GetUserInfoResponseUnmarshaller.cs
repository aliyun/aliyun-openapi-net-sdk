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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class GetUserInfoResponseUnmarshaller
    {
        public static GetUserInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserInfoResponse getUserInfoResponse = new GetUserInfoResponse();

			getUserInfoResponse.HttpResponse = context.HttpResponse;
			getUserInfoResponse.RequestId = context.StringValue("GetUserInfo.RequestId");
			getUserInfoResponse.Code = context.StringValue("GetUserInfo.Code");
			getUserInfoResponse.Message = context.StringValue("GetUserInfo.Message");

			GetUserInfoResponse.GetUserInfo_LoginResult loginResult = new GetUserInfoResponse.GetUserInfo_LoginResult();
			loginResult.LmUserId = context.LongValue("GetUserInfo.LoginResult.LmUserId");
			loginResult.BizId = context.StringValue("GetUserInfo.LoginResult.BizId");
			loginResult.BizUid = context.StringValue("GetUserInfo.LoginResult.BizUid");
			loginResult.BizUserName = context.StringValue("GetUserInfo.LoginResult.BizUserName");
			loginResult.ReturnUrl = context.StringValue("GetUserInfo.LoginResult.ReturnUrl");
			loginResult.ExtInfo = context.StringValue("GetUserInfo.LoginResult.ExtInfo");

			List<string> loginResult_subBizId = new List<string>();
			for (int i = 0; i < context.Length("GetUserInfo.LoginResult.SubBizId.Length"); i++) {
				loginResult_subBizId.Add(context.StringValue("GetUserInfo.LoginResult.SubBizId["+ i +"]"));
			}
			loginResult.SubBizId = loginResult_subBizId;
			getUserInfoResponse.LoginResult = loginResult;
        
			return getUserInfoResponse;
        }
    }
}
