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
    public class ModifyTenantUserRolesResponseUnmarshaller
    {
        public static ModifyTenantUserRolesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyTenantUserRolesResponse modifyTenantUserRolesResponse = new ModifyTenantUserRolesResponse();

			modifyTenantUserRolesResponse.HttpResponse = _ctx.HttpResponse;
			modifyTenantUserRolesResponse.RequestId = _ctx.StringValue("ModifyTenantUserRoles.RequestId");

			ModifyTenantUserRolesResponse.ModifyTenantUserRoles_TenantUser tenantUser = new ModifyTenantUserRolesResponse.ModifyTenantUserRoles_TenantUser();
			tenantUser.UserName = _ctx.StringValue("ModifyTenantUserRoles.TenantUser.UserName");
			tenantUser.TenantId = _ctx.StringValue("ModifyTenantUserRoles.TenantUser.TenantId");

			List<ModifyTenantUserRolesResponse.ModifyTenantUserRoles_TenantUser.ModifyTenantUserRoles_UserRoleItem> tenantUser_userRole = new List<ModifyTenantUserRolesResponse.ModifyTenantUserRoles_TenantUser.ModifyTenantUserRoles_UserRoleItem>();
			for (int i = 0; i < _ctx.Length("ModifyTenantUserRoles.TenantUser.UserRole.Length"); i++) {
				ModifyTenantUserRolesResponse.ModifyTenantUserRoles_TenantUser.ModifyTenantUserRoles_UserRoleItem userRoleItem = new ModifyTenantUserRolesResponse.ModifyTenantUserRoles_TenantUser.ModifyTenantUserRoles_UserRoleItem();
				userRoleItem.Database = _ctx.StringValue("ModifyTenantUserRoles.TenantUser.UserRole["+ i +"].Database");
				userRoleItem.Role = _ctx.StringValue("ModifyTenantUserRoles.TenantUser.UserRole["+ i +"].Role");
				userRoleItem.Table = _ctx.StringValue("ModifyTenantUserRoles.TenantUser.UserRole["+ i +"].Table");
				userRoleItem.IsSuccess = _ctx.BooleanValue("ModifyTenantUserRoles.TenantUser.UserRole["+ i +"].IsSuccess");

				tenantUser_userRole.Add(userRoleItem);
			}
			tenantUser.UserRole = tenantUser_userRole;
			modifyTenantUserRolesResponse.TenantUser = tenantUser;
        
			return modifyTenantUserRolesResponse;
        }
    }
}
