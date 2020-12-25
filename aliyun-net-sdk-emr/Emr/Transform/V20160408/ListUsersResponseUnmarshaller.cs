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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = _ctx.HttpResponse;
			listUsersResponse.RequestId = _ctx.StringValue("ListUsers.RequestId");

			List<ListUsersResponse.ListUsers_User> listUsersResponse_userList = new List<ListUsersResponse.ListUsers_User>();
			for (int i = 0; i < _ctx.Length("ListUsers.UserList.Length"); i++) {
				ListUsersResponse.ListUsers_User user = new ListUsersResponse.ListUsers_User();
				user.UserName = _ctx.StringValue("ListUsers.UserList["+ i +"].UserName");
				user.GroupName = _ctx.StringValue("ListUsers.UserList["+ i +"].GroupName");
				user.UserId = _ctx.StringValue("ListUsers.UserList["+ i +"].UserId");
				user.KnoxStatus = _ctx.StringValue("ListUsers.UserList["+ i +"].KnoxStatus");
				user.LinuxStatus = _ctx.StringValue("ListUsers.UserList["+ i +"].LinuxStatus");
				user.KerberosStatus = _ctx.StringValue("ListUsers.UserList["+ i +"].KerberosStatus");
				user.K8sStatus = _ctx.StringValue("ListUsers.UserList["+ i +"].K8sStatus");

				listUsersResponse_userList.Add(user);
			}
			listUsersResponse.UserList = listUsersResponse_userList;
        
			return listUsersResponse;
        }
    }
}
