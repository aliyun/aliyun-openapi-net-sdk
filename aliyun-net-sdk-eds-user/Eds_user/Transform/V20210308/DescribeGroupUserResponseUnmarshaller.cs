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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class DescribeGroupUserResponseUnmarshaller
    {
        public static DescribeGroupUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupUserResponse describeGroupUserResponse = new DescribeGroupUserResponse();

			describeGroupUserResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupUserResponse.RequestId = _ctx.StringValue("DescribeGroupUser.RequestId");

			List<DescribeGroupUserResponse.DescribeGroupUser_Group> describeGroupUserResponse_groups = new List<DescribeGroupUserResponse.DescribeGroupUser_Group>();
			for (int i = 0; i < _ctx.Length("DescribeGroupUser.Groups.Length"); i++) {
				DescribeGroupUserResponse.DescribeGroupUser_Group group = new DescribeGroupUserResponse.DescribeGroupUser_Group();
				group.GroupName = _ctx.StringValue("DescribeGroupUser.Groups["+ i +"].GroupName");
				group.GroupId = _ctx.StringValue("DescribeGroupUser.Groups["+ i +"].GroupId");
				group.UserCount = _ctx.StringValue("DescribeGroupUser.Groups["+ i +"].UserCount");

				describeGroupUserResponse_groups.Add(group);
			}
			describeGroupUserResponse.Groups = describeGroupUserResponse_groups;

			List<DescribeGroupUserResponse.DescribeGroupUser_User> describeGroupUserResponse_users = new List<DescribeGroupUserResponse.DescribeGroupUser_User>();
			for (int i = 0; i < _ctx.Length("DescribeGroupUser.Users.Length"); i++) {
				DescribeGroupUserResponse.DescribeGroupUser_User user = new DescribeGroupUserResponse.DescribeGroupUser_User();
				user.EndUserId = _ctx.StringValue("DescribeGroupUser.Users["+ i +"].EndUserId");
				user.Avatar = _ctx.StringValue("DescribeGroupUser.Users["+ i +"].Avatar");
				user.Address = _ctx.StringValue("DescribeGroupUser.Users["+ i +"].Address");
				user.Phone = _ctx.StringValue("DescribeGroupUser.Users["+ i +"].Phone");
				user.Email = _ctx.StringValue("DescribeGroupUser.Users["+ i +"].Email");
				user.NickName = _ctx.StringValue("DescribeGroupUser.Users["+ i +"].NickName");
				user.JobNumber = _ctx.StringValue("DescribeGroupUser.Users["+ i +"].JobNumber");
				user.GmtJoinGroup = _ctx.StringValue("DescribeGroupUser.Users["+ i +"].GmtJoinGroup");
				user.GmtCreated = _ctx.StringValue("DescribeGroupUser.Users["+ i +"].GmtCreated");

				describeGroupUserResponse_users.Add(user);
			}
			describeGroupUserResponse.Users = describeGroupUserResponse_users;
        
			return describeGroupUserResponse;
        }
    }
}
