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
    public class ListWorkspaceRolesResponseUnmarshaller
    {
        public static ListWorkspaceRolesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWorkspaceRolesResponse listWorkspaceRolesResponse = new ListWorkspaceRolesResponse();

			listWorkspaceRolesResponse.HttpResponse = _ctx.HttpResponse;
			listWorkspaceRolesResponse.RequestId = _ctx.StringValue("ListWorkspaceRoles.RequestId");
			listWorkspaceRolesResponse.Success = _ctx.BooleanValue("ListWorkspaceRoles.Success");

			List<ListWorkspaceRolesResponse.ListWorkspaceRoles_Data> listWorkspaceRolesResponse_result = new List<ListWorkspaceRolesResponse.ListWorkspaceRoles_Data>();
			for (int i = 0; i < _ctx.Length("ListWorkspaceRoles.Result.Length"); i++) {
				ListWorkspaceRolesResponse.ListWorkspaceRoles_Data data = new ListWorkspaceRolesResponse.ListWorkspaceRoles_Data();
				data.IsSystemRole = _ctx.BooleanValue("ListWorkspaceRoles.Result["+ i +"].IsSystemRole");
				data.RoleId = _ctx.LongValue("ListWorkspaceRoles.Result["+ i +"].RoleId");
				data.RoleName = _ctx.StringValue("ListWorkspaceRoles.Result["+ i +"].RoleName");

				List<ListWorkspaceRolesResponse.ListWorkspaceRoles_Data.ListWorkspaceRoles_AuthConfigListItem> data_authConfigList = new List<ListWorkspaceRolesResponse.ListWorkspaceRoles_Data.ListWorkspaceRoles_AuthConfigListItem>();
				for (int j = 0; j < _ctx.Length("ListWorkspaceRoles.Result["+ i +"].AuthConfigList.Length"); j++) {
					ListWorkspaceRolesResponse.ListWorkspaceRoles_Data.ListWorkspaceRoles_AuthConfigListItem authConfigListItem = new ListWorkspaceRolesResponse.ListWorkspaceRoles_Data.ListWorkspaceRoles_AuthConfigListItem();
					authConfigListItem.AuthKey = _ctx.StringValue("ListWorkspaceRoles.Result["+ i +"].AuthConfigList["+ j +"].AuthKey");

					List<string> authConfigListItem_actionAuthKeys = new List<string>();
					for (int k = 0; k < _ctx.Length("ListWorkspaceRoles.Result["+ i +"].AuthConfigList["+ j +"].ActionAuthKeys.Length"); k++) {
						authConfigListItem_actionAuthKeys.Add(_ctx.StringValue("ListWorkspaceRoles.Result["+ i +"].AuthConfigList["+ j +"].ActionAuthKeys["+ k +"]"));
					}
					authConfigListItem.ActionAuthKeys = authConfigListItem_actionAuthKeys;

					data_authConfigList.Add(authConfigListItem);
				}
				data.AuthConfigList = data_authConfigList;

				listWorkspaceRolesResponse_result.Add(data);
			}
			listWorkspaceRolesResponse.Result = listWorkspaceRolesResponse_result;
        
			return listWorkspaceRolesResponse;
        }
    }
}
