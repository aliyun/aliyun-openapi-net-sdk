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

			List<CreateTenantUserResponse.CreateTenantUser_Data> createTenantUserResponse_tenantUser = new List<CreateTenantUserResponse.CreateTenantUser_Data>();
			for (int i = 0; i < _ctx.Length("CreateTenantUser.TenantUser.Length"); i++) {
				CreateTenantUserResponse.CreateTenantUser_Data data = new CreateTenantUserResponse.CreateTenantUser_Data();
				data.UserType = _ctx.StringValue("CreateTenantUser.TenantUser["+ i +"].UserType");
				data.UserStatus = _ctx.StringValue("CreateTenantUser.TenantUser["+ i +"].UserStatus");
				data.UserName = _ctx.StringValue("CreateTenantUser.TenantUser["+ i +"].UserName");

				List<CreateTenantUserResponse.CreateTenantUser_Data.CreateTenantUser_RolesItem> data_roles = new List<CreateTenantUserResponse.CreateTenantUser_Data.CreateTenantUser_RolesItem>();
				for (int j = 0; j < _ctx.Length("CreateTenantUser.TenantUser["+ i +"].Roles.Length"); j++) {
					CreateTenantUserResponse.CreateTenantUser_Data.CreateTenantUser_RolesItem rolesItem = new CreateTenantUserResponse.CreateTenantUser_Data.CreateTenantUser_RolesItem();
					rolesItem.Database = _ctx.StringValue("CreateTenantUser.TenantUser["+ i +"].Roles["+ j +"].Database");
					rolesItem.Role = _ctx.StringValue("CreateTenantUser.TenantUser["+ i +"].Roles["+ j +"].Role");

					data_roles.Add(rolesItem);
				}
				data.Roles = data_roles;

				createTenantUserResponse_tenantUser.Add(data);
			}
			createTenantUserResponse.TenantUser = createTenantUserResponse_tenantUser;
        
			return createTenantUserResponse;
        }
    }
}
