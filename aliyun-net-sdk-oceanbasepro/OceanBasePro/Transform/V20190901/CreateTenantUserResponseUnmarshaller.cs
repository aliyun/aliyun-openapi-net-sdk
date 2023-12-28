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
    public class CreateTenantUserResponseUnmarshaller
    {
        public static CreateTenantUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTenantUserResponse createTenantUserResponse = new CreateTenantUserResponse();

			createTenantUserResponse.HttpResponse = _ctx.HttpResponse;
			createTenantUserResponse.RequestId = _ctx.StringValue("CreateTenantUser.RequestId");

			CreateTenantUserResponse.CreateTenantUser_TenantUser tenantUser = new CreateTenantUserResponse.CreateTenantUser_TenantUser();
			tenantUser.UserType = _ctx.StringValue("CreateTenantUser.TenantUser.UserType");
			tenantUser.UserStatus = _ctx.StringValue("CreateTenantUser.TenantUser.UserStatus");
			tenantUser.UserName = _ctx.StringValue("CreateTenantUser.TenantUser.UserName");

			List<CreateTenantUserResponse.CreateTenantUser_TenantUser.CreateTenantUser_RolesItem> tenantUser_roles = new List<CreateTenantUserResponse.CreateTenantUser_TenantUser.CreateTenantUser_RolesItem>();
			for (int i = 0; i < _ctx.Length("CreateTenantUser.TenantUser.Roles.Length"); i++) {
				CreateTenantUserResponse.CreateTenantUser_TenantUser.CreateTenantUser_RolesItem rolesItem = new CreateTenantUserResponse.CreateTenantUser_TenantUser.CreateTenantUser_RolesItem();
				rolesItem.Database = _ctx.StringValue("CreateTenantUser.TenantUser.Roles["+ i +"].Database");
				rolesItem.Role = _ctx.StringValue("CreateTenantUser.TenantUser.Roles["+ i +"].Role");

				tenantUser_roles.Add(rolesItem);
			}
			tenantUser.Roles = tenantUser_roles;
			createTenantUserResponse.TenantUser = tenantUser;
        
			return createTenantUserResponse;
        }
    }
}
