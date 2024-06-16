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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class CheckLiveMessageUsersInGroupResponseUnmarshaller
    {
        public static CheckLiveMessageUsersInGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckLiveMessageUsersInGroupResponse checkLiveMessageUsersInGroupResponse = new CheckLiveMessageUsersInGroupResponse();

			checkLiveMessageUsersInGroupResponse.HttpResponse = _ctx.HttpResponse;
			checkLiveMessageUsersInGroupResponse.RequestId = _ctx.StringValue("CheckLiveMessageUsersInGroup.RequestId");

			List<CheckLiveMessageUsersInGroupResponse.CheckLiveMessageUsersInGroup_UsersItem> checkLiveMessageUsersInGroupResponse_users = new List<CheckLiveMessageUsersInGroupResponse.CheckLiveMessageUsersInGroup_UsersItem>();
			for (int i = 0; i < _ctx.Length("CheckLiveMessageUsersInGroup.Users.Length"); i++) {
				CheckLiveMessageUsersInGroupResponse.CheckLiveMessageUsersInGroup_UsersItem usersItem = new CheckLiveMessageUsersInGroupResponse.CheckLiveMessageUsersInGroup_UsersItem();
				usersItem.UserId = _ctx.StringValue("CheckLiveMessageUsersInGroup.Users["+ i +"].UserId");
				usersItem.Online = _ctx.BooleanValue("CheckLiveMessageUsersInGroup.Users["+ i +"].Online");

				checkLiveMessageUsersInGroupResponse_users.Add(usersItem);
			}
			checkLiveMessageUsersInGroupResponse.Users = checkLiveMessageUsersInGroupResponse_users;
        
			return checkLiveMessageUsersInGroupResponse;
        }
    }
}
