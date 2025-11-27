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
    public class UnlockUsersResponseUnmarshaller
    {
        public static UnlockUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnlockUsersResponse unlockUsersResponse = new UnlockUsersResponse();

			unlockUsersResponse.HttpResponse = _ctx.HttpResponse;
			unlockUsersResponse.RequestId = _ctx.StringValue("UnlockUsers.RequestId");

			UnlockUsersResponse.UnlockUsers_UnlockUsersResult unlockUsersResult = new UnlockUsersResponse.UnlockUsers_UnlockUsersResult();

			List<string> unlockUsersResult_unlockedUsers = new List<string>();
			for (int i = 0; i < _ctx.Length("UnlockUsers.UnlockUsersResult.UnlockedUsers.Length"); i++) {
				unlockUsersResult_unlockedUsers.Add(_ctx.StringValue("UnlockUsers.UnlockUsersResult.UnlockedUsers["+ i +"]"));
			}
			unlockUsersResult.UnlockedUsers = unlockUsersResult_unlockedUsers;

			List<UnlockUsersResponse.UnlockUsers_UnlockUsersResult.UnlockUsers_FailedUsersItem> unlockUsersResult_failedUsers = new List<UnlockUsersResponse.UnlockUsers_UnlockUsersResult.UnlockUsers_FailedUsersItem>();
			for (int i = 0; i < _ctx.Length("UnlockUsers.UnlockUsersResult.FailedUsers.Length"); i++) {
				UnlockUsersResponse.UnlockUsers_UnlockUsersResult.UnlockUsers_FailedUsersItem failedUsersItem = new UnlockUsersResponse.UnlockUsers_UnlockUsersResult.UnlockUsers_FailedUsersItem();
				failedUsersItem.EndUserId = _ctx.StringValue("UnlockUsers.UnlockUsersResult.FailedUsers["+ i +"].EndUserId");
				failedUsersItem.ErrorCode = _ctx.StringValue("UnlockUsers.UnlockUsersResult.FailedUsers["+ i +"].ErrorCode");
				failedUsersItem.ErrorMessage = _ctx.StringValue("UnlockUsers.UnlockUsersResult.FailedUsers["+ i +"].ErrorMessage");

				unlockUsersResult_failedUsers.Add(failedUsersItem);
			}
			unlockUsersResult.FailedUsers = unlockUsersResult_failedUsers;
			unlockUsersResponse.UnlockUsersResult = unlockUsersResult;
        
			return unlockUsersResponse;
        }
    }
}
