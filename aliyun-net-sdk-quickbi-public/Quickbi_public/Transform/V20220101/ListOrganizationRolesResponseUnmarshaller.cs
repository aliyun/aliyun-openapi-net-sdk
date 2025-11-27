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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ListOrganizationRolesResponseUnmarshaller
    {
        public static ListOrganizationRolesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOrganizationRolesResponse listOrganizationRolesResponse = new ListOrganizationRolesResponse();

			listOrganizationRolesResponse.HttpResponse = _ctx.HttpResponse;
			listOrganizationRolesResponse.RequestId = _ctx.StringValue("ListOrganizationRoles.RequestId");
			listOrganizationRolesResponse.Success = _ctx.BooleanValue("ListOrganizationRoles.Success");

			List<ListOrganizationRolesResponse.ListOrganizationRoles_Data> listOrganizationRolesResponse_result = new List<ListOrganizationRolesResponse.ListOrganizationRoles_Data>();
			for (int i = 0; i < _ctx.Length("ListOrganizationRoles.Result.Length"); i++) {
				ListOrganizationRolesResponse.ListOrganizationRoles_Data data = new ListOrganizationRolesResponse.ListOrganizationRoles_Data();
				data.IsSystemRole = _ctx.BooleanValue("ListOrganizationRoles.Result["+ i +"].IsSystemRole");
				data.RoleId = _ctx.LongValue("ListOrganizationRoles.Result["+ i +"].RoleId");
				data.RoleName = _ctx.StringValue("ListOrganizationRoles.Result["+ i +"].RoleName");

				List<ListOrganizationRolesResponse.ListOrganizationRoles_Data.ListOrganizationRoles_AuthConfigListItem> data_authConfigList = new List<ListOrganizationRolesResponse.ListOrganizationRoles_Data.ListOrganizationRoles_AuthConfigListItem>();
				for (int j = 0; j < _ctx.Length("ListOrganizationRoles.Result["+ i +"].AuthConfigList.Length"); j++) {
					ListOrganizationRolesResponse.ListOrganizationRoles_Data.ListOrganizationRoles_AuthConfigListItem authConfigListItem = new ListOrganizationRolesResponse.ListOrganizationRoles_Data.ListOrganizationRoles_AuthConfigListItem();
					authConfigListItem.AuthKey = _ctx.StringValue("ListOrganizationRoles.Result["+ i +"].AuthConfigList["+ j +"].AuthKey");

					data_authConfigList.Add(authConfigListItem);
				}
				data.AuthConfigList = data_authConfigList;

				listOrganizationRolesResponse_result.Add(data);
			}
			listOrganizationRolesResponse.Result = listOrganizationRolesResponse_result;
        
			return listOrganizationRolesResponse;
        }
    }
}
