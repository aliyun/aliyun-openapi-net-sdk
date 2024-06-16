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
    public class ListMessageGroupUserByIdResponseUnmarshaller
    {
        public static ListMessageGroupUserByIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMessageGroupUserByIdResponse listMessageGroupUserByIdResponse = new ListMessageGroupUserByIdResponse();

			listMessageGroupUserByIdResponse.HttpResponse = _ctx.HttpResponse;
			listMessageGroupUserByIdResponse.RequestId = _ctx.StringValue("ListMessageGroupUserById.RequestId");

			ListMessageGroupUserByIdResponse.ListMessageGroupUserById_Result result = new ListMessageGroupUserByIdResponse.ListMessageGroupUserById_Result();
			result.HasMore = _ctx.BooleanValue("ListMessageGroupUserById.Result.HasMore");
			result.Total = _ctx.IntegerValue("ListMessageGroupUserById.Result.Total");

			List<ListMessageGroupUserByIdResponse.ListMessageGroupUserById_Result.ListMessageGroupUserById_UserListItem> result_userList = new List<ListMessageGroupUserByIdResponse.ListMessageGroupUserById_Result.ListMessageGroupUserById_UserListItem>();
			for (int i = 0; i < _ctx.Length("ListMessageGroupUserById.Result.UserList.Length"); i++) {
				ListMessageGroupUserByIdResponse.ListMessageGroupUserById_Result.ListMessageGroupUserById_UserListItem userListItem = new ListMessageGroupUserByIdResponse.ListMessageGroupUserById_Result.ListMessageGroupUserById_UserListItem();
				userListItem.IsMute = _ctx.BooleanValue("ListMessageGroupUserById.Result.UserList["+ i +"].IsMute");
				userListItem.UserAvatar = _ctx.StringValue("ListMessageGroupUserById.Result.UserList["+ i +"].UserAvatar");
				userListItem.UserExtension = _ctx.StringValue("ListMessageGroupUserById.Result.UserList["+ i +"].UserExtension");
				userListItem.UserId = _ctx.StringValue("ListMessageGroupUserById.Result.UserList["+ i +"].UserId");
				userListItem.UserNick = _ctx.StringValue("ListMessageGroupUserById.Result.UserList["+ i +"].UserNick");

				List<string> userListItem_muteBy = new List<string>();
				for (int j = 0; j < _ctx.Length("ListMessageGroupUserById.Result.UserList["+ i +"].MuteBy.Length"); j++) {
					userListItem_muteBy.Add(_ctx.StringValue("ListMessageGroupUserById.Result.UserList["+ i +"].MuteBy["+ j +"]"));
				}
				userListItem.MuteBy = userListItem_muteBy;

				result_userList.Add(userListItem);
			}
			result.UserList = result_userList;
			listMessageGroupUserByIdResponse.Result = result;
        
			return listMessageGroupUserByIdResponse;
        }
    }
}
