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
    public class ResetUserPasswordResponseUnmarshaller
    {
        public static ResetUserPasswordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ResetUserPasswordResponse resetUserPasswordResponse = new ResetUserPasswordResponse();

			resetUserPasswordResponse.HttpResponse = _ctx.HttpResponse;
			resetUserPasswordResponse.RequestId = _ctx.StringValue("ResetUserPassword.RequestId");

			ResetUserPasswordResponse.ResetUserPassword_ResetUsersResult resetUsersResult = new ResetUserPasswordResponse.ResetUserPassword_ResetUsersResult();

			List<string> resetUsersResult_resetUsers = new List<string>();
			for (int i = 0; i < _ctx.Length("ResetUserPassword.ResetUsersResult.ResetUsers.Length"); i++) {
				resetUsersResult_resetUsers.Add(_ctx.StringValue("ResetUserPassword.ResetUsersResult.ResetUsers["+ i +"]"));
			}
			resetUsersResult.ResetUsers = resetUsersResult_resetUsers;

			List<ResetUserPasswordResponse.ResetUserPassword_ResetUsersResult.ResetUserPassword_FailedUsersItem> resetUsersResult_failedUsers = new List<ResetUserPasswordResponse.ResetUserPassword_ResetUsersResult.ResetUserPassword_FailedUsersItem>();
			for (int i = 0; i < _ctx.Length("ResetUserPassword.ResetUsersResult.FailedUsers.Length"); i++) {
				ResetUserPasswordResponse.ResetUserPassword_ResetUsersResult.ResetUserPassword_FailedUsersItem failedUsersItem = new ResetUserPasswordResponse.ResetUserPassword_ResetUsersResult.ResetUserPassword_FailedUsersItem();
				failedUsersItem.EndUserId = _ctx.StringValue("ResetUserPassword.ResetUsersResult.FailedUsers["+ i +"].EndUserId");
				failedUsersItem.ErrorCode = _ctx.StringValue("ResetUserPassword.ResetUsersResult.FailedUsers["+ i +"].ErrorCode");
				failedUsersItem.ErrorMessage = _ctx.StringValue("ResetUserPassword.ResetUsersResult.FailedUsers["+ i +"].ErrorMessage");

				resetUsersResult_failedUsers.Add(failedUsersItem);
			}
			resetUsersResult.FailedUsers = resetUsersResult_failedUsers;
			resetUserPasswordResponse.ResetUsersResult = resetUsersResult;
        
			return resetUserPasswordResponse;
        }
    }
}
