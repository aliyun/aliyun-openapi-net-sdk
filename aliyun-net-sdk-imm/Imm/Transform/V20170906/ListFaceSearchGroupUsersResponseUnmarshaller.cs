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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListFaceSearchGroupUsersResponseUnmarshaller
    {
        public static ListFaceSearchGroupUsersResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceSearchGroupUsersResponse listFaceSearchGroupUsersResponse = new ListFaceSearchGroupUsersResponse();

			listFaceSearchGroupUsersResponse.HttpResponse = context.HttpResponse;
			listFaceSearchGroupUsersResponse.RequestId = context.StringValue("ListFaceSearchGroupUsers.RequestId");
			listFaceSearchGroupUsersResponse.NextMarker = context.StringValue("ListFaceSearchGroupUsers.NextMarker");
			listFaceSearchGroupUsersResponse.GroupName = context.StringValue("ListFaceSearchGroupUsers.GroupName");
			listFaceSearchGroupUsersResponse.GroupId = context.StringValue("ListFaceSearchGroupUsers.GroupId");

			List<ListFaceSearchGroupUsersResponse.ListFaceSearchGroupUsers_UsersItem> listFaceSearchGroupUsersResponse_users = new List<ListFaceSearchGroupUsersResponse.ListFaceSearchGroupUsers_UsersItem>();
			for (int i = 0; i < context.Length("ListFaceSearchGroupUsers.Users.Length"); i++) {
				ListFaceSearchGroupUsersResponse.ListFaceSearchGroupUsers_UsersItem usersItem = new ListFaceSearchGroupUsersResponse.ListFaceSearchGroupUsers_UsersItem();
				usersItem.User = context.StringValue("ListFaceSearchGroupUsers.Users["+ i +"].User");
				usersItem.Count = context.StringValue("ListFaceSearchGroupUsers.Users["+ i +"].Count");
				usersItem.Status = context.StringValue("ListFaceSearchGroupUsers.Users["+ i +"].Status");
				usersItem.CreateTime = context.StringValue("ListFaceSearchGroupUsers.Users["+ i +"].CreateTime");
				usersItem.ModifyTime = context.StringValue("ListFaceSearchGroupUsers.Users["+ i +"].ModifyTime");

				listFaceSearchGroupUsersResponse_users.Add(usersItem);
			}
			listFaceSearchGroupUsersResponse.Users = listFaceSearchGroupUsersResponse_users;
        
			return listFaceSearchGroupUsersResponse;
        }
    }
}
