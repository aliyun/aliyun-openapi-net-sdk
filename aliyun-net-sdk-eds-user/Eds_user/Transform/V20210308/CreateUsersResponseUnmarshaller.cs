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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class CreateUsersResponseUnmarshaller
    {
        public static CreateUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateUsersResponse createUsersResponse = new CreateUsersResponse();

			createUsersResponse.HttpResponse = _ctx.HttpResponse;
			createUsersResponse.RequestId = _ctx.StringValue("CreateUsers.RequestId");
			createUsersResponse.AllSucceed = _ctx.BooleanValue("CreateUsers.AllSucceed");

			CreateUsersResponse.CreateUsers_CreateResult createResult = new CreateUsersResponse.CreateUsers_CreateResult();

			List<CreateUsersResponse.CreateUsers_CreateResult.CreateUsers_CreatedUsersItem> createResult_createdUsers = new List<CreateUsersResponse.CreateUsers_CreateResult.CreateUsers_CreatedUsersItem>();
			for (int i = 0; i < _ctx.Length("CreateUsers.CreateResult.CreatedUsers.Length"); i++) {
				CreateUsersResponse.CreateUsers_CreateResult.CreateUsers_CreatedUsersItem createdUsersItem = new CreateUsersResponse.CreateUsers_CreateResult.CreateUsers_CreatedUsersItem();
				createdUsersItem.EndUserId = _ctx.StringValue("CreateUsers.CreateResult.CreatedUsers["+ i +"].EndUserId");
				createdUsersItem.Email = _ctx.StringValue("CreateUsers.CreateResult.CreatedUsers["+ i +"].Email");
				createdUsersItem.Phone = _ctx.StringValue("CreateUsers.CreateResult.CreatedUsers["+ i +"].Phone");
				createdUsersItem.Remark = _ctx.StringValue("CreateUsers.CreateResult.CreatedUsers["+ i +"].Remark");
				createdUsersItem.RealNickName = _ctx.StringValue("CreateUsers.CreateResult.CreatedUsers["+ i +"].RealNickName");

				createResult_createdUsers.Add(createdUsersItem);
			}
			createResult.CreatedUsers = createResult_createdUsers;

			List<CreateUsersResponse.CreateUsers_CreateResult.CreateUsers_FailedUsersItem> createResult_failedUsers = new List<CreateUsersResponse.CreateUsers_CreateResult.CreateUsers_FailedUsersItem>();
			for (int i = 0; i < _ctx.Length("CreateUsers.CreateResult.FailedUsers.Length"); i++) {
				CreateUsersResponse.CreateUsers_CreateResult.CreateUsers_FailedUsersItem failedUsersItem = new CreateUsersResponse.CreateUsers_CreateResult.CreateUsers_FailedUsersItem();
				failedUsersItem.EndUserId = _ctx.StringValue("CreateUsers.CreateResult.FailedUsers["+ i +"].EndUserId");
				failedUsersItem.Email = _ctx.StringValue("CreateUsers.CreateResult.FailedUsers["+ i +"].Email");
				failedUsersItem.Phone = _ctx.StringValue("CreateUsers.CreateResult.FailedUsers["+ i +"].Phone");
				failedUsersItem.ErrorCode = _ctx.StringValue("CreateUsers.CreateResult.FailedUsers["+ i +"].ErrorCode");
				failedUsersItem.ErrorMessage = _ctx.StringValue("CreateUsers.CreateResult.FailedUsers["+ i +"].ErrorMessage");

				createResult_failedUsers.Add(failedUsersItem);
			}
			createResult.FailedUsers = createResult_failedUsers;
			createUsersResponse.CreateResult = createResult;
        
			return createUsersResponse;
        }
    }
}
