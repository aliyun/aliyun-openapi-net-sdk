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
    public class LockUsersResponseUnmarshaller
    {
        public static LockUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			LockUsersResponse lockUsersResponse = new LockUsersResponse();

			lockUsersResponse.HttpResponse = _ctx.HttpResponse;
			lockUsersResponse.RequestId = _ctx.StringValue("LockUsers.RequestId");

			LockUsersResponse.LockUsers_LockUsersResult lockUsersResult = new LockUsersResponse.LockUsers_LockUsersResult();

			List<string> lockUsersResult_lockedUsers = new List<string>();
			for (int i = 0; i < _ctx.Length("LockUsers.LockUsersResult.LockedUsers.Length"); i++) {
				lockUsersResult_lockedUsers.Add(_ctx.StringValue("LockUsers.LockUsersResult.LockedUsers["+ i +"]"));
			}
			lockUsersResult.LockedUsers = lockUsersResult_lockedUsers;

			List<LockUsersResponse.LockUsers_LockUsersResult.LockUsers_FailedUsersItem> lockUsersResult_failedUsers = new List<LockUsersResponse.LockUsers_LockUsersResult.LockUsers_FailedUsersItem>();
			for (int i = 0; i < _ctx.Length("LockUsers.LockUsersResult.FailedUsers.Length"); i++) {
				LockUsersResponse.LockUsers_LockUsersResult.LockUsers_FailedUsersItem failedUsersItem = new LockUsersResponse.LockUsers_LockUsersResult.LockUsers_FailedUsersItem();
				failedUsersItem.EndUserId = _ctx.StringValue("LockUsers.LockUsersResult.FailedUsers["+ i +"].EndUserId");
				failedUsersItem.ErrorCode = _ctx.StringValue("LockUsers.LockUsersResult.FailedUsers["+ i +"].ErrorCode");
				failedUsersItem.ErrorMessage = _ctx.StringValue("LockUsers.LockUsersResult.FailedUsers["+ i +"].ErrorMessage");

				lockUsersResult_failedUsers.Add(failedUsersItem);
			}
			lockUsersResult.FailedUsers = lockUsersResult_failedUsers;
			lockUsersResponse.LockUsersResult = lockUsersResult;
        
			return lockUsersResponse;
        }
    }
}
