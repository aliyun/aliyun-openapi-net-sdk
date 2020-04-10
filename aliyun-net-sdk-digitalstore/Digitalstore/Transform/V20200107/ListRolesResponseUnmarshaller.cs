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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListRolesResponseUnmarshaller
    {
        public static ListRolesResponse Unmarshall(UnmarshallerContext context)
        {
			ListRolesResponse listRolesResponse = new ListRolesResponse();

			listRolesResponse.HttpResponse = context.HttpResponse;
			listRolesResponse.PageSize = context.IntegerValue("ListRoles.PageSize");
			listRolesResponse.TotalCount = context.IntegerValue("ListRoles.TotalCount");
			listRolesResponse.PageNumber = context.IntegerValue("ListRoles.PageNumber");
			listRolesResponse.RequestId = context.StringValue("ListRoles.RequestId");
			listRolesResponse.Success = context.BooleanValue("ListRoles.Success");

			List<ListRolesResponse.ListRoles_SysRoleModel> listRolesResponse_roles = new List<ListRolesResponse.ListRoles_SysRoleModel>();
			for (int i = 0; i < context.Length("ListRoles.Roles.Length"); i++) {
				ListRolesResponse.ListRoles_SysRoleModel sysRoleModel = new ListRolesResponse.ListRoles_SysRoleModel();
				sysRoleModel.MerchantId = context.LongValue("ListRoles.Roles["+ i +"].MerchantId");
				sysRoleModel.RoleId = context.IntegerValue("ListRoles.Roles["+ i +"].RoleId");
				sysRoleModel.Remark = context.StringValue("ListRoles.Roles["+ i +"].Remark");
				sysRoleModel.Name = context.StringValue("ListRoles.Roles["+ i +"].Name");
				sysRoleModel.Status = context.IntegerValue("ListRoles.Roles["+ i +"].Status");

				List<ListRolesResponse.ListRoles_SysRoleModel.ListRoles_BaseModel> sysRoleModel_apis = new List<ListRolesResponse.ListRoles_SysRoleModel.ListRoles_BaseModel>();
				for (int j = 0; j < context.Length("ListRoles.Roles["+ i +"].Apis.Length"); j++) {
					ListRolesResponse.ListRoles_SysRoleModel.ListRoles_BaseModel baseModel = new ListRolesResponse.ListRoles_SysRoleModel.ListRoles_BaseModel();
					baseModel.Id = context.IntegerValue("ListRoles.Roles["+ i +"].Apis["+ j +"].Id");
					baseModel.Name = context.StringValue("ListRoles.Roles["+ i +"].Apis["+ j +"].Name");
					baseModel.Code = context.StringValue("ListRoles.Roles["+ i +"].Apis["+ j +"].Code");

					sysRoleModel_apis.Add(baseModel);
				}
				sysRoleModel.Apis = sysRoleModel_apis;

				List<ListRolesResponse.ListRoles_SysRoleModel.ListRoles_BaseModel> sysRoleModel_menus = new List<ListRolesResponse.ListRoles_SysRoleModel.ListRoles_BaseModel>();
				for (int j = 0; j < context.Length("ListRoles.Roles["+ i +"].Menus.Length"); j++) {
					ListRolesResponse.ListRoles_SysRoleModel.ListRoles_BaseModel baseModel = new ListRolesResponse.ListRoles_SysRoleModel.ListRoles_BaseModel();
					baseModel.Id = context.IntegerValue("ListRoles.Roles["+ i +"].Menus["+ j +"].Id");
					baseModel.Name = context.StringValue("ListRoles.Roles["+ i +"].Menus["+ j +"].Name");
					baseModel.Code = context.StringValue("ListRoles.Roles["+ i +"].Menus["+ j +"].Code");

					sysRoleModel_menus.Add(baseModel);
				}
				sysRoleModel.Menus = sysRoleModel_menus;

				listRolesResponse_roles.Add(sysRoleModel);
			}
			listRolesResponse.Roles = listRolesResponse_roles;
        
			return listRolesResponse;
        }
    }
}
