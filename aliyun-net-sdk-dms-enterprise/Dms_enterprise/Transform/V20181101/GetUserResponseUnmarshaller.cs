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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = context.HttpResponse;
			getUserResponse.RequestId = context.StringValue("GetUser.RequestId");
			getUserResponse.Success = context.BooleanValue("GetUser.Success");
			getUserResponse.ErrorMessage = context.StringValue("GetUser.ErrorMessage");
			getUserResponse.ErrorCode = context.StringValue("GetUser.ErrorCode");

			GetUserResponse.GetUser_User user = new GetUserResponse.GetUser_User();
			user.UserId = context.StringValue("GetUser.User.UserId");
			user.Uid = context.LongValue("GetUser.User.Uid");
			user.NickName = context.StringValue("GetUser.User.NickName");
			user.Mobile = context.StringValue("GetUser.User.Mobile");
			user.ParentUid = context.LongValue("GetUser.User.ParentUid");
			user.State = context.StringValue("GetUser.User.State");

			List<string> user_roleIdList = new List<string>();
			for (int i = 0; i < context.Length("GetUser.User.RoleIdList.Length"); i++) {
				user_roleIdList.Add(context.StringValue("GetUser.User.RoleIdList["+ i +"]"));
			}
			user.RoleIdList = user_roleIdList;

			List<string> user_roleNameList = new List<string>();
			for (int i = 0; i < context.Length("GetUser.User.RoleNameList.Length"); i++) {
				user_roleNameList.Add(context.StringValue("GetUser.User.RoleNameList["+ i +"]"));
			}
			user.RoleNameList = user_roleNameList;
			getUserResponse.User = user;
        
			return getUserResponse;
        }
    }
}
