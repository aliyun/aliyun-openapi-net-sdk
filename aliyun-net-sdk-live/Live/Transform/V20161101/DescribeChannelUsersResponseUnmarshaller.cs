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
    public class DescribeChannelUsersResponseUnmarshaller
    {
        public static DescribeChannelUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeChannelUsersResponse describeChannelUsersResponse = new DescribeChannelUsersResponse();

			describeChannelUsersResponse.HttpResponse = _ctx.HttpResponse;
			describeChannelUsersResponse.RequestId = _ctx.StringValue("DescribeChannelUsers.RequestId");
			describeChannelUsersResponse.Timestamp = _ctx.LongValue("DescribeChannelUsers.Timestamp");
			describeChannelUsersResponse.IsChannelExists = _ctx.BooleanValue("DescribeChannelUsers.IsChannelExists");
			describeChannelUsersResponse.InteractiveUserNumber = _ctx.IntegerValue("DescribeChannelUsers.InteractiveUserNumber");
			describeChannelUsersResponse.LiveUserNumber = _ctx.IntegerValue("DescribeChannelUsers.LiveUserNumber");

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
