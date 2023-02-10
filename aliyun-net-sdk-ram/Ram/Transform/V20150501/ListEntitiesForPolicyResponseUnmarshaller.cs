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
using Aliyun.Acs.Ram.Model.V20150501;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class ListEntitiesForPolicyResponseUnmarshaller
    {
        public static ListEntitiesForPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEntitiesForPolicyResponse listEntitiesForPolicyResponse = new ListEntitiesForPolicyResponse();

			listEntitiesForPolicyResponse.HttpResponse = _ctx.HttpResponse;
			listEntitiesForPolicyResponse.RequestId = _ctx.StringValue("ListEntitiesForPolicy.RequestId");

			List<ListEntitiesForPolicyResponse.ListEntitiesForPolicy_Group> listEntitiesForPolicyResponse_groups = new List<ListEntitiesForPolicyResponse.ListEntitiesForPolicy_Group>();
			for (int i = 0; i < _ctx.Length("ListEntitiesForPolicy.Groups.Length"); i++) {
				ListEntitiesForPolicyResponse.ListEntitiesForPolicy_Group group = new ListEntitiesForPolicyResponse.ListEntitiesForPolicy_Group();
				group.GroupName = _ctx.StringValue("ListEntitiesForPolicy.Groups["+ i +"].GroupName");
				group.Comments = _ctx.StringValue("ListEntitiesForPolicy.Groups["+ i +"].Comments");
				group.AttachDate = _ctx.StringValue("ListEntitiesForPolicy.Groups["+ i +"].AttachDate");

				listEntitiesForPolicyResponse_groups.Add(group);
			}
			listEntitiesForPolicyResponse.Groups = listEntitiesForPolicyResponse_groups;

			List<ListEntitiesForPolicyResponse.ListEntitiesForPolicy_Role> listEntitiesForPolicyResponse_roles = new List<ListEntitiesForPolicyResponse.ListEntitiesForPolicy_Role>();
			for (int i = 0; i < _ctx.Length("ListEntitiesForPolicy.Roles.Length"); i++) {
				ListEntitiesForPolicyResponse.ListEntitiesForPolicy_Role role = new ListEntitiesForPolicyResponse.ListEntitiesForPolicy_Role();
				role.Description = _ctx.StringValue("ListEntitiesForPolicy.Roles["+ i +"].Description");
				role.RoleName = _ctx.StringValue("ListEntitiesForPolicy.Roles["+ i +"].RoleName");
				role.AttachDate = _ctx.StringValue("ListEntitiesForPolicy.Roles["+ i +"].AttachDate");
				role.Arn = _ctx.StringValue("ListEntitiesForPolicy.Roles["+ i +"].Arn");
				role.RoleId = _ctx.StringValue("ListEntitiesForPolicy.Roles["+ i +"].RoleId");

				listEntitiesForPolicyResponse_roles.Add(role);
			}
			listEntitiesForPolicyResponse.Roles = listEntitiesForPolicyResponse_roles;

			List<ListEntitiesForPolicyResponse.ListEntitiesForPolicy_User> listEntitiesForPolicyResponse_users = new List<ListEntitiesForPolicyResponse.ListEntitiesForPolicy_User>();
			for (int i = 0; i < _ctx.Length("ListEntitiesForPolicy.Users.Length"); i++) {
				ListEntitiesForPolicyResponse.ListEntitiesForPolicy_User user = new ListEntitiesForPolicyResponse.ListEntitiesForPolicy_User();
				user.DisplayName = _ctx.StringValue("ListEntitiesForPolicy.Users["+ i +"].DisplayName");
				user.UserId = _ctx.StringValue("ListEntitiesForPolicy.Users["+ i +"].UserId");
				user.UserName = _ctx.StringValue("ListEntitiesForPolicy.Users["+ i +"].UserName");
				user.AttachDate = _ctx.StringValue("ListEntitiesForPolicy.Users["+ i +"].AttachDate");

				listEntitiesForPolicyResponse_users.Add(user);
			}
			listEntitiesForPolicyResponse.Users = listEntitiesForPolicyResponse_users;
        
			return listEntitiesForPolicyResponse;
        }
    }
}
