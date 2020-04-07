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
    public class ListRolesResponseUnmarshaller
    {
        public static ListRolesResponse Unmarshall(UnmarshallerContext context)
        {
			ListRolesResponse listRolesResponse = new ListRolesResponse();

			listRolesResponse.HttpResponse = context.HttpResponse;
			listRolesResponse.RequestId = context.StringValue("ListRoles.RequestId");
			listRolesResponse.IsTruncated = context.BooleanValue("ListRoles.IsTruncated");
			listRolesResponse.Marker = context.StringValue("ListRoles.Marker");

			List<ListRolesResponse.ListRoles_Role> listRolesResponse_roles = new List<ListRolesResponse.ListRoles_Role>();
			for (int i = 0; i < context.Length("ListRoles.Roles.Length"); i++) {
				ListRolesResponse.ListRoles_Role role = new ListRolesResponse.ListRoles_Role();
				role.RoleId = context.StringValue("ListRoles.Roles["+ i +"].RoleId");
				role.RoleName = context.StringValue("ListRoles.Roles["+ i +"].RoleName");
				role.Arn = context.StringValue("ListRoles.Roles["+ i +"].Arn");
				role.Description = context.StringValue("ListRoles.Roles["+ i +"].Description");
				role.CreateDate = context.StringValue("ListRoles.Roles["+ i +"].CreateDate");
				role.UpdateDate = context.StringValue("ListRoles.Roles["+ i +"].UpdateDate");
				role.MaxSessionDuration = context.LongValue("ListRoles.Roles["+ i +"].MaxSessionDuration");

				listRolesResponse_roles.Add(role);
			}
			listRolesResponse.Roles = listRolesResponse_roles;
        
			return listRolesResponse;
        }
    }
}
