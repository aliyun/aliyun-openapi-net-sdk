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
using Aliyun.Acs.quickbi_public.Model.V20200801;

namespace Aliyun.Acs.quickbi_public.Transform.V20200801
{
    public class QueryUserInfoByAccountResponseUnmarshaller
    {
        public static QueryUserInfoByAccountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserInfoByAccountResponse queryUserInfoByAccountResponse = new QueryUserInfoByAccountResponse();

			queryUserInfoByAccountResponse.HttpResponse = _ctx.HttpResponse;
			queryUserInfoByAccountResponse.RequestId = _ctx.StringValue("QueryUserInfoByAccount.RequestId");
			queryUserInfoByAccountResponse.Success = _ctx.BooleanValue("QueryUserInfoByAccount.Success");

			QueryUserInfoByAccountResponse.QueryUserInfoByAccount_Result result = new QueryUserInfoByAccountResponse.QueryUserInfoByAccount_Result();
			result.AccountId = _ctx.StringValue("QueryUserInfoByAccount.Result.AccountId");
			result.AccountName = _ctx.StringValue("QueryUserInfoByAccount.Result.AccountName");
			result.AdminUser = _ctx.BooleanValue("QueryUserInfoByAccount.Result.AdminUser");
			result.AuthAdminUser = _ctx.BooleanValue("QueryUserInfoByAccount.Result.AuthAdminUser");
			result.Email = _ctx.StringValue("QueryUserInfoByAccount.Result.Email");
			result.NickName = _ctx.StringValue("QueryUserInfoByAccount.Result.NickName");
			result.Phone = _ctx.StringValue("QueryUserInfoByAccount.Result.Phone");
			result.UserId = _ctx.StringValue("QueryUserInfoByAccount.Result.UserId");
			result.UserType = _ctx.IntegerValue("QueryUserInfoByAccount.Result.UserType");
			queryUserInfoByAccountResponse.Result = result;
        
			return queryUserInfoByAccountResponse;
        }
    }
}
