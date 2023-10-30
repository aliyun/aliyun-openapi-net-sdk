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
    public class CheckLiveMessageUsersOnlineResponseUnmarshaller
    {
        public static CheckLiveMessageUsersOnlineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckLiveMessageUsersOnlineResponse checkLiveMessageUsersOnlineResponse = new CheckLiveMessageUsersOnlineResponse();

			checkLiveMessageUsersOnlineResponse.HttpResponse = _ctx.HttpResponse;
			checkLiveMessageUsersOnlineResponse.RequestId = _ctx.StringValue("CheckLiveMessageUsersOnline.RequestId");

			List<CheckLiveMessageUsersOnlineResponse.CheckLiveMessageUsersOnline_Users> checkLiveMessageUsersOnlineResponse_userList = new List<CheckLiveMessageUsersOnlineResponse.CheckLiveMessageUsersOnline_Users>();
			for (int i = 0; i < _ctx.Length("CheckLiveMessageUsersOnline.UserList.Length"); i++) {
				CheckLiveMessageUsersOnlineResponse.CheckLiveMessageUsersOnline_Users users = new CheckLiveMessageUsersOnlineResponse.CheckLiveMessageUsersOnline_Users();
				users.UserId = _ctx.StringValue("CheckLiveMessageUsersOnline.UserList["+ i +"].UserId");
				users.Online = _ctx.BooleanValue("CheckLiveMessageUsersOnline.UserList["+ i +"].Online");

				checkLiveMessageUsersOnlineResponse_userList.Add(users);
			}
			checkLiveMessageUsersOnlineResponse.UserList = checkLiveMessageUsersOnlineResponse_userList;
        
			return checkLiveMessageUsersOnlineResponse;
        }
    }
}
