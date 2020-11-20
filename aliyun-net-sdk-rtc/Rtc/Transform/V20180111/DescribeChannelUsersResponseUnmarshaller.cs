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
    public class DescribeChannelUsersResponseUnmarshaller
    {
        public static DescribeChannelUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeChannelUsersResponse describeChannelUsersResponse = new DescribeChannelUsersResponse();

			describeChannelUsersResponse.HttpResponse = _ctx.HttpResponse;
			describeChannelUsersResponse.RequestId = _ctx.StringValue("DescribeChannelUsers.RequestId");
			describeChannelUsersResponse.Timestamp = _ctx.IntegerValue("DescribeChannelUsers.Timestamp");
			describeChannelUsersResponse.IsChannelExist = _ctx.BooleanValue("DescribeChannelUsers.IsChannelExist");
			describeChannelUsersResponse.ChannelProfile = _ctx.IntegerValue("DescribeChannelUsers.ChannelProfile");
			describeChannelUsersResponse.CommTotalNum = _ctx.IntegerValue("DescribeChannelUsers.CommTotalNum");
			describeChannelUsersResponse.InteractiveUserNum = _ctx.IntegerValue("DescribeChannelUsers.InteractiveUserNum");
			describeChannelUsersResponse.LiveUserNum = _ctx.IntegerValue("DescribeChannelUsers.LiveUserNum");

			List<string> describeChannelUsersResponse_userList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeChannelUsers.UserList.Length"); i++) {
				describeChannelUsersResponse_userList.Add(_ctx.StringValue("DescribeChannelUsers.UserList["+ i +"]"));
			}
			describeChannelUsersResponse.UserList = describeChannelUsersResponse_userList;

			List<string> describeChannelUsersResponse_interactiveUserList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeChannelUsers.InteractiveUserList.Length"); i++) {
				describeChannelUsersResponse_interactiveUserList.Add(_ctx.StringValue("DescribeChannelUsers.InteractiveUserList["+ i +"]"));
			}
			describeChannelUsersResponse.InteractiveUserList = describeChannelUsersResponse_interactiveUserList;

			List<string> describeChannelUsersResponse_liveUserList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeChannelUsers.LiveUserList.Length"); i++) {
				describeChannelUsersResponse_liveUserList.Add(_ctx.StringValue("DescribeChannelUsers.LiveUserList["+ i +"]"));
			}
			describeChannelUsersResponse.LiveUserList = describeChannelUsersResponse_liveUserList;
        
			return describeChannelUsersResponse;
        }
    }
}
