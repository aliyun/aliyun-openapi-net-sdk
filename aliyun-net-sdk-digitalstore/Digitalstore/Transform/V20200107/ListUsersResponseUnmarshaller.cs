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
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext context)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = context.HttpResponse;
			listUsersResponse.PageSize = context.IntegerValue("ListUsers.PageSize");
			listUsersResponse.TotalCount = context.IntegerValue("ListUsers.TotalCount");
			listUsersResponse.PageNumber = context.IntegerValue("ListUsers.PageNumber");
			listUsersResponse.RequestId = context.StringValue("ListUsers.RequestId");
			listUsersResponse.Success = context.BooleanValue("ListUsers.Success");

			List<ListUsersResponse.ListUsers_SysUserModel> listUsersResponse_users = new List<ListUsersResponse.ListUsers_SysUserModel>();
			for (int i = 0; i < context.Length("ListUsers.Users.Length"); i++) {
				ListUsersResponse.ListUsers_SysUserModel sysUserModel = new ListUsersResponse.ListUsers_SysUserModel();
				sysUserModel.Mail = context.StringValue("ListUsers.Users["+ i +"].Mail");
				sysUserModel.AliyunAccount = context.StringValue("ListUsers.Users["+ i +"].AliyunAccount");
				sysUserModel.Telephone = context.StringValue("ListUsers.Users["+ i +"].Telephone");
				sysUserModel.Remark = context.StringValue("ListUsers.Users["+ i +"].Remark");
				sysUserModel.MerchantId = context.LongValue("ListUsers.Users["+ i +"].MerchantId");
				sysUserModel.UserName = context.StringValue("ListUsers.Users["+ i +"].UserName");
				sysUserModel.Status = context.IntegerValue("ListUsers.Users["+ i +"].Status");
				sysUserModel.UserId = context.LongValue("ListUsers.Users["+ i +"].UserId");

				List<ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel> sysUserModel_stores = new List<ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel>();
				for (int j = 0; j < context.Length("ListUsers.Users["+ i +"].Stores.Length"); j++) {
					ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel sysUserUnitModel = new ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel();
					sysUserUnitModel.UnitName = context.StringValue("ListUsers.Users["+ i +"].Stores["+ j +"].UnitName");
					sysUserUnitModel.UnitId = context.StringValue("ListUsers.Users["+ i +"].Stores["+ j +"].UnitId");

					sysUserModel_stores.Add(sysUserUnitModel);
				}
				sysUserModel.Stores = sysUserModel_stores;

				List<ListUsersResponse.ListUsers_SysUserModel.ListUsers_UserRoleModel> sysUserModel_roles = new List<ListUsersResponse.ListUsers_SysUserModel.ListUsers_UserRoleModel>();
				for (int j = 0; j < context.Length("ListUsers.Users["+ i +"].Roles.Length"); j++) {
					ListUsersResponse.ListUsers_SysUserModel.ListUsers_UserRoleModel userRoleModel = new ListUsersResponse.ListUsers_SysUserModel.ListUsers_UserRoleModel();
					userRoleModel.RoleId = context.IntegerValue("ListUsers.Users["+ i +"].Roles["+ j +"].RoleId");
					userRoleModel.RoleName = context.StringValue("ListUsers.Users["+ i +"].Roles["+ j +"].RoleName");
					userRoleModel.Status = context.IntegerValue("ListUsers.Users["+ i +"].Roles["+ j +"].Status");

					sysUserModel_roles.Add(userRoleModel);
				}
				sysUserModel.Roles = sysUserModel_roles;

				List<ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel> sysUserModel_warehouses = new List<ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel>();
				for (int j = 0; j < context.Length("ListUsers.Users["+ i +"].Warehouses.Length"); j++) {
					ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel sysUserUnitModel = new ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel();
					sysUserUnitModel.UnitName = context.StringValue("ListUsers.Users["+ i +"].Warehouses["+ j +"].UnitName");
					sysUserUnitModel.UnitId = context.StringValue("ListUsers.Users["+ i +"].Warehouses["+ j +"].UnitId");

					sysUserModel_warehouses.Add(sysUserUnitModel);
				}
				sysUserModel.Warehouses = sysUserModel_warehouses;

				List<ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel> sysUserModel_factories = new List<ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel>();
				for (int j = 0; j < context.Length("ListUsers.Users["+ i +"].Factories.Length"); j++) {
					ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel sysUserUnitModel = new ListUsersResponse.ListUsers_SysUserModel.ListUsers_SysUserUnitModel();
					sysUserUnitModel.UnitName = context.StringValue("ListUsers.Users["+ i +"].Factories["+ j +"].UnitName");
					sysUserUnitModel.UnitId = context.StringValue("ListUsers.Users["+ i +"].Factories["+ j +"].UnitId");

					sysUserModel_factories.Add(sysUserUnitModel);
				}
				sysUserModel.Factories = sysUserModel_factories;

				listUsersResponse_users.Add(sysUserModel);
			}
			listUsersResponse.Users = listUsersResponse_users;
        
			return listUsersResponse;
        }
    }
}
