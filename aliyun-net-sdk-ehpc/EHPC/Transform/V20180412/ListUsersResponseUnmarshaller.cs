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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = _ctx.HttpResponse;
			listUsersResponse.RequestId = _ctx.StringValue("ListUsers.RequestId");
			listUsersResponse.TotalCount = _ctx.IntegerValue("ListUsers.TotalCount");
			listUsersResponse.PageNumber = _ctx.IntegerValue("ListUsers.PageNumber");
			listUsersResponse.PageSize = _ctx.IntegerValue("ListUsers.PageSize");

			List<ListUsersResponse.ListUsers_UserInfo> listUsersResponse_users = new List<ListUsersResponse.ListUsers_UserInfo>();
			for (int i = 0; i < _ctx.Length("ListUsers.Users.Length"); i++) {
				ListUsersResponse.ListUsers_UserInfo userInfo = new ListUsersResponse.ListUsers_UserInfo();
				userInfo.Name = _ctx.StringValue("ListUsers.Users["+ i +"].Name");
				userInfo.Group = _ctx.StringValue("ListUsers.Users["+ i +"].Group");
				userInfo.AddTime = _ctx.StringValue("ListUsers.Users["+ i +"].AddTime");

				listUsersResponse_users.Add(userInfo);
			}
			listUsersResponse.Users = listUsersResponse_users;
        
			return listUsersResponse;
        }
    }
}
