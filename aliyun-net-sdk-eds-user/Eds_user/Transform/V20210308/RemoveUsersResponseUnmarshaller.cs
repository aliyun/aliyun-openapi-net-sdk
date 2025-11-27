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
    public class RemoveUsersResponseUnmarshaller
    {
        public static RemoveUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveUsersResponse removeUsersResponse = new RemoveUsersResponse();

			removeUsersResponse.HttpResponse = _ctx.HttpResponse;
			removeUsersResponse.RequestId = _ctx.StringValue("RemoveUsers.RequestId");

			RemoveUsersResponse.RemoveUsers_RemoveUsersResult removeUsersResult = new RemoveUsersResponse.RemoveUsers_RemoveUsersResult();

			List<string> removeUsersResult_removedUsers = new List<string>();
			for (int i = 0; i < _ctx.Length("RemoveUsers.RemoveUsersResult.RemovedUsers.Length"); i++) {
				removeUsersResult_removedUsers.Add(_ctx.StringValue("RemoveUsers.RemoveUsersResult.RemovedUsers["+ i +"]"));
			}
			removeUsersResult.RemovedUsers = removeUsersResult_removedUsers;

			List<RemoveUsersResponse.RemoveUsers_RemoveUsersResult.RemoveUsers_FailedUsersItem> removeUsersResult_failedUsers = new List<RemoveUsersResponse.RemoveUsers_RemoveUsersResult.RemoveUsers_FailedUsersItem>();
			for (int i = 0; i < _ctx.Length("RemoveUsers.RemoveUsersResult.FailedUsers.Length"); i++) {
				RemoveUsersResponse.RemoveUsers_RemoveUsersResult.RemoveUsers_FailedUsersItem failedUsersItem = new RemoveUsersResponse.RemoveUsers_RemoveUsersResult.RemoveUsers_FailedUsersItem();
				failedUsersItem.EndUserId = _ctx.StringValue("RemoveUsers.RemoveUsersResult.FailedUsers["+ i +"].EndUserId");
				failedUsersItem.ErrorCode = _ctx.StringValue("RemoveUsers.RemoveUsersResult.FailedUsers["+ i +"].ErrorCode");
				failedUsersItem.ErrorMessage = _ctx.StringValue("RemoveUsers.RemoveUsersResult.FailedUsers["+ i +"].ErrorMessage");

				removeUsersResult_failedUsers.Add(failedUsersItem);
			}
			removeUsersResult.FailedUsers = removeUsersResult_failedUsers;
			removeUsersResponse.RemoveUsersResult = removeUsersResult;
        
			return removeUsersResponse;
        }
    }
}
