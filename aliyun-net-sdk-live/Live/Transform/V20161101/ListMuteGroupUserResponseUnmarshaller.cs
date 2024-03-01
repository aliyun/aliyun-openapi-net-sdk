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
    public class ListMuteGroupUserResponseUnmarshaller
    {
        public static ListMuteGroupUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMuteGroupUserResponse listMuteGroupUserResponse = new ListMuteGroupUserResponse();

			listMuteGroupUserResponse.HttpResponse = _ctx.HttpResponse;
			listMuteGroupUserResponse.RequestId = _ctx.StringValue("ListMuteGroupUser.RequestId");

			ListMuteGroupUserResponse.ListMuteGroupUser_Result result = new ListMuteGroupUserResponse.ListMuteGroupUser_Result();
			result.Total = _ctx.IntegerValue("ListMuteGroupUser.Result.Total");
			result.HasMore = _ctx.BooleanValue("ListMuteGroupUser.Result.HasMore");

			List<ListMuteGroupUserResponse.ListMuteGroupUser_Result.ListMuteGroupUser_UserListItem> result_userList = new List<ListMuteGroupUserResponse.ListMuteGroupUser_Result.ListMuteGroupUser_UserListItem>();
			for (int i = 0; i < _ctx.Length("ListMuteGroupUser.Result.UserList.Length"); i++) {
				ListMuteGroupUserResponse.ListMuteGroupUser_Result.ListMuteGroupUser_UserListItem userListItem = new ListMuteGroupUserResponse.ListMuteGroupUser_Result.ListMuteGroupUser_UserListItem();
				userListItem.UserId = _ctx.StringValue("ListMuteGroupUser.Result.UserList["+ i +"].UserId");

				result_userList.Add(userListItem);
			}
			result.UserList = result_userList;
			listMuteGroupUserResponse.Result = result;
        
			return listMuteGroupUserResponse;
        }
    }
}
