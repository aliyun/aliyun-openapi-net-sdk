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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class ListUsersForGroupResponseUnmarshaller
    {
        public static ListUsersForGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersForGroupResponse listUsersForGroupResponse = new ListUsersForGroupResponse();

			listUsersForGroupResponse.HttpResponse = _ctx.HttpResponse;
			listUsersForGroupResponse.RequestId = _ctx.StringValue("ListUsersForGroup.RequestId");
			listUsersForGroupResponse.IsTruncated = _ctx.BooleanValue("ListUsersForGroup.IsTruncated");
			listUsersForGroupResponse.Marker = _ctx.StringValue("ListUsersForGroup.Marker");

			List<ListUsersForGroupResponse.ListUsersForGroup_User> listUsersForGroupResponse_users = new List<ListUsersForGroupResponse.ListUsersForGroup_User>();
			for (int i = 0; i < _ctx.Length("ListUsersForGroup.Users.Length"); i++) {
				ListUsersForGroupResponse.ListUsersForGroup_User user = new ListUsersForGroupResponse.ListUsersForGroup_User();
				user.UserPrincipalName = _ctx.StringValue("ListUsersForGroup.Users["+ i +"].UserPrincipalName");
				user.DisplayName = _ctx.StringValue("ListUsersForGroup.Users["+ i +"].DisplayName");
				user.UserId = _ctx.StringValue("ListUsersForGroup.Users["+ i +"].UserId");
				user.JoinDate = _ctx.StringValue("ListUsersForGroup.Users["+ i +"].JoinDate");

				listUsersForGroupResponse_users.Add(user);
			}
			listUsersForGroupResponse.Users = listUsersForGroupResponse_users;
        
			return listUsersForGroupResponse;
        }
    }
}
