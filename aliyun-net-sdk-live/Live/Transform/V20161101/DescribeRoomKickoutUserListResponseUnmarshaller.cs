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
    public class DescribeRoomKickoutUserListResponseUnmarshaller
    {
        public static DescribeRoomKickoutUserListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRoomKickoutUserListResponse describeRoomKickoutUserListResponse = new DescribeRoomKickoutUserListResponse();

			describeRoomKickoutUserListResponse.HttpResponse = _ctx.HttpResponse;
			describeRoomKickoutUserListResponse.RequestId = _ctx.StringValue("DescribeRoomKickoutUserList.RequestId");
			describeRoomKickoutUserListResponse.TotalNum = _ctx.IntegerValue("DescribeRoomKickoutUserList.TotalNum");
			describeRoomKickoutUserListResponse.TotalPage = _ctx.IntegerValue("DescribeRoomKickoutUserList.TotalPage");

			List<DescribeRoomKickoutUserListResponse.DescribeRoomKickoutUserList_User> describeRoomKickoutUserListResponse_userList = new List<DescribeRoomKickoutUserListResponse.DescribeRoomKickoutUserList_User>();
			for (int i = 0; i < _ctx.Length("DescribeRoomKickoutUserList.UserList.Length"); i++) {
				DescribeRoomKickoutUserListResponse.DescribeRoomKickoutUserList_User user = new DescribeRoomKickoutUserListResponse.DescribeRoomKickoutUserList_User();
				user.AppUid = _ctx.StringValue("DescribeRoomKickoutUserList.UserList["+ i +"].AppUid");
				user.OpStartTime = _ctx.StringValue("DescribeRoomKickoutUserList.UserList["+ i +"].OpStartTime");
				user.OpEndTime = _ctx.StringValue("DescribeRoomKickoutUserList.UserList["+ i +"].OpEndTime");

				describeRoomKickoutUserListResponse_userList.Add(user);
			}
			describeRoomKickoutUserListResponse.UserList = describeRoomKickoutUserListResponse_userList;
        
			return describeRoomKickoutUserListResponse;
        }
    }
}
