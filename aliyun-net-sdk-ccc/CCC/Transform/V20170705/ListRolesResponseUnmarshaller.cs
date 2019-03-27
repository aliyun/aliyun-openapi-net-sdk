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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListRolesResponseUnmarshaller
    {
        public static ListRolesResponse Unmarshall(UnmarshallerContext context)
        {
			ListRolesResponse listRolesResponse = new ListRolesResponse();

			listRolesResponse.HttpResponse = context.HttpResponse;
			listRolesResponse.RequestId = context.StringValue("ListRoles.RequestId");
			listRolesResponse.Success = context.BooleanValue("ListRoles.Success");
			listRolesResponse.Code = context.StringValue("ListRoles.Code");
			listRolesResponse.Message = context.StringValue("ListRoles.Message");
			listRolesResponse.HttpStatusCode = context.IntegerValue("ListRoles.HttpStatusCode");

			List<ListRolesResponse.ListRoles_Role> listRolesResponse_roles = new List<ListRolesResponse.ListRoles_Role>();
			for (int i = 0; i < context.Length("ListRoles.Roles.Length"); i++) {
				ListRolesResponse.ListRoles_Role role = new ListRolesResponse.ListRoles_Role();
				role.RoleId = context.StringValue("ListRoles.Roles["+ i +"].RoleId");
				role.InstanceId = context.StringValue("ListRoles.Roles["+ i +"].InstanceId");
				role.RoleName = context.StringValue("ListRoles.Roles["+ i +"].RoleName");
				role.RoleDescription = context.StringValue("ListRoles.Roles["+ i +"].RoleDescription");

				listRolesResponse_roles.Add(role);
			}
			listRolesResponse.Roles = listRolesResponse_roles;
        
			return listRolesResponse;
        }
    }
}
