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
    public class ListLiveMessageGroupUsersResponseUnmarshaller
    {
        public static ListLiveMessageGroupUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveMessageGroupUsersResponse listLiveMessageGroupUsersResponse = new ListLiveMessageGroupUsersResponse();

			listLiveMessageGroupUsersResponse.HttpResponse = _ctx.HttpResponse;
			listLiveMessageGroupUsersResponse.RequestId = _ctx.StringValue("ListLiveMessageGroupUsers.RequestId");
			listLiveMessageGroupUsersResponse.GroupId = _ctx.StringValue("ListLiveMessageGroupUsers.GroupId");
			listLiveMessageGroupUsersResponse.NextPageToken = _ctx.LongValue("ListLiveMessageGroupUsers.NextPageToken");
			listLiveMessageGroupUsersResponse.Hasmore = _ctx.BooleanValue("ListLiveMessageGroupUsers.Hasmore");

			List<ListLiveMessageGroupUsersResponse.ListLiveMessageGroupUsers_Users> listLiveMessageGroupUsersResponse_userList = new List<ListLiveMessageGroupUsersResponse.ListLiveMessageGroupUsers_Users>();
			for (int i = 0; i < _ctx.Length("ListLiveMessageGroupUsers.UserList.Length"); i++) {
				ListLiveMessageGroupUsersResponse.ListLiveMessageGroupUsers_Users users = new ListLiveMessageGroupUsersResponse.ListLiveMessageGroupUsers_Users();
				users.UserId = _ctx.StringValue("ListLiveMessageGroupUsers.UserList["+ i +"].UserId");
				users.UserInfo = _ctx.StringValue("ListLiveMessageGroupUsers.UserList["+ i +"].UserInfo");

				listLiveMessageGroupUsersResponse_userList.Add(users);
			}
			listLiveMessageGroupUsersResponse.UserList = listLiveMessageGroupUsersResponse_userList;
        
			return listLiveMessageGroupUsersResponse;
        }
    }
}
