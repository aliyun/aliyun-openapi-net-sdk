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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class ModifyDatabaseUserRolesResponseUnmarshaller
    {
        public static ModifyDatabaseUserRolesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyDatabaseUserRolesResponse modifyDatabaseUserRolesResponse = new ModifyDatabaseUserRolesResponse();

			modifyDatabaseUserRolesResponse.HttpResponse = _ctx.HttpResponse;
			modifyDatabaseUserRolesResponse.RequestId = _ctx.StringValue("ModifyDatabaseUserRoles.RequestId");

			ModifyDatabaseUserRolesResponse.ModifyDatabaseUserRoles_TenantUser tenantUser = new ModifyDatabaseUserRolesResponse.ModifyDatabaseUserRoles_TenantUser();
			tenantUser.DatabaseName = _ctx.StringValue("ModifyDatabaseUserRoles.TenantUser.DatabaseName");
			tenantUser.TenantId = _ctx.StringValue("ModifyDatabaseUserRoles.TenantUser.TenantId");

			List<ModifyDatabaseUserRolesResponse.ModifyDatabaseUserRoles_TenantUser.ModifyDatabaseUserRoles_UserRole> tenantUser_users = new List<ModifyDatabaseUserRolesResponse.ModifyDatabaseUserRoles_TenantUser.ModifyDatabaseUserRoles_UserRole>();
			for (int i = 0; i < _ctx.Length("ModifyDatabaseUserRoles.TenantUser.Users.Length"); i++) {
				ModifyDatabaseUserRolesResponse.ModifyDatabaseUserRoles_TenantUser.ModifyDatabaseUserRoles_UserRole userRole = new ModifyDatabaseUserRolesResponse.ModifyDatabaseUserRoles_TenantUser.ModifyDatabaseUserRoles_UserRole();
				userRole.Role = _ctx.StringValue("ModifyDatabaseUserRoles.TenantUser.Users["+ i +"].Role");
				userRole.UserName = _ctx.StringValue("ModifyDatabaseUserRoles.TenantUser.Users["+ i +"].UserName");

				tenantUser_users.Add(userRole);
			}
			tenantUser.Users = tenantUser_users;
			modifyDatabaseUserRolesResponse.TenantUser = tenantUser;
        
			return modifyDatabaseUserRolesResponse;
        }
    }
}
