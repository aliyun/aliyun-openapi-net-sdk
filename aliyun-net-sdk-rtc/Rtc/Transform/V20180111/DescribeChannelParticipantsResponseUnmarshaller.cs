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
    public class DescribeChannelParticipantsResponseUnmarshaller
    {
        public static DescribeChannelParticipantsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeChannelParticipantsResponse describeChannelParticipantsResponse = new DescribeChannelParticipantsResponse();

			describeChannelParticipantsResponse.HttpResponse = _ctx.HttpResponse;
			describeChannelParticipantsResponse.RequestId = _ctx.StringValue("DescribeChannelParticipants.RequestId");
			describeChannelParticipantsResponse.Timestamp = _ctx.IntegerValue("DescribeChannelParticipants.Timestamp");
			describeChannelParticipantsResponse.TotalNum = _ctx.IntegerValue("DescribeChannelParticipants.TotalNum");
			describeChannelParticipantsResponse.TotalPage = _ctx.IntegerValue("DescribeChannelParticipants.TotalPage");

			List<string> describeChannelParticipantsResponse_userList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeChannelParticipants.UserList.Length"); i++) {
				describeChannelParticipantsResponse_userList.Add(_ctx.StringValue("DescribeChannelParticipants.UserList["+ i +"]"));
			}
			describeChannelParticipantsResponse.UserList = describeChannelParticipantsResponse_userList;
        
			return describeChannelParticipantsResponse;
        }
    }
}
