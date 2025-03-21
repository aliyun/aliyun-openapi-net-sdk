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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryUserInfoByUserIdResponseUnmarshaller
    {
        public static QueryUserInfoByUserIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserInfoByUserIdResponse queryUserInfoByUserIdResponse = new QueryUserInfoByUserIdResponse();

			queryUserInfoByUserIdResponse.HttpResponse = _ctx.HttpResponse;
			queryUserInfoByUserIdResponse.Success = _ctx.BooleanValue("QueryUserInfoByUserId.Success");
			queryUserInfoByUserIdResponse.RequestId = _ctx.StringValue("QueryUserInfoByUserId.RequestId");

			QueryUserInfoByUserIdResponse.QueryUserInfoByUserId_Result result = new QueryUserInfoByUserIdResponse.QueryUserInfoByUserId_Result();
			result.AccountId = _ctx.StringValue("QueryUserInfoByUserId.Result.AccountId");
			result.AccountName = _ctx.StringValue("QueryUserInfoByUserId.Result.AccountName");
			result.AdminUser = _ctx.BooleanValue("QueryUserInfoByUserId.Result.AdminUser");
			result.AuthAdminUser = _ctx.BooleanValue("QueryUserInfoByUserId.Result.AuthAdminUser");
			result.Email = _ctx.StringValue("QueryUserInfoByUserId.Result.Email");
			result.NickName = _ctx.StringValue("QueryUserInfoByUserId.Result.NickName");
			result.Phone = _ctx.StringValue("QueryUserInfoByUserId.Result.Phone");
			result.UserId = _ctx.StringValue("QueryUserInfoByUserId.Result.UserId");
			result.UserType = _ctx.IntegerValue("QueryUserInfoByUserId.Result.UserType");

			List<string> result_roleIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryUserInfoByUserId.Result.RoleIdList.Length"); i++) {
				result_roleIdList.Add(_ctx.StringValue("QueryUserInfoByUserId.Result.RoleIdList["+ i +"]"));
			}
			result.RoleIdList = result_roleIdList;
			queryUserInfoByUserIdResponse.Result = result;
        
			return queryUserInfoByUserIdResponse;
        }
    }
}
