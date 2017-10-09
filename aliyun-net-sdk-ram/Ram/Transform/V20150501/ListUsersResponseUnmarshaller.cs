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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ram.Model.V20150501;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext context)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = context.HttpResponse;
			listUsersResponse.RequestId = context.StringValue("ListUsers.RequestId");
			listUsersResponse.IsTruncated = context.BooleanValue("ListUsers.IsTruncated");
			listUsersResponse.Marker = context.StringValue("ListUsers.Marker");

			List<ListUsersResponse.ListUsers_User> listUsersResponse_users = new List<ListUsersResponse.ListUsers_User>();
			for (int i = 0; i < context.Length("ListUsers.Users.Length"); i++) {
				ListUsersResponse.ListUsers_User user = new ListUsersResponse.ListUsers_User();
				user.UserId = context.StringValue("ListUsers.Users["+ i +"].UserId");
				user.UserName = context.StringValue("ListUsers.Users["+ i +"].UserName");
				user.DisplayName = context.StringValue("ListUsers.Users["+ i +"].DisplayName");
				user.MobilePhone = context.StringValue("ListUsers.Users["+ i +"].MobilePhone");
				user.Email = context.StringValue("ListUsers.Users["+ i +"].Email");
				user.Comments = context.StringValue("ListUsers.Users["+ i +"].Comments");
				user.CreateDate = context.StringValue("ListUsers.Users["+ i +"].CreateDate");
				user.UpdateDate = context.StringValue("ListUsers.Users["+ i +"].UpdateDate");

				listUsersResponse_users.Add(user);
			}
			listUsersResponse.Users = listUsersResponse_users;
        
			return listUsersResponse;
        }
    }
}