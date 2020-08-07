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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListProjectRolesResponseUnmarshaller
    {
        public static ListProjectRolesResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectRolesResponse listProjectRolesResponse = new ListProjectRolesResponse();

			listProjectRolesResponse.HttpResponse = context.HttpResponse;
			listProjectRolesResponse.RequestId = context.StringValue("ListProjectRoles.RequestId");

			List<ListProjectRolesResponse.ListProjectRoles_Role> listProjectRolesResponse_projectRoleList = new List<ListProjectRolesResponse.ListProjectRoles_Role>();
			for (int i = 0; i < context.Length("ListProjectRoles.ProjectRoleList.Length"); i++) {
				ListProjectRolesResponse.ListProjectRoles_Role role = new ListProjectRolesResponse.ListProjectRoles_Role();
				role.ProjectRoleCode = context.StringValue("ListProjectRoles.ProjectRoleList["+ i +"].ProjectRoleCode");
				role.ProjectRoleId = context.IntegerValue("ListProjectRoles.ProjectRoleList["+ i +"].ProjectRoleId");
				role.ProjectRoleName = context.StringValue("ListProjectRoles.ProjectRoleList["+ i +"].ProjectRoleName");
				role.ProjectRoleType = context.StringValue("ListProjectRoles.ProjectRoleList["+ i +"].ProjectRoleType");

				listProjectRolesResponse_projectRoleList.Add(role);
			}
			listProjectRolesResponse.ProjectRoleList = listProjectRolesResponse_projectRoleList;
        
			return listProjectRolesResponse;
        }
    }
}
