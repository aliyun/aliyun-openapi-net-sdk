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
    public class ListMessageGroupUserResponseUnmarshaller
    {
        public static ListMessageGroupUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMessageGroupUserResponse listMessageGroupUserResponse = new ListMessageGroupUserResponse();

			listMessageGroupUserResponse.HttpResponse = _ctx.HttpResponse;
			listMessageGroupUserResponse.RequestId = _ctx.StringValue("ListMessageGroupUser.RequestId");

			ListMessageGroupUserResponse.ListMessageGroupUser_Result result = new ListMessageGroupUserResponse.ListMessageGroupUser_Result();
			result.HasMore = _ctx.BooleanValue("ListMessageGroupUser.Result.HasMore");
			result.Total = _ctx.IntegerValue("ListMessageGroupUser.Result.Total");

			List<ListMessageGroupUserResponse.ListMessageGroupUser_Result.ListMessageGroupUser_UserListItem> result_userList = new List<ListMessageGroupUserResponse.ListMessageGroupUser_Result.ListMessageGroupUser_UserListItem>();
			for (int i = 0; i < _ctx.Length("ListMessageGroupUser.Result.UserList.Length"); i++) {
				ListMessageGroupUserResponse.ListMessageGroupUser_Result.ListMessageGroupUser_UserListItem userListItem = new ListMessageGroupUserResponse.ListMessageGroupUser_Result.ListMessageGroupUser_UserListItem();
				userListItem.JoinTime = _ctx.LongValue("ListMessageGroupUser.Result.UserList["+ i +"].JoinTime");
				userListItem.UserId = _ctx.StringValue("ListMessageGroupUser.Result.UserList["+ i +"].UserId");

				result_userList.Add(userListItem);
			}
			result.UserList = result_userList;
			listMessageGroupUserResponse.Result = result;
        
			return listMessageGroupUserResponse;
        }
    }
}
