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
    public class AddUserResponseUnmarshaller
    {
        public static AddUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddUserResponse addUserResponse = new AddUserResponse();

			addUserResponse.HttpResponse = _ctx.HttpResponse;
			addUserResponse.RequestId = _ctx.StringValue("AddUser.RequestId");
			addUserResponse.Success = _ctx.BooleanValue("AddUser.Success");

			AddUserResponse.AddUser_Result result = new AddUserResponse.AddUser_Result();
			result.AccountName = _ctx.StringValue("AddUser.Result.AccountName");
			result.AdminUser = _ctx.BooleanValue("AddUser.Result.AdminUser");
			result.AuthAdminUser = _ctx.BooleanValue("AddUser.Result.AuthAdminUser");
			result.Email = _ctx.StringValue("AddUser.Result.Email");
			result.NickName = _ctx.StringValue("AddUser.Result.NickName");
			result.Phone = _ctx.StringValue("AddUser.Result.Phone");
			result.UserId = _ctx.StringValue("AddUser.Result.UserId");
			result.UserType = _ctx.IntegerValue("AddUser.Result.UserType");

			List<string> result_roleIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("AddUser.Result.RoleIdList.Length"); i++) {
				result_roleIdList.Add(_ctx.StringValue("AddUser.Result.RoleIdList["+ i +"]"));
			}
			result.RoleIdList = result_roleIdList;
			addUserResponse.Result = result;
        
			return addUserResponse;
        }
    }
}
