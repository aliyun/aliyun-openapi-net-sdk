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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRtcUserListResponseUnmarshaller
    {
        public static DescribeRtcUserListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcUserListResponse describeRtcUserListResponse = new DescribeRtcUserListResponse();

			describeRtcUserListResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcUserListResponse.RequestId = _ctx.StringValue("DescribeRtcUserList.RequestId");

			List<DescribeRtcUserListResponse.DescribeRtcUserList_UserListItem> describeRtcUserListResponse_userList = new List<DescribeRtcUserListResponse.DescribeRtcUserList_UserListItem>();
			for (int i = 0; i < _ctx.Length("DescribeRtcUserList.UserList.Length"); i++) {
				DescribeRtcUserListResponse.DescribeRtcUserList_UserListItem userListItem = new DescribeRtcUserListResponse.DescribeRtcUserList_UserListItem();
				userListItem.User = _ctx.StringValue("DescribeRtcUserList.UserList["+ i +"].User");

				describeRtcUserListResponse_userList.Add(userListItem);
			}
			describeRtcUserListResponse.UserList = describeRtcUserListResponse_userList;
        
			return describeRtcUserListResponse;
        }
    }
}
